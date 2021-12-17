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

        private async void save_post(object sender, EventArgs e)
        {

            var post_name = await PositionEditorForm.EditPosition();
            if (post_name != null)
            {
                MessageBox.Show(post_name.NamePost);
            }
            else
            {
                MessageBox.Show("Отменено");
            }

        }

        private async void save_subdivision(object sender, EventArgs e)
        {
            var subdivision_name = await SubdivisionEditorForm.EditSubdivision();
            if (subdivision_name != null)
            {
                MessageBox.Show(subdivision_name.Name);
            }
            else
            {
                MessageBox.Show("Отменено");
            }
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
