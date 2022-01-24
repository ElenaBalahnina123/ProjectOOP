
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
            this.selected_materials_list_box.FormattingEnabled = true;
            this.selected_materials_list_box.ItemHeight = 20;
            this.selected_materials_list_box.Location = new System.Drawing.Point(10, 65);
            this.selected_materials_list_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.selected_materials_list_box.Name = "selected_materials_list_box";
            this.selected_materials_list_box.Size = new System.Drawing.Size(322, 124);
            this.selected_materials_list_box.TabIndex = 0;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(95, 456);
            this.save_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(134, 40);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // name_sketch
            // 
            this.name_sketch.AutoSize = true;
            this.name_sketch.Location = new System.Drawing.Point(10, 7);
            this.name_sketch.Name = "name_sketch";
            this.name_sketch.Size = new System.Drawing.Size(50, 20);
            this.name_sketch.TabIndex = 4;
            this.name_sketch.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Материалы";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 372);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 27);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Дата создания";
            // 
            // btn_edit_materials
            // 
            this.btn_edit_materials.Location = new System.Drawing.Point(9, 209);
            this.btn_edit_materials.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_edit_materials.Name = "btn_edit_materials";
            this.btn_edit_materials.Size = new System.Drawing.Size(321, 31);
            this.btn_edit_materials.TabIndex = 10;
            this.btn_edit_materials.Text = "Изменить материалы";
            this.btn_edit_materials.UseVisualStyleBackColor = true;
            this.btn_edit_materials.Click += new System.EventHandler(this.btn_edit_materials_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Размер";
            // 
            // size_combo_box
            // 
            this.size_combo_box.FormattingEnabled = true;
            this.size_combo_box.Location = new System.Drawing.Point(25, 276);
            this.size_combo_box.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.size_combo_box.Name = "size_combo_box";
            this.size_combo_box.Size = new System.Drawing.Size(269, 28);
            this.size_combo_box.TabIndex = 12;
            // 
            // BlueprintEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 512);
            this.Controls.Add(this.size_combo_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_edit_materials);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_sketch);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.selected_materials_list_box);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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