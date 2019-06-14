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
    public class HVehicles /*: Script*/
    {
        static readonly int drivingstyle = (int)DrivingStyle.SometimesOvertakeTraffic;
        static readonly float speed = 40f;

        static Ped player = Game.Player.Character;

        public static void DriveToWapointPosition(bool toggle)
        {
            if (player.IsInVehicle() && toggle)
            {
                Vehicle currentVehicle = player.CurrentVehicle;
                player.Task.DriveTo(currentVehicle, World.GetWaypointPosition(), 0f, speed, drivingstyle);
            }
            else
            {
                player.Task.ClearAll();
            }
        }

        public static void CruiseWithVehicle(bool toggle)
        {
            if (player.IsInVehicle() && toggle)
            {
                Vehicle currentVehicle = player.CurrentVehicle;
                player.Task.CruiseWithVehicle(currentVehicle, speed, drivingstyle);
            }
            else
            {
                player.Task.ClearAll();
            }
        }

        public static void VehicleSpawnByName()
        {
            Ped gamePed = Game.Player.Character;

            string modelName = Game.GetUserInput(50);
            Model model = new Model(modelName);
            model.Request();

            if (model.IsInCdImage && model.IsValid)
            {
                Vehicle v = World.CreateVehicle(model, gamePed.Position, gamePed.Heading);
                v.PlaceOnGround();
                gamePed.Task.WarpIntoVehicle(v, VehicleSeat.Driver);
            }
        }

        public static void VehicleInfo()
        {
            Ped player = Game.Player.Character;
            if (player.IsInVehicle())
            {
                Vehicle vehicle = player.CurrentVehicle;
                UI.Notify("ClassType: " + vehicle.ClassType.ToString());
                UI.Notify("DisplayName: " + vehicle.DisplayName.ToString());
                UI.Notify("FriendlyName: " + vehicle.FriendlyName);
                UI.ShowSubtitle("Acceleration: " + vehicle.Acceleration.ToString() +
                                "\nBodyHealth: " + vehicle.BodyHealth.ToString() +
                                "\nCurrentGear: " + vehicle.CurrentGear.ToString() +
                                "\nHighGear: " + vehicle.HighGear.ToString() +
                                "\nCurrentRPM: " + vehicle.CurrentRPM.ToString() +
                                "\nForwardVector\n" + vehicle.ForwardVector.ToString() +
                                "\nFuelLevel: " + vehicle.FuelLevel.ToString());
            }
        }

        public static void CreateVehicle(VehicleHash vehicleHash)
        {
            World.CreateVehicle(vehicleHash,
                    Game.Player.Character.Position + (Game.Player.Character.ForwardVector * 5));
        }

        static int count = -1;
        static Vehicle vehicle = null;
        public static void AllVehicles(bool revers = false)
        {
            VehicleHash[] allVehicleHash = (VehicleHash[])Enum.GetValues(typeof(VehicleHash));

            if (revers)
            {
                if (count <= 0) count = allVehicleHash.Length - 1;
                else count--;
            }
            else if (count == -1 || count > allVehicleHash.Length - 2) count = 0;
            else count++;

            if (vehicle != null)
            {
                vehicle.MarkAsNoLongerNeeded();
                vehicle.Delete();
            }

            vehicle = World.CreateVehicle(allVehicleHash[count],
                  Game.Player.Character.Position + (Game.Player.Character.ForwardVector * 15));

            if (vehicle.ClassType == VehicleClass.OffRoad)
            {
                UI.Notify(vehicle.ClassType.ToString());
            }

            UI.ShowSubtitle(allVehicleHash[count].ToString() + $": № {count} / " + (allVehicleHash.Length - 1).ToString(),
                10000);
        }

        //static int forwardVector = 15;
        //public static void AllVehiclesOffFoad()
        //{
        //    VehicleHash[] allVehicleHash = (VehicleHash[])Enum.GetValues(typeof(VehicleHash));
        //    Vehicle[] vehicles = new Vehicle[allVehicleHash.Length];
        //    Vehicle vehicle;
        //    int countOffRoad = 0;

        //    for (int i = 0; i < allVehicleHash.Length; i++)
        //    {
        //        vehicle = World.CreateVehicle(allVehicleHash[i],
        //              Game.Player.Character.Position + (Game.Player.Character.ForwardVector * forwardVector));

        //        //if (vehicle.ClassType == VehicleClass.OffRoad)
        //        //{
        //        //    vehicle.AddBlip().Color = BlipColor.Red;
        //        //    countOffRoad++;
        //        //    forwardVector += 10;

        //        //    UI.Notify("ColOffRoad = " + countOffRoad.ToString());
        //        //}
        //        //else
        //        //{
        //        vehicle.Delete();
        //        //}

        //        UI.ShowSubtitle(allVehicleHash[i].ToString() + $": № {i} / " + (allVehicleHash.Length - 1).ToString(),
        //                10000);
        //        //Wait(0);
        //    }
        //}
    }
}
