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
            throw new System.NotImplementedException();
        }
    }
}
