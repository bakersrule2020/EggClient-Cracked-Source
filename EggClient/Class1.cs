using System;
using System.Collections;
using MelonLoader;
using UnityEngine;
using EggClient.Murder4;
using EggClient.ObjectsM;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using static Il2CppSystem.Xml.XmlWellFormedWriter.AttributeValueCache;
using VRC;
using VRC.Core;
using HarmonyLib;
using EggClient.Utils;
using System.Linq;
using VRC.Udon;
using VRC.SDKBase;
using EggClient.MurderHacks;
using WebSocketSharp;
using System.Net;
using UnityEngine.UI;
using EggClient.PrisonHacks;
using VRC.Animation;
using VRC.UI.Elements.Menus;
using VRC.UI;
using VRC.DataModel;
using Newtonsoft.Json.Linq;
using EggClient;
using TMPro;

[assembly: MelonInfo(typeof(EggClient.Main), "EggClient", "0.0.3", "Foonix#0001,Ikari")]
[assembly: MelonGame("VRChat", "VRChat")]

namespace EggClient
{
    class Main : MelonMod
    {
        private static string resourcePath = Path.Combine(Environment.CurrentDirectory, "UserData/EggClient/Resources/");
        public static bool SpeedH = false;
        public static bool PortalSpam = false;
        public static bool M4Text = true;
        public static bool Yeet = false;
        public static bool NO = false;
        public static bool isPickupsToSpace = false;
        public static bool RespawnPick = false;
        public static bool Spin = false;
        public static bool Plugerbool = false;
        public static bool TPlugerbool = false;
        public static bool ItemStop = false;
        public static bool ButterFingers = false;
        public static bool AntiTheft = false;
        public static bool HidePickups = false;
        public static bool flytoggle = false;
        public static bool ColliderBool = false;
        public static VRCMotionState _motionState;
        public static Vector3 _originalGravity;
        public static bool canset;
        public static bool loaded;
        public static bool speedup = false;
        public static int speed = 3;

        public static UdonBehaviour[] udonBehaviours;
        public static bool joinedLobby = false;
        public static bool enabled = false;

        public static bool Toggled;
        public static WebSocket ws;
        public static Sprite Template;
        private static AssetBundle TemplateBundle;

       // APIUser selectedAPIUser = UserController.field_Private_Static_UserSelectionManager_0.field_Private_APIUser_1;
              
      //  VRCPlayer selectedVRCPlayer = PlayerManager.field_Private_Static_PlayerManager_0.field_Private_List_1_Player_0.ToArray().FirstOrDefault(a => a.field_Private_APIUser_0 != null && a.field_Private_APIUser_0.id == selectedAPIUser.id)?._vrcplayer;

        private static bool _initialized;
        public static MenuPage basePage;
        private static Tab mainTab;
        public static Sprite TabIcon;
        private static SingleButton DemoButton;
        private static ButtonGroup otherGroup;
        public static bool USPEAKLOUD = false;
        public static bool GoldenGunBool = false;
      //  public static GameObject UserInterface => GameObject.Find("UserInterface");
       // public static GameObject Menu_SelectedUser_Local => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Local");
       // public static MenuContent.QuickMenuStuff GO = new MenuContent.QuickMenuStuff();
     //  public static MenuController GetMenuController()
      //  {
       //     return GetUIManagerImpl().field_Public_MenuController_0;
     //   }
       // public static VRCPlayer GetSelectedVrcPlayer()
      //  {
      //      return GetMenuController().activePlayer;
      //  }
      //  public static Player GetSelectedPlayer()
      // {
       //     return GetSelectedVrcPlayer().GetVRC_Player();
       // }
        public static void CreateBTN(string btnText, Action callback)
        {
            var toinst = GameObject.Find("/UserInterface").transform.Find("Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Container/InnerContainer/WingMenu/ScrollRect/Viewport/VerticalLayoutGroup/Button_Emotes");
            
            
            var inst = GameObject.Instantiate(toinst, toinst.parent).gameObject;
            inst.name = btnText + "BTN";
            var txt = inst.transform.Find("Container/Text_QM_H3").GetComponent<TMPro.TextMeshProUGUI>();
            txt.richText = true;
            txt.text = ($"<color=#000080ff>{btnText}</color>"); GameObject.DestroyImmediate(inst.transform.Find("Container/Icon").gameObject);
            var btn = inst.GetComponent<UnityEngine.UI.Button>(); btn.onClick.RemoveAllListeners();
            btn.onClick.AddListener(callback);

        }
        
