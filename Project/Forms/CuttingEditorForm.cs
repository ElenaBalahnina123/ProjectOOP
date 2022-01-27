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

        public async Task<Cut> EditCutAsync(Cut editingCut, bool showModal = false, bool closeForm = true)
        {
            var stringItems = Employees.ConvertAll(employees => employees.Name + " " + employees.Surname);

            employee_combobox.DataSource = stringItems;

            if (editingCut != null)
            {
                InitialCutting = editingCut;

                var DisplayEmployeeName = editingCut.Author.Name + " " + editingCut.Author.Surname;

                employee_combobox.SelectedIndex = stringItems.IndexOf(DisplayEmployeeName);
                dateTimePicker1.Value = editingCut.CreationDate;
            }

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


            Cut result = InitialCutting ?? new Cut();
            result.CreationDate = dateDevice;
            result.Author = selectedEmployee;

 
            OnCutEditor.Invoke(this, result);
            Close();
        }

        private void CuttingEditorForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
