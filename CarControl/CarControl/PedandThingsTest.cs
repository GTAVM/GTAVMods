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
            switch (e.KeyCode)
            {
                #region comments
                //case Keys.NumPad8:

                //	if (v.IsDoorOpen(Hood) == false)
                //	{
                //		v.OpenDoor(Hood, false, false);

                //	}
                //	else
                //	{

                //		v.CloseDoor(Hood, false);

                //	}

                //	break;

                //case Keys.NumPad2:

                //	if (v.IsDoorOpen(Trunk) == true)
                //	{

                //		v.CloseDoor(Trunk, false);

                //	}
                //	else
                //	{
                //		v.OpenDoor(Trunk, false, false);

                //	}

                //	break;

                //case Keys.NumPad4:

                //	if (v.IsDoorOpen(FrontleftDoor) == true)
                //	{

                //		v.CloseDoor(FrontleftDoor, false);

                //	}
                //	else
                //	{
                //		v.OpenDoor(FrontleftDoor, false, false);

                //	}

                //	break;

                //case Keys.NumPad6:

                //	if (v.IsDoorOpen(FrontrightDoor) == true)
                //	{

                //		v.CloseDoor(FrontrightDoor, false);

                //	}
                //	else
                //	{
                //		v.OpenDoor(FrontrightDoor, false, false);

                //	}

                //	break;

                //case Keys.NumPad7:

                //	if (v.IsDoorOpen(BackleftDoor) == true)
                //	{

                //		v.CloseDoor(BackleftDoor, false);

                //	}
                //	else
                //	{
                //		v.OpenDoor(BackleftDoor, false, false);

                //	}

                //	break;

                //case Keys.NumPad9:

                //	if (v.IsDoorOpen(BackrightDoor) == true)
                //	{

                //		v.CloseDoor(BackrightDoor, false);

                //	}
                //	else
                //	{
                //		v.OpenDoor(BackrightDoor, false, false);

                //	}

                //	break;

                //case Keys.NumPad0:

                //	if (v.EngineRunning == false)
                //	{

                //		v.EngineRunning = true;

                //	}
                //	else
                //	{

                //		v.EngineRunning = false;

                //	}

                //	break;

                //case Keys.Divide:

                //	if (!(v.IsNeonLightsOn(VehicleNeonLight.Back) || v.IsNeonLightsOn(VehicleNeonLight.Front) || v.IsNeonLightsOn(VehicleNeonLight.Left) || v.IsNeonLightsOn(VehicleNeonLight.Right)))
                //	{

                //		v.SetNeonLightsOn(VehicleNeonLight.Back, true);
                //		v.SetNeonLightsOn(VehicleNeonLight.Front, true);
                //		v.SetNeonLightsOn(VehicleNeonLight.Left, true);
                //		v.SetNeonLightsOn(VehicleNeonLight.Right, true);

                //	}
                //	else
                //	{

                //		v.SetNeonLightsOn(VehicleNeonLight.Back, false);
                //		v.SetNeonLightsOn(VehicleNeonLight.Front, false);
                //		v.SetNeonLightsOn(VehicleNeonLight.Left, false);
                //		v.SetNeonLightsOn(VehicleNeonLight.Right, false);

                //	}

                //	break;

                //case Keys.NumPad1:

                //	//Change Plate

                //	v.NumberPlate = "C  SHARP";

                //	break;

                //case Keys.NumPad3:

                //	if (v.Driver.CanFlyThroughWindscreen == false)
                //	{

                //		v.Driver.CanFlyThroughWindscreen = true;
                //		UI.Notify("CanFlyThroughWindscreen = true");

                //	}
                //	else if (v.Driver.CanFlyThroughWindscreen == true)
                //	{

                //		v.Driver.CanFlyThroughWindscreen = false;
                //		UI.Notify("CanFlyThroughWindscreen = false");

                //	}

                //	break;
                #endregion
                      
            }

        }

    }

}
