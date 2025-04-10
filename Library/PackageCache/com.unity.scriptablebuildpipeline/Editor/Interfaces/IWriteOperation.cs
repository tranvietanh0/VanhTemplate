using UnityEditor.Build.Content;
using UnityEditor.Build.Pipeline.Utilities;
using UnityEngine;

namespace UnityEditor.Build.Pipeline.Interfaces
{
    /// <summary>
    /// Base interface for wrapping the different low level WriteSerializeFile API around a common high level Write function
    /// </summary>
    public interface IWriteOperation
    {
        /// <summary>
        /// The specific write command containing the details about what to write to disk.
        /// <see cref="WriteCommand"/>
        /// </summary>
        WriteCommand Command { get; set; }

        /// <summary>
        /// The specific usage data for objects in the write command.
        /// <see cref="BuildUsageTagSet"/>
        /// </summary>
        BuildUsageTagSet UsageSet { get; set; }

        /// <summary>
        /// The specific reference data for objects in the write command.
        /// <see cref="BuildReferenceMap"/>
        /// </summary>
        BuildReferenceMap ReferenceMap { get; set; }

        /// <summary>
        /// The hash that represents the unique set of input dependencies for caching this write command.
        /// </summary>
        Hash128 DependencyHash { get; set; }

        /// <summary>
        /// Write function that wraps the low level WriteSerializeFile APIs that takes the common minimum set of parameters.
        /// </summary>
        /// <param name="outputFolder">The location to write data to disk.</param>
        /// <param name="settings">The build settings to use for writing data.</param>
        /// <param name="globalUsage">The global usage to use for writing data.</param>
        /// <returns>The write results struct containing details about what was written to disk</returns>
        WriteResult Write(string outputFolder, BuildSettings settings, BuildUsageTagGlobal globalUsage);

        /// <summary>
        /// Optimized hash function for use with the Build Cache system.
        /// </summary>
        /// <returns>Unique hash for the contents of this write operation.</returns>
        Hash128 GetHash128();

        /// <summary>
        /// Optimized hash function for use with the Build Cache system.
        /// </summary>
        /// <param name="log">The build log.</param>
        /// <returns>Unique hash for the contents of this write operation.</returns>
        Hash128 GetHash128(IBuildLogger log);
    }
}
