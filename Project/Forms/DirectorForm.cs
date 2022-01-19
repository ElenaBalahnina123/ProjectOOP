using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Project
{
    public partial class DirectorForm : Form
    {
        private ProgramContext programState;

        public DirectorForm(ProgramContext programState)
        {
            this.programState = programState;
            InitializeComponent();
            Debug.WriteLine("components DirectorForm initialized");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var form = host.Services.GetRequiredService<ListEmployee>();
            programState.ShowEmployerList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            programState.ShowProductionList();
        }



        private void btn_edit_colors_Click(object sender, EventArgs e)
        {
            programState.DoColorEdit();
        }

        private void btn_edit_materials_Click(object sender, EventArgs e)
        {
            programState.ShowMaterialList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            programState.ShowForm<BlueprintEditorForm>();
        }
    }
}
