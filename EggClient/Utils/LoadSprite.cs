﻿using System;
using System.Linq;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;
using UnhollowerRuntimeLib;
using UnhollowerRuntimeLib.XrefScans;
using VRC;
using VRC.Core;
using VRC.DataModel;
using VRC.SDKBase;
using System.IO;
using MelonLoader;
 
namespace EggClient
{
    public static class Exten
    {
        public static Sprite LoadSpriteFromDisk(this string path)
        {
            if (string.IsNullOrEmpty(path)) return null;
            byte[] array = File.ReadAllBytes(path);
            if (array == null || array.Length == 0)
            {
                return null;
            }
            Texture2D texture2D = new Texture2D(512, 512);
            if (!ImageConversion.LoadImage(texture2D, array)) return null;
            Sprite sprite = Sprite.CreateSprite(texture2D, new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), new Vector2(0, 0), 100000f, 1000U, SpriteMeshType.FullRect, Vector4.zero, false);
            sprite.hideFlags |= HideFlags.DontUnloadUnusedAsset;
            return sprite;
        }
        public static GameObject FindObject(this GameObject parent, string name)
        {
            Transform[] trs = parent.GetComponentsInChildren<Transform>(true);
            foreach (Transform t in trs)
            {
                if (t.name == name)
                {
                    return t.gameObject;
                }
            }
            return null;
        }
        public static string GetPath(this GameObject gameObject)
        {
            string path = "/" + gameObject.name;
            while (gameObject.transform.parent != null)
            {
                gameObject = gameObject.transform.parent.gameObject;
                path = "/" + gameObject.name + path;
            }
            return path;
        }


        public static float RoundAmount(this float i, float nearestFactor)
        {
            return (float)Math.Round(i / nearestFactor) * nearestFactor;
        }
 
        public static Vector3 RoundAmount(this Vector3 i, float nearestFactor)
        {
            return new Vector3(i.x.RoundAmount(nearestFactor), i.y.RoundAmount(nearestFactor), i.z.RoundAmount(nearestFactor));
        }
 
        public static Vector2 RoundAmount(this Vector2 i, float nearestFactor)
        {
            return new Vector2(i.x.RoundAmount(nearestFactor), i.y.RoundAmount(nearestFactor));
        }
 
        public static Sprite ToSprite(this Texture2D tex)
        {
            Rect rect = new Rect(0, 0, tex.width, tex.height);
            Vector2 pivot = new Vector2(0.5f, 0.5f);
            Vector4 border = Vector4.zero;
            Sprite sprite = Sprite.CreateSprite_Injected(tex, ref rect, ref pivot, 50, 0, SpriteMeshType.FullRect, ref border, false);
            sprite.hideFlags |= HideFlags.DontUnloadUnusedAsset;
            return sprite;
        }
 
        // https://stackoverflow.com/questions/8809354/replace-first-occurrence-of-pattern-in-a-string
        public static string ReplaceFirst(this string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }
 
        public static ColorBlock SetColor(this ColorBlock block, Color color)
        {
            return new ColorBlock()
            {
                colorMultiplier = block.colorMultiplier,
                disabledColor = Color.grey,
                highlightedColor = color,
                normalColor = color / 1.5f,
                pressedColor = Color.white,
                selectedColor = color / 1.5f,
            };
        }
 
        public static string ToEasyString(this TimeSpan timeSpan)
        {
            if (Mathf.FloorToInt(timeSpan.Ticks / TimeSpan.TicksPerDay) > 0)
                return $"{timeSpan:%d} days";
            else if (Mathf.FloorToInt(timeSpan.Ticks / TimeSpan.TicksPerHour) > 0)
                return $"{timeSpan:%h} hours";
            else if (Mathf.FloorToInt(timeSpan.Ticks / TimeSpan.TicksPerMinute) > 0)
                return $"{timeSpan:%m} minutes";
            else
                return $"{timeSpan:%s} seconds";
        }
        #region QuickMenu ShowAlert
        private static MethodInfo ourShowAlertMethod;
 
