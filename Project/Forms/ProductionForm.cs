using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ProductionForm : Form
    {
        private readonly Role role;
        private readonly AppDbContext db;

        private List<Product> Sketching;

        public ProductionForm(ProgramContext context, AppDbContext db)
        {
            InitializeComponent();
            role = context.employee.Role;

            button_add_sketch.Visible = role == Role.DESIGNER || role == Role.DIRECTOR;
            this.db = db;
        }

        private void btnAddSketchClick(object sender, EventArgs e)
        {

        }

        private async void ProductionForm_Load(object sender, EventArgs e)
        {
            // await Task.Run(() => (from c in db.Colors select c).ToList());

            //var products = await Task.Run(() => (from p in db.Products select p).ToList());

            Sketching = await Task.Run(() => (from p in db.Products where p.GetStage() == Stage.SKETCH select p).ToList());
            sketches_list_box.DataSource = Sketching.ConvertAll(s => s.Sketch.Name);




            //var sketchProducts = await Task.Run(() => (from p in db.Products where p.GetStage() == Stage.SKETCH select p).ToList());
            //var blueprintProducts = await Task.Run(() => (from p in db.Products where p.GetStage() == Stage.BLUEPRINT select p).ToList());


        }
    }
}
