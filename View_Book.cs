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
    public partial class View_Book : Form
    {
        public View_Book()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Library hslm = new Library();
            hslm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hssfatema = new Home();
            hssfatema.Show();
        }
    }
}
