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
    public partial class Register : Form
    {
        
        public Register()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
            PasswordVerifyTextBox.PasswordChar = '*';
           

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LogInForm logIn = new LogInForm();
            this.Hide();
            logIn.ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegistorButton_Click(object sender, EventArgs e)
        {
            string user = UsernameTextBox.Text;
            string pass = PasswordTextBox.Text;
            string verPass = PasswordVerifyTextBox.Text;
            string email = EmailTextBox.Text;
            if(Validator.PasswordVerification(pass,verPass)==1 && Validator.EmailValidator(email)==1)
            {
                Users newUser = new Users(0, user, pass, email);
                FormOneController.insertUser(newUser);
            }
        }
    }
}
