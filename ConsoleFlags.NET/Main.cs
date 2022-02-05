using System;

namespace ConsoleFlags.NET
{
    public static class ConsoleFlags
    {

        // =======================================================
        //                   PRESET FLAGS
        // =======================================================

        public static void WriteSuccess(string input)
        {
            WriteCustom("SUCCESS", input, ConsoleColor.Green);

        }

        public static void WriteOK(string input)
        {
            WriteCustom("OK", input, ConsoleColor.DarkGreen);

        }

        public static void WriteInfo(string input)
        {
            WriteCustom("INFO", input, ConsoleColor.Cyan);

        }

        public static void WriteError(string input)
        {
            WriteCustom("ERROR", input, ConsoleColor.Red);

        }

        public static void WriteWarning(string input)
        {
            WriteCustom("WARNING", input, ConsoleColor.DarkYellow);

        }

        public static void WriteConnection(string input)
        {
            WriteCustom("CONNECTION", input, ConsoleColor.DarkMagenta);

        }

        public static void WriteDebug(string input)
        {
            WriteCustom("DEBUG", input, ConsoleColor.DarkGray);
        }

        // =========================================================

        /// <summary>
        /// Used to write a message to the console with a custom flag.
        /// </summary>
        /// <param name="flag_text">The text that appears within the console flag.</param>
        /// <param name="input">The text the appear beside the flag.</param>
        /// <param name="color">The color of the flag text.</param>
        public static void WriteCustom(string flag_text, string input, ConsoleColor color)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("[");
            Console.ForegroundColor = color;
            Console.Write(flag_text);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("] " + input);
        }
    }
}
