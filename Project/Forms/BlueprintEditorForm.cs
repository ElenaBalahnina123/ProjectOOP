using Microsoft.EntityFrameworkCore;
using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class BlueprintEditorForm : Form
    {

        private Blueprint? InitialBlueprint;
        public EventHandler<Blueprint> OnBlueprintEditor;

        /// <summary>
        /// Список материалов для эскиза
        /// </summary>
        private List<Material> SelectedMaterials;
        private List<Size> Sizes;

        private readonly AppDbContext db;

        private readonly ProgramContext context;

        public BlueprintEditorForm(AppDbContext dbContext, ProgramContext programContext)
        {
            InitializeComponent();
            db = dbContext;
            context = programContext;
        }

        /// <summary>
        /// Загрузка списка сохранённых в БД материалов для технического эскиза.
        /// Если эскиз не был сохранён ранее или не были заданы материалы - возвращается пустой список
        /// </summary>
        /// <param name="blueprintId"></param>
        /// <returns></returns>
        private async Task<List<Material>> GetSavedMaterialsForBlueprint(int? blueprintId)
        {
            if (blueprintId == null)
            {
                return new List<Material>();
            }

            return await db.MaterialInBlueprints.Where(m => m.Blueprint.ID == blueprintId)
                .Include(m => m.material.color)
                .Select(m => m.material)
                .ToListAsync();
        }

        /// <summary>
        /// Настройка формы под конкретный продукт
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        private async Task SetInitialProduct(Product product)
        {
            var fetchedProduct = await db.Products.Where(p => p.ID == product.ID)
                .Include(p => p.Sketch)
                .Include(p => p.Blueprint.Materials)
                .FirstAsync();

            name_sketch.Text = fetchedProduct.Sketch.Name;

            // материалы, которые были выбраны для этого чертежа ранее
            SelectedMaterials = await GetSavedMaterialsForBlueprint(fetchedProduct.Blueprint?.ID);

            selected_materials_list_box.DataSource = SelectedMaterials.ConvertAll(material => material.Name + " " + material.color.TextName);
        }

        /// <summary>
        /// Показывает форму (если showModal == true), дожидается когда будет готов Blueprint для сохранения.
        /// После готовности Blueprint закрывает форму если closeForm == true
        /// </summary>
        /// <param name="showModal"></param>
        /// <param name="closeForm">если true - форма будет закрыта после готовности Blueprint</param>
        /// <returns></returns>
        private async Task<Blueprint> AwaitBlueprintOrClose(bool showModal = true, bool closeForm = true)
        {
            var formClosed = false;
            var gotResult = false;

            var tcs = new TaskCompletionSource<Blueprint>();

            FormClosed += (_, _) =>
            {
                if (formClosed) return;
                formClosed = true;
                if (!gotResult)
                {
                    tcs.SetResult(null);
                }
            };
            OnBlueprintEditor += (_, blueprint) =>
            {
                if (gotResult) return;
                gotResult = true;
                tcs.SetResult(blueprint);
            };

            if (showModal)
            {
                ShowDialog();
            }

            var blueprint = await tcs.Task;

            if (!formClosed && closeForm)
            {
                Close();
            }
            return blueprint;
        }

        public async Task<Blueprint> BlueprintAsync(Product initialProduct, bool showModal = true, bool closeForm = true)
        {
            await SetInitialProduct(initialProduct);

            return await AwaitBlueprintOrClose(showModal, closeForm);
        }

        private void look_sketch_Click(object sender, EventArgs e)
        {

        }

        private async Task save_btn_Click(object sender, EventArgs e)
        {

            if (size_combo_box.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран размер");
                return;
            }

            var selectedSize = Sizes[size_combo_box.SelectedIndex];

            var dateDevice = dateTimePicker1.Value;

            var currentDate = DateTime.Now;

            if (dateDevice > currentDate)
            {
                MessageBox.Show("Неверная дата");
                return;
            }


            Blueprint result;
            if (InitialBlueprint != null)
            {
                result = new Blueprint()
                {
                    ID = InitialBlueprint.ID,
                    Size = selectedSize,

                    CreationDate = dateDevice, // возможно стоит перенести в вариант когда чертежа раньше не существовало?
                };
            }
            else
            {
                result = new Blueprint()
                {
                    Size = selectedSize,
                    CreationDate = dateDevice
                };
            };
            await RefreshBlueprintToMaterialLinks(result);


            OnBlueprintEditor?.Invoke(this, result);
            Close();
        }

        private async Task RefreshBlueprintToMaterialLinks(Blueprint blueprint)
        {
            if (blueprint.ID == 0) // эскиз ещё не был сохранён в бд, будут добавлены все выбранные материалы
            {
                blueprint.Materials = SelectedMaterials.ConvertAll(material => new MaterialInBlueprint()
                {
                    Blueprint = blueprint,
                    material = material
                });
            }
            else // эскиз существовал ранее, нужно удалить связи, которые пропали из списка и добавить новые
            {
                var excludedMaterialsInBlueprint = new List<MaterialInBlueprint>();
                var addedMaterialsInBlueprint = new List<MaterialInBlueprint>();

                // TODO
            }
        }

        private void BlueprintEditorForm_Load(object sender, EventArgs e)
        {
            var list = new List<Size>(Enum.GetValues<Size>());
            size_combo_box.DataSource = list;
        }

        private void btn_edit_materials_Click(object sender, EventArgs e)
        {
        }

    }
}
