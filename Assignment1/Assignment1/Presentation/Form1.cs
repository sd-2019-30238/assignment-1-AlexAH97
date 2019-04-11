using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Assignment1.BusinessLogic;
namespace Assignment1
{
    public partial class LogInForm : Form
    {   
        public LogInForm()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            
            String str1 = UsernameTextBox.Text;
            String str2 = PasswordTextBox.Text;
            if (Validator.TextBoxValidator(str1) == 1 && Validator.TextBoxValidator(str2) == 1)
            {
                if (FormOneController.verificationUser(new Users(0, str1, str2, String.Empty)))
                {
                    MainPage page = new MainPage(str1.ToString());
                    this.Hide();
                    page.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Numele de utilizator sau parola este gresita!Va rugam sa reincarcati!");
                UsernameTextBox.Text = "";
                PasswordTextBox.Text = "";
            }
           
           
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            this.Hide();
            registerForm.ShowDialog();
        }
    }
}
