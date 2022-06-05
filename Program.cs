using System;
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms;

namespace LABORATOR6___EmguCV
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        [SuppressMessage(@"ReSharper.DPA", @"DPA0001: Memory allocation issues")]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Base());
        }
    }
}