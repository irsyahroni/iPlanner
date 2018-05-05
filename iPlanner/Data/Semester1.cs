using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iPlanner.Data
{
    public class Semester1
    {
        private string namaMatkul;
        private int sks;
        private string nilai;
        private double bobot;
        private double bobotxsks;

        protected double Pembobotan(string Nilai)
        {
            char huruf = nilai[0];
            huruf = System.Char.ToLower(huruf);
            switch (huruf)
            {
                case 'a':
                    bobot = 4;
                    break;
                case 'b':
                    bobot = 3;
                    break;
                case 'c':
                    bobot = 2;
                    break;
                case 'd':
                    bobot = 1;
                    break;
                case 'e':
                    bobot = 0;
                    break;
            }
            char tambah = nilai[1];
            if (tambah=='+')
            {
                bobot += 0.25;
            }
            else
            {
                bobot -= 0.25;
            }

            return bobot;
        }
    }

}
