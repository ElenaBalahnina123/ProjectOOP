using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public AddMaterials(ProgramContext context, AppDbContext dbContext)
        {

            this.context = context;
            InitializeComponent();
            db = dbContext;
        }

        private void AddMaterials_Load(object sender, EventArgs e)
        {

        }
    }
}
