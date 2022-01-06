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
    public partial class EmployeeEditorForm : Form // сотрудник
    {
        private Employee? InitialEmployee;
        // задача которую можно завершить и дождаться момента когда она завершится. в одном месте
        // завершаем звдачу если все хорошо, в другом дожидаемся и получаем данные
        private TaskCompletionSource<Employee> onReady = new TaskCompletionSource<Employee>();

        public EmployeeEditorForm(Employee? employee)
        {
            InitializeComponent();
            InitialEmployee = employee;

            if (employee != null)
            {
                textBox1.Text = employee.FirstName;
                textBox2.Text = employee.LastName;
                textBox3.Text = employee.MiddleName;
                dateTimePicker1.Value = employee.DeviceDate;
                textBox5.Text = employee.Salary.ToString();
                password_box.Text = employee.Password;
                login_box.Text = employee.Login;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO: login, password
            var login = login_box.Text.Trim();
            if(login.Length == 0)
            {
                MessageBox.Show("Login");
                return;
            }

            var password = password_box.Text.Trim();
            if(password.Length == 0)
            {
                MessageBox.Show("Password");
                return;
            }

            var trimmedFirstName = textBox1.Text.Trim();
            if (trimmedFirstName.Length == 0)
            {
                MessageBox.Show("Не указана фамилия сотрудника");
                return;
            }
            var trimmedLastName = textBox2.Text.Trim();
            if (trimmedLastName.Length == 0)
            {
                MessageBox.Show("Не указано имя сотрудника");
                return;
            }
            var trimmedMiddleName = textBox3.Text.Trim();
            var dateDevice = dateTimePicker1.Value;

            var currentDate = DateTime.Now;

            if (dateDevice > currentDate)
            {
                MessageBox.Show("Неверная дата");
                return;
            }

            var trimmedSalary = textBox5.Text.Trim();
            if (int.TryParse(trimmedSalary, out _))
            {
                trimmedSalary = (int.Parse(trimmedSalary)).ToString("C2");
            }

            Employee result;
            if (InitialEmployee != null)
            {
                result = new Employee()
                {
                    ID = InitialEmployee.ID,
                    FirstName = trimmedFirstName,
                    LastName = trimmedLastName,
                    MiddleName = trimmedMiddleName,
                    DeviceDate = dateDevice,
                    Salary = trimmedSalary,
                    Password = password,
                    Login = login,
                };
            }
            else // else
            {
                result = new Employee()
                {
                    FirstName = trimmedFirstName,
                    LastName = trimmedLastName,
                    MiddleName = trimmedMiddleName,
                    DeviceDate = dateDevice,
                    Salary = trimmedSalary,
                    Password = password,
                    Login = login,
                };
            };
            onReady.SetResult(result);

        }
        // статический асинхронный метод. 
        public static async Task<Employee?>  GetEmployeeAsync(Employee initialEmployee = null)
        {
            var form = new EmployeeEditorForm(initialEmployee);
            form.Show();
            try
            {
                // ждем когда вызывается кнопка и эта задача завершится. 
                var employee = await form.onReady.Task;
                return employee;
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

        private void EmployeeEditorForm_FormClosed(object sender, FormClosedEventArgs e)
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
