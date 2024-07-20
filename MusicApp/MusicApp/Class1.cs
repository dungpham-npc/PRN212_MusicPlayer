using System;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace MusicApp
{
    static class Program
    {
        /// <summary>
        /// Điểm vào chính của ứng dụng.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MusicHomePage());
        }
    }
}
