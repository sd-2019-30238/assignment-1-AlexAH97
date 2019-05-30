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
using ServiceStack.OrmLite;
using System.Configuration;
using Assignment1.BusinessLogic;
using Assignment1.DatabaseConnection;

namespace Assignment1
{

    
  
    public partial class MainPage : Form
    {
    
       
        private string username;
        public MainPage(string username)
        {
            InitializeComponent();
      
            this.username = username;
            displayData();
        }

      

       

        
        private void displayData()
        {
            
            dataGridView1.DataSource = MainPageController.getDataTable;
          
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
            DataView dv = new DataView(MainPageController.getDataTable);
            switch(comboBox1.Text)
            {
                case "Title":
                    dv.RowFilter = string.Format("Title Like '%{0}%'", textBox1.Text);
                    break;
                case "Author":
                    dv.RowFilter = string.Format("Author Like '%{0}%'", textBox1.Text);
                    break;
                case "Genre":
                    dv.RowFilter = string.Format("Genre Like '%{0}%'", textBox1.Text);
                    break;
                case "ReleaseDate":
                    dv.RowFilter = string.Format("ReleaseDate Like '%{0}%'", textBox1.Text);
                    break;
            }
            dataGridView1.DataSource = dv;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibraryForm form = new LibraryForm(username);
            this.Hide();
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection _sqlConnection = Connection.connectivity;
            SqlCommand command = new SqlCommand();
            _sqlConnection.Open();
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            string title = row.Cells["titleDataGridViewTextBoxColumn"].Value.ToString();
            String available = row.Cells["Available"].Value.ToString();
            if(available.Equals("True"))
            {
                command.Connection = _sqlConnection;
                command.CommandText = "INSERT INTO Library VALUES('"+username.ToString()+"','"+title+"')";
                command.ExecuteNonQuery();
                command.CommandText="UPDATE Books SET Available='"+Convert.ToBoolean(0)+"' WHERE Title='"+title+"'";
                command.ExecuteNonQuery();
                MessageBox.Show("Cartea a fost adaugata cu succes in biblioteca dumneavoastra!");
            }
            else
            {
                command.Connection = _sqlConnection;
                command.CommandText = "INSERT INTO InQueue VALUES('" + title +"','" + username.ToString() + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Din pacate aceasta carte este rezervata.Ati fost introdus intr-o coada pentru obtinerea acesteia.");
               
            }
            _sqlConnection.Close();
            displayData();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
