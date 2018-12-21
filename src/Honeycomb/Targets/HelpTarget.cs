using System;

namespace Honeycomb.Targets
{
    /// <summary>
    /// Target which displays all available targets.
    /// </summary>
    /// <seealso cref="ITarget" />
    public class HelpTarget : ITarget
    {
        /// <inheritdoc/>
        public string Name => "help";

        /// <inheritdoc/>
        public string Description => "Gives information about build targets and flags.";

        /// <inheritdoc/>
        public void Perform()
        {
            Console.WriteLine("Usage: 'honeycomb <target>'");
            Console.WriteLine("Optionally a user can specify multiple targets to be executed in succession: 'honeycomb <target1> <target2> ...'");
            Console.WriteLine();
            Console.WriteLine("### Available Targets:");

            foreach (ITarget target in TargetCollection.AsEnumerable())
            {
                Console.WriteLine($"{target.Name} - {target.Description}");
            }
        }
    }
}
