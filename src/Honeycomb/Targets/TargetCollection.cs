using System.Collections.Generic;
using System.Linq;

namespace Honeycomb.Targets
{
    /// <summary>
    /// Contains a collection of all available targets.
    /// </summary>
    public static class TargetCollection
    {
        private static ITarget[] _targets = new ITarget[]
        {
            new HelpTarget(),
            new VersionTarget(),
            new CreateTarget(),
            new BuildTarget(),
            new CleanTarget()
        };

        private static Dictionary<string, ITarget> _dictionary = _targets.ToDictionary(x => x.Name, x => x);

        /// <summary>
        /// Gets the target instance based on a name.
        /// </summary>
        /// <param name="targetName">Name of the target.</param>
        /// <returns>The target if a match was found.</returns>
        public static ITarget Get(string targetName)
            => _dictionary[targetName];

        /// <summary>
        /// Checks if a target name is known to the program.
        /// </summary>
        /// <param name="targetName">Name of the target.</param>
        /// <returns>True if known, false otherwise.</returns>
        public static bool Contains(string targetName)
            => _dictionary.ContainsKey(targetName);

        /// <summary>
        /// Gets an enumerable of all targets in the collection.
        /// </summary>
        /// <returns>An enumerable of targets.</returns>
        public static IEnumerable<ITarget> AsEnumerable()
        {
            foreach (ITarget target in _targets)
            {
                yield return target;
            }
        }
    }
}