        public static void ShowAlert(this VRC.UI.Elements.QuickMenu qm, string message)
        {
 
            if (ourShowAlertMethod == null)
                foreach (MethodInfo inf in typeof(VRC.UI.Elements.Controls.ModalAlert).GetMethods())
                {
                    MelonLogger.Msg(inf.Name);
                    if (inf.Name.Contains("Method_Private_Void_") && !inf.Name.Contains("PDM") && inf.GetParameters().Length == 0)
                    {
                        qm.field_Private_ModalAlert_0.field_Private_String_0 = message;
                        inf.Invoke(qm.field_Private_ModalAlert_0, null);
                        if (qm.transform.Find("Container/Window/QMParent/Modal_Alert/Background_Alert").gameObject.activeSelf)
                        {
                            ourShowAlertMethod = inf;
                            break;
                        }
                    }
                }
            else
            {
                qm.field_Private_ModalAlert_0.field_Private_String_0 = message;
                ourShowAlertMethod.Invoke(qm.field_Private_ModalAlert_0, null);
            }
            //ShowAlertMethod.Invoke(qm, new object[] { message });
        }
        #endregion
        #region QuickMenu ShowOKDialog
 
        public static void ShowOKDialog(this VRC.UI.Elements.QuickMenu qm, string title, string message, Action okButton = null)
        {
            qm.Method_Public_Void_String_String_Action_String_Boolean_0(title, message, okButton);
        }
        #endregion
        #region QuickMenu ShowConfirmDialog
 
        public static void ShowConfirmDialog(this VRC.UI.Elements.QuickMenu qm, string title, string message, Action yesButton = null, Action noButton = null)
        {
            qm.Method_Public_Void_String_String_Action_Action_String_String_0(title, message, yesButton, noButton);
        }
 
        #endregion
        #region QuickMenu ShowCustomDialog
 
        public static void ShowCustomDialog(this VRC.UI.Elements.QuickMenu qm, string title, string message, string button1Text, string button2Text, string button3Text, Action button1Action = null, Action button2Action = null, Action button3Action = null)
        {
            qm.Method_Public_Void_String_String_String_String_String_Action_Action_Action_0(title, message, button1Text, button2Text, button3Text, button1Action, button2Action, button3Action);
        }
 
        #endregion
        #region QuickMenu AskConfirmOpenURL
        private static MethodInfo ourAskConfirmOpenURLMethod;
        public static MethodInfo AskConfirmOpenURLMethod
        {
            get
            {
                if (ourAskConfirmOpenURLMethod != null) return ourAskConfirmOpenURLMethod;
                var targetMethod = typeof(VRC.UI.Elements.QuickMenu).GetMethods()
                    .First(it => it != null && it.GetParameters().Length == 1 && it.Name.Contains("_Virtual_Final_New") && it.GetParameters().First().ParameterType == typeof(string) && XrefScanner.XrefScan(it).Any(jt => jt.Type == XrefType.Global && jt.ReadAsObject() != null && jt.ReadAsObject().ToString().Contains("This link will open in your web browser.")));
                ourAskConfirmOpenURLMethod = targetMethod;
                return ourAskConfirmOpenURLMethod;
            }
        }
 
        public static void AskConfirmOpenURL(this VRC.UI.Elements.QuickMenu qm, string url)
        {
            AskConfirmOpenURLMethod.Invoke(qm, new object[] { url });
        }
        #endregion
        #region VRCPlayer SpawnEmoji
 
        public static void SpawnEmoji(this VRCPlayer player, int emojiId)
        {
            Il2CppSystem.Int32 @int = default(Il2CppSystem.Int32);
            @int.m_value = emojiId;
            Il2CppSystem.Object @object = @int.BoxIl2CppObject();
            Networking.RPC(RPC.Destination.All, player.gameObject, "SpawnEmojiRPC", new Il2CppSystem.Object[] { @object });
        }
        #endregion
    }
}