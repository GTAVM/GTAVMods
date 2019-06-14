using GTA;
using System;
using System.Windows.Forms;

namespace CarControls
{
	class CarControl : Menu
	{

		public CarControl()
		{
			KeyUp += DoorControlEventKeys;

			KeyUp += Blinkers;

			KeyDown += CarControl_KeyDown;
		}

		private void CarControl_KeyDown(object sender, KeyEventArgs e)
		{
			Ped player = Game.Player.Character;
			Vehicle vehicle = null;
			if (e.KeyCode == Keys.NumPad1)
			{
				if (player.IsInVehicle())
				{
					vehicle = player.CurrentVehicle;
					vehicle.RollDownWindow(VehicleWindow.FrontLeftWindow);
				}
			}
			if (e.KeyCode == Keys.NumPad3)
			{
				if (player.IsInVehicle())
				{
					vehicle = player.CurrentVehicle;
					vehicle.RollDownWindow(VehicleWindow.FrontRightWindow);
				}
			}
			if (e.KeyCode == Keys.NumPad4)
			{
				if (player.IsInVehicle())
				{
					vehicle = player.CurrentVehicle;
					vehicle.RollUpWindow(VehicleWindow.FrontLeftWindow);
				}
			}
			if (e.KeyCode == Keys.NumPad6)
			{
				if (player.IsInVehicle())
				{
					vehicle = player.CurrentVehicle;
					vehicle.RollUpWindow(VehicleWindow.FrontRightWindow);
				}
			}
		}

		//Vehicle v = Game.Player.Character.CurrentVehicle;

		//Emergency Lights = 2 booleans true

		//Left blinker
		public static Boolean leftblinker = false;

		//Right blinker
		public static Boolean rightblinker = false;

		//Interior light

		public static Boolean interiorlights = false;

		public void DoorControlEventKeys(object sender, KeyEventArgs e)
		{

			Ped player = Game.Player.Character;

			//Get current vehicle if the player it's on vehicle and get the last vehicle if not.

			Vehicle v = null;

			if (player.IsInVehicle())
			{

				v = player.CurrentVehicle;

			}
			else
			{

				v = player.LastVehicle;

			}

			//Car Doors

			VehicleDoor Hood = VehicleDoor.Hood;
			VehicleDoor Trunk = VehicleDoor.Trunk;
			VehicleDoor FrontleftDoor = VehicleDoor.FrontLeftDoor;
			VehicleDoor FrontrightDoor = VehicleDoor.FrontRightDoor;
			VehicleDoor BackleftDoor = VehicleDoor.BackLeftDoor;
			VehicleDoor BackrightDoor = VehicleDoor.BackRightDoor;

			//Open or close Hood

			//if (e.KeyCode == Keys.NumPad8)
			if (hood)
			{

				if (v.IsDoorOpen(Hood) == true)
				{

					v.CloseDoor(Hood, false);

				}
				else
				{

					v.OpenDoor(Hood, false, false);

				}

				//hood = false;

			}

			//Open or close Trunk
			//else if (e.KeyCode == Keys.NumPad5)
			else if (trunk)
			{

				if (v.IsDoorOpen(Trunk) == true)
				{

					v.CloseDoor(Trunk, false);

				}
				else
				{
					v.OpenDoor(Trunk, false, false);

				}


			}

			//Open or close Front Left Door
			//else if (e.KeyCode == Keys.NumPad4)
			else if (frontLeftDoor)
			{

				if (v.IsDoorOpen(FrontleftDoor))
				{

					v.CloseDoor(FrontleftDoor, false);

				}
				else
				{
					v.OpenDoor(FrontleftDoor, false, false);

				}

			}

			//Open or close front right door
			//else if (e.KeyCode == Keys.NumPad6)
			else if (frontRightDoor)
			{

				if (v.IsDoorOpen(FrontrightDoor))
				{

					v.CloseDoor(FrontrightDoor, false);

				}
				else
				{
					v.OpenDoor(FrontrightDoor, false, false);

				}
			}
			//Open or close Back Left Door
			//else if (e.KeyCode == Keys.NumPad7)
			else if (backLeftDoor)
			{

				if (v.IsDoorOpen(BackleftDoor))
				{

					v.CloseDoor(BackleftDoor, false);

				}
				else
				{
					v.OpenDoor(BackleftDoor, false, false);

				}
			}
			//Open or close Back Right door
			//else if (e.KeyCode == Keys.NumPad9)
			else if (backRightDoor)
			{

				if (v.IsDoorOpen(BackrightDoor))
				{

					v.CloseDoor(BackrightDoor, false);

				}
				else
				{
					v.OpenDoor(BackrightDoor, false, false);

				}
			}
			//Start or Stop engine
			//else if (e.KeyCode == Keys.NumPad0)
			else if (engine)

			{

				if (v.EngineRunning == false)
				{

					v.EngineRunning = true;

				}
				else
				{

					v.EngineRunning = false;

				}

			}


		}

