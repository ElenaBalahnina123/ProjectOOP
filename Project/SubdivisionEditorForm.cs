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
    public partial class SubdivisionEditorForm : Form
    {
        private TaskCompletionSource<string?> onReady = new TaskCompletionSource<string>();

        public SubdivisionEditorForm(string? subdivision)
        {
            InitializeComponent();

            if (subdivision != null)
            {
                textBox1.Text = subdivision;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            onReady.SetResult(textBox1.Text);
        }

        public async Task<string?> getSubdivisionNameAsync()
        {
            Show();
            var result = await onReady.Task;
            Close();
            return result;
        }
    }
}
