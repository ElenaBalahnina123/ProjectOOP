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
    public partial class ListEmployee : Form
    {
        public ListEmployee()
        {
            InitializeComponent();
        }

        private async void save_employee_Click(object sender, EventArgs e)
        {
            var employeer = await EmployeeEditorForm.getEmployeeNameAsync();
            if (employeer != null)
            {
                MessageBox.Show(employeer.FirstName + " " + employeer.LastName + " " + employeer.MiddleName + " " + employeer.DeviceDate + " " + employeer.Salary);
            }
            else
            {
                MessageBox.Show("Отменено");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
