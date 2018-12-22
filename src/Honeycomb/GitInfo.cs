using System.IO;
using System.Reflection;

namespace Honeycomb
{
    /// <summary>
    /// Used to retrieve certain git information which is added during compile-time.
    /// </summary>
    public static class GitInfo
    {
        /// <summary>
        /// Gets the hash of the current commit.
        /// </summary>
        /// <returns>The hash of the current commit.</returns>
        public static string GetCommit()
            => GetContent("commit");

        /// <summary>
        /// Gets the name of the current branch.
        /// </summary>
        /// <returns>The name of the current branch.</returns>
        public static string GetBranch()
            => GetContent("branch");

        /// <summary>
        /// Gets the url of the repository.
        /// </summary>
        /// <returns>The url of the repository.</returns>
        public static string GetAddress()
            => GetContent("url");

        private static string GetContent(string fileName)
        {
            using (Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream($"Honeycomb.git_info.{fileName}"))
            {
                if (stream == null)
                {
                    return "-";
                }

                using (StreamReader sr = new StreamReader(stream))
                {
                    return sr.ReadToEnd().Trim();
                }
            }
        }
    }
}
