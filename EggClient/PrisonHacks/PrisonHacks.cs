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

namespace EggClient.PrisonHacks
{
	class PrisonHacks
	{
        public static void BringLMG()
        {
            Transform transform12 = GameObject.Find("Crates/Large Rewards/LMG").transform;
            transform12.gameObject.SetActive(true);
            VRC.Player PlayerPosition = UnityEngine.Object.FindObjectOfType<VRC.Player>();
            GameObject.Find("LMG").transform.position = PlayerPosition.transform.position;

            foreach (VRC_Pickup vrcPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
            {

                VRC.Player player0 = VRC.Player.prop_Player_0;
                Transform transform1 = GameObject.Find("Crates/Large Rewards/LMG").transform;
                Networking.LocalPlayer.TakeOwnership(((Component)transform1).gameObject);
                ((Component)transform1).transform.position = player0.transform.position + new Vector3(0f, 0.5f, 0f);

            }
        }
        public static void BringRocket1()
        {
            UdonBehaviour transform2 = GameObject.Find("Loot Crate Control").GetComponent<UdonBehaviour>();
            transform2.SendCustomNetworkEvent((NetworkEventTarget)0, "ClearRewardObjects");

            Transform transform12 = GameObject.Find("Crates/Large Rewards/RPG").transform;
            transform12.gameObject.SetActive(true);
            VRC.Player PlayerPosition = UnityEngine.Object.FindObjectOfType<VRC.Player>();
            GameObject.Find("RPG").transform.position = PlayerPosition.transform.position;

            foreach (VRC_Pickup vrcPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
            {

                VRC.Player player0 = VRC.Player.prop_Player_0;
                Transform transform1 = GameObject.Find("Crates/Large Rewards/RPG").transform;
                Networking.LocalPlayer.TakeOwnership(((Component)transform1).gameObject);
                ((Component)transform1).transform.position = player0.transform.position + new Vector3(0f, 0.5f, 0f);

            }
        }
        public static void BringRocket2()
        {
            UdonBehaviour transform2 = GameObject.Find("Loot Crate Control").GetComponent<UdonBehaviour>();
            transform2.SendCustomNetworkEvent((NetworkEventTarget)0, "ClearRewardObjects");

            Transform transform12 = GameObject.Find("Crates/Large Rewards/RPG (1)").transform;
            transform12.gameObject.SetActive(true);
            VRC.Player PlayerPosition = UnityEngine.Object.FindObjectOfType<VRC.Player>();
            GameObject.Find("RPG (1)").transform.position = PlayerPosition.transform.position;

            foreach (VRC_Pickup vrcPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
            {

                VRC.Player player0 = VRC.Player.prop_Player_0;
                Transform transform1 = GameObject.Find("Crates/Large Rewards/RPG (1)").transform;
                Networking.LocalPlayer.TakeOwnership(((Component)transform1).gameObject);
                ((Component)transform1).transform.position = player0.transform.position + new Vector3(0f, 0.5f, 0f);

            }
        }
        public static void KeyCard()
        {
            ObjectsM.Murder1.PrisonGive("Keycard");
        }
        public static void NoBloat()
        {
            Transform transform = GameObject.Find("Spawn Area/Signs").transform;
            transform.gameObject.SetActive(false);

            Transform transform1 = GameObject.Find("Spawn Area/Mirror").transform;
            transform1.gameObject.SetActive(false);
        }
        public static void BringMoney()
        {
                Player propPlayer0 = Player.prop_Player_0;
                Transform transform1 = GameObject.Find("Items/Money/Money Pile").transform;
                Networking.LocalPlayer.TakeOwnership(transform1.gameObject);            
                transform1.transform.position = propPlayer0.transform.position + new Vector3(0.0f, 0.5f, 0.0f);                          
            }
        
        public static void BringEnergy()
        {
            Transform transform12 = GameObject.Find("Crates/Small Rewards/Energy Drink").transform;
            transform12.gameObject.SetActive(true);
            VRC.Player PlayerPosition = UnityEngine.Object.FindObjectOfType<VRC.Player>();
            GameObject.Find("Energy Drink").transform.position = PlayerPosition.transform.position;

            foreach (VRC_Pickup vrcPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
            {

                VRC.Player player0 = VRC.Player.prop_Player_0;
                Transform transform1 = GameObject.Find("Crates/Small Rewards/Energy Drink").transform;
                Networking.LocalPlayer.TakeOwnership(((Component)transform1).gameObject);
                ((Component)transform1).transform.position = player0.transform.position + new Vector3(0f, 0.5f, 0f);

            }
        }
        public static void BringP90()
        {
            Transform transform12 = GameObject.Find("Crates/Large Rewards/P90").transform;
            transform12.gameObject.SetActive(true);
            VRC.Player PlayerPosition = UnityEngine.Object.FindObjectOfType<VRC.Player>();
            GameObject.Find("P90").transform.position = PlayerPosition.transform.position;

            foreach (VRC_Pickup vrcPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
            {

                VRC.Player player0 = VRC.Player.prop_Player_0;
                Transform transform1 = GameObject.Find("Crates/Large Rewards/P90").transform;
                Networking.LocalPlayer.TakeOwnership(((Component)transform1).gameObject);
                ((Component)transform1).transform.position = player0.transform.position + new Vector3(0f, 0.5f, 0f);

            }
        }
        public static void BringAK47()
        {
            Transform transform12 = GameObject.Find("Crates/Large Rewards/AK47").transform;
            transform12.gameObject.SetActive(true);
            VRC.Player PlayerPosition = UnityEngine.Object.FindObjectOfType<VRC.Player>();
            GameObject.Find("AK47").transform.position = PlayerPosition.transform.position;

            foreach (VRC_Pickup vrcPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
            {

                VRC.Player player0 = VRC.Player.prop_Player_0;
                Transform transform1 = GameObject.Find("Crates/Large Rewards/AK47").transform;
                Networking.LocalPlayer.TakeOwnership(((Component)transform1).gameObject);
                ((Component)transform1).transform.position = player0.transform.position + new Vector3(0f, 0.5f, 0f);

            }
        }
        public static void BringKnife1()
        {
            VRC.Player PlayerPosition = UnityEngine.Object.FindObjectOfType<VRC.Player>();
            GameObject.Find("Knife").transform.position = PlayerPosition.transform.position;
        }
        public static void BringKnife2()
        {
            VRC.Player PlayerPosition = UnityEngine.Object.FindObjectOfType<VRC.Player>();
            GameObject.Find("Knife (1)").transform.position = PlayerPosition.transform.position;
        }
        public static void BringSniper()
        {
            Transform transform12 = GameObject.Find("Items/Static Guns/Sniper").transform;
            transform12.gameObject.SetActive(true);
            VRC.Player PlayerPosition = UnityEngine.Object.FindObjectOfType<VRC.Player>();
            GameObject.Find("Sniper").transform.position = PlayerPosition.transform.position;

            foreach (VRC_Pickup vrcPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
            {

                VRC.Player player0 = VRC.Player.prop_Player_0;
                Transform transform1 = GameObject.Find("Items/Static Guns/Sniper").transform;
                Networking.LocalPlayer.TakeOwnership(((Component)transform1).gameObject);
                ((Component)transform1).transform.position = player0.transform.position + new Vector3(0f, 0.5f, 0f);

            }
        }
    }
}