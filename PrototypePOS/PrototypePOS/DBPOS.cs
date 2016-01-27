using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypePOS
{
    class DBPOS
    {
        private string datasource, database;

        public List<User> GetUserAccounts() {
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        using (DataTable table = new DataTable())
                        {
                            if (!File.Exists("data/database_a.txt"))
                            {
                                MessageBox.Show("database_a.txt can't be found!");
                            }

                            else
                            {
                                using (StreamReader sr = new StreamReader("data/database_a.txt"))
                                {
                                    while (sr.Peek() >= 0)
                                    {
                                        string str;
                                        string[] strArray;
                                        str = sr.ReadLine();

                                        strArray = Regex.Split(str, ", ");
                                        datasource = strArray[0];
                                        database = strArray[1];

                                    }
                                }
                            }
                            conn.ConnectionString = string.Format("Data Source={0};database={1};integrated security=true;", datasource, database);
                            cmd.Connection = conn;
                            cmd.CommandText = "SELECT Account.Username, Account.Password, AccountType.Description FROM Account INNER JOIN AccountType ON Account.AccountType= AccountType.AccountTypeID";
                            da.SelectCommand = cmd;

                            List<User> users = new List<User>();

                            try
                            {
                                conn.Open();
                                da.Fill(table);
                                foreach (DataRow row in table.Rows)
                                {
                                    users.Add(new User(row["Username"].ToString(), row["Password"].ToString(), row["Description"].ToString()));
                                }
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                            finally
                            {
                                conn.Close();
                            }
                            return users;
                        }
                    }
                }
            }
        }

        public void InsertVendorAccount(string txtBxEmail , string txtBxName, string txtBxPassword, string dateOfRegistration)
        {
           
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        using (DataTable table = new DataTable())
                        {
                            if (!File.Exists("data/database_a.txt"))
                            {
                                MessageBox.Show("database_a.txt can't be found!");
                            }

                            else
                            {
                                using (StreamReader sr = new StreamReader("data/database_a.txt"))
                                {
                                    while (sr.Peek() >= 0)
                                    {
                                        string str;
                                        string[] strArray;
                                        str = sr.ReadLine();

                                        strArray = Regex.Split(str, ", ");
                                        datasource = strArray[0];
                                        database = strArray[1];

                                    }
                                }
                            }

                            conn.ConnectionString = string.Format("Data Source={0};database={1};integrated security=true;", datasource, database);
                            cmd.Connection = conn;
                            cmd.CommandText = (string.Format("Insert into Account Values('{0}','{1}','{2}',{3},2)",txtBxName,txtBxPassword,txtBxEmail, dateOfRegistration));
                           

                            try
                            {
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                conn.Close();
                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                            finally
                            {
                                conn.Close();
                            }

                        }
                    }
                }
            }
        }


    }
}
