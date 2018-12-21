namespace Honeycomb.Targets
{
    /// <summary>
    /// Interface for build targets.
    /// </summary>
    public interface ITarget
    {
        /// <summary>
        /// Gets the name of the target.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the description of the target.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Perform the target.
        /// </summary>
        /// <exception cref="TargetFailedException">Thrown when a target failed being executed.</exception>
        void Perform();
    }
}
