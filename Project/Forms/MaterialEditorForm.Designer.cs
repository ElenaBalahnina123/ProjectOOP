
namespace Project.Forms
{
    partial class MaterialEditorForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.material_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_color = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название материала";
            // 
            // material_name
            // 
            this.material_name.Location = new System.Drawing.Point(24, 31);
            this.material_name.Name = "material_name";
            this.material_name.Size = new System.Drawing.Size(209, 23);
            this.material_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Цвет";
            // 
            // comboBox_color
            // 
            this.comboBox_color.FormattingEnabled = true;
            this.comboBox_color.Location = new System.Drawing.Point(24, 95);
            this.comboBox_color.Name = "comboBox_color";
            this.comboBox_color.Size = new System.Drawing.Size(209, 23);
            this.comboBox_color.TabIndex = 4;
            // 
            // MaterialEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 199);
            this.Controls.Add(this.comboBox_color);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.material_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "MaterialEditorForm";
            this.Text = "MaterialEditorForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MaterialEditorForm_FormClosed);
            this.Load += new System.EventHandler(this.MaterialEditorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox material_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_color;
    }
}