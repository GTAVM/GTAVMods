using GTA;
using System;
using System.Windows.Forms;

namespace CarControls
{
	class CarControl : Menu
	{
        public static bool leftblinker;
        public static bool rightblinker;
        public static bool interiorlights;

        public CarControl() => KeyDown += CarControl_KeyDown;
		
        private void CarControl_KeyDown(object sender, KeyEventArgs e)
		{
            Ped player = Game.Player.Character;

            //Get current vehicle if the player it's on vehicle and get the last vehicle if not.
            Vehicle vehicle = null;

            vehicle = player.IsInVehicle() ? player.CurrentVehicle : player.LastVehicle;

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

                if (vehicle.IsDoorOpen(Hood) == true)
                {

                    vehicle.CloseDoor(Hood, false);

                }
                else
                {

                    vehicle.OpenDoor(Hood, false, false);

                }

                //hood = false;

            }

            //Open or close Trunk
            //else if (e.KeyCode == Keys.NumPad5)
            else if (trunk)
            {

                if (vehicle.IsDoorOpen(Trunk) == true)
                {

                    vehicle.CloseDoor(Trunk, false);

                }
                else
                {
                    vehicle.OpenDoor(Trunk, false, false);

                }


            }

            //Open or close Front Left Door
            //else if (e.KeyCode == Keys.NumPad4)
            else if (frontLeftDoor)
            {

                if (vehicle.IsDoorOpen(FrontleftDoor))
                {

                    vehicle.CloseDoor(FrontleftDoor, false);

                }
                else
                {
                    vehicle.OpenDoor(FrontleftDoor, false, false);

                }

            }

            //Open or close front right door
            //else if (e.KeyCode == Keys.NumPad6)
            else if (frontRightDoor)
            {

                if (vehicle.IsDoorOpen(FrontrightDoor))
                {

                    vehicle.CloseDoor(FrontrightDoor, false);

                }
                else
                {
                    vehicle.OpenDoor(FrontrightDoor, false, false);

                }
            }
            //Open or close Back Left Door
            //else if (e.KeyCode == Keys.NumPad7)
            else if (backLeftDoor)
            {

                if (vehicle.IsDoorOpen(BackleftDoor))
                {

                    vehicle.CloseDoor(BackleftDoor, false);

                }
                else
                {
                    vehicle.OpenDoor(BackleftDoor, false, false);

                }
            }
            //Open or close Back Right door
            //else if (e.KeyCode == Keys.NumPad9)
            else if (backRightDoor)
            {

                if (vehicle.IsDoorOpen(BackrightDoor))
                {

                    vehicle.CloseDoor(BackrightDoor, false);

                }
                else
                {
                    vehicle.OpenDoor(BackrightDoor, false, false);

                }
            }
            //Start or Stop engine
            //else if (e.KeyCode == Keys.NumPad0)
            else if (engine)

            {

                if (vehicle.EngineRunning == false)
                {

                    vehicle.EngineRunning = true;

                }
                else
                {

                    vehicle.EngineRunning = false;

                }

            }

