using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FatemaTuzZuhura_19_41784_3
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home2 h2 = new Home2();
            h2.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admission ad = new Admission();
            ad.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Department d = new Department();
            d.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Courses dc = new Courses();
            dc.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
           Fees_and_Salary dz = new Fees_and_Salary();
            dz.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Library dlb = new Library();
            dlb.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Attendence da = new Attendence();
            da.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gymnastics burger = new Gymnastics();
            burger.Show();
        }
    }
}
