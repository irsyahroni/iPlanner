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
    public partial class Semester1_IsiNilaiForm : Form
    {
        string bobot;
        string akhir;
        double total;
        public Semester1_IsiNilaiForm()
        {
            InitializeComponent();
            HideKosong();
            IsiLabelBobot();
            IsiLabelAkhir();            
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
 
        private void IsiBobot(ref string bobot, string nilai)
        {
            HitungNilai hitungNilai = new HitungNilai();
            if (nilai != string.Empty)
                bobot = hitungNilai.HitungNilaiHuruf(nilai);
            else
                bobot = "0";
        }

        private void IsiAkhir(ref string akhir, string nilai, string sks)
        {
            HitungNilai hitungNilai = new HitungNilai();
            if (nilai != string.Empty && sks != string.Empty)
                akhir = hitungNilai.HitungNilaiAkhir(nilai, sks);
            else
                akhir = "0";
        }

        void IsiLabelBobot ()
        {
            IsiBobot(ref bobot, Nilai1_textBox.Text);
            Bobot1_label.Text = bobot;
            if (bobot == "0")
            {
                Bobot1_label.Visible = false;
            }
            IsiBobot(ref bobot, Nilai2_textBox.Text);
            Bobot2_label.Text = bobot;
            if (bobot == "0")
            {
                Bobot2_label.Visible = false;
            }
            IsiBobot(ref bobot, Nilai3_textBox.Text);
            Bobot3_label.Text = bobot;
            if (bobot == "0")
            {
                Bobot3_label.Visible = false;
            }
            IsiBobot(ref bobot, Nilai4_textBox.Text);
            Bobot4_label.Text = bobot;
            if (bobot == "0")
            {
                Bobot4_label.Visible = false;
            }
            IsiBobot(ref bobot, Nilai5_textBox.Text);
            Bobot5_label.Text = bobot;
            if (bobot == "0")
            {
                Bobot5_label.Visible = false;
            }
            IsiBobot(ref bobot, Nilai6_textBox.Text);
            Bobot6_label.Text = bobot;
            if (bobot == "0")
            {
                Bobot6_label.Visible = false;
            }
            IsiBobot(ref bobot, Nilai7_textBox.Text);
            Bobot7_label.Text = bobot;
            if (bobot == "0")
            {
                Bobot7_label.Visible = false;
            }
            IsiBobot(ref bobot, Nilai8_textBox.Text);
            Bobot8_label.Text = bobot;
            if (bobot == "0")
            {
                Bobot8_label.Visible = false;
            }
            IsiBobot(ref bobot, Nilai9_textBox.Text);
            Bobot9_label.Text = bobot;
            if (bobot == "0")
            {
                Bobot9_label.Visible = false;
            }
            IsiBobot(ref bobot, Nilai10_textBox.Text);
            Bobot10_label.Text = bobot;
            if (bobot == "0")
            {
                Bobot10_label.Visible = false;
            }
        }

        void IsiLabelAkhir()
        {
            int skstotal=0;
            int skst = 0;
            // 1
            IsiAkhir(ref akhir, Nilai1_textBox.Text, Sks1_label.Text);
            Bobotsks1_label.Text = akhir;
            if (akhir == "0")
            {
                Bobotsks1_label.Visible = false;
            }
            total = total + double.Parse(akhir);
            int.TryParse(Sks1_label.Text, out skst);
            skstotal = skstotal + skst;
            // 2 
            IsiAkhir(ref akhir, Nilai2_textBox.Text, Sks2_label.Text);
            Bobotsks2_label.Text = akhir;
            if (akhir == "0")
            {
                Bobotsks2_label.Visible = false;
            }
            total = total + double.Parse(akhir);
            int.TryParse(Sks2_label.Text, out skst);
            skstotal = skstotal + skst;
            // 3
            IsiAkhir(ref akhir, Nilai3_textBox.Text, Sks3_label.Text);
            Bobotsks3_label.Text = akhir;
            if (akhir == "0")
            {
                Bobotsks3_label.Visible = false;
            }
            total = total + double.Parse(akhir);
            int.TryParse(Sks3_label.Text, out skst);
            skstotal = skstotal + skst;
            // 4
            IsiAkhir(ref akhir, Nilai4_textBox.Text, Sks4_label.Text);
            Bobotsks4_label.Text = akhir;
            if (akhir == "0")
            {
                Bobotsks4_label.Visible = false;
            }
            total = total + double.Parse(akhir);
            int.TryParse(Sks4_label.Text, out skst);
            skstotal = skstotal + skst;
            // 5
            IsiAkhir(ref akhir, Nilai5_textBox.Text, Sks5_label.Text);
            Bobotsks5_label.Text = akhir;
            if (akhir == "0")
            {
                Bobotsks5_label.Visible = false;
            }
            total = total + double.Parse(akhir);
            int.TryParse(Sks5_label.Text, out skst);
            skstotal = skstotal + skst;
            // 6
            IsiAkhir(ref akhir, Nilai6_textBox.Text, Sks6_label.Text);
            Bobotsks6_label.Text = akhir;
            if (akhir == "0")
            {
                Bobotsks6_label.Visible = false;
            }
            total = total + double.Parse(akhir);
            int.TryParse(Sks6_label.Text, out skst);
            skstotal = skstotal + skst;
            // 7
            IsiAkhir(ref akhir, Nilai7_textBox.Text, Sks7_label.Text);
            Bobotsks7_label.Text = akhir;
            if (akhir == "0")
            {
                Bobotsks7_label.Visible = false;
            }
            total = total + double.Parse(akhir);
            int.TryParse(Sks7_label.Text, out skst);
            skstotal = skstotal + skst;
            // 8
            IsiAkhir(ref akhir, Nilai8_textBox.Text, Sks8_label.Text);
            Bobotsks8_label.Text = akhir;
            if (akhir == "0")
            {
                Bobotsks8_label.Visible = false;
            }
            total = total + double.Parse(akhir);
            int.TryParse(Sks8_label.Text, out skst);
            skstotal = skstotal + skst;
            // 9
            IsiAkhir(ref akhir, Nilai9_textBox.Text, Sks9_label.Text);
            Bobotsks9_label.Text = akhir;
            if (akhir == "0")
            {
                Bobotsks9_label.Visible = false;
            }
            total = total + double.Parse(akhir);
            int.TryParse(Sks9_label.Text, out skst);
            skstotal = skstotal + skst;
            // 10
            IsiAkhir(ref akhir, Nilai10_textBox.Text, Sks10_label.Text);
            Bobotsks10_label.Text = akhir;
            if (akhir=="0")
            {
                Bobotsks10_label.Visible = false;
            }
            int.TryParse(Sks10_label.Text, out skst);
            skstotal = skstotal + skst;
           

            //NilaiTotal_label.Text = total.ToString();
            //NilaiSKS_label.Text = skstotal.ToString();
            //double nilaiIp = total / skstotal;
            //NilaiIP_label.Text = nilaiIp.ToString("0.##");
        }

        private void HideKosong ()
        {
            if(Matkul1_label.Text==string.Empty)
            {
                Nilai1_textBox.Visible = false;
                Nomor1_label.Visible = false;
            }
            if (Matkul2_label.Text == string.Empty)
            {
                Nilai2_textBox.Visible = false;
                Nomor2_label.Visible = false;
            }
            if (Matkul3_label.Text == string.Empty)
            {
                Nilai3_textBox.Visible = false;
                Nomor3_label.Visible = false;
            }
            if (Matkul4_label.Text == string.Empty)
            {
                Nilai4_textBox.Visible = false;
                Nomor4_label.Visible = false;
            }
            if (Matkul5_label.Text == string.Empty)
            {
                Nilai5_textBox.Visible = false;
                Nomor5_label.Visible = false;
            }
            if (Matkul6_label.Text == string.Empty)
            {
                Nilai6_textBox.Visible = false;
                Nomor6_label.Visible = false;
            }
            if (Matkul7_label.Text == string.Empty)
            {
                Nilai7_textBox.Visible = false;
                Nomor7_label.Visible = false;
            }
            if (Matkul8_label.Text == string.Empty)
            {
                Nilai8_textBox.Visible = false;
                Nomor8_label.Visible = false;
            }
            if (Matkul9_label.Text == string.Empty)
            {
                Nilai9_textBox.Visible = false;
                Nomor9_label.Visible = false;
            }
            if (Matkul10_label.Text == string.Empty)
            {
                Nilai10_textBox.Visible = false;
                Nomor10_label.Visible = false;
            }
        }
    }
}
