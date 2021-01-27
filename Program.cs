using System;


// [assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace log4NetConfigConsoleApp
{
    class Program
    {

        private static readonly log4net.ILog Log = log4net.LogManager
            .GetLogger(System.Reflection.MethodBase.GetCurrentMethod()?.DeclaringType);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Log.Debug("This is a debug message");
            Log.Info("This is an information message");
            Log.Warn("This is a warning message");
            Log.Error("This is an error message");
            Log.Fatal("This is a fatal message");
        }
    }
}
