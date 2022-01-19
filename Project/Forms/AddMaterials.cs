using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class AddMaterials : Form
    {

        private ProgramContext context;
        private AppDbContext db;
        private List<Material> materials;

        public EventHandler<List<Material>> OnMaterialsReady;
        
        public AddMaterials(ProgramContext context, AppDbContext dbContext)
        {

            this.context = context;
            InitializeComponent();
            db = dbContext;
        }

        private async void AddMaterials_Load(object sender, EventArgs e)
        {
            var colors = await Task.Run(() => (from c in db.Colors select c).ToList());
            Debug.WriteLine("colors count: " + colors.Count);

            materials = await Task.Run(() => (from m in db.Materials select m).ToList());
            checkedListBox1.Items.AddRange(materials.ConvertAll(m => m.Name + " " + m.color.TextName).ToArray());
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            var indices = checkedListBox1.CheckedIndices;
            var list = new List<Material>();
            
            for(int i = 0; i < materials.Count; i++)
            {
                if(indices.Contains(i))
                {
                    list.Add(materials[i]);
                }
            }

            OnMaterialsReady?.Invoke(this,list);
        }
    }
}
