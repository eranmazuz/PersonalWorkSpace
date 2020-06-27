using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin
{
    /// <summary>
    /// Used to set template for the plugins that will be loaded.
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// The plugin name.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The plugin description.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// The path of the image cover of the plugin.
        /// </summary>
        string Cover { get; }
    }
}
