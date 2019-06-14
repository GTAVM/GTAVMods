using System;
using System.Drawing;
using CH;
using GTA;
using GTA.Native;

namespace TuningDubsta
{
	public class TuningDubsta
    {
        static Vehicle vehicle;
        public static string NumberPlate { get; private set; } = "CTOXYEB";

        internal static void Spawn()
		{
            if (vehicle != null) vehicle.MarkAsNoLongerNeeded();

			 vehicle = World.CreateVehicle(VehicleHash.Dubsta3, Game.Player.Character.Position +
				Game.Player.Character.ForwardVector * 4.0f, Game.Player.Character.Heading + 90);

			//vehicle.DirtLevel = 15f;//15
			//vehicle.CustomPrimaryColor = Color.White;
			vehicle.CanTiresBurst = false;
			vehicle.WindowTint = VehicleWindowTint.PureBlack;//тонировка в хлам
			vehicle.CustomPrimaryColor = Color.FromArgb(38, 38, 38);
			vehicle.CustomSecondaryColor = Color.Black;
			vehicle.PlaceOnGround();
            vehicle.NumberPlate = NumberPlate;
            vehicle.IsInvincible = true;
			
			//neon
			vehicle.SetNeonLightsOn(VehicleNeonLight.Front, true);
			vehicle.SetNeonLightsOn(VehicleNeonLight.Back, true);
			vehicle.SetNeonLightsOn(VehicleNeonLight.Right, true);
			vehicle.SetNeonLightsOn(VehicleNeonLight.Left, true);

			// Set the vehicle mods
			Function.Call(Hash.SET_VEHICLE_MOD_KIT, vehicle.Handle, 0);
			vehicle.SetMod(VehicleMod.Aerials, 0, true);
			vehicle.SetMod(VehicleMod.AirFilter, 0, true);
			vehicle.SetMod(VehicleMod.ArchCover, 0, true);
			vehicle.SetMod(VehicleMod.Armor, 4, true); //4
			vehicle.SetMod(VehicleMod.BackWheels, 0, true);
			vehicle.SetMod(VehicleMod.Brakes, 2, true); //2
			vehicle.SetMod(VehicleMod.ColumnShifterLevers, 0, true);
			vehicle.SetMod(VehicleMod.Dashboard, 0, true);
			vehicle.SetMod(VehicleMod.DialDesign, 0, true);
			vehicle.SetMod(VehicleMod.DoorSpeakers, 0, true);
			vehicle.SetMod(VehicleMod.Engine, 3, true); //3
			vehicle.SetMod(VehicleMod.EngineBlock, 0, true);
			vehicle.SetMod(VehicleMod.Exhaust, 1, true); //глушитель max 1
			vehicle.SetMod(VehicleMod.Fender, 0, true);
			vehicle.SetMod(VehicleMod.Frame, 0, true);
			vehicle.SetMod(VehicleMod.FrontBumper, 5, true); // max 5
			vehicle.SetMod(VehicleMod.FrontWheels, 0, true);
			vehicle.SetMod(VehicleMod.Grille, 0, true);
			vehicle.SetMod(VehicleMod.Hood, 0, true); //1
			vehicle.SetMod(VehicleMod.Horns, 0, true);
			vehicle.SetMod(VehicleMod.Hydraulics, 0, true);
			vehicle.SetMod(VehicleMod.Livery, 0, true);
			vehicle.SetMod(VehicleMod.Ornaments, 0, true);
			vehicle.SetMod(VehicleMod.Plaques, 0, true);
			vehicle.SetMod(VehicleMod.PlateHolder, 0, true);
			vehicle.SetMod(VehicleMod.RearBumper, 1, true); //1
			vehicle.SetMod(VehicleMod.RightFender, 0, true);
			vehicle.SetMod(VehicleMod.Roof, 3, true); //3
			vehicle.SetMod(VehicleMod.Seats, 0, true);
			vehicle.SetMod(VehicleMod.SideSkirt, 0, true);
			vehicle.SetMod(VehicleMod.Speakers, 0, true);
			vehicle.SetMod(VehicleMod.Spoilers, 0, true); //0
			vehicle.SetMod(VehicleMod.SteeringWheels, 0, true);
			vehicle.SetMod(VehicleMod.Struts, 0, true);
			vehicle.SetMod(VehicleMod.Suspension, 0, true);
			vehicle.SetMod(VehicleMod.Tank, 0, true);
			vehicle.SetMod(VehicleMod.Transmission, 2, true); //2
			vehicle.SetMod(VehicleMod.Trim, 0, true);
			vehicle.SetMod(VehicleMod.TrimDesign, 0, true);
			vehicle.SetMod(VehicleMod.Trunk, 0, true);
			vehicle.SetMod(VehicleMod.VanityPlates, 0, true);
			vehicle.SetMod(VehicleMod.Windows, 2, true); //2

            Messages.PrintText("Spawned: ~b~TuningDubsta\n" +
                "~w~Class:~b~ "+vehicle.ClassType, 10000);
		}
	}
}
