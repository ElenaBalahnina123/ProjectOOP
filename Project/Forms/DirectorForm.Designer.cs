﻿
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_edit_materials = new System.Windows.Forms.Button();
            this.btn_edit_colors = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сотрудники";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Производство";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_edit_materials
            // 
            this.btn_edit_materials.Location = new System.Drawing.Point(64, 194);
            this.btn_edit_materials.Name = "btn_edit_materials";
            this.btn_edit_materials.Size = new System.Drawing.Size(190, 43);
            this.btn_edit_materials.TabIndex = 3;
            this.btn_edit_materials.Text = "Редактировать материалы";
            this.btn_edit_materials.UseVisualStyleBackColor = true;
            this.btn_edit_materials.Click += new System.EventHandler(this.btn_edit_materials_Click);
            // 
            // btn_edit_colors
            // 
            this.btn_edit_colors.Location = new System.Drawing.Point(64, 133);
            this.btn_edit_colors.Name = "btn_edit_colors";
            this.btn_edit_colors.Size = new System.Drawing.Size(190, 43);
            this.btn_edit_colors.TabIndex = 2;
            this.btn_edit_colors.Text = "Редактировать цвета";
            this.btn_edit_colors.UseVisualStyleBackColor = true;
            this.btn_edit_colors.Click += new System.EventHandler(this.btn_edit_colors_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(64, 263);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 20);
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 326);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_edit_materials);
            this.Controls.Add(this.btn_edit_colors);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "DirectorForm";
            this.Text = "DirectorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_edit_materials;
        private System.Windows.Forms.Button btn_edit_colors;
        private System.Windows.Forms.Button button3;
    }
}