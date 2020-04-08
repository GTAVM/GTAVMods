using GTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA.Math;
using GTA.Native;

namespace LifeSimulator
{
    public class MainScript : Script
    {
        private Ped[] _peds;
        private int _count;
        private bool _playerChange;
        private Model _playerModel;
        private Blip blip;

        public MainScript()
        {
            Tick += OnTick;
            Interval = 1000;
        }

        private int Eat { get; set; } = 100;
        public static bool On { get; set; }

        private void OnTick(object sender, EventArgs e)
        {
            if (!On && _count > 0)
            {
                Game.Player.ChangeModel(_playerModel);
                Game.Player.Character.Task.ClearAll();
                _playerChange = false;
                _count = 0;
                Eat = 100;
            }

            if (!On) return;
            PlayerChange();
            Hunt();
            Eating();

            //if (count == 2)
            //{
            //    Hunt();
            //    count = 0;
            //}

            UI.ShowSubtitle("test:Life Engine: " + _count +
                            "\nEat: " + Eat);

            if (_count % 4 == 0) Eat--;
            _count++;
        }

        void Eating()
        {
            _peds = World.GetNearbyPeds(Game.Player.Character.Position, 10f);
            foreach (var ped in _peds)
            {
                if (!ped.IsInVehicle() &&
                    World.GetDistance(Game.Player.Character.Position, ped.Position)
                    < 1.1f && !ped.IsPlayer && ped.IsAlive)
                {
                    Eat += 10;
                    UI.Notify("Eating + 10 ");

                    ped.Task.HandsUp(10000);
                    CH.HPeds.PedDamageHeavy(ped);
                    Game.Player.Character.Task.RunTo(ped.Position);
                    ped.Kill();
                    ped.MarkAsNoLongerNeeded();
                    if (ped.Model == new Model(PedHash.Seagull) ||
                        ped.Model == new Model(PedHash.Rat))
                    {
                        ped.Delete();
                    }
                }
            }
        }

        void PlayerChange()
        {
            if (_playerChange) return;
            _playerModel = Game.Player.Character.Model;
            CH.HPeds.ChangePlayerModel(PedHash.MountainLion);
            _playerChange = true;
        }
        
        void Hunt()
        {
            _peds = World.GetNearbyPeds(Game.Player.Character.Position, 150f);
            foreach (var ped in _peds)
            {
                //ped.Task.FightAgainst(Game.Player.Character, 20000);
                if (!ped.IsInVehicle() && !ped.IsPlayer && !ped.IsDead && _count % 3 == 0
                                       && ped.IsOnFoot)
                {
                    blip?.Remove();
                    if (Game.Player.Character.Position.DistanceTo2D(ped.Position) < 150)
                    {
                        blip = World.CreateBlip(ped.Position + ped.ForwardVector * 20);
                        blip.Color = BlipColor.Blue;
                        Game.Player.Character.Task.RunTo(ped.Position + ped.ForwardVector * 25);
                    }

                }
                else if (_count % 6 == 0)
                {
                    Game.Player.Character.Task.WanderAround();
                }
            }
        }
    }
}
