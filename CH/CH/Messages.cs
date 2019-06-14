using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using GTA.Native;

namespace CH
{
    public class Messages
    {
        public static void NotifyToLoad(string modName) => UI.Notify("~b~~h~" + modName + "~h~~w~ - Loaded");

        public static void PrintText(string text, int time)
        {
            Function.Call(Hash._0xB87A37EEB7FAA67D, "STRING");
            Function.Call(Hash._ADD_TEXT_COMPONENT_STRING, text);
            Function.Call(Hash._0x9D77056A530643F6, time, 1);
        }
    }
}
