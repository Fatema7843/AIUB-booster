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
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home zuhura = new Home();
            zuhura.Show();
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_new_Book rzuhura = new Add_new_Book();
            rzuhura.Show();
        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Book gzuhura = new View_Book();
            gzuhura.Show();
        }

        private void removeBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
           Remove_Book mzuhura = new Remove_Book();
            mzuhura.Show();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Student_library fatema1 = new Add_Student_library();
            fatema1.Show();
        }

        private void viewStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_student_library_details zuhurafatema = new View_student_library_details();
            zuhurafatema.Show();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Remove_student_library zuhurar = new Remove_student_library();
            zuhurar.Show();
        }
    }
}
