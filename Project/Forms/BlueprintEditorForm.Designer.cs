﻿
namespace Project
{
    partial class BlueprintEditorForm
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
            this.selected_materials_list_box = new System.Windows.Forms.ListBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.name_sketch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_edit_materials = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.size_combo_box = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // selected_materials_list_box
            // 
            this.selected_materials_list_box.BackColor = System.Drawing.Color.White;
            this.selected_materials_list_box.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selected_materials_list_box.FormattingEnabled = true;
            this.selected_materials_list_box.ItemHeight = 14;
            this.selected_materials_list_box.Location = new System.Drawing.Point(10, 46);
            this.selected_materials_list_box.Name = "selected_materials_list_box";
            this.selected_materials_list_box.Size = new System.Drawing.Size(269, 88);
            this.selected_materials_list_box.TabIndex = 0;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.White;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save_btn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.save_btn.Location = new System.Drawing.Point(78, 304);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(134, 28);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // name_sketch
            // 
            this.name_sketch.AutoSize = true;
            this.name_sketch.Location = new System.Drawing.Point(10, 5);
            this.name_sketch.Name = "name_sketch";
            this.name_sketch.Size = new System.Drawing.Size(45, 14);
            this.name_sketch.TabIndex = 4;
            this.name_sketch.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Материалы:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 254);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Дата создания:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btn_edit_materials
            // 
            this.btn_edit_materials.BackColor = System.Drawing.Color.White;
            this.btn_edit_materials.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit_materials.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_edit_materials.Location = new System.Drawing.Point(55, 149);
            this.btn_edit_materials.Name = "btn_edit_materials";
            this.btn_edit_materials.Size = new System.Drawing.Size(185, 28);
            this.btn_edit_materials.TabIndex = 10;
            this.btn_edit_materials.Text = "Изменить материалы";
            this.btn_edit_materials.UseVisualStyleBackColor = false;
            this.btn_edit_materials.Click += new System.EventHandler(this.btn_edit_materials_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "Размер:";
            // 
            // size_combo_box
            // 
            this.size_combo_box.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.size_combo_box.FormattingEnabled = true;
            this.size_combo_box.Location = new System.Drawing.Point(10, 205);
            this.size_combo_box.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.size_combo_box.Name = "size_combo_box";
            this.size_combo_box.Size = new System.Drawing.Size(269, 22);
            this.size_combo_box.TabIndex = 12;
            // 
            // BlueprintEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(294, 358);
            this.Controls.Add(this.size_combo_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_edit_materials);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_sketch);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.selected_materials_list_box);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "BlueprintEditorForm";
            this.Text = "BlueprintEditorForm";
            this.Load += new System.EventHandler(this.BlueprintEditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox selected_materials_list_box;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label name_sketch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_edit_materials;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox size_combo_box;
    }
}