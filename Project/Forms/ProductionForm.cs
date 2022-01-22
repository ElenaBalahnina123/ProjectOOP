using Microsoft.EntityFrameworkCore;
using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
        private List<Product> ReadyProducts = new();

        public ProductionForm(ProgramContext context, AppDbContext db)
        {
            this.context = context;
            InitializeComponent();
            role = context.employee.Role;

            button_add_sketch.Visible = role == Role.DESIGNER || role == Role.DIRECTOR;
            this.db = db;
        }

        private async void btnAddSketchClick(object sender, EventArgs e)
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
            var allProducts = await db.Products
                .Include(p => p.Sketch)
                .Include(p => p.Blueprint)
                .Include(p => p.Cut)
                .Include(p => p.Sewing)
                .ToListAsync();

            Debug.WriteLine("total products count: " + allProducts);

            IEnumerable<IGrouping<Stage, Product>> staged = allProducts.GroupBy(p => p.GetStage());
            foreach (var st in staged)
            {
                switch (st.Key)
                {
                    case Stage.INITIAL:
                        Debug.WriteLine("products in INITAL stage: " + st.Count());
                        break;
                    case Stage.SKETCH:
                        Sketching = st.ToList();
                        Debug.WriteLine("products in SKETCH stage: " + Sketching.Count());
                        sketches_list_box.DataSource = Sketching.ConvertAll(product => product.Sketch.Name);
                        break;
                    case Stage.BLUEPRINT:
                        Blueprinting = st.ToList();
                        Debug.WriteLine("products in BLUEPRINT stage: " + Blueprinting.Count());
                        blueprint_list_box.DataSource = Blueprinting.ConvertAll(product => product.Sketch.Name);
                        break;
                    case Stage.CUT:
                        Cutting = st.ToList();
                        Debug.WriteLine("products in CUT stage: " + Cutting.Count());
                        cutting_list_box.DataSource = Cutting.ConvertAll(product => product.Sketch.Name);
                        break;
                    case Stage.SEWING:
                        Sewing = st.ToList();
                        Debug.WriteLine("products in SEWING stage: " + Sewing.Count());
                        sewing_list_box.DataSource = Sewing.ConvertAll(product => product.Sketch.Name);
                        break;
                    case Stage.READY:
                        ReadyProducts = st.ToList();
                        Debug.WriteLine("products in READY stage: " + ReadyProducts.Count());
                        ready_list_box.DataSource = ReadyProducts.ConvertAll(product => product.Sketch.Name);
                        break;
                }
            }
        }

        private async void create_blueprint_menu_item_click(object sender, EventArgs e)
        {
            var index = sketches_list_box.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                var product = Sketching[index];

                await context.ConvertFromSketchToBlueprint(product);

                LoadContent();
            }
        }



        #region "MouseDown list Box"
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

        private void blueprint_list_box_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var index = blueprint_list_box.IndexFromPoint(e.X, e.Y);
                if (index != ListBox.NoMatches)
                {
                    blueprint_list_box.SelectedIndex = index;
                    blueprint_context_menu.Show(Cursor.Position);
                }
            }
        }
        private void cutting_list_box_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var index = cutting_list_box.IndexFromPoint(e.X, e.Y);
                if (index != ListBox.NoMatches)
                {
                    cutting_list_box.SelectedIndex = index;
                    cutting_context_menu.Show(Cursor.Position);
                }
            }
        }

        private void sewing_list_box_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var index = sewing_list_box.IndexFromPoint(e.X, e.Y);
                if (index != ListBox.NoMatches)
                {
                    sewing_list_box.SelectedIndex = index;
                    sewing_context_menu.Show(Cursor.Position);
                }
            }
        }



        private void ready_list_box_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var index = ready_list_box.IndexFromPoint(e.X, e.Y);
                if (index != ListBox.NoMatches)
                {
                    ready_list_box.SelectedIndex = index;
                    ready_context_menu.Show(Cursor.Position);
                }
            }
        }
        #endregion 

        #region "edit"
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
        private void edit_blueprint_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private async void edit_cutting_ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var index = cutting_list_box.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                var cutting = Cutting[index].Cut;
                await context.EditCutting(cutting);
                LoadContent();
            }
        }

        private async void edit_sewing_ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var index = sewing_list_box.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                var sewing = Sewing[index].Sewing;
                await context.EditSewing(sewing);
                LoadContent();
            }
        }
        #endregion

        #region "delete"
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
        private async void delete_blueprint_ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var index = blueprint_list_box.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                var product = Blueprinting[index];
                await product.RemoveFromDb(db);
                LoadContent();
            }
        }
        private async void delete_cutting_ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var index = cutting_list_box.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                var product = Cutting[index];
                await product.RemoveFromDb(db);
                LoadContent();
            }
        }

        private async void delete_sewing_ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var index = sewing_list_box.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                var product = Sewing[index];
                await product.RemoveFromDb(db);
                LoadContent();
            }
        }

        private async void delete_ready_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var index = ready_list_box.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                var product = ReadyProducts[index];
                await product.RemoveFromDb(db);
                LoadContent();
            }
        }
        #endregion


    }
}
