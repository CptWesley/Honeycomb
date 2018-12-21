using System;

namespace Honeycomb
{
    /// <summary>
    /// Entry class of the CLI.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Entry function of the CLI.
        /// </summary>
        /// <param name="args">Program arguments.</param>
        /// <returns>Exit code of the CLI.</returns>
        public static int Main(string[] args)
        {
            if (args.Length <= 0)
            {
                Console.WriteLine("No targets were supplied. Use 'honeycomb help' for more information.");
                return ExitCode.NoTargets;
            }

            return ExitCode.Success;
        }
    }
}
