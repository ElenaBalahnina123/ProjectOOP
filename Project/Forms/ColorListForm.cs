using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ColorListForm : Form
    {
        private ProgramContext context;
        private AppDbContext db;
        private List<ModelColor> colors;

        public ColorListForm(ProgramContext context, AppDbContext dbContext)
        {

            this.context = context;
            InitializeComponent();
            db = dbContext;
        }

        private async void btn_add_new_Click(object sender, EventArgs e)
        {
            await context.AddNewColor();
            loadColorList();
        }

        private async Task loadColorList()
        {
            colors = await Task.Run(() => (from c in db.Colors select c).ToList());
            var items = colors.ConvertAll(c => c.TextName + " " + c.RgbValue);
            colors_list.Invoke((MethodInvoker)delegate
            {
                colors_list.DataSource = items;
            });
        }
        private async void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var index = colors_list.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                var color = colors[index];

                Debug.WriteLine("before edit color");
                await context.EditColor(color);
                Debug.WriteLine("color updated");
                await loadColorList();
            }
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var index = colors_list.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                var color = colors[index];

                await context.DeleteColor(color);
                await loadColorList();
            }
        }

        private void ColorListForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var index = colors_list.IndexFromPoint(e.X, e.Y);
                if (index != ListBox.NoMatches)
                {
                    colors_list.SelectedIndex = index;
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void ColorListForm_Load(object sender, EventArgs e)
        {
            loadColorList();
        }
    }
}
