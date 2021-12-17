
namespace Project
{
    partial class PositionEditorForm
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
            this.name_post = new System.Windows.Forms.TextBox();
            this.save_btn_position = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_post
            // 
            this.name_post.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_post.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_post.Location = new System.Drawing.Point(8, 7);
            this.name_post.Margin = new System.Windows.Forms.Padding(2);
            this.name_post.Name = "name_post";
            this.name_post.Size = new System.Drawing.Size(326, 32);
            this.name_post.TabIndex = 0;
            // 
            // save_btn_position
            // 
            this.save_btn_position.Location = new System.Drawing.Point(15, 51);
            this.save_btn_position.Name = "save_btn_position";
            this.save_btn_position.Size = new System.Drawing.Size(75, 23);
            this.save_btn_position.TabIndex = 1;
            this.save_btn_position.Text = "Сохранить";
            this.save_btn_position.UseVisualStyleBackColor = true;
            this.save_btn_position.Click += new System.EventHandler(this.save_btn_position_Click);
            // 
            // PositionEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 74);
            this.Controls.Add(this.save_btn_position);
            this.Controls.Add(this.name_post);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PositionEditorForm";
            this.Text = "S";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PositionEditorForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_post;
        private System.Windows.Forms.Button save_btn_position;
    }
}