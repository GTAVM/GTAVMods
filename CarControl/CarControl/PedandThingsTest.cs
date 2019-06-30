using System.Linq;
using System.Windows.Forms;
using CH;
using GTA;
using GTA.Native;

namespace KurumaTest
{
    public class PedandThingsTest : Script
    {
        public PedandThingsTest() => KeyUp += onKeyPressed;

        public void onKeyPressed(object sender, KeyEventArgs e)
        {
            #region comments
            // GTA.Native.Function.Call(Hash.SET_PLAYER_WANTED_LEVEL, Game.Player.Character, true, 5); 

            //Open Hood

            //Get Player's car
            //Vehicle v = Game.Player.Character.CurrentVehicle;

            //Car Doors

            //VehicleDoor Hood = VehicleDoor.Hood;
            //VehicleDoor Trunk = VehicleDoor.Trunk;
            //VehicleDoor FrontleftDoor = VehicleDoor.FrontLeftDoor;
            //VehicleDoor FrontrightDoor = VehicleDoor.FrontRightDoor;
            //VehicleDoor BackleftDoor = VehicleDoor.BackLeftDoor;
            //VehicleDoor BackrightDoor = VehicleDoor.BackRightDoor;

            //Open or close Hood
            #endregion com
            }

        }

    }

}
