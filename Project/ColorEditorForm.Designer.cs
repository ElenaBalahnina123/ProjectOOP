
namespace Project
{
    partial class ColorEditorForm
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
            this.btn_save = new System.Windows.Forms.Button();
            this.color_string_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rgb_value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(8, 113);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(94, 25);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // color_string_name
            // 
            this.color_string_name.Location = new System.Drawing.Point(8, 22);
            this.color_string_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.color_string_name.Name = "color_string_name";
            this.color_string_name.Size = new System.Drawing.Size(307, 23);
            this.color_string_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Текстовое название цвета (напр. розовый)";
            // 
            // rgb_value
            // 
            this.rgb_value.Location = new System.Drawing.Point(8, 76);
            this.rgb_value.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rgb_value.Name = "rgb_value";
            this.rgb_value.Size = new System.Drawing.Size(307, 23);
            this.rgb_value.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Машинное представление (RGB)";
            // 
            // ColorEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 157);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rgb_value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.color_string_name);
            this.Controls.Add(this.btn_save);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ColorEditorForm";
            this.Text = "ColorEditorForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ColorEditorForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox color_string_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rgb_value;
        private System.Windows.Forms.Label label2;
    }
}