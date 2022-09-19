using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using VRC;

namespace EggClient.MurderHacks
{
    public static class Misc1
    {
		public static Player GetPlayer() => Player.prop_Player_0;
		public static void RoleAssign(string udonevent)
		{
			GameObject gameObject = GameObject.Find("Player Nodes");
			foreach (Transform transform in gameObject.GetComponentsInChildren<Transform>())
			{
				if (transform.name != gameObject.name)
				{
					transform.gameObject.Udonsend(udonevent, GetPlayer(), false);
				}
			}
		}
		//public static IEnumerator BanPrank()
		//{
		//	yield return (object)new WaitForSeconds(20f);
		//	VRCUiManager.prop_VRCUiManager_0.prop_VRCUiPopupManager_0.Method_Public_Void_String_String_Single_0("[ERROR]\n[Moderator Ban]", "You have been banned.\n All content on account removed.\n This ban is permanent.\n Reason: Inappropriate conduct:\ncreation of sexually explicit avatars.\n Contact Support: D_N_@vrchat.com", 20f);
		//}
		//public static IEnumerator Alert(string title, string msg)
	//	{
		//	yield return (object)new WaitForSeconds(20f);
		//	VRCUiManager.prop_VRCUiManager_0.prop_VRCUiPopupManager_0.Method_Public_Void_String_String_Single_0($"[ERROR]\n[{title}]", $"{msg}", 20f);
		//}
	}
}
