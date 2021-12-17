using System;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            /*using(var ctx = new AppDbContext()) {

            }*/

            var name = await new PositionEditorForm(null).getPostNameAsync();
            MessageBox.Show(name);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var name = await new SubdivisionEditorForm(null).getSubdivisionNameAsync();
            MessageBox.Show(name);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var name = await new EmployeeEditorForm(null).getEmployeeNameAsync();
            MessageBox.Show(name);

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            var color = await ColorEditorForm.EditColorAsync();
            if(color != null)
            {
                MessageBox.Show(color.TextName);
            } else
            {
                MessageBox.Show("Отменено");
            }
        }
    }
}
