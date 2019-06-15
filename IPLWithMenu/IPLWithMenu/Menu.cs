using GTA;
using NativeUI;
using System.Windows.Forms;

namespace IPL
{
    public class Menu : Script
    {
        private MenuPool _menuPool;

        public Menu()
        {
            _menuPool = new MenuPool();
            var mainMenu = new UIMenu("IPL", "Load/Unload IPLs");
            _menuPool.Add(mainMenu);

            BahamaMamasTeleport(mainMenu);
            BahamaMamas(mainMenu);
            ChopshopTeleport(mainMenu);
            Chopshop(mainMenu);
            CluckinBellTeleport(mainMenu);
            CluckinBell(mainMenu);
            ComedyClubTeleport(mainMenu);
            ComedyClub(mainMenu);
            FameOrShameStadiumTeleport(mainMenu);
            FameOrShameStadium(mainMenu);
            FIBLobbyTeleport(mainMenu);
            FIBLobby(mainMenu);
            FoundryTeleport(mainMenu);
            Foundry(mainMenu);
            FloydsHouseTeleport(mainMenu);
            FloydsHouse(mainMenu);
            EpsilonTeleport(mainMenu);
            Epsilon(mainMenu);
            EpsilonTeleport2(mainMenu);
            Epsilon2(mainMenu);
            HospitalInteriorTeleport(mainMenu);
            HospitalNormalTeleport(mainMenu);
            HospitalNormal(mainMenu);
            HospitalDestroyed(mainMenu);
            HospitalBoardedUp(mainMenu);
            JanitorTeleport(mainMenu);
            Janitor(mainMenu);
            JewelStoreTeleport(mainMenu);
            JewelStore(mainMenu);
            LabTeleport(mainMenu);
            LabElevatorTeleport(mainMenu);
            LabElevator2Teleport(mainMenu);
            Lab(mainMenu);
            LifeInvaderTeleport(mainMenu);
            LifeInvader(mainMenu);
            LestersHouseTeleport(mainMenu);
            LestersHouse(mainMenu);
            LestersFactoryTeleport(mainMenu);
            LestersFactory(mainMenu);
            MorgueTeleport(mainMenu);
            MorgueTeleport2(mainMenu);
            Morgue(mainMenu);
            ONeilRanchTeleport(mainMenu);
            ONeilRanch(mainMenu);
            PsycheofficeTeleport(mainMenu);
            Psycheoffice(mainMenu);
            RanchTeleport(mainMenu);
            Ranch(mainMenu);
            RogersSalvageAndScrapTeleport(mainMenu);
            RogersSalvageAndScrap(mainMenu);
            RogersSalvageAndScrap2(mainMenu);
            SheriffOfficePaletoTeleport(mainMenu);
            SheriffOfficePaleto(mainMenu);
            SheriffOfficeSandyShoresTeleport(mainMenu);
            SheriffOfficeSandyShores(mainMenu);
            SimeonsShowroomTeleport(mainMenu);
            SimeonsShowroom(mainMenu);
            SlaughterHouseTeleport(mainMenu);
            SlaughterHouse(mainMenu);
            SolomonsOfficeTeleport(mainMenu);
            SolomonsOffice(mainMenu);
            StabCityTeleport(mainMenu);
            StabCityUnburnt(mainMenu);
            StabCityBurnt(mainMenu);
            TrevorstrailerTeleport(mainMenu);
            Trevorstrailer(mainMenu);
            TequlLaLaTeleport(mainMenu);
            TequlLaLa(mainMenu);
            TortureTeleport(mainMenu);
            Torture(mainMenu);
            Online(mainMenu);
            LostSafeHouseTeleport(mainMenu);
            LostSafeHouse(mainMenu);
            YachtTeleport(mainMenu);
            Yacht(mainMenu);
            HeistCarrierTeleport(mainMenu);
            HeistCarrier(mainMenu);
            NorthYanktonTeleport(mainMenu);
            NorthYankton(mainMenu);

            _menuPool.RefreshIndex();

            Tick += (o, e) => _menuPool.ProcessMenus();
            KeyDown += (o, e) =>
            {
                if (e.KeyCode == Keys.F9 && !_menuPool.IsAnyMenuOpen()) // Our menu on/off switch
                    mainMenu.Visible = !mainMenu.Visible;
            };
        }

        private void NorthYanktonTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("North Yankton - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                    CH.IPL.NorthYanktonTeleport();
            };
        }

        private void NorthYankton(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("North Yankton", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                    CH.IPL.NorthYanktonLoad();

                if (item == newitem && !checked_)
                    CH.IPL.NorthYanktonUnload();
            };
        }

