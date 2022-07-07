using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAdo.NetExercise_1Day16
{
    public partial class Form2 : Form
    {
        private SqlConnection connection = null;
        private SqlCommand command = null;
        private SqlDataReader reader = null;
        public Form2()
        {
            InitializeComponent();
        }
        public void ClearText()
        {
           
            TextBoxUserName.Clear();
            TextBoxPassword.Clear();
           
        }

        //Sign in opeartion by validating the username and password
        private void ButtonSignIn_Click(object sender, EventArgs e)
        {
            using (connection = new SqlConnection(@"Data source=ECXLC5437; Initial catalog=HR;Integrated Security=true;"))
            {
                using (command = new SqlCommand("Select vEmail,vPassword from Login where vEmail=@Email AND vPassword=@password", connection))
                {
                    command.Parameters.AddWithValue("@Email", TextBoxUserName.Text);
                    command.Parameters.AddWithValue("@Password", TextBoxPassword.Text);

                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    using (reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            MessageBox.Show("Login Succesfull");
                        }
                        else
                        {
                            MessageBox.Show("Invalid Email ID / Password");
                            this.ClearText();
                        }
                    }

                }
            }
        }

        //Resetting the text box
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            this.ClearText();
        }
    }
}
