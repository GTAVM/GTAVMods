using GTA;
using NativeUI;
using System.Windows.Forms;
using GTA.Native;
using System.Drawing;
using System;

namespace CarControls
{
    public class Menu : Script
    {
        protected bool blinkersAndLight;
        protected bool powerWindowsControl;

        protected Ped player;
        protected Vehicle vehicle;

        private const VehicleDoor Hood = VehicleDoor.Hood;
        private const VehicleDoor Trunk = VehicleDoor.Trunk;
        private const VehicleDoor FrontleftDoor = VehicleDoor.FrontLeftDoor;
        private const VehicleDoor FrontrightDoor = VehicleDoor.FrontRightDoor;
        private const VehicleDoor BackleftDoor = VehicleDoor.BackLeftDoor;
        private const VehicleDoor BackrightDoor = VehicleDoor.BackRightDoor;
        
        const string ModName = "Car Control";

        private MenuPool _menuPool;

        protected Menu()
        {
            CH.Messages.NotifyToLoad(modName: ModName);

            _menuPool = new MenuPool();
            var mainMenu = new UIMenu(ModName, "");
            _menuPool.Add(mainMenu);

            BlinkersAndLight(mainMenu);
            OpenOrCloseHood(mainMenu);
            OpenOrCloseTrunk(mainMenu);
            FrontLeftDoor(mainMenu);
            FrontRightDoor(mainMenu);
            BackLeftDoor(mainMenu);
            BbackRightDoor(mainMenu);
            Engine(mainMenu);
            NeonLights(mainMenu);
            FlyThroughWindscreen(mainMenu);
            PowerWindowsControl(mainMenu);

            _menuPool.RefreshIndex();

            Tick += (o, e) => _menuPool.ProcessMenus();
            KeyDown += (o, e) =>
            {
                player = Game.Player.Character;
                //Get current vehicle if the player it's on vehicle and get the last vehicle if not.
                vehicle = player.IsInVehicle() ? player.CurrentVehicle : player.LastVehicle;

                if (e.KeyCode == Keys.F10 && !_menuPool.IsAnyMenuOpen()) // Our menu on/off switch
                    mainMenu.Visible = !mainMenu.Visible;
            };
        }

        private void FlyThroughWindscreen(UIMenu mainMenu)
        {
            var newitem = new UIMenuCheckboxItem("Can't Fly Through Windscreen", false);
            mainMenu.AddItem(newitem);
            mainMenu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    Game.Player.Character.CanFlyThroughWindscreen = !checked_;
                }
            };
        }

        private void NeonLights(UIMenu mainMenu)
        {
            var newitem = new UIMenuCheckboxItem("NeonLights", false);
            mainMenu.AddItem(newitem);
            mainMenu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item != newitem) return;

                if (checked_)
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
            };
        }

        private void BlinkersAndLight(UIMenu mainMenu)
        {
            var newitem = new UIMenuCheckboxItem("Turn on Blinkers and interior light", false);
            mainMenu.AddItem(newitem);
            mainMenu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item != newitem) return;

                blinkersAndLight = checked_;
                
                if(!checked_) return;
                UI.ShowSubtitle("Left Blinker - NumPad1\n" +
                                "Right Blinker - NumPad3\n" +
                                "Emergency Lights - NumPad2\n" +
                                "Interior light - NumPad*", 10000);
            };
        }

        private void PowerWindowsControl(UIMenu mainMenu)
        {
            var newitem = new UIMenuCheckboxItem("Power windows control", false);
            mainMenu.AddItem(newitem);
            mainMenu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item != newitem) return;

                powerWindowsControl = checked_;

                if (!checked_) return;
                UI.ShowSubtitle("Down Front Left Window - NumPad1\n" +
                                "Down Front Right Window - NumPad3\n" +
                                "Up Front Left Window - NumPad4\n" +
                                "Up Front Right Window - NumPad6", 10000);
            };
        }

        private void Engine(UIMenu mainMenu)
        {
            var newitem = new UIMenuCheckboxItem("Start or Stop engine", false);
            mainMenu.AddItem(newitem);
            mainMenu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item != newitem) return;
                //if (!player.IsInVehicle())
                vehicle.EngineRunning = checked_;
            };
        }

        private void BbackRightDoor(UIMenu menu)
        {
            var newitem = new UIMenuCheckboxItem("Open or close Back Right door", false);
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item != newitem) return;
                if (!checked_)
                    vehicle.CloseDoor(BackrightDoor, false);
                else
                    vehicle.OpenDoor(BackrightDoor, false, false);
            };
        }

        private void BackLeftDoor(UIMenu menu)
        {
            var newitem = new UIMenuCheckboxItem("Open or close Back Left Door", false);
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item != newitem) return;
                if (!checked_)
                    vehicle.CloseDoor(BackleftDoor, false);
                else
                    vehicle.OpenDoor(BackleftDoor, false, false);
            };
        }

        private void OpenOrCloseHood(UIMenu menu)
        {
            var newitem = new UIMenuCheckboxItem("Open or close Hood", false);
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item != newitem) return;
                if (checked_)
                    vehicle.OpenDoor(Hood, false, false);
                else
                    vehicle.CloseDoor(Hood, false);
            };
        }

        private void OpenOrCloseTrunk(UIMenu menu)
        {
            var newitem = new UIMenuCheckboxItem("Open or close Trunk", false);
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item != newitem) return;
                if (checked_)
                    vehicle.OpenDoor(Trunk, false, false);
                else
                    vehicle.CloseDoor(Trunk, false);
            };
        }

        private void FrontLeftDoor(UIMenu menu)
        {
            var newitem = new UIMenuCheckboxItem("Open or close Front Left Door", false);
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item != newitem) return;
                if (checked_)
                    vehicle.OpenDoor(FrontleftDoor, false, false);
                else
                    vehicle.CloseDoor(FrontleftDoor, false);
            };
        }

        private void FrontRightDoor(UIMenu menu)
        {
            var newitem = new UIMenuCheckboxItem("Open or close Front Right door", false);
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item != newitem) return;
                if (!checked_)
                    vehicle.CloseDoor(FrontrightDoor, false);
                else
                    vehicle.OpenDoor(FrontrightDoor, false, false);
            };
        }
    }
}