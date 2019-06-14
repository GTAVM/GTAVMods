using GTA;
using GTA.Math;
using System;
using System.Windows.Forms;

namespace TuningDubsta
{
    class DriveToPlayer : Script
    {
        static Vehicle vehicle;
        static Ped driver;
        static bool driveToPlayer = false;

        static Vector3 currentplayerPos;

        public DriveToPlayer()
        {
            //KeyDown += OnKeyDown;
            //KeyUp += OnKeyUp;
            Tick += OnTick;
            Interval = 1000;
        }

        private static void Drive()
        {
            if (driver != null)
            {
                driver.Delete();

            }

            vehicle = Game.Player.Character.LastVehicle;
            vehicle.AddBlip().Sprite = BlipSprite.PersonalVehicleCar;


            driver = vehicle.CreateRandomPedOnSeat(VehicleSeat.Driver);


            currentplayerPos = Game.Player.Character.Position;
            currentplayerPos = currentplayerPos + Game.Player.Character.ForwardVector;

            driver.Task.DriveTo(vehicle, currentplayerPos, 15f, 10f);
        }

        public static void Start(bool on)
        {
            if (on)
            {


                Drive();
                driveToPlayer = true;

                UI.Notify("Start");
            }
            else
            {
                driveToPlayer = false;
            }


        }

        private void OnTick(object sender, EventArgs e)
        {
            Vector3 currentplayerPos = Game.Player.Character.Position;
            //currentplayerPos = currentplayerPos + Game.Player.Character.ForwardVector;
            if (vehicle != null && driver != null && driveToPlayer)
            {
                //    driver.Task.DriveTo(vehicle, currentplayerPos, 15f, 10f);

                if (World.CalculateTravelDistance(currentplayerPos, vehicle.Position) > 20)
                {
                    Drive();

                    UI.Notify((World.CalculateTravelDistance(currentplayerPos, vehicle.Position).ToString()) + " > 20");


                }
                else if (World.CalculateTravelDistance(currentplayerPos, vehicle.Position) < 20)
                {
                    if (driver != null)
                    {
                        driver.Delete();
                        vehicle.CurrentBlip.Remove();
                    }
                }

                //    UI.Notify("OnTick if driveToPlayer");
            }
        }
    }
}
