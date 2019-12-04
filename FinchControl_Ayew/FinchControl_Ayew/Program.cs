using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinchControl_Ayew
{
    static class Program
    // **************************************************
    //
    // Title: Finch Control Ayew
    // Description: A WinForms App that lets you control the Finch Robot
    // Application Type: WinForms
    // Author: Michelle Vanwettere
    // Dated Created: November 25th, 2019
    // Last Modified: December 4th, 2019
    //
    // **************************************************
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_FinchControl());
        }
    }
}
