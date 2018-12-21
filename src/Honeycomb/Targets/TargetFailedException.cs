using System;

namespace Honeycomb.Targets
{
    /// <summary>
    /// Exception thrown when a target fails during execution.
    /// </summary>
    /// <seealso cref="Exception" />
    public class TargetFailedException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TargetFailedException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public TargetFailedException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TargetFailedException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public TargetFailedException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TargetFailedException"/> class.
        /// </summary>
        public TargetFailedException()
        {
        }
    }
}
