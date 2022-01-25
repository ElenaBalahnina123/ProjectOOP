using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class CuttingEditorForm : Form
    {
        private Cut? InitialCutting;

        public EventHandler<Cut> OnCutEditor;
        private List<Employee> Employees;
        public CuttingEditorForm(AppDbContext db)
        {
            InitializeComponent();
            Employees = (from e in db.Employees select e).ToList();
        }

        public CuttingEditorForm SetCutting(Cut? initialCut)
        {
            if (initialCut == null) return this;

            InitialCutting = initialCut;

            employee_combobox.Text = initialCut.Author.ToString();
            dateTimePicker1.Value = initialCut.CreationDate;
            return this;
        }

        public async Task<Cut> CutAsync(bool showModal = false, bool closeForm = true)
        {
            var tcs = new TaskCompletionSource<Cut?>();

            var formClosed = false;
            var gotResult = false;

            FormClosed += (_, _) =>
            {
                if (formClosed) return;
                formClosed = true;
                if (!gotResult)
                {
                    tcs.SetResult(null);
                }
            };
            OnCutEditor += (_, cut) =>
            {
                if (gotResult) return;
                gotResult = true;
                tcs.SetResult(cut);
            };

            if (showModal)
            {
                ShowDialog();
            }

            var cut = await tcs.Task;

            if (!formClosed && closeForm)
            {
                Close();
            }
            return cut;
        }


        
        private void save_btn_Click(object sender, EventArgs e)
        {
            if (employee_combobox.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран автор");
                return;
            }

            var selectedEmployee = Employees[employee_combobox.SelectedIndex];



            var dateDevice = dateTimePicker1.Value;

            var currentDate = DateTime.Now;

            if (dateDevice > currentDate)
            {
                MessageBox.Show("Неверная дата");
                return;
            }



            Cut result;
            if (InitialCutting != null)
            {
                result = new Cut()
                {
                    ID = InitialCutting.ID,
                    Author = selectedEmployee,
                    CreationDate = dateDevice,

                };
            }
            else
            {
                result = new Cut()
                {
                    Author = selectedEmployee,
                    CreationDate = dateDevice,
                };
            };

            OnCutEditor.Invoke(this, result);
            Close();
        }

        private void CuttingEditorForm_Load(object sender, EventArgs e)
        {
            employee_combobox.DataSource = Employees.ConvertAll(employees => employees.Name + " " + employees.Surname);
        }
    }
}
