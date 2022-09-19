using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRC.SDKBase;

namespace EggClient.Eggsploits
{
    internal class AntiTheft
    {
        public static void AntiPickupTheift()
        {
            foreach (VRC_Pickup VRCPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
            {
                VRCPickup.DisallowTheft = true;
            }
           
        }
    }
}
