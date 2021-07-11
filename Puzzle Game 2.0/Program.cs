using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle_Game_2._0
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
            //Application.Run(new Form1());
            //Application.Run(new puzzle_game());
            //Application.Run(new puzzle_m());
            //Application.Run(new puzzle_select());
            //Application.Run(new Form1());
            //Application.Run(new Login());
            //Application.Run(new Signup());
            Application.Run(new Form1());
        }
    }
}
