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
namespace Assignment1
{
    public partial class Register : Form
    {
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private const string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PS\Assignment1\Assignment1\Books.mdf;Integrated Security=True";
        public Register()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
            PasswordVerifyTextBox.PasswordChar = '*';
            sqlConnection = new SqlConnection(CONNECTION_STRING);

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
            string user, pass, verPass, email;
            user = UsernameTextBox.Text;
            pass = PasswordTextBox.Text;
            verPass = PasswordVerifyTextBox.Text;
            email = EmailTextBox.Text;
            
            if(!user.ToString().Equals("") && 
               !pass.ToString().Equals("") && 
               !verPass.ToString().Equals("") &&
               !email.ToString().Equals(""))
            {
                if(pass.ToString().Equals(verPass.ToString()))
                {
                    if(email.ToString().Contains("@"))
                    {
                        try
                        {
                            sqlConnection.Open();
                            sqlCommand = new SqlCommand("INSERT INTO Users Values('" + user.ToString() + "','" + pass.ToString() + "','"+ email.ToString() +"')");
                            sqlCommand.Connection = sqlConnection;
                            if (sqlCommand.ExecuteNonQuery() != 0)
                                BackButton_Click(sender,e);
                            sqlConnection.Close();
                        }catch(SqlException e1)
                        {
                            MessageBox.Show("Probleme la inserare.Va rugam sa reincercati!");
                            MessageBox.Show(e1.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nu este un format bun pentru un E-mail");
                    }
                }
                else
                {
                    MessageBox.Show("Parola nu coincide!Va rugam sa reincercati.");
                }
            }
            else
            {
                MessageBox.Show("Nu a-ti completat una dintre casute.Toate casutele trebuie completate");
            }
        }
    }
}
