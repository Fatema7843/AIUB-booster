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
    public partial class Fees_and_Salary : Form
    {
        public Fees_and_Salary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Professor_salary r = new Professor_salary();
            r.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_fees fat = new Student_fees();
            fat.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_salary st = new Staff_salary();
            st.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home ph = new Home();
            ph.Show();
        }
    }
}
