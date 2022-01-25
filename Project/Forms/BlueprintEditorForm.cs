﻿using Microsoft.EntityFrameworkCore;
using Project.Forms;
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

        /// <summary>
        /// Метод, который будет обрабатывать событие, когда событие предоставляет данные.
        /// </summary>
        public EventHandler<Blueprint> OnBlueprintEditor;

        /// <summary>
        /// Список материалов для эскиза
        /// </summary>
        private List<Material> SelectedMaterials;

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
            if (blueprintId == null) return new List<Material>();

            return db.Blueprints.Where(b => b.ID == blueprintId)
                .Include(b => b.Materials)
                .Select(b => b.Materials)
                .FirstOrDefault()
                .ToList();

           
        }

        /// <summary>
        /// Настройка формы под конкретный продукт
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        private async Task SetInitialProduct(Product product)
        {
            var fetchedProduct = await db.Products.Where(p => p.ID == product.ID)
                // Говорим фрейму, какие связанные сущности ему нужно подгружать
                .Include(p => p.Sketch)
                .Include(p => p.Blueprint)
                .FirstAsync();

            name_sketch.Text = fetchedProduct.Sketch.Name;

            // материалы, которые были выбраны для этого чертежа ранее
            SelectedMaterials = await GetSavedMaterialsForBlueprint(fetchedProduct.Blueprint?.ID);
            selected_materials_list_box.DataSource = SelectedMaterials.ConvertAll(material => material.Name + " " + material.Сolor.TextName);
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

        private void RefreshBlueprintToMaterialLinks(Blueprint blueprint)
        {
            if (blueprint.Materials?.Any() == true) // Удаляем старую информацию
            {
                blueprint.Materials = null;
                db.SaveChanges();
            }

            blueprint.Materials = SelectedMaterials;
        }

        private void BlueprintEditorForm_Load(object sender, EventArgs e)
        {
            size_combo_box.DataSource = Enum.GetValues<WearSize>();
        }

        private async void btn_edit_materials_Click(object sender, EventArgs e)
        {
            var list = await context.ShowForm<MaterialsSelectorForm>().GetMaterialsAsync(SelectedMaterials, true);
            if (list == null)
            {
                return;
            }

            SelectedMaterials = list;
            selected_materials_list_box.DataSource = SelectedMaterials.ConvertAll(material => material.Name + " " + material.Сolor.TextName);
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

            if (size_combo_box.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран размер");
                return;
            }

            var selectedSize = Enum.GetValues<WearSize>()[size_combo_box.SelectedIndex];

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

                    CreationDate = dateDevice, 
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

            db.SaveChanges();

            RefreshBlueprintToMaterialLinks(result);

            db.SaveChanges();

            OnBlueprintEditor?.Invoke(this, result);
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
