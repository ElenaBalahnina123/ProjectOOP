
namespace Project
{
    partial class ResourceRequestHistoryItemEditor
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
            this.dateStory = new System.Windows.Forms.DateTimePicker();
            this.save_btn_story = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateStory
            // 
            this.dateStory.Location = new System.Drawing.Point(12, 12);
            this.dateStory.Name = "dateStory";
            this.dateStory.Size = new System.Drawing.Size(242, 23);
            this.dateStory.TabIndex = 0;
            // 
            // save_btn_story
            // 
            this.save_btn_story.Location = new System.Drawing.Point(8, 50);
            this.save_btn_story.Name = "save_btn_story";
            this.save_btn_story.Size = new System.Drawing.Size(96, 23);
            this.save_btn_story.TabIndex = 1;
            this.save_btn_story.Text = "Сохранить";
            this.save_btn_story.UseVisualStyleBackColor = true;
            this.save_btn_story.Click += new System.EventHandler(this.save_btn_story_Click);
            // 
            // ResourceRequestHistoryItemEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 86);
            this.Controls.Add(this.save_btn_story);
            this.Controls.Add(this.dateStory);
            this.Name = "ResourceRequestHistoryItemEditor";
            this.Text = "ResourceRequestHistoryItemEditor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ResourceRequestHistoryItemEditor_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateStory;
        private System.Windows.Forms.Button save_btn_story;
    }
}