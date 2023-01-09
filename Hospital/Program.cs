using static Hospital.Func;
namespace Hospital
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
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