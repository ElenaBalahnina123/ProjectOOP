
namespace Project
{
    partial class ColorEditor
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
            this.label1 = new System.Windows.Forms.Label();
            this.color_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rgb_value = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название цвета (текстовое)";
            // 
            // color_name
            // 
            this.color_name.Location = new System.Drawing.Point(29, 85);
            this.color_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.color_name.Name = "color_name";
            this.color_name.Size = new System.Drawing.Size(235, 31);
            this.color_name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название цвета (RGB)";
            // 
            // rgb_value
            // 
            this.rgb_value.Location = new System.Drawing.Point(29, 195);
            this.rgb_value.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rgb_value.Name = "rgb_value";
            this.rgb_value.Size = new System.Drawing.Size(235, 31);
            this.rgb_value.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 263);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColorEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 330);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rgb_value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.color_name);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ColorEditor";
            this.Text = "ColorEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox color_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rgb_value;
        private System.Windows.Forms.Button button1;
    }
}