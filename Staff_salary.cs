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
    public partial class Staff_salary : Form
    {
        public Staff_salary()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fees_and_Salary r = new Fees_and_Salary();



            r.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home zu = new Home();

            zu.Show();
        }
    }
}
