using Tyuiu.MironenkoSE.Sprint6.Task5.V6.Lib;
namespace Tyuiu.MironenkoSE.Sprint6.Task5.V6
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
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