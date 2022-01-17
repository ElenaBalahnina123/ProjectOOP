using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ProductionForm : Form
    {
        private readonly Role role;
        private readonly AppDbContext db;
        private readonly ProgramContext context;

        private List<Product> Sketching = new();
        private List<Product> Blueprinting = new();
        private List<Product> Cutting = new();
        private List<Product> Sewing = new();
        private List<Product> QualityControl = new();
        private List<Product> ReadyProducts = new();

        public ProductionForm(ProgramContext context, AppDbContext db)
        {
            this.context = context;
            InitializeComponent();
            role = context.employee.Role;

            button_add_sketch.Visible = role == Role.DESIGNER || role == Role.DIRECTOR;
            this.db = db;
        }

        private  async void btnAddSketchClick(object sender, EventArgs e)
        {
            await context.CreateSketchAndProduct();
            LoadContent();
        }

        private async void ProductionForm_Load(object sender, EventArgs e)
        {
            LoadContent();
        }

        private async void LoadContent()
        {
            /*Sketching = await Task.Run(() => (from p in db.Products where p.GetStage() == Stage.SKETCH select p).ToList());
            sketches_list_box.DataSource = Sketching.ConvertAll(s => s.Sketch.Name + " " + s.Sketch.FileLocation + " " + s.Sketch.Author + " " + s.Sketch.CreationDate);*/
            var allProducts = await Task.Run(() => (from p in db.Products select p).ToList());
            IEnumerable<IGrouping<Stage, Product>> staged = allProducts.GroupBy(p => p.GetStage());
            foreach(var st in staged)
            {
                switch (st.Key)
                {
                    case Stage.INITIAL:
                        break;
                    case Stage.SKETCH:
                        Sketching = st.ToList();
                        break;
                    case Stage.BLUEPRINT:
                        Blueprinting = st.ToList();
                        break;
                    case Stage.CUT:
                        Cutting = st.ToList();
                        break;
                    case Stage.SEWING:
                        Sewing = st.ToList();
                        break;
                    case Stage.READY:
                        ReadyProducts = st.ToList();
                        break;
                }
            }

            sketches_list_box.DataSource = Sketching.ConvertAll(product => product.Sketch.Name);

        }

        private void sketch_group_Enter(object sender, EventArgs e)
        {
           
        }

        private void sketches_list_box_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var index = sketches_list_box.IndexFromPoint(e.X, e.Y);
                if (index != ListBox.NoMatches)
                {
                    sketches_list_box.SelectedIndex = index;
                    sketch_context_menu.Show(Cursor.Position);
                }
            }
        }

        private async void edit_sketch_toolstrip_MenuItem_Click(object sender, EventArgs e)
        {
            var index = sketches_list_box.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                var sketch = Sketching[index].Sketch;
                await context.EditSketch(sketch);
                LoadContent();
            }
        }

        private async void delete_sketch_toolstrip_MenuItem_Click(object sender, EventArgs e)
        {
            var index = sketches_list_box.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                var product = Sketching[index];
                await product.RemoveFromDb(db);
                LoadContent();
            }
        }

        private void finishedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
