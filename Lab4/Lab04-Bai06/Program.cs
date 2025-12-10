using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_Bai06
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string tokenType = "123";
            string accessToken = "123";
            if (args.Length > 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    {
                        if (args[i] == "-TokenType")
                        {
                            try
                            {
                                tokenType = args[i + 1];
                            }
                            catch { }
                        }
                        if (args[i] == "-AccessToken")
                        {
                            try
                            {
                                accessToken = args[i + 1];
                            }
                            catch { }
                        }
                    }
                }
            }
            Application.Run(new Info(tokenType, accessToken));
        }
    }
}
