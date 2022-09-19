using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;

namespace EggClient.Eggsploits
{
    internal class UdonNuker
    {
        public static void Nuker()
        {
            foreach (var gameObject in Resources.FindObjectsOfTypeAll<VRC.Udon.UdonBehaviour>())
            {
                Il2CppSystem.Collections.Generic.Dictionary<string, Il2CppSystem.Collections.Generic.List<uint>>.Enumerator Egg = gameObject._eventTable.GetEnumerator();
                while (Egg.MoveNext())
                {
                    Il2CppSystem.Collections.Generic.KeyValuePair<string, Il2CppSystem.Collections.Generic.List<uint>> Nuke = Egg.current;
                    gameObject.SendCustomNetworkEvent(NetworkEventTarget.All, Nuke.Key);
             

                // test
            }
        }
        
    
        }
    }
}






