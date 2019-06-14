using GTA;
using GTA.Math;
using GTA.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH
{
    public  class HWorld : Script
    {
        private static double waves = 0;

        public static void IncreaseWaves(double increase = 50)
        {
            waves += increase;
            Function.Call((Hash)0xB96B00E976BE977F, waves);
            UI.ShowSubtitle("Increase Waves = ~r~" + waves, 3000);
        }

        public static void ReduceWaves(double reduce = 50)
        {
            waves -= reduce;
            Function.Call((Hash)0xB96B00E976BE977F, waves);
            UI.ShowSubtitle("Reduce Waves = ~b~" + waves, 3000);
        }
    }
}
