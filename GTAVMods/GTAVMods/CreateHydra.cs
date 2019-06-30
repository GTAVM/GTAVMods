using System;
using System.Drawing;
using System.Windows.Forms;
using GTA;
using GTA.Native;

namespace GTAVMods
{
    class CreateHydra : Script
    {
        public static void Spawn()
        {
            Vehicle vehicle = World.CreateVehicle(VehicleHash.Hydra, Game.Player.Character.Position +
                Game.Player.Character.ForwardVector * 13.0f, Game.Player.Character.Heading + 90);
            vehicle.CanTiresBurst = false;
            vehicle.IsInvincible = true;
        }
    }
}