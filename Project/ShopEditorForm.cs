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
    public partial class ShopEditorForm : Form
    {
        private Shop? InitialShop;
        
        private TaskCompletionSource<Shop> onReady = new TaskCompletionSource<Shop>();

        public ShopEditorForm(Shop? Shop)
        {
            InitializeComponent();
            InitialShop = Shop;

            if (Shop != null)
            {
                textBox1.Text = Shop.ShopName;
                textBox2.Text = Shop.Address;              
            }
        }

        private void save_shop(object sender, EventArgs e)
        {
            var trimmedShopName = textBox1.Text.Trim();
            if (trimmedShopName.Length == 0)
            {
                MessageBox.Show("Не указана фамилия сотрудника");
                return;
            }
            var trimmedAddress = textBox2.Text.Trim();
            if (trimmedAddress.Length == 0)
            {
                MessageBox.Show("Не указано имя сотрудника");
                return;
            }
            Shop result;
            if (InitialShop != null)
            {
                result = new Shop()
                {
                    ID = InitialShop.ID,
                    ShopName = trimmedShopName,
                    Address = trimmedAddress
                };
            }
            else
            {
                result = new Shop()
                {
                    ShopName = trimmedShopName,
                    Address = trimmedAddress
                };
            };
            onReady.SetResult(result);

        }
        public static async Task<Shop?> getShop(Shop? initialShop = null)
        {
            var form = new ShopEditorForm(initialShop);
            form.Show();
            try
            {
                // ждем когда вызывается кнопка и эта задача завершится. 
                var employee = await form.onReady.Task;
                return employee;
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

        private void Shop_FormClosed(object sender, FormClosedEventArgs e)
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
