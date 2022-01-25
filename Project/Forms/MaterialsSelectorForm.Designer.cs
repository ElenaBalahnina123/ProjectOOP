
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
            // materials_checked_list_box
            // 
            this.materials_checked_list_box.FormattingEnabled = true;
            this.materials_checked_list_box.Location = new System.Drawing.Point(24, 20);
            this.materials_checked_list_box.Name = "materials_checked_list_box";
            this.materials_checked_list_box.Size = new System.Drawing.Size(303, 259);
            this.materials_checked_list_box.TabIndex = 0;
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.White;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save_btn.Location = new System.Drawing.Point(126, 298);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(90, 25);
            this.save_btn.TabIndex = 1;
            this.save_btn.Text = "Готово";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // MaterialsSelectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(374, 346);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.materials_checked_list_box);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "MaterialsSelectorForm";
            this.Text = "AddMaterials";
            this.Load += new System.EventHandler(this.AddMaterials_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox materials_checked_list_box;
        private System.Windows.Forms.Button save_btn;
    }
}