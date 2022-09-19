using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using VRC;
using VRC.SDKBase;
using VRC.Udon;
using VRC.UI.Elements.Menus;
using VRC.Core;

namespace EggClient.MurderHacks
{
    public static class BlackCat
    {
        public static void Udonsend(this GameObject gameObject, string udonEvent, VRC.Player player = null, bool componetcheck = false)
        {
            UdonBehaviour component = gameObject.GetComponent<UdonBehaviour>();
            if (!(player != null))
            {
                if (!componetcheck)
                {
                    if (player == VRCPlayer.field_Internal_Static_VRCPlayer_0._player)
                    {
                        component.SendCustomEvent(udonEvent);
                        return;
                    }
                    component.SendCustomNetworkEvent(0, udonEvent);
                }
                return;
            }
            SetEventOwner(gameObject, player);
            component.SendCustomNetworkEvent((VRC.Udon.Common.Interfaces.NetworkEventTarget)1, udonEvent);

        }
        public static void SetEventOwner(this GameObject gameObject, VRC.Player player)
        {
            if (GrabOwner(gameObject) != player)
            {
                Networking.SetOwner(player.field_Private_VRCPlayerApi_0, gameObject);
            }
        }
        public static VRC.Player GrabOwner(this GameObject gameObject)
        {
            foreach (VRC.Player player in PlayerManager.field_Private_Static_PlayerManager_0.field_Private_List_1_Player_0)
            {
                if (player.field_Private_VRCPlayerApi_0.IsOwner(gameObject))
                {
                    return player;
                }
            }
            return null;
        }

        public static void TargetedEvent(string udonevent)
        {
            GameObject playernode = GameObject.Find("Player Nodes");
            Udonsend( playernode, udonevent, IUserExtension.SelectedIUser().GetPlayer(), false);         
        }
        /*public static void Ass()
        {
         foreach (Transform player in playernode.GetComponentsInChildren<Transform>())
        player.gameObject.Udonsend(udonevent, IUserExtension.SelectedIUser().GetPlayer(), false);
            }*/
    }
}
