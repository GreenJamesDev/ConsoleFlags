using System;
using System.Threading;
using ConsoleFlagsNET;

// Console flags example application.

namespace ConsoleFlagsExampleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleFlags.WriteSuccess("Program started!");
            Thread.Sleep(2000);
            ConsoleFlags.WriteOK("This is an OK flag.");
            Thread.Sleep(2000);
            ConsoleFlags.WriteInfo("This is an info flag.");
            Thread.Sleep(2000);
            ConsoleFlags.WriteWarning("This is a warning flag.");
            Thread.Sleep(2000);
            ConsoleFlags.WriteError("This is an error flag.");
            Thread.Sleep(2000);
            ConsoleFlags.WriteConnection("This is a connection flag.");
            Thread.Sleep(2000);
            ConsoleFlags.WriteDebug("This is a debug flag.");
            Thread.Sleep(2000);
            ConsoleFlags.WriteCustom("Random", "This is a custom-made flag.", ConsoleColor.Blue);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
