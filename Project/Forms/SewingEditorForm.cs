using Microsoft.EntityFrameworkCore;
using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class SewingEditorForm : Form
    {
        private Sewing? InitialSewing;

        public EventHandler<Sewing> OnSewingEditor;
        private List<Employee> Employees;

        private readonly AppDbContext db;

        public SewingEditorForm(AppDbContext dbContext)
        {
            db = dbContext;
            InitializeComponent();
            Employees = db.Employees.ToList();
            employee_combobox.DataSource = Employees.ConvertAll(employees => employees.Name + " " + employees.Surname);
        }

        private void save_btn_Click_1(object sender, EventArgs e)
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

            Sewing result = InitialSewing ?? new Sewing();
            result.CreationDate = dateDevice;
            result.Author = selectedEmployee;

            OnSewingEditor?.Invoke(this, result);
            Close();
        }

        public async Task<Sewing> EditSewingAsync(Sewing editingSewing, bool showModal = false, bool closeForm = true)
        {
            var stringItems = Employees.ConvertAll(employees => employees.Name + " " + employees.Surname);

            employee_combobox.DataSource = stringItems;

            if (editingSewing != null)
            {
                InitialSewing = editingSewing;

                var DisplayEmployeeName = editingSewing.Author.Name + " " + editingSewing.Author.Surname;

                employee_combobox.SelectedIndex = stringItems.IndexOf(DisplayEmployeeName);
                dateTimePicker1.Value = editingSewing.CreationDate;
            }

            var tcs = new TaskCompletionSource<Sewing?>();

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
            OnSewingEditor += (_, sewing) =>
            {
                if (gotResult) return;
                gotResult = true;
                tcs.SetResult(sewing);
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
    }
}
