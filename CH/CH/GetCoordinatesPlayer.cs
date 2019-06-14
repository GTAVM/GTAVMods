using GTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CH
{
    public  class GetCoordinatesPlayer
    {
        static Ped player = Game.Player.Character;
        static string fold = AppDomain.CurrentDomain.BaseDirectory.ToString();

        #region comments
        public GetCoordinatesPlayer()
        {
            //Tick += OnTick; // Main loop event, called every few milliseconds specified via the Interval property.
            //KeyDown += OnKeyDown; // Called when a key or mouse button is pressed.
            //Interval = 10; // Tick interval in milliseconds. Set to zero to run as fast as possible.
        }

        //void OnTick(object sender, EventArgs e)
        //{
        //	player = Game.Player.Character;
        //}
        #endregion

        public static void Report()
        {
            try
            {
                string details = Game.GetUserInput("Enter Details:\n", 200);
                System.IO.StreamWriter file = new System.IO.StreamWriter(fold + @"\CoordReport.txt", true);
                string COORDS = "new Vector3(" + player.Position.X + "f, " + player.Position.Y + "f, " + player.Position.Z + "f) Heading = " + player.Heading + "f";

                Regex regex = new Regex(@"\d,");
                COORDS = regex.Replace(COORDS, "0.");


                file.WriteLine();
                file.WriteLine(details);
                file.WriteLine(COORDS);
                file.Close();
                UI.ShowSubtitle(COORDS, 10000);
            }
            catch (Exception ex)
            {
                UI.ShowSubtitle(ex.Message);
            }
        }
    }
}