        public static Transform camera()
        {
            return VRCPlayer.field_Internal_Static_VRCPlayer_0.transform;
        }
        public override void OnUpdate()
        {
            Funni.NaziItems();
            Funni.arroworbit();
            if (TPlugerbool == true)
            {
                EggClient.BlackCatHat.CatTargetGiveTarget();
            }
            if (ButterFingers)
            {
                Eggsploits1.DropUrPants();
            }
            if (Plugerbool == true)
            {
                EggClient.BlackCatHat.CatTargetGive();
            }
            // Movement.Movement.Movment();   
        }
        public override void OnApplicationStart()
        {
           
            MelonCoroutines.Start(waitforui());


            MenuStart();


        }
      
        private static Sprite LoadSprite(string sprite)
        {
            return $"{resourcePath}/{sprite}".LoadSpriteFromDisk();
        }

        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
            if (sceneName == "ui")
            {
                Console.WriteLine("UI Detected! Setting loading screen animation & loading screen music...");
                CustomMenuMusic.OnUiManagerInit();
            }
            if (buildIndex == -1)
            {
                Console.WriteLine("UI Detected! Setting loading screen animation & loading screen music...");
                CustomMenuMusic.OnUiManagerInit();
            }
            Movement.Movement.OnSceneWasInitialized(buildIndex);

        
        }

