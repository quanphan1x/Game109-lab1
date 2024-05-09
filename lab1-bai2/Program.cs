using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide1
{
   
    public static class Maps
    {
        public static string Id;
        public static string UserName;
        public static string _InGame = "Lien Minh Huyen Thoai";
        public Maps(string id, string userName)
        {
            this.id = id;
            this.userName = userName;

        }
        
    }
    public string ShowData()
    {
        return "ID: " + id + |Name: : " + userName + "| InGame: "+ _inGame";

    }
}