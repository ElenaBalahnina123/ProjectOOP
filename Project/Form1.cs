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

        private async void save_resourse_story_Click(object sender, EventArgs e)
        {
            var resourse = await ResourceRequestHistoryItemEditor.getResource();
            if (resourse != null)
            {
                MessageBox.Show(resourse.Date.ToString());

            }
            else
            {
                MessageBox.Show("Отменено");
            }
        }

        private async void saveProductDelivery_Click(object sender, EventArgs e)
        {
            var productDelivery = await ProductDeliveryEditorForm.getProductDelivery();
            if (productDelivery != null)
            {
                MessageBox.Show(productDelivery.DeliveryDate.ToString());

            }
            else
            {
                MessageBox.Show("Отменено");
            }
        }

        private async void save_raw_transaction_Click(object sender, EventArgs e)
        {
            var rawTransaction = await RawMaterialPuchaseTransactionEditorForm.getRawTransaction();
            if (rawTransaction != null)
            {
                MessageBox.Show(rawTransaction.PurchaseDate.ToString());

            }
            else
            {
                MessageBox.Show("Отменено");
            }
        }
    }
}
