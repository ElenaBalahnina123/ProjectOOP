
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.add_material = new System.Windows.Forms.Button();
            this.look_sketch = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.name_sketch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 72);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(359, 214);
            this.listBox1.TabIndex = 0;
            // 
            // add_material
            // 
            this.add_material.Location = new System.Drawing.Point(83, 308);
            this.add_material.Name = "add_material";
            this.add_material.Size = new System.Drawing.Size(201, 23);
            this.add_material.TabIndex = 1;
            this.add_material.Text = "Добавить материал";
            this.add_material.UseVisualStyleBackColor = true;
            // 
            // look_sketch
            // 
            this.look_sketch.Location = new System.Drawing.Point(73, 337);
            this.look_sketch.Name = "look_sketch";
            this.look_sketch.Size = new System.Drawing.Size(233, 23);
            this.look_sketch.TabIndex = 2;
            this.look_sketch.Text = "Посмотреть художественный эскиз";
            this.look_sketch.UseVisualStyleBackColor = true;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(149, 366);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 3;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = true;
            // 
            // name_sketch
            // 
            this.name_sketch.AutoSize = true;
            this.name_sketch.Location = new System.Drawing.Point(149, 24);
            this.name_sketch.Name = "name_sketch";
            this.name_sketch.Size = new System.Drawing.Size(38, 15);
            this.name_sketch.TabIndex = 4;
            this.name_sketch.Text = "label1";
            // 
            // BlueprintEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 433);
            this.Controls.Add(this.name_sketch);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.look_sketch);
            this.Controls.Add(this.add_material);
            this.Controls.Add(this.listBox1);
            this.Name = "BlueprintEditorForm";
            this.Text = "BlueprintEditorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button add_material;
        private System.Windows.Forms.Button look_sketch;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Label name_sketch;
    }
}