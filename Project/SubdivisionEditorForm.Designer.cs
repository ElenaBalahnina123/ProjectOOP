
namespace Project
{
    partial class SubdivisionEditorForm
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
            this.name_subdivision = new System.Windows.Forms.TextBox();
            this.save_btn_subdivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_subdivision
            // 
            this.name_subdivision.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_subdivision.Location = new System.Drawing.Point(12, 12);
            this.name_subdivision.Name = "name_subdivision";
            this.name_subdivision.Size = new System.Drawing.Size(335, 33);
            this.name_subdivision.TabIndex = 1;
            // 
            // save_btn_subdivision
            // 
            this.save_btn_subdivision.Location = new System.Drawing.Point(12, 51);
            this.save_btn_subdivision.Name = "save_btn_subdivision";
            this.save_btn_subdivision.Size = new System.Drawing.Size(101, 23);
            this.save_btn_subdivision.TabIndex = 2;
            this.save_btn_subdivision.Text = " Сохранить";
            this.save_btn_subdivision.UseVisualStyleBackColor = true;
            this.save_btn_subdivision.Click += new System.EventHandler(this.save_btn_subdivision_Click_1);
            // 
            // SubdivisionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 85);
            this.Controls.Add(this.save_btn_subdivision);
            this.Controls.Add(this.name_subdivision);
            this.Name = "SubdivisionEditorForm";
            this.Text = "SubdivisionEditorForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SubdivisionEditorForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save_btn_position
            ;
        private System.Windows.Forms.TextBox name_subdivision;
        private System.Windows.Forms.Button save_btn_subdivision;
    }
}