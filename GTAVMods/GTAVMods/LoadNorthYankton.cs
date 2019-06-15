//using GTA;
//using GTA.Native;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;

//namespace GTAVMods
//{
//	class LoadNorthYankton : Script
//	{
//		public LoadNorthYankton()
//		{
//			KeyDown += LoadNorthYankton_KeyDown;
//		}

//		private void LoadNorthYankton_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
//		{
//			String fileName = "/ipl.txt";

//			string folder = AppDomain.CurrentDomain.BaseDirectory.ToString();

//			FileStream stream = new FileStream(folder + fileName, FileMode.Open);
//			StreamReader reader = new StreamReader(stream, Encoding.Default);
//			String str = reader.ReadToEnd();
//			stream.Close();

//			String pattern = @"\s+";
//			String[] wordList = Regex.Split(str, pattern);

//			if (e.KeyCode == System.Windows.Forms.Keys.I)
//			{
								
//				foreach (string item in wordList)
//				{
//					Function.Call(Hash.REQUEST_IPL, item);
//					UI.Notify("Load - " + item);
//				}

//				#region old code
//				//Function.Call(Hash.REQUEST_IPL, "plg_01");
//				//Function.Call(Hash.REQUEST_IPL, "prologue01");
//				//Function.Call(Hash.REQUEST_IPL, "prologue01k");
//				//Function.Call(Hash.REQUEST_IPL, "prologue01k_lod");
//				//Function.Call(Hash.REQUEST_IPL, "prologue01z");
//				//Function.Call(Hash.REQUEST_IPL, "prologue01z_lod");
//				//Function.Call(Hash.REQUEST_IPL, "prologue01_lod");
//				//Function.Call(Hash.REQUEST_IPL, "prologue01c");
//				//Function.Call(Hash.REQUEST_IPL, "prologue01c_lod");
//				//Function.Call(Hash.REQUEST_IPL, "prologue01d");
//				//Function.Call(Hash.REQUEST_IPL, "prologue01d_lod");
//				//Function.Call(Hash.REQUEST_IPL, "prologue01e");
//				//Function.Call(Hash.REQUEST_IPL, "prologue01e_lod");
//				//Function.Call(Hash.REQUEST_IPL, "prologue01f");
//				//Function.Call(Hash.REQUEST_IPL, "prologue01f_lod");
//				//Function.Call(Hash.REQUEST_IPL, "prologue01g");
//				//Function.Call(Hash.REQUEST_IPL, "prologue01h");
//				//Function.Call(Hash.REQUEST_IPL, "prologue01h_lod");
//				//Function.Call(Hash.REQUEST_IPL, "prologue01i");
//				//Function.Call(Hash.REQUEST_IPL, "prologue01i_lod");
//				//Function.Call(Hash.REQUEST_IPL, "prologue01j");
//				//Function.Call(Hash.REQUEST_IPL, "prologue01j_lod");
//				//Function.Call(Hash.REQUEST_IPL, "plg_02");
//				//Function.Call(Hash.REQUEST_IPL, "prologue02");
//				//Function.Call(Hash.REQUEST_IPL, "prologue02_lod");
//				//Function.Call(Hash.REQUEST_IPL, "plg_03");
//				//Function.Call(Hash.REQUEST_IPL, "prologue03");
//				//Function.Call(Hash.REQUEST_IPL, "prologue03_lod");
//				//Function.Call(Hash.REQUEST_IPL, "prologue03b");
//				//Function.Call(Hash.REQUEST_IPL, "prologue03b_lod");
//				////the commented code disables the 'Prologue' grave and
//				////enables the 'Bury the Hatchet' grave
//				//Function.Call(Hash.REQUEST_IPL, "prologue03_grv_cov"); // was be comment
//				//Function.Call(Hash.REQUEST_IPL, "prologue03_grv_cov_lod"); // was be comment
//				//Function.Call(Hash.REQUEST_IPL, "prologue03_grv_dug");
//				//Function.Call(Hash.REQUEST_IPL, "prologue03_grv_dug_lod");
//				//Function.Call(Hash.REQUEST_IPL, "prologue03_grv_fun"); // was be comment
//				//Function.Call(Hash.REQUEST_IPL, "prologue_grv_torch");
//				//Function.Call(Hash.REQUEST_IPL, "plg_04");
//				//Function.Call(Hash.REQUEST_IPL, "prologue04");
//				//Function.Call(Hash.REQUEST_IPL, "prologue04_lod");
//				//Function.Call(Hash.REQUEST_IPL, "prologue04b");
//				//Function.Call(Hash.REQUEST_IPL, "prologue04b_lod");
//				//Function.Call(Hash.REQUEST_IPL, "prologue04_cover");
//				//Function.Call(Hash.REQUEST_IPL, "des_protree_end");
//				//Function.Call(Hash.REQUEST_IPL, "des_protree_start");
//				//Function.Call(Hash.REQUEST_IPL, "des_protree_start_lod");
//				//Function.Call(Hash.REQUEST_IPL, "plg_05");
//				//Function.Call(Hash.REQUEST_IPL, "prologue05");
//				//Function.Call(Hash.REQUEST_IPL, "prologue05_lod");
//				//Function.Call(Hash.REQUEST_IPL, "prologue05b");
//				//Function.Call(Hash.REQUEST_IPL, "prologue05b_lod");
//				//Function.Call(Hash.REQUEST_IPL, "plg_06");
//				//Function.Call(Hash.REQUEST_IPL, "prologue06");
//				//Function.Call(Hash.REQUEST_IPL, "prologue06_lod");
//				//Function.Call(Hash.REQUEST_IPL, "prologue06b");
//				//Function.Call(Hash.REQUEST_IPL, "prologue06b_lod");
//				//Function.Call(Hash.REQUEST_IPL, "prologue06_int");
//				//Function.Call(Hash.REQUEST_IPL, "prologue06_int_lod");
//				//Function.Call(Hash.REQUEST_IPL, "prologue06_pannel");
//				//Function.Call(Hash.REQUEST_IPL, "prologue06_pannel_lod");
//				//Function.Call(Hash.REQUEST_IPL, "prologue_m2_door");
//				//Function.Call(Hash.REQUEST_IPL, "prologue_m2_door_lod");
//				//Function.Call(Hash.REQUEST_IPL, "plg_occl_00");
//				//Function.Call(Hash.REQUEST_IPL, "prologue_occl");
//				//Function.Call(Hash.REQUEST_IPL, "plg_rd");
//				//Function.Call(Hash.REQUEST_IPL, "prologuerd");
//				//Function.Call(Hash.REQUEST_IPL, "prologuerdb");
//				//Function.Call(Hash.REQUEST_IPL, "prologuerd_lod");
//				#endregion

//				UI.Notify("North Yankton Loaded");
//			}
//			if (e.KeyCode == System.Windows.Forms.Keys.U)
//			{
//				foreach (string item in wordList)
//				{
//					Function.Call(Hash.REMOVE_IPL, item);
//					UI.Notify("Unload - " + item);
//				}
//				UI.Notify("North Yankton Unloaded");
//			}
//		}
//	}
//}
