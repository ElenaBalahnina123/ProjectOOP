﻿
namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.save_product_warehouse = new System.Windows.Forms.Button();
            this.save_resourse_story = new System.Windows.Forms.Button();
            this.saveProductDelivery = new System.Windows.Forms.Button();
            this.save_raw_trancaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить должность";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.save_post);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить подразделение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.save_subdivision);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Добавить сотрудника";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(8, 169);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Добавить цвет";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // save_product_warehouse
            // 
            this.save_product_warehouse.Location = new System.Drawing.Point(8, 131);
            this.save_product_warehouse.Name = "save_product_warehouse";
            this.save_product_warehouse.Size = new System.Drawing.Size(184, 23);
            this.save_product_warehouse.TabIndex = 4;
            this.save_product_warehouse.Text = "Добавить продукт на складе";
            this.save_product_warehouse.UseVisualStyleBackColor = true;
            this.save_product_warehouse.Click += new System.EventHandler(this.save_product_warehouse_Click);
            // 
            // save_resourse_story
            // 
            this.save_resourse_story.Location = new System.Drawing.Point(228, 205);
            this.save_resourse_story.Name = "save_resourse_story";
            this.save_resourse_story.Size = new System.Drawing.Size(159, 23);
            this.save_resourse_story.TabIndex = 5;
            this.save_resourse_story.Text = "Добавить историю";
            this.save_resourse_story.UseVisualStyleBackColor = true;
            this.save_resourse_story.Click += new System.EventHandler(this.save_resourse_story_Click);
            // 
            // saveProductDelivery
            // 
            this.saveProductDelivery.Location = new System.Drawing.Point(12, 245);
            this.saveProductDelivery.Name = "saveProductDelivery";
            this.saveProductDelivery.Size = new System.Drawing.Size(189, 23);
            this.saveProductDelivery.TabIndex = 6;
            this.saveProductDelivery.Text = "Добавить поставку товара";
            this.saveProductDelivery.UseVisualStyleBackColor = true;
            this.saveProductDelivery.Click += new System.EventHandler(this.saveProductDelivery_Click);
            // 
            // save_raw_trancaction
            // 
            this.save_raw_trancaction.Location = new System.Drawing.Point(18, 286);
            this.save_raw_trancaction.Name = "save_raw_trancaction";
            this.save_raw_trancaction.Size = new System.Drawing.Size(234, 23);
            this.save_raw_trancaction.TabIndex = 7;
            this.save_raw_trancaction.Text = "Добавить транзакцию закупки сырья";
            this.save_raw_trancaction.UseVisualStyleBackColor = true;
            this.save_raw_trancaction.Click += new System.EventHandler(this.save_raw_transaction_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(228, 169);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Добавить поставщика";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(8, 205);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(184, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "Добавить вид сырья";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 452);
            this.Controls.Add(this.save_raw_trancaction);
            this.Controls.Add(this.saveProductDelivery);
            this.Controls.Add(this.save_resourse_story);
            this.Controls.Add(this.save_product_warehouse);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button save_product_warehouse;
        private System.Windows.Forms.Button save_resourse_story;
        private System.Windows.Forms.Button saveProductDelivery;
        private System.Windows.Forms.Button save_raw_trancaction;
    }
}

