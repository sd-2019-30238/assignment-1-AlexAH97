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
using Assignment1.DatabaseConnection;

namespace Assignment1
{
    public partial class LibraryForm : Form
    {
        private SqlConnection conn;
        private string username;
        public LibraryForm(string name)
        {
            InitializeComponent();
            this.username = name;
            this.conn = Connection.connectivity;
            displayGridView();
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDataSet1.Library' table. You can move, or remove it, as needed.
            this.libraryTableAdapter.Fill(this.booksDataSet1.Library);

        }
        void displayGridView()
        {
            
            dataGridView1.DataSource = MainPageController.GetUserLibrary(new Users(0,username.ToString(),String.Empty,String.Empty));
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            string title = row.Cells["bookTitleDataGridViewTextBoxColumn"].Value.ToString();
            conn.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conn;
            command.CommandText = "Delete From Library where Username='"+username+"' and BookTitle='"+title+"'";
            command.ExecuteNonQuery();
            if(getUsersForBook(command,title)>0)
            {
                UpdateQueue(command,title);
            }
            else
            {
                UpdateTable(command, title);
            }
            
            
            conn.Close();
            displayGridView();

        }
        private int getUsersForBook(SqlCommand command,string title)
        {
            command.CommandText = "Select * from InQueue where Title='" + title + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet set = new DataSet();
            adapter.Fill(set);
            return set.Tables[0].Rows.Count;
        }
        private void UpdateTable(SqlCommand command,string title)
        {
            try
            {
            command.CommandText = "UPDATE Books Set Available='"+Convert.ToBoolean(1)+"' Where Title='" + title + "'";
            command.ExecuteNonQuery();
            }catch(SqlException exp)
            {
               
            }
            
        }
        private void UpdateQueue(SqlCommand command,string title)
        {
            command.CommandText = "Select Username from InQueue where Title='" + title + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet set = new DataSet();
            adapter.Fill(set);
            string user = set.Tables[0].Rows[0].ToString();
            command.CommandText = "Delete FROM InQueue where Title='" + title + "' and Username='" + user + "'";
            command.ExecuteNonQuery();
            command.CommandText="INSERT INTO Library VALUES('"+user+"','"+title+"')";
            command.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage page = new MainPage(username);
            this.Hide();
            page.ShowDialog();
        }
    }
}
