using System;
using System.Windows.Forms;

namespace Lab04_Bai02
{
    internal static class Program
    {
        /// <summary>
        /// Điểm bắt đầu của chương trình.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form1());
        }
    }
}