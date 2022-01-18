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
        public BlueprintEditorForm(AppDbContext db)
        {
            InitializeComponent();
            Materials = (from m in db.Materials select m).ToList();
        }

        public BlueprintEditorForm SetProduct(Product product)
        {
            name_sketch.Text = product.Sketch.Name;
            return this;
        }

        public async Task<Blueprint?> GetBlueprintAsync()
        {
            throw new Exception("not implemented");
        }

        

        private void look_sketch_Click(object sender, EventArgs e)
        {

        }

        private void save_btn_Click(object sender, EventArgs e)
        {



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
                  
                    CreationDate = dateDevice
                };
            }
            else
            {
                result = new Blueprint()
                {

                    CreationDate = dateDevice
                };
            };
            OnBlueprintEditor?.Invoke(this, result);
            Close();
        }

        private void BlueprintEditorForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
