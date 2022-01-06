using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Project.Forms;
using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public class ProgramState : ApplicationContext
    {

        private readonly IHost host;

        private readonly List<Form> formsRegistry = new();

        public ProgramState(IHost host)
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

        /*private IHost host;

        public void SetHost(IHost host)
        {
            this.host = host;
        }*/

        public Employee employee { get; private set; }

        public async Task OnStart()
        {
            var db = host.Services.GetRequiredService<AppDbContext>();
            if(db.Employees.Count() > 0) 
            {
                var loginForm = CreateForm<LoginForm>();
                Application.Run(loginForm);
            } 
            else
            {
                var employee = await EmployeeEditorForm.GetEmployeeAsync();
                await db.AddAsync(employee);
                if(employee != null)
                {
                    Application.Run(CreateMainForm(employee));
                }
                else
                {
                    MessageBox.Show("Требуется хотя бы один пользователь");
                }
            }
        }

        private void ShowForm<T>() where T : Form
        {
            CreateForm<T>().Show();
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
