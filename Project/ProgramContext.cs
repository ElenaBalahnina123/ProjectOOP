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
    /// <summary>
    /// Класс хранит в себе информацию о состоянии приложения, такую как список открытых форм, текущий пользователь и тд.
    /// </summary>
    public class ProgramContext : ApplicationContext
    {
        /// <summary>
        /// IHost - контейнер зависимостей. 
        /// Инкапсулирует внутри себя логику создания и хранения экземпляров классов.
        /// </summary>
        private readonly IHost host;

        private readonly List<Form> formsRegistry = new();

        /// <summary>
        /// Флаг того, что в данный момент можно выполнять выход из программы
        /// </summary>
        private bool exitAllowed = true;

        /// <summary>
        /// Флаг того, что в данный момент выполняется завершение программы
        /// </summary>
        private bool disposing = false;

        public ProgramContext() 
        {
            // Настраиваем контейнер зависимостей
            host = Host.CreateDefaultBuilder()
                .ConfigureServices((_, services) =>
                    services
                    .AddSingleton<AppDbContext>()  // AddSingleton говорит контейнеру, что экземпляр AppDbContext должен быть создан только один раз
                    .AddSingleton(this) // добавляем текущий экземпляр ProgramContext в контейнер в виде синглтона, чтобы его можно было подставить в нужные места
                                        // (например в конструкторы, если там указан ProgramContext)
                    .AddTransient<LoginForm>() // AddTransient говорит контейнеру, что на каждый запрос зависимости указанного типа нужно создавать новый экземпляр
                    .AddTransient<ProductionForm>()
                    .AddTransient<EmployeeListForm>()
                    .AddTransient<MaterialListForm>()
                    .AddTransient<MaterialEditorForm>()
                    .AddTransient<ColorListForm>()
                    .AddTransient<ColorEditor>()
                    .AddTransient<DirectorForm>()
                    .AddTransient<EmployeeEditorForm>()
                    .AddTransient<DesignerForm>()
                    .AddTransient<SketchArtEditorForm>()
                    .AddTransient<SewingEditorForm>()
                    .AddTransient<CuttingEditorForm>()
                    .AddTransient<BlueprintEditorForm>()
                    .AddTransient<MaterialsSelectorForm>()
                    .AddTransient<DesignerForm>()
                ).Build();

            host.StartAsync();

            OnStart();
        }

        /// <summary>
        /// Пользователь, который авторизован на данный момент в программе
        /// </summary>
        public Employee employee { get; private set; }

        // уберите. Про internal лучше рассказать если спросят. То же самое что писать в комментах что такое int и bool. Лучше добавить что именно делает метод EditEmployee
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
            var existing = await host.Services.GetRequiredService<AppDbContext>().Employees.FindAsync(e.ID);  ///???
            if (existing == null)
            {
                Debug.WriteLine("cannot find employee in host.Services.GetRequiredService<AppDbContext>(), return");
                return;
            }
            //Запись обеспечивает доступ к информации об отслеживании изменений и операциям для объекта.
            host.Services.GetRequiredService<AppDbContext>().Entry(existing).CurrentValues.SetValues(e);
            Debug.WriteLine("saving changes");
            host.Services.GetRequiredService<AppDbContext>().SaveChanges();
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

            var existing = await host.Services.GetRequiredService<AppDbContext>().Colors.FindAsync(c.ID);
            if (existing == null)
            {
                Debug.WriteLine("cannot find colors in host.Services.GetRequiredService<AppDbContext>(), return");
                return;
            }

            host.Services.GetRequiredService<AppDbContext>().Entry(existing).CurrentValues.SetValues(c);
            Debug.WriteLine("saving changes");
            host.Services.GetRequiredService<AppDbContext>().SaveChanges();
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

            var existing = await host.Services.GetRequiredService<AppDbContext>().Materials.FindAsync(c.ID);
            if (existing == null)
            {
                Debug.WriteLine("cannot find material in host.Services.GetRequiredService<AppDbContext>(), return");
                return;
            }

            host.Services.GetRequiredService<AppDbContext>().Entry(existing).CurrentValues.SetValues(c);
            Debug.WriteLine("saving changes");
            host.Services.GetRequiredService<AppDbContext>().SaveChanges();
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

        internal async Task EditCutting(Product product)
        {
            var cut = await CreateForm<CuttingEditorForm>().SetCutting(product.Cut).CutAsync(showModal: true);
            if (cut == null)
            {
                Debug.WriteLine("cutting edit cancelled");
                return;
            }
            product.Cut = cut;
            host.Services.GetRequiredService<AppDbContext>().SaveChanges();
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
            host.Services.GetRequiredService<AppDbContext>().SaveChanges();
        }

        internal void QualityControlPassed(Product product)
        {
            product.QaPassed = true;
            host.Services.GetRequiredService<AppDbContext>().SaveChanges();
        }

        internal async Task ConvertFromSketchToBlueprint(Product product)
        {
            if (product.Blueprint != null) return;

            var blueprint = await CreateForm<BlueprintEditorForm>().BlueprintAsync(product);

            if (blueprint == null) return;

            //создался технический эскиз
            host.Services.GetRequiredService<AppDbContext>().Blueprints.Add(blueprint);
            host.Services.GetRequiredService<AppDbContext>().SaveChanges();

            //в продукт записан технический эскиз
            host.Services.GetRequiredService<AppDbContext>().Attach(product);
            product.Blueprint = blueprint;
            host.Services.GetRequiredService<AppDbContext>().SaveChanges();
        }

        internal async Task AddNewEmployee()
        {
            var employee = await CreateForm<EmployeeEditorForm>().EmployeeAsync(showModal: true);

            if (employee == null) return;

            host.Services.GetRequiredService<AppDbContext>().Employees.Add(employee);

            await host.Services.GetRequiredService<AppDbContext>().SaveChangesAsync();
        }

        internal async Task EditBlueprint(Product product)
        {
            await CreateForm<BlueprintEditorForm>().BlueprintAsync(product);
        }

        internal async Task AddNewColor()
        {
            var color = await CreateForm<ColorEditor>().ColorAsync(showModal: true);

            if (color == null) return;

            host.Services.GetRequiredService<AppDbContext>().Colors.Add(color);

            await host.Services.GetRequiredService<AppDbContext>().SaveChangesAsync();
        }

        internal async Task CreateSketchAndProduct()
        {
            var sketch = await CreateForm<SketchArtEditorForm>().SketchAsync(showModal: true);

            if (sketch == null) return;

            host.Services.GetRequiredService<AppDbContext>().Sketches.Add(sketch);

            host.Services.GetRequiredService<AppDbContext>().Products.Add(new Product()
            {
                Sketch = sketch
            });

            await host.Services.GetRequiredService<AppDbContext>().SaveChangesAsync();
        }

        internal async Task AddNewMaterial()
        {
            var material = await CreateForm<MaterialEditorForm>().MaterialAsync(showModal: true);

            if (material == null) return;

            host.Services.GetRequiredService<AppDbContext>().Materials.Add(material);

            await host.Services.GetRequiredService<AppDbContext>().SaveChangesAsync();
        }

        private void OnStart()
        {
            // проверяем всех сотрудников в базе данных. Если есть хоть один сотрудник, открываем форму входа. Если нет, показываем форму для добавления информации о сотруднике
            if (host.Services.GetRequiredService<AppDbContext>().Employees.Any())
            {
                ShowForm<LoginForm>();
            }
            else
            {
                Debug.WriteLine("users not found, show editor form");

                // C помощью булевых флагов обрабатываем сценарий, когда в программе не зарегистрирован ни один пользователь
                // а редактор пользователей был закрыт без сохранения.
                // Программа реализована таким образом, чтобы можно было открыать сразу несколько окон,
                // и чтобы программа завершалась после закрытия последнего открытого окна
                // флаг exitAllowed, установленный в false позволяет не выполнять выход из программы после закрытия формы редактора пользователей.
                // данный сценарий нужен для первоначального запуска программы

                exitAllowed = false;
                var editorForm = ShowForm<EmployeeEditorForm>();

                var OnEmployeeReadyHasBeenCalled = false;

                editorForm.OnEmployeeReady += (sender, employee) =>
                {
                    OnEmployeeReadyHasBeenCalled = true;
                    exitAllowed = true;

                    employee.Role = Role.DIRECTOR;
                    host.Services.GetRequiredService<AppDbContext>().Employees.Add(employee);
                    host.Services.GetRequiredService<AppDbContext>().SaveChanges();
                    ShowMainForm(employee);
                    ((Form)sender).Close();
                };
                editorForm.FormClosed += (_, args) =>
                {
                    if (!OnEmployeeReadyHasBeenCalled)
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
            host.Services.GetRequiredService<AppDbContext>().Employees.Remove(employee);
            host.Services.GetRequiredService<AppDbContext>().SaveChanges();
        }

        internal async Task DeleteSketch(Sketch sketch)
        {
            host.Services.GetRequiredService<AppDbContext>().Sketches.Remove(sketch);
            host.Services.GetRequiredService<AppDbContext>().SaveChanges();
        }
        internal async Task DeleteColor(ModelColor color)
        {
            host.Services.GetRequiredService<AppDbContext>().Colors.Remove(color);
            host.Services.GetRequiredService<AppDbContext>().SaveChanges();
        }
        internal async Task DeleteMaterial(Material material)
        {
            host.Services.GetRequiredService<AppDbContext>().Materials.Remove(material);
            host.Services.GetRequiredService<AppDbContext>().SaveChanges();
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
            host.Services.GetRequiredService<AppDbContext>().SaveChanges();
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
