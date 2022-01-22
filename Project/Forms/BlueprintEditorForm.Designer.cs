
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
            this.look_sketch = new System.Windows.Forms.Button();
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
            this.selected_materials_list_box.ItemHeight = 25;
            this.selected_materials_list_box.Location = new System.Drawing.Point(13, 82);
            this.selected_materials_list_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selected_materials_list_box.Name = "selected_materials_list_box";
            this.selected_materials_list_box.Size = new System.Drawing.Size(401, 154);
            this.selected_materials_list_box.TabIndex = 0;
            // 
            // look_sketch
            // 
            this.look_sketch.Location = new System.Drawing.Point(31, 533);
            this.look_sketch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.look_sketch.Name = "look_sketch";
            this.look_sketch.Size = new System.Drawing.Size(333, 38);
            this.look_sketch.TabIndex = 2;
            this.look_sketch.Text = "Посмотреть художественный эскиз";
            this.look_sketch.UseVisualStyleBackColor = true;
            this.look_sketch.Click += new System.EventHandler(this.look_sketch_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(119, 582);
            this.save_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(144, 38);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = true;

            // 
            // name_sketch
            // 
            this.name_sketch.AutoSize = true;
            this.name_sketch.Location = new System.Drawing.Point(13, 9);
            this.name_sketch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name_sketch.Name = "name_sketch";
            this.name_sketch.Size = new System.Drawing.Size(59, 25);
            this.name_sketch.TabIndex = 4;
            this.name_sketch.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Материалы";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(31, 465);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(331, 31);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 420);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Дата создания";
            // 
            // btn_edit_materials
            // 
            this.btn_edit_materials.Location = new System.Drawing.Point(13, 246);
            this.btn_edit_materials.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_edit_materials.Name = "btn_edit_materials";
            this.btn_edit_materials.Size = new System.Drawing.Size(401, 38);
            this.btn_edit_materials.TabIndex = 10;
            this.btn_edit_materials.Text = "Изменить материалы";
            this.btn_edit_materials.UseVisualStyleBackColor = true;
            this.btn_edit_materials.Click += new System.EventHandler(this.btn_edit_materials_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 317);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Размер";
            // 
            // size_combo_box
            // 
            this.size_combo_box.FormattingEnabled = true;
            this.size_combo_box.Location = new System.Drawing.Point(27, 354);
            this.size_combo_box.Name = "size_combo_box";
            this.size_combo_box.Size = new System.Drawing.Size(335, 33);
            this.size_combo_box.TabIndex = 12;
            // 
            // BlueprintEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 640);
            this.Controls.Add(this.size_combo_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_edit_materials);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_sketch);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.look_sketch);
            this.Controls.Add(this.selected_materials_list_box);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BlueprintEditorForm";
            this.Text = "BlueprintEditorForm";
            this.Load += new System.EventHandler(this.BlueprintEditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox selected_materials_list_box;
        private System.Windows.Forms.Button look_sketch;
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