using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_Labs1
{
    public class Maps
    {
        public string id;
        public string userName;
        public static string _inGame = "lien minh huyen thoai";

        public Maps(string id, string userName)
        {
            this.id = id;
            this.userName = userName;
        }
        public string ShowData()
        {
            return "ID : " + id + "|Name:" + userName + "|inGame:" + _inGame;
        }
    }
}