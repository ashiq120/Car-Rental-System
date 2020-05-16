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
    public partial class sv_Fill : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Arifin\Documents\Car_Rental_System.mdf;Integrated Security=True;Connect Timeout=30");
        String userID;
        public sv_Fill(String userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Car_Have f = new Car_Have(userID);
            f.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            //Generating SQL Query
            string sql = "INSERT svcar(Brand,Model,Numberplate,Color,Driver,Drivercont) VALUES(@param1,@param2,@param3,@param4,@param5,@param6)";
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

                cmd.CommandType = CommandType.Text;






                cmd.ExecuteNonQuery();



                //Disconnect
                con.Close();
            }

            MessageBox.Show("Thank you , Your Customer will be contacted soon after a rent request");
        }
    }
}
