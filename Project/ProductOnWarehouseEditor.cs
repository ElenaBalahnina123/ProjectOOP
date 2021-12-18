using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectOop.Entities;
namespace Project
{
    public partial class ProductOnWarehouseEditor : Form // товар на складе

        
    {
        private ProductOnWarehouse? InitialProductOnWarehouse;
        private TaskCompletionSource<ProductOnWarehouse> tcs = new TaskCompletionSource<ProductOnWarehouse>();

        public ProductOnWarehouseEditor(ProductOnWarehouse? productOnWarehouse)
        {
            InitializeComponent();
            InitialProductOnWarehouse = productOnWarehouse;

            if(productOnWarehouse != null)
            {
                var index = sizeBox.Items.IndexOf(productOnWarehouse.Size.ToString());
                if(index != -1)
                {
                    sizeBox.SelectedIndex = index;
                   
                }


                amountInput.Text = productOnWarehouse.Quantity.ToString();
            }
        }

        private void save_btn_prOnWerehouse(object sender, EventArgs e)

        {

            var size = Int32.Parse((sizeBox.SelectedItem as string));



            var trimmedAmount = amountInput.Text.Trim();
            if (trimmedAmount.Length == 0)
            {
                MessageBox.Show("Не указано количество");
                return;
            }

           ProductOnWarehouse resultPrOnWareh;
            if (InitialProductOnWarehouse != null)
            {
                resultPrOnWareh = new ProductOnWarehouse()
                {
                    ID = InitialProductOnWarehouse.ID,
                    Size = size,
                    Quantity = Int32.Parse(trimmedAmount)
                };
            }
            else
            {
                resultPrOnWareh = new ProductOnWarehouse()
                {
                    Size = size,
                    Quantity = Int32.Parse(trimmedAmount)
                };
            };
            tcs.SetResult(resultPrOnWareh);
        }


        public static async Task<ProductOnWarehouse?> EditPrOnWarehouse(ProductOnWarehouse? initialPrOnWarehouse = null)
        {
            var form = new ProductOnWarehouseEditor(initialPrOnWarehouse);
            form.Show();
            try
            {
                var productOnWarehouse = await form.tcs.Task;
                return productOnWarehouse;
            }
            catch (OperationCanceledException e)
            {
                return null;
            }
            finally
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                }
            }
        }

        private void ProductOnWarehouseEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                tcs.TrySetCanceled();
            }
            catch (Exception error)
            {

            }
        }

        private void ProductOnWarehouseEditor_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

     
   
}
