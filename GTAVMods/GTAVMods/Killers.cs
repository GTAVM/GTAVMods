using GTA;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA.Native;
using GTA.Math;

namespace GTAVMods
{
	public class Killers : Script
	{
		int _groupIndex;
		Ped _killer;
		static bool killers;

		public Killers()
		{
			_groupIndex = World.AddRelationshipGroup("player");
			Game.Player.Character.RelationshipGroup = _groupIndex;

			KeyDown += KillerScript_KeyDown;
		}

		public static void Spawn()
		{
			killers = true;
		}

		private void KillerScript_KeyDown(object sender, KeyEventArgs e)
		{
			Vector3 playerForward = Game.Player.Character.Position +
			Game.Player.Character.ForwardVector * 4;

			Entity target = Game.Player.GetTargetedEntity();
			Ped targetPed = target as Ped;

			if (killers)
			{
				UI.Notify("Прицелиться по цели и нажать E.");
				UI.Notify("Позвать - T.");
		
				_killer = World.CreatePed(PedHash.Stripper02SFY, playerForward);
				_killer.RelationshipGroup = _groupIndex;
				_killer.Weapons.Give(WeaponHash.RPG, 20, true, false);
				_killer.IsInvincible = true;
			}

			if (e.KeyCode == Keys.E && target != null &&
			   targetPed != null)
			{
				_killer.Task.AimAt(target, 200);
				_killer.Task.FightAgainst(targetPed, 20000);
			}

			if (e.KeyCode == Keys.T)
			{

				_killer.Task.GoTo(playerForward);
			}

			killers = false;
		}
	}
}
