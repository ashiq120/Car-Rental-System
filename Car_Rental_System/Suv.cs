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
    public partial class Suv : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Arifin\Documents\Car_Rental_System.mdf;Integrated Security=True;Connect Timeout=30");
        String userID;
        public Suv(String userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void Suv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'car_Rental_SystemDataSet4.svcar' table. You can move, or remove it, as needed.
            this.svcarTableAdapter.Fill(this.car_Rental_SystemDataSet4.svcar);
            //Generating SQL Query
            SqlCommand command = new SqlCommand("select * from svcar", con);

            //Opening the connection:
            con.Open();

            //Execute SQL Query:
            SqlDataReader DR = command.ExecuteReader();

            //Binding reader to binding source
            BindingSource source = new BindingSource();
            source.DataSource = DR;

            //Binding gridview or control datacsource to binding source:
            dataGridView1.DataSource = source;

            //Disconnect
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_Pannel f = new User_Pannel(userID);
            f.Show();
            this.Close();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {


            //Generating SQL Query
            string sql = "INSERT svreq(Brand,Model,Numberplate,Color,Driver,Drivercont,Deparature,Destination,Startdt,Enddt,Username) VALUES(@param1,@param2,@param3,@param4,@param5,@param6,@param7,@param8,@param9,@param10,@param11)";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                //Opening the connection:
                con.Open();


                cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = textBox1.Text;
                cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = textBox2.Text;
                cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = textBox3.Text;

                cmd.Parameters.Add("@param4", SqlDbType.VarChar, 50).Value = textBox4.Text;
                cmd.Parameters.Add("@param5", SqlDbType.VarChar, 50).Value = textBox5.Text;
                cmd.Parameters.Add("@param6", SqlDbType.VarChar, 50).Value = textBox6.Text;
                cmd.Parameters.Add("@param7", SqlDbType.VarChar, 50).Value = textBox7.Text;
                cmd.Parameters.Add("@param8", SqlDbType.VarChar, 50).Value = textBox8.Text;
                cmd.Parameters.Add("@param9", SqlDbType.DateTime).Value = dateTimePicker1.Value.Date;
                cmd.Parameters.Add("@param10", SqlDbType.DateTime).Value = dateTimePicker2.Value.Date;
                cmd.Parameters.Add("@param11", SqlDbType.VarChar, 50).Value = userID;

                cmd.CommandType = CommandType.Text;






                cmd.ExecuteNonQuery();



                //Disconnect
                con.Close();
            }

            MessageBox.Show("Registration Successful");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Take_Car f1 = new Take_Car(userID);
            f1.Show();
            this.Hide();
        }
    }
}
