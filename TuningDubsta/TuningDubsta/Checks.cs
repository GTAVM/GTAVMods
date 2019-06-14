using GTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuningDubsta
{
    class Checks : Script
    {
        internal static bool IsPerformed(bool toggle, string methodName)
        {
            if (Game.Player.Character.IsInVehicle())
            {
                if (!toggle && IsTuningDubsta())
                {
                    UI.Notify(methodName + ":~r~ Off");
                    return false;
                }
                if (toggle && !IsTuningDubsta())
                {
                    UI.Notify("~y~" + methodName + " works only in TuningDubsta");
                    return false;
                }
                if (IsTuningDubsta()) return true;
            }
            else if (toggle)
            {
                UI.Notify("~y~You need get TuningDubsta");
                return false;
            }
            return false;
        }

        internal static bool IsTuningDubsta()
        {
            Ped ped = Game.Player.Character;
            Vehicle vehicle = ped.CurrentVehicle;

            string s1 = vehicle.NumberPlate;
            string s2 = TuningDubsta.NumberPlate;

            int result = string.Compare(s1, s2);

            if (result == 1) return true;
            return false;
        }
    }
}
