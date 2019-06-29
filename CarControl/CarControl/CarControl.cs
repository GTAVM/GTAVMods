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

            //Car Doors
            VehicleDoor Hood = VehicleDoor.Hood;
            VehicleDoor Trunk = VehicleDoor.Trunk;
            VehicleDoor FrontleftDoor = VehicleDoor.FrontLeftDoor;
            VehicleDoor FrontrightDoor = VehicleDoor.FrontRightDoor;
            VehicleDoor BackleftDoor = VehicleDoor.BackLeftDoor;
            VehicleDoor BackrightDoor = VehicleDoor.BackRightDoor;

            //Get current vehicle if the player it's on vehicle and get the last vehicle if not.
            Vehicle vehicle = player.IsInVehicle() ? player.CurrentVehicle : player.LastVehicle;
            
            //Open or close Hood
            if (hood)
            {
                if (vehicle.IsDoorOpen(Hood))
                    vehicle.CloseDoor(Hood, false);
                else
                    vehicle.OpenDoor(Hood, false, false);
            }

            //Open or close Trunk
            else if (trunk)
            {
                if (vehicle.IsDoorOpen(Trunk))
                    vehicle.CloseDoor(Trunk, false);
                else
                    vehicle.OpenDoor(Trunk, false, false);
            }

            //Open or close Front Left Door
            else if (frontLeftDoor)
            {
                if (vehicle.IsDoorOpen(FrontleftDoor))
                    vehicle.CloseDoor(FrontleftDoor, false);
                else
                    vehicle.OpenDoor(FrontleftDoor, false, false);
            }

            //Open or close front right door
            else if (frontRightDoor)
            {
                if (vehicle.IsDoorOpen(FrontrightDoor))
                    vehicle.CloseDoor(FrontrightDoor, false);
                else
                    vehicle.OpenDoor(FrontrightDoor, false, false);
            }
            //Open or close Back Left Door
            else if (backLeftDoor)
            {
                if (vehicle.IsDoorOpen(BackleftDoor))
                    vehicle.CloseDoor(BackleftDoor, false);
                else
                    vehicle.OpenDoor(BackleftDoor, false, false);
            }
            //Open or close Back Right door
            else if (backRightDoor)
            {
                if (vehicle.IsDoorOpen(BackrightDoor))
                    vehicle.CloseDoor(BackrightDoor, false);
                else
                    vehicle.OpenDoor(BackrightDoor, false, false);
            }
            //Start or Stop engine
            else if (engine)
                vehicle.EngineRunning = vehicle.EngineRunning == false;

            //Turn on Blinkers and interior light
            if (blinkersAndLight)
            {
                switch (e.KeyCode)
                {
                    //Left Blinker
                    case Keys.NumPad1 when leftblinker == false:
                        vehicle.RightIndicatorLightOn = false;
                        vehicle.LeftIndicatorLightOn = true;

                        leftblinker = true;
                        rightblinker = false;
                        break;
                    case Keys.NumPad1:
                        vehicle.RightIndicatorLightOn = false;
                        vehicle.LeftIndicatorLightOn = false;

                        leftblinker = false;
                        rightblinker = false;
                        break;
                    //Right Blinker
                    case Keys.NumPad3 when rightblinker == false:
                        vehicle.RightIndicatorLightOn = true;
                        vehicle.LeftIndicatorLightOn = false;

                        rightblinker = true;
                        leftblinker = false;
                        break;
                    //Emergency Lights
                    case Keys.NumPad3:
                        vehicle.RightIndicatorLightOn = false;
                        vehicle.LeftIndicatorLightOn = false;

                        rightblinker = false;
                        leftblinker = false;
                        break;
                    case Keys.NumPad2 when rightblinker == false || leftblinker == false:
                        vehicle.RightIndicatorLightOn = true;
                        vehicle.LeftIndicatorLightOn = true;

                        rightblinker = true;
                        leftblinker = true;
                        break;
                    //Interior lights
                    case Keys.NumPad2:
                        vehicle.RightIndicatorLightOn = false;
                        vehicle.LeftIndicatorLightOn = false;

                        rightblinker = false;
                        leftblinker = false;
                        break;
                    case Keys.Multiply when interiorlights == false:
                        vehicle.InteriorLightOn = true;

                        interiorlights = true;
                        UI.ShowSubtitle("interior light = On");
                        break;
                    case Keys.Multiply:
                        vehicle.InteriorLightOn = false;

                        interiorlights = false;
                        UI.ShowSubtitle("interior light = Off");
                        break;
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

            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                {
                    if (player.IsInVehicle())
                    {
                        vehicle = player.CurrentVehicle;
                        vehicle.RollDownWindow(VehicleWindow.FrontLeftWindow);
                    }

                    break;
                }

                case Keys.NumPad3:
                {
                    if (player.IsInVehicle())
                    {
                        vehicle = player.CurrentVehicle;
                        vehicle.RollDownWindow(VehicleWindow.FrontRightWindow);
                    }

                    break;
                }

                case Keys.NumPad4:
                {
                    if (player.IsInVehicle())
                    {
                        vehicle = player.CurrentVehicle;
                        vehicle.RollUpWindow(VehicleWindow.FrontLeftWindow);
                    }

                    break;
                }

                case Keys.NumPad6:
                {
                    if (player.IsInVehicle())
                    {
                        vehicle = player.CurrentVehicle;
                        vehicle.RollUpWindow(VehicleWindow.FrontRightWindow);
                    }

                    break;
                }
            }
        }
    }
}
