
namespace Project.Forms
{
    partial class MaterialsSelectorForm
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
            this.materials_checked_list_box = new System.Windows.Forms.CheckedListBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.materials_checked_list_box.FormattingEnabled = true;
            this.materials_checked_list_box.Location = new System.Drawing.Point(30, 35);
            this.materials_checked_list_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.materials_checked_list_box.Name = "checkedListBox1";
            this.materials_checked_list_box.Size = new System.Drawing.Size(378, 480);
            this.materials_checked_list_box.TabIndex = 0;
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(303, 562);
            this.save_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(107, 38);
            this.save_btn.TabIndex = 1;
            this.save_btn.Text = "Готово";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // AddMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 667);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.materials_checked_list_box);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddMaterials";
            this.Text = "AddMaterials";
            this.Load += new System.EventHandler(this.AddMaterials_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox materials_checked_list_box;
        private System.Windows.Forms.Button save_btn;
    }
}