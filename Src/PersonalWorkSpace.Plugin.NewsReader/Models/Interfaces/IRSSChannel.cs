using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.NewsReader.Models.Interfaces
{
    public interface IRSSChannel
    {
        /// <summary>
        /// The name of the channel.
        /// </summary>
        string Title { get; }

        /// <summary>
        /// The description of the channel.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Link to the channel.
        /// </summary>
        string Link { get; }

        /// <summary>
        /// The stories of the channel.
        /// </summary>
        ICollection<IRSSStory> Stories { get; }
    }
}
