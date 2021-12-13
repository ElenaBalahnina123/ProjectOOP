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
    }
}