            //Turn on Blinkers and interior light
            if (blinkersAndLight)
            {
                if (player.IsInVehicle())
                {

                    vehicle = player.CurrentVehicle;

                }
                else
                {

                    vehicle = player.LastVehicle;

                }

                //Left Blinker

                if (e.KeyCode == Keys.NumPad1)
                {

                    if (leftblinker == false)
                    {

                        vehicle.RightIndicatorLightOn = false;
                        vehicle.LeftIndicatorLightOn = true;

                        leftblinker = true;
                        rightblinker = false;

                    }
                    else
                    {

                        vehicle.RightIndicatorLightOn = false;
                        vehicle.LeftIndicatorLightOn = false;

                        leftblinker = false;
                        rightblinker = false;

                    }

                }

                //Right Blinker

                if (e.KeyCode == Keys.NumPad3)
                {

                    if (rightblinker == false)
                    {

                        vehicle.RightIndicatorLightOn = true;
                        vehicle.LeftIndicatorLightOn = false;

                        rightblinker = true;
                        leftblinker = false;

                    }
                    else
                    {
                        vehicle.RightIndicatorLightOn = false;
                        vehicle.LeftIndicatorLightOn = false;

                        rightblinker = false;
                        leftblinker = false;
                    }
                }
                //Emergency Lights
                else if (e.KeyCode == Keys.NumPad2)
                {
                    if (rightblinker == false || leftblinker == false)
                    {
                        vehicle.RightIndicatorLightOn = true;
                        vehicle.LeftIndicatorLightOn = true;

                        rightblinker = true;
                        leftblinker = true;
                    }
                    else
                    {
                        vehicle.RightIndicatorLightOn = false;
                        vehicle.LeftIndicatorLightOn = false;

                        rightblinker = false;
                        leftblinker = false;
                    }
                }
                //Interior lights
                else if (e.KeyCode == Keys.Multiply)
                {

                    if (interiorlights == false)
                    {

                        vehicle.InteriorLightOn = true;

                        interiorlights = true;
                        UI.ShowSubtitle("interior light = On");
                    }
                    else
                    {

                        vehicle.InteriorLightOn = false;

                        interiorlights = false;
                        UI.ShowSubtitle("interior light = Off");
                    }

                }
            }
            if (neonLights)
            {
                if (!(vehicle.IsNeonLightsOn(VehicleNeonLight.Back) || vehicle.IsNeonLightsOn(VehicleNeonLight.Front) || vehicle.IsNeonLightsOn(VehicleNeonLight.Left) || vehicle.IsNeonLightsOn(VehicleNeonLight.Right)))
                {

                    vehicle.SetNeonLightsOn(VehicleNeonLight.Back, true);
                    vehicle.SetNeonLightsOn(VehicleNeonLight.Front, true);
                    vehicle.SetNeonLightsOn(VehicleNeonLight.Left, true);
                    vehicle.SetNeonLightsOn(VehicleNeonLight.Right, true);

                }
                else
                {

                    vehicle.SetNeonLightsOn(VehicleNeonLight.Back, false);
                    vehicle.SetNeonLightsOn(VehicleNeonLight.Front, false);
                    vehicle.SetNeonLightsOn(VehicleNeonLight.Left, false);
                    vehicle.SetNeonLightsOn(VehicleNeonLight.Right, false);

                }
            }

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

		

		public void DoorControlEventKeys(object sender, KeyEventArgs e)
		{

			//Ped player = Game.Player.Character;

			////Get current vehicle if the player it's on vehicle and get the last vehicle if not.

			//Vehicle v = null;

			//if (player.IsInVehicle())
			//{

			//	v = player.CurrentVehicle;

			//}
			//else
			//{

			//	v = player.LastVehicle;

			//}

			////Car Doors

			//VehicleDoor Hood = VehicleDoor.Hood;
			//VehicleDoor Trunk = VehicleDoor.Trunk;
			//VehicleDoor FrontleftDoor = VehicleDoor.FrontLeftDoor;
			//VehicleDoor FrontrightDoor = VehicleDoor.FrontRightDoor;
			//VehicleDoor BackleftDoor = VehicleDoor.BackLeftDoor;
			//VehicleDoor BackrightDoor = VehicleDoor.BackRightDoor;

			////Open or close Hood

			////if (e.KeyCode == Keys.NumPad8)
			//if (hood)
			//{

			//	if (v.IsDoorOpen(Hood) == true)
			//	{

			//		v.CloseDoor(Hood, false);

			//	}
			//	else
			//	{

			//		v.OpenDoor(Hood, false, false);

			//	}

			//	//hood = false;

			//}

			////Open or close Trunk
			////else if (e.KeyCode == Keys.NumPad5)
			//else if (trunk)
			//{

			//	if (v.IsDoorOpen(Trunk) == true)
			//	{

			//		v.CloseDoor(Trunk, false);

			//	}
			//	else
			//	{
			//		v.OpenDoor(Trunk, false, false);

			//	}


			//}

			////Open or close Front Left Door
			////else if (e.KeyCode == Keys.NumPad4)
			//else if (frontLeftDoor)
			//{

			//	if (v.IsDoorOpen(FrontleftDoor))
			//	{

			//		v.CloseDoor(FrontleftDoor, false);

			//	}
			//	else
			//	{
			//		v.OpenDoor(FrontleftDoor, false, false);

			//	}

			//}

			////Open or close front right door
			////else if (e.KeyCode == Keys.NumPad6)
			//else if (frontRightDoor)
			//{

			//	if (v.IsDoorOpen(FrontrightDoor))
			//	{

			//		v.CloseDoor(FrontrightDoor, false);

			//	}
			//	else
			//	{
			//		v.OpenDoor(FrontrightDoor, false, false);

			//	}
			//}
			////Open or close Back Left Door
			////else if (e.KeyCode == Keys.NumPad7)
			//else if (backLeftDoor)
			//{

			//	if (v.IsDoorOpen(BackleftDoor))
			//	{

			//		v.CloseDoor(BackleftDoor, false);

			//	}
			//	else
			//	{
			//		v.OpenDoor(BackleftDoor, false, false);

			//	}
			//}
			////Open or close Back Right door
			////else if (e.KeyCode == Keys.NumPad9)
			//else if (backRightDoor)
			//{

			//	if (v.IsDoorOpen(BackrightDoor))
			//	{

			//		v.CloseDoor(BackrightDoor, false);

			//	}
			//	else
			//	{
			//		v.OpenDoor(BackrightDoor, false, false);

			//	}
			//}
			////Start or Stop engine
			////else if (e.KeyCode == Keys.NumPad0)
			//else if (engine)

			//{

			//	if (v.EngineRunning == false)
			//	{

			//		v.EngineRunning = true;

			//	}
			//	else
			//	{

			//		v.EngineRunning = false;

			//	}

			//}


		}

