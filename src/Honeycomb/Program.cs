using System;
using System.Collections.Generic;
using Honeycomb.Targets;

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
        public static void Main(string[] args)
        {
            if (args.Length <= 0)
            {
                Console.WriteLine("No targets were supplied. Use 'honeycomb help' for more information.");
                Exit(ExitCode.NoTargets);
            }

            foreach (ITarget target in ParseArguments(args))
            {
                try
                {
                    target.Perform();
                }
                catch (TargetFailedException e)
                {
                    Console.WriteLine($"Failed executing target '{target.Name}' because '{e.Message}'.");
                    Exit(ExitCode.TargetFailed);
                }
            }

            Exit(ExitCode.Success);
        }

        /// <summary>
        /// Parses the arguments.
        /// </summary>
        /// <param name="args">Program arguments.</param>
        /// <returns>A collection of all targets to be executed.</returns>
        private static IEnumerable<ITarget> ParseArguments(string[] args)
        {
            foreach (string arg in args)
            {
                if (TargetCollection.Contains(arg))
                {
                    yield return TargetCollection.Get(arg);
                }
                else
                {
                    Console.WriteLine($"Unknown target '{arg}' found. Use 'honeycomb help' for a list of all available targets.");
                    Exit(ExitCode.UnknownTarget);
                }
            }
        }

        /// <summary>
        /// Exits the application with the given exit code.
        /// </summary>
        /// <param name="exitCode">Exit code to exit with.</param>
        private static void Exit(ExitCode exitCode)
        {
            Console.WriteLine();
            Console.WriteLine($"Exited with code '{(int)exitCode}' ({exitCode}).");
            Environment.Exit((int)exitCode);
        }
    }
}
