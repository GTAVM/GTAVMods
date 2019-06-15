using System;
using System.Drawing;
using System.Windows.Forms;
using GTA;
using GTA.Native;

namespace GTAVMods
{

	public class CreateHydra : Script
	{
		public CreateHydra()
		{

			//this.KeyUp += onKeyUp;

		}



		public static void Spawn()
		{
			//if (createHydra)
			//{
				Vehicle vehicle = World.CreateVehicle(VehicleHash.Hydra, Game.Player.Character.Position +
					Game.Player.Character.ForwardVector * 13.0f, Game.Player.Character.Heading + 90);
				vehicle.CanTiresBurst = false;
				//vehicle.CustomPrimaryColor = Color.FromArgb(38, 38, 38);
				//vehicle.CustomSecondaryColor = Color.DarkOrange;
				//vehicle.PlaceOnGround();
				//vehicle.NumberPlate = "CTOXYEB";
				vehicle.IsInvincible = true;

			//	createHydra = false;
			//}
		}
	}
}