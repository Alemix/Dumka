using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.SqlServer.Dts.Runtime;

namespace Dumka_Buh
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>


       



                [STAThread]
        static void Main()
        {
           System.Windows.Forms.Application.EnableVisualStyles();
           System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
           System.Windows.Forms.Application.Run(new Главная_Думка_Бух());
        }
   
    
    }
}