		//Turn on Blinkers and interior light

		public void Blinkers(object sender, KeyEventArgs e)
		{

			if (blinkersAndLight)
			{
				//Player and current vehicle
				Ped player = Game.Player.Character;

				//Get current vehicle if the player it's on vehicle and get the last vehicle if not.

				Vehicle v = null;

				if (player.IsInVehicle())
				{

					v = player.CurrentVehicle;

				}
				else
				{

					v = player.LastVehicle;

				}

				//Left Blinker

				if (e.KeyCode == Keys.NumPad1)
				{

					if (leftblinker == false)
					{

						v.RightIndicatorLightOn = false;
						v.LeftIndicatorLightOn = true;

						leftblinker = true;
						rightblinker = false;

					}
					else
					{

						v.RightIndicatorLightOn = false;
						v.LeftIndicatorLightOn = false;

						leftblinker = false;
						rightblinker = false;

					}

				}

				//Right Blinker

				if (e.KeyCode == Keys.NumPad3)
				{

					if (rightblinker == false)
					{

						v.RightIndicatorLightOn = true;
						v.LeftIndicatorLightOn = false;

						rightblinker = true;
						leftblinker = false;

					}
					else
					{

						v.RightIndicatorLightOn = false;
						v.LeftIndicatorLightOn = false;

						rightblinker = false;
						leftblinker = false;

					}


					//Emergency Lights

				}
				else if (e.KeyCode == Keys.NumPad2)
				{

					if (rightblinker == false || leftblinker == false)
					{

						v.RightIndicatorLightOn = true;
						v.LeftIndicatorLightOn = true;

						rightblinker = true;
						leftblinker = true;

					}
					else
					{

						v.RightIndicatorLightOn = false;
						v.LeftIndicatorLightOn = false;

						rightblinker = false;
						leftblinker = false;

					}



				}
				//Interior lights
				else if (e.KeyCode == Keys.Multiply)
				{

					if (interiorlights == false)
					{

						v.InteriorLightOn = true;

						interiorlights = true;
						UI.ShowSubtitle("interior light = On");
					}
					else
					{

						v.InteriorLightOn = false;

						interiorlights = false;
						UI.ShowSubtitle("interior light = Off");
					}

				}
			}
			if (neonLights)
			{
				Vehicle v = Game.Player.Character.CurrentVehicle;

				if (!(v.IsNeonLightsOn(VehicleNeonLight.Back) || v.IsNeonLightsOn(VehicleNeonLight.Front) || v.IsNeonLightsOn(VehicleNeonLight.Left) || v.IsNeonLightsOn(VehicleNeonLight.Right)))
				{

					v.SetNeonLightsOn(VehicleNeonLight.Back, true);
					v.SetNeonLightsOn(VehicleNeonLight.Front, true);
					v.SetNeonLightsOn(VehicleNeonLight.Left, true);
					v.SetNeonLightsOn(VehicleNeonLight.Right, true);

				}
				else
				{

					v.SetNeonLightsOn(VehicleNeonLight.Back, false);
					v.SetNeonLightsOn(VehicleNeonLight.Front, false);
					v.SetNeonLightsOn(VehicleNeonLight.Left, false);
					v.SetNeonLightsOn(VehicleNeonLight.Right, false);

				}
			}
			if (flyThroughWindscreen)
			{
				Vehicle v = Game.Player.Character.CurrentVehicle;
				if (v.Driver.CanFlyThroughWindscreen == false)
				{

					v.Driver.CanFlyThroughWindscreen = true;
					UI.Notify("CanFlyThroughWindscreen = true");
					UI.ShowSubtitle("Не пристёгнут");

				}
				else if (v.Driver.CanFlyThroughWindscreen == true)
				{

					v.Driver.CanFlyThroughWindscreen = false;
					UI.Notify("CanFlyThroughWindscreen = false");
					UI.ShowSubtitle("Пристёгнут");

				}



			}
		}

	}
}
