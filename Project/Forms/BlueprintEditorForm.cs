using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class BlueprintEditorForm : Form
    {

        private Blueprint? InitialBlueprint;
        public EventHandler<Blueprint> OnBlueprintEditor;

        private List<Material> Materials;
        private List<Size> Sizes;
        public BlueprintEditorForm(AppDbContext db)
        {
            InitializeComponent();
            Materials = (from m in db.Materials select m).ToList();
        }

        public BlueprintEditorForm SetProduct(Product product)
        {
            name_sketch.Text = product.Sketch.Name;
            //listBox1.SelectedItem = product.Materials;
            //comboBox1.SelectedIndex = (int)product.Size;
           // dateTimePicker1.Value = product.CreationDate;
            return this;
        }

        public async Task<Blueprint> BlueprintAsync(Product initialProduct, bool showModal = false, bool closeForm = true)
        {
            var tcs = new TaskCompletionSource<Blueprint?>();

            SetProduct(initialProduct);

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
            OnBlueprintEditor += (_, blueprint) =>
            {
                if (gotResult) return;
                gotResult = true;
                tcs.SetResult(blueprint);
            };

            if (showModal)
            {
                ShowDialog();
            }

            var blueprint = await tcs.Task;

            if (!formClosed && closeForm)
            {
                Close();
            }
            return blueprint;
        }

    private void look_sketch_Click(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран размер");
                return;
            }

            var selectedSize = Sizes[comboBox1.SelectedIndex];

            var dateDevice = dateTimePicker1.Value;

            var currentDate = DateTime.Now;

            if (dateDevice > currentDate)
            {
                MessageBox.Show("Неверная дата");
                return;
            }


            Blueprint result;
            if (InitialBlueprint != null)
            {
                result = new Blueprint()
                {
                    ID = InitialBlueprint.ID,
                    Size = selectedSize,
                    
                    CreationDate = dateDevice
                };
            }
            else
            {
                result = new Blueprint()
                {
                    Size = selectedSize,
                    CreationDate = dateDevice
                };
            };
            OnBlueprintEditor?.Invoke(this, result);
            Close();
        }

        private void BlueprintEditorForm_Load(object sender, EventArgs e)
        {
            var list = new List<Size>(Enum.GetValues<Size>());
            comboBox1.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

       
    }
}
