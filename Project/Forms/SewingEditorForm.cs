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
    public partial class SewingEditorForm : Form
    {
        private Sewing? InitialSewing;

        public EventHandler<Sewing> OnSewingEditor;
        private List<Employee> Employees;
        public SewingEditorForm(AppDbContext db)
        {
            InitializeComponent();
            Employees = (from e in db.Employees select e).ToList();
        }

        public SewingEditorForm SetSewing(Sewing initialSewing)
        {
            InitialSewing = initialSewing;

            employee_combobox.Text = initialSewing.Author.ToString();
            dateTimePicker1.Value = initialSewing.CreationDate;
            return this;
        }

        public async Task<Sewing> SewingAsync(bool showModal = false, bool closeForm = true)
        {
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

            var sewing = await tcs.Task;

            if (!formClosed && closeForm)
            {
                Close();
            }
            return sewing;
        }


        public static async Task<Sewing?> GetSewingAsync(ProgramContext context, Sewing initialSewing = null)
        {
            var form = context.CreateForm<SewingEditorForm>();
            Debug.WriteLine("form created");

            form.SetSewing(initialSewing);

            var tcs = new TaskCompletionSource<Sewing?>();

            var formClosed = false;
            var gotResult = false;

            form.FormClosed += (_, _) =>
            {
                if (formClosed) return;
                formClosed = true;
                tcs.SetResult(null);
            };
            form.OnSewingEditor += (_, sewing) =>
            {
                if (gotResult) return;
                gotResult = true;
                tcs.SetResult(sewing);
            };

            form.Show();

            var sewing = await tcs.Task;

            if (!formClosed)
            {
                form.Close();
            }
            return sewing;
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

            OnSewingEditor.Invoke(this, result);
            Close();
        }
        private void SewingEditorForm_Load(object sender, EventArgs e)
        {
            employee_combobox.DataSource = Employees.ConvertAll(employees => employees.Surname + " " + employees.Name);
        }
    }
}
