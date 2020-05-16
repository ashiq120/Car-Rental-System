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


namespace Car_Rental_System
{
    public partial class Sign_Up : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Arifin\Documents\Car_Rental_System.mdf;Integrated Security=True;Connect Timeout=30");
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Log_In f7 = new Log_In();
            f7.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) && String.IsNullOrEmpty(textBox2.Text) && String.IsNullOrEmpty(textBox3.Text) && String.IsNullOrEmpty(textBox4.Text) && String.IsNullOrEmpty(textBox5.Text))

            { MessageBox.Show("Please Enter all the details first"); }

            else
            {
                

                //Generating SQL Query
                string sql = "INSERT uinfo(Fullname,Username,Gender,Dateofbirth,Address,Email,Password) VALUES(@param1,@param2,@param3,@param4,@param5,@param6,@param7)";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    //Opening the connection:
                    con.Open();


                    cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = textBox1.Text;
                    cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = textBox2.Text;
                    if (radioButton1.Checked)
                    {
                        cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = "male";
                    }
                    else
                    {
                        cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = "female";
                    }
                    cmd.Parameters.Add("@param4", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    cmd.Parameters.Add("@param5", SqlDbType.VarChar, 50).Value = textBox3.Text;
                    cmd.Parameters.Add("@param6", SqlDbType.VarChar, 50).Value = textBox4.Text;
                    cmd.Parameters.Add("@param7", SqlDbType.VarChar, 50).Value = textBox5.Text;

                    cmd.CommandType = CommandType.Text;






                    int i = cmd.ExecuteNonQuery();

                    if (i >= 1)
                    { MessageBox.Show("Registration Successful"); }

                    else { MessageBox.Show("Registration unuccessful"); }




                    //Disconnect
                    con.Close();


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Log_In f = new Log_In();
            f.Show();
            this.Close();
        }
    }
}
