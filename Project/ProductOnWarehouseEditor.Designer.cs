
namespace Project
{
    partial class ProductOnWarehouseEditor
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
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amountInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sizeBox
            // 
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.Items.AddRange(new object[] {
            "40",
            "42",
            "44",
            "46",
            "48",
            "50"});
            this.sizeBox.Location = new System.Drawing.Point(8, 22);
            this.sizeBox.Margin = new System.Windows.Forms.Padding(2);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(129, 23);
            this.sizeBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Размер";
            // 
            // amountInput
            // 
            this.amountInput.Location = new System.Drawing.Point(8, 82);
            this.amountInput.Margin = new System.Windows.Forms.Padding(2);
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(129, 23);
            this.amountInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 119);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.save_btn_prOnWerehouse);
            // 
            // ProductOnWarehouseEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 163);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProductOnWarehouseEditor";
            this.Text = "ProductOnWarehouseEditor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductOnWarehouseEditor_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sizeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}