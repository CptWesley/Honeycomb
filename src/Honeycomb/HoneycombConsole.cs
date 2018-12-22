using System;

namespace Honeycomb
{
    /// <summary>
    /// Static class with console functions for different types of prints.
    /// </summary>
    public static class HoneycombConsole
    {
        /// <summary>
        /// Prints an information line.
        /// </summary>
        /// <param name="value">Value to print.</param>
        public static void WriteInfoLine(object value)
            => Console.WriteLine($"[INFO] {value}");

        /// <summary>
        /// Prints an empty line.
        /// </summary>
        public static void WriteNewline()
            => Console.WriteLine();

        /// <summary>
        /// Prints a warning line.
        /// </summary>
        /// <param name="value">Value to print.</param>
        public static void WriteWarningLine(object value)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[WARNING] {value}");
            Console.ResetColor();
        }

        /// <summary>
        /// Prints an error line.
        /// </summary>
        /// <param name="value">Value to print.</param>
        public static void WriteErrorLine(object value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[ERROR] {value}");
            Console.ResetColor();
        }
    }
}
