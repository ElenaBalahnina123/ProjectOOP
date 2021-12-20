using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectOop.Entities;

namespace Project
{
    public partial class ResourceRequestHistoryItemEditor : Form
    {
        private ResourceRequestHistoryItem? InitialResourse;
        private TaskCompletionSource<ResourceRequestHistoryItem> onReady = new TaskCompletionSource<ResourceRequestHistoryItem>();
        public ResourceRequestHistoryItemEditor(ResourceRequestHistoryItem? resource)
        {
            InitializeComponent();
            InitialResourse = resource;

            if(resource != null)
            {
                dateStory.Value = resource.Date;
            }
        }

        public static async Task<ResourceRequestHistoryItem?> getResource(ResourceRequestHistoryItem? initialResourse = null)
        {
            var form = new ResourceRequestHistoryItemEditor(initialResourse);
            form.Show();
            try
            {
                var resource = await form.onReady.Task;
                return resource;
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

        private void ResourceRequestHistoryItemEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                onReady.TrySetCanceled();
            }
            catch (Exception error)
            {

            }
        }

        private void save_btn_story_Click(object sender, EventArgs e)
        {
            var date = dateStory.Value;

            var currentDate = DateTime.Now;

            if (date > currentDate)
            {
                MessageBox.Show("Неверная дата");
                return;
            }

            ResourceRequestHistoryItem result;
            if (InitialResourse != null)
            {
                result = new ResourceRequestHistoryItem()
                {
                    ID = InitialResourse.ID,
                    Date = dateStory.Value

                };
            }
            else
            {
                result = new ResourceRequestHistoryItem()
                {
                    Date = dateStory.Value
                };
            };
            onReady.SetResult(result);
        }
    }
}
