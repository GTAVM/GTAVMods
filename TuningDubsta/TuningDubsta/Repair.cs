using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;

namespace TuningDubsta
{
    class Repair : Script
    {
        int timeCount = 0;
        readonly int timeCountReset = 11;
        public static bool repairToggle;
        bool messageOn = false;

        public Repair()
        {
            Tick += OnTick;
            Interval = 1000;
        }

        internal static void VehicleRepairToggle(bool toggle)
        {
            repairToggle = toggle;
            Checks.IsPerformed(toggle, "Repair");
        }

        void OnTick(object sender, EventArgs e)
        {
            if (repairToggle)
            {
                Ped ped = Game.Player.Character;
                Vehicle vehicle = ped.CurrentVehicle;

                if (ped.IsInVehicle() && Checks.IsTuningDubsta())
                {
                    UI.Notify("Repair:~g~ On...");

                    if (vehicle.IsDamaged && !messageOn)
                    {
                        UI.Notify("Repair Message:\n~r~Vehicle damage repairing...");
                        timeCount = 0;
                        messageOn = true;
                    }

                    //UI.ShowSubtitle(timeCount.ToString());
                    if (timeCount == timeCountReset && vehicle.IsDamaged)
                    {
                        vehicle.Repair();
                        UI.Notify("Repair Message:\n~g~Vehicle repaired");
                        timeCount = 0;
                        messageOn = false;
                    }

                    if (timeCount == timeCountReset) timeCount = 0;

                    timeCount++;
                }
            }
        }
    }
}
