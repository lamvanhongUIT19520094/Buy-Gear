﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuyGear
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form_Main());
           Application.EnableVisualStyles();
          Application.SetCompatibleTextRenderingDefault(false);
           
        }
    }
}
