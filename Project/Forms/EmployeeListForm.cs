using ProjectOop.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class EmployeeListForm : Form
    {
        private ProgramContext context;
        private AppDbContext db;
        private List<Employee> employees;

        public EmployeeListForm(ProgramContext context, AppDbContext dbContext)
        {
            this.context = context;
            InitializeComponent();
            db = dbContext;
        }

        private async void add_employee_Click(object sender, EventArgs e)
        {
            await context.AddNewEmployee();
            loadEmployeeList();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            loadEmployeeList();
        }

        private async Task loadEmployeeList()
        {
            employees = await Task.Run(() => (from e in db.Employees select e).ToList());
            var items = employees.ConvertAll(e => e.Surname + "   " + e.Name + "   " + e.Patronymic+ "   " + e.Role + "   "+e.Salary + "   " + e.DeviceDate + "   "+ e.Login + "   " + e.Password );
            listBox1.Invoke((MethodInvoker)delegate
            {
                listBox1.DataSource = items;
            });
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var index = listBox1.IndexFromPoint(e.X, e.Y);
                if (index != ListBox.NoMatches)
                {
                    listBox1.SelectedIndex = index;
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private async void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var index = listBox1.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                var employee = employees[index];

                Debug.WriteLine("before edit employee");
                await context.EditEmployee(employee);
                Debug.WriteLine("employee updated");
                await loadEmployeeList();
            }
        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var index = listBox1.SelectedIndex;
            if (index != ListBox.NoMatches)
            {
                var employee = employees[index];

                await context.DeleteEmployee(employee);
                await loadEmployeeList();
            }
        }
    }
}
