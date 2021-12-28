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
    public partial class Student_fees : Form
    {
        public Student_fees()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fees_and_Salary rf = new Fees_and_Salary();
            rf.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hs = new Home();
            hs.Show();
        }
    }
}
