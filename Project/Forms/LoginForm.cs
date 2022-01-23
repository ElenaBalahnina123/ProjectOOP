using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class LoginForm : Form
    {
        private AppDbContext dbContext;
        private ProgramContext programState;

        public LoginForm(AppDbContext dbContext, ProgramContext state)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            programState = state;
        }

        private async void btn_come_in_Click(object sender, EventArgs e)
        {
            var login = textBox1.Text;
            var password = textBox2.Text;

            var employee = await Task.Run(() => (from emp in dbContext.Employees where emp.Login == login select emp).FirstOrDefault());

            if (employee == null)
            {
                MessageBox.Show("not found");
                return;
            }
            if (employee.Password != password)
            {
                MessageBox.Show("invalid password");
                return;
            }

 

            programState.ShowMainForm(employee);
            Close();
        }
    }
}
