using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Chatting
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //string constr = "server=localhost;User Id=root;password=guo1cheng;Database=chatting";
            //MySqlConnection mycon = new MySqlConnection(constr);
            //mycon.Open();
            //Console.WriteLine("已建立连接");
            //MySqlCommand mycmd = new MySqlCommand("select * from users", mycon);
            //MySqlDataReader res = mycmd.ExecuteReader();
            //res.Read();
            //Console.WriteLine(res.GetString("account"));


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
