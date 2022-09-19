// Decompiled with JetBrains decompiler
// Type: Nocturnal.Settings.wrappers.extensions
// Assembly: Nocturnal V3, Version=1.0.8227.19703, Culture=neutral, PublicKeyToken=null
// MVID: 9E40539C-177E-4B53-B5B4-EDB7DACD5B23
// Assembly location: C:\Users\joshu\OneDrive\Desktop\Nocturnal V3.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading.Tasks;
using TMPro;
using UnhollowerRuntimeLib.XrefScans;
using UnityEngine;
using UnityEngine.Networking;
using VRC;
using VRC.Core;
using VRC.Networking;

namespace EggClient
{
    internal static class extensions
    {
        internal static GameObject _CurentCamera { get; set; }

        internal static GameObject _LastCamera { get; set; }

        internal static GameObject _PlatePrefab { get; set; }

        internal static GameObject _NewPlate { get; set; }

        internal static GameObject _Icon { get; set; }

       


        internal static IEnumerator loadaudio(AudioSource auds)
        {
            UnityWebRequest www = UnityWebRequest.Get("https://nocturnal-client.xyz/Resources/LoadingMusic.mp3");
            www.SendWebRequest();
            while (!www.isDone)
                yield return (object)null;
            if (!www.isHttpError)
            {
                AudioClip audioc = WebRequestWWW.InternalCreateAudioClipUsingDH(www.downloadHandler, www.url, false, false, AudioType.MPEG);
                AudioClip audioClip = audioc;
                ((UnityEngine.Object)audioClip).hideFlags = ((UnityEngine.Object)audioClip).hideFlags | HideFlags.DontUnloadUnusedAsset;
                auds.clip = audioc;
                www.Dispose();
            }
        }
    }
}


      

