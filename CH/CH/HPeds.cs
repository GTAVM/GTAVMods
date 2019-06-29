using GTA;
using GTA.Math;
using GTA.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH
{
    public class HPeds : Script
    {
        static int countCompanions = 0;

        public static void SpawnEnemyPed(string model_name = "ig_bride")
        {
            //Spawn the model
            Ped companion = CreatePedByName(model_name);

            //Set ped properties
            companion.Armor = 50000;
            companion.Health = 50000;
            companion.MaxHealth = 50000;
            companion.IsEnemy = true;
            companion.IsPriorityTargetForEnemies = true;
            companion.RelationshipGroup = 5;
            companion.CanBeShotInVehicle = true;
            companion.AlwaysDiesOnLowHealth = false;

            //Give a Weapon to ped

            //Rifle
            companion.Weapons.Give(WeaponHash.AdvancedRifle, 500, false, true);

            //Colt
            companion.Weapons.Give(WeaponHash.APPistol, 500, false, true);

            //Parachute
            companion.Weapons.Give(WeaponHash.Parachute, 1, true, true);

            //KnifeHouse

            companion.Weapons.Give(WeaponHash.Knife, 1, false, true);

            //Set ped into vehicle

            companion.SetIntoVehicle(Game.Player.Character.CurrentVehicle, VehicleSeat.Any);
        }

        public static void ChangePlayerVisibility()
        {
            Game.Player.Character.IsVisible = !Game.Player.Character.IsVisible;
            Messages.PrintText("change visibility", 10000);
        }

        public static void SET_BLOCKING_OF_NON_TEMPORARY_EVENTS()
        {
            Ped[] nearByPeople = World.GetNearbyPeds(Game.Player.Character, 10000);//400
            for (int i = 0; i < nearByPeople.Length; i++)
            {
                Function.Call(Hash.SET_BLOCKING_OF_NON_TEMPORARY_EVENTS, nearByPeople[i], 1);
            }
        }

        public static void PedDrunk(Ped ped)
        {
            if (!Function.Call<bool>(Hash.HAS_CLIP_SET_LOADED, new InputArgument[] { "move_m@drunk@verydrunk" }))
                Function.Call(Hash.REQUEST_CLIP_SET, new InputArgument[]
                { "move_m@drunk@verydrunk" });

            if (Function.Call<bool>(Hash.HAS_CLIP_SET_LOADED, new InputArgument[] { "move_m@drunk@verydrunk" }))
                Function.Call(Hash.SET_PED_MOVEMENT_CLIPSET, new InputArgument[]
                {ped.Handle,"move_m@drunk@verydrunk", 1048576000});
        }

        public static void StopPedSpeaking(Ped ped)
        {
            Function.Call(Hash.STOP_PED_SPEAKING, new InputArgument[] { ped.Handle, true });
        }

        public static void DisablePedPainAudio(Ped ped)
        {
            Function.Call(Hash.DISABLE_PED_PAIN_AUDIO, new InputArgument[] { ped.Handle, true });
        }

        public static void PedDamage_BigHitByVehicle(Ped ped)
        {
            Function.Call(Hash.APPLY_PED_DAMAGE_PACK, ped, "BigHitByVehicle", 0.0, 9.0);
        }

        public static void PedDamage_SCR_Dumpster(Ped ped)
        {
            Function.Call(Hash.APPLY_PED_DAMAGE_PACK, ped, "SCR_Dumpster", 0.0, 9.0);
        }

        public static void PedDamage_SCR_Torture(Ped ped)
        {
            Function.Call(Hash.APPLY_PED_DAMAGE_PACK, ped, "SCR_Torture", 0.0, 9.0);
        }

        public static void PedDamageHeavy(Ped ped)
        {
            Function.Call(Hash.APPLY_PED_DAMAGE_PACK, ped, "BigHitByVehicle", 0.0, 9.0);
            Function.Call(Hash.APPLY_PED_DAMAGE_PACK, ped, "SCR_Dumpster", 0.0, 9.0);
            Function.Call(Hash.APPLY_PED_DAMAGE_PACK, ped, "SCR_Torture", 0.0, 9.0);
        }

        static List<Ped> group_members = new List<Ped>();
        /// <summary>
        /// Create or Kill Dogs:
        /// If param createOrKillDogs = true, creation a Dog, otherwise killing Dog.
        /// </summary>
        /// <param name="createOrKillDogs"></param>
        /// <param name="maxCompanions"></param>
        public static void Dogs(bool createOrKillDogs = true, int maxCompanions = 0)
        {
            List<string> model_names = new List<string>
            {
                "a_c_husky",
                "a_c_retriever",
                "a_c_rottweiler",
                "a_c_shepherd"
            };

            int max_companions = maxCompanions;

            if (maxCompanions == 0)
            {
                max_companions = countCompanions++;
            }

            if (createOrKillDogs && group_members.Count < max_companions)
            {
                Ped player = Game.Player.Character;
                Vector3 spawnLoc = player.Position + (player.ForwardVector * 5);
                Random rnd = new Random();
                Ped companion = World.CreatePed(model_names[rnd.Next(0, model_names.Count - 1)], spawnLoc);
                group_members.Add(companion);

                int player_group = Function.Call<int>(Hash.GET_PED_GROUP_INDEX,
                    player.CurrentPedGroup);

                Function.Call(Hash.SET_PED_AS_GROUP_MEMBER, companion.CurrentPedGroup,
                    player_group);

                companion.Task.ClearAllImmediately();
                Function.Call(Hash.TASK_COMBAT_HATED_TARGETS_IN_AREA, companion, 50000, 0);
                Function.Call(Hash.SET_PED_KEEP_TASK, companion, true);

                companion.MarkAsNoLongerNeeded();
            }

            if (!createOrKillDogs && group_members.Count != 0)
            {
                group_members[group_members.Count - 1].Kill();
                group_members.RemoveAt(group_members.Count - 1);
            }
        }
        public static Ped CreatePedByName(string modelName, float forwardVector = 5)
        {
            //Model Spawn location
            Vector3 spawnloc = Game.Player.Character.Position +
                (Game.Player.Character.ForwardVector * forwardVector);

            //Spawn the model
            return World.CreatePed(modelName, spawnloc);
        }
        public static Ped CreatePed(PedHash model, float forwardVector = 5)
        {
            //Model Spawn location
            Vector3 spawnloc = Game.Player.Character.Position +
                (Game.Player.Character.ForwardVector * forwardVector);

            //Spawn the model
            return World.CreatePed(model, spawnloc);
        }

        public static void SpawnRandomPeds(float distance = 100f)
        {
            Vector3 SpawnPoint = new Vector3();
            Random rnd = new Random();

            for (int i = 0; i < rnd.Next(1, 9); i++)
            {
                if (Function.Call<bool>(Hash.CAN_CREATE_RANDOM_PED))
                {
                    if (i == 0)
                    {
                        SpawnPoint = Game.Player.Character.Position.Around(distance);
                    }
                    else
                    {
                        SpawnPoint = SpawnPoint.Around(3);
                    }
                    SpawnPoint.Z = World.GetGroundHeight(SpawnPoint); SpawnPoint.Z += 0.9f;
                    Ped RandPed = World.CreateRandomPed(SpawnPoint);
                    RandPed.AddBlip().Color = BlipColor.White; // For test
                    RandPed.MarkAsNoLongerNeeded();
                    RandPed.Task.RunTo(Game.Player.Character.Position);
                    RandPed.Task.FightAgainst(Game.Player.Character);
                }
                Wait(0);
            }
        }
    }
}
