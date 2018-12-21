namespace Honeycomb.Targets
{
    /// <summary>
    /// Target which creates a Honeycomb project.
    /// </summary>
    /// <seealso cref="ITarget" />
    public class CreateTarget : ITarget
    {
        /// <inheritdoc/>
        public string Name => "create";

        /// <inheritdoc/>
        public string Description => "Creates a new project.";

        /// <inheritdoc/>
        public void Perform()
        {
            throw new TargetFailedException("Target is not yet implemented");
        }
    }
}
