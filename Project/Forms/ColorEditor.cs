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
    public partial class ColorEditor : Form
    {
        private ModelColor? InitialModelColor;

        private TaskCompletionSource<ModelColor> tcs = new TaskCompletionSource<ModelColor>();
        public ColorEditor(ModelColor? color)
        {
            InitializeComponent();
            InitialModelColor = color;
            if (color != null)
            {
                textBox1.Text = color.TextName;
                textBox2.Text = color.RgbValue;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var trimmedName = textBox1.Text.Trim();

            if (trimmedName.Length == 0)
            {
                MessageBox.Show("Не указано текстовое название для цвета");
                return;
            }

            var trimmedRgb = textBox2.Text.Trim();
            if (trimmedRgb.Length == 0)
            {
                MessageBox.Show("Не указано RGB значение для цвета");
                return;
            }

            ModelColor resultModel;
            if (InitialModelColor != null)
            {
                resultModel = new ModelColor()
                {
                    ID = InitialModelColor.ID,
                    RgbValue = trimmedRgb,
                    TextName = trimmedName
                };
            }
            else
            {
                resultModel = new ModelColor()
                {
                    RgbValue = trimmedRgb,
                    TextName = trimmedName
                };
            };
            tcs.SetResult(resultModel);
        }

        public static async Task<ModelColor?> EditColorAsync(ModelColor? initialColor = null)
        {
            var form = new ColorEditor(initialColor);
            form.Show();
            try
            {
                var color = await form.tcs.Task;
                return color;
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

        private void ColorEditor_FormClosed(object sender, FormClosedEventArgs e)
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
