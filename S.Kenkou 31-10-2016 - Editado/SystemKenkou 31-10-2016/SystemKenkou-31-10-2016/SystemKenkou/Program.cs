using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SystemKenkou
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login_principal());
            //Application.Run(new Frm_cadastro_consulta());
           
        }
    }
}
