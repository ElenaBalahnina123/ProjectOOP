﻿
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
            this.qa_box = new System.Windows.Forms.GroupBox();
            this.quality_control_list_box = new System.Windows.Forms.ListBox();
            this.ready_box = new System.Windows.Forms.GroupBox();
            this.ready_list_box = new System.Windows.Forms.ListBox();
            this.sketch_context_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.to_blueprint_sketch_context_MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueprint_context_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toCuttingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sketch_group.SuspendLayout();
            this.blueprint_box.SuspendLayout();
            this.cut_box.SuspendLayout();
            this.sewing_box.SuspendLayout();
            this.qa_box.SuspendLayout();
            this.ready_box.SuspendLayout();
            this.sketch_context_menu.SuspendLayout();
            this.blueprint_context_menu.SuspendLayout();
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
            this.sketches_list_box.Location = new System.Drawing.Point(7, 32);
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
            this.blueprint_list_box.Size = new System.Drawing.Size(346, 829);
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
            this.cutting_list_box.Size = new System.Drawing.Size(346, 829);
            this.cutting_list_box.TabIndex = 0;
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
            this.sewing_list_box.Size = new System.Drawing.Size(346, 829);
            this.sewing_list_box.TabIndex = 0;
            // 
            // qa_box
            // 
            this.qa_box.Controls.Add(this.quality_control_list_box);
            this.qa_box.Location = new System.Drawing.Point(1491, 20);
            this.qa_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.qa_box.Name = "qa_box";
            this.qa_box.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.qa_box.Size = new System.Drawing.Size(360, 885);
            this.qa_box.TabIndex = 2;
            this.qa_box.TabStop = false;
            this.qa_box.Text = "Котроль качества";
            // 
            // quality_control_list_box
            // 
            this.quality_control_list_box.FormattingEnabled = true;
            this.quality_control_list_box.ItemHeight = 25;
            this.quality_control_list_box.Location = new System.Drawing.Point(7, 32);
            this.quality_control_list_box.Name = "quality_control_list_box";
            this.quality_control_list_box.Size = new System.Drawing.Size(346, 829);
            this.quality_control_list_box.TabIndex = 0;
            // 
            // ready_box
            // 
            this.ready_box.Controls.Add(this.ready_list_box);
            this.ready_box.Location = new System.Drawing.Point(1860, 20);
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
            this.ready_list_box.Size = new System.Drawing.Size(346, 829);
            this.ready_list_box.TabIndex = 0;
            // 
            // sketch_context_menu
            // 
            this.sketch_context_menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.sketch_context_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.to_blueprint_sketch_context_MenuItem});
            this.sketch_context_menu.Name = "contextMenuStrip1";
            this.sketch_context_menu.Size = new System.Drawing.Size(303, 100);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(302, 32);
            this.editToolStripMenuItem.Text = "Редактировать";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.edit_sketch_toolstrip_MenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(302, 32);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.delete_sketch_toolstrip_MenuItem_Click);
            // 
            // to_blueprint_sketch_context_MenuItem
            // 
            this.to_blueprint_sketch_context_MenuItem.Name = "to_blueprint_sketch_context_MenuItem";
            this.to_blueprint_sketch_context_MenuItem.Size = new System.Drawing.Size(302, 32);
            this.to_blueprint_sketch_context_MenuItem.Text = "Создать технический эскиз";
            this.to_blueprint_sketch_context_MenuItem.Click += new System.EventHandler(this.create_blueprint_menu_item_click);
            // 
            // blueprint_context_menu
            // 
            this.blueprint_context_menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.blueprint_context_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem1,
            this.toCuttingToolStripMenuItem});
            this.blueprint_context_menu.Name = "blueprint_context_menu";
            this.blueprint_context_menu.Size = new System.Drawing.Size(241, 133);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(240, 32);
            this.editToolStripMenuItem1.Text = "Edit";
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(240, 32);
            this.deleteToolStripMenuItem1.Text = "Delete";
            // 
            // toCuttingToolStripMenuItem
            // 
            this.toCuttingToolStripMenuItem.Name = "toCuttingToolStripMenuItem";
            this.toCuttingToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.toCuttingToolStripMenuItem.Text = "Добавить раскрой";
            this.toCuttingToolStripMenuItem.Click += new System.EventHandler(this.toCuttingToolStripMenuItem_Click);
            // 
            // ProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2238, 938);
            this.Controls.Add(this.ready_box);
            this.Controls.Add(this.qa_box);
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
            this.qa_box.ResumeLayout(false);
            this.ready_box.ResumeLayout(false);
            this.sketch_context_menu.ResumeLayout(false);
            this.blueprint_context_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox sketch_group;
        private System.Windows.Forms.Button button_add_sketch;
        private System.Windows.Forms.GroupBox blueprint_box;
        private System.Windows.Forms.GroupBox cut_box;
        private System.Windows.Forms.GroupBox sewing_box;
        private System.Windows.Forms.GroupBox qa_box;
        private System.Windows.Forms.GroupBox ready_box;
        private System.Windows.Forms.ListBox sketches_list_box;
        private System.Windows.Forms.ContextMenuStrip sketch_context_menu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem to_blueprint_sketch_context_MenuItem;
        private System.Windows.Forms.ListBox blueprint_list_box;
        private System.Windows.Forms.ListBox cutting_list_box;
        private System.Windows.Forms.ListBox sewing_list_box;
        private System.Windows.Forms.ListBox quality_control_list_box;
        private System.Windows.Forms.ListBox ready_list_box;
        private System.Windows.Forms.ContextMenuStrip blueprint_context_menu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toCuttingToolStripMenuItem;
    }
}