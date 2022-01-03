
namespace Project
{
    partial class ListPosition
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
            this.save_position = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // save_position
            // 
            this.save_position.Location = new System.Drawing.Point(376, 353);
            this.save_position.Name = "save_position";
            this.save_position.Size = new System.Drawing.Size(171, 35);
            this.save_position.TabIndex = 0;
            this.save_position.Text = "Добавить должность";
            this.save_position.UseVisualStyleBackColor = true;
            this.save_position.Click += new System.EventHandler(this.save_position_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(27, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(520, 289);
            this.listBox1.TabIndex = 1;

            // 
            // ListPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.save_position);
            this.Name = "ListPosition";
            this.Text = "ListPosition";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button save_position;
        private System.Windows.Forms.ListBox listBox1;
    }
}