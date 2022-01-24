
namespace Project
{
    partial class DirectorForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.btn_edit_materials = new System.Windows.Forms.Button();
            this.btn_edit_colors = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(64, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Производство";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_edit_materials
            // 
            this.btn_edit_materials.BackColor = System.Drawing.Color.White;
            this.btn_edit_materials.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit_materials.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_edit_materials.Location = new System.Drawing.Point(64, 158);
            this.btn_edit_materials.Name = "btn_edit_materials";
            this.btn_edit_materials.Size = new System.Drawing.Size(164, 43);
            this.btn_edit_materials.TabIndex = 3;
            this.btn_edit_materials.Text = "Редактировать материалы";
            this.btn_edit_materials.UseVisualStyleBackColor = false;
            this.btn_edit_materials.Click += new System.EventHandler(this.btn_edit_materials_Click);
            // 
            // btn_edit_colors
            // 
            this.btn_edit_colors.BackColor = System.Drawing.Color.White;
            this.btn_edit_colors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit_colors.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_edit_colors.Location = new System.Drawing.Point(64, 219);
            this.btn_edit_colors.Name = "btn_edit_colors";
            this.btn_edit_colors.Size = new System.Drawing.Size(164, 43);
            this.btn_edit_colors.TabIndex = 2;
            this.btn_edit_colors.Text = "Редактировать цвета";
            this.btn_edit_colors.UseVisualStyleBackColor = false;
            this.btn_edit_colors.Click += new System.EventHandler(this.btn_edit_colors_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(64, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "Сотрудники";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(310, 326);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_edit_materials);
            this.Controls.Add(this.btn_edit_colors);
            this.Controls.Add(this.button2);
            this.Name = "DirectorForm";
            this.Text = "DirectorForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_edit_materials;
        private System.Windows.Forms.Button btn_edit_colors;
        private System.Windows.Forms.Button button3;
    }
}