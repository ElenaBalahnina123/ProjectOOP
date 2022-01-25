using ProjectOop.Entities;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ColorEditor : Form
    {
        private ModelColor? InitialModelColor;
        public EventHandler<ModelColor> OnColorEditor;


        public ColorEditor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var trimmedName = color_name.Text.Trim();

            if (trimmedName.Length == 0)
            {
                MessageBox.Show("Не указано текстовое название для цвета");
                return;
            }

            var trimmedRgb = rgb_value.Text.Trim();
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
            OnColorEditor?.Invoke(this, resultModel);
            Close();
        }

        public ColorEditor SetColor(ModelColor initialColor)
        {
            InitialModelColor = initialColor;
            color_name.Text = initialColor.TextName;
            rgb_value.Text = initialColor.RgbValue;

            return this;
        }


        public async Task<ModelColor> ColorAsync(bool showModal = false, bool closeForm = true)
        {
            var tcs = new TaskCompletionSource<ModelColor?>();

            var formClosed = false;
            var gotResult = false;

            FormClosed += (_, _) =>
            {
                if (formClosed) return;
                formClosed = true;
                if (!gotResult)
                {
                    tcs.SetResult(null);
                }
            };
            OnColorEditor += (_, color) =>
            {
                if (gotResult) return;
                gotResult = true;
                tcs.SetResult(color);
            };

            if (showModal)
            {
                ShowDialog();
            }

            var color = await tcs.Task;

            if (!formClosed && closeForm)
            {
                Close();
            }
            return color;
        }

       
    }
}
