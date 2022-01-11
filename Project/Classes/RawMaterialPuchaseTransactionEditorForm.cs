using ProjectOop.Entities;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class RawMaterialPuchaseTransactionEditorForm : Form
    {
        private RawMaterialPuchaseTransaction? InitialRawTransaction;
        private TaskCompletionSource<RawMaterialPuchaseTransaction> onReady = new TaskCompletionSource<RawMaterialPuchaseTransaction>();
        public RawMaterialPuchaseTransactionEditorForm(RawMaterialPuchaseTransaction? materialPuchaseTransaction)
        {
            InitializeComponent();
            InitialRawTransaction = materialPuchaseTransaction;

            if (materialPuchaseTransaction != null)
            {
                dateTimePicker1.Value = materialPuchaseTransaction.PurchaseDate;
            }
        }

        public static async Task<RawMaterialPuchaseTransaction?> getRawTransaction(RawMaterialPuchaseTransaction? initialTransaction = null)
        {
            var form = new RawMaterialPuchaseTransactionEditorForm(initialTransaction);
            form.Show();
            try
            {
                var transaction = await form.onReady.Task;
                return transaction;
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

        private void save_btn_rawTransaction_Click(object sender, EventArgs e)
        {
            var date = dateTimePicker1.Value;

            var currentDate = DateTime.Now;

            if (date > currentDate)
            {
                MessageBox.Show("Неверная дата");
                return;
            }

            RawMaterialPuchaseTransaction result;
            if (InitialRawTransaction != null)
            {
                result = new RawMaterialPuchaseTransaction()
                {
                    ID = InitialRawTransaction.ID,
                    PurchaseDate = dateTimePicker1.Value

                };
            }
            else
            {
                result = new RawMaterialPuchaseTransaction()
                {
                    PurchaseDate = dateTimePicker1.Value
                };
            };
            onReady.SetResult(result);

        }

        private void RawMaterialPuchaseTransactionEditorForm_FormClosed(object sender, FormClosedEventArgs e)
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
