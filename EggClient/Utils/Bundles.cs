using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MelonLoader;
using UnhollowerBaseLib;
using UnityEngine;

namespace EggClient.Utils
{
    internal class Bundles
    {
       
        internal static void Loadingscreen()
        {
            WebClient webClient1 = new WebClient();
            WebClient webClient2 = new WebClient();
            var loadingscreen = webClient1.DownloadData("https://nocturnal-client.xyz/Resources/loading");
            AssetBundle assetBundle = AssetBundle.LoadFromMemory((Il2CppStructArray<byte>)loadingscreen);
            if ((UnityEngine.Object)assetBundle == (UnityEngine.Object)null)
            {
                MelonLogger.Msg((object)"Failed to load AssetBundle!");
            }
            else
            {
                GameObject original = assetBundle.LoadAsset<GameObject>("loadingscreen");
                assetBundle.Unload(false);
                GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient").gameObject.SetActive(false);
                GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(original, GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/LoadingPopup").transform);
                gameObject.transform.localPosition = new Vector3(0.0f, 0.0f, 30000f);
                gameObject.transform.Find("GameObjectanim").transform.localPosition = new Vector3(0.0f, 7000f, 0.0f);
                gameObject.transform.Find("finished (1)").transform.localPosition = new Vector3(0.0f, -2800f, 0.0f);
                gameObject.transform.Find("wings").transform.localPosition = new Vector3(0.0f, 1500f, 0.0f);
                gameObject.transform.Find("Particle System (2)").transform.localPosition = new Vector3(0.0f, -8000f, -9000f);
                gameObject.transform.Find("Particle System (1)").transform.localPosition = new Vector3(0.0f, 0.0f, 9000f);
                gameObject.transform.Find("Particle System").transform.localPosition = new Vector3(0.0f, -1500f, -30000f);
                GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/LoadingPopup/3DElements").transform.localScale = new Vector3(1f, 1f, 1f);
                Il2CppArrayBase<ParticleSystem> componentsInChildren = gameObject.GetComponentsInChildren<ParticleSystem>(true);
                for (int index = 0; index < componentsInChildren.Length; ++index)
                    componentsInChildren[index].startColor = new Color(ConfigVars.HuDColor[0], ConfigVars.HuDColor[1], ConfigVars.HuDColor[2]);
                MelonCoroutines.Start(extensions.loadaudio(GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/LoadingPopup/LoadingSound").gameObject.GetComponent<AudioSource>()));
            }
        }
    }
}
