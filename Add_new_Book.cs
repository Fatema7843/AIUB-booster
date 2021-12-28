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
    public partial class Add_new_Book : Form
    {
        public Add_new_Book()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hss = new Home();
            hss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Library hsl = new Library();
            hsl.Show();
        }
    }
}
