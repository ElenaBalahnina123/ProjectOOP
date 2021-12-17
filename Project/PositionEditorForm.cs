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
        
        private Position? InitialPosition;

        private TaskCompletionSource<Position> onReady = new TaskCompletionSource<Position>();

        public PositionEditorForm(Position? post)
        {
            InitializeComponent();
            InitialPosition = post;

            if(post != null)
            {
                name_post.Text = post.NamePost;
            }
            
        }


        private void save_btn_position_Click(object sender, EventArgs e)
        {
            var trimmedNamePost = name_post.Text.Trim();

            if (trimmedNamePost.Length == 0)
            {
                MessageBox.Show("Не указана должность");
                return;
            }

            Position resultPosition;
            if (InitialPosition != null)
            {
                resultPosition = new Position()
                {
                    ID = InitialPosition.ID,
                    NamePost = trimmedNamePost

                };
            }
            else
            {
                resultPosition = new Position()
                {
                    NamePost = trimmedNamePost
                };
            };

            onReady.SetResult(resultPosition);
        }

        public static async Task<Position?> EditPosition(Position? initialPosition = null)
        {
            var form = new PositionEditorForm(initialPosition);
            form.Show();
            try
            {
                var post_name = await form.onReady.Task;
                return post_name;
            }
            catch (OperationCanceledException e)
            {
                return null;
            }
            finally
            {
                if (!form.IsDisposed)
                {
                    form.Close();
                }
            }
        }

        private void PositionEditorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                onReady.TrySetCanceled();
            }
            catch (Exception error)
            {

            }
        }
    }
}
