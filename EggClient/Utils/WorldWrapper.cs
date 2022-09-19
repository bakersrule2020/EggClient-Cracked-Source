using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRC.Core;
using VRC.SDKBase;
using VRC.Udon;

namespace EggClient.Utils
{
    class WorldWrapper
    {
        public static VRC_Pickup[] vrc_Pickups;
        public static UdonBehaviour[] udonBehaviours;
        public static VRC_Trigger[] vrc_Triggers;
       
        public static string GetID() => CurrentWorld().id;
        
        public static ApiWorld CurrentWorld() => RoomManager.field_Internal_Static_ApiWorld_0;
        public static ApiWorldInstance CurrentWorldInstance() => RoomManager.field_Internal_Static_ApiWorldInstance_0;
       
        public static void Init()
        {
            vrc_Pickups = UnityEngine.Object.FindObjectsOfType<VRC_Pickup>();
            udonBehaviours = UnityEngine.Object.FindObjectsOfType<UdonBehaviour>();
            vrc_Triggers = UnityEngine.Object.FindObjectsOfType<VRC_Trigger>();
           
           

        }
    }
}
