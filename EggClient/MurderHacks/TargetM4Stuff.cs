using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using MelonLoader;
using UnityEngine.UI;
using System.Threading;
using System.Collections;
using EggClient;
using VRC;
using EggClient.MurderHacks;
using VRC.Udon.Common.Interfaces;
using VRC.SDK3.Components;
using VRC.Core;
using Il2CppSystem.Threading.Tasks;
using EggClient.Extentions;


namespace EggClient.MurderHacks
{
    internal class TargetM4Stuff
    {
        public static void KillTarget()
        {
            if (RoomManager.field_Internal_Static_ApiWorld_0.id == "wrld_858dfdfc-1b48-4e1e-8a43-f0edc611e5fe")
            {
                BlackCat.TargetedEvent("SyncKill");
            }
            if (RoomManager.field_Internal_Static_ApiWorld_0.id == "wrld_dd036610-a246-4f52-bf01-9d7cea3405d7")
            {
                BlackCat.TargetedEvent("SyncKill");
            }
        }

        public static void MakeMurder()
        {
            if (RoomManager.field_Internal_Static_ApiWorld_0.id == "wrld_858dfdfc-1b48-4e1e-8a43-f0edc611e5fe")
            {
                BlackCat.TargetedEvent("SyncAssignM");
            }
        }

        public static void MakeBystander()
        {
            if (RoomManager.field_Internal_Static_ApiWorld_0.id == "wrld_858dfdfc-1b48-4e1e-8a43-f0edc611e5fe")
            {
                BlackCat.TargetedEvent("SyncAssignB");
            }
        }

        public static void TPAllKnives(VRCPlayer p)
		{
			if (Extentions.Extentions.MurderWorld())
			{
				List<GameObject> Knifes = new List<GameObject>()
			{
				GameObject.Find("Game Logic").transform.Find("Weapons/Knife (0)").gameObject,
				GameObject.Find("Game Logic").transform.Find("Weapons/Knife (1)").gameObject,
				GameObject.Find("Game Logic").transform.Find("Weapons/Knife (2)").gameObject,
				GameObject.Find("Game Logic").transform.Find("Weapons/Knife (3)").gameObject,
				GameObject.Find("Game Logic").transform.Find("Weapons/Knife (4)").gameObject,
				GameObject.Find("Game Logic").transform.Find("Weapons/Knife (5)").gameObject,

			};
				foreach (var gameObject in Knifes)
				{
					Networking.SetOwner(p.field_Private_VRCPlayerApi_0, gameObject);
					gameObject.transform.position = p.transform.position + new Vector3(0f, 0.1f, 0f);
				}
			}
		}
		public static void BringLuger(VRCPlayer p)
		{
			VRC.Player PlayerPosition = UnityEngine.Object.FindObjectOfType<VRC.Player>();
			GameObject.Find("Luger (0)").transform.position = PlayerPosition.transform.position;

			foreach (VRC_Pickup vrcPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
			{
				VRC.Player player0 = p.prop_Player_0;
				Transform transform1 = GameObject.Find("Game Logic/Weapons/Unlockables/Luger (0)").transform;
				Networking.LocalPlayer.TakeOwnership(((Component)transform1).gameObject);
				((Component)transform1).transform.position = player0.transform.position + new Vector3(0f, 0.1f, 0f);
			}
		}
		public static void BringShotgun(VRCPlayer p)
		{
			VRC.Player PlayerPosition = UnityEngine.Object.FindObjectOfType<VRC.Player>();
			GameObject.Find("Shotgun (0)").transform.position = PlayerPosition.transform.position;

			foreach (VRC_Pickup vrcPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
			{
				VRC.Player player0 = p.prop_Player_0;
				Transform transform1 = GameObject.Find("Game Logic/Weapons/Unlockables/Shotgun (0)").transform;
				Networking.LocalPlayer.TakeOwnership(((Component)transform1).gameObject);
				((Component)transform1).transform.position = player0.transform.position + new Vector3(0f, 0.1f, 0f);
			}
		}
		public static void BringFrag(VRCPlayer p)
		{
			VRC.Player PlayerPosition = UnityEngine.Object.FindObjectOfType<VRC.Player>();
			GameObject.Find("Frag (0)").transform.position = PlayerPosition.transform.position;

			foreach (VRC_Pickup vrcPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
			{
				VRC.Player player0 = p.prop_Player_0;
				Transform transform1 = GameObject.Find("Game Logic/Weapons/Unlockables/Frag (0)").transform;
				Networking.LocalPlayer.TakeOwnership(((Component)transform1).gameObject);
				((Component)transform1).transform.position = player0.transform.position + new Vector3(0f, 0.1f, 0f);

			}
		}
    }
}
