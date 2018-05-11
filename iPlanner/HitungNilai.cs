using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iPlanner
{
    public class HitungNilai
    {
        private double bobot;
        private double nilaiAkhir;

        private void Translate(string nilai)
        {
            nilai = nilai.ToUpper();
            for (int i = 0; i < 12; i++)
            {
                if (NilaiDalamHuruf[i] == nilai)
                    bobot = NilaiDalamBobot[i];
            }
        }

        private void NilaiFinal(double bobot, int sks)
        {
            nilaiAkhir = bobot * sks;
        }

        public string HitungNilaiHuruf(string huruf)
        {
            Translate(huruf);
            return bobot.ToString();
        }

        public string HitungNilaiAkhir(string huruf, string sks)
        {
            Translate(huruf);
            NilaiFinal(bobot, int.Parse(sks));
            return nilaiAkhir.ToString();
        }

        private static string[] NilaiDalamHuruf = new string[12] 
        { "A", "A-", "A/B", "B+", "B", "B-", "B/C", "C+", "C", "C-", "D", "E"};

        private static double[] NilaiDalamBobot = new double[12]
        { 4.0, 3.75, 3.5, 3.25, 3.0, 2.75, 2.5, 2.25, 2, 1.75, 1, 0};
    }
}

