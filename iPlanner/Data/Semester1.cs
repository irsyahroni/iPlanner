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
        private static string[] Matkul = new string[10];
        private static string[] Nilai = new string[10];

        public static void IsiKosong(ref string[] isi)
        {
            for (int i = 0; i < isi.GetLength(0); i++)
            {              
                isi[i] = " ";
            }
        }

        public static string[] DapatMatkul()
        {
            return Matkul;
        }

        public static string[] DapatNilai()
        {
            return Nilai;
        }
    }

}
