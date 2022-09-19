using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using MelonLoader;

namespace EggClient
{
    public class CustomMenuMusic
    {

        public static void OnUiManagerInit()
        {
            // Start trying to set up the menu music
           MelonLogger.Msg("Initializing custom menu music...");
            MelonLoader.MelonCoroutines.Start(Initialize());
        }
        public static IEnumerator Initialize()
        {
            if (!Directory.Exists(Path.Combine(Environment.CurrentDirectory, "UserData/EggClient/CustomMenuMusic")))
                Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, "UserData/EggClient/CustomMenuMusic"));
            if (File.Exists(Path.Combine(Environment.CurrentDirectory, "UserData/EggClient/custommenu.ogg")))
            {
                try
                {
                    File.Move(Path.Combine(Environment.CurrentDirectory, "UserData/EggClient/ustommenu.ogg"), Path.Combine(Environment.CurrentDirectory, "UserData/EggClient/CustomMenuMusic/custommenu.ogg"));
                }
                catch (Exception ex)
                {
                    ex = new Exception();
                    MelonLogger.Msg("A custommenu.ogg was detected, but you already have one in the CustomMenuMusic folder. Please put custom menu music in the Ogg Vorbis format into UserData/emmVRC/CustomMenuMusic instead.");
                }
            }
            string[] availableCustomMenuMusics = Directory.GetFiles(Path.Combine(Environment.CurrentDirectory, "UserData/EggClient/CustomMenuMusic"));
            if (availableCustomMenuMusics.Length >= 1)
            {
                MelonLogger.Msg("Processing custom menu music...");
                System.Random rndm = new System.Random();
                int randomIndex = rndm.Next(availableCustomMenuMusics.Length);
                MelonLogger.Msg("Picked track: " + availableCustomMenuMusics[randomIndex]);
                GameObject loadingMusic1 = GameObject.Find("LoadingBackground_TealGradient_Music/LoadingSound");
                GameObject loadingMusic2 = GameObject.Find("MenuContent/Popups/LoadingPopup/LoadingSound")?.gameObject;
                if (loadingMusic1 != null)
                    loadingMusic1.GetComponent<AudioSource>().Stop();
                if (loadingMusic2 != null)
                    loadingMusic2.GetComponent<AudioSource>().Stop();
                //WWW CustomLoadingMusicWWW = WWW.LoadFromCacheOrDownload(string.Format("file://{0}", availableCustomMenuMusics[randomIndex]).Replace(@"\", "/"), null, (uint)new System.Random().Next(0, 65535));
                UnityWebRequest CustomLoadingMusicRequest = UnityWebRequest.Get(string.Format("file://{0}", availableCustomMenuMusics[randomIndex]).Replace(@"\", "/"));
                CustomLoadingMusicRequest.SendWebRequest();
                while (!CustomLoadingMusicRequest.isDone) yield return null;
                MelonLogger.Msg("Request sent and returned");
                AudioClip customLoadingMusic = null;
                if (CustomLoadingMusicRequest.isHttpError)
                    MelonLogger.Msg("Could not load music file: " + CustomLoadingMusicRequest.error);
                else
                    customLoadingMusic = WebRequestWWW.InternalCreateAudioClipUsingDH(CustomLoadingMusicRequest.downloadHandler, CustomLoadingMusicRequest.url, false, false, AudioType.UNKNOWN);
                //AudioClip customLoadingMusic = CustomLoadingMusicWWW.GetAudioClip();
                //while (!CustomLoadingMusicWWW.isDone || customLoadingMusic.loadState == AudioDataLoadState.Loading) ;

                if (customLoadingMusic != null)
                {
                    if (loadingMusic1 != null)
                    {
                        loadingMusic1.GetComponent<AudioSource>().clip = customLoadingMusic;
                        loadingMusic1.GetComponent<AudioSource>().Play();
                    }
                    if (loadingMusic2 != null)
                    {
                        loadingMusic2.GetComponent<AudioSource>().clip = customLoadingMusic;
                        loadingMusic2.GetComponent<AudioSource>().Play();
                    }
                }
            }
            yield return null;

        }
    }
}
