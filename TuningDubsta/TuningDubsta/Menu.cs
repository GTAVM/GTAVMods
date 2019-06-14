using GTA;
using NativeUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuningDubsta
{
    class Menu : Script
    {
        MenuPool _menuPool;
        const string ModName = "Tuning Dubsta";

        public Menu()
        {
            CH.Messages.NotifyToLoad(modName: ModName);

            _menuPool = new MenuPool();
            var mainMenu = new UIMenu(ModName, "~b~Select Item");
            _menuPool.Add(mainMenu);

            SpawnDubsta(mainMenu);
            DriveTo(mainMenu);
            Cruise(mainMenu);
            Repair(mainMenu);
            //TaskDriveToPlayer(mainMenu);

            _menuPool.RefreshIndex();

            Tick += (o, e) => _menuPool.ProcessMenus();
            KeyDown += (o, e) =>
            {
                if (e.KeyCode == Keys.F11 && !_menuPool.IsAnyMenuOpen()) // Our menu on/off switch
                    mainMenu.Visible = !mainMenu.Visible;
            };
        }

        void Repair(UIMenu menu)
        {
            var newitem = new UIMenuCheckboxItem("Repair", false);
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    global::TuningDubsta.Repair.VehicleRepairToggle(checked_);
                }
            };
        }

        void DriveTo(UIMenu menu)
        {
            var newitem = new UIMenuCheckboxItem("Drive to", false);
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    Autopilot.DriveTo(checked_);
                }
            };
        }

        void Cruise(UIMenu menu)
        {
            var newitem = new UIMenuCheckboxItem("Cruise", false);
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    Autopilot.Cruise(checked_);
                }
            };
        }

        //public void TaskDriveToPlayer(UIMenu menu)
        //{
        //	var newitem = new UIMenuCheckboxItem("~r~Drive To Player", false);
        //	menu.AddItem(newitem);
        //	menu.OnCheckboxChange += (sender, item, checked_) =>
        //	{
        //              UI.Notify(checked_.ToString());
        //              if (item == newitem)
        //		{
        //                  DriveToPlayer.Start(checked_);
        //              }
        //	};
        //}

        void SpawnDubsta(UIMenu menu)
        {
            var newitem = new UIMenuItem("TuningDubsta", "Создать дабсту" /*tuningDubsta*/);
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    TuningDubsta.Spawn();
                }
            };
        }
    }
}
