
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
            this.label3 = new System.Windows.Forms.Label();
            this.colorInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sizeBox
            // 
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.Items.AddRange(new object[] {
            "Маленький",
            "Средний",
            "Большой"});
            this.sizeBox.Location = new System.Drawing.Point(12, 37);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(182, 33);
            this.sizeBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Размер";
            // 
            // amountInput
            // 
            this.amountInput.Location = new System.Drawing.Point(12, 165);
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(182, 31);
            this.amountInput.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цвет";
            // 
            // colorInput
            // 
            this.colorInput.Location = new System.Drawing.Point(12, 296);
            this.colorInput.Name = "colorInput";
            this.colorInput.Size = new System.Drawing.Size(182, 31);
            this.colorInput.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductOnWarehouseEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.colorInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amountInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sizeBox);
            this.Name = "ProductOnWarehouseEditor";
            this.Text = "ProductOnWarehouseEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sizeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox amountInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox colorInput;
        private System.Windows.Forms.Button button1;
    }
}