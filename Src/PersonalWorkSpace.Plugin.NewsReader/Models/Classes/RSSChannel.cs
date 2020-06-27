using Plugin.NewsReader.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.NewsReader.Models.Classes
{
    /// <summary>
    /// Interface for the RSS channel class.
    /// </summary>
    public class RSSChannel : IRSSChannel
    {
        public RSSChannel(string title, string description, string link)
        {
            Title = title;
            Description = description;
            Link = link;
        }

        /// <summary>
        /// The title of the RSS item.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// The RSS item synopsis.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Link to the story.
        /// </summary>
        public string Link { get; }

        /// <summary>
        /// The stories of the channel.
        /// </summary>
        public ICollection<IRSSStory> Stories { get; } = new List<IRSSStory>();
    }
}
