using GTA;
using GTA.Math;
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CH
{
    [Serializable]
    public class Vector3XmlSerializer : Script
    {
        static string fold = AppDomain.CurrentDomain.BaseDirectory.ToString();
        private static int count = 1;
                
        public static void Serialize()
        {
            Vector3 playerVector3 = Game.Player.Character.Position;
            // передаем в конструктор тип класса
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Vector3));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream(fold + @"\PlayerVector3.xml", FileMode.Append))
            {
                xmlSerializer.Serialize(fs, playerVector3);
                UI.ShowSubtitle(playerVector3.ToString());
            }
            string text = File.ReadAllText(fold + @"\PlayerVector3.xml", Encoding.UTF8);
            File.Delete(fold + @"\PlayerVector3.xml");
            StreamWriter file = new StreamWriter(fold + @"\Vector3.xml", true);
            text = text.Replace(" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"", "");
            text = text.Replace("<?xml version=\"1.0\"?>", "");
            string coords = text.Trim();
            file.WriteLine(coords);
            file.Close();
            UI.Notify("File Write: ~b~" + count++.ToString());
        }
    }
}
