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
        private ProgramContext context;

        private List<Sketch> sketches;

        private List<Product> Sketching;

        public ProductionForm(ProgramContext context, AppDbContext db)
        {
            InitializeComponent();
            role = context.employee.Role;

            button_add_sketch.Visible = role == Role.DESIGNER || role == Role.DIRECTOR;
            this.db = db;
        }

        private  async void btnAddSketchClick(object sender, EventArgs e)
        {
            await context.AddNewSketch();
            loadSketchList();
        }

        private async void ProductionForm_Load(object sender, EventArgs e)
        {
            // await Task.Run(() => (from c in db.Colors select c).ToList());

            //var products = await Task.Run(() => (from p in db.Products select p).ToList());
            loadSketchList();
            LoadContent();
            

            //var sketchProducts = await Task.Run(() => (from p in db.Products where p.GetStage() == Stage.SKETCH select p).ToList());
            //var blueprintProducts = await Task.Run(() => (from p in db.Products where p.GetStage() == Stage.BLUEPRINT select p).ToList());


        }

        private async void LoadContent()
        {
            Sketching = await Task.Run(() => (from p in db.Products where p.GetStage() == Stage.SKETCH select p).ToList());
            sketches_list_box.DataSource = Sketching.ConvertAll(s => s.Sketch.Name + " " + s.Sketch.FileLocation + " " + s.Sketch.Author + " " + s.Sketch.CreationDate);
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
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private async void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var index = sketches_list_box.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                var sketch = sketches[index];

                Debug.WriteLine("before edit employee");
                await context.EditSketch(sketch);
                Debug.WriteLine("employee updated");
                await loadSketchList();
            }
        }

        private async Task loadSketchList()
        {
            sketches = await Task.Run(() => (from e in db.Sketches select e).ToList());
            var items = sketches.ConvertAll(e => e.Name + " " + e.FileLocation + " " + e.Author + " " + e.CreationDate);
            sketches_list_box.Invoke((MethodInvoker)delegate
            {
                sketches_list_box.DataSource = items;
            });
        }
        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var index = sketches_list_box.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                var sketch = sketches[index];

                await context.DeleteSketch(sketch);
                await loadSketchList();
            }
        }

        private void finishedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
