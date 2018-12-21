namespace Honeycomb.Targets
{
    /// <summary>
    /// Target which builds all projects.
    /// </summary>
    /// <seealso cref="ITarget" />
    public class BuildTarget : ITarget
    {
        /// <inheritdoc/>
        public string Name => "build";

        /// <inheritdoc/>
        public string Description => "Builds the project.";

        /// <inheritdoc/>
        public void Perform()
        {
            throw new System.NotImplementedException();
        }
    }
}
