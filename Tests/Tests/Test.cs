using GTA;
using GTA.Native;
using System;
using System.Windows.Forms;

namespace Tests
{
    class Test : Script
    {
        public Test()
        {
            CH.Messages.NotifyToLoad("Tests");

            KeyDown += OnKeyDown;
            //KeyUp += OnKeyUp;
            //Tick += OnTick;
            //Interval = 1000;
        }

        void OnKeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Home)
            {
                //Game.Player.Character.Health = -1;
                //Game.Player.ChangeModel(new Model(PedHash.Rat));
                //CH.HWorld.IncreaseWaves();
                UI.Notify(@"Pressed Key: Nome");
            }

            if (e.KeyCode == Keys.End)
            {
                //Game.Player.ChangeModel(new Model(PedHash.Trevor));
                //CH.HWorld.ReduceWaves();
                UI.Notify("Pressed Key: End");
            }
        }

        void OnKeyUp(object sender, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        void OnTick(object sender, EventArgs e)
        {
            UI.Notify("Tests.OnTick: works");
        }
    }
}

