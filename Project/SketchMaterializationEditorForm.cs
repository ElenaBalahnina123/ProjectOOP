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
    public partial class SketchMaterializationEditorForm : Form
    {
        private SketchMaterialization? InitialSketchMaterialization;
        private TaskCompletionSource<SketchMaterialization> tcs = new TaskCompletionSource<SketchMaterialization>();

        public SketchMaterializationEditorForm(SketchMaterialization? SketchMaterialization)
        {
            InitializeComponent();
            InitialSketchMaterialization = SketchMaterialization;

            if (SketchMaterialization != null)
            {
                var index = sizeBox.Items.IndexOf(SketchMaterialization.Size.ToString());
                var index1 = comboBox.Items.IndexOf(SketchMaterialization.DegreeDevelopment.ToString());
                if (index != -1 && index1 !=-1)
                {
                    sizeBox.SelectedIndex = index;
                    dateTimePicker1.Value = SketchMaterialization.CreationDate;
                    comboBox.SelectedIndex = index1;
                }            
            }
        }

        private void save_SketchMaterial(object sender, EventArgs e)
        {
            var size = sizeBox.SelectedItem;
            var development= comboBox.SelectedItem;
            var dateDevice = dateTimePicker1.Value;

            var currentDate = DateTime.Now;

            if (dateDevice > currentDate)
            {
                MessageBox.Show("Неверная дата");
                return;
            }


            SketchMaterialization result;
            if (InitialSketchMaterialization != null)
            {
                result = new SketchMaterialization()
                {
                    ID = InitialSketchMaterialization.ID,
                    Size = (string)size,
                    DegreeDevelopment= (string)development,
                    CreationDate=dateDevice
                };
            }
            else
            {
                result = new SketchMaterialization()
                {
                    Size = (string)size,
                    DegreeDevelopment = (string)development,
                    CreationDate = dateDevice
                };
            };
            tcs.SetResult(result);

        }
        public static async Task<SketchMaterialization?> EditSketchMaterialization(SketchMaterialization? initialSketchMaterialization = null)
        {
            var form = new SketchMaterializationEditorForm(initialSketchMaterialization);
            form.Show();
            try
            {
                var SketchMaterialization = await form.tcs.Task;
                return SketchMaterialization;
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

        private void SketchMaterial_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                tcs.TrySetCanceled();
            }
            catch (Exception error)
            {

            }
        }
    }
}
