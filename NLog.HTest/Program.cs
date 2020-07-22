using System;

namespace NLog.HTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Info($"Info 1234");
            Log.Error($"Error 7895");
            Console.WriteLine("Hello World!");
        }
    }
}
