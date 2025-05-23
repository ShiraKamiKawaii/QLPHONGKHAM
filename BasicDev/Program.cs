﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using QLPHONGKHAM.UI;

namespace BasicDev {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (true)
            {
                using (frmLogin frmLogin = new frmLogin())
                {
                    if (frmLogin.ShowDialog() != DialogResult.OK)
                        return;
                    frmMain mainForm = new frmMain(frmLogin.UserRole);
                        Application.Run(mainForm);
                          
                };
            }
            
        }
    }
}
