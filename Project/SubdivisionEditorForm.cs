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
    public partial class SubdivisionEditorForm : Form

    {
        private Subdivision? InitialSubdivision;
        private TaskCompletionSource<Subdivision> onReady = new TaskCompletionSource<Subdivision>();

        public SubdivisionEditorForm(Subdivision subdivision)
        {
            InitializeComponent();
            InitialSubdivision = subdivision;

            if (subdivision != null)
            {
                name_subdivision.Text = subdivision.Name;
            }
        }

        private void save_btn_subdivision_Click_1(object sender, EventArgs e)
        {
            var trimmedName = name_subdivision.Text.Trim();
            if(trimmedName.Length == 0)
            {

                MessageBox.Show("Не указано название подразделения");
                return;
            }

             Subdivision resultSublivision;
            if (InitialSubdivision != null)
            {
                resultSublivision = new Subdivision()
                {
                    ID = InitialSubdivision.ID,
                    Name = trimmedName
                };
            }
            else
            {
                resultSublivision = new Subdivision()
                {
                    Name = trimmedName
                };
            };
            onReady.SetResult(resultSublivision);
        }

        public static async Task<Subdivision?> EditSubdivision(Subdivision? initialSublivision = null)
        {
            var form = new SubdivisionEditorForm(initialSublivision);
            form.Show();
            try
            {
                var subdivision = await form.onReady.Task;
                return subdivision;
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


        private void SubdivisionEditorForm_FormClosed(object sender, FormClosedEventArgs e)
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
