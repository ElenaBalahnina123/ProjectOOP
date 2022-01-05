
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
            this.colors_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_add_new
            // 
            this.btn_add_new.Location = new System.Drawing.Point(491, 12);
            this.btn_add_new.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_new.Name = "btn_add_new";
            this.btn_add_new.Size = new System.Drawing.Size(298, 34);
            this.btn_add_new.TabIndex = 0;
            this.btn_add_new.Text = "Добавить новый цвет";
            this.btn_add_new.UseVisualStyleBackColor = true;
            this.btn_add_new.Click += new System.EventHandler(this.btn_add_new_Click);
            // 
            // colors_list
            // 
            this.colors_list.FormattingEnabled = true;
            this.colors_list.ItemHeight = 25;
            this.colors_list.Location = new System.Drawing.Point(12, 12);
            this.colors_list.Name = "colors_list";
            this.colors_list.Size = new System.Drawing.Size(474, 729);
            this.colors_list.TabIndex = 1;
            // 
            // ColorListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 858);
            this.Controls.Add(this.colors_list);
            this.Controls.Add(this.btn_add_new);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ColorListForm";
            this.Text = "ColorListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add_new;
        private System.Windows.Forms.ListBox colors_list;
    }
}