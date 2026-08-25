using System;
using System.Windows.Forms;

namespace Guess_The_Card
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start the game at the intro screen
            Application.Run(new FormIntro());
        }
    }
}
