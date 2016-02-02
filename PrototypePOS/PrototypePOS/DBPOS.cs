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

        public List<User> GetUserAccounts()
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
                            List<User> users = new List<User>();
                            try
                            {

                            conn.ConnectionString = string.Format("Data Source={0};database={1};integrated security=true;", datasource, database);
                            cmd.Connection = conn;
                            cmd.CommandText = "SELECT Account.Username, Account.Password, AccountType.Description FROM Account INNER JOIN AccountType ON Account.AccountType= AccountType.AccountTypeID";
                            da.SelectCommand = cmd;

                          

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
        public int GetAccountID(string username)
        {
            int x = 0;
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
                          
                            try
                            {

                                conn.ConnectionString = string.Format("Data Source={0};database={1};integrated security=true;", datasource, database);
                                cmd.Connection = conn;
                                cmd.CommandText =  string.Format("SELECT AccountID FROM Account where username='{0}'",username);
                                da.SelectCommand = cmd;



                                conn.Open();
                                da.Fill(table);
                             
                                foreach(DataRow row in table.Rows)
                                {
                                    x = int.Parse(row["AccountID"].ToString());
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
                            return x;
                        }
                    }
                }
            }
        }

        public void InsertAccount(string txtBxEmail, string txtBxName, string txtBxPassword, string dateOfRegistration, int accountType)
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
                            cmd.CommandText = (string.Format("Insert into Account Values('{0}','{1}','{2}',{3},{4})", txtBxName, txtBxPassword, txtBxEmail, dateOfRegistration, accountType));


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
                
        public void InsertCustomer(int AccountID,string txtBxFirstName, string txtBxLastName, string txtBxMobileNo,string DOB)
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
                            cmd.CommandText = (string.Format("Insert into Customer Values ({0},'{1}','{2}','{3}',{4})",AccountID,txtBxFirstName,txtBxLastName,
                                txtBxMobileNo, DOB));


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

        public void InsertCreditCard(int AccountID,string txtBxCreditCardName,int txtBxCreditCardNo, DateTime dtpExpiryDate, int txtBxCVC,int txtBxSixDigitPIN)
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
                            cmd.CommandText = (string.Format("Insert into CreditCard Values ({0},'{1}',{2},'{3}',{4},{5})", AccountID, txtBxCreditCardName,txtBxCreditCardNo,
                                dtpExpiryDate,txtBxCVC,txtBxSixDigitPIN));


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


        public void InsertVendor(int accountID, string txtBxName, string txtBxContactPerson, string txtBxContactNo)
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
                            
                            cmd.CommandText = "SELECT Account.AccountID FROM Account";
                            cmd.CommandText = (string.Format("Insert into Vendor Values('{0}','{1}','{2}','{3}')",accountID, txtBxName, txtBxContactPerson, txtBxContactNo));


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

        public List<Vendor> LoadVendorAccounts()
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
                            List<Vendor> vendors = new List<Vendor>();


                            try
                            {
                                conn.ConnectionString = string.Format("Data Source={0};database={1};integrated security=true;", datasource, database);
                            cmd.Connection = conn;
                            cmd.CommandText = "SELECT VendorID, Vendor.AccountID, Vendor.Name, Vendor.ContactPerson, Vendor.ContactNo FROM Vendor";
                            da.SelectCommand = cmd;

                          
                            
                                conn.Open();
                                da.Fill(table);
                                foreach (DataRow row in table.Rows)
                                {
                                    vendors.Add(new Vendor(row["VendorID"].ToString(),row["AccountID"].ToString(), row["Name"].ToString(), row["ContactPerson"].ToString(), row["ContactNo"].ToString()));
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
                            return vendors;
                        }
                    }
                }
            }
        }

    }
}
         
