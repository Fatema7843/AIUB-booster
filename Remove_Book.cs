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
    public partial class Remove_Book : Form
    {
        public Remove_Book()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hssw = new Home();
            hssw.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Library hsl = new Library();
            hsl.Show();
        }
    }
}
