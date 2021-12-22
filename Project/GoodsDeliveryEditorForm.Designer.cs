
namespace Project
{
    partial class GoodsDeliveryEditorForm
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
            this.amount_label = new System.Windows.Forms.Label();
            this.numeric_amount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.save_btn_position = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_amount)).BeginInit();
            this.SuspendLayout();
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Location = new System.Drawing.Point(21, 28);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(72, 15);
            this.amount_label.TabIndex = 0;
            this.amount_label.Text = "Количество";
            // 
            // numeric_amount
            // 
            this.numeric_amount.Location = new System.Drawing.Point(21, 46);
            this.numeric_amount.Name = "numeric_amount";
            this.numeric_amount.Size = new System.Drawing.Size(120, 23);
            this.numeric_amount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Размер";
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
            this.sizeBox.Location = new System.Drawing.Point(21, 116);
            this.sizeBox.Margin = new System.Windows.Forms.Padding(2);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(120, 23);
            this.sizeBox.TabIndex = 3;
            this.sizeBox.SelectedIndexChanged += new System.EventHandler(this.sizeBox_SelectedIndexChanged);
            // 
            // save_btn_position
            // 
            this.save_btn_position.Location = new System.Drawing.Point(21, 153);
            this.save_btn_position.Name = "save_btn_position";
            this.save_btn_position.Size = new System.Drawing.Size(75, 23);
            this.save_btn_position.TabIndex = 4;
            this.save_btn_position.Text = "Сохранить";
            this.save_btn_position.UseVisualStyleBackColor = true;
            this.save_btn_position.Click += new System.EventHandler(this.save_btn_position_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Добавить товар в поставке";
            // 
            // GoodsDeliveryEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 204);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.save_btn_position);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numeric_amount);
            this.Controls.Add(this.amount_label);
            this.Name = "GoodsDeliveryEditorForm";
            this.Text = "GoodsDeliveryEditorForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GoodsDeliveryEditorForm_FormClosed);
            this.Load += new System.EventHandler(this.GoodsDeliveryEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.NumericUpDown numeric_amount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sizeBox;
        private System.Windows.Forms.Button save_btn_position;
        private System.Windows.Forms.Label label2;
    }
}