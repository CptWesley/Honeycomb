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
            HoneycombConsole.WriteInfoLine("Usage: 'honeycomb <target>'");
            HoneycombConsole.WriteInfoLine("Optionally a user can specify multiple targets to be executed in succession: 'honeycomb <target1> <target2> ...'");
            HoneycombConsole.WriteNewline();
            HoneycombConsole.WriteInfoLine("### Available Targets:");

            foreach (ITarget target in TargetCollection.AsEnumerable())
            {
                HoneycombConsole.WriteInfoLine($"{target.Name} - {target.Description}");
            }
        }
    }
}
