using System;
using System.Windows.Forms;

namespace Datastruc
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form2()); // start with loading screen
        }
    }
}
