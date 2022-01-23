
namespace Project
{
    partial class DesignerForm
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
            this.btn_edit_colors = new System.Windows.Forms.Button();
            this.btn_edit_materials = new System.Windows.Forms.Button();
            this.btn_production = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_edit_colors
            // 
            this.btn_edit_colors.Location = new System.Drawing.Point(89, 48);
            this.btn_edit_colors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_edit_colors.Name = "btn_edit_colors";
            this.btn_edit_colors.Size = new System.Drawing.Size(271, 72);
            this.btn_edit_colors.TabIndex = 0;
            this.btn_edit_colors.Text = "Редактировать цвета";
            this.btn_edit_colors.UseVisualStyleBackColor = true;
            this.btn_edit_colors.Click += new System.EventHandler(this.btn_edit_colors_Click);
            // 
            // btn_edit_materials
            // 
            this.btn_edit_materials.Location = new System.Drawing.Point(89, 150);
            this.btn_edit_materials.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_edit_materials.Name = "btn_edit_materials";
            this.btn_edit_materials.Size = new System.Drawing.Size(271, 72);
            this.btn_edit_materials.TabIndex = 1;
            this.btn_edit_materials.Text = "Редактировать материалы";
            this.btn_edit_materials.UseVisualStyleBackColor = true;
            this.btn_edit_materials.Click += new System.EventHandler(this.btn_edit_materials_Click);
            // 
            // btn_production
            // 
            this.btn_production.Location = new System.Drawing.Point(89, 271);
            this.btn_production.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_production.Name = "btn_production";
            this.btn_production.Size = new System.Drawing.Size(271, 72);
            this.btn_production.TabIndex = 2;
            this.btn_production.Text = "Производство";
            this.btn_production.UseVisualStyleBackColor = true;
            this.btn_production.Click += new System.EventHandler(this.btn_production_Click);
            // 
            // DesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 390);
            this.Controls.Add(this.btn_production);
            this.Controls.Add(this.btn_edit_materials);
            this.Controls.Add(this.btn_edit_colors);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DesignerForm";
            this.Text = "Form00";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_edit_colors;
        private System.Windows.Forms.Button btn_edit_materials;
        private System.Windows.Forms.Button btn_production;
    }
}