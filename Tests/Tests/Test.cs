using GTA;
using GTA.Native;
using System;
using System.Windows.Forms;
using Test;

namespace Tests
{
    class Test : Script
    {
        private Ped myPed;
        private object myBlip;
        private Blip blip;

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
                LifeSimulator.On = true;
                UI.Notify("Pressed Key: Nome");
            }

            if (e.KeyCode == Keys.End)
            {
                LifeSimulator.On = false;
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

