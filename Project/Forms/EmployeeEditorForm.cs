﻿using ProjectOop.Entities;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class EmployeeEditorForm : Form // сотрудник
    {
        private Employee? InitialEmployee;

        public EventHandler<Employee> OnEmployeeReady;

        public EmployeeEditorForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var login = login_box.Text.Trim();
            if (login.Length == 0)
            {
                MessageBox.Show("Login");
                return;
            }

            var password = password_box.Text.Trim();
            if (password.Length == 0)
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
                    Name = trimmedFirstName,
                    Surname = trimmedLastName,
                    Patronymic = trimmedMiddleName,
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
                    Name = trimmedFirstName,
                    Surname = trimmedLastName,
                    Patronymic = trimmedMiddleName,
                    DeviceDate = dateDevice,
                    Salary = trimmedSalary,
                    Password = password,
                    Login = login,
                };
            };

            OnEmployeeReady?.Invoke(this, result);
            Close();
        }

        public EmployeeEditorForm SetEmployee(Employee initialEmployee)
        {
            InitialEmployee = initialEmployee;
            textBox1.Text = initialEmployee.Name;
            textBox2.Text = initialEmployee.Surname;
            textBox3.Text = initialEmployee.Patronymic;
            dateTimePicker1.Value = initialEmployee.DeviceDate;
            textBox5.Text = initialEmployee.Salary.ToString();
            password_box.Text = initialEmployee.Password;
            login_box.Text = initialEmployee.Login;
            return this;
        }

        public async Task<Employee> EmployeeAsync(bool showModal = false, bool closeForm = true)
        {
            var tcs = new TaskCompletionSource<Employee?>();

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
            OnEmployeeReady += (_, employee) =>
            {
                if (gotResult) return;
                gotResult = true;
                tcs.SetResult(employee);
            };

            if (showModal)
            {
                ShowDialog();
            }

            var employee = await tcs.Task;

            if (!formClosed && closeForm)
            {
                Close();
            }
            return employee;
        }

        // статический асинхронный метод. 
        public static async Task<Employee?> GetEmployeeAsync(ProgramContext context, Employee initialEmployee = null)
        {
            var form = context.CreateForm<EmployeeEditorForm>();
            Debug.WriteLine("form created");

            form.SetEmployee(initialEmployee);

            var tcs = new TaskCompletionSource<Employee?>();

            var formClosed = false;
            var gotResult = false;

            form.FormClosed += (_, _) =>
            {
                if (formClosed) return;
                formClosed = true;
                tcs.SetResult(null);
            };
            form.OnEmployeeReady += (_, employee) =>
            {
                if (gotResult) return;
                gotResult = true;
                tcs.SetResult(employee);
            };

            form.Show();

            var employee = await tcs.Task;

            if (!formClosed)
            {
                form.Close();
            }
            return employee;
        }

    }
}
