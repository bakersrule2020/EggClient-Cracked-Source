using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using VRC.SDKBase;
using EggClient.Extentions;
namespace EggClient
{
    internal class BlackCatHat
    {
        public static bool Plugerbool = false;
        public static void CatTargetGive()
        {
            Transform gameObject = GameObject.Find("plunger").transform;
            GameObject gameObject1 = GameObject.Find("plunger").gameObject;

            Networking.SetOwner(VRCPlayer.field_Internal_Static_VRCPlayer_0.field_Private_VRCPlayerApi_0, gameObject1);

            gameObject.transform.position = EggClient.Extentions.Extentions.LocalPlayer.transform.position + new Vector3(0f, 1f, 0f);
            gameObject.transform.eulerAngles = new Vector3(270f, 240f, 0.0f);
        }

        public static void CatTargetGiveTarget()
        {
            Transform gameObject = GameObject.Find("plunger").transform;
            GameObject gameObject1 = GameObject.Find("plunger").gameObject;

            Networking.SetOwner(VRCPlayer.field_Internal_Static_VRCPlayer_0.field_Private_VRCPlayerApi_0, gameObject1);

            gameObject.transform.position = IUserExtension.GetVRCPlayer().transform.position + new Vector3(0f, 1f, 0f);
            gameObject.transform.eulerAngles = new Vector3(270f, 240f, 0.0f);
        }
    }
}
        

