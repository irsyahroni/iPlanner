using iPlanner.Data;
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
    public partial class Semester2_EditForm : Form
    {
        public Semester2_EditForm()
        {
            DapatInput();
            InitializeComponent();
        }

      
        private void Save_button_Click(object sender, EventArgs e)
        {
            SimpanMatkul();            
            Semester2_Form _Form = new Semester2_Form();
            _Form.Show();
            this.Close();
        }

        private string[] Matkul = new string[10];
        private string[] Nilai = new string[10];

        private void DapatInput()
        {
            Matkul = Semester1.DapatMatkul();
            Nilai = Semester1.DapatNilai();
        }

        private void SimpanMatkul ()
        {
            Matkul[0] = Matkul1_textbox.Text;
            Matkul[1] = Matkul2_textbox.Text;
            Matkul[2] = Matkul3_textbox.Text;
            Matkul[3] = Matkul4_textbox.Text;
            Matkul[4] = Matkul5_textbox.Text;
            Matkul[5] = Matkul6_textbox.Text;
            Matkul[6] = Matkul7_textbox.Text;
            Matkul[7] = Matkul8_textbox.Text;
            Matkul[8] = Matkul9_textbox.Text;
            Matkul[9] = Matkul10_textbox.Text;

        }               
    }
}
