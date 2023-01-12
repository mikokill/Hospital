using System.Globalization;
using static Hospital.Func;
using System.Diagnostics;
namespace Hospital
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            if (CultureInfo.InstalledUICulture.Name == "pl-PL")
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("pl-PL");
            else
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            if (File.Exists("usersData.json")) DeserializujDane();
            if (File.Exists("shiftsData.json")) DeserializujDyzury();
            if (listpesel.Count != 0)
            {
                Application.ApplicationExit += new EventHandler(OnApplicationExit);
                AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnApplicationExit);
                ApplicationConfiguration.Initialize();
                Application.Run(new Login());
            }
            else
            {
                Application.ApplicationExit += new EventHandler(OnApplicationExit);
                AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnApplicationExit);
                ApplicationConfiguration.Initialize();
                Application.Run(new AdminAdd(false));
            }
        }
        private static void OnApplicationExit(object? sender, EventArgs e)
        {
            SerializujDane();
            SerializujDyzury();
        }
    }
}