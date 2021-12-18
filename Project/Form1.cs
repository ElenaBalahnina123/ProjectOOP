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
    public partial class Form1 : Form
    {
        private TaskCompletionSource<string?> onReady = new TaskCompletionSource<string>();
        public Form1(string? form)
        {
            InitializeComponent();
            if (form != null)
            {
                label1.Text = form;
            }
        }
        public async Task<string?> getForm1()
        {
            Show();
            var result = await onReady.Task;
            Close();
            return result;
        }
        public class Form1F
        {
            public string NameOrganization { get; set; }
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

        private async void save_product_warehouse_Click(object sender, EventArgs e)
        {
            var productOnWarehouse = await ProductOnWarehouseEditor.EditPrOnWarehouse();
            if (productOnWarehouse != null)
            {
                MessageBox.Show(productOnWarehouse.Size.ToString() + " " + productOnWarehouse.Quantity.ToString());

            }
            else
            {
                MessageBox.Show("Отменено");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button5_Click(object sender, EventArgs e)
        {
            var name = await new SupplierEditorForm(null).getSupplierEditorForm();

            
                MessageBox.Show(name);
            
        }
    }
}
