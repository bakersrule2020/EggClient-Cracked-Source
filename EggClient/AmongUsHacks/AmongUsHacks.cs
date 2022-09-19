using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EggClient.MurderHacks;
using UnityEngine;
using VRC.Udon;
using VRC.Udon.Common.Interfaces;

namespace EggClient
{
    internal class AmongUsHacks
    {
        public static void EjectAll()
        {
			Extentions.Extentions.AllPlayers.ForEach(p =>
			{
				GameObject gameObject = GameObject.Find("Player Nodes");
				foreach (Transform transform in gameObject.GetComponentsInChildren<Transform>())
				{
					if (transform.name != gameObject.name)
					{
						transform.gameObject.Udonsend("SyncVotedOut", p, false);
					}
				}
			}); 
        }
    }
}
