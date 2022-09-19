using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using VRC;
using MelonLoader;
using VRC.Animation;
using VRC.SDKBase;

namespace EggClient.Movement
{
    internal class Movement
    {
        public static bool Speed;
        public static bool flytoggle1 = false;
        public static VRCMotionState _motionState;
        public static Vector3 _originalGravity;
        public static bool canset;
        public static bool loaded;
        public static bool speedup = false;
        public static int speed = 3;
        public static bool InfJumpEnabled = false;
        public static Transform camera()
        {
            return VRCPlayer.field_Internal_Static_VRCPlayer_0.transform;
        }
        public static void Movment()
        {
            if (!flytoggle1)

            {
                if (loaded)
                {
                    Physics.gravity = _originalGravity;
                }
            }
            else if (flytoggle1 && !(Physics.gravity == Vector3.zero))
            {
                _originalGravity = Physics.gravity;
                Physics.gravity = Vector3.zero;
                return;
            }
            float num = Input.GetKey((KeyCode)304) ? (Time.deltaTime * 15f) : (Time.deltaTime * 10f);
            if (flytoggle1 && !(Player.prop_Player_0.gameObject == null))
            {
                if (Input.GetAxis("Oculus_CrossPlatform_SecondaryThumbstickVertical") < -0.5f)
                {
                    Player.prop_Player_0.gameObject.transform.position -= camera().up * num;
                }
                if (Input.GetAxis("Oculus_CrossPlatform_SecondaryThumbstickVertical") > 0.5f)
                {
                    Player.prop_Player_0.gameObject.transform.position += camera().up * num;
                }
                if (Input.GetAxis("Vertical") != 0f)
                {
                    Player.prop_Player_0.gameObject.transform.position += camera().forward * (num * Input.GetAxis("Vertical"));
                }
                if (Input.GetAxis("Horizontal") != 0f)
                {
                    Player.prop_Player_0.gameObject.transform.position += camera().transform.right * (num * Input.GetAxis("Horizontal"));
                    return;
                }
            } //UnityEngine.KeyCode

            // prop_Player_0.gameObject

        }
        public static void SpeedHack()
        {
            
            
                Networking.LocalPlayer.SetWalkSpeed(8);
                Networking.LocalPlayer.SetRunSpeed(16);
                Networking.LocalPlayer.SetStrafeSpeed(8);
            
        }
        public static void UnSpeedHack()

        {
                Networking.LocalPlayer.SetWalkSpeed(2);
                Networking.LocalPlayer.SetRunSpeed(4);
                Networking.LocalPlayer.SetStrafeSpeed(2);
            
        }

        public static void InfJump()
        {
            if (InfJumpEnabled)
            {
               /* if ((double)VRCInputManager.Method_Public_Static_VRCInput_String_0("Jump").prop_Single_2 != 1.0)
                    return;
                Networking.LocalPlayer.SetVelocity(Networking.LocalPlayer.GetVelocity());
               */
            }
        }

        public static void OnSceneWasInitialized(int buildIndex)
        {
            if (buildIndex == -1)
            {
                _originalGravity = Physics.gravity;
                canset = false;
                loaded = true;
            }
        }
    }
}