        private void BahamaMamasTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Bahama Mamas - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                    CH.IPL.BahamaMamasTeleport();
            };
        }

        private void BahamaMamas(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Bahama  Mamas", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                    CH.IPL.BahamaMamasLoad();

                if (item == newitem && !checked_)
                    CH.IPL.BahamaMamasUnload();
            };
        }

        private void ChopshopTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Chopshop - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                    CH.IPL.ChopshopTeleport();
            };
        }

        private void Chopshop(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Chopshop", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                    CH.IPL.ChopshopLoad();

                if (item == newitem && !checked_)
                    CH.IPL.ChopshopUnload();
            };
        }

        private void CluckinBellTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Cluckin Bell - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.CluckinBellTeleport();

                }
            };
        }

        private void CluckinBell(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Cluckin Bell", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.CluckinBellLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.CluckinBellUnload();

                }

            };
        }

        private void ComedyClubTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Comedy club - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.ComedyClubTeleport();

                }
            };
        }

        private void ComedyClub(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("~r~Comedy club", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.ComedyClubLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.ComedyClubUnload();

                }

            };
        }
        private void FameOrShameStadiumTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Fame or Shame Stadium - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.FameOrShameStadiumTeleport();

                }
            };
        }

        private void FameOrShameStadium(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Fame or Shame Stadium", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.FameOrShameStadiumLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.FameOrShameStadiumUnload();

                }

            };
        }
        private void FIBLobbyTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("FIB Lobby - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.FIBLobbyTeleport();

                }
            };
        }

        private void FIBLobby(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("FIB Lobby", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.FIBLobbyLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.FIBLobbyUnload();

                }

            };
        }
        private void FoundryTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Foundry - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.FoundryTeleport();

                }
            };
        }

        private void Foundry(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Foundry", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.FoundryLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.FoundryUnload();

                }

            };
        }
        private void FloydsHouseTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Floyd's house - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.FloydsHouseTeleport();

                }
            };
        }

        private void FloydsHouse(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Floyd's house", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.FloydsHouseLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.FloydsHouseUnload();

                }

            };
        }
        private void EpsilonTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Epsilon - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.EpsilonTeleport();

                }
            };
        }

        private void Epsilon(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Epsilon", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.EpsilonLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.EpsilonUnload();

                }

            };
        }
        private void EpsilonTeleport2(UIMenu menu)
        {
            var newitem = new UIMenuItem("Epsilon2 - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.EpsilonTeleport2();

                }
            };
        }

        private void Epsilon2(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Epsilon2", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.EpsilonLoad2();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.EpsilonUnload2();

                }

            };
        }
        private void HospitalInteriorTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Hospital Interior - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.HospitalInteriorTeleport();

                }
            };
        }
        private void HospitalNormalTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Hospital normal - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.HospitalNormalTeleport();

                }
            };
        }
        private void HospitalNormal(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Hospital normal", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.HospitalNormalLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.HospitalNormalUnload();

                }

            };
        }
        private void HospitalDestroyed(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Hospital Destroyed", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.HospitalDestroyedLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.HospitalDestroyedUnload();

                }

            };
        }
        private void HospitalBoardedUp(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Hospital boarded up", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.HospitalBoardedUpLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.HospitalBoardedUpUnload();

                }

            };
        }
        private void JanitorTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Janitor - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.JanitorTeleport();

                }
            };
        }
        private void Janitor(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Janitor", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.JanitorLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.JanitorUnload();

                }

            };
        }
        private void JewelStoreTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Jewel store - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.JewelStoreTeleport();

                }
            };
        }
        private void JewelStore(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Jewel store", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.JewelStoreLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.JewelStoreUnload();

                }

            };
        }
        private void LabTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Lab - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.LabTeleport();

                }
            };
        }
        private void LabElevatorTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Lab Elevator - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.LabElevatorTeleport();

                }
            };
        }
        private void LabElevator2Teleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Lab Elevator2 - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.LabElevator2Teleport();

                }
            };
        }
        private void Lab(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Lab", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.LabLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.LabUnload();

                }

            };
        }
        private void LifeInvaderTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("LifeInvader - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.LifeInvaderTeleport();

                }
            };
        }
        private void LifeInvader(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("LifeInvader", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.LifeInvaderLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.LifeInvaderUnload();

                }

            };
        }
        private void LestersHouseTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Lesters House - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.LestersHouseTeleport();

                }
            };
        }
        private void LestersHouse(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Lesters House", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.LestersHouseLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.LestersHouseUnload();

                }

            };
        }
        private void LestersFactoryTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Lesters Factory - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.LestersFactoryTeleport();

                }
            };
        }
        private void LestersFactory(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Lesters Factory", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.LestersFactoryLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.LestersFactoryUnload();

                }

            };
        }
        private void MorgueTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Morgue - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.MorgueTeleport();

                }
            };
        }
        private void MorgueTeleport2(UIMenu menu)
        {
            var newitem = new UIMenuItem("Morgue 2 - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.MorgueTeleport2();

                }
            };
        }
        private void Morgue(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Morgue", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.MorgueLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.MorgueUnload();

                }

            };
        }
        private void ONeilRanchTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("O'Neil Ranch - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.ONeilRanchTeleport();

                }
            };
        }
        private void ONeilRanch(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("O'Neil Ranch", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.ONeilRanchLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.ONeilRanchUnload();

                }

            };
        }
        private void PsycheofficeTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Psycheoffice - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.PsycheofficeTeleport();

                }
            };
        }
        private void Psycheoffice(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Psycheoffice", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.PsycheofficeLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.PsycheofficeUnload();

                }

            };
        }
        private void RanchTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Ranch - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.RanchTeleport();

                }
            };
        }
        private void Ranch(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Ranch", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.RanchLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.RanchUnload();

                }

            };
        }
        private void RogersSalvageAndScrapTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Rogers Salvage & Scrap - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.RogersSalvageAndScrapTeleport();

                }
            };
        }
        private void RogersSalvageAndScrap(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Rogers Salvage & Scrap", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.RogersSalvageAndScrapLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.RogersSalvageAndScrapUnload();

                }

            };
        }
        private void RogersSalvageAndScrap2(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Rogers Salvage & Scrap 2", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.RogersSalvageAndScrapLoad2();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.RogersSalvageAndScrapUnload2();

                }

            };
        }
        private void SheriffOfficePaletoTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Sheriff Office paleto - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.SheriffOfficePaletoTeleport();

                }
            };
        }
        private void SheriffOfficePaleto(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Sheriff Office paleto", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.SheriffOfficePaletoLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.SheriffOfficePaletoUnload();

                }

            };
        }
        private void SheriffOfficeSandyShoresTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Sheriff Office sandy shores - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.SheriffOfficeSandyShoresTeleport();

                }
            };
        }
        private void SheriffOfficeSandyShores(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Sheriff Office sandy shores", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.SheriffOfficeSandyShoresLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.SheriffOfficeSandyShoresUnload();

                }

            };
        }
        private void SimeonsShowroomTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Simeons Showroom - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.SimeonsShowroomTeleport();

                }
            };
        }
        private void SimeonsShowroom(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Simeons Showroom", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.SimeonsShowroomLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.SimeonsShowroomUnload();

                }

            };
        }
        private void SlaughterHouseTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Slaughter house - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.SlaughterHouseTeleport();

                }
            };
        }
        private void SlaughterHouse(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Slaughter house", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.SlaughterHouseLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.SlaughterHouseUnload();

                }

            };
        }
        private void SolomonsOfficeTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Solomon's office - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.SolomonsOfficeTeleport();

                }
            };
        }
        private void SolomonsOffice(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Solomon's office", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.SolomonsOfficeLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.SolomonsOfficeUnload();

                }

            };
        }
        private void StabCityTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Stab city - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.StabCityTeleport();

                }
            };
        }
        private void StabCityUnburnt(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Stab city unburnt", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.StabCityUnburntLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.StabCityUnburntUnload();

                }

            };
        }
        private void StabCityBurnt(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Stab city burnt", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.StabCityBurntLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.StabCityBurntUnload();

                }

            };
        }
        private void TrevorstrailerTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Trevorstrailer - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.TrevorstrailerTeleport();

                }
            };
        }
        private void Trevorstrailer(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Trevorstrailer", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.TrevorstrailerLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.TrevorstrailerUnload();

                }

            };
        }
        private void TequlLaLaTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("TEQUL-LA_LA - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.TequlLaLaTeleport();

                }
            };
        }
        private void TequlLaLa(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("TEQUL-LA_LA", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.TequlLaLaLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.TequlLaLaUnload();

                }

            };
        }
        private void TortureTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Torture - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.TortureTeleport();

                }
            };
        }
        private void Torture(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Torture", check, "Load/Unload");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.TortureLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.TortureUnload();

                }

            };
        }
        private void Online(UIMenu menu)
        {
            var newitem = new UIMenuItem("Online - Load");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.Online();
                }
            };
        }
        private void LostSafeHouseTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Lost Safe House - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.LostSafeHouseTeleport();

                }
            };
        }
        private void LostSafeHouse(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Lost Safe House", check, "Load/Unload\n" +
                "Requires: Online - Load");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.LostSafeHouseLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.LostSafeHouseUnload();

                }

            };
        }
        private void YachtTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Yacht - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.YachtTeleport();

                }
            };
        }
        private void Yacht(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("Yacht", check, "Load/Unload\n" +
                "Requires: Online - Load");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.YachtLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.YachtUnload();

                }

            };
        }
        private void HeistCarrierTeleport(UIMenu menu)
        {
            var newitem = new UIMenuItem("Heist Carrier - Teleport");
            menu.AddItem(newitem);
            menu.OnItemSelect += (sender, item, checked_) =>
            {
                if (item == newitem)
                {
                    CH.IPL.HeistCarrierTeleport();

                }
            };
        }
        private void HeistCarrier(UIMenu menu)
        {
            bool check = false;
            var newitem = new UIMenuCheckboxItem("~y~Heist Carrier", check, "Load/Unload\n" +
                "Requires: Online - Load");
            menu.AddItem(newitem);
            menu.OnCheckboxChange += (sender, item, checked_) =>
            {
                if (item == newitem && checked_)
                {

                    CH.IPL.HeistCarrierLoad();

                }
                if (item == newitem && !checked_)
                {

                    CH.IPL.HeistCarrierUnload();

                }

            };
        }
    }
}
