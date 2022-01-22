using Microsoft.EntityFrameworkCore;
using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    /// <summary>
    /// Форма для выбора материалов, которые будут использоваться в техническом эскизе
    /// </summary>
    public partial class MaterialsSelectorForm : Form
    {

        private ProgramContext context;
        private AppDbContext db;
        private List<Material> materials;

        private EventHandler<List<Material>> OnMaterialsReady;

        public MaterialsSelectorForm(ProgramContext context, AppDbContext dbContext)
        {
            this.context = context;
            InitializeComponent();
            db = dbContext;
        }

        private async void AddMaterials_Load(object sender, EventArgs e)
        {
            materials = await db.Materials
                .Include(material => material.color)
                .ToListAsync();

            materials_checked_list_box.Items.AddRange(materials.ConvertAll(m => m.Name + " " + m.color.TextName).ToArray());
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            var indices = materials_checked_list_box.CheckedIndices;

            var selectedMaterials = new List<Material>();

            for (int i = 0; i < materials.Count; i++)
            {
                if (indices.Contains(i))
                {
                    selectedMaterials.Add(materials[i]);
                }
            }

            OnMaterialsReady?.Invoke(this, selectedMaterials);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="previousMaterials"></param>
        /// <param name="shouldCloseForm"></param>
        /// <returns></returns>
        public async Task<List<Material>> GetMaterialsAsync(List<Material> previousMaterials = null, bool shouldCloseForm = false)
        {
            var dict = previousMaterials?.ToDictionary(m => m.ID);

            for (var i = 0; i < materials.Count; i++)
            {
                materials_checked_list_box.SetItemChecked(i, dict?.ContainsKey(materials[i].ID) ?? false);
            }

            var completionSource = new TaskCompletionSource<List<Material>>();

            var isClosed = false;
            var isResumed = false;

            OnMaterialsReady += (_, list) =>
            {
                if (!isResumed)
                {
                    completionSource.SetResult(list);
                    isResumed = true;
                }
            };

            FormClosed += (_, _) =>
            {
                isClosed = true;
                if (!isResumed)
                {
                    isResumed = true;
                    completionSource.SetResult(null);
                }
            };

            if (shouldCloseForm && !isClosed)
            {
                Close();
            }

            return await completionSource.Task;
        }
    }
}
