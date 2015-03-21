using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FrontendServer
{
    class Pages
    {   const string pagesdir = "../../../resources/Pages/";
        
        public static string Main = File.ReadAllText(pagesdir + "main.html");
        public static string Register = File.ReadAllText(pagesdir + "register.html");
        public static string Login = File.ReadAllText(pagesdir + "login.html");

        public static string ClientsControl = File.ReadAllText(pagesdir + "clientscontrol.html");
        public static string PhotosControl = File.ReadAllText(pagesdir + "photoscontrol.html");

        public static string Table = File.ReadAllText(pagesdir + "table.html");
    }
}
