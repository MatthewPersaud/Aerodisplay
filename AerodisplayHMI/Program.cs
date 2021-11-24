﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AerodisplayHMI
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
            Application.Run(new Form1());

            Controller.ascend(12000);
            int check = Intercooler.getTemp();
            Controller.ascend(2000);
            Altimeter a = new Altimeter();
            a.GetAltitude();
        }
    }
}
