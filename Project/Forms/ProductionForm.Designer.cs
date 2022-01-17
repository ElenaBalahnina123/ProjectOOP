
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
            this.cut_box = new System.Windows.Forms.GroupBox();
            this.sewing_box = new System.Windows.Forms.GroupBox();
            this.qa_box = new System.Windows.Forms.GroupBox();
            this.ready_box = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finishedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sketch_group.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sketch_group
            // 
            this.sketch_group.Controls.Add(this.sketches_list_box);
            this.sketch_group.Controls.Add(this.button_add_sketch);
            this.sketch_group.Location = new System.Drawing.Point(12, 12);
            this.sketch_group.Name = "sketch_group";
            this.sketch_group.Size = new System.Drawing.Size(252, 531);
            this.sketch_group.TabIndex = 0;
            this.sketch_group.TabStop = false;
            this.sketch_group.Text = "Художественный эскиз";
            this.sketch_group.Enter += new System.EventHandler(this.sketch_group_Enter);
            // 
            // sketches_list_box
            // 
            this.sketches_list_box.FormattingEnabled = true;
            this.sketches_list_box.ItemHeight = 15;
            this.sketches_list_box.Location = new System.Drawing.Point(5, 19);
            this.sketches_list_box.Margin = new System.Windows.Forms.Padding(2);
            this.sketches_list_box.Name = "sketches_list_box";
            this.sketches_list_box.Size = new System.Drawing.Size(243, 469);
            this.sketches_list_box.TabIndex = 1;
            this.sketches_list_box.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sketches_list_box_MouseDown);
            // 
            // button_add_sketch
            // 
            this.button_add_sketch.Location = new System.Drawing.Point(16, 493);
            this.button_add_sketch.Name = "button_add_sketch";
            this.button_add_sketch.Size = new System.Drawing.Size(217, 23);
            this.button_add_sketch.TabIndex = 0;
            this.button_add_sketch.Text = "Добавить эскиз";
            this.button_add_sketch.UseVisualStyleBackColor = true;
            this.button_add_sketch.Click += new System.EventHandler(this.btnAddSketchClick);
            // 
            // blueprint_box
            // 
            this.blueprint_box.Location = new System.Drawing.Point(270, 12);
            this.blueprint_box.Name = "blueprint_box";
            this.blueprint_box.Size = new System.Drawing.Size(252, 531);
            this.blueprint_box.TabIndex = 1;
            this.blueprint_box.TabStop = false;
            this.blueprint_box.Text = "Технический эскиз";
            // 
            // cut_box
            // 
            this.cut_box.Location = new System.Drawing.Point(528, 12);
            this.cut_box.Name = "cut_box";
            this.cut_box.Size = new System.Drawing.Size(252, 531);
            this.cut_box.TabIndex = 1;
            this.cut_box.TabStop = false;
            this.cut_box.Text = "Раскрой";
            // 
            // sewing_box
            // 
            this.sewing_box.Location = new System.Drawing.Point(786, 12);
            this.sewing_box.Name = "sewing_box";
            this.sewing_box.Size = new System.Drawing.Size(252, 531);
            this.sewing_box.TabIndex = 1;
            this.sewing_box.TabStop = false;
            this.sewing_box.Text = "Пошив";
            // 
            // qa_box
            // 
            this.qa_box.Location = new System.Drawing.Point(1044, 12);
            this.qa_box.Name = "qa_box";
            this.qa_box.Size = new System.Drawing.Size(252, 531);
            this.qa_box.TabIndex = 2;
            this.qa_box.TabStop = false;
            this.qa_box.Text = "Котроль качества";
            // 
            // ready_box
            // 
            this.ready_box.Location = new System.Drawing.Point(1302, 12);
            this.ready_box.Name = "ready_box";
            this.ready_box.Size = new System.Drawing.Size(252, 531);
            this.ready_box.TabIndex = 2;
            this.ready_box.TabStop = false;
            this.ready_box.Text = "Готовое изделие";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.finishedToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // finishedToolStripMenuItem
            // 
            this.finishedToolStripMenuItem.Name = "finishedToolStripMenuItem";
            this.finishedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.finishedToolStripMenuItem.Text = "Finished";
            this.finishedToolStripMenuItem.Click += new System.EventHandler(this.finishedToolStripMenuItem_Click);
            // 
            // ProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 563);
            this.Controls.Add(this.ready_box);
            this.Controls.Add(this.qa_box);
            this.Controls.Add(this.sewing_box);
            this.Controls.Add(this.cut_box);
            this.Controls.Add(this.blueprint_box);
            this.Controls.Add(this.sketch_group);
            this.Name = "ProductionForm";
            this.Text = "ProductionForm";
            this.Load += new System.EventHandler(this.ProductionForm_Load);
            this.sketch_group.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finishedToolStripMenuItem;
    }
}