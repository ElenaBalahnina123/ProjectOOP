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
    public class ProgramState
    {
        private IHost host;

        public void SetHost(IHost host)
        {
            this.host = host;
        }

        public Employee employee { get; private set; }

        public async void OnStart()
        {
            var db = host.Services.GetRequiredService<AppDbContext>();
            if(db.Employees.Count() > 0) 
            {
                var loginForm = host.Services.GetRequiredService<LoginForm>();
                Application.Run(loginForm);
            } else
            {

            }
        }

        private void ShowForm<T>() where T : Form
        {
            host.Services.GetRequiredService<T>().Show();
        }

        public void ShowMainForm(Employee employee)
        {
            this.employee = employee;

            switch (employee.Role)
            {
                case Role.DIRECTOR:
                    ShowForm<DirectorForm>();
                    break;
                /*case Role.SEAMSTRESS:
                    ShowForm<ProductionForm>();
                    break;
                case Role.CUTTER:
                    ShowForm<ProductionForm>();
                    break;
                case Role.DESIGNER:
                    ShowForm<DesignerForm>();
                    break;
                case Role.TECHNOLOGIST:
                    ShowForm<ProductionForm>();
                    break;*/
            }
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
