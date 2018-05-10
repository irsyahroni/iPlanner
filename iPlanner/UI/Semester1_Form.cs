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
    public partial class Semester1_Form : Form
    {
        public Semester1_Form()
        {
            InitializeComponent();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string[] Matkul = new string[10];
        private string[] Nilai = new string[10];
        private void DapatInput()
        {
            Matkul = Semester1.DapatMatkul();
            Nilai = Semester1.DapatNilai();
        }
 
        private bool InputKosong()
        {
            bool MasihKosong=true;
            foreach (var item in Matkul)
            {
                if (item is null)
                {
                    MasihKosong = true;
                }
                else 
                {
                    MasihKosong = false;
                }
            }
            return MasihKosong;
        }
    }
}
