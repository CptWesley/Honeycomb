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
            => WriteLine($"[INFO] {value}");

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
            => WriteLine($"[WARNING] {value}", ConsoleColor.Yellow);

        /// <summary>
        /// Prints an error line.
        /// </summary>
        /// <param name="value">Value to print.</param>
        public static void WriteErrorLine(object value)
            => WriteLine($"[ERROR] {value}", ConsoleColor.Red);

        /// <summary>
        /// Writes a line in a certain colour to the console.
        /// </summary>
        /// <param name="value">Value to write.</param>
        /// <param name="color">Color to write it in.</param>
        public static void WriteLine(object value, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(value);
            Console.ResetColor();
        }

        /// <summary>
        /// Writes a line to the console.
        /// </summary>
        /// <param name="value">Value to write.</param>
        public static void WriteLine(object value)
            => Console.WriteLine(value);
    }
}
