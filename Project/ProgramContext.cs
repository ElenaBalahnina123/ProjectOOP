using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Project.Forms;
using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public class ProgramContext : ApplicationContext
    {

        private readonly IHost host;

        private readonly List<Form> formsRegistry = new();

        private bool exitAllowed = true;

        private bool disposing = false;

        public ProgramContext()
        {
            host = Host.CreateDefaultBuilder()
                .ConfigureServices((_, services) =>
                    services
                    .AddTransient<LoginForm>()
                    .AddTransient<ProductionForm>()
                    .AddTransient<EmployeeListForm>()
                    .AddTransient<ListMaterial>()
                    .AddTransient<MaterialEditorForm>()
                    .AddTransient<ColorListForm>()
                    .AddTransient<ColorEditor>()
                    .AddTransient<DirectorForm>()
                    .AddTransient<EmployeeEditorForm>()
                    .AddSingleton<AppDbContext>()
                    .AddSingleton(this)
                    .AddTransient<DesignerForm>()
                    .AddTransient<SketchArtEditorForm>()
                    .AddTransient<SewingEditorForm>()
                    .AddTransient<CuttingEditorForm>()
                    .AddTransient<BlueprintEditorForm>()
                    .AddTransient<AddMaterials>()
                ).Build();

            host.StartAsync();

            OnStart();
        }

        public Employee employee { get; private set; }
        public ModelColor color { get; private set; }
        public Material material { get; private set; }

        internal async Task EditEmployee(Employee employee)
        {
            var e = await CreateForm<EmployeeEditorForm>().SetEmployee(employee).EmployeeAsync(showModal: true);
            if (e == null)
            {
                Debug.WriteLine("employee edit cancelled");
                return;
            }
            Debug.WriteLine("employee edit complete, saving");

            var db = host.Services.GetRequiredService<AppDbContext>();

            var existing = await db.Employees.FindAsync(e.ID);
            if (existing == null)
            {
                Debug.WriteLine("cannot find employee in db, return");
                return;
            }

            db.Entry(existing).CurrentValues.SetValues(e);
            Debug.WriteLine("saving changes");
            db.SaveChanges();
            Debug.WriteLine("changes saved");
        }
        internal async Task EditColor(ModelColor color)
        {
            var c = await CreateForm<ColorEditor>().SetColor(color).ColorAsync(showModal: true);
            if (c == null)
            {
                Debug.WriteLine("color edit cancelled");
                return;
            }
            Debug.WriteLine("color edit complete, saving");

            var db = host.Services.GetRequiredService<AppDbContext>();

            var existing = await db.Colors.FindAsync(c.ID);
            if (existing == null)
            {
                Debug.WriteLine("cannot find colors in db, return");
                return;
            }

            db.Entry(existing).CurrentValues.SetValues(c);
            Debug.WriteLine("saving changes");
            db.SaveChanges();
            Debug.WriteLine("changes saved");
        }

        internal async Task EditMaterial(Material material)
        {
            var c = await CreateForm<MaterialEditorForm>().SetMaterial(material).MaterialAsync(showModal: true);
            if (c == null)
            {
                Debug.WriteLine("material edit cancelled");
                return;
            }
            Debug.WriteLine("material edit complete, saving");

            var db = host.Services.GetRequiredService<AppDbContext>();

            var existing = await db.Materials.FindAsync(c.ID);
            if (existing == null)
            {
                Debug.WriteLine("cannot find material in db, return");
                return;
            }

            db.Entry(existing).CurrentValues.SetValues(c);
            Debug.WriteLine("saving changes");
            db.SaveChanges();
            Debug.WriteLine("changes saved");
        }

        internal async Task EditSketch(Sketch sketch)
        {
            var s = await CreateForm<SketchArtEditorForm>().SetSketch(sketch).SketchAsync(showModal: true);
            if (s == null)
            {
                Debug.WriteLine("sketch edit cancelled");
                return;
            }
            Debug.WriteLine("sketch edit complete, saving");

            var db = host.Services.GetRequiredService<AppDbContext>();

            var existing = await db.Sketches.FindAsync(s.ID);
            if (existing == null)
            {
                Debug.WriteLine("cannot find sketch in db, return");
                return;
            }

            db.Entry(existing).CurrentValues.SetValues(s);
            Debug.WriteLine("saving changes");
            db.SaveChanges();
            Debug.WriteLine("changes saved");
        }

        internal async Task EditCutting(Cut cut)
        {
            var s = await CreateForm<CuttingEditorForm>().SetCutting(cut).CutAsync(showModal: true);
            if (s == null)
            {
                Debug.WriteLine("cutting edit cancelled");
                return;
            }
            Debug.WriteLine("cutting edit complete, saving");

            var db = host.Services.GetRequiredService<AppDbContext>();

            var existing = await db.Cuts.FindAsync(s.ID);
            if (existing == null)
            {
                Debug.WriteLine("cannot find cutting in db, return");
                return;
            }

            db.Entry(existing).CurrentValues.SetValues(s);
            Debug.WriteLine("saving changes");
            db.SaveChanges();
            Debug.WriteLine("changes saved");
        }

        internal async Task EditSewing(Sewing sewing)
        {
            var s = await CreateForm<SewingEditorForm>().SetSewing(sewing).SewingAsync(showModal: true);
            if (s == null)
            {
                Debug.WriteLine("sewing edit cancelled");
                return;
            }
            Debug.WriteLine("sewing edit complete, saving");

            var db = host.Services.GetRequiredService<AppDbContext>();

            var existing = await db.Cuts.FindAsync(s.ID);
            if (existing == null)
            {
                Debug.WriteLine("cannot find sewing in db, return");
                return;
            }

            db.Entry(existing).CurrentValues.SetValues(s);
            Debug.WriteLine("saving changes");
            db.SaveChanges();
            Debug.WriteLine("changes saved");
        }

        internal async Task ConvertFromSketchToBlueprint(Product product)
        {
            if (product.Blueprint != null) return;
            var blueprint = await ShowForm<BlueprintEditorForm>().BlueprintAsync(product);

            var db = host.Services.GetRequiredService<AppDbContext>();
            db.Blueprints.Add(blueprint);
            db.SaveChanges();

            db.Attach(product);
            product.Blueprint = blueprint;
            db.SaveChanges();
        }

        internal async Task AddNewEmployee()
        {
            var employee = await CreateForm<EmployeeEditorForm>().EmployeeAsync(showModal: true);

            if (employee == null) return;

            var db = host.Services.GetRequiredService<AppDbContext>();
            db.Employees.Add(employee);

            await db.SaveChangesAsync();

            //await ShowFormModal<EmployeeEditorForm>().EmployeeAsync();
        }

        internal async Task AddNewColor()
        {
            var color = await CreateForm<ColorEditor>().ColorAsync(showModal: true);

            if (color == null) return;

            var db = host.Services.GetRequiredService<AppDbContext>();
            db.Colors.Add(color);

            await db.SaveChangesAsync();
        }

        internal async Task CreateSketchAndProduct()
        {
            var sketch = await CreateForm<SketchArtEditorForm>().SketchAsync(showModal: true);

            if (sketch == null) return;

            var db = host.Services.GetRequiredService<AppDbContext>();
            db.Sketches.Add(sketch);

            db.Products.Add(new Product()
            {
                Sketch = sketch
            });
           
            await db.SaveChangesAsync();
        }

        internal async Task AddNewMaterial()
        {
            var material = await CreateForm<MaterialEditorForm>().MaterialAsync(showModal: true);

            if (material == null) return;

            var db = host.Services.GetRequiredService<AppDbContext>();
            db.Materials.Add(material);

            await db.SaveChangesAsync();
        }

        private void OnStart()
        {
            Debug.WriteLine("call onStart");

            var db = host.Services.GetRequiredService<AppDbContext>();

            if (db.Employees.Any())
            {
                Debug.WriteLine("has accounts, show login form");
                ShowForm<LoginForm>();
            }
            else
            {
                Debug.WriteLine("users not found, show editor form");

                exitAllowed = false;
                var editorForm = ShowForm<EmployeeEditorForm>();

                var readyCalled = false;

                editorForm.OnEmployeeReady += (sender, employee) =>
                {
                    readyCalled = true;
                    exitAllowed = true;

                    employee.Role = Role.DIRECTOR;
                    db.Employees.Add(employee);
                    db.SaveChanges();
                    ShowMainForm(employee);
                    ((Form)sender).Close();
                };
                editorForm.FormClosed += (_, args) =>
                {
                    if (!readyCalled)
                    {
                        exitAllowed = true;
                        MessageBox.Show("Требуется хотя бы один пользователь");

                        ExitProgram();
                    }
                };
            }
        }

        internal async Task DeleteEmployee(Employee employee)
        {
            var db = host.Services.GetRequiredService<AppDbContext>();
            db.Employees.Remove(employee);
            db.SaveChanges();
        }

        internal async Task DeleteSketch(Sketch sketch)
        {
            var db = host.Services.GetRequiredService<AppDbContext>();
            db.Sketches.Remove(sketch);
            db.SaveChanges();
        }
        internal async Task DeleteColor(ModelColor color)
        {
            var db = host.Services.GetRequiredService<AppDbContext>();
            db.Colors.Remove(color);
            db.SaveChanges();
        }

        internal async Task DeleteMaterial(Material material)
        {
            var db = host.Services.GetRequiredService<AppDbContext>();
            db.Materials.Remove(material);
            db.SaveChanges();
        }
        private void ExitProgram()
        {
            if (disposing) return;
            disposing = true;

            host.Dispose();
            ExitThread();
        }

        public T CreateForm<T>() where T : Form
        {
            var form = host.Services.GetRequiredService<T>();
            formsRegistry.Add(form);
            form.FormClosed += OnFormClosed;
            return form;
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            var form = (Form)sender;
            if (formsRegistry.Remove(form) && formsRegistry.Count == 0 && exitAllowed)
            {
                ExitProgram();
            }
        }

        public T ShowFormModal<T>() where T : Form
        {
            var form = CreateForm<T>();
            form.ShowDialog();
            return form;
        }

        public T ShowForm<T>() where T : Form
        {
            var form = CreateForm<T>();
            form.Show();
            return form;
        }

        private Form CreateMainForm(Employee employee)
        {
            this.employee = employee;
            switch (employee.Role)
            {
                case Role.DIRECTOR: return CreateForm<DirectorForm>();
                //case Role.DESIGNER: return CreateForm<DesignerForm>();
                default: throw new NotImplementedException("not implemented");
            }
        }

        public void ShowMainForm(Employee employee)
        {
            CreateMainForm(employee).Show();
        }

        public void DoColorEdit()
        {
            ShowForm<ColorListForm>();
        }

        public void ShowEmployerList()
        {
            ShowForm<EmployeeListForm>();
        }

        public void ShowProductionList()
        {
            ShowForm<ProductionForm>();
        }

        public void ShowMaterialList()
        {
            ShowForm<ListMaterial>();
        }

    }
}
