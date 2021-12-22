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
    public partial class TransactionContentsEditorForm : Form
    {
        private TransactionContents? InitialTransactionContents;
        private TaskCompletionSource<TransactionContents> tcs = new TaskCompletionSource<TransactionContents>();
        public TransactionContentsEditorForm(TransactionContents? transactionContents)
        {
            InitializeComponent();
            InitialTransactionContents = transactionContents;

            if(transactionContents != null)
            {
                numericUpDown1.Text = transactionContents.Quantity.ToString();
                textBox_price.Text = transactionContents.Price.ToString();

            }

        }

        private void TransactionContentsEditorForm_Load(object sender, EventArgs e)
        {

        }

        private void TransactionContentsEditorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                tcs.TrySetCanceled();
            }
            catch (Exception error)
            {

            }
        }

        private void save_btn_story_Click(object sender, EventArgs e)
        {

            var trimmedAmount = numericUpDown1.Value.ToString();
            if (trimmedAmount.Length == 0)
            {
                MessageBox.Show("Не указано количество");
                return;
            }

            var trimmedPrice = textBox_price.Text.Trim();
            int temp = 0;

            if (int.TryParse(trimmedPrice, out temp))
            {
                trimmedPrice = (int.Parse(trimmedPrice)).ToString("C2");
            }



            TransactionContents result;
            if (InitialTransactionContents != null)
            {
                result = new TransactionContents()
                {
                    ID = InitialTransactionContents.ID,
                    Quantity = Int32.Parse(trimmedAmount),
                    Price = double.Parse(trimmedPrice),

                };
            }
            else
            {
                result = new TransactionContents()
                {
                    Quantity = Int32.Parse(trimmedAmount),
                    Price = double.Parse(trimmedPrice),
                };
            };
            tcs.SetResult(result);
        }

        public static async Task<TransactionContents?> EditorTransactionContents(TransactionContents? initialTransactionContents = null)
        {
            var form = new TransactionContentsEditorForm(initialTransactionContents);
            form.Show();
            try
            {
                // ждем когда вызывается кнопка и эта задача завершится. 
                var transaction = await form.tcs.Task;
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
    }
}
