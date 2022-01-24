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
    //ApplicationContext указывает контекстную информацию о потоке приложения
    public class ProgramContext : ApplicationContext
    {

        private readonly IHost host;

        private readonly List<Form> formsRegistry = new();

        private bool exitAllowed = true;

        private bool disposing = false;

        private readonly AppDbContext db;

        public ProgramContext()  //???
        {
            host = Host.CreateDefaultBuilder()
                .ConfigureServices((_, services) =>
                    services
                    .AddTransient<LoginForm>()
                    .AddTransient<ProductionForm>()
                    .AddTransient<EmployeeListForm>()
                    .AddTransient<MaterialListForm>()
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
                    .AddTransient<MaterialsSelectorForm>()
                    .AddTransient<DesignerForm>()
                ).Build();

            host.StartAsync();

            //Получить запрос от сервера
            db = host.Services.GetRequiredService<AppDbContext>();

            OnStart();
        }
        public Employee employee { get; private set; }
        public ModelColor color { get; private set; }
        public Material material { get; private set; }

        //internal: компоненты класса или структуры доступен из любого места кода в той же сборке, однако он недоступен для других программ и сборок.
        internal async Task EditEmployee(Employee employee)
        {
            var e = await CreateForm<EmployeeEditorForm>().SetEmployee(employee).EmployeeAsync(showModal: true);
            if (e == null)
            {
                Debug.WriteLine("employee edit cancelled");
                return;
            }
            Debug.WriteLine("employee edit complete, saving");

            //FindAsync находит сущность с заданными значениями первичного ключа. Если сущность с заданными
            //значениями первичного ключа отслеживается контекстом, то она возвращается немедленно,
            //без запроса к базе данных. В противном случае делается запрос к базе данных.
            var existing = await db.Employees.FindAsync(e.ID);  ///???
            if (existing == null)
            {
                Debug.WriteLine("cannot find employee in db, return");
                return;
            }
            //Запись обеспечивает доступ к информации об отслеживании изменений и операциям для объекта.
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

        internal async Task EditCutting(Product product)
        {
            var cut = await CreateForm<CuttingEditorForm>().SetCutting(product.Cut).CutAsync(showModal: true);
            if (cut == null)
            {
                Debug.WriteLine("cutting edit cancelled");
                return;
            }
            product.Cut = cut;
            db.SaveChanges();
        }

        internal async Task EditSewing(Product product)
        {
            var sewing = await ShowForm<SewingEditorForm>().EditSewingAsync(product);
            if (sewing == null)
            {
                Debug.WriteLine("sewing edit cancelled");
                return;
            }
            Debug.WriteLine("sewing not null");
            product.Sewing = sewing;
            db.SaveChanges();
        }

        internal void QualityControlPassed(Product product)
        {
            product.QaPassed = true;
            db.SaveChanges();
        }

        internal async Task ConvertFromSketchToBlueprint(Product product)
        {
            if (product.Blueprint != null) return;

            var blueprint = await CreateForm<BlueprintEditorForm>().BlueprintAsync(product);

            if (blueprint == null) return;

            //создался технический эскиз
            db.Blueprints.Add(blueprint);
            db.SaveChanges();

            //в продукт записан технический эскиз
            db.Attach(product);
            product.Blueprint = blueprint;
            db.SaveChanges();
        }

        internal async Task AddNewEmployee()
        {
            var employee = await CreateForm<EmployeeEditorForm>().EmployeeAsync(showModal: true);

            if (employee == null) return;

            db.Employees.Add(employee);

            await db.SaveChangesAsync();
        }

        internal async Task EditBlueprint(Product product)
        {
            await CreateForm<BlueprintEditorForm>().BlueprintAsync(product);
        }

        internal async Task AddNewColor()
        {
            var color = await CreateForm<ColorEditor>().ColorAsync(showModal: true);

            if (color == null) return;

            db.Colors.Add(color);

            await db.SaveChangesAsync();
        }

        internal async Task CreateSketchAndProduct()
        {
            var sketch = await CreateForm<SketchArtEditorForm>().SketchAsync(showModal: true);

            if (sketch == null) return;

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

            db.Materials.Add(material);

            await db.SaveChangesAsync();
        }

        private void OnStart()
        {
            // проверяем всех сотрудников в базе данных. Если есть хоть один сотрудник, открываем форму входа. Если нет, показываем форму для добавления информации о сотруднике
            if (db.Employees.Any())
            {
                ShowForm<LoginForm>();
            }
            else
            {
                Debug.WriteLine("users not found, show editor form");

                exitAllowed = false;  //???
                var editorForm = ShowForm<EmployeeEditorForm>();

                var readyCalled = false;

                editorForm.OnEmployeeReady += (sender, employee) =>
                {
                    readyCalled = true;  //???
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
            db.Employees.Remove(employee);
            db.SaveChanges();
        }

        internal async Task DeleteSketch(Sketch sketch)
        {
            db.Sketches.Remove(sketch);
            db.SaveChanges();
        }
        internal async Task DeleteColor(ModelColor color)
        {
            db.Colors.Remove(color);
            db.SaveChanges();
        }
        internal async Task DeleteMaterial(Material material)
        {
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

        internal void SendToCut(Product product)
        {
            product.Sewing = null;
            db.SaveChanges();
        }

        #region "forms"
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
                case Role.DESIGNER: return CreateForm<DesignerForm>();
                default: return CreateForm<ProductionForm>();
            }
        }

        public void ShowMainForm(Employee employee)
        {
            var form = CreateMainForm(employee);
            form.Show();
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
            ShowForm<MaterialListForm>();
        }
        #endregion
    }
}
