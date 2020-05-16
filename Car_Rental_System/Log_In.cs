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
    public partial class Log_In : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Arifin\Documents\Car_Rental_System.mdf;Integrated Security=True;Connect Timeout=30");
        public Log_In()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "admin")
            {
                //Opening the connection:
                con.Open();

                //Execute SQL Query:

                SqlCommand command = new SqlCommand("select * from uinfo where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "' ", con);

                SqlDataReader DR = command.ExecuteReader();

                int count = 0;

                while (DR.Read())
                {
                    count = count + 1;
                }

                if (count == 1)
                {
                    MessageBox.Show("Login Successful");


                    Admin_Pannel f1= new Admin_Pannel();
                    f1.ShowDialog();
                    this.Hide();
                }

                if (count == 0)
                {
                    MessageBox.Show("Please Enter Username and password correctly");
                }
                




                //Disconnect
                con.Close();
            
            }

            else
            {
                //Opening the connection:
                con.Open();

                //Execute SQL Query:

                SqlCommand command = new SqlCommand("select * from uinfo where username = '" + textBox1.Text + "' and password = '" + textBox2.Text + "' ", con);

                SqlDataReader DR = command.ExecuteReader();

                int count = 0;

                while (DR.Read())
                {
                    count = count + 1;
                }

                if (count == 1)
                {
                    MessageBox.Show("Login Successful");


                    User_Pannel f1 = new User_Pannel(textBox1.Text);
                    f1.ShowDialog();
                    this.Hide();
                }

                if (count == 0)
                {
                    MessageBox.Show("Please Enter Username and password correctly");
                }




                //Disconnect
                con.Close();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sign_Up f1 = new Sign_Up();
            f1.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.Handled=(e.KeyChar==(char)Keys.Space))
            {
                MessageBox.Show("Space Are Not Allowed");
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
