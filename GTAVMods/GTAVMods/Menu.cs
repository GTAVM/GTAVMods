using GTA;
using NativeUI;
using System.Windows.Forms;

namespace GTAVMods
{
	public class Menu : Script
	{
		#region variable comments
		//public bool scriptTutorial_CreateDogs;
		//public bool scriptTutorial_KilleDogs;
		//public bool driverInCar;
		//public bool tuningDubsta;
		//public bool killers;
		//public bool killersComon;
		//public bool createHydra;
		//public bool hydraWithPilot;
		//public bool crazyChristmasTogle;
		//public bool cordReporter = false;
		//public bool driveToWapointPosition;
		//public bool cruise;
		//public bool repair;
		#endregion

		public bool visibility;
        const string ModName = "GTAVMods";

        public Menu()
		{
            CH.Messages.NotifyToLoad(modName: ModName);

            _menuPool = new MenuPool();
			var mainMenu = new UIMenu(ModName, "GTAVMods - All in One");
			_menuPool.Add(mainMenu);
						
			SpawnKillers2(mainMenu);
			SpawnKillers(mainMenu);
			Cord(mainMenu);
			SpawnHydra(mainMenu);
			SpawnHydraWithPilot(mainMenu);
			SpawnDriverInCar(mainMenu);
			ScriptTutorial_CreateDogs(mainMenu);
			ScriptTutorial_KilleDogs(mainMenu);
			Visibility(mainMenu);
            
			_menuPool.RefreshIndex();

			Tick += (o, e) => _menuPool.ProcessMenus();
			KeyDown += (o, e) =>
			{
				if (e.KeyCode == Keys.F12 && !_menuPool.IsAnyMenuOpen()) // Our menu on/off switch
					mainMenu.Visible = !mainMenu.Visible;
			};

		}

		private MenuPool _menuPool;
		
		public void SpawnKillers2(UIMenu menu)
		{
			var newitem = new UIMenuItem("Killers2");
			menu.AddItem(newitem);
			menu.OnItemSelect += (sender, item, checked_) =>
			{
				if (item == newitem)
				{
					Killers2.Spawn();
				}
			};
		}

		public void Visibility(UIMenu menu)
		{
			var newitem = new UIMenuCheckboxItem("ChangeVisibility", visibility);
			menu.AddItem(newitem);
			menu.OnCheckboxChange += (sender, item, checked_) =>
			{
				if (item == newitem)
				{
                    CH.HPeds.ChangePlayerVisibility();
				}
			};
		}
				
		public void Cord(UIMenu menu)
		{
			var newitem = new UIMenuItem("CordReporter", "Получение координат и запсь в файл\nCoordReport.txt"/*cordReporter*/);

			menu.AddItem(newitem);
			menu.OnItemSelect += (sender, item, checked_) =>
			{
				if (item == newitem)
				{
                    CH.GetCoordinatesPlayer.Report();					
				}
			};
		}

		public void SpawnHydra(UIMenu menu)
		{
			var newitem = new UIMenuItem("Hydra", "Создать Hydra" /*createHydra*/);
			menu.AddItem(newitem);
			menu.OnItemSelect += (sender, item, checked_) =>
			{
				if (item == newitem)
				{
					//createHydra = checked_;
					CreateHydra.Spawn();

				}
			};
		}
		public void SpawnHydraWithPilot(UIMenu menu)
		{
			var newitem = new UIMenuItem("Hydra With Pilot", "SpawnHydraWithPilot" /*hydraWithPilot*/);
			menu.AddItem(newitem);
			menu.OnItemSelect += (sender, item, checked_) =>
			{
				if (item == newitem)
				{
					HydraWithPilot.Spawn();
					//hydraWithPilot = checked_;

				}
			};
		}

		public void SpawnDriverInCar(UIMenu menu)
		{
			var newitem = new UIMenuItem("DriverInCar", "SpawnDriverInCar"/*driverInCar*/);
			menu.AddItem(newitem);
			menu.OnItemSelect += (sender, item, checked_) =>
			{
				if (item == newitem)
				{
					//driverInCar = checked_;
					DriverInCar.Spawn();

				}
			};
		}

		public void SpawnKillers(UIMenu menu)
		{
			var newitem = new UIMenuItem("~y~Killers", "SpawnKillers"/*killers*/);
			menu.AddItem(newitem);
			menu.OnItemSelect += (sender, item, checked_) =>
			{
				if (item == newitem)
				{
					Killers.Spawn();
					//killers = checked_;

				}
			};
		}

		public void ScriptTutorial_CreateDogs(UIMenu menu)
		{
			var newitem = new UIMenuItem("CreateDogs", "Create Dogs"/*scriptTutorial_CreateDogs*/);
			menu.AddItem(newitem);
			menu.OnItemSelect += (sender, item, checked_) =>
			{
				if (item == newitem)
				{
                    CH.HPeds.Dogs(true);
					//scriptTutorial_CreateDogs = checked_;

				}
			};
		}

		public void ScriptTutorial_KilleDogs(UIMenu menu)
		{
			var newitem = new UIMenuItem("KilleDogs", "Kille Dogs"/*scriptTutorial_KilleDogs*/);
			menu.AddItem(newitem);
			menu.OnItemSelect += (sender, item, checked_) =>
			{
				if (item == newitem)
				{
                    CH.HPeds.Dogs(false);
					//scriptTutorial_KilleDogs = true;

				}
			};
		}
	}
}