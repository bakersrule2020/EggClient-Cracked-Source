

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using VRC;
using VRC.Core;

using VRC.SDKBase;


namespace EggClient.Wrapper
{
    public static class Wrapper
    {
        public static float GetFrames(this Player player) => (player._playerNet.prop_Byte_0 != 0) ? Mathf.Floor(1000f / (float)player._playerNet.prop_Byte_0) : -1f;

        public static short GetPing(this Player player) => player._playerNet.field_Private_Int16_0;

        public static bool ClientDetect(this Player player) => player.GetFrames() > 200 || player.GetFrames() < 1 || player.GetPing() > 665 || player.GetPing() < 0;

        public static bool GetIsMaster(this Player Instance) => Instance.GetVRCPlayerApi().isMaster;
        internal static GameObject PlatePrefab { get; set; }
        internal static GameObject NewPlate { get; set; }
        internal static GameObject Icon { get; set; }
        public static VRCPlayerApi GetVRCPlayerApi(this Player Instance) => Instance?.prop_VRCPlayerApi_0;

        public static ApiAvatar GetAvatarInfo(this Player Instance) => Instance?.prop_ApiAvatar_0;

        internal static void Loadfrombytes(this GameObject gmj, string img, bool isimage = true, Color? color = null) => Loadfrombytes(gmj, System.Convert.FromBase64String(img), isimage, color);

        internal static void Loadfrombytes(this GameObject gmj, byte[] img, bool isimage = true, Color? color = null) => new ImageHandler(gmj, img, isimage, color);

        internal static GameObject GeneratePlate(this VRC.Player player, string text) => GeneratePlate(player._vrcplayer, text);

        internal static GameObject GeneratePlate(this VRCPlayer player, string text)
        {
            if (player == null) return new GameObject();
            try
            {
                PlatePrefab = player.gameObject.GetComponent<VRCPlayer>().field_Public_PlayerNameplate_0.field_Public_GameObject_0.transform.Find("Platesmanager/Plate Holder").gameObject;
                NewPlate = GameObject.Instantiate(PlatePrefab, PlatePrefab.transform.parent);
                NewPlate.gameObject.SetActive(true);
                NewPlate.gameObject.transform.Find("PrefabPlate").gameObject.SetActive(true);

                NewPlate.transform.Find("PrefabPlate/Text").gameObject.GetComponent<TMPro.TextMeshProUGUI>().text = text;
                NewPlate.gameObject.name = $"_Plate:{text}";
                return NewPlate;
            }
            catch
            {

            }

            return new GameObject();
        }

        public static bool IsBot(this Player player)
        {
            if ((player.GetPing() > 0 || !(player.GetFrames() <= 0f)) && !(player.GetFrames() <= -1f))
            {
                return player.transform.position == Vector3.zero;
            }
            return true;
        }

        public static string GetAvatarStatus(this Player player)
        {
            string status = player.GetAvatarInfo().releaseStatus.ToLower();
            if (status == "public")
                return "<color=green>" + status + "</color>";
            else
                return "<color=red>" + status + "</color>";
        }

        public static string GetFramesColord(this Player player)
        {
            float fps = player.GetFrames();
            if (fps > 80)
                return "<color=green>" + fps + "</color>";
            else if (fps > 30)
                return "<color=yellow>" + fps + "</color>";
            else
                return "<color=red>" + fps + "</color>";
        }

        public static string GetPingColord(this Player player)
        {
            short ping = player.GetPing();
            if (ping > 150)
                return "<color=red>" + ping + "</color>";
            else if (ping > 75)
                return "<color=yellow>" + ping + "</color>";
            else
                return "<color=green>" + ping + "</color>";
        }

       // public static string GetPlatform(this Player player)
      //  {
       //     if (player.GetAPIUser().IsOnMobile)
        //    {
         //       return "<color=green>Q</color>";
         //   }
         //   else if (player.GetVRCPlayerApi().IsUserInVR())
         //   {
         //       return "<color=#CE00D5>VR</color>";
         //   }
         //   else
        //    {
         //       return "<color=grey>PC</color>";
         //   }
     //   }

