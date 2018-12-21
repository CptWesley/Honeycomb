using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Honeycomb.Targets
{
    /// <summary>
    /// Contains a collection of all available targets.
    /// </summary>
    public static class TargetCollection
    {
        private static Dictionary<string, ITarget> _targets = new Dictionary<string, ITarget>
        {
            { "help", new HelpTarget() },
            { "create", new CreateTarget() },
            { "build", new BuildTarget() },
            { "clean", new CleanTarget() }
        };

        /// <summary>
        /// Gets the target instance based on a name.
        /// </summary>
        /// <param name="targetName">Name of the target.</param>
        /// <returns>The target if a match was found.</returns>
        public static ITarget Get(string targetName)
            => _targets[targetName];

        /// <summary>
        /// Checks if a target name is known to the program.
        /// </summary>
        /// <param name="targetName">Name of the target.</param>
        /// <returns>True if known, false otherwise.</returns>
        public static bool Contains(string targetName)
        {
            return _targets.ContainsKey(targetName);
        }

        /// <summary>
        /// Gets an array of all keys and values in the collection.
        /// </summary>
        /// <returns>An array of tuples of all keys and values.</returns>
        [SuppressMessage("Spacing Rules", "SA1008", Justification = "Space should not be there, seems to be a parsing error.")]
        [SuppressMessage("Spacing Rules", "SA1009", Justification = "Space should not be there, seems to be a parsing error.")]
        public static IEnumerable<(string name, ITarget target)> AsEnumerable()
        {
            foreach (KeyValuePair<string, ITarget> entry in _targets)
            {
                yield return (entry.Key, entry.Value);
            }
        }
    }
}
