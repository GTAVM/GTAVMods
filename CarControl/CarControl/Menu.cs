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
        public bool trunk;
        public bool frontLeftDoor;
        public bool frontRightDoor;
        public bool backLeftDoor;
        public bool backRightDoor;
        public bool engine;
        public bool blinkersAndLight;
        public bool neonLights;

        protected VehicleDoor Hood = VehicleDoor.Hood;
        protected VehicleDoor Trunk = VehicleDoor.Trunk;
        protected VehicleDoor FrontleftDoor = VehicleDoor.FrontLeftDoor;
        protected VehicleDoor FrontrightDoor = VehicleDoor.FrontRightDoor;
        protected VehicleDoor BackleftDoor = VehicleDoor.BackLeftDoor;
        protected VehicleDoor BackrightDoor = VehicleDoor.BackRightDoor;

        protected Ped player;
        protected Vehicle vehicle;

        const string ModName = "Car Control";

        private MenuPool _menuPool;
        public Menu()
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
            var newitem = new UIMenuCheckboxItem("NeonLights", neonLights);
            mainMenu.AddItem(newitem);
            mainMenu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    neonLights = checked_;
                    UI.Notify("~r~NeonLights status: ~b~" + neonLights);

                }
            };
        }

        private void BlinkersAndLight(UIMenu mainMenu)
        {
            var newitem = new UIMenuCheckboxItem("Turn on Blinkers and interior light", blinkersAndLight);
            mainMenu.AddItem(newitem);
            mainMenu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    blinkersAndLight = checked_;
                    UI.Notify("~r~Turn on Blinkers and interior light status: ~b~" + blinkersAndLight);
                    UI.ShowSubtitle("Left Blinker - NumPad1\n" +
                                    "Right Blinker - NumPad3\n" +
                                    "Emergency Lights - NumPad2\n" +
                                    "Interior light - NumPad*", 10000);
                }
            };
        }

        private void Engine(UIMenu mainMenu)
        {
            var newitem = new UIMenuCheckboxItem("Start or Stop engine", engine);
            mainMenu.AddItem(newitem);
            mainMenu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    engine = checked_;
                    UI.Notify("~r~Start or Stop engine status: ~b~" + engine);
                }
            };
        }
        public void BbackRightDoor(UIMenu menu)
        {
            var newitem = new UIMenuCheckboxItem("Open or close Back Right door", backRightDoor);
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    backRightDoor = checked_;
                    UI.Notify("~r~Open or close Back Right door status: ~b~" + backRightDoor);
                }
            };
        }
        public void BackLeftDoor(UIMenu menu)
        {
            var newitem = new UIMenuCheckboxItem("Open or close Back Left Door", backLeftDoor);
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    backLeftDoor = checked_;
                    UI.Notify("~r~Open or close Back Left Door status: ~b~" + backLeftDoor);
                }
            };
        }
        public void OpenOrCloseHood(UIMenu menu)
        {
            var newitem = new UIMenuCheckboxItem("Open or close Hood", false);
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    
                    //Open or close Hood
                    if (checked_)
                        vehicle.OpenDoor(Hood, false, false);
                    else
                        vehicle.CloseDoor(Hood, false);
                }
            };
        }
        public void OpenOrCloseTrunk(UIMenu menu)
        {
            var newitem = new UIMenuCheckboxItem("Open or close Trunk", false);
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    if (checked_)
                        vehicle.OpenDoor(Trunk, false, false);
                    else
                        vehicle.CloseDoor(Trunk, false);

                }
            };
        }
        public void FrontLeftDoor(UIMenu menu)
        {
            var newitem = new UIMenuCheckboxItem("Open or close Front Left Door", frontLeftDoor);
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    frontLeftDoor = checked_;
                    UI.Notify("~r~FrontLeftDoor status: ~b~" + frontLeftDoor);
                }
            };
        }
        public void FrontRightDoor(UIMenu menu)
        {
            var newitem = new UIMenuCheckboxItem("Open or close Front Right door", frontRightDoor);
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    frontRightDoor = checked_;
                    UI.Notify("~r~FrontRightDoor status: ~b~" + frontRightDoor);
                }
            };
        }
    }
}