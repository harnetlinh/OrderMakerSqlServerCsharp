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

namespace orderMaker
{
    public partial class Login : Form
    {
        SqlConnection conn;
        public bool isLogin = false;
        public Login()
        {
            InitializeComponent();
            createConnection();
        }

        private void createConnection()
        {
            try
            {
                String strConnection = "Server=HANGOCLINH45AC;Database=BikeStores;Integrated Security = true";
                conn = new SqlConnection(strConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi SQL " + ex.Message);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                String email = tbEmail.Text;
                String password = tbPassword.Text;
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                String sqlQuery = "SELECT * FROM staffs WHERE email = @email AND password = @password";
                cmd.CommandText = sqlQuery;

                cmd.Parameters.Add("@email", SqlDbType.VarChar);
                cmd.Parameters["@email"].Value = email;

                cmd.Parameters.Add("@password", SqlDbType.VarChar);
                cmd.Parameters["@password"].Value = password;

                //cmd.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    AppData.fullname = reader["first_name"].ToString() + " " + reader["last_name"].ToString();
                    AppData.email = reader["email"].ToString();
                    AppData.password = reader["password"].ToString();
                    AppData.staff_id = Convert.ToInt32(reader["staff_id"].ToString());
                    AppData.isLogin = true;
                    MessageBox.Show("Welcome " + reader["first_name"].ToString() + " " + reader["last_name"].ToString());
                    Close();
                }
                else
                {
                    MessageBox.Show("Login that bai!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi he thong " + ex.Message);
            }

        }
    }
}
