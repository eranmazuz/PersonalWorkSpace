using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.NewsReader.Models.Interfaces
{
    /// <summary>
    /// Interface for the RSS story class.
    /// </summary>
    public interface IRSSStory
    {
        /// <summary>
        /// The title of the RSS item.
        /// </summary>
        string Title { get; }

        /// <summary>
        /// The RSS item synopsis.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Link to the story.
        /// </summary>
        string Link { get; }

    }
}
