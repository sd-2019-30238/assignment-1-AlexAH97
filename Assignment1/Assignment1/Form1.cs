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
using System.Data;
namespace Assignment1
{
    public partial class LogInForm : Form
    {
        private SqlConnection _sqlConnection;
        private SqlCommand _sqlCommand;
        private SqlDataAdapter adapter;
        private DataSet dataSet;
        
        public LogInForm()
        {
            InitializeComponent();
            PasswordTextBox.PasswordChar = '*';
            _sqlConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\PS\Assignment1\Assignment1\Books.mdf;Integrated Security=True");
            
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
            var str1 = UsernameTextBox.Text;
            var str2 = PasswordTextBox.Text;
            if(!str1.ToString().Equals("") && !str2.ToString().Equals(""))
            {
                try
                {
                
                    _sqlConnection.Open();
                    _sqlCommand = new SqlCommand("SELECT * FROM USERS WHERE Username='" + str1.ToString() + "' AND Password='" + str2.ToString() + "'");
                    _sqlCommand.Connection = _sqlConnection;
                    adapter = new SqlDataAdapter(_sqlCommand);
                    dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    if(dataSet.Tables[0].Rows.Count!=0)
                    {
                        MessageBox.Show("Logat!");
                    }
                    _sqlConnection.Close();
                }
                catch(SqlException e1)
                {
                    MessageBox.Show("Nu se poate deshide baza de date.Eroarea va fi afisata intr-o alta casuta!");
                    MessageBox.Show(e1.ToString());
                }
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
