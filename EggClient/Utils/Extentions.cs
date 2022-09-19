using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using VRC;
using VRC.Core;
using VRC.SDKBase;
using Il2CppSystem.Collections.Generic;
using VRC.UI.Elements.Menus;

namespace EggClient.Extentions
{
    internal static class Extentions
    {

        public static string murder = "wrld_858dfdfc-1b48-4e1e-8a43-f0edc611e5fe";
        public static string amongsus = "wrld_dd036610-a246-4f52-bf01-9d7cea3405d7";
        public static Player LocalPlayer
        {
            get
            {
                return Player.prop_Player_0;
            }
        }
        public static Animator GetAnimator(this VRCPlayer player)
        {
            return player.field_Internal_Animator_0;
        }

        public static VRCPlayer GetVRCPlayer(this Player Instance)
        {
            return Instance._vrcplayer;
        }

        public static VRCPlayer GetVRCPlayer(this PlayerNet Instance)
        {
            return Instance._vrcPlayer;
        }
        public static VRCPlayerApi GetVRCPlayerApi(this VRCPlayer Instance)
        {
            return Instance.prop_VRCPlayerApi_0;
        }
        public static VRCPlayerApi GetVRCPlayerApi(this PlayerNet Instance)
        {
            return Instance.GetVRCPlayer().GetVRCPlayerApi();
        }
        public static bool GetIsInVR(this VRCPlayer Instance)
        {
            return Instance.GetVRCPlayerApi().IsUserInVR();
        }
        public static bool IsInWorld()
        {
            return RoomManager.field_Internal_Static_ApiWorld_0 != null;
        }

        public static VRCPlayerApi GetVRCPlayerApi(this Player player)
        {
            return player.field_Private_VRCPlayerApi_0;
        }
        public static bool IsInVR(this Player player)
        {
            return player.GetVRCPlayerApi().IsUserInVR();
        }

        public static int GetActorNumber(this Player player)
        {
            return player.GetVRCPlayerApi().playerId;
        }
        public static string roommanagerstr()
        {
            return RoomManager.field_Internal_Static_ApiWorld_0.id;

        }

        public static bool Amongunsworld()
        {
            if (RoomManager.field_Internal_Static_ApiWorld_0.id == "wrld_dd036610-a246-4f52-bf01-9d7cea3405d7")
                return true;
            else return false;
        }

        public static bool MurderWorld()
        {
            if (RoomManager.field_Internal_Static_ApiWorld_0.id == "wrld_858dfdfc-1b48-4e1e-8a43-f0edc611e5fe")
                return true;
            else return false;
        }
        public static Player GetPlayer(int ActorNumber)
        {
            return AllPlayers.Where(p => p.GetActorNumber() == ActorNumber).FirstOrDefault();
        }
        public static void TakeOwnershipIfNecessary(GameObject gameObject)
        {
            if (getOwnerOfGameObject(gameObject) != LocalPlayer)
            {
                Networking.SetOwner(LocalPlayer.field_Private_VRCPlayerApi_0, gameObject);
            }
        }
        public static PlayerManager PManager
        {
            get
            {
                return PlayerManager.field_Private_Static_PlayerManager_0;
            }
        }
        public static System.Collections.Generic.List<Player> AllPlayers
        {
            get
            {
                return PManager.field_Private_List_1_Player_0.ToArray().ToList<Player>();
            }
        }

        public static Player getOwnerOfGameObject(GameObject gameObject)
        {
            foreach (Player player in AllPlayers)
            {
                if (player.field_Private_VRCPlayerApi_0.IsOwner(gameObject))
                {
                    return player;
                }
            }
            return null;
        }
        public static Il2CppSystem.Collections.Generic.List<Player> AllPlayerss(this PlayerManager Instance)
        {
            return Instance.field_Private_List_1_Player_0;
        }
        public static Player GetPlayerWithPlayerID(this PlayerManager Instance, int playerID)
        {
            Il2CppSystem.Collections.Generic.List<Player> list = Instance.AllPlayerss();
            foreach (Player player in list.ToArray())
            {
                if (player.GetVRCPlayerApi().playerId == playerID)
                {
                    return player;
                }
            }
            return null;
        }

        public static Player GetPlayer(this PlayerManager Instance, int playerID)
        {
            Il2CppSystem.Collections.Generic.List<Player> list = Instance.AllPlayerss();
            foreach (Player player in list.ToArray())
            {
                if (player.GetVRCPlayerApi().playerId == playerID)
                {
                    return player;
                }
            }
            return null;
        }


    }
    internal static class NCT
    {
        public static bool IsFriend(this Player player) => player.field_Private_APIUser_0 != null && APIUser.CurrentUser != null && APIUser.CurrentUser.friendIDs.Contains(player.field_Private_APIUser_0.id);

        public static int GetFrames(this VRCPlayer Instance)
        {
            return (Instance.prop_PlayerNet_0.prop_Byte_0 != 0) ? ((int)(1000f / Instance.prop_PlayerNet_0.prop_Byte_0)) : 0;
        }
        public static short GetPing(this VRCPlayer Instance)
        {
            return Instance.prop_PlayerNet_0.field_Private_Int16_0;
        }


        public static string geping(this VRCPlayer Instance)
        {

            string arg;
            if (Instance.GetPing() <= 75)
            {
                arg = "<color=#008000ff>";
            }
            else
            {

                if (Instance.GetPing() >= 75 && Instance.GetPing() <= 150)
                {
                    arg = "<color=#ffa500ff>";
                }
                else
                {
                    arg = "<color=#ff0000ff>";
                }
            }
            return string.Format("{0}{1}</color>", arg, Instance.GetPing());
        }
        public static string gefps(this VRCPlayer Instance)
        {

            string arg;
            if (Instance.GetFrames() >= 80)
            {
                arg = "<color=#008000ff>";
            }
            else
            {

                if (Instance.GetFrames() <= 80 && Instance.GetFrames() >= 30)
                {
                    arg = "<color=#ffa500ff>";
                }
                else
                {
                    arg = "<color=#ff0000ff>";
                }
            }
            return string.Format("{0}{1}</color>", arg, Instance.GetFrames());
        }
       
    }
}