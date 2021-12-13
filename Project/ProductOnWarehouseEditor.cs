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
    public partial class ProductOnWarehouseEditor : Form
    {
        private TaskCompletionSource<ProductOnWarehouseEditorResult> tcs = new TaskCompletionSource<ProductOnWarehouseEditorResult>();

        public ProductOnWarehouseEditor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: проверки
            tcs.SetResult(new ProductOnWarehouseEditorResult
            {
                Size = sizeBox.SelectedIndex, 
                Amount = Int32.Parse(amountInput.Text),
                Color = colorInput.Text
            });
        }

        public async Task<ProductOnWarehouseEditorResult> GetEditorResult()
        {
            Show();
            var data = await tcs.Task;
            Close();
            return data;
        }
    }

    public class ProductOnWarehouseEditorResult
    {
        public int Amount { get; set; }

        public string Color { get; set; }

        public int Size { get; set; }
    }
}
