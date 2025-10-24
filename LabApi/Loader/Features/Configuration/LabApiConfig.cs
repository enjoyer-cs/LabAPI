﻿using LabApi.Loader.Features.Paths;
using System.Collections.Generic;
using System.ComponentModel;

namespace LabApi.Loader.Features.Configuration;

/// <summary>
/// Configuration for LabAPI core functionality.
/// </summary>
public class LabApiConfig
{
    /// <summary>
    /// List of dependency paths relative to <see cref="PathManager.Dependencies"/>.
    /// </summary>
    [Description("List of dependency paths relative to the Dependencies folder to load from. Use $port to load from the server port's folder.")]
    public List<string> DependencyPaths { get; set; } = ["global", "$port"];

    /// <summary>
    /// List of plugin paths relative to <see cref="PathManager.Plugins"/>.
    /// </summary>
    [Description("List of plugin paths relative to the Plugins folder to load from. Use $port to load from the server port's folder.")]
    public List<string> PluginPaths { get; set; } = ["global", "$port"];

    /// <summary>
    /// Whether to allow loading plugins even if they were built for a different major version of LabAPI.
    /// </summary>
    /// <seealso cref="LabApi.Loader.Features.Plugins.Configuration.Properties.UnsupportedLoading"/>
    [Description("Whether to allow loading plugins even if they were built for a different major version of LabAPI.")]
    public bool LoadUnsupportedPlugins { get; set; }
}
