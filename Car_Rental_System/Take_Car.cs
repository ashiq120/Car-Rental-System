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
    public partial class Take_Car : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Arifin\Documents\Car_Rental_System.mdf;Integrated Security=True;Connect Timeout=30");
        String userID;
        public Take_Car(String userID)
        {
            InitializeComponent();
            this.userID = userID;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            User_Pannel f = new User_Pannel(userID);
            f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Sedan f1 = new Sedan(userID);
                f1.Show();
                this.Hide();
            }
            else
            {
                Suv f2 = new Suv(userID);
                f2.Show();
                this.Hide();
            }
        }

        private void Take_Car_Load(object sender, EventArgs e)
        {

        }
    }
}
