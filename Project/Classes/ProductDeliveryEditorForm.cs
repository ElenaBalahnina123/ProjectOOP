using ProjectOop.Entities;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ProductDeliveryEditorForm : Form
    {
        private ProductDelivery? InitialProductDelivery;
        private TaskCompletionSource<ProductDelivery> onReady = new TaskCompletionSource<ProductDelivery>();
        public ProductDeliveryEditorForm(ProductDelivery? productDelivery)
        {
            InitializeComponent();
            InitialProductDelivery = productDelivery;

            if (productDelivery != null)
            {
                dateTimePicker1.Value = productDelivery.DeliveryDate;
            }
        }

        public static async Task<ProductDelivery?> getProductDelivery(ProductDelivery? initialProductDelivery = null)
        {
            var form = new ProductDeliveryEditorForm(initialProductDelivery);
            form.Show();
            try
            {
                var productDelivery = await form.onReady.Task;
                return productDelivery;
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
        private void save_btn_Click(object sender, EventArgs e)
        {
            var date = dateTimePicker1.Value;

            var currentDate = DateTime.Now;

            if (date > currentDate)
            {
                MessageBox.Show("Неверная дата");
                return;
            }

            ProductDelivery result;
            if (InitialProductDelivery != null)
            {
                result = new ProductDelivery()
                {
                    ID = InitialProductDelivery.ID,
                    DeliveryDate = dateTimePicker1.Value

                };
            }
            else
            {
                result = new ProductDelivery()
                {
                    DeliveryDate = dateTimePicker1.Value
                };
            };
            onReady.SetResult(result);
        }

        private void ProductDeliveryEditorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                onReady.TrySetCanceled();
            }
            catch (Exception error)
            {

            }
        }
    }
}
