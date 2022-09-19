using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using VRC;
using MelonLoader;
using System.Collections;

namespace EggClient
{
    internal class FunniText
    {
        public static bool FunniTextEnabled;
        
        public static void OnPlayerJoined(Player player)
        { 
            if (RoomManager.field_Internal_Static_ApiWorld_0.id == "wrld_858dfdfc-1b48-4e1e-8a43-f0edc611e5fe")

                if (!FunniTextEnabled) return;
            MelonCoroutines.Start(Eggclient());
            new WaitForSeconds(0.1f);
            MelonCoroutines.Start(Eggclient2());
            new WaitForSeconds(0.1f);
            MelonCoroutines.Start(Eggclient3());
            new WaitForSeconds(0.1f);
            MelonCoroutines.Start(Eggclient4());
        }
        public static IEnumerator Eggclient()
        {
            if (RoomManager.field_Internal_Static_ApiWorld_0.id == "wrld_858dfdfc-1b48-4e1e-8a43-f0edc611e5fe")
            {
                UnityEngine.UI.Text gameObject = GameObject.Find("Game Logic/Game Canvas/Pregame/Title Text").GetComponent<Text>();
                gameObject.text = ("Egg Client");

                yield return (object)null;
            }
        }
        public static IEnumerator Eggclient2()
        {
            if (RoomManager.field_Internal_Static_ApiWorld_0.id == "wrld_858dfdfc-1b48-4e1e-8a43-f0edc611e5fe")
            {
                UnityEngine.UI.Text gameObject = GameObject.Find("Game Logic/Game Canvas/Pregame/Author Text").GetComponent<Text>();
                gameObject.text = ("By Egg");

                yield return (object)null;
            }
        }

        public static IEnumerator Eggclient3()
        {
            if (RoomManager.field_Internal_Static_ApiWorld_0.id == "wrld_858dfdfc-1b48-4e1e-8a43-f0edc611e5fe")
            {
                UnityEngine.UI.Text gameObject = GameObject.Find("Game Logic/Game Canvas/Pregame/Game Modifiers/Mask/Toggle (0)/Label").GetComponent<Text>();
                gameObject.text = ("Ew Teams");

                yield return (object)null;
            }
        }

        public static IEnumerator Eggclient4()
        {
            if (RoomManager.field_Internal_Static_ApiWorld_0.id == "wrld_858dfdfc-1b48-4e1e-8a43-f0edc611e5fe")
            {
                UnityEngine.UI.Text gameObject = GameObject.Find("Game Logic/Game Canvas/Pregame/Game Modifiers/Mask/Toggle (1)/Label").GetComponent<Text>();
                gameObject.text = ("Scrambled Eggs");

                yield return (object)null;
            }

        }
    }
}



