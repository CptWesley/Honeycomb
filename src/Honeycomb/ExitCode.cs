namespace Honeycomb
{
    /// <summary>
    /// Enumeration for exit codes.
    /// </summary>
    public enum ExitCode
    {
        /// <summary>
        /// Exit code for when the program exits correctly.
        /// </summary>
        Success = 0,

        /// <summary>
        /// Exit code for when no target was given.
        /// </summary>
        NoTargets = 1,

        /// <summary>
        /// Exit code for when a given target was not known to the program.
        /// </summary>
        UnknownTarget = 2,

        /// <summary>
        /// Exit code for when a given target has failed it's execution.
        /// </summary>
        TargetFailed = 3
    }
}
