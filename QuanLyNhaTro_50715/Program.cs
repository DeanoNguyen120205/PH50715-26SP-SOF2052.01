using DuAnMau_QuanLyPhongtro_PH50715;

namespace QuanLyNhaTro_50715
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new QLKhachThue());
        }
    }
}