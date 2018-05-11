using iPlanner.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iPlanner
{
    public partial class iPlannerMain : Form
    {
        public iPlannerMain()
        {
            InitializeComponent();
            this.Activate();
        }

        private void Profile_Click(object sender, EventArgs e)
        {

        }

        private void EditSemester1_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Semester 1 tidak dapat diedit !");
        }
        private void Semester1_button_Click(object sender, EventArgs e)
        {
            Semester1_Form semester1 = new Semester1_Form();
            semester1.Show();
        }

        private void Semester2_button_Click(object sender, EventArgs e)
        {
            Semester2_Form semester2 = new Semester2_Form();
            semester2.Show();
        }

        private void EditSemester2_button_Click(object sender, EventArgs e)
        {
            Semester2_EditForm EditForm = new Semester2_EditForm();
            EditForm.Show(); 
        }
    }
}
