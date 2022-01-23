
namespace Project
{
    partial class ProductionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sketch_group = new System.Windows.Forms.GroupBox();
            this.sketches_list_box = new System.Windows.Forms.ListBox();
            this.button_add_sketch = new System.Windows.Forms.Button();
            this.blueprint_box = new System.Windows.Forms.GroupBox();
            this.blueprint_list_box = new System.Windows.Forms.ListBox();
            this.cut_box = new System.Windows.Forms.GroupBox();
            this.cutting_list_box = new System.Windows.Forms.ListBox();
            this.sewing_box = new System.Windows.Forms.GroupBox();
            this.sewing_list_box = new System.Windows.Forms.ListBox();
            this.ready_box = new System.Windows.Forms.GroupBox();
            this.ready_list_box = new System.Windows.Forms.ListBox();
            this.sketch_context_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.edit_sketch = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_sketch = new System.Windows.Forms.ToolStripMenuItem();
            this.to_blueprint_sketch_context_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueprint_context_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.edit_blueprint = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_blueprint = new System.Windows.Forms.ToolStripMenuItem();
            this.add_cutting_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutting_context_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.edit_cutting = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_cutting = new System.Windows.Forms.ToolStripMenuItem();
            this.add_sewing_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sewing_context_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.edit_sewing = new System.Windows.Forms.ToolStripMenuItem();
            this.delete_sewing = new System.Windows.Forms.ToolStripMenuItem();
            this.qual_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отправитьНаДоработкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.раскройToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пошивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.утилизироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.контрольКачестваПройденToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ready_context_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.close_product_menu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.sketch_group.SuspendLayout();
            this.blueprint_box.SuspendLayout();
            this.cut_box.SuspendLayout();
            this.sewing_box.SuspendLayout();
            this.ready_box.SuspendLayout();
            this.sketch_context_menu.SuspendLayout();
            this.blueprint_context_menu.SuspendLayout();
            this.cutting_context_menu.SuspendLayout();
            this.sewing_context_menu.SuspendLayout();
            this.ready_context_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // sketch_group
            // 
            this.sketch_group.Controls.Add(this.sketches_list_box);
            this.sketch_group.Controls.Add(this.button_add_sketch);
            this.sketch_group.Location = new System.Drawing.Point(17, 20);
            this.sketch_group.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sketch_group.Name = "sketch_group";
            this.sketch_group.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sketch_group.Size = new System.Drawing.Size(360, 885);
            this.sketch_group.TabIndex = 0;
            this.sketch_group.TabStop = false;
            this.sketch_group.Text = "Художественный эскиз";
            // 
            // sketches_list_box
            // 
            this.sketches_list_box.FormattingEnabled = true;
            this.sketches_list_box.ItemHeight = 25;
            this.sketches_list_box.Location = new System.Drawing.Point(7, 35);
            this.sketches_list_box.Name = "sketches_list_box";
            this.sketches_list_box.Size = new System.Drawing.Size(345, 779);
            this.sketches_list_box.TabIndex = 1;
            this.sketches_list_box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sketches_list_box_MouseDown);
            // 
            // button_add_sketch
            // 
            this.button_add_sketch.Location = new System.Drawing.Point(23, 822);
            this.button_add_sketch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_add_sketch.Name = "button_add_sketch";
            this.button_add_sketch.Size = new System.Drawing.Size(310, 38);
            this.button_add_sketch.TabIndex = 0;
            this.button_add_sketch.Text = "Добавить эскиз";
            this.button_add_sketch.UseVisualStyleBackColor = true;
            this.button_add_sketch.Click += new System.EventHandler(this.btnAddSketchClick);
            // 
            // blueprint_box
            // 
            this.blueprint_box.Controls.Add(this.blueprint_list_box);
            this.blueprint_box.Location = new System.Drawing.Point(386, 20);
            this.blueprint_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blueprint_box.Name = "blueprint_box";
            this.blueprint_box.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blueprint_box.Size = new System.Drawing.Size(360, 885);
            this.blueprint_box.TabIndex = 1;
            this.blueprint_box.TabStop = false;
            this.blueprint_box.Text = "Технический эскиз";
            // 
            // blueprint_list_box
            // 
            this.blueprint_list_box.FormattingEnabled = true;
            this.blueprint_list_box.ItemHeight = 25;
            this.blueprint_list_box.Location = new System.Drawing.Point(7, 32);
            this.blueprint_list_box.Name = "blueprint_list_box";
            this.blueprint_list_box.Size = new System.Drawing.Size(345, 829);
            this.blueprint_list_box.TabIndex = 0;
            this.blueprint_list_box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.blueprint_list_box_MouseDown);
            // 
            // cut_box
            // 
            this.cut_box.Controls.Add(this.cutting_list_box);
            this.cut_box.Location = new System.Drawing.Point(754, 20);
            this.cut_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cut_box.Name = "cut_box";
            this.cut_box.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cut_box.Size = new System.Drawing.Size(360, 885);
            this.cut_box.TabIndex = 1;
            this.cut_box.TabStop = false;
            this.cut_box.Text = "Раскрой";
            // 
            // cutting_list_box
            // 
            this.cutting_list_box.FormattingEnabled = true;
            this.cutting_list_box.ItemHeight = 25;
            this.cutting_list_box.Location = new System.Drawing.Point(7, 32);
            this.cutting_list_box.Name = "cutting_list_box";
            this.cutting_list_box.Size = new System.Drawing.Size(345, 829);
            this.cutting_list_box.TabIndex = 0;
            this.cutting_list_box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cutting_list_box_MouseDown);
            // 
            // sewing_box
            // 
            this.sewing_box.Controls.Add(this.sewing_list_box);
            this.sewing_box.Location = new System.Drawing.Point(1123, 20);
            this.sewing_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sewing_box.Name = "sewing_box";
            this.sewing_box.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sewing_box.Size = new System.Drawing.Size(360, 885);
            this.sewing_box.TabIndex = 1;
            this.sewing_box.TabStop = false;
            this.sewing_box.Text = "Пошив";
            // 
            // sewing_list_box
            // 
            this.sewing_list_box.FormattingEnabled = true;
            this.sewing_list_box.ItemHeight = 25;
            this.sewing_list_box.Location = new System.Drawing.Point(7, 32);
            this.sewing_list_box.Name = "sewing_list_box";
            this.sewing_list_box.Size = new System.Drawing.Size(345, 829);
            this.sewing_list_box.TabIndex = 0;
            this.sewing_list_box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sewing_list_box_MouseDown);
            // 
            // ready_box
            // 
            this.ready_box.Controls.Add(this.ready_list_box);
            this.ready_box.Location = new System.Drawing.Point(1491, 20);
            this.ready_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ready_box.Name = "ready_box";
            this.ready_box.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ready_box.Size = new System.Drawing.Size(360, 885);
            this.ready_box.TabIndex = 2;
            this.ready_box.TabStop = false;
            this.ready_box.Text = "Готовое изделие";
            // 
            // ready_list_box
            // 
            this.ready_list_box.FormattingEnabled = true;
            this.ready_list_box.ItemHeight = 25;
            this.ready_list_box.Location = new System.Drawing.Point(7, 32);
            this.ready_list_box.Name = "ready_list_box";
            this.ready_list_box.Size = new System.Drawing.Size(345, 829);
            this.ready_list_box.TabIndex = 0;
            this.ready_list_box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ready_list_box_MouseDown);
            // 
            // sketch_context_menu
            // 
            this.sketch_context_menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.sketch_context_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit_sketch,
            this.delete_sketch,
            this.to_blueprint_sketch_context_MenuItem});
            this.sketch_context_menu.Name = "contextMenuStrip1";
            this.sketch_context_menu.Size = new System.Drawing.Size(316, 100);
            // 
            // edit_sketch
            // 
            this.edit_sketch.Name = "edit_sketch";
            this.edit_sketch.Size = new System.Drawing.Size(315, 32);
            this.edit_sketch.Text = "Редактировать";
            this.edit_sketch.Click += new System.EventHandler(this.edit_sketch_toolstrip_MenuItem_Click);
            // 
            // delete_sketch
            // 
            this.delete_sketch.Name = "delete_sketch";
            this.delete_sketch.Size = new System.Drawing.Size(315, 32);
            this.delete_sketch.Text = "Удалить";
            this.delete_sketch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete_sketch.Click += new System.EventHandler(this.delete_sketch_toolstrip_MenuItem_Click);
            // 
            // to_blueprint_sketch_context_MenuItem
            // 
            this.to_blueprint_sketch_context_MenuItem.Name = "to_blueprint_sketch_context_MenuItem";
            this.to_blueprint_sketch_context_MenuItem.Size = new System.Drawing.Size(315, 32);
            this.to_blueprint_sketch_context_MenuItem.Text = "Добавить технический эскиз";
            this.to_blueprint_sketch_context_MenuItem.Click += new System.EventHandler(this.create_blueprint_menu_item_click);
            // 
            // blueprint_context_menu
            // 
            this.blueprint_context_menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.blueprint_context_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit_blueprint,
            this.delete_blueprint,
            this.add_cutting_ToolStripMenuItem});
            this.blueprint_context_menu.Name = "blueprint_context_menu";
            this.blueprint_context_menu.Size = new System.Drawing.Size(237, 100);
            // 
            // edit_blueprint
            // 
            this.edit_blueprint.Name = "edit_blueprint";
            this.edit_blueprint.Size = new System.Drawing.Size(236, 32);
            this.edit_blueprint.Text = "Редактировать";
            this.edit_blueprint.Click += new System.EventHandler(this.edit_blueprint_ToolStripMenuItem1_Click);
            // 
            // delete_blueprint
            // 
            this.delete_blueprint.Name = "delete_blueprint";
            this.delete_blueprint.Size = new System.Drawing.Size(236, 32);
            this.delete_blueprint.Text = "Удалить";
            this.delete_blueprint.Click += new System.EventHandler(this.delete_blueprint_ToolStripMenuItem1_Click);
            // 
            // add_cutting_ToolStripMenuItem
            // 
            this.add_cutting_ToolStripMenuItem.Name = "add_cutting_ToolStripMenuItem";
            this.add_cutting_ToolStripMenuItem.Size = new System.Drawing.Size(236, 32);
            this.add_cutting_ToolStripMenuItem.Text = "Добавить раскрой";
            this.add_cutting_ToolStripMenuItem.Click += new System.EventHandler(this.blueprint_menu_item_click_add_cut);
            // 
            // cutting_context_menu
            // 
            this.cutting_context_menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cutting_context_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit_cutting,
            this.delete_cutting,
            this.add_sewing_ToolStripMenuItem});
            this.cutting_context_menu.Name = "contextMenuStrip1";
            this.cutting_context_menu.Size = new System.Drawing.Size(223, 100);
            // 
            // edit_cutting
            // 
            this.edit_cutting.Name = "edit_cutting";
            this.edit_cutting.Size = new System.Drawing.Size(222, 32);
            this.edit_cutting.Text = "Редактировать";
            this.edit_cutting.Click += new System.EventHandler(this.edit_cutting_ToolStripMenuItem2_Click);
            // 
            // delete_cutting
            // 
            this.delete_cutting.Name = "delete_cutting";
            this.delete_cutting.Size = new System.Drawing.Size(222, 32);
            this.delete_cutting.Text = "Удалить";
            this.delete_cutting.Click += new System.EventHandler(this.delete_cutting_ToolStripMenuItem2_Click);
            // 
            // add_sewing_ToolStripMenuItem
            // 
            this.add_sewing_ToolStripMenuItem.Name = "add_sewing_ToolStripMenuItem";
            this.add_sewing_ToolStripMenuItem.Size = new System.Drawing.Size(222, 32);
            this.add_sewing_ToolStripMenuItem.Text = "Добавить пошив";
            this.add_sewing_ToolStripMenuItem.Click += new System.EventHandler(this.cutting_menu_item_click_add_sewing);
            // 
            // sewing_context_menu
            // 
            this.sewing_context_menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.sewing_context_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit_sewing,
            this.delete_sewing,
            this.qual_ToolStripMenuItem});
            this.sewing_context_menu.Name = "sewing_context_menu";
            this.sewing_context_menu.Size = new System.Drawing.Size(241, 133);
            // 
            // edit_sewing
            // 
            this.edit_sewing.Name = "edit_sewing";
            this.edit_sewing.Size = new System.Drawing.Size(240, 32);
            this.edit_sewing.Text = "Редактировать";
            this.edit_sewing.Click += new System.EventHandler(this.edit_sewing_ToolStripMenuItem3_Click);
            // 
            // delete_sewing
            // 
            this.delete_sewing.Name = "delete_sewing";
            this.delete_sewing.Size = new System.Drawing.Size(240, 32);
            this.delete_sewing.Text = "Удалить";
            this.delete_sewing.Click += new System.EventHandler(this.delete_sewing_ToolStripMenuItem3_Click);
            // 
            // qual_ToolStripMenuItem
            // 
            this.qual_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отправитьНаДоработкуToolStripMenuItem,
            this.утилизироватьToolStripMenuItem,
            this.контрольКачестваПройденToolStripMenuItem});
            this.qual_ToolStripMenuItem.Name = "qual_ToolStripMenuItem";
            this.qual_ToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.qual_ToolStripMenuItem.Text = "Контроль качества";
            // 
            // отправитьНаДоработкуToolStripMenuItem
            // 
            this.отправитьНаДоработкуToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.раскройToolStripMenuItem,
            this.пошивToolStripMenuItem});
            this.отправитьНаДоработкуToolStripMenuItem.Name = "отправитьНаДоработкуToolStripMenuItem";
            this.отправитьНаДоработкуToolStripMenuItem.Size = new System.Drawing.Size(344, 34);
            this.отправитьНаДоработкуToolStripMenuItem.Text = "Отправить на доработку";
            // 
            // раскройToolStripMenuItem
            // 
            this.раскройToolStripMenuItem.Name = "раскройToolStripMenuItem";
            this.раскройToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.раскройToolStripMenuItem.Text = "Раскрой";
            this.раскройToolStripMenuItem.Click += new System.EventHandler(this.send_to_cut);
            // 
            // пошивToolStripMenuItem
            // 
            this.пошивToolStripMenuItem.Name = "пошивToolStripMenuItem";
            this.пошивToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.пошивToolStripMenuItem.Text = "Пошив";
            this.пошивToolStripMenuItem.Click += new System.EventHandler(this.send_to_sewing);
            // 
            // утилизироватьToolStripMenuItem
            // 
            this.утилизироватьToolStripMenuItem.Name = "утилизироватьToolStripMenuItem";
            this.утилизироватьToolStripMenuItem.Size = new System.Drawing.Size(344, 34);
            this.утилизироватьToolStripMenuItem.Text = "Утилизировать";
            this.утилизироватьToolStripMenuItem.Click += new System.EventHandler(this.sewing_menu_item_click_utilize);
            // 
            // контрольКачестваПройденToolStripMenuItem
            // 
            this.контрольКачестваПройденToolStripMenuItem.Name = "контрольКачестваПройденToolStripMenuItem";
            this.контрольКачестваПройденToolStripMenuItem.Size = new System.Drawing.Size(344, 34);
            this.контрольКачестваПройденToolStripMenuItem.Text = "Контроль качества пройден";
            this.контрольКачестваПройденToolStripMenuItem.Click += new System.EventHandler(this.sewing_menu_item_click_quality_control_passed);
            // 
            // ready_context_menu
            // 
            this.ready_context_menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ready_context_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.close_product_menu_item});
            this.ready_context_menu.Name = "ready_context_menu";
            this.ready_context_menu.Size = new System.Drawing.Size(174, 36);
            // 
            // close_product_menu_item
            // 
            this.close_product_menu_item.Name = "close_product_menu_item";
            this.close_product_menu_item.Size = new System.Drawing.Size(173, 32);
            this.close_product_menu_item.Text = "Завершить";
            this.close_product_menu_item.Click += new System.EventHandler(this.delete_ready_ToolStripMenuItem_Click);
            // 
            // ProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 940);
            this.Controls.Add(this.ready_box);
            this.Controls.Add(this.sewing_box);
            this.Controls.Add(this.cut_box);
            this.Controls.Add(this.blueprint_box);
            this.Controls.Add(this.sketch_group);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductionForm";
            this.Text = "ProductionForm";
            this.Load += new System.EventHandler(this.ProductionForm_Load);
            this.sketch_group.ResumeLayout(false);
            this.blueprint_box.ResumeLayout(false);
            this.cut_box.ResumeLayout(false);
            this.sewing_box.ResumeLayout(false);
            this.ready_box.ResumeLayout(false);
            this.sketch_context_menu.ResumeLayout(false);
            this.blueprint_context_menu.ResumeLayout(false);
            this.cutting_context_menu.ResumeLayout(false);
            this.sewing_context_menu.ResumeLayout(false);
            this.ready_context_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sketch_group;
        private System.Windows.Forms.Button button_add_sketch;
        private System.Windows.Forms.GroupBox blueprint_box;
        private System.Windows.Forms.GroupBox cut_box;
        private System.Windows.Forms.GroupBox sewing_box;
        private System.Windows.Forms.GroupBox ready_box;
        private System.Windows.Forms.ListBox sketches_list_box;
        private System.Windows.Forms.ContextMenuStrip sketch_context_menu;
        private System.Windows.Forms.ToolStripMenuItem edit_sketch;
        private System.Windows.Forms.ToolStripMenuItem delete_sketch;
        private System.Windows.Forms.ToolStripMenuItem to_blueprint_sketch_context_MenuItem;
        private System.Windows.Forms.ListBox blueprint_list_box;
        private System.Windows.Forms.ListBox cutting_list_box;
        private System.Windows.Forms.ListBox sewing_list_box;
        private System.Windows.Forms.ListBox ready_list_box;
        private System.Windows.Forms.ContextMenuStrip blueprint_context_menu;
        private System.Windows.Forms.ToolStripMenuItem edit_blueprint;
        private System.Windows.Forms.ToolStripMenuItem delete_blueprint;
        private System.Windows.Forms.ContextMenuStrip cutting_context_menu;
        private System.Windows.Forms.ToolStripMenuItem edit_cutting;
        private System.Windows.Forms.ToolStripMenuItem delete_cutting;
        private System.Windows.Forms.ContextMenuStrip sewing_context_menu;
        private System.Windows.Forms.ToolStripMenuItem edit_sewing;
        private System.Windows.Forms.ToolStripMenuItem delete_sewing;
        private System.Windows.Forms.ContextMenuStrip ready_context_menu;
        private System.Windows.Forms.ToolStripMenuItem close_product_menu_item;
        private System.Windows.Forms.ToolStripMenuItem add_cutting_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem add_sewing_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qual_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отправитьНаДоработкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem раскройToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пошивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem утилизироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контрольКачестваПройденToolStripMenuItem;
    }
}