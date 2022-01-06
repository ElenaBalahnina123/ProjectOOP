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

namespace Project
{
    public partial class ProductionForm : Form
    {
        private readonly Role role;

        public ProductionForm(ProgramContext state)
        {
            InitializeComponent();
            role = state.employee.Role;

            button_add_sketch.Visible = role == Role.DESIGNER || role == Role.DIRECTOR;
        }

        private void btnAddSketchClick(object sender, EventArgs e)
        {

        }
    }
}
