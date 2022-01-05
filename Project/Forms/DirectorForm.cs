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
    public partial class DirectorForm : Form
    {
        private ProgramState programState;
        
        public DirectorForm(ProgramState programState)
        {
            this.programState = programState;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var form = host.Services.GetRequiredService<ListEmployee>();
            programState.ShowEmployerList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var form2 = host.Services.GetRequiredService<ProductionForm>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //var form3 = host.Services.GetRequiredService<PositionEditorForm>();
        }

        private void btn_edit_colors_Click(object sender, EventArgs e)
        {
            programState.DoColorEdit();
        }
    }
}
