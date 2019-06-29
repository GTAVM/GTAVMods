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

        private bool _frontLeftWindowUp;
        private bool _frontRightWindowUp;
        private bool _backLeftWindowUp;
        private bool _backRightWindowUp;
        private bool _allWindowsUp;

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

            if (!powerWindowsControl) return;

            switch (e.KeyCode)
            {
                case Keys.NumPad4 when _frontLeftWindowUp == false:
                    vehicle.RollDownWindow(VehicleWindow.FrontLeftWindow);

                    _frontLeftWindowUp = true;
                    break;

                case Keys.NumPad4:
                    vehicle.RollUpWindow(VehicleWindow.FrontLeftWindow);

                    _frontLeftWindowUp = false;
                    break;

                case Keys.NumPad6 when _frontRightWindowUp == false:
                    vehicle.RollDownWindow(VehicleWindow.FrontRightWindow);

                    _frontRightWindowUp = true;
                    break;

                case Keys.NumPad6:
                    vehicle.RollUpWindow(VehicleWindow.FrontRightWindow);

                    _frontRightWindowUp = false;
                    break;

                case Keys.NumPad7 when _backLeftWindowUp == false:
                    vehicle.RollDownWindow(VehicleWindow.BackLeftWindow);

                    _backLeftWindowUp = true;
                    break;

                case Keys.NumPad7:
                    vehicle.RollUpWindow(VehicleWindow.BackLeftWindow);

                    _backLeftWindowUp = false;
                    break;

                case Keys.NumPad9 when _backRightWindowUp == false:
                    vehicle.RollDownWindow(VehicleWindow.BackRightWindow);

                    _backRightWindowUp = true;
                    break;

                case Keys.NumPad9:
                    vehicle.RollUpWindow(VehicleWindow.BackRightWindow);

                    _backRightWindowUp = false;
                    break;

                case Keys.NumPad5 when _allWindowsUp == false:
                    vehicle.RollDownWindows();

                    _allWindowsUp = true;
                    break;

                case Keys.NumPad5:
                    vehicle.RollUpWindow(VehicleWindow.BackRightWindow);
                    vehicle.RollUpWindow(VehicleWindow.BackLeftWindow);
                    vehicle.RollUpWindow(VehicleWindow.FrontLeftWindow);
                    vehicle.RollUpWindow(VehicleWindow.FrontRightWindow);

                    _allWindowsUp = false;
                    break;
            }
        }
    }
}
