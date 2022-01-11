using ProjectOop.Entities;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class GoodsDeliveryEditorForm : Form
    {
        private GoodsDelivery? InitialGoodsDelivery;
        private TaskCompletionSource<GoodsDelivery> tcs = new TaskCompletionSource<GoodsDelivery>();

        public GoodsDeliveryEditorForm(GoodsDelivery? goodsDelivery)
        {
            InitializeComponent();
            InitialGoodsDelivery = goodsDelivery;
            if (goodsDelivery != null)
            {
                numeric_amount.Text = goodsDelivery.Quantity.ToString();
                var index = sizeBox.Items.IndexOf(goodsDelivery.Size.ToString());
                if (index != -1)
                {
                    sizeBox.SelectedIndex = index;

                }
            }


        }

        private void GoodsDeliveryEditorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                tcs.TrySetCanceled();
            }
            catch (Exception error)
            {

            }
        }

        private void save_btn_position_Click(object sender, EventArgs e)
        {
            var trimmedAmount = numeric_amount.Text.Trim();
            if (trimmedAmount.Length == 0)
            {
                MessageBox.Show("Не указано количество");
                return;
            }
            var size = Int32.Parse((sizeBox.SelectedItem as string));


            GoodsDelivery result;
            if (InitialGoodsDelivery != null)
            {
                result = new GoodsDelivery()
                {
                    ID = InitialGoodsDelivery.ID,

                    Quantity = Int32.Parse(trimmedAmount),
                    Size = size.ToString()
                };
            }
            else
            {
                result = new GoodsDelivery()
                {
                    Quantity = Int32.Parse(trimmedAmount),
                    Size = size.ToString()
                };
            };
            tcs.SetResult(result);
        }

        public static async Task<GoodsDelivery?> EditGoodsDelivery(GoodsDelivery? initialGoodsDelivery = null)
        {
            var form = new GoodsDeliveryEditorForm(initialGoodsDelivery);
            form.Show();
            try
            {
                var goodsDelivery = await form.tcs.Task;
                return goodsDelivery;
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
    }

}
