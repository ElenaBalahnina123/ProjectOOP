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
    public partial class SupplierEditorForm : Form
    {

        private TaskCompletionSource<string?> onReady = new TaskCompletionSource<string>();
        public SupplierEditorForm(string? supplier)
        {
            InitializeComponent();
            if (supplier != null)
            {
                textBox1.Text = supplier;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void SupplierEditorForm_Load(object sender, EventArgs e)
        {

        }
        public async Task<string?> getSupplierEditorForm()
        {
            Show();
            var result = await onReady.Task;
            Close();
            return result;
        }
        public class EmployeeEditor
        {
            public string NameOrganization { get; set; }

           
        }

    }
}
