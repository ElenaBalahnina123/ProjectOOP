using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class MaterialEditorForm : Form
    {
        private Material? InitialMaterial;
        public EventHandler<Material> OnMaterialEditor;

        private List<ModelColor> Colors;

        public MaterialEditorForm(AppDbContext db)
        {
            InitializeComponent();

            Colors = (from c in db.Colors select c).ToList();
        }

        private void MaterialEditorForm_Load(object sender, EventArgs e)
        {
            comboBox_color.DataSource = Colors.ConvertAll(color => color.TextName);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox_color.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран цвет");
                return;
            }

            var selectedColor = Colors[comboBox_color.SelectedIndex];



            var trimmedName = material_name.Text.Trim();

            if (trimmedName.Length == 0)
            {
                MessageBox.Show("Не указано название материала");
                return;
            }


            Material result;
            if (InitialMaterial != null)
            {
                result = new Material()
                {
                    ID = InitialMaterial.ID,
                    Name = trimmedName,
                    Сolor = selectedColor
                };
            }
            else
            {
                result = new Material()
                {
                    Name = trimmedName,
                    Сolor = selectedColor
                };
            };
            OnMaterialEditor?.Invoke(this, result);
            Close();
        }

        public MaterialEditorForm SetMaterial(Material initialMaterial)
        {
            InitialMaterial = initialMaterial;
            material_name.Text = initialMaterial.Name;
            comboBox_color.Text = initialMaterial.Сolor.ToString();

            return this;
        }

        public async Task<Material> MaterialAsync(bool showModal = false, bool closeForm = true)
        {
            var tcs = new TaskCompletionSource<Material?>();

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
            OnMaterialEditor += (_, material) =>
            {
                if (gotResult) return;
                gotResult = true;
                tcs.SetResult(material);
            };

            if (showModal)
            {
                ShowDialog();
            }

            var material = await tcs.Task;

            if (!formClosed && closeForm)
            {
                Close();
            }
            return material;
        }

        /*public static async Task<Material?> GetMaterialAsync(ProgramContext context, Material initialMaterial = null)
        {
            var form = context.CreateForm<MaterialEditorForm>();
            Debug.WriteLine("form created");

            form.SetMaterial(initialMaterial);

            var tcs = new TaskCompletionSource<Material?>();

            var formClosed = false;
            var gotResult = false;

            form.FormClosed += (_, _) =>
            {
                if (formClosed) return;
                formClosed = true;
                tcs.SetResult(null);
            };
            form.OnMaterialEditor += (_, material) =>
            {
                if (gotResult) return;
                gotResult = true;
                tcs.SetResult(material);
            };

            form.Show();

            var material = await tcs.Task;

            if (!formClosed)
            {
                form.Close();
            }
            return material;
        }*/
        private void MaterialEditorForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }


    }
}
