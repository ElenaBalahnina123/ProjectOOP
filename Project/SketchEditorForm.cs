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
    public partial class SketchEditorForm : Form
    {
        private Sketch? InitialSketch;
        private TaskCompletionSource<Sketch> tcs = new TaskCompletionSource<Sketch>();

        public SketchEditorForm(Sketch? Sketch)
        {
            InitializeComponent();
            InitialSketch = Sketch;

            if (Sketch != null)
            {
               
                var index = comboBox.Items.IndexOf(Sketch.DegreeDevelopment.ToString());
                if (index != -1 )
                {
                    textBox1.Text = Sketch.Name;
                    dateTimePicker1.Value = Sketch.CreationDate;
                    comboBox.SelectedIndex = index;
                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Sketch_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                tcs.TrySetCanceled();
            }
            catch (Exception error)
            {

            }

        }
        public static async Task<Sketch?> EditSketch(Sketch? initialSketch = null)
        {
            var form = new SketchEditorForm(initialSketch);
            form.Show();
            try
            {
                var Sketch = await form.tcs.Task;
                return Sketch;
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

        private void save_click(object sender, EventArgs e)
        {
            var trimmedName = textBox1.Text.Trim();
            if (trimmedName.Length == 0)
            {
                MessageBox.Show("Не указана фамилия сотрудника");
                return;
            }
            var development = comboBox.SelectedItem;
            var dateDevice = dateTimePicker1.Value;

            var currentDate = DateTime.Now;

            if (dateDevice > currentDate)
            {
                MessageBox.Show("Неверная дата");
                return;
            }


            Sketch result;
            if (InitialSketch != null)
            {
                result = new Sketch()
                {
                    ID = InitialSketch.ID,
                    Name= trimmedName,
                    DegreeDevelopment = (string)development,
                    CreationDate = dateDevice
                };
            }
            else
            {
                result = new Sketch()
                {
                    ID = InitialSketch.ID,
                    Name = trimmedName,
                    DegreeDevelopment = (string)development,
                    CreationDate = dateDevice
                };
            };
            tcs.SetResult(result);

        }
    }
}
