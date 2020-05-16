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
    public partial class Admin_Pannel : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Arifin\Documents\Car_Rental_System.mdf;Integrated Security=True;Connect Timeout=30");
        private SqlCommand cmd;
        public Admin_Pannel()
        {
            InitializeComponent();
            
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            //textBox3.Text = "";

            //textBox4.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Log_In f = new Log_In();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Generating SQL Query
            SqlCommand command = new SqlCommand("delete uinfo where username = '" + textBox2.Text + "' ", con);

            con.Open();


            

            command.CommandType = CommandType.Text;






            int i = command.ExecuteNonQuery();

            if (i >= 1)
            { MessageBox.Show("Delete Successfull"); }

            else { MessageBox.Show("Delete unuccessful"); }




            //Disconnect
            con.Close();

            dataGridView1.DataSource = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Arifin\Documents\Car_Rental_System.mdf;Integrated Security=True;Connect Timeout=30");
            SqlCommand commandd = new SqlCommand("select * from uinfo", con);


            con.Open();

            SqlDataReader DR = commandd.ExecuteReader();


            BindingSource source = new BindingSource();
            source.DataSource = DR;


            dataGridView1.DataSource = source;


            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Generating SQL Query
           
                //Opening the connection:
                con.Open();

                cmd = new SqlCommand("UPDATE uinfo SET Fullname=@param1, Gender=@param3, Dateofbirth=@param4, Address=@param5 ,Email=@param6, Password=@param7 WHERE username = '" + textBox2.Text + "' ", con);
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
                cmd.Parameters.Add("@param5", SqlDbType.VarChar, 50).Value = textBox5.Text;
                cmd.Parameters.Add("@param6", SqlDbType.VarChar, 50).Value = textBox6.Text;
                cmd.Parameters.Add("@param7", SqlDbType.VarChar, 50).Value = textBox7.Text;

                cmd.CommandType = CommandType.Text;






                int i = cmd.ExecuteNonQuery();

                if (i >= 1)
                { MessageBox.Show("Update Successful"); }

                else { MessageBox.Show("Update unuccessful"); }




                //Disconnect
                con.Close();

                dataGridView1.DataSource = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Arifin\Documents\Car_Rental_System.mdf;Integrated Security=True;Connect Timeout=30");
                dataGridView1.Refresh();
                SqlCommand command = new SqlCommand("select * from uinfo", con);


                con.Open();

                SqlDataReader DR = command.ExecuteReader();


                BindingSource source = new BindingSource();
                source.DataSource = DR;


                dataGridView1.DataSource = source;


                con.Close();
            

            
        }

        private void button2_Click(object sender, EventArgs e)
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
                cmd.Parameters.Add("@param5", SqlDbType.VarChar, 50).Value = textBox5.Text;
                cmd.Parameters.Add("@param6", SqlDbType.VarChar, 50).Value = textBox6.Text;
                cmd.Parameters.Add("@param7", SqlDbType.VarChar, 50).Value = textBox7.Text;

                cmd.CommandType = CommandType.Text;






                int i = cmd.ExecuteNonQuery();

                if (i >= 1)
                { MessageBox.Show("Registration Successful"); }

                else { MessageBox.Show("Registration unuccessful"); }




                //Disconnect
                con.Close();

                dataGridView1.DataSource = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Arifin\Documents\Car_Rental_System.mdf;Integrated Security=True;Connect Timeout=30");
                dataGridView1.Refresh();
                SqlCommand command = new SqlCommand("select * from uinfo", con);


                con.Open();

                SqlDataReader DR = command.ExecuteReader();


                BindingSource source = new BindingSource();
                source.DataSource = DR;


                dataGridView1.DataSource = source;


                con.Close();
            }
        }

        private void Admin_Pannel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'car_Rental_SystemDataSet3.uinfo' table. You can move, or remove it, as needed.
            this.uinfoTableAdapter1.Fill(this.car_Rental_SystemDataSet3.uinfo);
            // TODO: This line of code loads data into the 'car_Rental_SystemDataSet2.svreq' table. You can move, or remove it, as needed.
            this.svreqTableAdapter.Fill(this.car_Rental_SystemDataSet2.svreq);
            // TODO: This line of code loads data into the 'car_Rental_SystemDataSet1.sdreq' table. You can move, or remove it, as needed.
            this.sdreqTableAdapter.Fill(this.car_Rental_SystemDataSet1.sdreq);
            

        }
    }
}
