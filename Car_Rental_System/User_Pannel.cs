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
    public partial class User_Pannel : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Arifin\Documents\Car_Rental_System.mdf;Integrated Security=True;Connect Timeout=30");
        String userID;
        public User_Pannel(String userID)
        {
            InitializeComponent();
            this.userID = userID;
            label2.Text = "Welcome ," + userID;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            My_Profile f7 = new My_Profile(userID);
            f7.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Log_In f8 = new Log_In();
            f8.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            My_Rent_Request f7 = new My_Rent_Request(userID);
            f7.Show();

            this.Close();
        }

        private void User_Pannel_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Take_Car f4 = new Take_Car(userID);
            f4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Car_Have f = new Car_Have(userID);

            f.Show();

            this.Hide();
        }
    }
}
