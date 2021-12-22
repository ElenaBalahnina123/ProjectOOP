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
    public partial class RawMaterialItemEditorForm : Form
    {
        private RawMaterialItem? InitialRawMaterialItem;
        private TaskCompletionSource<RawMaterialItem> onReady = new TaskCompletionSource<RawMaterialItem>();
        public SupplierEditorForm(RawMaterialItem? supplier)
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







































        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RawMaterialItemEditorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
