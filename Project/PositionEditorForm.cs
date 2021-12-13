using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class PositionEditorForm : Form
    {
        private TaskCompletionSource<string?> onReady = new TaskCompletionSource<string>();

        public PositionEditorForm(string? post)
        {
            InitializeComponent();

            if(post != null) 
            {
                textBox1.Text = post;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*postReadyEventHandler.Invoke(this, textBox1.Text);*/
            onReady.SetResult(textBox1.Text);
        }

        public async Task<string?> getPostNameAsync()
        {
            Show();
            var result = await onReady.Task;
            Close();
            return result;
        }

        private void PositionEditorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