		//Turn on Blinkers and interior light

		//public void Blinkers(object sender, KeyEventArgs e)
		//{

		//	if (blinkersAndLight)
		//	{
		//		//Player and current vehicle
		//		Ped player = Game.Player.Character;

		//		//Get current vehicle if the player it's on vehicle and get the last vehicle if not.

		//		Vehicle v = null;

		//		if (player.IsInVehicle())
		//		{

		//			v = player.CurrentVehicle;

		//		}
		//		else
		//		{

		//			v = player.LastVehicle;

		//		}

		//		//Left Blinker

		//		if (e.KeyCode == Keys.NumPad1)
		//		{

		//			if (leftblinker == false)
		//			{

		//				v.RightIndicatorLightOn = false;
		//				v.LeftIndicatorLightOn = true;

		//				leftblinker = true;
		//				rightblinker = false;

		//			}
		//			else
		//			{

		//				v.RightIndicatorLightOn = false;
		//				v.LeftIndicatorLightOn = false;

		//				leftblinker = false;
		//				rightblinker = false;

		//			}

		//		}

		//		//Right Blinker

		//		if (e.KeyCode == Keys.NumPad3)
		//		{

		//			if (rightblinker == false)
		//			{

		//				v.RightIndicatorLightOn = true;
		//				v.LeftIndicatorLightOn = false;

		//				rightblinker = true;
		//				leftblinker = false;

		//			}
		//			else
		//			{

		//				v.RightIndicatorLightOn = false;
		//				v.LeftIndicatorLightOn = false;

		//				rightblinker = false;
		//				leftblinker = false;

		//			}


		//			//Emergency Lights

		//		}
		//		else if (e.KeyCode == Keys.NumPad2)
		//		{

		//			if (rightblinker == false || leftblinker == false)
		//			{

		//				v.RightIndicatorLightOn = true;
		//				v.LeftIndicatorLightOn = true;

		//				rightblinker = true;
		//				leftblinker = true;

		//			}
		//			else
		//			{

		//				v.RightIndicatorLightOn = false;
		//				v.LeftIndicatorLightOn = false;

		//				rightblinker = false;
		//				leftblinker = false;

		//			}



		//		}
		//		//Interior lights
		//		else if (e.KeyCode == Keys.Multiply)
		//		{

		//			if (interiorlights == false)
		//			{

		//				v.InteriorLightOn = true;

		//				interiorlights = true;
		//				UI.ShowSubtitle("interior light = On");
		//			}
		//			else
		//			{

		//				v.InteriorLightOn = false;

		//				interiorlights = false;
		//				UI.ShowSubtitle("interior light = Off");
		//			}

		//		}
		//	}
		//	if (neonLights)
		//	{
		//		Vehicle v = Game.Player.Character.CurrentVehicle;

		//		if (!(v.IsNeonLightsOn(VehicleNeonLight.Back) || v.IsNeonLightsOn(VehicleNeonLight.Front) || v.IsNeonLightsOn(VehicleNeonLight.Left) || v.IsNeonLightsOn(VehicleNeonLight.Right)))
		//		{

		//			v.SetNeonLightsOn(VehicleNeonLight.Back, true);
		//			v.SetNeonLightsOn(VehicleNeonLight.Front, true);
		//			v.SetNeonLightsOn(VehicleNeonLight.Left, true);
		//			v.SetNeonLightsOn(VehicleNeonLight.Right, true);

		//		}
		//		else
		//		{

		//			v.SetNeonLightsOn(VehicleNeonLight.Back, false);
		//			v.SetNeonLightsOn(VehicleNeonLight.Front, false);
		//			v.SetNeonLightsOn(VehicleNeonLight.Left, false);
		//			v.SetNeonLightsOn(VehicleNeonLight.Right, false);

		//		}
		//	}
		//}
	}
}
