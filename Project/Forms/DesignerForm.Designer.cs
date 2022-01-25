
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
            this.btn_edit_colors.BackColor = System.Drawing.Color.White;
            this.btn_edit_colors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit_colors.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_edit_colors.Location = new System.Drawing.Point(66, 141);
            this.btn_edit_colors.Name = "btn_edit_colors";
            this.btn_edit_colors.Size = new System.Drawing.Size(217, 40);
            this.btn_edit_colors.TabIndex = 0;
            this.btn_edit_colors.Text = "Редактировать цвета";
            this.btn_edit_colors.UseVisualStyleBackColor = false;
            this.btn_edit_colors.Click += new System.EventHandler(this.btn_edit_colors_Click);
            // 
            // btn_edit_materials
            // 
            this.btn_edit_materials.BackColor = System.Drawing.Color.White;
            this.btn_edit_materials.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit_materials.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_edit_materials.Location = new System.Drawing.Point(66, 82);
            this.btn_edit_materials.Name = "btn_edit_materials";
            this.btn_edit_materials.Size = new System.Drawing.Size(217, 40);
            this.btn_edit_materials.TabIndex = 1;
            this.btn_edit_materials.Text = "Редактировать материалы";
            this.btn_edit_materials.UseVisualStyleBackColor = false;
            this.btn_edit_materials.Click += new System.EventHandler(this.btn_edit_materials_Click);
            // 
            // btn_production
            // 
            this.btn_production.BackColor = System.Drawing.Color.White;
            this.btn_production.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_production.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_production.Location = new System.Drawing.Point(66, 20);
            this.btn_production.Name = "btn_production";
            this.btn_production.Size = new System.Drawing.Size(217, 40);
            this.btn_production.TabIndex = 2;
            this.btn_production.Text = "Производство";
            this.btn_production.UseVisualStyleBackColor = false;
            this.btn_production.Click += new System.EventHandler(this.btn_production_Click);
            // 
            // DesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(346, 218);
            this.Controls.Add(this.btn_production);
            this.Controls.Add(this.btn_edit_materials);
            this.Controls.Add(this.btn_edit_colors);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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