using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVTO_BASE
{
    static class Data
    {
        public static string Global_connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user.STUD\Desktop\ДОУ\AVTO_BASE\AVTO_BASE\AVTO_BASE.mdf;Integrated Security = True";
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}




