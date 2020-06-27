using Plugin.NewsReader.Models.Classes;
using Plugin.NewsReader.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Plugin.NewsReader.ViewModels
{
    public class NewsReaderViewModel
    {
        public ICollection<IRSSChannel> channels { get; } = new ObservableCollection<IRSSChannel>();

        public NewsReaderViewModel()
        {
            IRSSChannel channel = new RSSChannel("channel 1 title", "channel 1 description", "channel 1 link");

            IRSSStory story = new RSSStory("channel 1 story 1 title", "channel 1 story 1 description", "channel 1 story 1 link");
            channel.Stories.Add(story);

            story = new RSSStory("channel 1 story 2 title", "channel 1 story 2 description", "channel 1 story 2 link");
            channel.Stories.Add(story);

            story = new RSSStory("channel 1 story 3 title", "channel 1 story 3 description", "channel 1 story 3 link");
            channel.Stories.Add(story);

            channels.Add(channel);

            channel = new RSSChannel("channel 2 title", "channel 2 description", "channel 2 link");

            story = new RSSStory("channel 2 story 1 title", "channel 2 story 1 description", "channel 2 story 1 link");
            channel.Stories.Add(story);

            story = new RSSStory("channel 2 story 2 title", "channel 2 story 2 description", "channel 2 story 2 link");
            channel.Stories.Add(story);

            channels.Add(channel);

        }
    }
}
