using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin.NewsReader
{
    public class Plugin : IPlugin
    {
        public string Name => "News Reader";

        public string Description => "Plugin to read RSS news";

        public string Cover => "Res\\cover.png";
    }
}
