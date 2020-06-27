using Plugin.NewsReader.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.NewsReader.Models.Classes
{
    /// <summary>
    /// Represent a story in the RSS feed.
    /// </summary>
    public class RSSStory : IRSSStory
    {
        /// <summary>
        /// Constructor of the class to create story of the RSS feed.
        /// </summary>
        /// <param name="title">The title of the story.</param>
        /// <param name="description">The synopsis of the story.</param>
        /// <param name="link">The URL link for the story.</param>
        public RSSStory(string title, string description, string link)
        {
            this.Title = title;

            this.Description = description;

            this.Link = link;
        }

        /// <summary>
        /// The title of the RSS item.
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// The RSS item synopsis.
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Link to the story.
        /// </summary>
        public string Link { get; private set; }

    }
}
