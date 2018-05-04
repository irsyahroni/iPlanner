using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iPlanner
{
    public class loginCheck
    {
        //
        //Implementasi Enkapsulasi
        //
            
        private static string userId = "admin";
        private static string userPass = "admin";
        public string UserNama()
        {
            return userId;
        }
        public string UserPassword()
        {
            return userPass;
        }

    }
}
