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
		public bool hood;
		public bool trunk;
		public bool frontLeftDoor;
		public bool frontRightDoor;
		public bool backLeftDoor;
		public bool backRightDoor;
		public bool engine;
		public bool blinkersAndLight;
		public bool neonLights;
		public bool flyThroughWindscreen;
        const string ModName = "Car Control";

        private MenuPool _menuPool;
		public Menu()
		{
            CH.Messages.NotifyToLoad(modName: ModName);

            _menuPool = new MenuPool();
			var mainMenu = new UIMenu(ModName, "");
			_menuPool.Add(mainMenu);

			BlinkersAndLight(mainMenu);
			Hood(mainMenu);
			Trunk(mainMenu);
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
				if (e.KeyCode == Keys.F10 && !_menuPool.IsAnyMenuOpen()) // Our menu on/off switch
					mainMenu.Visible = !mainMenu.Visible;
			};
		}

		private void FlyThroughWindscreen(UIMenu mainMenu)
		{
			var newitem = new UIMenuCheckboxItem("FlyThroughWindscreen", flyThroughWindscreen);
			mainMenu.AddItem(newitem);
			mainMenu.OnCheckboxChange += (sender, item, checked_) =>
			{
				if (item == newitem)
				{
					flyThroughWindscreen = checked_;
					UI.Notify("~r~FlyThroughWindscreen status: ~b~" + flyThroughWindscreen);

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
		public void Hood(UIMenu menu)
		{
			var newitem = new UIMenuCheckboxItem("Open or close Hood", hood);
			menu.AddItem(newitem);
			menu.OnCheckboxChange += (sender, item, checked_) =>
			{
				if (item == newitem)
				{
					hood = checked_;
					UI.Notify("~r~Hood status: ~b~" + hood);
				}
			};
		}
		public void Trunk(UIMenu menu)
		{
			var newitem = new UIMenuCheckboxItem("Open or close Trunk", trunk);
			menu.AddItem(newitem);
			menu.OnCheckboxChange += (sender, item, checked_) =>
			{
				if (item == newitem)
				{
					trunk = checked_;
					UI.Notify("~r~Trunk status: ~b~" + trunk);
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