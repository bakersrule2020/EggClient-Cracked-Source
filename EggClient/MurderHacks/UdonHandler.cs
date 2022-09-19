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

namespace EggClient.Murder4
{ //need to have bool on false after leave
	class Murder
	{
		public static bool KillLoop = false;
		public static void BystanderW()
		{
			if (Extentions.Extentions.MurderWorld())
			{
				GameObject.Find("/Game Logic").GetComponent<VRC.Udon.UdonBehaviour>().SendCustomNetworkEvent(0, "SyncVictoryB");
			}
		}
		public static void MurderW()
		{
			if (Extentions.Extentions.MurderWorld())
			{

				GameObject.Find("/Game Logic").GetComponent<VRC.Udon.UdonBehaviour>().SendCustomNetworkEvent(0, "SyncVictoryM");

			}
		}
		public static void Killall()
		{
			if (Extentions.Extentions.MurderWorld())
			{

				GameObject.Find("/Game Logic").GetComponent<VRC.Udon.UdonBehaviour>().SendCustomNetworkEvent(0, "KillLocalPlayer");

			}
		}
		public static void BringAllKnifes()
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
					Networking.SetOwner(Extentions.Extentions.LocalPlayer.field_Private_VRCPlayerApi_0, gameObject);
					gameObject.transform.position = Extentions.Extentions.LocalPlayer.GetVRCPlayer().transform.position + new Vector3(0f, 0.1f, 0f);
				}
			}
		}
		public static void Luger()
		{
			VRC.Player PlayerPosition = UnityEngine.Object.FindObjectOfType<VRC.Player>();
			GameObject.Find("Luger (0)").transform.position = PlayerPosition.transform.position;

			foreach (VRC_Pickup vrcPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
			{
				VRC.Player player0 = VRC.Player.prop_Player_0;
				Transform transform1 = GameObject.Find("Game Logic/Weapons/Unlockables/Luger (0)").transform;
				Networking.LocalPlayer.TakeOwnership(((Component)transform1).gameObject);
				((Component)transform1).transform.position = player0.transform.position + new Vector3(0f, 0.1f, 0f);
			}
		}
		public static void XmasGun()
		{
			Transform transform = GameObject.Find("Game Logic/Weapons/Revolver/Recoil Anim/Recoil/geo (xmas)").transform;
			transform.gameObject.SetActive(true);
		}
		public static void Shotgun()
		{
			VRC.Player PlayerPosition = UnityEngine.Object.FindObjectOfType<VRC.Player>();
			GameObject.Find("Shotgun (0)").transform.position = PlayerPosition.transform.position;

			foreach (VRC_Pickup vrcPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
			{
				VRC.Player player0 = VRC.Player.prop_Player_0;
				Transform transform1 = GameObject.Find("Game Logic/Weapons/Unlockables/Shotgun (0)").transform;
				Networking.LocalPlayer.TakeOwnership(((Component)transform1).gameObject);
				((Component)transform1).transform.position = player0.transform.position + new Vector3(0f, 0.1f, 0f);
			}
		}
		public static void Frag()
		{
			VRC.Player PlayerPosition = UnityEngine.Object.FindObjectOfType<VRC.Player>();
			GameObject.Find("Frag (0)").transform.position = PlayerPosition.transform.position;

			foreach (VRC_Pickup vrcPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
			{
				VRC.Player player0 = VRC.Player.prop_Player_0;
				Transform transform1 = GameObject.Find("Game Logic/Weapons/Unlockables/Frag (0)").transform;
				Networking.LocalPlayer.TakeOwnership(((Component)transform1).gameObject);
				((Component)transform1).transform.position = player0.transform.position + new Vector3(0f, 0.1f, 0f);

			}
		}
		public static void SelfBystander()
		{
			Misc1.RoleAssign("SyncAssignB");
		}
		public static void SelfMurderer()
		{
			Misc1.RoleAssign("SyncAssignM");
		}
		public static void Revolver()
		{
			if (Extentions.Extentions.MurderWorld())
			{
				VRC.Player PlayerPosition = UnityEngine.Object.FindObjectOfType<VRC.Player>();
				GameObject.Find("Revolver").transform.position = PlayerPosition.transform.position;

				foreach (VRC_Pickup vrcPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
				{
					VRC.Player player0 = VRC.Player.prop_Player_0;
					Transform transform1 = GameObject.Find("Game Logic/Weapons/Revolver").transform;
					Networking.LocalPlayer.TakeOwnership(((Component)transform1).gameObject);
					((Component)transform1).transform.position = player0.transform.position + new Vector3(0f, 0.1f, 0f);
				}
			}
		}
		public static void StartCount()
		{
			if (Extentions.Extentions.MurderWorld())
			{
				UdonBehaviour transform = GameObject.Find("Game Logic").GetComponent<UdonBehaviour>();
				transform.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncCountdown");
			}
		}
		public static void Abort()
		{
			if (Extentions.Extentions.MurderWorld())
			{
				GameObject.Find("/Game Logic").GetComponent<VRC.Udon.UdonBehaviour>().SendCustomNetworkEvent(0, "SyncAbort");
			}
		}
		public static void BreakDoors()
		{
			UdonBehaviour transform = GameObject.Find("Door").GetComponent<UdonBehaviour>();
			transform.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncShove");
			transform.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncUnlockR");
			transform.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncOpenR");

			UdonBehaviour transform0 = GameObject.Find("Door/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform0.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform1 = GameObject.Find("Door (1)").GetComponent<UdonBehaviour>();
			transform1.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncShove");
			transform1.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncUnlockR");
			transform1.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncOpenR");

			UdonBehaviour transform01 = GameObject.Find("Door (1)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform01.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform2 = GameObject.Find("Door (3)").GetComponent<UdonBehaviour>();
			transform2.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncShove");
			transform2.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncUnlockR");
			transform2.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncOpenR");

			UdonBehaviour transform02 = GameObject.Find("Door (3)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform02.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform3 = GameObject.Find("Door (4)").GetComponent<UdonBehaviour>();
			transform3.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncShove");
			transform3.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncUnlockR");
			transform3.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncOpenR");

			UdonBehaviour transform03 = GameObject.Find("Door (4)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform03.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform4 = GameObject.Find("Door (5)").GetComponent<UdonBehaviour>();
			transform4.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncShove");
			transform4.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncUnlockR");
			transform4.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncOpenR");

			UdonBehaviour transform04 = GameObject.Find("Door (5)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform04.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform5 = GameObject.Find("Door (6)").GetComponent<UdonBehaviour>();
			transform5.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncShove");
			transform5.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncUnlockR");
			transform5.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncOpenR");

			UdonBehaviour transform05 = GameObject.Find("Door (6)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform05.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform6 = GameObject.Find("Door (7)").GetComponent<UdonBehaviour>();
			transform6.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncShove");
			transform6.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncUnlockR");
			transform6.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncOpenR");

			UdonBehaviour transform06 = GameObject.Find("Door (7)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform06.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform7 = GameObject.Find("Door (15)").GetComponent<UdonBehaviour>();
			transform7.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncShove");
			transform7.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncUnlockR");
			transform7.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncOpenR");

			UdonBehaviour transform07 = GameObject.Find("Door (15)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform07.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform9 = GameObject.Find("Door (16)").GetComponent<UdonBehaviour>();
			transform9.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncShove");
			transform9.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncUnlockR");
			transform9.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncOpenR");

			UdonBehaviour transform09 = GameObject.Find("Door (16)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform09.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform10 = GameObject.Find("Door (8)").GetComponent<UdonBehaviour>();
			transform10.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncShove");
			transform10.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncUnlockR");
			transform10.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncOpenR");

			UdonBehaviour transform010 = GameObject.Find("Door (8)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform010.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform11 = GameObject.Find("Door (13)").GetComponent<UdonBehaviour>();
			transform11.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncShove");
			transform11.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncUnlockR");
			transform11.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncOpenR");

			UdonBehaviour transform011 = GameObject.Find("Door (13)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform011.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");
			//
			UdonBehaviour transform12 = GameObject.Find("Door (17)").GetComponent<UdonBehaviour>();
			transform12.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncShove");
			transform12.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncUnlockR");
			transform12.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncOpenR");

			UdonBehaviour transform012 = GameObject.Find("Door (17)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform012.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform13 = GameObject.Find("Door (18)").GetComponent<UdonBehaviour>();
			transform13.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncShove");
			transform13.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncUnlockR");
			transform13.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncOpenR");

			UdonBehaviour transform013 = GameObject.Find("Door (18)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform013.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform14 = GameObject.Find("Door (19)").GetComponent<UdonBehaviour>();
			transform14.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncShove");
			transform14.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncUnlockR");
			transform14.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncOpenR");

			UdonBehaviour transform014 = GameObject.Find("Door (19)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform014.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform15 = GameObject.Find("Door (20)").GetComponent<UdonBehaviour>();
			transform15.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncShove");
			transform15.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncUnlockR");
			transform15.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncOpenR");

			UdonBehaviour transform015 = GameObject.Find("Door (20)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform015.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform16 = GameObject.Find("Door (21)").GetComponent<UdonBehaviour>();
			transform16.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncShove");
			transform16.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncUnlockR");
			transform16.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncOpenR");

			UdonBehaviour transform016 = GameObject.Find("Door (21)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform016.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform17 = GameObject.Find("Door (22)").GetComponent<UdonBehaviour>();
			transform17.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncShove");
			transform17.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncUnlockR");
			transform17.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncOpenR");

			UdonBehaviour transform017 = GameObject.Find("Door (22)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform017.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform18 = GameObject.Find("Door (23)").GetComponent<UdonBehaviour>();
			transform18.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncShove");
			transform18.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncUnlockR");
			transform18.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncOpenR");

			UdonBehaviour transform018 = GameObject.Find("Door (23)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform018.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");


			UdonBehaviour transform19 = GameObject.Find("Door (14)").GetComponent<UdonBehaviour>();
			transform19.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncShove");
			transform19.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncUnlockR");
			transform19.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncOpenR");

			UdonBehaviour transform019 = GameObject.Find("Door (14)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform019.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");
		}
		public static void SlamDoors()
		{
			UdonBehaviour transform = GameObject.Find("Door").GetComponent<UdonBehaviour>();
			transform.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncLock");

			UdonBehaviour transform0 = GameObject.Find("Door/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform0.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform1 = GameObject.Find("Door (1)").GetComponent<UdonBehaviour>();
			transform1.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncLock");

			UdonBehaviour transform01 = GameObject.Find("Door (1)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform01.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform2 = GameObject.Find("Door (3)").GetComponent<UdonBehaviour>();
			transform2.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncLock");

			UdonBehaviour transform02 = GameObject.Find("Door (3)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform02.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform3 = GameObject.Find("Door (4)").GetComponent<UdonBehaviour>();
			transform3.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncLock");

			UdonBehaviour transform03 = GameObject.Find("Door (4)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform03.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform4 = GameObject.Find("Door (5)").GetComponent<UdonBehaviour>();
			transform4.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncLock");

			UdonBehaviour transform04 = GameObject.Find("Door (5)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform04.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform5 = GameObject.Find("Door (6)").GetComponent<UdonBehaviour>();
			transform5.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncLock");

			UdonBehaviour transform05 = GameObject.Find("Door (6)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform05.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform6 = GameObject.Find("Door (7)").GetComponent<UdonBehaviour>();
			transform6.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncLock");

			UdonBehaviour transform06 = GameObject.Find("Door (7)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform06.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform7 = GameObject.Find("Door (15)").GetComponent<UdonBehaviour>();
			transform7.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncLock");

			UdonBehaviour transform07 = GameObject.Find("Door (15)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform07.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform9 = GameObject.Find("Door (16)").GetComponent<UdonBehaviour>();
			transform9.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncLock");

			UdonBehaviour transform09 = GameObject.Find("Door (16)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform09.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform10 = GameObject.Find("Door (8)").GetComponent<UdonBehaviour>();
			transform10.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncLock");

			UdonBehaviour transform010 = GameObject.Find("Door (8)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform010.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform11 = GameObject.Find("Door (13)").GetComponent<UdonBehaviour>();
			transform11.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncLock");

			UdonBehaviour transform011 = GameObject.Find("Door (13)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform011.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform12 = GameObject.Find("Door (17)").GetComponent<UdonBehaviour>();
			transform12.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncLock");

			UdonBehaviour transform012 = GameObject.Find("Door (17)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform012.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform13 = GameObject.Find("Door (18)").GetComponent<UdonBehaviour>();
			transform13.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncLock");

			UdonBehaviour transform013 = GameObject.Find("Door (18)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform013.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform14 = GameObject.Find("Door (19)").GetComponent<UdonBehaviour>();
			transform14.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncLock");

			UdonBehaviour transform014 = GameObject.Find("Door (19)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform014.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform15 = GameObject.Find("Door (20)").GetComponent<UdonBehaviour>();
			transform15.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncLock");

			UdonBehaviour transform015 = GameObject.Find("Door (20)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform015.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform16 = GameObject.Find("Door (21)").GetComponent<UdonBehaviour>();
			transform16.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncLock");

			UdonBehaviour transform016 = GameObject.Find("Door (21)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform016.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform17 = GameObject.Find("Door (22)").GetComponent<UdonBehaviour>();
			transform17.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncLock");

			UdonBehaviour transform017 = GameObject.Find("Door (22)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform017.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform18 = GameObject.Find("Door (23)").GetComponent<UdonBehaviour>();
			transform18.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncLock");

			UdonBehaviour transform018 = GameObject.Find("Door (23)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform018.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");

			UdonBehaviour transform19 = GameObject.Find("Door (14)").GetComponent<UdonBehaviour>();
			transform19.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncLock");

			UdonBehaviour transform019 = GameObject.Find("Door (14)/Sounds/Break Sound").GetComponent<UdonBehaviour>();
			transform019.SendCustomNetworkEvent((NetworkEventTarget)0, "Play");
		}
		public static void MurderAll()
		{
			if (Extentions.Extentions.MurderWorld())
			{
				foreach (var udonEvent in GameObject.FindObjectsOfType<UdonBehaviour>())
				{

					udonEvent.SendCustomNetworkEvent(0, "SyncAssignM");
				}
			}
		}
		public static void Snake()
		{
			GameObject.Find("/Game Logic").transform.Find("Snakes/SnakeDispenser").GetComponent<UdonBehaviour>().SendCustomNetworkEvent(0, "DispenseSnake");
		}
		public static void BlindAll()
		{
			Extentions.Extentions.AllPlayers.ForEach(p =>
			{
				GameObject gameObject = GameObject.Find("Player Nodes");
				foreach (Transform transform in gameObject.GetComponentsInChildren<Transform>())
				{
					if (transform.name != gameObject.name)
					{
						transform.gameObject.Udonsend("SyncFlashbang", p, false);
					}
				}
			});

		}
		public static IEnumerator UnGoldenGun()
		{
			VRCPickup revolver = GameObject.Find("Revolver").GetComponent<VRCPickup>();
			while (true)
			{
				if (((VRC_Pickup)revolver).currentPlayer != null)
				{
					VRCPlayerApi playerVrcPlayerApi = ((VRC_Pickup)revolver).currentPlayer;
					if (playerVrcPlayerApi.displayName.Equals(APIUser.CurrentUser.displayName))
					{
						UdonBehaviour[] revolverEvent = (GameObject.Find("Revolver").GetComponents<UdonBehaviour>());
						revolverEvent[0].SendCustomNetworkEvent(NetworkEventTarget.All, "NonPatronSkin");
						revolverEvent = (UdonBehaviour[])null;
						revolverEvent = (UdonBehaviour[])null;
					}
					yield return (object)null;
					playerVrcPlayerApi = (VRCPlayerApi)null;
					playerVrcPlayerApi = (VRCPlayerApi)null;
				}
				yield return (object)null;
			}
		}
		public static IEnumerator GoldenGun()

		{
			VRCPickup revolver = GameObject.Find("Revolver").GetComponent<VRCPickup>();
			while (true)
			{
				if (revolver.currentPlayer != null)
				{
					VRCPlayerApi playerVrcPlayerApi = revolver.currentPlayer;
					if (playerVrcPlayerApi.displayName.Equals(APIUser.CurrentUser.displayName) && (UnityEngine.Object)GameObject.Find("geo (patron)") == (UnityEngine.Object)null)
					{
						UdonBehaviour[] revolverEvent = (UdonBehaviour[])GameObject.Find("Revolver").GetComponents<UdonBehaviour>();
						revolverEvent[0].SendCustomNetworkEvent(NetworkEventTarget.All, "PatronSkin");
						revolverEvent = (UdonBehaviour[])null;
						revolverEvent = (UdonBehaviour[])null;
					}
					yield return (object)null;
					playerVrcPlayerApi = (VRCPlayerApi)null;
					playerVrcPlayerApi = (VRCPlayerApi)null;
				}
				yield return (object)null;
			}
		}
		public static void HudOff()
		{
			Transform transform = GameObject.Find("Game Logic/Player HUD/Death HUD Anim").transform;
			transform.gameObject.SetActive(false);

			Transform transform1 = GameObject.Find("Game Logic/Player HUD/Blind HUD Anim").transform;
			transform1.gameObject.SetActive(false);

			Transform transform2 = GameObject.Find("Game Logic/Player HUD/Flashbang HUD Anim").transform;
			transform2.gameObject.SetActive(false);

			Transform transform3 = GameObject.Find("Game Logic/Player HUD/Clue HUD Anim").transform;
			transform3.gameObject.SetActive(false);
		}
		private static List<UdonBehaviour> lights = new List<UdonBehaviour>();
		public static void LightsOff()
		{
			Transform transform = GameObject.Find("Game Logic/Switch Boxes").transform;
			for (int index = 0; index < transform.childCount; ++index)
				EggClient.Murder4.Murder.lights.Add(((Component)transform.GetChild(index)).GetComponent<UdonBehaviour>());
			for (int index = 0; index < EggClient.Murder4.Murder.lights.Count; ++index)
				EggClient.Murder4.Murder.lights[index].SendCustomNetworkEvent(NetworkEventTarget.All, "SwitchDown");
		}
		public static void LightsOn()
		{
			Transform transform = GameObject.Find("Game Logic/Switch Boxes").transform;
			for (int index = 0; index < transform.childCount; ++index)
				EggClient.Murder4.Murder.lights.Add(((Component)transform.GetChild(index)).GetComponent<UdonBehaviour>());
			for (int index = 0; index < EggClient.Murder4.Murder.lights.Count; ++index)
				EggClient.Murder4.Murder.lights[index].SendCustomNetworkEvent(NetworkEventTarget.All, "SwitchUp");
		}
		public static IEnumerator KillLoopAll()
		{
			if (Extentions.Extentions.MurderWorld())
			{
				GameObject gameObject = GameObject.Find("Player Nodes");
				UdonBehaviour transform = GameObject.Find("Player Nodes").GetComponent<UdonBehaviour>();
				while (KillLoop == true)
				{
					new WaitForSeconds(0.6f);
					transform.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncKill");
					new WaitForSeconds(0.6f);
					transform.SendCustomNetworkEvent((NetworkEventTarget)0, "SyncAssignM");
					yield return new WaitForSeconds(0.6f);
				}
			}
		}
	}
}




