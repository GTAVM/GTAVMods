using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GTA;
using GTA.Math;
using GTA.Native;

namespace GTAVMods
{

	class DriverInCar : Script
	{
		public DriverInCar()
		{
			//KeyDown += My_KeyDown;
		}

		public static void Spawn()
		{
			//if (driverInCar)
			//{
				Vector3 playerPos = Game.Player.Character.Position;
				playerPos = playerPos + Game.Player.Character.ForwardVector * 5;

				Vehicle myCar =
					World.CreateVehicle(VehicleHash.Banshee, playerPos);

				Ped driver =
					myCar.CreateRandomPedOnSeat(VehicleSeat.Driver);

				driver.Task.DriveTo(myCar, driver.ForwardVector * 100, 1, 100);

				string mess = "Координаты = " + playerPos.ToString();
				UI.Notify(mess);

			//	driverInCar = false;

			//}
		}
	}
}
