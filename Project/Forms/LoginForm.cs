using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class LoginForm : Form
    {
        private IHost host;
        private AppDbContext dbContext;

        public LoginForm(HostHolder hostHolder, AppDbContext dbContext)
        {
            host = hostHolder.host;
            InitializeComponent();
            this.dbContext = dbContext;
        }

        private void btn_come_in_Click(object sender, EventArgs e)
        {
            //var form = host.Services.GetRequiredService<DirectorForm>();

        }
    }
}
