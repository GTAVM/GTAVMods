using GTA;
using GTA.Native;

namespace CH
{
    public class IPL : Script
    {
        public static void BahamaMamasTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(-1390f, -585f, 29f);
            //Game.Player.Character.Position = new GTA.Math.Vector3(-1388.0013427734375f, -618.419677734375f, 30.819599151611328f/*-1390f, -585f, 29f*/);
        }
        public static void BahamaMamasLoad()
        {
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -1388.0013427734375, -618.419677734375, 30.819599151611328), false);
            Function.Call(Hash.REQUEST_IPL, "v_bahama");

            Game.Player.Character.Position = new GTA.Math.Vector3(-1388.0013427734375f, -618.419677734375f, 30.819599151611328f/*-1390f, -585f, 29f*/);

            UI.Notify("BahamaMamasLoad");
        }
        public static void BahamaMamasUnload()
        {
            BahamaMamasTeleport();

            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -1388.0013427734375, -618.419677734375, 30.819599151611328), true);
            Function.Call(Hash.REMOVE_IPL, "v_bahama");


            UI.Notify("BahamaMamasUnload");
        }
        public static void ChopshopTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(488.0567932128906f, -1310.8253173828125f, 28.2038f);
        }
        public static void ChopshopLoad()
        {
            Function.Call(Hash.CAP_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 479.0567932128906f, -1316.8253173828125f, 28.2038f), false);
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 479.0567932128906f, -1316.8253173828125f, 28.2038f), false);
            Function.Call(Hash.REQUEST_IPL, "v_chopshop");
            Function.Call(Hash.UNPIN_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 479.0567932128906f, -1316.8253173828125f, 28.2038f));
            Function.Call(Hash._DOOR_CONTROL, -664582244, 482.8112f, -1311.953f, 29.35057f, true, 0.0f, 0.0f, -1.0f);
            Function.Call(Hash._DOOR_CONTROL, -190780785, 484.5652f, -1315.574f, 30.20331f, true, 0.0f, 0.0f, 0.0f);

            UI.Notify("ChopshopLoad");
        }
        public static void ChopshopUnload()
        {
            Function.Call(Hash.CAP_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 479.0567932128906f, -1316.8253173828125f, 28.2038f), true);
            Function.Call(Hash.REMOVE_IPL, "v_chopshop");

            UI.Notify("ChopshopUnload");
        }
        public static void CluckinBellTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(-75.49429f, 6270.23f, 30.49062f/*-140.9572f, 6200.716f, 30.23358f*/);

        }
        public static void CluckinBellLoad()
        {
            Function.Call(Hash.REQUEST_IPL, "CS1_02_cf_onmission1");
            Function.Call(Hash.REQUEST_IPL, "CS1_02_cf_onmission2");
            Function.Call(Hash.REQUEST_IPL, "CS1_02_cf_onmission3");
            Function.Call(Hash.REQUEST_IPL, "CS1_02_cf_onmission4");
            Function.Call(Hash.REMOVE_IPL, "CS1_02_cf_offmission");

            //Game.Player.Character.Position = new GTA.Math.Vector3(-146.3837f, 6161.5f, 30.2062f);

            UI.Notify("CluckinBellLoad");
        }
        public static void CluckinBellUnload()
        {
            //CluckinBellTeleport();

            Function.Call(Hash.REMOVE_IPL, "CS1_02_cf_onmission1");
            Function.Call(Hash.REMOVE_IPL, "CS1_02_cf_onmission2");
            Function.Call(Hash.REMOVE_IPL, "CS1_02_cf_onmission3");
            Function.Call(Hash.REMOVE_IPL, "CS1_02_cf_onmission4");
            Function.Call(Hash.REQUEST_IPL, "CS1_02_cf_offmission");

            UI.Notify("CluckinBellUnload");
        }
        public static void ComedyClubTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(-430.4833068847656f, 255.3197021484375f, 82f);
        }
        public static void ComedyClubLoad()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(-447.4833068847656f, 280.3197021484375f, 77.52149963378906f);

            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -447.4833068847656, 280.3197021484375, 77.52149963378906), false);
            Function.Call(Hash.REQUEST_IPL, "v_comedy");

            UI.Notify("ComedyClubLoad");
        }
        public static void ComedyClubUnload()
        {
            ComedyClubTeleport();

            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -447.4833068847656, 280.3197021484375, 77.52149963378906), true);
            Function.Call(Hash.REMOVE_IPL, "v_comedy");

            UI.Notify("ComedyClubUnload");
        }
        public static void FameOrShameStadiumTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(-230.4916f, -2040.509f, 27.0f);
        }
        public static void FameOrShameStadiumLoad()
        {
            Function.Call(Hash.REMOVE_IPL, "sp1_10_fake_interior");
            Function.Call(Hash.REMOVE_IPL, "sp1_10_fake_interior_lod");
            Function.Call(Hash.REQUEST_IPL, "sp1_10_real_interior");
            Function.Call(Hash.REQUEST_IPL, "sp1_10_real_interior_lod");

            UI.Notify("FameOrShameStadiumLoad");
        }
        public static void FameOrShameStadiumUnload()
        {
            //FameOrShameStadiumTeleport();

            Function.Call(Hash.REMOVE_IPL, "sp1_10_real_interior");
            Function.Call(Hash.REMOVE_IPL, "sp1_10_real_interior_lod");
            Function.Call(Hash.REQUEST_IPL, "sp1_10_fake_interior");
            Function.Call(Hash.REQUEST_IPL, "sp1_10_fake_interior_lod");

            UI.Notify("FameOrShameStadiumUnload");
        }
        public static void FIBLobbyTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(100.3793f, -743.6982f, 44.51962f);
        }
        public static void FIBLobbyLoad()
        {
            Function.Call(Hash.REQUEST_IPL, "FIBlobby");
            Function.Call(Hash.REMOVE_IPL, "FIBlobbyfake");
            Function.Call(Hash._DOOR_CONTROL, -1517873911, 106.3793f, -742.6982f, 46.51962f, false, 0.0f, 0.0f, 0.0f);
            Function.Call(Hash._DOOR_CONTROL, -90456267, 105.7607f, -746.646f, 46.18266f, false, 0.0f, 0.0f, 0.0f);

            UI.Notify("FIBLobbyLoad");
        }
        public static void FIBLobbyUnload()
        {
            Function.Call(Hash.REQUEST_IPL, "FIBlobbyfake");
            Function.Call(Hash.REMOVE_IPL, "FIBlobby");
            Function.Call(Hash._DOOR_CONTROL, -1517873911, 106.3793f, -742.6982f, 46.51962f, true, 0.0f, 0.0f, 0.0f);
            Function.Call(Hash._DOOR_CONTROL, -90456267, 105.7607f, -746.646f, 46.18266f, true, 0.0f, 0.0f, 0.0f);

            UI.Notify("FIBLobbyUnload");
        }
        public static void FoundryTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(1084.547f, -1972.435f, 30f);
        }
        public static void FoundryLoad()
        {
            Function.Call(Hash.CAP_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 1087.1951904296875, -1988.4449462890625, 28.649), false);
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 1087.1951904296875, -1988.4449462890625, 28.649), false);
            Function.Call(Hash.REQUEST_IPL, "v_foundry");
            Function.Call(Hash._DOOR_CONTROL, -1428622127, 1083.547f, -1975.435f, 31.62222f, true, 0.0f, 0.0f, -1.0f);
            Function.Call(Hash._DOOR_CONTROL, -1428622127, 1085.307f, -2018.561f, 41.62894f, true, 0.0f, 0.0f, 1.0f);


            UI.Notify("FoundryLoad");
        }
        public static void FoundryUnload()
        {
            Function.Call(Hash.CAP_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 1087.1951904296875, -1988.4449462890625, 28.649), true);
            //Door error
            //Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 1087.1951904296875, -1988.4449462890625, 28.649), true); 
            Function.Call(Hash.REMOVE_IPL, "v_foundry");
            Function.Call(Hash._DOOR_CONTROL, -1428622127, 1083.547f, -1975.435f, 31.62222f, true, 0.0f, 0.0f, 0.0f);
            Function.Call(Hash._DOOR_CONTROL, -1428622127, 1085.307f, -2018.561f, 41.62894f, true, 0.0f, 0.0f, 0.0f);

            UI.Notify("FoundryUnload");
        }
        public static void FloydsHouseTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(-1149.709f, -1521.088f, 10.78267f);
        }
        public static void FloydsHouseLoad()
        {
            Function.Call(Hash.REMOVE_IPL, "vb_30_crimetape");
            Function.Call(Hash._DOOR_CONTROL, -607040053, -1149.709f, -1521.088f, 10.78267f, false, 0.0f, 0.0f, 0.0f);

            UI.Notify("FloydsHouseLoad");
        }
        public static void FloydsHouseUnload()
        {
            Function.Call(Hash.REQUEST_IPL, "vb_30_crimetape");
            Function.Call(Hash._DOOR_CONTROL, -607040053, -1149.709f, -1521.088f, 10.78267f, true, 0.0f, 0.0f, 0.0f);

            UI.Notify("FloydsHouseUnload");
        }
        public static void EpsilonTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(241.3621f, 361.0471f, 105.8883f);
        }
        public static void EpsilonLoad()
        {
            Function.Call(Hash.CAP_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 245.15640258789062, 370.21099853515625, 104.73819732666016), false);
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 245.15640258789062, 370.21099853515625, 104.73819732666016), false);
            Function.Call(Hash.REQUEST_IPL, "v_epsilonism");
            Function.Call(Hash._DOOR_CONTROL, -1230442770, 241.3621f, 361.0471f, 105.8883f, false, 0.0f, 0.0f, 0.0f);

            UI.Notify("EpsilonLoad");
        }
        public static void EpsilonUnload()
        {
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 245.15640258789062, 370.21099853515625, 104.73819732666016), true);
            Function.Call(Hash.REMOVE_IPL, "v_epsilonism");
            Function.Call(Hash._DOOR_CONTROL, -1230442770, 241.3621f, 361.0471f, 105.8883f, true, 0.0f, 0.0f, 0.0f);

            UI.Notify("EpsilonUnload");
        }
        public static void EpsilonTeleport2()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(241.3621f, 361.0471f, 105.8883f);
        }
        public static void EpsilonLoad2()
        {
            Function.Call(Hash.CAP_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 245.15640258789062, 370.21099853515625, 104.73819732666016), false);
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 245.15640258789062, 370.21099853515625, 104.73819732666016), false);
            Function.Call(Hash._0x2CA429C029CCF247, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 245.15640258789062, 370.21099853515625, 104.73819732666016));
            Function.Call(Hash.UNPIN_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 245.15640258789062, 370.21099853515625, 104.73819732666016));
            Function.Call(Hash._DOOR_CONTROL, -1230442770, 241.3621f, 361.0471f, 105.8883f, false, 0.0f, 0.0f, 0.0f);

            UI.Notify("EpsilonLoad2");
        }
        public static void EpsilonUnload2()
        {
            Function.Call(Hash.CAP_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 245.15640258789062, 370.21099853515625, 104.73819732666016), true);
            Function.Call(Hash._DOOR_CONTROL, -1230442770, 241.3621f, 361.0471f, 105.8883f, true, 0.0f, 0.0f, 0.0f);

            UI.Notify("EpsilonUnload2");
        }
        public static void HospitalInteriorTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(330.4596f, -584.8196f, 42.3174f);
        }
        public static void HospitalNormalTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(290.7717f, -580.9828f, 42.26085f);
        }
        public static void HospitalNormalLoad()
        {
            Function.Call(Hash.REMOVE_IPL, "RC12B_Destroyed");
            Function.Call(Hash.REMOVE_IPL, "RC12B_HospitalInterior");
            Function.Call(Hash.REMOVE_IPL, "RC12B_Default");
            Function.Call(Hash.REMOVE_IPL, "RC12B_Fixed");
            Function.Call(Hash.REQUEST_IPL, "RC12B_Default");//state 1 normal

            UI.Notify("HospitalNormalLoad");
        }
        public static void HospitalNormalUnload()
        {
            Function.Call(Hash.REQUEST_IPL, "RC12B_Destroyed");
            Function.Call(Hash.REQUEST_IPL, "RC12B_HospitalInterior");
            Function.Call(Hash.REQUEST_IPL, "RC12B_Default");
            Function.Call(Hash.REQUEST_IPL, "RC12B_Fixed");
            Function.Call(Hash.REMOVE_IPL, "RC12B_Default");//state 1 normal

            UI.Notify("HospitalNormalUnload");
        }
        public static void HospitalDestroyedLoad()
        {
            Function.Call(Hash.REMOVE_IPL, "RC12B_Destroyed");
            Function.Call(Hash.REMOVE_IPL, "RC12B_HospitalInterior");
            Function.Call(Hash.REMOVE_IPL, "RC12B_Default");
            Function.Call(Hash.REMOVE_IPL, "RC12B_Fixed");
            Function.Call(Hash.REQUEST_IPL, "RC12B_Destroyed");//state 3 1of2
            Function.Call(Hash.REQUEST_IPL, "RC12B_HospitalInterior");//state 3 2of2 Destroyed Interior

            UI.Notify("HospitalDestroyedLoad");
        }
        public static void HospitalDestroyedUnload()
        {
            Function.Call(Hash.REQUEST_IPL, "RC12B_Destroyed");
            Function.Call(Hash.REQUEST_IPL, "RC12B_HospitalInterior");
            Function.Call(Hash.REQUEST_IPL, "RC12B_Default");
            Function.Call(Hash.REQUEST_IPL, "RC12B_Fixed");
            Function.Call(Hash.REMOVE_IPL, "RC12B_Destroyed");//state 3 1of2
            Function.Call(Hash.REMOVE_IPL, "RC12B_HospitalInterior");//state 3 2of2 Destroyed Interior

            UI.Notify("HospitalDestroyedUnload");
        }
        public static void HospitalBoardedUpLoad()
        {
            Function.Call(Hash.REMOVE_IPL, "RC12B_Destroyed");
            Function.Call(Hash.REMOVE_IPL, "RC12B_HospitalInterior");
            Function.Call(Hash.REMOVE_IPL, "RC12B_Default");
            Function.Call(Hash.REMOVE_IPL, "RC12B_Fixed");
            Function.Call(Hash.REQUEST_IPL, "RC12B_Fixed");//state 2 boarded up

            UI.Notify("HospitalBoardedUpLoad");
        }
        public static void HospitalBoardedUpUnload()
        {
            Function.Call(Hash.REQUEST_IPL, "RC12B_Destroyed");
            Function.Call(Hash.REQUEST_IPL, "RC12B_HospitalInterior");
            Function.Call(Hash.REQUEST_IPL, "RC12B_Default");
            Function.Call(Hash.REQUEST_IPL, "RC12B_Fixed");
            Function.Call(Hash.REMOVE_IPL, "RC12B_Fixed");//state 2 boarded up

            UI.Notify("HospitalBoardedUpUnload");
        }
        public static void JanitorTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(-107.5373f, -9.018099f, 70.67085f);
        }
        public static void JanitorLoad()
        {
            Function.Call(Hash.REQUEST_IPL, "v_janitor");
            Function.Call(Hash._DOOR_CONTROL, 486670049, -107.5373f, -9.018099f, 70.67085f, false, 0.0f, 0.0f, 0.0f);

            UI.Notify("JanitorLoad");
        }
        public static void JanitorUnload()
        {
            Function.Call(Hash.REMOVE_IPL, "v_janitor");
            Function.Call(Hash._DOOR_CONTROL, 486670049, -107.5373f, -9.018099f, 70.67085f, true, 0.0f, 0.0f, 0.0f);

            UI.Notify("JanitorUnload");
        }
        public static void JewelStoreTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(-630.4f, -236.7f, 40.0f);
        }
        public static void JewelStoreLoad()
        {
            Function.Call(Hash.CAP_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -630.4, -236.7, 40.0), false);
            Function.Call(Hash.UNPIN_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -630.4, -236.7, 40.0));
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -630.4, -236.7, 40.0), false);
            Function.Call(Hash.REQUEST_IPL, "post_hiest_unload");
            Function.Call(Hash.REMOVE_IPL, "jewel2fake");
            Function.Call(Hash.REMOVE_IPL, "bh1_16_refurb");
            Function.Call(Hash._DOOR_CONTROL, 9467943, -630.4265f, -238.4375f, 38.20653f, true, 0.0f, 0.0f, 1.0f);
            Function.Call(Hash._DOOR_CONTROL, 1425919976, -631.9554f, -236.3333f, 38.20653f, true, 0.0f, 0.0f, -1.0f);

            UI.Notify("JewelStoreLoad");
        }
        public static void JewelStoreUnload()
        {
            Function.Call(Hash.REMOVE_IPL, "post_hiest_unload");
            Function.Call(Hash.REQUEST_IPL, "jewel2fake");
            Function.Call(Hash.REQUEST_IPL, "bh1_16_refurb");
            Function.Call(Hash._DOOR_CONTROL, 9467943, -630.4265f, -238.4375f, 38.20653f, true, 0.0f, 0.0f, 1.0f);
            Function.Call(Hash._DOOR_CONTROL, 1425919976, -631.9554f, -236.3333f, 38.20653f, true, 0.0f, 0.0f, -1.0f);

            UI.Notify("JewelStoreUnload");
        }
        public static void LabTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(3627.713f, 3746.716f, 27.69009f);
        }
        public static void LabElevatorTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(3540.65f, 3675.77f, 28.12f);
        }
        public static void LabElevator2Teleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(3540.65f, 3675.77f, 20.12f);
        }
        public static void LabLoad()
        {
            //elevator coords 3540.65f, 3675.77f, 28.12f
            //elevator2 coords 3540.65f, 3675.77f, 20.12f

            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 3522.84521484375, 3707.96533203125, 19.9918), false);
            Function.Call(Hash.REQUEST_IPL, "v_lab");
            Function.Call(Hash._DOOR_CONTROL, -1081024910, 3620.843f, 3751.527f, 27.69009f, false, 0.0f, 0.0f, -1.0f);
            Function.Call(Hash._DOOR_CONTROL, -1081024910, 3627.713f, 3746.716f, 27.69009f, false, 0.0f, 0.0f, -1.0f);

            UI.Notify("LabLoad");
        }
        public static void LabUnload()
        {
            Function.Call(Hash.REMOVE_IPL, "v_lab");
            Function.Call(Hash._DOOR_CONTROL, -1081024910, 3620.843f, 3751.527f, 27.69009f, true, 0.0f, 0.0f, -0.0f);
            Function.Call(Hash._DOOR_CONTROL, -1081024910, 3627.713f, 3746.716f, 27.69009f, true, 0.0f, 0.0f, -0.0f);

            UI.Notify("LabUnload");
        }
        public static void LifeInvaderTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(-1042.518f, -240.6915f, 38.11796f);
        }
        public static void LifeInvaderLoad()
        {
            Function.Call(Hash.REQUEST_IPL, "facelobby");  // lifeinvader
            Function.Call(Hash.REMOVE_IPL, "facelobbyfake");
            Function.Call(Hash._DOOR_CONTROL, -340230128, -1042.518, -240.6915, 38.11796, true, 0.0f, 0.0f, -1.0f);

            UI.Notify("LifeInvaderLoad");
        }
        public static void LifeInvaderUnload()
        {
            Function.Call(Hash.REMOVE_IPL, "facelobby");  // lifeinvader
            Function.Call(Hash.REQUEST_IPL, "facelobbyfake");
            Function.Call(Hash._DOOR_CONTROL, -340230128, -1042.518, -240.6915, 38.11796, true, 0.0f, 0.0f, 0.0f);

            UI.Notify("LifeInvaderUnload");
        }
        public static void LestersHouseTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(1273.816f, -1720.697f, 54.92143f);
        }
        public static void LestersHouseLoad()
        {
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 1274.933837890625, -1714.7255859375, 53.77149963378906), false);
            Function.Call(Hash.REQUEST_IPL, "v_lesters");
            Function.Call(Hash._DOOR_CONTROL, 1145337974, 1273.816f, -1720.697f, 54.92143f, false, 0.0f, 0.0f, 0.0f);

            UI.Notify("LestersHouseLoad");
        }
        public static void LestersHouseUnload()
        {
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 1274.933837890625, -1714.7255859375, 53.77149963378906), false);
            Function.Call(Hash.REMOVE_IPL, "v_lesters");
            Function.Call(Hash._DOOR_CONTROL, 1145337974, 1273.816f, -1720.697f, 54.92143f, true, 0.0f, 0.0f, 0.0f);

            UI.Notify("LestersHouseUnload");
        }
        public static void LestersFactoryTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(718.0f, -979.0f, 23.0f);
        }
        public static void LestersFactoryLoad()
        {
            Function.Call(Hash.REMOVE_IPL, "id2_14_during_door");
            Function.Call(Hash.REMOVE_IPL, "id2_14_during1");
            Function.Call(Hash.REMOVE_IPL, "id2_14_during2");
            Function.Call(Hash.REMOVE_IPL, "id2_14_on_fire");
            Function.Call(Hash.REMOVE_IPL, "id2_14_post_no_int");
            Function.Call(Hash.REMOVE_IPL, "id2_14_pre_no_int");
            Function.Call(Hash.REMOVE_IPL, "id2_14_during_door");
            Function.Call(Hash.REQUEST_IPL, "id2_14_during1");
            Function.Call(Hash._DOOR_CONTROL, 826072862, 717.0f, -975.0f, 25.0f, false, 0.0f, 0.0f, 0.0f);
            Function.Call(Hash._DOOR_CONTROL, 763780711, 719.0f, -975.0f, 25.0f, false, 0.0f, 0.0f, 0.0f);

            UI.Notify("LestersFactoryLoad");
        }
        public static void LestersFactoryUnload()
        {
            Function.Call(Hash.REMOVE_IPL, "id2_14_during_door");
            Function.Call(Hash.REMOVE_IPL, "id2_14_during1");
            Function.Call(Hash.REMOVE_IPL, "id2_14_during2");
            Function.Call(Hash.REMOVE_IPL, "id2_14_on_fire");
            Function.Call(Hash.REMOVE_IPL, "id2_14_post_no_int");
            Function.Call(Hash.REMOVE_IPL, "id2_14_during_door");
            Function.Call(Hash.REQUEST_IPL, "id2_14_post_no_int");

            UI.Notify("LestersFactoryUnload");
        }
        public static void MorgueTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(275.1f, -1360.6f, 24.5f);
        }
        public static void MorgueTeleport2()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(240.8f, -1379.5f, 33.74f);
        }
        public static void MorgueLoad()
        {
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -447.4833068847656, 280.3197021484375, 77.52149963378906), false);
            Function.Call(Hash.REQUEST_IPL, "Coroner_Int_on");
            Function.Call(Hash.REMOVE_IPL, "Coroner_Int_off");

            //teleport coords 275.1f,  -1360.6f,  24.5f
            //teleport2 coords 240.8f, -1379.5f, 33.74f

            UI.Notify("MorgueLoad");
        }
        public static void MorgueUnload()
        {
            Function.Call(Hash.REMOVE_IPL, "Coroner_Int_on");
            Function.Call(Hash.REQUEST_IPL, "Coroner_Int_off");

            UI.Notify("MorgueUnload");
        }
        public static void ONeilRanchTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(2447.9f, 4973.4f, 47.7f);
        }
        public static void ONeilRanchLoad()
        {
            Function.Call(Hash.REMOVE_IPL, "farm_burnt");
            Function.Call(Hash.REMOVE_IPL, "farm_burnt_lod");
            Function.Call(Hash.REMOVE_IPL, "farm_burnt_props");
            Function.Call(Hash.REMOVE_IPL, "farmint_cap");
            Function.Call(Hash.REMOVE_IPL, "farmint_cap_lod");
            Function.Call(Hash.REQUEST_IPL, "farm");
            Function.Call(Hash.REQUEST_IPL, "farmint");
            Function.Call(Hash.REQUEST_IPL, "farm_lod");
            Function.Call(Hash.REQUEST_IPL, "farm_props");

            UI.Notify("ONeilRanchLoad");
        }
        public static void ONeilRanchUnload()
        {
            Function.Call(Hash.REMOVE_IPL, "farm");
            Function.Call(Hash.REMOVE_IPL, "farmint");
            Function.Call(Hash.REMOVE_IPL, "farm_lod");
            Function.Call(Hash.REMOVE_IPL, "farm_props");
            Function.Call(Hash.REQUEST_IPL, "farm_burnt");
            Function.Call(Hash.REQUEST_IPL, "farm_burnt_lod");
            Function.Call(Hash.REQUEST_IPL, "farm_burnt_props");
            Function.Call(Hash.REQUEST_IPL, "farmint_cap");
            Function.Call(Hash.REQUEST_IPL, "farmint_cap_lod");

            UI.Notify("ONeilRanchUnload");
        }
        public static void PsycheofficeTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(-1906.7857666015625f, -573.7576293945312f, 19.077299118041992f);
        }
        public static void PsycheofficeLoad()
        {
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -1906.7857666015625, -573.7576293945312, 19.077299118041992), false);
            Function.Call(Hash.REQUEST_IPL, "v_psycheoffice");

            UI.Notify("PsycheofficeLoad");
        }
        public static void PsycheofficeUnload()
        {
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -1906.7857666015625, -573.7576293945312, 19.077299118041992), true);
            Function.Call(Hash.REMOVE_IPL, "v_psycheoffice");

            UI.Notify("PsycheofficeUnload");
        }
        public static void RanchTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(1390.666f, 1133.317f, 114.4808f);
        }
        public static void RanchLoad()
        {
            Function.Call(Hash.CAP_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 1399.9730224609375, 1148.755859375, 113.33360290527344), false);
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 1399.9730224609375, 1148.755859375, 113.33360290527344), false);
            Function.Call(Hash._0x2CA429C029CCF247, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 1399.9730224609375, 1148.755859375, 113.33360290527344));
            Function.Call(Hash.UNPIN_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 1399.9730224609375, 1148.755859375, 113.33360290527344));
            //Function.Call(Hash._DOOR_CONTROL, 1504256620, 1395.92f, 1142.904f, 114.7902f, true, 0.0f, 0.0f, 1.0f);
            //Function.Call(Hash._DOOR_CONTROL, -52575179, 1390.666f, 1133.317f, 114.4808f, true, 0.0f, 0.0f, -1.0f);

            UI.Notify("RanchLoad");
        }
        public static void RanchUnload()
        {
            Function.Call(Hash.CAP_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 1399.9730224609375, 1148.755859375, 113.33360290527344), true);

            UI.Notify("RanchUnload");
        }
        public static void RogersSalvageAndScrapTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(-608.7289f, -1610.315f, 27.15894f);
        }
        public static void RogersSalvageAndScrapLoad()// doors will lock if you leave area
        {
            Function.Call(Hash.CAP_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -598.6378784179688, -1608.3985595703125, 26.010799407958984), false);
            Function.Call(Hash.UNPIN_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -598.6378784179688, -1608.3985595703125, 26.010799407958984));
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -598.6378784179688, -1608.3985595703125, 26.010799407958984), false);
            Function.Call(Hash.REQUEST_IPL, "v_recycle");
            Function.Call(Hash._DOOR_CONTROL, 1099436502, -608.7289f, -1610.315f, 27.15894f, false, 0.0f, 0.0f, -1.0f);
            Function.Call(Hash._DOOR_CONTROL, -1627599682, -611.32f, -1610.089f, 27.15894f, false, 0.0f, 0.0f, 1.0f);
            Function.Call(Hash._DOOR_CONTROL, 1099436502, -592.9376f, -1631.577f, 27.15931f, false, 0.0f, 0.0f, -1.0f);
            Function.Call(Hash._DOOR_CONTROL, -1627599682, -592.7109f, -1628.986f, 27.15931f, false, 0.0f, 0.0f, 1.0f);

            UI.Notify("RogersSalvageAndScrapLoad");
        }
        public static void RogersSalvageAndScrapUnload()
        {
            Function.Call(Hash.CAP_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -598.6378784179688, -1608.3985595703125, 26.010799407958984), true);
            Function.Call(Hash.REMOVE_IPL, "v_recycle");
            Function.Call(Hash._DOOR_CONTROL, 1099436502, -608.7289f, -1610.315f, 27.15894f, true, 0.0f, 0.0f, 0.0f);
            Function.Call(Hash._DOOR_CONTROL, -1627599682, -611.32f, -1610.089f, 27.15894f, true, 0.0f, 0.0f, 0.0f);
            Function.Call(Hash._DOOR_CONTROL, 1099436502, -592.9376f, -1631.577f, 27.15931f, true, 0.0f, 0.0f, 0.0f);
            Function.Call(Hash._DOOR_CONTROL, -1627599682, -592.7109f, -1628.986f, 27.15931f, true, 0.0f, 0.0f, 0.0f);

            UI.Notify("RogersSalvageAndScrapUnload");
        }

        public static void RogersSalvageAndScrapLoad2()// 2nd way
        {
            Function.Call(Hash.CAP_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -598.6378784179688, -1608.3985595703125, 26.010799407958984), false);
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -598.6378784179688, -1608.3985595703125, 26.010799407958984), false);
            Function.Call(Hash._0x2CA429C029CCF247, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -598.6378784179688, -1608.3985595703125, 26.010799407958984));
            Function.Call(Hash.UNPIN_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -598.6378784179688, -1608.3985595703125, 26.010799407958984));
            Function.Call(Hash._DOOR_CONTROL, 1099436502, -608.7289f, -1610.315f, 27.15894f, false, 0.0f, 0.0f, -1.0f);
            Function.Call(Hash._DOOR_CONTROL, -1627599682, -611.32f, -1610.089f, 27.15894f, false, 0.0f, 0.0f, 1.0f);
            Function.Call(Hash._DOOR_CONTROL, 1099436502, -592.9376f, -1631.577f, 27.15931f, false, 0.0f, 0.0f, -1.0f);
            Function.Call(Hash._DOOR_CONTROL, -1627599682, -592.7109f, -1628.986f, 27.15931f, false, 0.0f, 0.0f, 1.0f);

            UI.Notify("RogersSalvageAndScrapLoad2");
        }
        public static void RogersSalvageAndScrapUnload2()
        {
            RogersSalvageAndScrapUnload();

            UI.Notify("RogersSalvageAndScrapUnload2");
        }
        public static void SheriffOfficePaletoTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(-444.4985f, 6017.06f, 31.86633f);
        }
        public static void SheriffOfficePaletoLoad()
        {
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -444.89068603515625, 6013.5869140625, 30.7164), false);
            Function.Call(Hash.CAP_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -444.89068603515625, 6013.5869140625, 30.7164), false);
            Function.Call(Hash.REQUEST_IPL, "v_sheriff2");
            Function.Call(Hash.REMOVE_IPL, "cs1_16_sheriff_cap");
            Function.Call(Hash._DOOR_CONTROL, -1501157055, -444.4985f, 6017.06f, 31.86633f, false, 0.0f, 0.0f, 0.0f);
            Function.Call(Hash._DOOR_CONTROL, -1501157055, -442.66f, 6015.222f, 31.86633f, false, 0.0f, 0.0f, 0.0f);

            UI.Notify("SheriffOfficePaletoLoad");
        }
        public static void SheriffOfficePaletoUnload()
        {
            Function.Call(Hash.CAP_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -444.89068603515625, 6013.5869140625, 30.7164), true);
            Function.Call(Hash.REMOVE_IPL, "v_sheriff2");
            Function.Call(Hash.REQUEST_IPL, "cs1_16_sheriff_cap");
            Function.Call(Hash._DOOR_CONTROL, -1501157055, -444.4985f, 6017.06f, 31.86633f, true, 0.0f, 0.0f, 0.0f);
            Function.Call(Hash._DOOR_CONTROL, -1501157055, -442.66f, 6015.222f, 31.86633f, true, 0.0f, 0.0f, 0.0f);

            UI.Notify("SheriffOfficePaletoUnload");
        }
        public static void SheriffOfficeSandyShoresTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(1855.685f, 3683.93f, 34.59282f);
        }
        public static void SheriffOfficeSandyShoresLoad()
        {
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 1854.2537841796875, 3686.738525390625, 33.2671012878418), false);
            Function.Call(Hash.CAP_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 1854.2537841796875, 3686.738525390625, 33.2671012878418), false);
            Function.Call(Hash.REQUEST_IPL, "v_sheriff");
            Function.Call(Hash.REMOVE_IPL, "sheriff_cap");
            Function.Call(Hash._DOOR_CONTROL, -1765048490, 1855.685f, 3683.93f, 34.59282f, false, 0.0f, 0.0f, 0.0f);

            UI.Notify("SheriffOfficeSandyShoresLoad");
        }
        public static void SheriffOfficeSandyShoresUnload()
        {
            Function.Call(Hash.CAP_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 1854.2537841796875, 3686.738525390625, 33.2671012878418), true);
            Function.Call(Hash.REMOVE_IPL, "v_sheriff");
            Function.Call(Hash.REQUEST_IPL, "sheriff_cap");
            Function.Call(Hash._DOOR_CONTROL, -1765048490, 1855.685f, 3683.93f, 34.59282f, true, 0.0f, 0.0f, 0.0f);

            UI.Notify("SheriffOfficeSandyShoresUnload");
        }
        public static void SimeonsShowroomTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(-30.8793f, -1088.336f, 25.4221f);
        }
        public static void SimeonsShowroomLoad()
        {
            Function.Call(Hash.REMOVE_IPL, "v_carshowroom");
            Function.Call(Hash.REMOVE_IPL, "shutter_open");
            Function.Call(Hash.REMOVE_IPL, "shutter_closed");
            Function.Call(Hash.REMOVE_IPL, "shr_int");
            Function.Call(Hash.REMOVE_IPL, "csr_inMission");
            Function.Call(Hash.REMOVE_IPL, "fakeint");
            Function.Call(Hash.REQUEST_IPL, "shr_int");

            UI.Notify("SimeonsShowroomLoad");
        }
        public static void SimeonsShowroomUnload()
        {
            Function.Call(Hash.REMOVE_IPL, "v_carshowroom");
            Function.Call(Hash.REMOVE_IPL, "shutter_open");
            Function.Call(Hash.REMOVE_IPL, "shutter_closed");
            Function.Call(Hash.REMOVE_IPL, "shr_int");
            Function.Call(Hash.REMOVE_IPL, "csr_inMission");
            Function.Call(Hash.REMOVE_IPL, "fakeint");
            Function.Call(Hash.REQUEST_IPL, "fakeint");

            UI.Notify("SimeonsShowroomUnload");
        }
        public static void SlaughterHouseTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(962.0066f, -2183.816f, 31.06194f);
        }
        public static void SlaughterHouseLoad()// doors will lock if you leave area
        {
            Function.Call(Hash.CAP_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 982.2329711914062, -2160.381591796875, 28.4761), false);
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 982.2329711914062, -2160.381591796875, 28.4761), false);
            Function.Call(Hash.REQUEST_IPL, "v_abattoir");
            Function.Call(Hash._DOOR_CONTROL, -1468417022, 962.9084f, -2105.813f, 32.52716f, true, 0.0f, 0.0f, 1.0f);
            Function.Call(Hash._DOOR_CONTROL, 1755793225, 962.0066f, -2183.816f, 31.06194f, true, 0.0f, 0.0f, 1.0f);
            Function.Call(Hash.UNPIN_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 982.2329711914062, -2160.381591796875, 28.4761));

            UI.Notify("SlaughterHouseLoad");
        }
        public static void SlaughterHouseUnload()
        {
            Function.Call(Hash.CAP_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 982.2329711914062, -2160.381591796875, 28.4761), true);
            Function.Call(Hash._DOOR_CONTROL, -1468417022, 962.9084f, -2105.813f, 32.52716f, true, 0.0f, 0.0f, 0.0f);
            Function.Call(Hash._DOOR_CONTROL, 1755793225, 962.0066f, -2183.816f, 31.06194f, true, 0.0f, 0.0f, 0.0f);
            Function.Call(Hash.REMOVE_IPL, "v_abattoir");

            UI.Notify("SlaughterHouseUnload");
        }
        public static void SolomonsOfficeTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(-1005.663208f, -478.3460998535156f, 49.0265f);
        }
        public static void SolomonsOfficeLoad()
        {
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -1005.663208f, -478.3460998535156f, 49.0265f), false);
            Function.Call(Hash.REQUEST_IPL, "v_58_sol_office");

            UI.Notify("SolomonsOfficeLoad");
        }
        public static void SolomonsOfficeUnload()
        {
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -1005.663208f, -478.3460998535156f, 49.0265f), true);
            Function.Call(Hash.REMOVE_IPL, "v_58_sol_office");

            UI.Notify("SolomonsOfficeUnload");
        }
        public static void StabCityTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(110.975f, 3718.419f, 38.827f);
        }
        public static void StabCityUnburntLoad()
        {
            Function.Call(Hash.REMOVE_IPL, "trailerparkA_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkA_grp2");
            Function.Call(Hash.REMOVE_IPL, "occl_trailerA_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkB_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkB_grp2");
            Function.Call(Hash.REMOVE_IPL, "occl_trailerB_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkC_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkC_grp2");
            Function.Call(Hash.REMOVE_IPL, "occl_trailerC_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkD_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkD_grp2");
            Function.Call(Hash.REMOVE_IPL, "occl_trailerD_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkE_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkE_grp2");
            Function.Call(Hash.REMOVE_IPL, "occl_trailerE_grp1");
            Function.Call(Hash.REMOVE_IPL, "des_methtrailer");
            Function.Call(Hash.REMOVE_IPL, "methtrailer_grp1");
            Function.Call(Hash.REMOVE_IPL, "methtrailer_grp2");
            Function.Call(Hash.REMOVE_IPL, "methtrailer_grp3");
            Function.Call(Hash.REMOVE_IPL, "occl_meth_grp1");
            Function.Call(Hash.REMOVE_IPL, "occl_meth_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkA_grp1");
            Function.Call(Hash.REQUEST_IPL, "occl_trailerA_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkB_grp1");
            Function.Call(Hash.REQUEST_IPL, "occl_trailerB_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkC_grp1");
            Function.Call(Hash.REQUEST_IPL, "occl_trailerC_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkD_grp1");
            Function.Call(Hash.REQUEST_IPL, "occl_trailerD_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkE_grp1");
            Function.Call(Hash.REQUEST_IPL, "occl_trailerE_grp1");
            Function.Call(Hash.REQUEST_IPL, "occl_meth_grp1");
            Function.Call(Hash.REQUEST_IPL, "methtrailer_grp1");

            UI.Notify("StabCityUnburntLoad");
        }
        public static void StabCityUnburntUnload()
        {
            Function.Call(Hash.REQUEST_IPL, "trailerparkA_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkA_grp2");
            Function.Call(Hash.REQUEST_IPL, "occl_trailerA_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkB_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkB_grp2");
            Function.Call(Hash.REQUEST_IPL, "occl_trailerB_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkC_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkC_grp2");
            Function.Call(Hash.REQUEST_IPL, "occl_trailerC_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkD_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkD_grp2");
            Function.Call(Hash.REQUEST_IPL, "occl_trailerD_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkE_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkE_grp2");
            Function.Call(Hash.REQUEST_IPL, "occl_trailerE_grp1");
            Function.Call(Hash.REQUEST_IPL, "des_methtrailer");
            Function.Call(Hash.REQUEST_IPL, "methtrailer_grp1");
            Function.Call(Hash.REQUEST_IPL, "methtrailer_grp2");
            Function.Call(Hash.REQUEST_IPL, "methtrailer_grp3");
            Function.Call(Hash.REQUEST_IPL, "occl_meth_grp1");
            Function.Call(Hash.REQUEST_IPL, "occl_meth_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkA_grp1");
            Function.Call(Hash.REMOVE_IPL, "occl_trailerA_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkB_grp1");
            Function.Call(Hash.REMOVE_IPL, "occl_trailerB_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkC_grp1");
            Function.Call(Hash.REMOVE_IPL, "occl_trailerC_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkD_grp1");
            Function.Call(Hash.REMOVE_IPL, "occl_trailerD_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkE_grp1");
            Function.Call(Hash.REMOVE_IPL, "occl_trailerE_grp1");
            Function.Call(Hash.REMOVE_IPL, "occl_meth_grp1");
            Function.Call(Hash.REMOVE_IPL, "methtrailer_grp1");

            UI.Notify("StabCityUnburntUnload");
        }
        public static void StabCityBurntLoad()
        {
            Function.Call(Hash.REMOVE_IPL, "trailerparkA_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkA_grp2");
            Function.Call(Hash.REMOVE_IPL, "occl_trailerA_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkB_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkB_grp2");
            Function.Call(Hash.REMOVE_IPL, "occl_trailerB_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkC_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkC_grp2");
            Function.Call(Hash.REMOVE_IPL, "occl_trailerC_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkD_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkD_grp2");
            Function.Call(Hash.REMOVE_IPL, "occl_trailerD_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkE_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkE_grp2");
            Function.Call(Hash.REMOVE_IPL, "occl_trailerE_grp1");
            Function.Call(Hash.REMOVE_IPL, "des_methtrailer");
            Function.Call(Hash.REMOVE_IPL, "methtrailer_grp1");
            Function.Call(Hash.REMOVE_IPL, "methtrailer_grp2");
            Function.Call(Hash.REMOVE_IPL, "methtrailer_grp3");
            Function.Call(Hash.REMOVE_IPL, "occl_meth_grp1");
            Function.Call(Hash.REMOVE_IPL, "occl_meth_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkA_grp2");
            Function.Call(Hash.REQUEST_IPL, "trailerparkB_grp2");
            Function.Call(Hash.REQUEST_IPL, "trailerparkC_grp2");
            Function.Call(Hash.REQUEST_IPL, "trailerparkD_grp2");
            Function.Call(Hash.REQUEST_IPL, "trailerparkE_grp2");
            Function.Call(Hash.REQUEST_IPL, "des_methtrailer");
            Function.Call(Hash.REQUEST_IPL, "methtrailer_grp3");  //burnt
                                                                  //Function.Call(Hash.REQUEST_IPL, "methtrailer_grp2");  //on fire

            UI.Notify("StabCityBurntLoad");
        }
        public static void StabCityBurntUnload()
        {
            Function.Call(Hash.REQUEST_IPL, "trailerparkA_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkA_grp2");
            Function.Call(Hash.REQUEST_IPL, "occl_trailerA_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkB_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkB_grp2");
            Function.Call(Hash.REQUEST_IPL, "occl_trailerB_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkC_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkC_grp2");
            Function.Call(Hash.REQUEST_IPL, "occl_trailerC_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkD_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkD_grp2");
            Function.Call(Hash.REQUEST_IPL, "occl_trailerD_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkE_grp1");
            Function.Call(Hash.REQUEST_IPL, "trailerparkE_grp2");
            Function.Call(Hash.REQUEST_IPL, "occl_trailerE_grp1");
            Function.Call(Hash.REQUEST_IPL, "des_methtrailer");
            Function.Call(Hash.REQUEST_IPL, "methtrailer_grp1");
            Function.Call(Hash.REQUEST_IPL, "methtrailer_grp2");
            Function.Call(Hash.REQUEST_IPL, "methtrailer_grp3");
            Function.Call(Hash.REQUEST_IPL, "occl_meth_grp1");
            Function.Call(Hash.REQUEST_IPL, "occl_meth_grp1");
            Function.Call(Hash.REMOVE_IPL, "trailerparkA_grp2");
            Function.Call(Hash.REMOVE_IPL, "trailerparkB_grp2");
            Function.Call(Hash.REMOVE_IPL, "trailerparkC_grp2");
            Function.Call(Hash.REMOVE_IPL, "trailerparkD_grp2");
            Function.Call(Hash.REMOVE_IPL, "trailerparkE_grp2");
            Function.Call(Hash.REMOVE_IPL, "des_methtrailer");
            Function.Call(Hash.REMOVE_IPL, "methtrailer_grp3");  //burnt
                                                                 //Function.Call(Hash.REQUEST_IPL, "methtrailer_grp2");  //on fire

            UI.Notify("StabCityBurntUnload");
        }
        public static void TrevorstrailerTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(1972.769f, 3815.366f, 33.66326f);
        }
        public static void TrevorstrailerLoad()
        {
            Function.Call(Hash.REMOVE_IPL, "TrevorsTrailerTrash");
            Function.Call(Hash.REMOVE_IPL, "TrevorsTrailerTidy");
            Function.Call(Hash.REMOVE_IPL, "TrevorsTrailer");
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 1973.0, 3815.0, 34.0), false);
            Function.Call(Hash.REQUEST_IPL, "TrevorsTrailerTidy");
            Function.Call(Hash._DOOR_CONTROL, 132154435, 1972.769f, 3815.366f, 33.66326f, false, 0.0f, 0.0f, 0.0f);

            UI.Notify("TrevorstrailerLoad");
        }
        public static void TrevorstrailerUnload()
        {
            Function.Call(Hash.REQUEST_IPL, "TrevorsTrailerTrash");
            Function.Call(Hash.REQUEST_IPL, "TrevorsTrailerTidy");
            Function.Call(Hash.REQUEST_IPL, "TrevorsTrailer");
            Function.Call(Hash.REMOVE_IPL, "TrevorsTrailerTidy");
            //Function.Call(Hash._DOOR_CONTROL, 132154435, 1972.769f, 3815.366f, 33.66326f, true, 0.0f, 0.0f, 0.0f);

            UI.Notify("TrevorstrailerUnload");
        }
        public static void TequlLaLaTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(-565.1712f, 276.6259f, 83.28626f);
        }
        public static void TequlLaLaLoad()
        {
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -556.5089111328125, 286.318115234375, 81.1763), false);
            Function.Call(Hash.CAP_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -556.5089111328125, 286.318115234375, 81.1763), false);
            Function.Call(Hash.REQUEST_IPL, "v_rockclub");
            Function.Call(Hash._DOOR_CONTROL, 993120320, -565.1712f, 276.6259f, 83.28626f, false, 0.0f, 0.0f, 0.0f);// front door
            Function.Call(Hash._DOOR_CONTROL, 993120320, -561.2866f, 293.5044f, 87.77851f, false, 0.0f, 0.0f, 0.0f);// back door

            UI.Notify("TequlLaLaLoad");
        }
        public static void TequlLaLaUnload()
        {
            Function.Call(Hash.CAP_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, -556.5089111328125, 286.318115234375, 81.1763), true);
            Function.Call(Hash.REMOVE_IPL, "v_rockclub");
            Function.Call(Hash._DOOR_CONTROL, 993120320, -565.1712f, 276.6259f, 83.28626f, true, 0.0f, 0.0f, 0.0f);// front door
            Function.Call(Hash._DOOR_CONTROL, 993120320, -561.2866f, 293.5044f, 87.77851f, true, 0.0f, 0.0f, 0.0f);// back door

            UI.Notify("TequlLaLaUnload");
        }
        public static void TortureTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(134.3954f, -2204.097f, 7.514325f);
        }
        public static void TortureLoad()
        {
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 147.43299865722656, -2201.370361328125, 3.688), false);
            Function.Call(Hash.REQUEST_IPL, "v_torture");
            Function.Call(Hash._DOOR_CONTROL, 464151082, 134.3954f, -2204.097f, 7.514325f, false, 0.0f, 0.0f, 0.0f);

            UI.Notify("TortureLoad");
        }
        public static void TortureUnload()
        {
            Function.Call(Hash.DISABLE_INTERIOR, Function.Call<int>(Hash.GET_INTERIOR_AT_COORDS, 147.43299865722656, -2201.370361328125, 3.688), false);
            Function.Call(Hash.REMOVE_IPL, "v_torture");
            Function.Call(Hash._DOOR_CONTROL, 464151082, 134.3954f, -2204.097f, 7.514325f, true, 0.0f, 0.0f, 0.0f);

            UI.Notify("TortureUnload");
        }
        public static void Online()
        {
            Function.Call(Hash._ENABLE_MP_DLC_MAPS, 1);
            Function.Call(Hash._LOAD_MP_DLC_MAPS);
        }
        public static void LostSafeHouseTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(984.1552f, -110.3662f, 72.9326f);
        }
        public static void LostSafeHouseLoad()
        {
            Function.Call(Hash.REMOVE_IPL, "hei_bi_hw1_13_door");
            Function.Call(Hash.REQUEST_IPL, "bkr_bi_hw1_13_int"); // coords    984.1552f, -95.3662f, 75.9326f

            UI.Notify("LostSafeHouseLoad");
        }
        public static void LostSafeHouseUnload()
        {
            Function.Call(Hash.REQUEST_IPL, "hei_bi_hw1_13_door");
            Function.Call(Hash.REMOVE_IPL, "bkr_bi_hw1_13_int"); // coords    984.1552f, -95.3662f, 75.9326f

            UI.Notify("LostSafeHouseUnload");
        }
        public static void YachtTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(-2043.974f, -1031.582f, 11.981f);
        }
        public static void YachtLoad()
        {
            Function.Call(Hash.REQUEST_IPL, "hei_yacht_heist");
            Function.Call(Hash.REQUEST_IPL, "hei_yacht_heist_Bar");
            Function.Call(Hash.REQUEST_IPL, "hei_yacht_heist_Bedrm");
            Function.Call(Hash.REQUEST_IPL, "hei_yacht_heist_Bridge");
            Function.Call(Hash.REQUEST_IPL, "hei_yacht_heist_DistantLights");
            Function.Call(Hash.REQUEST_IPL, "hei_yacht_heist_enginrm");
            Function.Call(Hash.REQUEST_IPL, "hei_yacht_heist_LODLights");
            Function.Call(Hash.REQUEST_IPL, "hei_yacht_heist_Lounge");

            UI.Notify("YachtLoad");
        }
        public static void YachtUnload()
        {
            Function.Call(Hash.REMOVE_IPL, "hei_yacht_heist");
            Function.Call(Hash.REMOVE_IPL, "hei_yacht_heist_Bar");
            Function.Call(Hash.REMOVE_IPL, "hei_yacht_heist_Bedrm");
            Function.Call(Hash.REMOVE_IPL, "hei_yacht_heist_Bridge");
            Function.Call(Hash.REMOVE_IPL, "hei_yacht_heist_DistantLights");
            Function.Call(Hash.REMOVE_IPL, "hei_yacht_heist_enginrm");
            Function.Call(Hash.REMOVE_IPL, "hei_yacht_heist_LODLights");
            Function.Call(Hash.REMOVE_IPL, "hei_yacht_heist_Lounge");

            UI.Notify("YachtUnload");
        }
        public static void HeistCarrierTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(3069.98f, -4632.49f, 16.26f);
        }
        public static void HeistCarrierLoad()
        {
            Function.Call(Hash.REQUEST_IPL, "hei_carrier");
            Function.Call(Hash.REQUEST_IPL, "hei_carrier_DistantLights");
            Function.Call(Hash.REQUEST_IPL, "hei_Carrier_int1");
            Function.Call(Hash.REQUEST_IPL, "hei_Carrier_int2");
            Function.Call(Hash.REQUEST_IPL, "hei_Carrier_int3");
            Function.Call(Hash.REQUEST_IPL, "hei_Carrier_int4");
            Function.Call(Hash.REQUEST_IPL, "hei_Carrier_int5");
            Function.Call(Hash.REQUEST_IPL, "hei_Carrier_int6");
            Function.Call(Hash.REQUEST_IPL, "hei_carrier_LODLights");

            UI.Notify("HeistCarrierLoad");
        }
        public static void HeistCarrierUnload()
        {
            Function.Call(Hash.REMOVE_IPL, "hei_carrier");
            Function.Call(Hash.REMOVE_IPL, "hei_carrier_DistantLights");
            Function.Call(Hash.REMOVE_IPL, "hei_Carrier_int1");
            Function.Call(Hash.REMOVE_IPL, "hei_Carrier_int2");
            Function.Call(Hash.REMOVE_IPL, "hei_Carrier_int3");
            Function.Call(Hash.REMOVE_IPL, "hei_Carrier_int4");
            Function.Call(Hash.REMOVE_IPL, "hei_Carrier_int5");
            Function.Call(Hash.REMOVE_IPL, "hei_Carrier_int6");
            Function.Call(Hash.REMOVE_IPL, "hei_carrier_LODLights");

            UI.Notify("HeistCarrierUnload");
        }
        public static void NorthYanktonTeleport()
        {
            Game.Player.Character.Position = new GTA.Math.Vector3(3360.19f, -4849.67f, 111.8f);
        }
        public static void NorthYanktonLoad()
        {
            Function.Call(Hash.REQUEST_IPL, "plg_01");
            Function.Call(Hash.REQUEST_IPL, "prologue01");
            Function.Call(Hash.REQUEST_IPL, "prologue01k");
            Function.Call(Hash.REQUEST_IPL, "prologue01k_lod");
            Function.Call(Hash.REQUEST_IPL, "prologue01z");
            Function.Call(Hash.REQUEST_IPL, "prologue01z_lod");
            Function.Call(Hash.REQUEST_IPL, "prologue01_lod");
            Function.Call(Hash.REQUEST_IPL, "prologue01c");
            Function.Call(Hash.REQUEST_IPL, "prologue01c_lod");
            Function.Call(Hash.REQUEST_IPL, "prologue01d");
            Function.Call(Hash.REQUEST_IPL, "prologue01d_lod");
            Function.Call(Hash.REQUEST_IPL, "prologue01e");
            Function.Call(Hash.REQUEST_IPL, "prologue01e_lod");
            Function.Call(Hash.REQUEST_IPL, "prologue01f");
            Function.Call(Hash.REQUEST_IPL, "prologue01f_lod");
            Function.Call(Hash.REQUEST_IPL, "prologue01g");
            Function.Call(Hash.REQUEST_IPL, "prologue01h");
            Function.Call(Hash.REQUEST_IPL, "prologue01h_lod");
            Function.Call(Hash.REQUEST_IPL, "prologue01i");
            Function.Call(Hash.REQUEST_IPL, "prologue01i_lod");
            Function.Call(Hash.REQUEST_IPL, "prologue01j");
            Function.Call(Hash.REQUEST_IPL, "prologue01j_lod");
            Function.Call(Hash.REQUEST_IPL, "plg_02");
            Function.Call(Hash.REQUEST_IPL, "prologue02");
            Function.Call(Hash.REQUEST_IPL, "prologue02_lod");
            Function.Call(Hash.REQUEST_IPL, "plg_03");
            Function.Call(Hash.REQUEST_IPL, "prologue03");
            Function.Call(Hash.REQUEST_IPL, "prologue03_lod");
            Function.Call(Hash.REQUEST_IPL, "prologue03b");
            Function.Call(Hash.REQUEST_IPL, "prologue03b_lod");
            //the commented code disables the 'Prologue' grave and
            //enables the 'Bury the Hatchet' grave
            Function.Call(Hash.REQUEST_IPL, "prologue03_grv_cov"); // was be comment
            Function.Call(Hash.REQUEST_IPL, "prologue03_grv_cov_lod"); // was be comment
            Function.Call(Hash.REQUEST_IPL, "prologue03_grv_dug");
            Function.Call(Hash.REQUEST_IPL, "prologue03_grv_dug_lod");
            Function.Call(Hash.REQUEST_IPL, "prologue03_grv_fun"); // was be comment
            Function.Call(Hash.REQUEST_IPL, "prologue_grv_torch");
            Function.Call(Hash.REQUEST_IPL, "plg_04");
            Function.Call(Hash.REQUEST_IPL, "prologue04");
            Function.Call(Hash.REQUEST_IPL, "prologue04_lod");
            Function.Call(Hash.REQUEST_IPL, "prologue04b");
            Function.Call(Hash.REQUEST_IPL, "prologue04b_lod");
            Function.Call(Hash.REQUEST_IPL, "prologue04_cover");
            Function.Call(Hash.REQUEST_IPL, "des_protree_end");
            Function.Call(Hash.REQUEST_IPL, "des_protree_start");
            Function.Call(Hash.REQUEST_IPL, "des_protree_start_lod");
            Function.Call(Hash.REQUEST_IPL, "plg_05");
            Function.Call(Hash.REQUEST_IPL, "prologue05");
            Function.Call(Hash.REQUEST_IPL, "prologue05_lod");
            Function.Call(Hash.REQUEST_IPL, "prologue05b");
            Function.Call(Hash.REQUEST_IPL, "prologue05b_lod");
            Function.Call(Hash.REQUEST_IPL, "plg_06");
            Function.Call(Hash.REQUEST_IPL, "prologue06");
            Function.Call(Hash.REQUEST_IPL, "prologue06_lod");
            Function.Call(Hash.REQUEST_IPL, "prologue06b");
            Function.Call(Hash.REQUEST_IPL, "prologue06b_lod");
            Function.Call(Hash.REQUEST_IPL, "prologue06_int");
            Function.Call(Hash.REQUEST_IPL, "prologue06_int_lod");
            Function.Call(Hash.REQUEST_IPL, "prologue06_pannel");
            Function.Call(Hash.REQUEST_IPL, "prologue06_pannel_lod");
            Function.Call(Hash.REQUEST_IPL, "prologue_m2_door");
            Function.Call(Hash.REQUEST_IPL, "prologue_m2_door_lod");
            Function.Call(Hash.REQUEST_IPL, "plg_occl_00");
            Function.Call(Hash.REQUEST_IPL, "prologue_occl");
            Function.Call(Hash.REQUEST_IPL, "plg_rd");
            Function.Call(Hash.REQUEST_IPL, "prologuerd");
            Function.Call(Hash.REQUEST_IPL, "prologuerdb");
            Function.Call(Hash.REQUEST_IPL, "prologuerd_lod");

            UI.Notify("NorthYanktonLoad");
        }
        public static void NorthYanktonUnload()
        {
            Function.Call(Hash.REMOVE_IPL, "plg_01");
            Function.Call(Hash.REMOVE_IPL, "prologue01");
            Function.Call(Hash.REMOVE_IPL, "prologue01k");
            Function.Call(Hash.REMOVE_IPL, "prologue01k_lod");
            Function.Call(Hash.REMOVE_IPL, "prologue01z");
            Function.Call(Hash.REMOVE_IPL, "prologue01z_lod");
            Function.Call(Hash.REMOVE_IPL, "prologue01_lod");
            Function.Call(Hash.REMOVE_IPL, "prologue01c");
            Function.Call(Hash.REMOVE_IPL, "prologue01c_lod");
            Function.Call(Hash.REMOVE_IPL, "prologue01d");
            Function.Call(Hash.REMOVE_IPL, "prologue01d_lod");
            Function.Call(Hash.REMOVE_IPL, "prologue01e");
            Function.Call(Hash.REMOVE_IPL, "prologue01e_lod");
            Function.Call(Hash.REMOVE_IPL, "prologue01f");
            Function.Call(Hash.REMOVE_IPL, "prologue01f_lod");
            Function.Call(Hash.REMOVE_IPL, "prologue01g");
            Function.Call(Hash.REMOVE_IPL, "prologue01h");
            Function.Call(Hash.REMOVE_IPL, "prologue01h_lod");
            Function.Call(Hash.REMOVE_IPL, "prologue01i");
            Function.Call(Hash.REMOVE_IPL, "prologue01i_lod");
            Function.Call(Hash.REMOVE_IPL, "prologue01j");
            Function.Call(Hash.REMOVE_IPL, "prologue01j_lod");
            Function.Call(Hash.REMOVE_IPL, "plg_02");
            Function.Call(Hash.REMOVE_IPL, "prologue02");
            Function.Call(Hash.REMOVE_IPL, "prologue02_lod");
            Function.Call(Hash.REMOVE_IPL, "plg_03");
            Function.Call(Hash.REMOVE_IPL, "prologue03");
            Function.Call(Hash.REMOVE_IPL, "prologue03_lod");
            Function.Call(Hash.REMOVE_IPL, "prologue03b");
            Function.Call(Hash.REMOVE_IPL, "prologue03b_lod");
            //the commented code disables the 'Prologue' grave and
            //enables the 'Bury the Hatchet' grave
            Function.Call(Hash.REMOVE_IPL, "prologue03_grv_cov"); // was be comment
            Function.Call(Hash.REMOVE_IPL, "prologue03_grv_cov_lod"); // was be comment
            Function.Call(Hash.REMOVE_IPL, "prologue03_grv_dug");
            Function.Call(Hash.REMOVE_IPL, "prologue03_grv_dug_lod");
            Function.Call(Hash.REMOVE_IPL, "prologue03_grv_fun"); // was be comment
            Function.Call(Hash.REMOVE_IPL, "prologue_grv_torch");
            Function.Call(Hash.REMOVE_IPL, "plg_04");
            Function.Call(Hash.REMOVE_IPL, "prologue04");
            Function.Call(Hash.REMOVE_IPL, "prologue04_lod");
            Function.Call(Hash.REMOVE_IPL, "prologue04b");
            Function.Call(Hash.REMOVE_IPL, "prologue04b_lod");
            Function.Call(Hash.REMOVE_IPL, "prologue04_cover");
            Function.Call(Hash.REMOVE_IPL, "des_protree_end");
            Function.Call(Hash.REMOVE_IPL, "des_protree_start");
            Function.Call(Hash.REMOVE_IPL, "des_protree_start_lod");
            Function.Call(Hash.REMOVE_IPL, "plg_05");
            Function.Call(Hash.REMOVE_IPL, "prologue05");
            Function.Call(Hash.REMOVE_IPL, "prologue05_lod");
            Function.Call(Hash.REMOVE_IPL, "prologue05b");
            Function.Call(Hash.REMOVE_IPL, "prologue05b_lod");
            Function.Call(Hash.REMOVE_IPL, "plg_06");
            Function.Call(Hash.REMOVE_IPL, "prologue06");
            Function.Call(Hash.REMOVE_IPL, "prologue06_lod");
            Function.Call(Hash.REMOVE_IPL, "prologue06b");
            Function.Call(Hash.REMOVE_IPL, "prologue06b_lod");
            Function.Call(Hash.REMOVE_IPL, "prologue06_int");
            Function.Call(Hash.REMOVE_IPL, "prologue06_int_lod");
            Function.Call(Hash.REMOVE_IPL, "prologue06_pannel");
            Function.Call(Hash.REMOVE_IPL, "prologue06_pannel_lod");
            Function.Call(Hash.REMOVE_IPL, "prologue_m2_door");
            Function.Call(Hash.REMOVE_IPL, "prologue_m2_door_lod");
            Function.Call(Hash.REMOVE_IPL, "plg_occl_00");
            Function.Call(Hash.REMOVE_IPL, "prologue_occl");
            Function.Call(Hash.REMOVE_IPL, "plg_rd");
            Function.Call(Hash.REMOVE_IPL, "prologuerd");
            Function.Call(Hash.REMOVE_IPL, "prologuerdb");
            Function.Call(Hash.REMOVE_IPL, "prologuerd_lod");

            UI.Notify("NorthYanktonUnload");
        }
    }
}
