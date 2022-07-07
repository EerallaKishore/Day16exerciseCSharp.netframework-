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
using System.Configuration;

namespace Day16exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection con = null;
        private SqlCommand cmd = null;
        //private SqlDataAdapter adapter = null;
        private SqlDataReader reader = null;
        private void BtnSignup_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["Training"].ConnectionString))
            {
                using (cmd = new SqlCommand("inser_registration", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FirstName", TxtFName.Text);
                    cmd.Parameters.AddWithValue("@LastName", TxtLName.Text);
                    cmd.Parameters.AddWithValue("@BirthDate", DtpDob.Value);
                    cmd.Parameters.AddWithValue("@Gender", TxtGender.Text);
                    cmd.Parameters.AddWithValue("@EmailId", TxtEmail.Text);
                    cmd.Parameters.AddWithValue("@Password", TxtPassword.Text);
                    cmd.Parameters.AddWithValue("@ConfirmPassword", TxtConPassword.Text);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    cmd.ExecuteNonQuery(); //used for DML operation
                }
            }
            MessageBox.Show("New row Created");
        
            

        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["Training"].ConnectionString))
            {
                using (cmd = new SqlCommand("Select EmailId,Password from Registration where EmailId=@EmailId and Password=@Password", con))
                {
                    cmd.Parameters.AddWithValue("@EmailId", TxtEmail.Text);
                    cmd.Parameters.AddWithValue("@Password", TxtPassword.Text);

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }

                    using (reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            TxtEmail.Text = reader["EmailId"].ToString();
                            TxtPassword.Text = reader["Password"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Don't have a account");

                        }
                        MessageBox.Show($"Email:{TxtEmail.Text}\nPassword:{TxtPassword.Text}");
                    }
                }
            } 
            
        }
    }
}
