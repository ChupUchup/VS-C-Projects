using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aotools
{
    static class Program
    {
        /// <summary>
        /// Public variable of list hWnd
        /// </summary>
        public static IntPtr[] _list_hwnd = new IntPtr[0];

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new form_automouse());
        }
    }
}
