using System;
using System.Reflection;

namespace Honeycomb.Targets
{
    /// <summary>
    /// Target which displays version information.
    /// </summary>
    /// <seealso cref="ITarget" />
    public class VersionTarget : ITarget
    {
        /// <inheritdoc/>
        public void Perform()
        {
            AssemblyName asm = Assembly.GetExecutingAssembly().GetName();
            Console.WriteLine($"### {asm.Name} ###");
            Console.WriteLine($"version: {asm.Version}");
            Console.WriteLine($"url: {GitInfo.GetAddress()}");
            Console.WriteLine($"branch: {GitInfo.GetBranch()}");
            Console.WriteLine($"commit: {GitInfo.GetCommit()}");
        }
    }
}
