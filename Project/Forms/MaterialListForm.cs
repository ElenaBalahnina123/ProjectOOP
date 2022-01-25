using Microsoft.EntityFrameworkCore;
using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class MaterialListForm : Form
    {


        private ProgramContext context;
        private AppDbContext db;
        private List<Material> materials;

        public MaterialListForm(ProgramContext context, AppDbContext dbContext)
        {
            this.context = context;
            InitializeComponent();
            db = dbContext;
        }

        private async Task loadMaterialList()
        {
            materials = await db.Materials // загружаем все материалы
                .Include(m => m.Сolor) // метод Include позволяет подгрузить связанный с материалом цвет
                .ToListAsync();

            var items = materials.ConvertAll(m => m.Name + " " + m.Сolor.TextName);
            listBox1.Invoke((MethodInvoker)delegate
            {
                listBox1.DataSource = items;
            });
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var index = listBox1.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                var material = materials[index];

                Debug.WriteLine("before edit color");
                await context.EditMaterial(material);
                Debug.WriteLine("color updated");
                await loadMaterialList();
            }
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var index = listBox1.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                var material = materials[index];

                await context.DeleteMaterial(material);
                await loadMaterialList();
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var index = listBox1.IndexFromPoint(e.X, e.Y);
                if (index != ListBox.NoMatches)
                {
                    listBox1.SelectedIndex = index;
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void ListMaterial_Load(object sender, EventArgs e)
        {
            loadMaterialList();
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            await context.AddNewMaterial();
            loadMaterialList();
        }


    }
}
