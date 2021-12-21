using ProjectOop.Entities;
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
        private Supplier? InitialSupplier;
        private TaskCompletionSource<Supplier> onReady = new TaskCompletionSource<Supplier>();
        public SupplierEditorForm(Supplier? supplier)
        {
            InitializeComponent();
            InitialSupplier = supplier;

            if (supplier != null)
            {
                textBox1.Text = supplier.NameOrganization;
            }

        }       
        private void button1_Click(object sender, EventArgs e)
        {
            var trimmedNameOrganizatio = textBox1.Text.Trim();

            if (trimmedNameOrganizatio.Length == 0)
            {
                MessageBox.Show("Поставщик не указан");
                return;
            }

            Supplier resultSupplier;
            if (InitialSupplier != null)
            {
                resultSupplier = new Supplier()
                {
                    ID = InitialSupplier.ID,
                    NameOrganization = trimmedNameOrganizatio

                };
            }
            else
            {
                resultSupplier = new Supplier()
                {
                    NameOrganization = trimmedNameOrganizatio
                };
            };

            onReady.SetResult(resultSupplier);

        }

        public static async Task<Supplier?> EditSupplier(Supplier? initialSupplier = null)
        {
            var form = new SupplierEditorForm(initialSupplier);
            form.Show();
            try
            {
                var name_organizatio = await form.onReady.Task;
                return name_organizatio;
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

        private void SupplierEditorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                onReady.TrySetCanceled();
            }
            catch (Exception error)
            {

            }
        }



     
        private void SupplierEditorForm_Load(object sender, EventArgs e)
        {

        }
       
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
