// Decompiled with JetBrains decompiler
// Type: Nocturnal.Settings.ConfigVars
// Assembly: Nocturnal V3, Version=1.0.8227.19703, Culture=neutral, PublicKeyToken=null
// MVID: 9E40539C-177E-4B53-B5B4-EDB7DACD5B23
// Assembly location: C:\Users\joshu\OneDrive\Desktop\Nocturnal V3.dll

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EggClient
{
    internal class ConfigVars
    {
        public static string QmDebbugerImg = "https://cutewallpaper.org/21/black-aesthetic-anime/Image-about-girl-in-black-aesthetic-by-Quantis.png";
        public static string BiguiImg = "https://nocturnal-client.xyz/BigUi.png";
        public static string PlayerListImg = "https://i.pinimg.com/564x/4e/70/5a/4e705a534d03153e9800b2ba676bf1ee.jpg";
        public static string QmImg = "https://i.pinimg.com/564x/54/24/3b/54243bfa9ea67ed8be8ee4dc4e015e6e.jpg";
        public static float QMopacity = 0.8f;
        public static float playelerlistopacity = 0.8f;
        public static float clientvolume = 0.4f;
        public static float BigImgOpacity = 0.7f;
        public static bool esp = true;
        public static float Flyspeed = 0.6f;
        public static float jumpimpulse = 3f;
        public static float espwidth = 0.35f;
        public static float debuggeropacity = 0.7f;
        public static bool qmdebug = true;
        public static bool thunderbigui = false;
        public static float falloff = 0.1f;
        public static bool itemmaxrange = true;
        public static bool itempickup = true;
        public static bool qmmusic = true;
        public static bool avataroutline = true;
        public static int maxaudiosources = 15;
        public static int maxmaterials = 60;
        public static int maxmeshes = 100;
        public static int maxverticies = 200000;
        public static int maxparticles = 30000;
        public static int particlesystem = 30;
        public static bool verticiesp = true;
        public static bool meshp = true;
        public static bool ShaderP = true;
        public static bool audiosourcep = true;
        public static bool particlep = true;
        public static bool linerenderp = true;
        public static bool lightsp = true;
        public static bool selfanti = false;
        public static bool logshaderstoconsole = true;
        public static float[] visitor = new float[4]
        {
      1f,
      1f,
      1f,
      1f
        };
        public static float[] newuser = new float[4]
        {
      1f,
      0.7f,
      1f,
      1f
        };
        public static float[] user = new float[4]
        {
      0.0f,
      1f,
      0.0f,
      1f
        };
        public static float[] known = new float[4]
        {
      0.8f,
      0.2f,
      0.0f,
      1f
        };
        public static float[] trusted = new float[4]
        {
      0.6f,
      0.0f,
      0.95f,
      1f
        };
        public static float[] superpowers = new float[4]
        {
      0.6f,
      0.0f,
      0.0f,
      1f
        };
        public static float[] Moderator = new float[4]
        {
      1f,
      0.0f,
      0.0f,
      1f
        };
        public static float[] friend = new float[4]
        {
      1f,
      1f,
      0.0f,
      1f
        };
        public static bool playerlist = true;
        public static bool rightsideplayerlist = true;
        public static float[] ButtonColor = new float[4]
        {
      0.0f,
      0.0f,
      0.0f,
      1f
        };
        public static float[] HuDColor = new float[4]
        {
      0.2f,
      0.0f,
      0.5f,
      0.9f
        };
        public static float[] textcolor = new float[4]
        {
      1f,
      0.1f,
      0.2f,
      1f
        };
        public static bool forcejump = false;
        public static bool infinitejump = true;
        public static float speedvalue = 10f;
        public static bool speed = false;
        public static bool Thidperson = true;
        public static bool bhop = false;
        public static bool joinsound = true;
        public static bool onlyfriendjoin = false;
        public static bool hidequests = false;
        public static bool itemesp = false;
        public static bool allowitemtheft = true;
        public static bool murdergoldweapon = false;
        public static bool murdergodmod = false;
        public static bool everyonegoldgun = false;
        public static bool amongusgodmod = false;
        public static bool continuesfire = false;
        public static bool everyonecontinuesfire = false;
        public static bool qminfopannel = true;
        public static string chatimage = "https://nocturnal-client.xyz/Resources/img.jpg";
        public static bool rainbackground = true;
        public static bool discordrichpresence = true;
        public static bool udonblock = false;
        public static bool hudUi = true;
        public static bool toggleonscreenlogger = true;
        public static string Customanmespoof = "Edward7";
        public static bool onlywauthornamespoof = true;
        public static bool joinnotif = true;
        public static bool HwidSpoof = false;
        public static string SpoofedHWID = Guid.NewGuid().ToString().Replace("-", "3");
        public static bool ItemThrowBoost = false;
        public static float ItemThrowBoostValue = 7f;
        public static bool SelfTrail = false;
        public static bool EveryoneTrail = false;
        public static bool HudUi = true;
        public static bool OnlyFriendsPortals = true;
        public static bool NoPortals = false;
        public static bool EspSizeOverDistance = true;
        public static bool DoubleSpaceFly = false;
        public static bool RocketJump = false;
        public static bool NamePlatesInfo = true;
        public static bool OfflineSpoof = false;

      
    }
}
