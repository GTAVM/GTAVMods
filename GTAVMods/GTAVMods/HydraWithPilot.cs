using GTA;
using GTA.Math;
using GTA.Native;

namespace GTAVMods
{
    class HydraWithPilot : Script
    {
        public static void Spawn()
        {
            Vector3 playerPos = Game.Player.Character.Position;
            playerPos = playerPos + Game.Player.Character.ForwardVector * 13;

            Vehicle myCar =
                World.CreateVehicle(VehicleHash.Hydra, playerPos);

            Ped driver =
                myCar.CreateRandomPedOnSeat(VehicleSeat.Driver);

            driver.Task.DriveTo(myCar, driver.ForwardVector * 100, 1, 100);
        }
    }
}
