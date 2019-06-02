using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Assignment1.DatabaseConnection;
using System.Data;

namespace Assignment1.BusinessLogic.FactoryMethod
{
    class FilterBy
    {
        String result;
       
        public String filterByAuthor()
        {
            return String.Empty;
        }
        public String filterBySF()
        {
           
            using (var connection = Connection.connectivity)
            {


                using (SqlCommand command = new SqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "Select * FROM BOOKS WHERE Genre=SF";
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet set = new DataSet();
                    adapter.Fill(set);
                    for(int i=0;i<set.Tables[0].Rows.Count;i++)
                    {
                        result =result + set.Tables[0].Rows[i][0].ToString() + " "
                            + set.Tables[0].Rows[i][1].ToString() + " "
                            + set.Tables[0].Rows[i][2].ToString() + " "
                            + set.Tables[0].Rows[i][3].ToString() + " "
                            + set.Tables[0].Rows[i][4].ToString() + " "
                            + set.Tables[0].Rows[i][5].ToString() + "\n";

                    }
                }
                connection.Close();
            }
            return result;
        }
        public String filterByComedy()
        {
            using (var connection = Connection.connectivity)
            {


                using (SqlCommand command = new SqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "Select * FROM BOOKS WHERE Genre=comedy";
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet set = new DataSet();
                    adapter.Fill(set);
                    for (int i = 0; i < set.Tables[0].Rows.Count; i++)
                    {
                        result = result + set.Tables[0].Rows[i][0].ToString() + " "
                            + set.Tables[0].Rows[i][1].ToString() + " "
                            + set.Tables[0].Rows[i][2].ToString() + " "
                            + set.Tables[0].Rows[i][3].ToString() + " "
                            + set.Tables[0].Rows[i][4].ToString() + " "
                            + set.Tables[0].Rows[i][5].ToString() + "\n";

                    }
                }
                connection.Close();
            }
            return result;
        }
        public String filterByCrime()
        {
            using (var connection = Connection.connectivity)
            {


                using (SqlCommand command = new SqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "Select * FROM BOOKS WHERE Genre=crime";
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet set = new DataSet();
                    adapter.Fill(set);
                    for (int i = 0; i < set.Tables[0].Rows.Count; i++)
                    {
                        result = result + set.Tables[0].Rows[i][0].ToString() + " "
                            + set.Tables[0].Rows[i][1].ToString() + " "
                            + set.Tables[0].Rows[i][2].ToString() + " "
                            + set.Tables[0].Rows[i][3].ToString() + " "
                            + set.Tables[0].Rows[i][4].ToString() + " "
                            + set.Tables[0].Rows[i][5].ToString() + "\n";

                    }
                }
                connection.Close();
            }
            return result;
        }
        public String filterByDrama()
        {
            using (var connection = Connection.connectivity)
            {


                using (SqlCommand command = new SqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "Select * FROM BOOKS WHERE Genre=drama";
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet set = new DataSet();
                    adapter.Fill(set);
                    for (int i = 0; i < set.Tables[0].Rows.Count; i++)
                    {
                        result = result + set.Tables[0].Rows[i][0].ToString() + " "
                            + set.Tables[0].Rows[i][1].ToString() + " "
                            + set.Tables[0].Rows[i][2].ToString() + " "
                            + set.Tables[0].Rows[i][3].ToString() + " "
                            + set.Tables[0].Rows[i][4].ToString() + " "
                            + set.Tables[0].Rows[i][5].ToString() + "\n";

                    }
                }
                connection.Close();
            }
            return result;
        }
        public String filterByKids()
        {
            using (var connection = Connection.connectivity)
            {


                using (SqlCommand command = new SqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "Select * FROM BOOKS WHERE Genre=kids";
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataSet set = new DataSet();
                    adapter.Fill(set);
                    for (int i = 0; i < set.Tables[0].Rows.Count; i++)
                    {
                        result = result + set.Tables[0].Rows[i][0].ToString() + " "
                            + set.Tables[0].Rows[i][1].ToString() + " "
                            + set.Tables[0].Rows[i][2].ToString() + " "
                            + set.Tables[0].Rows[i][3].ToString() + " "
                            + set.Tables[0].Rows[i][4].ToString() + " "
                            + set.Tables[0].Rows[i][5].ToString() + "\n";

                    }
                }
                connection.Close();
            }
            return result;
        }
        
    }
}
