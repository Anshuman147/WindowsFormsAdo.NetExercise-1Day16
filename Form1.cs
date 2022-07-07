using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAdo.NetExercise_1Day16
{
    public partial class Form1 : Form
    {
        private SqlConnection connnection = null;
        private SqlCommand command=null;
        private SqlDataAdapter adapter = null;
       // private SqlDataReader reader = null;
       
        public Form1()
        {
            InitializeComponent();
        }

        public void ClearTextBox()
        {
            TextBoxFirstName.Clear();
            TextBoxLastName.Clear();
            TextBoxEmail.Clear();
            TextBoxPassword.Clear();
            TextBoxConfirmPassword.Clear();
        }
        private void ButtonSignup_Click(object sender, EventArgs e)
        {
            using (connnection=new SqlConnection(ConfigurationManager.ConnectionStrings["HR"].ConnectionString))
            {
                using (command=new SqlCommand("usp_InsertIntoLoginTable",connnection))
                {
                    using (adapter=new SqlDataAdapter(command))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        SqlCommandBuilder cbd = new SqlCommandBuilder(adapter);
                        DataTable dt = new DataTable();

                        command.Parameters.AddWithValue("@FirstName", TextBoxFirstName.Text);
                        command.Parameters.AddWithValue("@LastName", TextBoxLastName.Text);
                        command.Parameters.AddWithValue("@BirthDate", DateTimePickerBirthDate.Value);
                        command.Parameters.AddWithValue("@Gender", ComboBoxGender.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Email", TextBoxEmail.Text);
                        command.Parameters.AddWithValue("@Password", TextBoxPassword.Text);
                        command.Parameters.AddWithValue("@Confirmpassword", TextBoxConfirmPassword.Text);
                        
                        try
                        {
                            
                            if(TextBoxPassword.Text== TextBoxConfirmPassword.Text)
                            {
                                adapter.Fill(dt);
                                Form2 f2 = new Form2();
                                f2.Show();
                            }
                            else
                            {
                                MessageBox.Show("Password and Confirm pasword is not entered");
                            }
                        }
                        catch(SqlException)
                        {
                            MessageBox.Show("Email is already used or Email is not Prperly Entered");
                        }
                        catch(Exception)
                        {
                            MessageBox.Show(new Exception().Message);
                        }
                       
                    }
                }
            }
           
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            this.ClearTextBox();
        }
    }
}
