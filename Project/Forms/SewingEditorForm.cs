using Microsoft.EntityFrameworkCore;
using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        }

        private async void SewingEditorForm_Load(object sender, EventArgs e)
        {
            Employees = await db.Employees.ToListAsync();

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

            Sewing result;
            if (InitialSewing != null)
            {
                result = new Sewing()
                {
                    ID = InitialSewing.ID,
                    Author = selectedEmployee,
                    CreationDate = dateDevice,

                };
            }
            else
            {
                result = new Sewing()
                {
                    Author = selectedEmployee,
                    CreationDate = dateDevice,
                };
            };

            OnSewingEditor?.Invoke(this, result);
            Close();
        }

        public async Task<Sewing> EditSewingAsync(Product product)
        {
            if (product.Sewing != null)
            {
                InitialSewing = product.Sewing;
                employee_combobox.Text = InitialSewing.Author.ToString();
                dateTimePicker1.Value = InitialSewing.CreationDate;
            }

            var tcs = new TaskCompletionSource<Sewing?>();

            var formClosed = false;
            var gotResult = false;

            FormClosed += (_, _) =>
            {
                Debug.WriteLine("form closed");
                if (formClosed) return;
                formClosed = true;
                if (!gotResult)
                {
                    gotResult = true;
                    tcs.SetResult(null);
                }
            };
            OnSewingEditor += (_, sewing) =>
            {
                Debug.WriteLine("got result");
                if (gotResult) return;
                gotResult = true;
                tcs.SetResult(sewing);
            };

            Debug.WriteLine("await sewing");
            var sewing = await tcs.Task;
            Debug.WriteLine("got sewing");

            if (!formClosed)
            {
                Close();
            }
            return sewing;
        }

    }
}
