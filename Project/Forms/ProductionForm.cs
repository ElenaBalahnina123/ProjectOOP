using ProjectOop.Entities;
using System;
using System.Windows.Forms;

namespace Project
{
    public partial class ProductionForm : Form
    {
        private readonly Role role;
        private readonly AppDbContext db;

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

        private void ProductionForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
