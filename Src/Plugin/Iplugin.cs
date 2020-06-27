using System;
using System.Collections.Generic;
using System.Text;

namespace Plugin
{
    public interface Iplugin
    {
        string Name { get; }

        string Description { get; }

        string Cover { get; }
    }
}
