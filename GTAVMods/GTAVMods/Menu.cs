using GTA;
using NativeUI;
using System.Windows.Forms;

namespace GTAVMods
{
    public class Menu : Script
    {
        const string ModName = "GTAVMods";

        public Menu()
        {
            CH.Messages.NotifyToLoad(modName: ModName);

            var menuPool = new MenuPool();
            var mainMenu = new UIMenu(ModName, "GTAVMods - All in One");
            menuPool.Add(mainMenu);

            SpawnKillers2(mainMenu);
            SpawnKillers(mainMenu);
            Cord(mainMenu);
            SpawnHydra(mainMenu);
            SpawnHydraWithPilot(mainMenu);
            SpawnDriverInCar(mainMenu);
            ScriptTutorial_CreateDogs(mainMenu);
            ScriptTutorial_KilleDogs(mainMenu);
            Visibility(mainMenu);

            menuPool.RefreshIndex();

            Tick += (o, e) => menuPool.ProcessMenus();
            KeyDown += (o, e) =>
            {
                if (e.KeyCode == Keys.F12 && !menuPool.IsAnyMenuOpen()) // Our menu on/off switch
                    mainMenu.Visible = !mainMenu.Visible;
            };

        }

        void SpawnKillers2(UIMenu menu)
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

        void Visibility(UIMenu menu)
        {
            var newitem = new UIMenuCheckboxItem("ChangeVisibility", false);
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.HPeds.ChangePlayerVisibility();
                }
            };
        }

        void Cord(UIMenu menu)
        {
            var newitem = new UIMenuItem("CordReporter", "Получение координат и запсь в файл\nCoordReport.txt");

            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.GetCoordinatesPlayer.Report();
                }
            };
        }

        void SpawnHydra(UIMenu menu)
        {
            var newitem = new UIMenuItem("Hydra", "Создать Hydra");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CreateHydra.Spawn();
                }
            };
        }

        void SpawnHydraWithPilot(UIMenu menu)
        {
            var newitem = new UIMenuItem("Hydra With Pilot", "SpawnHydraWithPilot");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    HydraWithPilot.Spawn();
                }
            };
        }

        void SpawnDriverInCar(UIMenu menu)
        {
            var newitem = new UIMenuItem("DriverInCar", "SpawnDriverInCar");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    DriverInCar.Spawn();
                }
            };
        }

        void SpawnKillers(UIMenu menu)
        {
            var newitem = new UIMenuItem("~y~Killers", "SpawnKillers");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    Killers.Spawn();
                }
            };
        }

        void ScriptTutorial_CreateDogs(UIMenu menu)
        {
            var newitem = new UIMenuItem("CreateDogs", "Create Dogs");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.HPeds.Dogs(true);
                }
            };
        }

        void ScriptTutorial_KilleDogs(UIMenu menu)
        {
            var newitem = new UIMenuItem("KilleDogs", "Kille Dogs");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.HPeds.Dogs(false);
                }
            };
        }
    }
}