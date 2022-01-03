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

        public void DoLogin()
        {
            var loginForm = host.Services.GetRequiredService<LoginForm>();
            Application.Run(loginForm);
        }

        public void ShowMainForm(Employee employee)
        {
            this.employee = employee;

            var hasDirectorRole = employee.HasRole(KnownRoles.DIRECTOR);
            if(hasDirectorRole)
            {
                host.Services.GetRequiredService<DirectorForm>().Show();
            }
        }

        public void ShowEmployerList()
        {

        }
    }
}
