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
    public partial class My_Profile : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Arifin\Documents\Car_Rental_System.mdf;Integrated Security=True;Connect Timeout=30");
        
        string userID;
        public My_Profile(String userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void My_Profile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            SqlCommand cmd = new SqlCommand("update uinfo set Fullname=@param1,Username=@param2,Gender=@param3,Dateofbirth=@param4,Address=@param5,Email=@param6,Password=@param7 where Username = '" + userID + "'", con);

            con.Open();
            //cmd.Parameters.AddWithValue("@id", ID);  
            cmd.Parameters.AddWithValue("@param1", textBox1.Text);
            cmd.Parameters.AddWithValue("@param2", textBox2.Text);
            cmd.Parameters.AddWithValue("@param3", textBox3.Text);
            cmd.Parameters.AddWithValue("@param4", textBox4.Text);
            cmd.Parameters.AddWithValue("@param5", textBox5.Text);
            cmd.Parameters.AddWithValue("@param6", textBox6.Text);
            cmd.Parameters.AddWithValue("@param7", textBox7.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated Successfully");
            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_Pannel f7 = new User_Pannel(userID);
            f7.Show();
            this.Hide();
        }
    }
}
