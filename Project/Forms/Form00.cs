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
    public partial class Form00 : Form
    {
        private IHost host;
        private AppDbContext dbContext;
        public Form00(HostHolder hostHolder, AppDbContext dbContext)
        {
            host = hostHolder.host;
            InitializeComponent();
            this.dbContext = dbContext;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = host.Services.GetRequiredService<ColorListForm>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = host.Services.GetRequiredService<ListMaterial>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = host.Services.GetRequiredService<ListPosition>();
        }
    }
}
