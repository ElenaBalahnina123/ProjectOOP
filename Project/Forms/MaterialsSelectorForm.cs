using Microsoft.EntityFrameworkCore;
using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    /// <summary>
    /// Форма для выбора материалов, которые будут использоваться в техническом эскизе
    /// </summary>
    public partial class MaterialsSelectorForm : Form
    {

        private AppDbContext db;
        private List<Material> materials;

        private List<int> previousSelectedMaterialIds = new();

        private EventHandler<List<Material>> OnMaterialsReady;

        public MaterialsSelectorForm(AppDbContext dbContext)
        {
            db = dbContext;
            InitializeComponent();
        }

        private async void AddMaterials_Load(object sender, EventArgs e)
        {
            materials = await db.Materials
                .Include(material => material.color)
                .ToListAsync();

            foreach (var material in materials)
            {
                materials_checked_list_box.Items.Add(
                    item: material.Name + " " + material.color.TextName,
                    isChecked: previousSelectedMaterialIds.Contains(material.ID)
                    );
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            var indices = materials_checked_list_box.CheckedIndices;

            var selectedMaterials = new List<Material>();

            for (int i = 0; i < materials.Count; i++)
            {
                if (materials_checked_list_box.GetItemChecked(i)) selectedMaterials.Add(materials[i]);
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
            previousSelectedMaterialIds = previousMaterials?.ConvertAll(m => m.ID) ?? new();

            var completionSource = new TaskCompletionSource<List<Material>>();

            var isClosed = false;
            var isResumed = false;

            OnMaterialsReady += (_, list) =>
            {
                if (!isResumed)
                {
                    isResumed = true;
                    completionSource.SetResult(list);
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

            var result = await completionSource.Task;

            if (shouldCloseForm && !isClosed)
            {
                Close();
            }

            return result;
        }
    }
}
