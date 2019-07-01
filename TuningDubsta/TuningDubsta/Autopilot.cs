using CH;
using GTA;
using System;
using GTA.Math;

namespace TuningDubsta
{
    class Autopilot : Script
    {
        static bool _toggleDriveTo;
        static bool _isParking;
        static Vehicle _vehicle;
        static bool _onTheHandbrake;
        static bool _toggleCruise;

        public Autopilot()
        {
            SetDefault();

            Tick += OnTick;
            Interval = 1000;
        }

        static void SetDefault()
        {
            if (Game.Player.Character.IsInVehicle())
            {
                _vehicle = Game.Player.Character.CurrentVehicle;
                _vehicle.HandbrakeOn = false;
                _onTheHandbrake = false;
            }
        }

        void OnTick(object sender, EventArgs e)
        {
            if (_toggleCruise && Checks.IsTuningDubsta()) UI.Notify("Cruise:~g~ On...");

            if (_onTheHandbrake) UI.ShowSubtitle("~g~Waypoint position is reached\n" +
                                                "~r~~h~>>!<<~h~~y~ The car is on the handbrake ~r~~h~>>!<<\n" +
                "~h~~w~Turn off the 'Drive to' to remove from the parking brake", 1000);

            if (_toggleDriveTo && Checks.IsTuningDubsta())
            {
                UI.Notify("Drive to:~g~ On...");
            }
            if (!Game.IsWaypointActive &&_isParking)
            {
                Game.Player.Character.Task.ClearAll();
                _vehicle.HandbrakeOn = true;
                _onTheHandbrake = true;
                _isParking = false;
                //_toggleDriveTo = false;
                UI.Notify("Arrived");
            }
        }

        internal static void Cruise(bool toggle)
        {
            _toggleCruise = toggle;
            bool startIfOkey = Checks.IsPerformed(toggle, "Cruise");
            HVehicles.CruiseWithVehicle(startIfOkey);
        }

        internal static void DriveTo(bool toggle)
        {
            SetDefault();

            bool startIfOkey = Checks.IsPerformed(toggle, "Drive to");

            if (startIfOkey)
            {
                if (Game.IsWaypointActive)
                {
                    HVehicles.DriveToWapointPosition(startIfOkey);
                    _isParking = true;
                    _toggleDriveTo = toggle;

                }
                else if (toggle && !Game.IsWaypointActive)
                {
                    UI.Notify("Enter waypoint");
                }
            }
            else if (!toggle)
            {
                _toggleDriveTo = toggle;
                Game.Player.Character.Task.ClearAll();
            }
        }
    }
}
