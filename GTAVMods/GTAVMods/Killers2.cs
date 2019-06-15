using GTA;
using GTA.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAVMods
{
	class Killers2
	{
		public static void Spawn()
		{
			//Player
			Ped player = Game.Player.Character;

			//Model Spawn location
			GTA.Math.Vector3 spawnlocat = player.Position + (player.ForwardVector * 5);

            //Model name, in this case it's the random event Bride
            //string model_namespawn = "ig_bride"; //Bride ped 1633872967 ig_bride

			//Spawn the model
			Ped ped = GTA.World.CreatePed(PedHash.Stripper02SFY, spawnlocat);
			//Ped ped = GTA.World.CreatePed(model_namespawn, spawnlocat);

			//Set ped properties
			ped.Armor = 50000;
			ped.Health = 50000;
			ped.MaxHealth = 50000;
			ped.IsEnemy = false;
			ped.IsPriorityTargetForEnemies = true;
			ped.RelationshipGroup = (int)Relationship.Companion;
			ped.CanBeShotInVehicle = true;
			ped.AlwaysDiesOnLowHealth = false;

			//Follow Player
			//Call Native Function
			int playerG = GTA.Native.Function.Call<int>(GTA.Native.Hash.GET_PED_GROUP_INDEX,
				Game.Player.Character.Handle);
			GTA.Native.Function.Call(GTA.Native.Hash.SET_PED_AS_GROUP_MEMBER, ped.Handle, playerG);

			//Give a Weapon to ped

			//Rifle
			ped.Weapons.Give(WeaponHash.AdvancedRifle, 500, false, true);

			//Colt
			ped.Weapons.Give(WeaponHash.APPistol, 500, false, true);

			//Parachute
			ped.Weapons.Give(WeaponHash.Parachute, 1, true, true);

			//KnifeHouse

			ped.Weapons.Give(WeaponHash.Knife, 1, false, true);

			//Set ped into vehicle

			if (player.IsInVehicle())
			{
				ped.SetIntoVehicle(Game.Player.Character.CurrentVehicle, VehicleSeat.Any);
			}
			UI.Notify("Killers2 Spawn...");
		}
	}
}
