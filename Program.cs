using System.Diagnostics;

namespace StartProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Process.Start(@"C:\Users\Pavlo\source\repos\StartProcess\bin\Debug\StartProcess");
            }

            /*foreach (Process process in Process.GetProcessesByName("StartProcess"))
            {
                process.Kill();
            }*/
        }
    }
}