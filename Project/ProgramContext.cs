using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Project.Forms;
using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public class ProgramContext : ApplicationContext
    {

        private IHost host;

        private readonly List<Form> formsRegistry = new();

        public void SetHost(IHost host)
        {
            this.host = host;
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
            if (formsRegistry.Remove(form) && formsRegistry.Count == 0)
            {
                host.Dispose();
                ExitThread();
            }
        }

        public Employee employee { get; private set; }

        public void OnStart()
        {
            Debug.WriteLine("call onStart");

            var db = host.Services.GetRequiredService<AppDbContext>();
            if(db.Employees.Any()) 
            {
                ShowForm<LoginForm>();
            } 
            else
            {
                Task.Run(async () =>
                {
                    var employee = await EmployeeEditorForm.GetEmployeeAsync(this);
                    await db.AddAsync(employee);
                    if (employee != null)
                    {
                        CreateMainForm(employee).Show();
                    }
                    else
                    {
                        MessageBox.Show("Требуется хотя бы один пользователь");
                    }
                });
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
