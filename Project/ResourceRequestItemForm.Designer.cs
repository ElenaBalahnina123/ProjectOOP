﻿namespace Project
{
    partial class ResourceRequestItemForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numeric_amount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_amount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Содержимое запроса сырья";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Количество:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.save_btn_ResourceRequestItem_Click);
            // 
            // numeric_amount
            // 
            this.numeric_amount.Location = new System.Drawing.Point(12, 52);
            this.numeric_amount.Name = "numeric_amount";
            this.numeric_amount.Size = new System.Drawing.Size(100, 23);
            this.numeric_amount.TabIndex = 6;
            this.numeric_amount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ResourceRequestItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 122);
            this.Controls.Add(this.numeric_amount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ResourceRequestItemForm";
            this.Text = "ResourceRequestItemForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResourceRequestItemForm_FormClosed);
            this.Load += new System.EventHandler(this.ResourceRequestItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numeric_amount;
    }
}