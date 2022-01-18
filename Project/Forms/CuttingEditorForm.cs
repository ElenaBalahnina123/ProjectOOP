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

namespace Project.Forms
{
    public partial class CuttingEditorForm : Form
    {
        public CuttingEditorForm()
        {
            InitializeComponent();
        }

        public CuttingEditorForm SetProduct(Product product)
        {

            return this;
        }

        public async Task<Cut> GetCutAsync()
        {
            throw new Exception("not ready");
        }
    }
}
