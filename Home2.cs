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
    public partial class Home2 : Form
    {
        public Home2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home fatema = new Home();
            fatema.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }

        private void Home2_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Medical thug = new Medical();
            thug.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Parking pippip = new Parking();
            pippip.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Call_To_Ride ghurbo = new Call_To_Ride();
            ghurbo.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cafeteria cha_khabo = new Cafeteria();
            cha_khabo.Show();
        }
    }
}
