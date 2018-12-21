namespace Honeycomb
{
    /// <summary>
    /// Constant holder for exit codes.
    /// </summary>
    public static class ExitCode
    {
        /// <summary>
        /// Exit code for when the program exits correctly.
        /// </summary>
        public const int Success = 0;

        /// <summary>
        /// Exit code for when no target was given.
        /// </summary>
        public const int NoTargets = 1;

        /// <summary>
        /// Exit code for when a given target was not known to the program.
        /// </summary>
        public const int UnknownTarget = 2;
    }
}
