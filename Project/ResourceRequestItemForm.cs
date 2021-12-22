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
    public partial class ResourceRequestItemForm: Form
    {
        private ResourceRequestItem? InitialResourceRequestItem;
        private TaskCompletionSource<ResourceRequestItem> tcs = new TaskCompletionSource<ResourceRequestItem>();

        public ResourceRequestItemForm(ResourceRequestItem? ResourceRequestItem)
        {
            InitializeComponent();
            InitialResourceRequestItem = ResourceRequestItem;

            if (ResourceRequestItem != null)
            {
                numeric_amount.Text = ResourceRequestItem.Quantity.ToString();
            }
        }

        private void ResourceRequestItemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                tcs.TrySetCanceled();
            }
            catch (Exception error)
            {

            }
        }

        private void save_btn_ResourceRequestItem_Click(object sender, EventArgs e)
        {
            var trimmedAmount = numeric_amount.Text.Trim();
            if (trimmedAmount.Length == 0)
            {
                MessageBox.Show("Не указано количество");
                return;
            }

            ResourceRequestItem result;
            if (InitialResourceRequestItem != null)
            {
                result = new ResourceRequestItem()
                {
                    ID = InitialResourceRequestItem.ID,
                    Quantity = Int32.Parse(trimmedAmount),
                };
            }
            else
            {
                result = new ResourceRequestItem()
                {
                    Quantity = Int32.Parse(trimmedAmount),

                };
            };
            tcs.SetResult(result);
        }
        public static async Task<ResourceRequestItem?> EditResourceRequestItem(ResourceRequestItem? initialResourceRequestItem = null)
        {
            var form = new ResourceRequestItemForm(initialResourceRequestItem);
            form.Show();
            try
            {
                var ResourceRequestItem = await form.tcs.Task;
                return ResourceRequestItem;
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
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ResourceRequestItemForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        
    }
}
