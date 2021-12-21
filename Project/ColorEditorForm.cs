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
    public partial class ColorEditorForm : Form
    {
        private ModelColor? InitialModelColor;

        private TaskCompletionSource<ModelColor> tcs = new TaskCompletionSource<ModelColor>();

        public ColorEditorForm(ModelColor? color)
        {
            InitializeComponent();
            InitialModelColor = color;
            if(color != null)
            {
                color_string_name.Text = color.TextName;
                rgb_value.Text = color.RgbValue;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var trimmedName = color_string_name.Text.Trim();

            if (trimmedName.Length == 0)
            {
                MessageBox.Show("Не указано текстовое название для цвета");
                return;
            }

            var trimmedRgb = rgb_value.Text.Trim();
            if(trimmedRgb.Length == 0)
            {
                MessageBox.Show("Не указано RGB значение для цвета");
                return;
            }

            ModelColor resultModel;
            if(InitialModelColor != null)
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
            var form = new ColorEditorForm(initialColor);
            form.Show();
            try
            {
                var color = await form.tcs.Task;
                return color;
            }
            catch(OperationCanceledException e)
            {
                return null;
            }
            finally
            {
                if(!form.IsDisposed)
                {
                    form.Close();
                }
            }
        }

        private void ColorEditorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                tcs.TrySetCanceled();
            }
            catch(Exception error)
            {
                
            }
        }

        private void ColorEditorForm_Load(object sender, EventArgs e)
        {

        }
    }


}
