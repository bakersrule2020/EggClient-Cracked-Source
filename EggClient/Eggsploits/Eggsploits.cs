using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EggClient.MurderHacks;
using Il2CppSystem.Threading.Tasks;
using MelonLoader;
using UnityEngine;
using UnityEngine.UI;
using VRC;
using VRC.SDKBase;
using UnhollowerBaseLib;
using System.Diagnostics;

namespace EggClient
{
    internal class Eggsploits1
    {
        public static bool toggled = false;
        public static bool toggledUwU = false;
        public static void OnEnable()
        {
            toggled = true;
            MelonCoroutines.Start(ItemLagger());
            MelonCoroutines.Start(ItemLagger2());
        }

        public static void OnDisable()
        {
            toggled = false;
            MelonCoroutines.Stop(ItemLagger());
            MelonCoroutines.Stop(ItemLagger2());
        }

        public static IEnumerator ItemLagger()
        {
            while (toggled)
            {
                foreach (VRC_Pickup VRCPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
                {
                    Networking.LocalPlayer.TakeOwnership(VRCPickup.gameObject);
                    VRCPickup.transform.position = Misc1.GetPlayer().transform.position + new Vector3(0f, 0.15f, 0f);
                }
                yield return new WaitForSeconds(0.3f);
            }
            yield break;
        }

        public static IEnumerator ItemLagger2()
        {
            while (toggled)
            {
                foreach (VRC_Pickup VRCPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
                {
                    Networking.LocalPlayer.TakeOwnership(VRCPickup.gameObject);
                    VRCPickup.transform.position = Misc1.GetPlayer().transform.position + new Vector3(0f, 9.998E+07f, 0);
                }
                yield return new WaitForSeconds(0.3f);
            }
            yield break;
        }
        /* public static void PortalSpam()
         {
             VRCUiPopupManager vRCUiPopupManager = new VRCUiPopupManager();
             Action<string, Il2CppSystem.Collections.Generic.List<KeyCode>, Text> value = (s, k, t) =>
                              {
                                  if (string.IsNullOrEmpty(s))
                                      return;

                                  Extentions.Extentions.AllPlayers.ForEach(player =>
                                  {
                                      if (player.name.Contains(s.ToString()))
                                      {
                                          MelonCoroutines.Start(Shitass(player));
                                      }
                                  });




                              };
             vRCUiPopupManager.Method_Public_Void_String_String_InputType_Boolean_String_Action_3_String_List_1_KeyCode_Text_String_Boolean_Action_1_VRCUiPopup_PDM_0("Set Target Player", "PlayerName", InputField.InputType.Standard, false, "Submit",
                 value, "Enter Text...", true, null);
 */




        /*     public static IEnumerator Shitass(Player player)
             {
                 while (Main.PortalSpam)
                 {
                     PortalPlayer(player, 3f, false);
                     yield return new WaitForSeconds(2.0f);
                 }
             }
             public static void PortalPlayer(Player player, float distance, bool blank = false)
             {
                 if (player == null) return;

                 PortalPosition(player.transform.position + player.transform.forward * distance, player.transform.rotation, blank);
             }
             public static Player player;
             public static System.Collections.IEnumerator DestroyDelayed(float seconds, UnityEngine.Object obj)
             {
                 yield return new WaitForSeconds(seconds);
                 UnityEngine.Object.Destroy(obj);
             }

             public static GameObject PortalPosition(Vector3 position, Quaternion rotation, bool blank = false)
             {
                 GameObject portal = Networking.Instantiate(VRC_EventHandler.VrcBroadcastType.Always, "Portals/PortalInternalDynamic", position, rotation);

                 if (portal == null) return null;

                 Networking.RPC(RPC.Destination.AllBufferOne, portal, nameof(PortalInternal.ConfigurePortal), new Il2CppSystem.Object[] {
                     "wrld_5b89c79e-c340-4510-be1b-476e9fcdedcc",
                     (player != null)
                     ? $"Shitass\n{player.field_Private_APIUser_0.displayName}\0"
                     : "Shitass",
                     new Il2CppSystem.Int32
                     {
                         m_value = -666
                     }.BoxIl2CppObject()
                 });

                 if (blank) MelonCoroutines.Start(DestroyDelayed(1.0f, portal.GetComponent<PortalInternal>()));

                 return portal;
             }*/

        /*  public static void Desync()
          {
              if (GeneralUtils._AsukaDesync == true)
              {
                  try
                  {
                      Delay += Time.deltaTime;
                      if (Delay > 1f)
                      {
                          for (int i = 0; i < 420; i++)
                          {
                              byte[] Bytes = Convert.FromBase64String(_event);
                              int idfirst2 = int.Parse(Networking.LocalPlayer.playerId + "00001");
                              byte[] IDOut2 = BitConverter.GetBytes(idfirst2);

                              Buffer.BlockCopy(IDOut2, 0, Bytes, 0, 4);
                              OpRaiseEvent(5, Bytes, new RaiseEventOptions
                              {
                                  field_Public_ReceiverGroup_0 = ReceiverGroup.Others,
                                  field_Public_EventCaching_0 = EventCaching.DoNotCache
                              }, default);
                          }
                          Delay = 0f;
                      }
                  }
                  catch { }

              }
          }
          public static void OpRaiseEvent(byte code, object customObject, RaiseEventOptions RaiseEventOptions, SendOptions sendOptions)
          {
              Il2CppSystem.Object customObject2 = Serialization.FromManagedToIL2CPP<Il2CppSystem.Object>(customObject);
              OpRaiseEvent(code, customObject2, RaiseEventOptions, sendOptions);
          }

          public static void OpRaiseEvent(byte code, Il2CppSystem.Object customObject, RaiseEventOptions RaiseEventOptions, SendOptions sendOptions)
          {
              PhotonNetwork.field_Public_Static_LoadBalancingClient_0.Method_Public_Virtual_New_Boolean_Byte_Object_RaiseEventOptions_SendOptions_0(code, customObject, RaiseEventOptions, sendOptions);
          }

          public static float Delay;*/

        public static void PickupsToSpace()
        {
            foreach (VRC_Pickup VRCPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
            {
                Networking.LocalPlayer.TakeOwnership(VRCPickup.gameObject);
                VRCPickup.transform.position = new Vector3(0f, 9.998E+07f, 0);
            }

        }
        public static void RespawnPickups()
        {
            foreach (VRC_Pickup VRCPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
            {
                Networking.LocalPlayer.TakeOwnership(VRCPickup.gameObject);
                VRCPickup.transform.position = new Vector3(0f, -9999f, 0);
            }
        }

        /* public static IEnumerator SpinBoi()
         {
             foreach (VRC_Pickup VRCPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
             {
                 while (Main.Spin == true)
                 {
                     Networking.LocalPlayer.TakeOwnership(VRCPickup.gameObject);
                     VRCPickup.transform.eulerAngles = new Vector3(2f, 0.0f, 0.0f) * 2;
                     yield return new WaitForSeconds(0.1f);

                 }
             }

         }*/
        public static void Yeetpickups()
        {
            foreach (VRC_Pickup VRCPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
            {
                VRCPickup.ThrowVelocityBoostScale = 15f;
            }
        }


        public static void UnYeetpickups()
        {
            foreach (VRC_Pickup VRCPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
            {
                VRCPickup.ThrowVelocityBoostScale = 2f;
            }
        }

        /*public static void UnYeetpickups()
        {
            foreach (VRC_Pickup VRCPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
            {
                VRCPickup.transform.
            }
        }*/

        public static void HidePickups()
        {
            if (Main.HidePickups == true)
            {
                foreach (VRC_Pickup VRCPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
                {
                    VRCPickup.gameObject.active = false;
                }
            }
            else
            if (Main.HidePickups == false)
            {
                foreach (VRC_Pickup VRCPickup1 in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
                {
                    VRCPickup1.gameObject.active = true;
                }
            }
        }
        public static void DropUrPants()
        {
            foreach (VRC_Pickup VRCPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
            {
                if (Main.ButterFingers == true)
                {
                    if (!Networking.IsOwner(Networking.LocalPlayer, ((Component)VRCPickup).gameObject))
                        Networking.SetOwner(Networking.LocalPlayer, ((Component)VRCPickup).gameObject);
                    VRCPickup.Drop();

                }
            }

        }

        public static void NoCollider()
        {
            foreach (VRC_Pickup VRCPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
            {
                Main.ColliderBool = true;
                Networking.SetOwner(Networking.LocalPlayer, ((Component)VRCPickup).gameObject);
                VRCPickup.GetComponent<Collider>().enabled = false;

            }
        }
        public static void UnNoCollider()
        {
            foreach (VRC_Pickup VRCPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
            {
                Main.ColliderBool = false;
                Networking.SetOwner(Networking.LocalPlayer, ((Component)VRCPickup).gameObject);
                VRCPickup.GetComponent<Collider>().enabled = true;
            }
        }
        public static void TargetBringAll()
        {                
                foreach (VRC_Pickup VRCPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
                {
                    Networking.LocalPlayer.TakeOwnership(VRCPickup.gameObject);
                    VRCPickup.transform.position = IUserExtension.GetVRCPlayer().transform.position + new Vector3(0f, 0.15f, 0f);
                }                                   
        }
        public static IEnumerator UwULagger()
        {
            while (toggledUwU)
            {
                foreach (VRC_Pickup VRCPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
                {
                    Networking.LocalPlayer.TakeOwnership(VRCPickup.gameObject);
                    VRCPickup.transform.position = IUserExtension.GetVRCPlayer().transform.position + new Vector3(0f, 1.5f, 0f);

                }
                yield return new WaitForSeconds(0.3f);
            }
            yield break;
        }

        public static IEnumerator UwULagger2()
        {
            while (toggledUwU)
            {
                foreach (VRC_Pickup VRCPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
                {
                    Networking.LocalPlayer.TakeOwnership(VRCPickup.gameObject);
                    VRCPickup.transform.position = IUserExtension.GetVRCPlayer().transform.position + new Vector3(0f, 9.998E+07f, 0);
                }
                yield return new WaitForSeconds(0.3f);
            }
            yield break;
        }
        public static void OnEnableUwU()
        {
            toggledUwU = true;
            MelonCoroutines.Start(UwULagger());
            MelonCoroutines.Start(UwULagger2());
        }

        public static void OnDisableUwU()
        {
            toggledUwU = false;
            MelonCoroutines.Stop(UwULagger());
            MelonCoroutines.Stop(UwULagger2());
        }
    }
}
      
    

 







