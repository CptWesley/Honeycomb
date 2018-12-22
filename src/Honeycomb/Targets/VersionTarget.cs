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
        public string Name => "version";

        /// <inheritdoc/>
        public string Description => "Displays information about the used version of the program.";

        /// <inheritdoc/>
        public void Perform()
        {
            AssemblyName asm = Assembly.GetExecutingAssembly().GetName();
            HoneycombConsole.WriteInfoLine($"name: {asm.Name}");
            HoneycombConsole.WriteInfoLine($"version: {asm.Version}");
            HoneycombConsole.WriteInfoLine($"url: {GitInfo.GetAddress()}");
            HoneycombConsole.WriteInfoLine($"branch: {GitInfo.GetBranch()}");
            HoneycombConsole.WriteInfoLine($"commit: {GitInfo.GetCommit()}");
        }
    }
}