        public static void MenuStart()
        {
            string menuName = "Button_MainMenu";
            string pageTitle = "EggClient";
            bool root = true;
            bool backButton = false;
            bool extButton = false;
            Action extButtonAction = null;
            string str = "<color=#4CA750>Egg Client</color> version ";

             //Buttons
            GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Container/InnerContainer/WingMenu/WngHeader_H1/LeftItemContainer/Text_Title").GetComponent<TMP_Text>().faceColor = Color.magenta;
            GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Left/Container/InnerContainer/WingMenu/WngHeader_H1/LeftItemContainer/Text_Title").GetComponent<TMP_Text>().faceColor = Color.magenta;
            GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/Header_H1/LeftItemContainer/Text_Title").GetComponent<TMP_Text>().faceColor = Color.magenta;

            GameObject.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Worlds/Text_H4").GetComponent<TMP_Text>().faceColor = Color.magenta;
            GameObject.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Worlds/Background").GetComponent<Image>().color = Color.black;

            GameObject.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Avatars/Text_H4").GetComponent<TMP_Text>().faceColor = Color.magenta;
            GameObject.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Avatars/Background").GetComponent<Image>().color = Color.black;

            GameObject.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Social/Text_H4").GetComponent<TMP_Text>().faceColor = Color.magenta;
            GameObject.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Social/Background").GetComponent<Image>().color = Color.black;


            GameObject.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Safety/Text_H4").GetComponent<TMP_Text>().faceColor = Color.magenta;
            GameObject.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Safety/Background").GetComponent<Image>().color = Color.black;

            GameObject.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Respawn/Text_H4").GetComponent<TMP_Text>().faceColor = Color.magenta;
            GameObject.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Respawn/Background").GetComponent<Image>().color = Color.black;

            GameObject.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/ Button_InteractionPauseWithState/Text_H4").GetComponent<TMP_Text>().faceColor = Color.magenta;
            GameObject.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/ Button_InteractionPauseWithState/Background").GetComponent<Image>().color = Color.black;


            var BackGround1 = (Environment.CurrentDirectory + "\\LynxClient\\Background1.png").LoadSpriteFromDisk();
            GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/BackgroundLayer01").GetComponent<Image>().overrideSprite = BackGround1;
            GameObject.Find("UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/BackgroundLayer02").GetComponent<Image>().overrideSprite = BackGround1;

            MenuPage basePage = new MenuPage(menuName, pageTitle, true, true, false, null, str, Main.LoadSprite("Eggclient.png"), true);
            otherGroup = new ButtonGroup(basePage.menuContents, "EggClient");

            MenuPage MPage = new MenuPage("MurderHacks Page 1", "MurderHacks 1", true, true, false, null, str, Main.LoadSprite("Eggclient.png"), true);
            var MGroup = new ButtonGroup(MPage.menuContents, "MurderHacks Page 1");

            MenuPage M1Page = new MenuPage("MurderHacks Page 2", "MurderHacks 2", true, true, false, null, str, Main.LoadSprite("Eggclient.png"), true);
            var M1Group = new ButtonGroup(M1Page.menuContents, "MurderHacks Page 2");

            MenuPage EPage = new MenuPage("Eggsploits", "Eggsploits", true, true, false, null, str, Main.LoadSprite("Eggclient.png"), true);
            var EGroup = new ButtonGroup(EPage.menuContents, "Eggsploits");

            MenuPage MovePage = new MenuPage("Movement", "Movement", true, true, false, null, str, Main.LoadSprite("Eggclient.png"), true);
            var MoveGroup = new ButtonGroup(MovePage.menuContents, "Movement");

            MenuPage PPage = new MenuPage("Prison Hacks", "Prison Hacks", true, true, false, null, str, Main.LoadSprite("Eggclient.png"), true);
            var PGroup = new ButtonGroup(PPage.menuContents, "Prison Hacks");

            MenuPage APage = new MenuPage("AmoungUs Hacks", "AmoungUs Hacks", true, true, false, null, str, Main.LoadSprite("Eggclient.png"), true);
            var AGroup = new ButtonGroup(APage.menuContents, "AmoungUs Hacks");

            MenuPage PhoPage = new MenuPage("Photon Exploits", "Photon Exploits", true, true, false, null, str, Main.LoadSprite("Eggclient.png"), true);
            var PhoGroup = new ButtonGroup(PhoPage.menuContents, "Photon Exploits");

            MenuPage QPage = new MenuPage("Quality Of Life", "Quality Of Life", true, true, false, null, str, Main.LoadSprite("Eggclient.png"), true);
            var QGroup = new ButtonGroup(QPage.menuContents, "Quality Of Life");



            //  var UserSelection = new ButtonGroup(Menu_SelectedUser_Local.transform, "EggClient");

            Tab mainTab = new Tab(ButtonAPI.menuTabBase.transform.parent, "Button_MainMenu", "EggClient", LoadSprite("Eggclient.png"), delegate ()
            {
                basePage.OpenMenu();
            });

            // new SingleButton(UserSelection, "Teloport", new Action(() =>
            // {
            //     
            // }), "", Main.LoadSprite("Eggclient.png"), false);


            new SingleButton(otherGroup, "Eggsploits", new Action(() =>
            {
                EPage.OpenMenu();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(otherGroup, "Movement", new Action(() =>
            {
                MovePage.OpenMenu();
            }), "", LoadSprite("running.png"), false);

            new SingleButton(otherGroup, "Murder 4", new Action(() =>
            {
                MPage.OpenMenu();
            }), "K", LoadSprite("Murder.png"), false);

            new SingleButton(otherGroup, "Prison Hacks", new Action(() =>
            {
                PPage.OpenMenu();
            }), "", LoadSprite("Kill.png"), false);

            new SingleButton(otherGroup, "Photon Exploits", new Action(() =>
            {
                PhoPage.OpenMenu();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(otherGroup, "Quality Of Life", new Action(() =>
            {
                QPage.OpenMenu();
            }), "", LoadSprite("Eggclient.png"), false);



            new SingleButton(MGroup, "Start Game", new Action(() =>
            {
                Murder.StartCount();
            }), "", LoadSprite("Eggclient.png"), false);


            new SingleButton(MGroup, "Abort Game", new Action(() =>
            {
                Murder.Abort();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(MGroup, "Murder Win", new Action(() =>
            {
                Murder.MurderW();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(MGroup, "Bystander Win", new Action(() =>
            {

                Murder.BystanderW();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(MGroup, "Kill All", new Action(() =>
            {
                Murder.Killall();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(MGroup, "Everyone Murderer", new Action(() =>
            {
                Murder.MurderAll();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(MGroup, "Bring All Knives", new Action(() =>
            {
                Murder.BringAllKnifes();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(MGroup, "Bring Lugar", new Action(() =>
            {
                Murder.Luger();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(MGroup, "Bring Shotgun", new Action(() =>
            {
                Murder.Shotgun();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(MGroup, "Bring Revolver", new Action(() =>
            {
                Murder.Revolver();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(MGroup, "Bring Frag", new Action(() =>
            {
                Murder.Frag();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(MGroup, "Slam Doors", new Action(() =>
            {
                Murder.SlamDoors();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(MGroup, "Break Doors", new Action(() =>
            {
                Murder.BreakDoors();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(MGroup, "Self Bystander", new Action(() =>
            {
                Murder.SelfBystander();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(M1Group, "Self Murderer", new Action(() =>
            {
                Murder.SelfMurderer();
            }), "", LoadSprite("Eggclient.png"), false);


            new SingleButton(MGroup, "Page 2", new Action(() =>
            {
                M1Page.OpenMenu();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(M1Group, "Lazer", new Action(() =>
            {
                Murder1.Lazer();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(M1Group, "Flash Fuck All", new Action(() =>
            {
                Murder.BlindAll();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(M1Group, "Force Pickups", new Action(() =>
            {
                Murder1.PickupSteal();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(M1Group, "No Bloat", new Action(() =>
            {
                Murder1.NoBloat();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(M1Group, "NoDoorColiders", new Action(() =>
            {
                Murder1.NoDoorColiders();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(M1Group, "XmasGun", new Action(() =>
            {
                Murder.XmasGun();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(M1Group, "Golden Gun", new Action(() =>
            {

                if (GoldenGunBool == false)
                {
                    GoldenGunBool = true;
                    MelonCoroutines.Start(Murder.GoldenGun());
                }
                else
                  if (GoldenGunBool == true)
                {
                    GoldenGunBool = false;
                    MelonCoroutines.Start(Murder.UnGoldenGun());
                }
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(M1Group, "Fix Bounds", new Action(() =>
            {
                Murder1.FixBounds();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(M1Group, "Reset Bounds", new Action(() =>
            {
                Murder1.ResetBounds();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(M1Group, "No HUD", new Action(() =>
            {
                Murder.HudOff();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(M1Group, "Lights off", new Action(() =>
            {
                Murder.LightsOff();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(M1Group, "Lights on", new Action(() =>
            {
                Murder.LightsOn();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(M1Group, "MurderText", new Action(() =>
            {
                if (M4Text == true)
                {
                    if (RoomManager.field_Internal_Static_ApiWorld_0.id == "wrld_858dfdfc-1b48-4e1e-8a43-f0edc611e5fe")
                    {
                        MelonCoroutines.Start(FunniText.Eggclient());
                        new WaitForSeconds(0.1f);
                        MelonCoroutines.Start(FunniText.Eggclient2());
                        new WaitForSeconds(0.1f);
                        MelonCoroutines.Start(FunniText.Eggclient3());
                        new WaitForSeconds(0.1f);
                        MelonCoroutines.Start(FunniText.Eggclient4());
                    }
                }
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(M1Group, "Kill Loop All", new Action(() =>
            {
                if (Murder.KillLoop == false)
                {
                    Murder.KillLoop = true;
                    Murder.KillLoopAll();
                }
                else
                    if (Murder.KillLoop == true)
                {
                    Murder.KillLoop = false;
                }
            }), "", LoadSprite("Eggclient.png"), false);


            new SingleButton(PGroup, "Invis LMG", new Action(() =>
            {
                PrisonHacks.PrisonHacks.BringLMG();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(PGroup, "Invis P90", new Action(() =>
            {
                PrisonHacks.PrisonHacks.BringP90();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(PGroup, "Invis Ak47", new Action(() =>
            {
                PrisonHacks.PrisonHacks.BringAK47();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(PGroup, "Bring Sniper", new Action(() =>
            {
                PrisonHacks.PrisonHacks.BringSniper();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(PGroup, "Invis Knife", new Action(() =>
            {
                PrisonHacks.PrisonHacks.BringKnife1();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(PGroup, "Invis Knife 2", new Action(() =>
            {
                PrisonHacks.PrisonHacks.BringKnife2();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(PGroup, "Invis Energy", new Action(() =>
            {
                PrisonHacks.PrisonHacks.BringEnergy();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(PGroup, "Invis Rocket1", new Action(() =>
            {
                PrisonHacks.PrisonHacks.BringRocket1();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(PGroup, "Invis Rocket2", new Action(() =>
            {
                PrisonHacks.PrisonHacks.BringRocket2();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(PGroup, "Bring KeyCards", new Action(() =>
            {
                PrisonHacks.PrisonHacks.KeyCard();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(PGroup, "No Bloat", new Action(() =>
            {
                PrisonHacks.PrisonHacks.NoBloat();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(PGroup, "NoDoors", new Action(() =>
            {
                Murder1.NoDoorsPrison();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(PGroup, "NoWantedAreas", new Action(() =>
            {
                Murder1.NoWantedZones();
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(PGroup, "Bring Money", new Action(() =>
            {
                PrisonHacks.PrisonHacks.BringMoney();
            }), "", LoadSprite("Eggclient.png"), false);


            new SingleButton(MoveGroup, "Fly", new Action(() =>
            {

                if (flytoggle == false)
                {
                    flytoggle = true;
                    VRC.Player.prop_Player_0.gameObject.GetComponent<CharacterController>().enabled = true;
                }
                else
               if (flytoggle == true)
                {
                    flytoggle = false;
                    VRC.Player.prop_Player_0.gameObject.GetComponent<CharacterController>().enabled = false;
                }

            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(MoveGroup, "Force Jump", new Action(() =>
            {
                Networking.LocalPlayer.SetJumpImpulse(4);
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(MoveGroup, "Speed Hack", new Action(() =>
            {
                if (SpeedH == false)
                {
                    SpeedH = true;
                    Movement.Movement.SpeedHack();
                }
                if (SpeedH == true)
                {
                    SpeedH = false;
                    Movement.Movement.UnSpeedHack();
                }
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(PhoGroup, "USpeak Loud Mic", new Action(() =>
            {
                if (USPEAKLOUD == false)
                {
                    USPEAKLOUD = true;
                    USpeaker.field_Internal_Static_Single_1 = float.MaxValue;
                }
                else
                    if (USPEAKLOUD == true)
                {
                    USPEAKLOUD = false;
                    USpeaker.field_Internal_Static_Single_1 = 1f;
                }

            }), "", LoadSprite("Speaker.png"), false);


            new SingleButton(EGroup, "Item Lagger", new Action(() =>
            {
                if (toggled4 == false)
                {
                    OnEnable();
                }
                else
                if (toggled4 == true)
                {
                    OnDisable();
                }
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(EGroup, "Nazi Items", new Action(() =>
            {
                if (Funni.sovasticabool == false)
                {
                    Funni.sovasticabool = true;
                    Funni.vec3poz = EggClient.Extentions.Extentions.LocalPlayer.transform.position;
                }
                else
                if (Funni.sovasticabool == true)
                {
                    Funni.sovasticabool = false;
                }
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(EGroup, "Arrow Items", new Action(() =>
            {
                if (Funni.arroworbittoggle == false)
                {
                    Funni.arroworbittoggle = true;
                }
                else
                if (Funni.arroworbittoggle == true)
                {
                    Funni.arroworbittoggle = false;
                }
            }), "", LoadSprite("Eggclient.png"), false);


            /* new SingleButton(EGroup, "Funni", new Action(() =>
             {
                 if (PortalSpam == false)
                 {
                     PortalSpam = true;
                     Eggsploits1.PortalSpam();
                 }
                 else
                     if (PortalSpam == true)
                 {
                     PortalSpam = false;
                 }
             }), "", LoadSprite("Eggclient.png"), false);*/



            new SingleButton(EGroup, "Pickups To Space", new Action(() =>
            {

                Eggsploits1.PickupsToSpace();

            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(EGroup, "Respawn Pickups", new Action(() =>
            {
                Eggsploits1.RespawnPickups();

            }), "", LoadSprite("Eggclient.png"), false);

            /* new SingleButton(EGroup, "Spin test(W.I.P)", new Action(() =>
             {
                 if (Spin == false)
                 {
                     Spin = true;
                    MelonCoroutines.Start(Eggsploits1.SpinBoi());
                 }
                 else
                     if (Spin == true)
                 {
                     Spin = false;
                 }

             }), "", LoadSprite("Eggclient.png"), false);*/

            new SingleButton(EGroup, "Yeet Pickups", new Action(() =>
            {
                if (Yeet == false)
                {
                    Yeet = true;
                    Eggsploits1.Yeetpickups();
                }
                else
                    if (Yeet == true)
                {
                    Yeet = false;
                    Eggsploits1.UnYeetpickups();
                }

            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(EGroup, "Hide Pickups", new Action(() =>
                {
                    if (HidePickups == false)
                    {
                        HidePickups = true;
                        Eggsploits1.HidePickups();
                    }
                    else
                        if (HidePickups == true)
                    {
                        HidePickups = false;
                        Eggsploits1.HidePickups();
                    }

                }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(EGroup, "Butter Fingers", new Action(() =>
            {
                if (ButterFingers == false)
                {
                    ButterFingers = true;
                }
                else

                if (ButterFingers == true)
                {
                    ButterFingers = false;
                }

            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(EGroup, "Item No Collider(W.I.P)", new Action(() =>
            {
                if (ColliderBool == false)
                {
                    ColliderBool = true;
                    Eggsploits1.NoCollider();
                }
                else
                    if (ColliderBool == true)
                {
                    ColliderBool = false;
                    Eggsploits1.UnNoCollider();
                }

            }), "", LoadSprite("Eggclient.png"), false);


            new SingleButton(EGroup, "Udon Nuke(W.I.P)", new Action(() =>
            {
                Eggsploits.UdonNuker.Nuker();

            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(EGroup, "AntiTheft(W.I.P)", new Action(() =>
            {

                if (AntiTheft == false)
                {
                    AntiTheft = true;
                    Eggsploits.AntiTheft.AntiPickupTheift();
                }
                else
                    if (AntiTheft == true)
                {
                    AntiTheft = false;
                }
            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(EGroup, "Black Cat Pluger", new Action(() =>
            {
                if (Plugerbool == false)
                {
                    Plugerbool = true;
                }
                else
                 if (Plugerbool == true)
                {
                    Plugerbool = false;
                }

            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(EGroup, "UdonDumper", new Action(() =>
            {
                EggClient.Eggsploits.UdonDumper.LogUdon(RoomManager.field_Internal_Static_ApiWorld_0.id);

            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(QGroup, "UltraLow", new Action(() =>
            {
                EggClient.Utils.FPSStuff.UltraLow();

            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(QGroup, "Low", new Action(() =>
            {
                EggClient.Utils.FPSStuff.low();

            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(QGroup, "Fps Target 90", new Action(() =>
            {
                EggClient.Utils.FPSStuff.SetFPS90();

            }), "", LoadSprite("Eggclient.png"), false);

            new SingleButton(AGroup, "Eject All", new Action(() =>
            {
                AmongUsHacks.EjectAll();

            }), "", LoadSprite("Eggclient.png"), false);




            Transform baseMenuTransform = ButtonAPI.menuPageBase.transform.parent.Find("Menu_SelectedUser_Local/ScrollRect/Viewport/VerticalLayoutGroup");
            var selectedUserGroup = new ButtonGroup(baseMenuTransform, "EggClient Actions");
            var selectedBlackCatGroup = new ButtonGroup(baseMenuTransform, "EggClient Black Cat Actions");
            var selectedMurderGroup = new ButtonGroup(baseMenuTransform, "EggClient Murder 4 Actions");
            var selectedUtilGroup = new ButtonGroup(baseMenuTransform, "EggClient Util Actions");

          var teleportButton = new SimpleSingleButton(selectedUserGroup, "Teleport", () =>
            {
                VRCPlayer.field_Internal_Static_VRCPlayer_0.field_Private_VRCPlayerApi_0.TeleportTo(IUserExtension.GetVRCPlayer().transform.position, IUserExtension.GetVRCPlayer().transform.rotation);
            }, "");

         var teleportButton1 = new SimpleSingleButton(selectedBlackCatGroup, "Target BlackCat Hat", () =>
            {
                if (TPlugerbool == false)
                {
                    TPlugerbool = true;
                }
                else
                 if (TPlugerbool == true)
                {
                    TPlugerbool = false;
                }
            }, "Plunger");

            new SimpleSingleButton(selectedMurderGroup, "Kill", () =>
            {
                MurderHacks.TargetM4Stuff.KillTarget();
            }, "Kills User");

            new SimpleSingleButton(selectedMurderGroup, "Make Murder", () =>
            {
                MurderHacks.TargetM4Stuff.MakeMurder();
            }, "Kills User");

            new SimpleSingleButton(selectedMurderGroup, "Make Bystander", () =>
            {
                MurderHacks.TargetM4Stuff.MakeBystander();
            }, "Kills User");

            new SimpleSingleButton(selectedMurderGroup, "TP Frag", () =>
            {
                MurderHacks.TargetM4Stuff.BringFrag(IUserExtension.GetVRCPlayer());
            }, "Kills User");

            new SimpleSingleButton(selectedMurderGroup, "TP Knives", () =>
            {
                MurderHacks.TargetM4Stuff.TPAllKnives(IUserExtension.GetVRCPlayer());
            }, "Kills User");

            new SimpleSingleButton(selectedMurderGroup, "TP Luger", () =>
            {
                MurderHacks.TargetM4Stuff.BringLuger(IUserExtension.GetVRCPlayer());
            }, "");

            new SimpleSingleButton(selectedMurderGroup, "TP Shotgun", () =>
            {
                MurderHacks.TargetM4Stuff.BringShotgun(IUserExtension.GetVRCPlayer());
            }, "Kills User");

            new SimpleSingleButton(selectedUserGroup, "Give All Items", () =>
            {
                EggClient.Eggsploits1.TargetBringAll();
            }, "OwO");

            new SingleButton(selectedUserGroup, "UwU Lagger", new Action(() =>
            {
                if (UwU == false)
                {
                    Eggsploits1.OnEnableUwU();
                }
                else
                if (UwU == true)
                {
                    Eggsploits1.OnDisableUwU();
                }
            }), "", LoadSprite("Eggclient.png"), false);
        }



    public virtual void OnUiManagerInit()
        {
            ObjectPublicHa1UnT1Unique<Player> field_Internal_ObjectPublicHa1UnT1Unique_1_Player_ = NetworkManager.field_Internal_Static_NetworkManager_0.field_Internal_ObjectPublicHa1UnT1Unique_1_Player_0;
            ObjectPublicHa1UnT1Unique<Player> field_Internal_ObjectPublicHa1UnT1Unique_1_Player_2 = NetworkManager.field_Internal_Static_NetworkManager_0.field_Internal_ObjectPublicHa1UnT1Unique_1_Player_2;
            field_Internal_ObjectPublicHa1UnT1Unique_1_Player_.field_Private_HashSet_1_UnityAction_1_T_0.Add(new Action<Player>(OnPlayerJoin));
        }

        private static void OnPlayerJoin(Player player)
        {
            EggClient.Utils.ScreenLogger.Msg($"{player.field_Private_APIUser_0.username} joined the lobby", 4);
            MelonLogger.Msg($"{player.field_Private_APIUser_0.username} joined the lobby - {player.field_Private_APIUser_0.id}");
            //   using (StreamReader r = new StreamReader("Tags.json"))
            //  {
            //     string json = r.ReadToEnd();
            //    var jo = JObject.Parse(json.ToString());
            //  var id = (JArray)jo[player.field_Private_APIUser_0.id];
            //  JArray a = JArray.Parse(id.ToString());
            //  MelonLogger.Msg(id.ToString());
            //  Tags.AddTag(player, a, (int)(float)a.Count);
            //}

            if (player.prop_APIUser_0.displayName == VRC.Core.APIUser.CurrentUser.displayName)
            {
                if (joinedLobby == false)
                {
                    if (File.Exists(Directory.GetCurrentDirectory() + "\\key.txt"))
                    {
                        string[] lines = File.ReadAllLines(Directory.GetCurrentDirectory() + "\\key.txt");
                       
                        string hostName = Dns.GetHostName();
                        Managers.KeyMessage[] keyMessages = { new Managers.KeyMessage(lines[0], hostName) };
                        ws.Send(JsonConvert.SerializeObject(keyMessages));
                    }
               
                }
            }
        }
        public static bool toggled4 = false;
        public static bool UwU = false;
        public static void OnEnable()
        {
            toggled4 = true;
            MelonCoroutines.Start(ItemLagger());
            MelonCoroutines.Start(ItemLagger2());
        }

        public static void OnDisable()
        {
            toggled4 = false;
            MelonCoroutines.Stop(ItemLagger());
            MelonCoroutines.Stop(ItemLagger2());
        }

        public static IEnumerator ItemLagger()
        {
            while (toggled4)
            {
                foreach (VRC_Pickup VRCPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
                {
                    Networking.LocalPlayer.TakeOwnership(VRCPickup.gameObject);
                    VRCPickup.transform.position = Misc1.GetPlayer().transform.position + new Vector3(0f, 0.15f, 0f);
                }
                yield return new WaitForSeconds(0.3f);
            }
            yield break;
        }

        public static IEnumerator ItemLagger2()
        {
            while (toggled4)
            {
                foreach (VRC_Pickup VRCPickup in UnityEngine.Object.FindObjectsOfType<VRC_Pickup>())
                {
                    Networking.LocalPlayer.TakeOwnership(VRCPickup.gameObject);
                    VRCPickup.transform.position = Misc1.GetPlayer().transform.position + new Vector3(0f, 9.998E+07f, 0);
                }
                yield return new WaitForSeconds(0.3f);
            }
            yield break;
        }
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            if (sceneName == "ui")
            {
                Console.WriteLine("UI Detected! Setting loading screen animation & loading screen music...");
                CustomMenuMusic.OnUiManagerInit();
            }           
                 if (buildIndex == -1)
            {
                Console.WriteLine("UI Detected! Setting loading screen animation & loading screen music...");
                CustomMenuMusic.OnUiManagerInit();
            }
        }

        private IEnumerator waitforui()
        {
            MelonLogger.Msg("Waiting For Ui");
            while (GameObject.Find("UserInterface") == null) yield return null;
            while (GameObject.Find("UserInterface").transform.Find("Canvas_QuickMenu(Clone)") == null) yield return null;
            MelonLogger.Msg("Ui loaded");

            CustomMenuMusic.OnUiManagerInit();
            ButtonAPI.OnUiManagerInit();
            MenuStart();
            LoadingScreen.runti();
          


            _originalGravity = Physics.gravity;
            canset = false;
            loaded = true;
        }
    }
}