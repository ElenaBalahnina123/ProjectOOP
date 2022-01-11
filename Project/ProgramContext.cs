using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
                    .AddTransient<ListEmployee>()
                    .AddTransient<ListMaterial>()
                    .AddTransient<ColorListForm>()
                    .AddTransient<DirectorForm>()
                    .AddTransient<EmployeeEditorForm>()
                    .AddSingleton<AppDbContext>()
                    .AddSingleton<ProgramContext>(this)
                    .AddTransient<DesignerForm>()
                ).Build();

            host.StartAsync();

            OnStart();
        }




        public Employee employee { get; private set; }

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

        }
    }
}
