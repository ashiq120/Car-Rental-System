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
    public partial class My_Rent_Request : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Arifin\Documents\Car_Rental_System.mdf;Integrated Security=True;Connect Timeout=30");
        String userID;
        public My_Rent_Request(String userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void My_Rent_Request_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'car_Rental_SystemDataSet2.svreq' table. You can move, or remove it, as needed.
            this.svreqTableAdapter.Fill(this.car_Rental_SystemDataSet2.svreq);
            // TODO: This line of code loads data into the 'car_Rental_SystemDataSet1.sdreq' table. You can move, or remove it, as needed.
            this.sdreqTableAdapter.Fill(this.car_Rental_SystemDataSet1.sdreq);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User_Pannel f7 = new User_Pannel(userID);
            f7.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
