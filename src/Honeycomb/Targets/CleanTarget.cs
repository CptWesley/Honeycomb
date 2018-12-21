namespace Honeycomb.Targets
{
    /// <summary>
    /// Target which cleans binaries created during building.
    /// </summary>
    /// <seealso cref="ITarget" />
    public class CleanTarget : ITarget
    {
        /// <inheritdoc/>
        public string Name => "clean";

        /// <inheritdoc/>
        public string Description => "Cleans the project of binaries created during building.";

        /// <inheritdoc/>
        public void Perform()
        {
            throw new System.NotImplementedException();
        }
    }
}
