using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental_System
{
    public partial class Car_Have : Form
    {
        String userID;
        public Car_Have(String userID)
        {
            InitializeComponent();
            this.userID = userID;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                sd_Fill f1 = new sd_Fill(userID);

                f1.Show();
                this.Close();
            }
            else
            {
                sv_Fill f2 = new sv_Fill(userID);

                f2.Show();
                this.Close();
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_Pannel f1 = new User_Pannel(userID);
            f1.Show();
            this.Hide();
        }
    }
}
