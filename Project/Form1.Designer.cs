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
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.save_btn_RawMaterialItem = new System.Windows.Forms.Button();
            this.save_btn_goodsDelivery = new System.Windows.Forms.Button();
            this.save_btn_transactionContents = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить должность";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.save_post);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 26);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить подразделение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.save_subdivision);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Добавить сотрудника";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(161, 282);
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
            this.save_product_warehouse.Location = new System.Drawing.Point(8, 110);
            this.save_product_warehouse.Name = "save_product_warehouse";
            this.save_product_warehouse.Size = new System.Drawing.Size(184, 29);
            this.save_product_warehouse.TabIndex = 4;
            this.save_product_warehouse.Text = "Добавить товар на склад";
            this.save_product_warehouse.UseVisualStyleBackColor = true;
            this.save_product_warehouse.Click += new System.EventHandler(this.save_product_warehouse_Click);
            // 
            // save_resourse_story
            // 
            this.save_resourse_story.Location = new System.Drawing.Point(288, 19);
            this.save_resourse_story.Name = "save_resourse_story";
            this.save_resourse_story.Size = new System.Drawing.Size(159, 23);
            this.save_resourse_story.TabIndex = 5;
            this.save_resourse_story.Text = "Добавить историю";
            this.save_resourse_story.UseVisualStyleBackColor = true;
            this.save_resourse_story.Click += new System.EventHandler(this.save_resourse_story_Click);
            // 
            // saveProductDelivery
            // 
            this.saveProductDelivery.Location = new System.Drawing.Point(8, 179);
            this.saveProductDelivery.Name = "saveProductDelivery";
            this.saveProductDelivery.Size = new System.Drawing.Size(189, 23);
            this.saveProductDelivery.TabIndex = 6;
            this.saveProductDelivery.Text = "Добавить поставку товара";
            this.saveProductDelivery.UseVisualStyleBackColor = true;
            this.saveProductDelivery.Click += new System.EventHandler(this.saveProductDelivery_Click);
            // 
            // save_raw_trancaction
            // 
            this.save_raw_trancaction.Location = new System.Drawing.Point(8, 208);
            this.save_raw_trancaction.Name = "save_raw_trancaction";
            this.save_raw_trancaction.Size = new System.Drawing.Size(234, 23);
            this.save_raw_trancaction.TabIndex = 7;
            this.save_raw_trancaction.Text = "Добавить транзакцию закупки сырья";
            this.save_raw_trancaction.UseVisualStyleBackColor = true;
            this.save_raw_trancaction.Click += new System.EventHandler(this.save_raw_transaction_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(288, 208);
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
            // save_btn_RawMaterialItem
            // 
            this.save_btn_RawMaterialItem.Location = new System.Drawing.Point(8, 145);
            this.save_btn_RawMaterialItem.Name = "save_btn_RawMaterialItem";
            this.save_btn_RawMaterialItem.Size = new System.Drawing.Size(184, 23);
            this.save_btn_RawMaterialItem.TabIndex = 7;
            this.save_btn_RawMaterialItem.Text = "Добавить сырье на склад";
            this.save_btn_RawMaterialItem.UseVisualStyleBackColor = true;
            this.save_btn_RawMaterialItem.Click += new System.EventHandler(this.button6_Click);
            // 
            // save_btn_goodsDelivery
            // 
            this.save_btn_goodsDelivery.Location = new System.Drawing.Point(8, 237);
            this.save_btn_goodsDelivery.Name = "save_btn_goodsDelivery";
            this.save_btn_goodsDelivery.Size = new System.Drawing.Size(184, 23);
            this.save_btn_goodsDelivery.TabIndex = 8;
            this.save_btn_goodsDelivery.Text = "Добавить товар в поставке";
            this.save_btn_goodsDelivery.UseVisualStyleBackColor = true;
            this.save_btn_goodsDelivery.Click += new System.EventHandler(this.save_btn_goodsDelivery_Click);
            // 
            // save_btn_transactionContents
            // 
            this.save_btn_transactionContents.Location = new System.Drawing.Point(288, 237);
            this.save_btn_transactionContents.Name = "save_btn_transactionContents";
            this.save_btn_transactionContents.Size = new System.Drawing.Size(265, 23);
            this.save_btn_transactionContents.TabIndex = 9;
            this.save_btn_transactionContents.Text = "Добавить содержимое транзакции";
            this.save_btn_transactionContents.UseVisualStyleBackColor = true;
            this.save_btn_transactionContents.Click += new System.EventHandler(this.save_btn_transactionContents_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(288, 52);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(230, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Добавить содержимое запроса сырья";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.save_ResourceRequestItem_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(288, 81);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(199, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "Добавить материал для раскроя";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.save_MaterialCutting);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(288, 110);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(226, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "Добавить информацию о магазине";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.save_Shop);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(288, 145);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(103, 23);
            this.button9.TabIndex = 13;
            this.button9.Text = "Добавить эскиз";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.save_Sketch);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(288, 179);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(234, 23);
            this.button10.TabIndex = 14;
            this.button10.Text = "Добавить материализацию эскиза";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.save_SketchMaterialization);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 331);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.save_btn_transactionContents);
            this.Controls.Add(this.save_btn_goodsDelivery);
            this.Controls.Add(this.save_raw_trancaction);
            this.Controls.Add(this.saveProductDelivery);
            this.Controls.Add(this.save_resourse_story);
            this.Controls.Add(this.save_btn_RawMaterialItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.save_product_warehouse);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save_btn_RawMaterialItem;
        private System.Windows.Forms.Button save_btn_goodsDelivery;
        private System.Windows.Forms.Button save_btn_transactionContents;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

