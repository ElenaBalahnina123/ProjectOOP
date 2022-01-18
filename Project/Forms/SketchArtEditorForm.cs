using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Forms
{
    public partial class SketchArtEditorForm : Form
    {

        private Sketch? InitialSketch;

        public EventHandler<Sketch> OnSketchEditor;
        private List<Employee> Employees;
        public SketchArtEditorForm(AppDbContext db)
        {
            InitializeComponent();

            Employees = (from e in db.Employees select e).ToList();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

            var trimmedName = textBox1.Text.Trim();
            if (trimmedName.Length == 0)
            {
                MessageBox.Show("Не указано название");
                return;
            }
            var location = textBox2.Text.Trim();
            if (location.Length == 0)
            {
                MessageBox.Show("Не указано расположение");
                return;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран автор");
                return;
            }

            var selectedEmployee = Employees[comboBox1.SelectedIndex];


           
            var dateDevice = dateTimePicker1.Value;

            var currentDate = DateTime.Now;

            if (dateDevice > currentDate)
            {
                MessageBox.Show("Неверная дата");
                return;
            }

           

            Sketch result;
            if (InitialSketch != null)
            {
                result = new Sketch()
                {
                    ID = InitialSketch.ID,
                    Name = trimmedName,
                    FileLocation = location,
                    Author = selectedEmployee,
                    CreationDate = dateDevice,
                    
                };
            }
            else
            {
                result = new Sketch()
                {
                    Name = trimmedName,
                    FileLocation = location,
                    Author = selectedEmployee,
                    CreationDate = dateDevice,
                };
            };

            OnSketchEditor.Invoke(this, result);
            Close();
        }

        private void SketchArtEditorForm_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Employees.ConvertAll(employees => employees.Surname + " " + employees.Name);
        }

        public SketchArtEditorForm SetSketch(Sketch initialSketch)
        {
            InitialSketch = initialSketch;
            textBox1.Text = initialSketch.Name;
            textBox2.Text = initialSketch.FileLocation;
            comboBox1.Text = initialSketch.Author.ToString();
            dateTimePicker1.Value = initialSketch.CreationDate;

            return this;
        }

        public async Task<Sketch> SketchAsync(bool showModal = false, bool closeForm = true)
        {
            var tcs = new TaskCompletionSource<Sketch?>();

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
            OnSketchEditor += (_, sketch) =>
            {
                if (gotResult) return;
                gotResult = true;
                tcs.SetResult(sketch);
            };

            if (showModal)
            {
                ShowDialog();
            }

            var sketch = await tcs.Task;

            if (!formClosed && closeForm)
            {
                Close();
            }
            return sketch;
        }


        public static async Task<Sketch?> GetSketchAsync(ProgramContext context, Sketch initialSketch = null)
        {
            var form = context.CreateForm<SketchArtEditorForm>();
            Debug.WriteLine("form created");

            form.SetSketch(initialSketch);

            var tcs = new TaskCompletionSource<Sketch?>();

            var formClosed = false;
            var gotResult = false;

            form.FormClosed += (_, _) =>
            {
                if (formClosed) return;
                formClosed = true;
                tcs.SetResult(null);
            };
            form.OnSketchEditor += (_, sketch) =>
            {
                if (gotResult) return;
                gotResult = true;
                tcs.SetResult(sketch);
            };

            form.Show();

            var sketch = await tcs.Task;

            if (!formClosed)
            {
                form.Close();
            }
            return sketch;
        }
    }
}
