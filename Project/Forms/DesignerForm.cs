using System.Windows.Forms;

namespace Project
{
    public partial class DesignerForm : Form
    {
        private readonly ProgramContext context;

        public DesignerForm(ProgramContext program)
        {
            InitializeComponent();
            this.context = program;
        }

        private void btn_edit_colors_Click(object sender, System.EventArgs e)
        {
            context.DoColorEdit();
        }

        private void btn_edit_materials_Click(object sender, System.EventArgs e)
        {
            context.ShowMaterialList();
        }

        private void btn_production_Click(object sender, System.EventArgs e)
        {
            context.ShowProductionList();
        }
    }
}
