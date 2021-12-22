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
    public partial class RawMaterialItemForm : Form
    {
        private RawMaterialItem? InitialRawMaterialItem;
        private TaskCompletionSource<RawMaterialItem> tcs = new TaskCompletionSource<RawMaterialItem>();

        public RawMaterialItemForm(RawMaterialItem? RawMaterialItem)
        {
            InitializeComponent();
            InitialRawMaterialItem = RawMaterialItem;

            if (RawMaterialItem != null)
            {
                numeric_amount.Text = RawMaterialItem.Quantity.ToString();
            }
        }
        private void RawMaterialItemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                tcs.TrySetCanceled();
            }
            catch (Exception error)
            {

            }
        }
        private void save_btn_RawMaterialItem_Click(object sender, EventArgs e)
        {
            var trimmedAmount = numeric_amount.Text.Trim();
            if (trimmedAmount.Length == 0)
            {
                MessageBox.Show("Не указано количество");
                return;
            }

            RawMaterialItem result;
            if (InitialRawMaterialItem != null)
            {
                result = new RawMaterialItem()
                {
                    ID = InitialRawMaterialItem.ID,

                    Quantity = Int32.Parse(trimmedAmount),
                   
                };
            }
            else
            {
                result = new RawMaterialItem()
                {
                    Quantity = Int32.Parse(trimmedAmount),
                 
                };
            };
            tcs.SetResult(result);
        }
       
        public static async Task<RawMaterialItem?> EditRawMaterialItem(RawMaterialItem? initialRawMaterialItem = null)
        {
            var form = new RawMaterialItemForm(initialRawMaterialItem);
            form.Show();
            try
            {
                var RawMaterialItem = await form.tcs.Task;
                return RawMaterialItem;
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

        private void RawMaterialItemForm_Load(object sender, EventArgs e)
        {

        }
     
    }
}
