using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP
{
    internal class ClassUser
    {
        public static DataRow _user;
        private static bool _isUchenik = false;

        public static bool IsUchenik { get => _isUchenik; set => _isUchenik = value; }
        

        public static DataRow getUser()
        {
            return _user;
        }

        public static string getUserName() {
            string pref = _isUchenik == true ? "Ученик" : "Врач";
            return pref + " #" + _user["id"].ToString() + " " + _user["ima"].ToString() + " " + _user["otchestvo"].ToString();
        }
    }
}
