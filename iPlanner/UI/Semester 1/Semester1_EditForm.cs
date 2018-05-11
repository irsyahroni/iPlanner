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
    public partial class Semester1_EditForm : Form
    {
        public Semester1_EditForm()
        {
            DapatInput();
            InitializeComponent();
        }

        private void Recommend_button_Click(object sender, EventArgs e)
        {
            SimpanMatkul();
            SimpanNilai();
            MessageBox.Show(Nilai[1] + Nilai[2] + Matkul[1] + Matkul[2]);
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            SimpanMatkul();
            SimpanNilai();
            Semester1_Form _Form = new Semester1_Form();
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

        
        private void SimpanNilai()
        {
            Nilai[0] = Nilai1_textbox.Text;
            Nilai[1] = Nilai2_textbox.Text;
            Nilai[2] = Nilai3_textbox.Text;
            Nilai[3] = Nilai4_textbox.Text;
            Nilai[4] = Nilai5_textbox.Text;
            Nilai[5] = Nilai6_textbox.Text;
            Nilai[6] = Nilai7_textbox.Text;
            Nilai[7] = Nilai8_textbox.Text;
            Nilai[8] = Nilai9_textbox.Text;
            Nilai[9] = Nilai10_textbox.Text;

        }      
    }
}
