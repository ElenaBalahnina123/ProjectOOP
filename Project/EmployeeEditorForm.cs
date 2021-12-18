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
    public partial class EmployeeEditorForm : Form // сотрудник
    {

        private TaskCompletionSource<string?> onReady = new TaskCompletionSource<string>();

        public EmployeeEditorForm(string? employee)
        {
            InitializeComponent();

            if (employee != null)
            {
                textBox1.Text = employee;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public async Task<string?> getEmployeeNameAsync()
        {
            Show();
            var result = await onReady.Task;
            Close();
            return result;
        }

        public class EmployeeEditor
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }
            public string MiddleName { get; set; }

            public string Date { get; set; }

            public int Price { get; set; }
        }

        private void EmployeeEditorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