        public static void StopSpawnSounds(this GameObject avtrObject)
        {
            foreach (var audioSource in avtrObject.GetComponentsInChildren<AudioSource>().Where(audioSource => audioSource.isPlaying))
                audioSource.Stop();
        }

        public static VRCPlayer GetLocalVRCPlayer() => VRCPlayer.field_Internal_Static_VRCPlayer_0;

        public static VRC.Player LocalPlayer() => VRC.Player.prop_Player_0;

        public static GameObject GetAvatarObject(this Player p) => p.prop_VRCPlayer_0.prop_VRCAvatarManager_0.prop_GameObject_0;

        public static Il2CppSystem.Collections.Generic.List<Player> GetAllPlayers() => GetPlayerManager()?.field_Private_List_1_Player_0;

        public static bool IsMe(this Player p) => p.name == GetLocalVRCPlayer().name;

        public static bool IsFriendsWith(this APIUser apiUser) => APIUser.CurrentUser.friendIDs.Contains(apiUser.id);

       // public static ModerationManager GetModerationManager() => ModerationManager.prop_ModerationManager_0;

        public static PlayerManager GetPlayerManager() => PlayerManager.prop_PlayerManager_0;

    //    public static Dictionary<string, PlayerDetails> playerList = new Dictionary<string, PlayerDetails>();

       // public static Color GetTrustColor(this Player player)
       // {
       //     return VRCPlayer.Method_Public_Static_Color_APIUser_0(player.GetAPIUser());
       // }

        //public static PlayerDetails GetPlayerInformationById(int index)
       // {
         //   foreach (KeyValuePair<string, PlayerDetails> playerInfo in playerList.ToList())
         //   {
           //     if (playerInfo.Value.networkBehaviour.prop_Int32_0 == index)
           //     {
           //         return playerInfo.Value;
           //     }
         //   }

      //      return null;
       // }

        public static T GetOrAddComponent<T>(this GameObject gameObject) where T : Component
        {
            T component = gameObject.GetComponent<T>();
            if (component == null)
            {
                return gameObject.AddComponent<T>();
            }
            return component;
        }
    }
    internal class ImageHandler : IDisposable
    {
        private Image ImageComponent { get; set; }
        private Texture2D Texture2d { get; set; }
        private ImageThreeSlice ImageThreeSliceCompnent { get; set; }

        ~ImageHandler() => this.Dispose();

        public void Dispose()
        {
            this.ImageComponent = null;
            this.Texture2d = null;
            this.ImageThreeSliceCompnent = null;
        }

        public ImageHandler(GameObject gmj, byte[] img, bool isimage = true, Color? color = null)
        {
            if (isimage)
            {
                ImageComponent = gmj.GetComponent<Image>();
                Texture2d = new Texture2D(256, 256);
                ImageConversion.LoadImage(Texture2d, img);
                Texture2d.Apply();
                ImageComponent.sprite = Sprite.CreateSprite(Texture2d,
                new Rect(0f, 0f, Texture2d.width, Texture2d.height), new Vector2(0f, 0f), 100000f, 1000u,
                SpriteMeshType.FullRect, Vector4.zero, false);
                if (color != null)
                    ImageComponent.color = Color.white;
                return;
            }
            ImageThreeSliceCompnent = gmj.GetComponent<ImageThreeSlice>();
            Texture2d = new Texture2D(256, 256);
            ImageConversion.LoadImage(Texture2d, img);
            Texture2d.Apply();
            ImageThreeSliceCompnent.prop_Sprite_0 = Sprite.CreateSprite(Texture2d,
            new Rect(0f, 0f, Texture2d.width, Texture2d.height), new Vector2(0f, 0f), 100000f, 1000u,
            SpriteMeshType.FullRect, new Vector4(255, 0, 255, 0), false);
            if (color != null)
                ImageThreeSliceCompnent.color = Color.white;
        }
    }
}