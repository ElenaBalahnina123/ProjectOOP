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
    public partial class MaterialCuttingEditorForm : Form
    {
        private MaterialCutting? InitialMaterialCutting;
        private TaskCompletionSource<MaterialCutting> tcs = new TaskCompletionSource<MaterialCutting>();

        public MaterialCuttingEditorForm(MaterialCutting? MaterialCutting)
        {
            InitializeComponent();
            InitialMaterialCutting = MaterialCutting;

            if (MaterialCutting != null)
            {
                numeric_amount.Text = MaterialCutting.Quantity.ToString();
            }
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                tcs.TrySetCanceled();
            }
            catch (Exception error)
            {

            }
        }
        private void save_btn_materialCuttingEditorForm_Click(object sender, EventArgs e)
        {
            var trimmedAmount = numeric_amount.Text.Trim();
            if (trimmedAmount.Length == 0)
            {
                MessageBox.Show("Не указано количество");
                return;
            }

            MaterialCutting result;
            if (InitialMaterialCutting != null)
            {
                result = new MaterialCutting()
                {
                    ID = InitialMaterialCutting.ID,
                    Quantity = Int32.Parse(trimmedAmount),
                };
            }
            else
            {
                result = new MaterialCutting()
                {
                    Quantity = Int32.Parse(trimmedAmount),

                };
            };
            tcs.SetResult(result);
        }
        public static async Task<MaterialCutting?> EditMaterialCutting(MaterialCutting? initialMaterialCutting = null)
        {
            var form = new MaterialCuttingEditorForm(initialMaterialCutting);
            form.Show();
            try
            {
                var MaterialCutting = await form.tcs.Task;
                return MaterialCutting;
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
