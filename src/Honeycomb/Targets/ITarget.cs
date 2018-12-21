namespace Honeycomb.Targets
{
    /// <summary>
    /// Interface for build targets.
    /// </summary>
    public interface ITarget
    {
        /// <summary>
        /// Perform the target.
        /// </summary>
        /// <exception cref="TargetFailedException">Thrown when a target failed being executed.</exception>
        void Perform();
    }
}
