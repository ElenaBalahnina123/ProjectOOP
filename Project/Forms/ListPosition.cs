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
    public partial class ListPosition : Form
    {
        public ListPosition()
        {
            InitializeComponent();
        }

        private async void save_position_Click(object sender, EventArgs e)
        {
            var post_name = await PositionEditorForm.EditPosition();
            if (post_name != null)
            {
                LoadPositions();
            }
           
        }

        private async void LoadPositions()
        {
            AppContext.g
        }

        
    }
}
