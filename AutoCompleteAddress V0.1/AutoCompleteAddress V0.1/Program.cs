using AutoCompleteAddress.View;
using System;
using System.Windows.Forms;

namespace AutoCompleteAddress_V0._1
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
            Application.Run(new FrmAddress());
        }
    }
}
