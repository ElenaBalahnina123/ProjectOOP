
namespace Project
{
    partial class ColorListForm
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
            this.btn_add_new = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_add_new
            // 
            this.btn_add_new.Location = new System.Drawing.Point(425, 791);
            this.btn_add_new.Name = "btn_add_new";
            this.btn_add_new.Size = new System.Drawing.Size(298, 34);
            this.btn_add_new.TabIndex = 0;
            this.btn_add_new.Text = "Добавить новый цвет";
            this.btn_add_new.UseVisualStyleBackColor = true;
            this.btn_add_new.Click += new System.EventHandler(this.btn_add_new_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(545, 629);
            this.listBox1.TabIndex = 1;
            // 
            // ColorListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 858);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_add_new);
            this.Name = "ColorListForm";
            this.Text = "ColorListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add_new;
        private System.Windows.Forms.ListBox listBox1;
    }
}