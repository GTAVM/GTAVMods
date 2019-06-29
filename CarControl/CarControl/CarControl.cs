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
