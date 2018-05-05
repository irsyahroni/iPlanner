using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iPlanner.UI
{
    public partial class Semester1_EditForm : Form
    {
        public Semester1_EditForm()
        {
            InitializeComponent();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            Semester1_Form _Form = new Semester1_Form();
            _Form.Show();
            this.Close();
        }
    }
}
