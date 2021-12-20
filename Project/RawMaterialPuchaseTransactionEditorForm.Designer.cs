
namespace Project
{
    partial class RawMaterialPuchaseTransactionEditorForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.save_btn_rawTransaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(248, 23);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // save_btn_rawTransaction
            // 
            this.save_btn_rawTransaction.Location = new System.Drawing.Point(20, 52);
            this.save_btn_rawTransaction.Name = "save_btn_rawTransaction";
            this.save_btn_rawTransaction.Size = new System.Drawing.Size(91, 23);
            this.save_btn_rawTransaction.TabIndex = 1;
            this.save_btn_rawTransaction.Text = "Сохранить";
            this.save_btn_rawTransaction.UseVisualStyleBackColor = true;
            this.save_btn_rawTransaction.Click += new System.EventHandler(this.save_btn_rawTransaction_Click);
            // 
            // RawMaterialPuchaseTransactionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 96);
            this.Controls.Add(this.save_btn_rawTransaction);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "RawMaterialPuchaseTransactionEditorForm";
            this.Text = "RawMaterialPuchaseTransactionEditorForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RawMaterialPuchaseTransactionEditorForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button save_btn_rawTransaction;
    }
}