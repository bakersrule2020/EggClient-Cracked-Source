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
using VRC.SDK3.Components;

namespace EggClient.ObjectsM
{
    class Murder1
    {
        public static void Lazer()
        {
            if (RoomManager.field_Internal_Static_ApiWorld_0.id == "wrld_858dfdfc-1b48-4e1e-8a43-f0edc611e5fe")
            {
                Transform transform = GameObject.Find("Game Logic/Weapons/Revolver/Recoil Anim/Recoil/Laser Sight").transform;
                transform.gameObject.SetActive(true);
            }
        }
        public static void NoBloat()
        {
            if (RoomManager.field_Internal_Static_ApiWorld_0.id == "wrld_858dfdfc-1b48-4e1e-8a43-f0edc611e5fe")
            {
                Transform transform = GameObject.Find("Patreon Canvas/Background").transform;
                transform.gameObject.SetActive(false);

                Transform transform1 = GameObject.Find("Patreon Canvas/Outline").transform;
                transform1.gameObject.SetActive(false);

                Transform transform2 = GameObject.Find("Game Logic/Signs").transform;
                transform2.gameObject.SetActive(false);

                Transform transform3 = GameObject.Find("Game Logic/Signs").transform;
                transform3.gameObject.SetActive(false);

               /* Transform transform7 = GameObject.Find("Dining").transform.GetChild(fire);
                Transform fire = transform7.name.Contains("Fireplace");*/

               /* transform7.gameObject.SetActive(false);*/

                Transform transform11 = GameObject.Find("Environment/Library/Fireplace fire").transform;
                transform11.gameObject.SetActive(false);
            }
        }
        public static void NoDoorColiders()
        {
            if (RoomManager.field_Internal_Static_ApiWorld_0.id == "wrld_858dfdfc-1b48-4e1e-8a43-f0edc611e5fe")
            {
                Transform transform = GameObject.Find("Environment/Doors/Door/Door Anim/Closed collision geo").transform;
                GameObject.Destroy((GameObject)transform.gameObject);

                Transform transform1 = GameObject.Find("Environment/Doors/Door (1)/Door Anim/Closed collision geo").transform;
                GameObject.Destroy((GameObject)transform1.gameObject);

                Transform transform2 = GameObject.Find("Environment/Doors/Door (3)/Door Anim/Closed collision geo").transform;
                GameObject.Destroy((GameObject)transform2.gameObject);

                Transform transform3 = GameObject.Find("Environment/Doors/Door (4)/Door Anim/Closed collision geo").transform;
                GameObject.Destroy((GameObject)transform3.gameObject);

                Transform transform4 = GameObject.Find("Environment/Doors/Door (5)/Door Anim/Closed collision geo").transform;
                GameObject.Destroy((GameObject)transform4.gameObject);

                Transform transform5 = GameObject.Find("Environment/Doors/Door (6)/Door Anim/Closed collision geo").transform;
                GameObject.Destroy((GameObject)transform5.gameObject);

                Transform transform6 = GameObject.Find("Environment/Doors/Door (7)/Door Anim/Closed collision geo").transform;
                GameObject.Destroy((GameObject)transform6.gameObject);

                Transform transform7 = GameObject.Find("Environment/Doors/Door (15)/Door Anim/Closed collision geo").transform;
                GameObject.Destroy((GameObject)transform7.gameObject);

                Transform transform8 = GameObject.Find("Environment/Doors/Door (16)/Door Anim/Closed collision geo").transform;
                GameObject.Destroy((GameObject)transform8.gameObject);

                Transform transform9 = GameObject.Find("Environment/Doors/Door (8)/Door Anim/Closed collision geo").transform;
                GameObject.Destroy((GameObject)transform9.gameObject);

                Transform transform10 = GameObject.Find("Environment/Doors/Door (13)/Door Anim/Closed collision geo").transform;
                GameObject.Destroy((GameObject)transform10.gameObject);

                Transform transform11 = GameObject.Find("Environment/Doors/Door (17)/Door Anim/Closed collision geo").transform;
                GameObject.Destroy((GameObject)transform11.gameObject);

                Transform transform12 = GameObject.Find("Environment/Doors/Door (18)/Door Anim/Closed collision geo").transform;
                GameObject.Destroy((GameObject)transform12.gameObject);

                Transform transform13 = GameObject.Find("Environment/Doors/Door (19)/Door Anim/Closed collision geo").transform;
                GameObject.Destroy((GameObject)transform13.gameObject);

                Transform transform14 = GameObject.Find("Environment/Doors/Door (20)/Door Anim/Closed collision geo").transform;
                GameObject.Destroy((GameObject)transform14.gameObject);

                Transform transform15 = GameObject.Find("Environment/Doors/Door (21)/Door Anim/Closed collision geo").transform;
                GameObject.Destroy((GameObject)transform15.gameObject);

                Transform transform16 = GameObject.Find("Environment/Doors/Door (22)/Door Anim/Closed collision geo").transform;
                GameObject.Destroy((GameObject)transform16.gameObject);

                Transform transform17 = GameObject.Find("Environment/Doors/Door (23)/Door Anim/Closed collision geo").transform;
                GameObject.Destroy((GameObject)transform17.gameObject);

                Transform transform18 = GameObject.Find("Environment/Doors/Door (14)/Door Anim/Closed collision geo").transform;
                GameObject.Destroy((GameObject)transform18.gameObject);
            }
        }
        public static void PickupSteal()
        {
            VRC_Pickup[] PickupsSteal = Resources.FindObjectsOfTypeAll<VRC_Pickup>().ToArray();
            for (int i = 0; i < PickupsSteal.Length; i++)
            {
                if ((bool)PickupsSteal[i].gameObject)
                {
                    PickupsSteal[i].DisallowTheft = false;
                }
            }
        }
        public static void FixBounds()
        {
            if (RoomManager.field_Internal_Static_ApiWorld_0.id == "wrld_858dfdfc-1b48-4e1e-8a43-f0edc611e5fe")
            {
                ((Behaviour)GameObject.Find("Game Logic").GetComponent<UdonBehaviour>()).enabled = false;
                GameObject.Find("Game Logic/Game Area Bounds").transform.localScale = new Vector3(1000f, 1000f, 1000f); return;
            }
        }
        public static void ResetBounds()
        {
            if (RoomManager.field_Internal_Static_ApiWorld_0.id == "wrld_858dfdfc-1b48-4e1e-8a43-f0edc611e5fe")
            {
                ((Behaviour)GameObject.Find("Game Logic").GetComponent<UdonBehaviour>()).enabled = true;
                GameObject.Find("Game Logic/Game Area Bounds").transform.localScale = new Vector3(77.2646f, 7.938f, 43.289f);
            }
        }
        public static void PrisonGive(string ObjectName)
        {
            foreach (GameObject item in Resources.FindObjectsOfTypeAll<GameObject>())
            {
                if (item.name.Contains(ObjectName) && (!item.name.Contains("Give")) && (!item.name.Contains("Teleport")))
                {
                    Networking.SetOwner(VRCPlayer.field_Internal_Static_VRCPlayer_0.field_Private_VRCPlayerApi_0, item);
                    item.transform.position = VRCPlayer.field_Internal_Static_VRCPlayer_0.transform.position + new Vector3(0f, 0.1f, 0f);
                }
            }
        }
        public static void NoDoorsPrison()
        {
            GameObject door1 = GameObject.Find("Prison/Cells");
            GameObject door2 = GameObject.Find("Prison/Lit Prison/Building/Yard/Cars");
            GameObject door3 = GameObject.Find("Prison/Doors");
            door1.transform.position = new Vector3(0.0f, 100f, 0.0f);
            door2.transform.position = new Vector3(0.0f, 100f, 0.0f);
            door3.transform.position = new Vector3(0.0f, 100f, 0.0f);
        }
        public static void NoWantedZones()
        {
            GameObject Wantedzones = GameObject.Find("Prison/Wanted Zones");
            Wantedzones.transform.position = new Vector3(0.0f, 100f, 0.0f);
        }
    }


}
