using System;
using System.Drawing;
using System.Linq;
using UnityEngine;
using VRC.UI.Elements;
using VRC.UI.Elements.Menus;

//Credits Dayoftheplay
namespace EggClient
{
    public class MenuContent
    {
        public class QuickMenuStuff
        {
            public Image Button_WorldsIcon;
            public Image Button_AvatarsIcon;
            public Image Button_SocialIcon;
            public Image Button_SafetyIcon;
            public Image Panel_NoNotifications_MessageIcon;

            public Image Button_NameplateVisibleIcon;

            public Image Button_GoHomeIcon;
            public Image Button_RespawnIcon;
            public Image StandIcon;

            public VRC.UI.Elements.QuickMenu quickMenu;
            public SelectedUserMenuQM selectedUserMenuQM;
            public MenuStateController menuStateController;

            public Transform tabMenuTemplat;
            public Transform Menu_DevTools;
            public Transform Menu_Dashboard;
            public Transform QMParent;
            public Transform page_Buttons_QM;

            public QuickMenuStuff()
            {
                quickMenu = Resources.FindObjectsOfTypeAll<VRC.UI.Elements.QuickMenu>().First();
                menuStateController = quickMenu.gameObject.GetComponent<MenuStateController>();

                Button_WorldsIcon = quickMenu.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Worlds/Icon").GetComponent<Image>();
                Button_AvatarsIcon = quickMenu.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Avatars/Icon").GetComponent<Image>();
                Button_SocialIcon = quickMenu.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Social/Icon").GetComponent<Image>();
                Button_SafetyIcon = quickMenu.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickLinks/Button_Safety/Icon").GetComponent<Image>();

                Button_GoHomeIcon = quickMenu.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_GoHome/Icon").GetComponent<Image>();
                Button_RespawnIcon = quickMenu.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/Button_Respawn/Icon").GetComponent<Image>();
                StandIcon = quickMenu.transform.Find("Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport/VerticalLayoutGroup/Buttons_QuickActions/SitStandCalibrateButton/Button_SitStand/Icon_Off").GetComponent<Image>();
                Panel_NoNotifications_MessageIcon = quickMenu.transform.Find("Container/Window/QMParent/Menu_Notifications/Panel_NoNotifications_Message/Icon").gameObject.GetComponent<Image>();

                Button_NameplateVisibleIcon = quickMenu.transform.Find("Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport/VerticalLayoutGroup/Buttons_UI_Elements_Row_1/Button_NameplateControls/Buttons/Button A/Icon").GetComponent<Image>();

                selectedUserMenuQM = quickMenu.transform.Find("Container/Window/QMParent/Menu_SelectedUser_Local").GetComponent<SelectedUserMenuQM>();
                tabMenuTemplat = quickMenu.transform.Find("Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_DevTools");
                Menu_DevTools = quickMenu.transform.Find("Container/Window/QMParent/Menu_DevTools");
                QMParent = quickMenu.transform.Find("Container/Window/QMParent");
                page_Buttons_QM = quickMenu.transform.Find("Container/Window/Page_Buttons_QM/HorizontalLayoutGroup");
                Menu_Dashboard = quickMenu.transform.Find("Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Settings");
            }
        }
        public static GameObject Backdrop => GameObject.Find("/UserInterface/MenuContent/Backdrop");
        public class Backdrop_1
        {
            public static GameObject Backdrop => GameObject.Find("/UserInterface/MenuContent/Backdrop/Backdrop");
            public class Backdrop_2
            {
                public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Backdrop/Backdrop/Background");
                public static GameObject TopLine => GameObject.Find("/UserInterface/MenuContent/Backdrop/Backdrop/TopLine");
                public static GameObject BottomLine => GameObject.Find("/UserInterface/MenuContent/Backdrop/Backdrop/BottomLine");
                public static GameObject BackgroundCircles => GameObject.Find("/UserInterface/MenuContent/Backdrop/Backdrop/BackgroundCircles");
                public static GameObject EarlyAccessText => GameObject.Find("/UserInterface/MenuContent/Backdrop/Backdrop/EarlyAccessText");
                public static GameObject Directional_light_This_makes_shaders_work_dont_worry_about_it_dleslie_Actually_it_breaks_the_beam_shaders => GameObject.Find("/UserInterface/MenuContent/Backdrop/Backdrop/Directional light [This makes shaders work don't worry about it] dleslie: Actually, it breaks the beam shaders");
                public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Backdrop/Backdrop/Image");

            }
            public static GameObject Header => GameObject.Find("/UserInterface/MenuContent/Backdrop/Header");
            public class Header_2
            {
                public static GameObject ArrowRight => GameObject.Find("/UserInterface/MenuContent/Backdrop/Header/ArrowRight");
                public static GameObject ArrowLeft => GameObject.Find("/UserInterface/MenuContent/Backdrop/Header/ArrowLeft");
                public static GameObject Tabs => GameObject.Find("/UserInterface/MenuContent/Backdrop/Header/Tabs");
                public class Tabs_3
                {
                    public static GameObject ViewPort => GameObject.Find("/UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort");
                    public class ViewPort_4
                    {
                        public static GameObject Content => GameObject.Find("/UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content");
                        public class Content_5
                        {
                            public static GameObject VRCPlusPageTab => GameObject.Find("/UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/VRC+PageTab");
                            public static GameObject GalleryTab => GameObject.Find("/UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/GalleryTab");
                            public static GameObject WorldsPageTab => GameObject.Find("/UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/WorldsPageTab");
                            public static GameObject AvatarPageTab => GameObject.Find("/UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/AvatarPageTab");
                            public static GameObject SocialPageTab => GameObject.Find("/UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/SocialPageTab");
                            public static GameObject SettingsPageTab => GameObject.Find("/UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/SettingsPageTab");
                            public static GameObject SafetyPageTab => GameObject.Find("/UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/SafetyPageTab");
                            public static GameObject Search => GameObject.Find("/UserInterface/MenuContent/Backdrop/Header/Tabs/ViewPort/Content/Search");

                        }

                    }

                }

            }
            public static GameObject Avatar => GameObject.Find("/UserInterface/MenuContent/Backdrop/Avatar");
            public class Avatar_2
            {
                public static GameObject AvatarModel => GameObject.Find("/UserInterface/MenuContent/Backdrop/Avatar/AvatarModel");
                public static GameObject EditPlayerDirLight => GameObject.Find("/UserInterface/MenuContent/Backdrop/Avatar/EditPlayerDirLight");

            }

        }
        public static GameObject Screens => GameObject.Find("/UserInterface/MenuContent/Screens");
        public class Screens_1
        {
            public static GameObject Announcement => GameObject.Find("/UserInterface/MenuContent/Screens/Announcement");
            public class Announcement_2
            {
                public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel");
                public class Panel_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/Text");
                    public static GameObject ButtonBack => GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/ButtonBack");
                    public class ButtonBack_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/ButtonBack/Text");
                        public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/ButtonBack/Image");

                    }
                    public static GameObject ButtonDone => GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/ButtonDone");
                    public class ButtonDone_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/ButtonDone/Text");
                        public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/ButtonDone/Image");

                    }
                    public static GameObject Scroll_View => GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/Scroll View");
                    public class Scroll_View_4
                    {
                        public static GameObject Viewport => GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/Scroll View/Viewport");
                        public class Viewport_5
                        {
                            public static GameObject Content => GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/Scroll View/Viewport/Content");

                        }
                        public static GameObject Scrollbar_Horizontal => GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/Scroll View/Scrollbar Horizontal");
                        public class Scrollbar_Horizontal_5
                        {
                            public static GameObject Sliding_Area => GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/Scroll View/Scrollbar Horizontal/Sliding Area");

                        }
                        public static GameObject Scrollbar_Vertical => GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/Scroll View/Scrollbar Vertical");
                        public class Scrollbar_Vertical_5
                        {
                            public static GameObject Sliding_Area => GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/Scroll View/Scrollbar Vertical/Sliding Area");

                        }
                        public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/Scroll View/Image");
                        public class Image_5
                        {
                            public static GameObject LoadingIcon => GameObject.Find("/UserInterface/MenuContent/Screens/Announcement/Panel/Scroll View/Image/LoadingIcon");

                        }

                    }

                }

            }
            public static GameObject Authentication => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication");
            public class Authentication_2
            {
                public static GameObject Login2FA => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA");
                public class Login2FA_3
                {
                    public static GameObject VRChat_LOGO => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/VRChat_LOGO");
                    public static GameObject TextWelcome => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/TextWelcome");
                    public static GameObject BoxLogin2FA => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA");
                    public class BoxLogin2FA_4
                    {
                        public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/Panel");
                        public static GameObject Title => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/Title");
                        public static GameObject Instructions => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/Instructions");
                        public static GameObject InputField2FACode => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/InputField2FACode");
                        public class InputField2FACode_5
                        {
                            public static GameObject Placeholder => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/InputField2FACode/Placeholder");
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/InputField2FACode/Text");

                        }
                        public static GameObject ButtonDone => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/ButtonDone");
                        public class ButtonDone_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/ButtonDone/Text");

                        }
                        public static GameObject ButtonBack => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/ButtonBack");
                        public class ButtonBack_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/ButtonBack/Text");

                        }
                        public static GameObject ButtonUseRecoveryCode => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/ButtonUseRecoveryCode");
                        public class ButtonUseRecoveryCode_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/ButtonUseRecoveryCode/Text");

                        }
                        public static GameObject ButtonHelp => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/ButtonHelp");
                        public class ButtonHelp_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/BoxLogin2FA/ButtonHelp/Text");

                        }

                    }
                    public static GameObject ButtonAboutUs => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/ButtonAboutUs");
                    public class ButtonAboutUs_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/ButtonAboutUs/Text");
                        public static GameObject About_Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/ButtonAboutUs/About_Panel");
                        public class About_Panel_5
                        {
                            public static GameObject Text_2 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/ButtonAboutUs/About_Panel/Text (2)");
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/ButtonAboutUs/About_Panel/Text");

                        }

                    }
                    public static GameObject TextVRChat => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FA/TextVRChat");

                }
                public static GameObject Login2FAEmail => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail");
                public class Login2FAEmail_3
                {
                    public static GameObject VRChat_LOGO => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail/VRChat_LOGO");
                    public static GameObject TextWelcome => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail/TextWelcome");
                    public static GameObject BoxLogin2FA => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail/BoxLogin2FA");
                    public class BoxLogin2FA_4
                    {
                        public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail/BoxLogin2FA/Panel");
                        public static GameObject Title => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail/BoxLogin2FA/Title");
                        public static GameObject Instructions => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail/BoxLogin2FA/Instructions");
                        public static GameObject InputField2FACode => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail/BoxLogin2FA/InputField2FACode");
                        public class InputField2FACode_5
                        {
                            public static GameObject Placeholder => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail/BoxLogin2FA/InputField2FACode/Placeholder");
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail/BoxLogin2FA/InputField2FACode/Text");

                        }
                        public static GameObject ButtonDone => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail/BoxLogin2FA/ButtonDone");
                        public class ButtonDone_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail/BoxLogin2FA/ButtonDone/Text");

                        }
                        public static GameObject ButtonBack => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail/BoxLogin2FA/ButtonBack");
                        public class ButtonBack_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail/BoxLogin2FA/ButtonBack/Text");

                        }
                        public static GameObject ButtonUseRecoveryCode => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail/BoxLogin2FA/ButtonUseRecoveryCode");
                        public class ButtonUseRecoveryCode_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail/BoxLogin2FA/ButtonUseRecoveryCode/Text");

                        }
                        public static GameObject ButtonHelp => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail/BoxLogin2FA/ButtonHelp");
                        public class ButtonHelp_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail/BoxLogin2FA/ButtonHelp/Text");

                        }

                    }
                    public static GameObject ButtonAboutUs => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail/ButtonAboutUs");
                    public class ButtonAboutUs_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail/ButtonAboutUs/Text");
                        public static GameObject About_Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail/ButtonAboutUs/About_Panel");
                        public class About_Panel_5
                        {
                            public static GameObject Text_2 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail/ButtonAboutUs/About_Panel/Text (2)");
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail/ButtonAboutUs/About_Panel/Text");

                        }

                    }
                    public static GameObject TextVRChat => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FAEmail/TextVRChat");

                }
                public static GameObject Login2FARecovery => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery");
                public class Login2FARecovery_3
                {
                    public static GameObject VRChat_LOGO => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/VRChat_LOGO");
                    public static GameObject TextWelcome => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/TextWelcome");
                    public static GameObject BoxLogin2FARecovery => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery");
                    public class BoxLogin2FARecovery_4
                    {
                        public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery/Panel");
                        public static GameObject Title => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery/Title");
                        public static GameObject Instructions => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery/Instructions");
                        public static GameObject InputField2FARecoveryCode => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery/InputField2FARecoveryCode");
                        public class InputField2FARecoveryCode_5
                        {
                            public static GameObject Placeholder => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery/InputField2FARecoveryCode/Placeholder");
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery/InputField2FARecoveryCode/Text");

                        }
                        public static GameObject ButtonDone => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery/ButtonDone");
                        public class ButtonDone_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery/ButtonDone/Text");

                        }
                        public static GameObject ButtonBack => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery/ButtonBack");
                        public class ButtonBack_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery/ButtonBack/Text");

                        }
                        public static GameObject ButtonHelp => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery/ButtonHelp");
                        public class ButtonHelp_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/BoxLogin2FARecovery/ButtonHelp/Text");

                        }

                    }
                    public static GameObject ButtonAboutUs => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/ButtonAboutUs");
                    public class ButtonAboutUs_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/ButtonAboutUs/Text");
                        public static GameObject About_Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/ButtonAboutUs/About_Panel");
                        public class About_Panel_5
                        {
                            public static GameObject Text_2 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/ButtonAboutUs/About_Panel/Text (2)");
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/ButtonAboutUs/About_Panel/Text");

                        }

                    }
                    public static GameObject TextVRChat => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/Login2FARecovery/TextVRChat");

                }
                public static GameObject LoginPrompt => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt");
                public class LoginPrompt_3
                {
                    public static GameObject VRChatButtonLogin => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/VRChatButtonLogin");
                    public class VRChatButtonLogin_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/VRChatButtonLogin/Text");

                    }
                    public static GameObject ButtonCreate => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/ButtonCreate");
                    public class ButtonCreate_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/ButtonCreate/Text");

                    }
                    public static GameObject ButtonBypass => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/ButtonBypass");
                    public class ButtonBypass_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/ButtonBypass/Text");

                    }
                    public static GameObject TextWelcome => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/TextWelcome");
                    public static GameObject VRChat_LOGO => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/VRChat_LOGO");
                    public static GameObject TextVRChat => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/TextVRChat");
                    public static GameObject TextOr => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/TextOr");
                    public static GameObject TextLoginWith => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/TextLoginWith");
                    public static GameObject ButtonAboutUs_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/ButtonAboutUs (1)");
                    public class ButtonAboutUs_1_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/ButtonAboutUs (1)/Text");
                        public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/ButtonAboutUs (1)/Image");
                        public class Image_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/ButtonAboutUs (1)/Image/Text");
                            public static GameObject Text_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/ButtonAboutUs (1)/Image/Text (1)");

                        }

                    }
                    public static GameObject StoreButtonLogin_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/StoreButtonLogin (1)");
                    public class StoreButtonLogin_1_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/StoreButtonLogin (1)/Text");

                    }
                    public static GameObject LanguagePanel => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/LanguagePanel");
                    public class LanguagePanel_4
                    {
                        public static GameObject TitleText_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/LanguagePanel/TitleText (1)");
                        public static GameObject SelectPrevLang => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/LanguagePanel/SelectPrevLang");
                        public static GameObject SelectNextLang => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/LanguagePanel/SelectNextLang");
                        public static GameObject Language => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginPrompt/LanguagePanel/Language");

                    }

                }
                public static GameObject LoginUserPass => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass");
                public class LoginUserPass_3
                {
                    public static GameObject VRChat_LOGO_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/VRChat_LOGO (1)");
                    public static GameObject TextWelcome => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/TextWelcome");
                    public static GameObject BoxLogin => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/BoxLogin");
                    public class BoxLogin_4
                    {
                        public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/BoxLogin/Panel");
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/BoxLogin/Text");
                        public static GameObject InputFieldUser => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/BoxLogin/InputFieldUser");
                        public class InputFieldUser_5
                        {
                            public static GameObject Placeholder => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/BoxLogin/InputFieldUser/Placeholder");
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/BoxLogin/InputFieldUser/Text");
                            public static GameObject ValidateImage => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/BoxLogin/InputFieldUser/ValidateImage");

                        }
                        public static GameObject InputFieldPassword => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/BoxLogin/InputFieldPassword");
                        public class InputFieldPassword_5
                        {
                            public static GameObject Placeholder => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/BoxLogin/InputFieldPassword/Placeholder");
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/BoxLogin/InputFieldPassword/Text");
                            public static GameObject ValidateImage => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/BoxLogin/InputFieldPassword/ValidateImage");

                        }

                    }
                    public static GameObject ButtonDone_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/ButtonDone (1)");
                    public class ButtonDone_1_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/ButtonDone (1)/Text");

                    }
                    public static GameObject ButtonBack_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/ButtonBack (1)");
                    public class ButtonBack_1_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/ButtonBack (1)/Text");

                    }
                    public static GameObject ButtonAboutUs => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/ButtonAboutUs");
                    public class ButtonAboutUs_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/ButtonAboutUs/Text");
                        public static GameObject About_Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/ButtonAboutUs/About_Panel");
                        public class About_Panel_5
                        {
                            public static GameObject Text_2 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/ButtonAboutUs/About_Panel/Text (2)");
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/ButtonAboutUs/About_Panel/Text");

                        }

                    }
                    public static GameObject TextVRChat => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUserPass/TextVRChat");

                }
                public static GameObject LoginCreateFromWebsite => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite");
                public class LoginCreateFromWebsite_3
                {
                    public static GameObject Panel_Backdrop => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/Panel_Backdrop");
                    public static GameObject ButtonAboutUs => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/ButtonAboutUs");
                    public class ButtonAboutUs_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/ButtonAboutUs/Text");
                        public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/ButtonAboutUs/Image");
                        public class Image_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/ButtonAboutUs/Image/Text");

                        }

                    }
                    public static GameObject TextWelcome => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/TextWelcome");
                    public static GameObject TextVRChat => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/TextVRChat");
                    public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/Panel");
                    public class Panel_4
                    {
                        public static GameObject RegisterOnWebsiteText_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/Panel/RegisterOnWebsiteText (1)");

                    }
                    public static GameObject RegisterOnWebsiteText => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/RegisterOnWebsiteText");
                    public static GameObject RegisterationCompletedText => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/RegisterationCompletedText");
                    public static GameObject ButtonLogin => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/ButtonLogin");
                    public class ButtonLogin_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/ButtonLogin/Text");
                        public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginCreateFromWebsite/ButtonLogin/Image");

                    }

                }
                public static GameObject StoreLoginPrompt => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt");
                public class StoreLoginPrompt_3
                {
                    public static GameObject VRChat_LOGO_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/VRChat_LOGO (1)");
                    public static GameObject VRChatButtonLogin => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/VRChatButtonLogin");
                    public class VRChatButtonLogin_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/VRChatButtonLogin/Text");

                    }
                    public static GameObject ButtonCreate => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/ButtonCreate");
                    public class ButtonCreate_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/ButtonCreate/Text");

                    }
                    public static GameObject ButtonBypass => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/ButtonBypass");
                    public class ButtonBypass_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/ButtonBypass/Text");

                    }
                    public static GameObject TextWelcome => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/TextWelcome");
                    public static GameObject TextVRChat => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/TextVRChat");
                    public static GameObject TextOr => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/TextOr");
                    public static GameObject TextLoginWith => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/TextLoginWith");
                    public static GameObject ButtonAboutUs_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/ButtonAboutUs (1)");
                    public class ButtonAboutUs_1_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/ButtonAboutUs (1)/Text");
                        public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/ButtonAboutUs (1)/Image");
                        public class Image_5
                        {
                            public static GameObject Text_2 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/ButtonAboutUs (1)/Image/Text (2)");
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/ButtonAboutUs (1)/Image/Text");

                        }

                    }
                    public static GameObject StoreButtonLogin_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/StoreButtonLogin (1)");
                    public class StoreButtonLogin_1_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/StoreButtonLogin (1)/Text");

                    }
                    public static GameObject LanguagePanel => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/LanguagePanel");
                    public class LanguagePanel_4
                    {
                        public static GameObject TitleText_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/LanguagePanel/TitleText (1)");
                        public static GameObject SelectPrevLang => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/LanguagePanel/SelectPrevLang");
                        public static GameObject SelectNextLang => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/LanguagePanel/SelectNextLang");
                        public static GameObject Language => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/StoreLoginPrompt/LanguagePanel/Language");

                    }

                }
                public static GameObject LoginUpdate => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate");
                public class LoginUpdate_3
                {
                    public static GameObject VRChat_LOGO_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/VRChat_LOGO (1)");
                    public static GameObject Create => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/Create");
                    public class Create_4
                    {
                        public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/Create/Panel");
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/Create/Text");
                        public static GameObject InputFieldEmail => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/Create/InputFieldEmail");
                        public class InputFieldEmail_5
                        {
                            public static GameObject Placeholder => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/Create/InputFieldEmail/Placeholder");
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/Create/InputFieldEmail/Text");
                            public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/Create/InputFieldEmail/Image");
                            public static GameObject ValidateImage => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/Create/InputFieldEmail/ValidateImage");

                        }
                        public static GameObject InputFieldBirthday => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/Create/InputFieldBirthday");
                        public class InputFieldBirthday_5
                        {
                            public static GameObject Placeholder => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/Create/InputFieldBirthday/Placeholder");
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/Create/InputFieldBirthday/Text");
                            public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/Create/InputFieldBirthday/Image");
                            public static GameObject ValidateImage => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/Create/InputFieldBirthday/ValidateImage");

                        }

                    }
                    public static GameObject TextWelcome => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/TextWelcome");
                    public static GameObject TextVRChat => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/TextVRChat");
                    public static GameObject ButtonBack => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/ButtonBack");
                    public class ButtonBack_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/ButtonBack/Text");
                        public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/ButtonBack/Image");

                    }
                    public static GameObject ButtonAboutUs => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/ButtonAboutUs");
                    public class ButtonAboutUs_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/ButtonAboutUs/Text");
                        public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/ButtonAboutUs/Image");
                        public class Image_5
                        {
                            public static GameObject Text_ => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/ButtonAboutUs/Image/Text (3)");
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/ButtonAboutUs/Image/Text");

                        }

                    }
                    public static GameObject ButtonDone => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/ButtonDone");
                    public class ButtonDone_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/ButtonDone/Text");
                        public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdate/ButtonDone/Image");

                    }

                }
                public static GameObject LoginUpdateVS => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS");
                public class LoginUpdateVS_3
                {
                    public static GameObject Create => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/Create");
                    public class Create_4
                    {
                        public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/Create/Panel");
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/Create/Text");
                        public static GameObject InputFieldEmail => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/Create/InputFieldEmail");
                        public class InputFieldEmail_5
                        {
                            public static GameObject Placeholder => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/Create/InputFieldEmail/Placeholder");
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/Create/InputFieldEmail/Text");
                            public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/Create/InputFieldEmail/Image");
                            public static GameObject ValidateImage => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/Create/InputFieldEmail/ValidateImage");

                        }
                        public static GameObject InputFieldBirthday => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/Create/InputFieldBirthday");
                        public class InputFieldBirthday_5
                        {
                            public static GameObject Placeholder => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/Create/InputFieldBirthday/Placeholder");
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/Create/InputFieldBirthday/Text");
                            public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/Create/InputFieldBirthday/Image");
                            public static GameObject ValidateImage => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/Create/InputFieldBirthday/ValidateImage");

                        }

                    }
                    public static GameObject ButtonBack => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/ButtonBack");
                    public class ButtonBack_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/ButtonBack/Text");
                        public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/ButtonBack/Image");

                    }
                    public static GameObject ButtonAboutUs => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/ButtonAboutUs");
                    public class ButtonAboutUs_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/ButtonAboutUs/Text");
                        public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/ButtonAboutUs/Image");
                        public class Image_5
                        {
                            public static GameObject Text_ => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/ButtonAboutUs/Image/Text (3)");
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/ButtonAboutUs/Image/Text");

                        }

                    }
                    public static GameObject ButtonDone => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/ButtonDone");
                    public class ButtonDone_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/ButtonDone/Text");
                        public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/LoginUpdateVS/ButtonDone/Image");

                    }

                }
                public static GameObject AgreeTermsOfService => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService");
                public class AgreeTermsOfService_3
                {
                    public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel");
                    public class Panel_4
                    {
                        public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/Panel");
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/Text");
                        public static GameObject ButtonBack => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/ButtonBack");
                        public class ButtonBack_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/ButtonBack/Text");
                            public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/ButtonBack/Image");

                        }
                        public static GameObject ButtonDone => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/ButtonDone");
                        public class ButtonDone_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/ButtonDone/Text");
                            public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/ButtonDone/Image");

                        }
                        public static GameObject ToggleAgree => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/ToggleAgree");
                        public class ToggleAgree_5
                        {
                            public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/ToggleAgree/Background");
                            public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/ToggleAgree/Label");

                        }
                        public static GameObject Scroll_View => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/Scroll View");
                        public class Scroll_View_5
                        {
                            public static GameObject Viewport => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/Scroll View/Viewport");
                            public static GameObject Scrollbar_Horizontal => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/Scroll View/Scrollbar Horizontal");
                            public static GameObject Scrollbar_Vertical => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/Scroll View/Scrollbar Vertical");
                            public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/Scroll View/Image");

                        }
                        public static GameObject AgreeText => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/AgreeText");
                        public class AgreeText_5
                        {
                            public static GameObject Button => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/AgreeTermsOfService/Panel/AgreeText/Button");

                        }

                    }

                }
                public static GameObject ViveportStoreLoginPrompt => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt");
                public class ViveportStoreLoginPrompt_3
                {
                    public static GameObject VRChat_LOGO_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/VRChat_LOGO (1)");
                    public static GameObject VRChatButtonLogin => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/VRChatButtonLogin");
                    public class VRChatButtonLogin_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/VRChatButtonLogin/Text");

                    }
                    public static GameObject ButtonCreate => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/ButtonCreate");
                    public class ButtonCreate_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/ButtonCreate/Text");

                    }
                    public static GameObject ButtonBypass => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/ButtonBypass");
                    public class ButtonBypass_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/ButtonBypass/Text");

                    }
                    public static GameObject TextWelcome => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/TextWelcome");
                    public static GameObject TextVRChat => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/TextVRChat");
                    public static GameObject TextOr => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/TextOr");
                    public static GameObject TextLoginWith => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/TextLoginWith");
                    public static GameObject ButtonAboutUs_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/ButtonAboutUs (1)");
                    public class ButtonAboutUs_1_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/ButtonAboutUs (1)/Text");
                        public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/ButtonAboutUs (1)/Image");
                        public class Image_5
                        {
                            public static GameObject Text_ => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/ButtonAboutUs (1)/Image/Text (3)");
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/ButtonAboutUs (1)/Image/Text");

                        }

                    }
                    public static GameObject StoreButtonLogin_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/StoreButtonLogin (1)");
                    public class StoreButtonLogin_1_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/StoreButtonLogin (1)/Text");

                    }
                    public static GameObject LanguagePanel => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/LanguagePanel");
                    public class LanguagePanel_4
                    {
                        public static GameObject TitleText_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/LanguagePanel/TitleText (1)");
                        public static GameObject SelectPrevLang => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/LanguagePanel/SelectPrevLang");
                        public static GameObject SelectNextLang => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/LanguagePanel/SelectNextLang");
                        public static GameObject Language => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/ViveportStoreLoginPrompt/LanguagePanel/Language");

                    }

                }
                public static GameObject OculusStoreLoginPrompt => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt");
                public class OculusStoreLoginPrompt_3
                {
                    public static GameObject VRChat_LOGO_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/VRChat_LOGO (1)");
                    public static GameObject VRChatButtonLogin => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/VRChatButtonLogin");
                    public class VRChatButtonLogin_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/VRChatButtonLogin/Text");

                    }
                    public static GameObject ButtonCreate => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/ButtonCreate");
                    public class ButtonCreate_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/ButtonCreate/Text");

                    }
                    public static GameObject ButtonBypass => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/ButtonBypass");
                    public class ButtonBypass_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/ButtonBypass/Text");

                    }
                    public static GameObject TextWelcome => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/TextWelcome");
                    public static GameObject TextVRChat => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/TextVRChat");
                    public static GameObject TextOr_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/TextOr (1)");
                    public static GameObject TextLoginWith_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/TextLoginWith (1)");
                    public static GameObject ButtonAboutUs_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/ButtonAboutUs (1)");
                    public class ButtonAboutUs_1_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/ButtonAboutUs (1)/Text");
                        public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/ButtonAboutUs (1)/Image");
                        public class Image_5
                        {
                            public static GameObject Text_ => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/ButtonAboutUs (1)/Image/Text (3)");
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/ButtonAboutUs (1)/Image/Text");

                        }

                    }
                    public static GameObject StoreButtonLogin_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/StoreButtonLogin (1)");
                    public class StoreButtonLogin_1_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/StoreButtonLogin (1)/Text");

                    }
                    public static GameObject LanguagePanel => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/LanguagePanel");
                    public class LanguagePanel_4
                    {
                        public static GameObject TitleText_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/LanguagePanel/TitleText (1)");
                        public static GameObject SelectPrevLang => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/LanguagePanel/SelectPrevLang");
                        public static GameObject SelectNextLang => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/LanguagePanel/SelectNextLang");
                        public static GameObject Language => GameObject.Find("/UserInterface/MenuContent/Screens/Authentication/OculusStoreLoginPrompt/LanguagePanel/Language");

                    }

                }

            }
            public static GameObject Avatar => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar");
            public class Avatar_2
            {
                public static GameObject TitlePanel_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/TitlePanel (1)");
                public class TitlePanel_1_3
                {
                    public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/TitlePanel (1)/TitleText");

                }
                public static GameObject Vertical_Scroll_View => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View");
                public class Vertical_Scroll_View_3
                {
                    public static GameObject Viewport => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport");
                    public class Viewport_4
                    {
                        public static GameObject FavoriteListTemplate => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/FavoriteListTemplate");
                        public class FavoriteListTemplate_5
                        {
                            public static GameObject ViewPort => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/FavoriteListTemplate/ViewPort");
                            public static GameObject Button => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/FavoriteListTemplate/Button");
                            public static GameObject GetMoreFavorites => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/FavoriteListTemplate/GetMoreFavorites");
                            public static GameObject Expired => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/FavoriteListTemplate/Expired");

                        }
                        public static GameObject Content => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content");
                        public class Content_5
                        {
                            public static GameObject Personal_Fallback_Avatar_List => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Personal Fallback Avatar List");
                            public static GameObject Fallback_Avatar_List => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Fallback Avatar List");
                            public static GameObject Personal_Avatar_List => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Personal Avatar List");
                            public static GameObject FavoriteContent => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/FavoriteContent");
                            public static GameObject Licensed_Avatar_List_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Licensed Avatar List (1)");
                            public static GameObject Public_Avatar_List => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Public Avatar List");
                            public static GameObject Public_Avatar_List_Quest => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Public Avatar List Quest");
                            public static GameObject Developer_Avatar_List => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Developer Avatar List");
                            public static GameObject Legacy_Avatar_List => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Legacy Avatar List");
                            public static GameObject Avatar_Worlds_Whats_Hot => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Avatar Worlds (What's Hot)");
                            public static GameObject Avatar_Worlds_Random => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Vertical Scroll View/Viewport/Content/Avatar Worlds (Random)");

                        }

                    }

                }
                public static GameObject Ticker => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Ticker");
                public class Ticker_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Ticker/Text");
                    public static GameObject TopLine => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Ticker/TopLine");
                    public static GameObject TopLine_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Ticker/TopLine (1)");

                }
                public static GameObject AvatarPreviewBase => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarPreviewBase");
                public class AvatarPreviewBase_3
                {
                    public static GameObject MainRoot => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarPreviewBase/MainRoot");
                    public class MainRoot_4
                    {
                        public static GameObject MainModel => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarPreviewBase/MainRoot/MainModel");

                    }
                    public static GameObject FallbackRoot => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarPreviewBase/FallbackRoot");
                    public class FallbackRoot_4
                    {
                        public static GameObject FallbackModel => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarPreviewBase/FallbackRoot/FallbackModel");

                    }
                    public static GameObject EditPlayerDirLight => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarPreviewBase/EditPlayerDirLight");
                    public static GameObject FallbackThumbnail => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarPreviewBase/FallbackThumbnail");
                    public class FallbackThumbnail_4
                    {
                        public static GameObject AvatarImage => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarPreviewBase/FallbackThumbnail/AvatarImage");
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarPreviewBase/FallbackThumbnail/Text");

                    }

                }
                public static GameObject Select_Button => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Select Button");
                public class Select_Button_3
                {
                    public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Select Button/Label");
                    public static GameObject PlatformIcon => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Select Button/PlatformIcon");

                }
                public static GameObject Fallback_Hide_Button => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Fallback Hide Button");
                public class Fallback_Hide_Button_3
                {
                    public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Fallback Hide Button/Label");

                }
                public static GameObject Change_Button => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Change Button");
                public class Change_Button_3
                {
                    public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Change Button/Label");
                    public static GameObject PlatformAnyIcon => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Change Button/PlatformAnyIcon");

                }
                public static GameObject Fallback_Info => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Fallback Info");
                public class Fallback_Info_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Fallback Info/Text");

                }
                public static GameObject Move_Button => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Move Button");
                public class Move_Button_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Move Button/Text");

                }
                public static GameObject Favorite_Button => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Favorite Button");
                public class Favorite_Button_3
                {
                    public static GameObject Horizontal => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Favorite Button/Horizontal");
                    public class Horizontal_4
                    {
                        public static GameObject FavoriteActionText => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Favorite Button/Horizontal/FavoriteActionText");
                        public static GameObject FavoritesCountSpacingText => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Favorite Button/Horizontal/FavoritesCountSpacingText");
                        public static GameObject FavoritesCurrentCountText => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Favorite Button/Horizontal/FavoritesCurrentCountText");
                        public static GameObject FavoritesCountDividerText => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Favorite Button/Horizontal/FavoritesCountDividerText");
                        public static GameObject FavoritesMaxAvailableText => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Favorite Button/Horizontal/FavoritesMaxAvailableText");

                    }
                    public static GameObject Icon_VRCPlus => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Favorite Button/Icon_VRC+");

                }
                public static GameObject Delete_Button => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Delete Button");
                public class Delete_Button_3
                {
                    public static GameObject DeleteText => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/Delete Button/DeleteText");

                }
                public static GameObject AvatarUiPrefab2 => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarUiPrefab2");
                public class AvatarUiPrefab2_3
                {
                    public static GameObject RoomGlow => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarUiPrefab2/RoomGlow");
                    public static GameObject RoomOutline => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarUiPrefab2/RoomOutline");
                    public static GameObject RoomImageShape => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarUiPrefab2/RoomImageShape");
                    public class RoomImageShape_4
                    {
                        public static GameObject RoomImage => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarUiPrefab2/RoomImageShape/RoomImage");
                        public class RoomImage_5
                        {
                            public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarUiPrefab2/RoomImageShape/RoomImage/Panel");

                        }

                    }
                    public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarUiPrefab2/TitleText");

                }
                public static GameObject DepthOverlay => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/DepthOverlay");
                public static GameObject AvatarDetails_Button => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarDetails Button");
                public class AvatarDetails_Button_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarDetails Button/Text");
                    public static GameObject PerfIcon => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarDetails Button/PerfIcon");
                    public static GameObject PlatformIcon => GameObject.Find("/UserInterface/MenuContent/Screens/Avatar/AvatarDetails Button/PlatformIcon");

                }

            }
            public static GameObject FirstLogin => GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin");
            public class FirstLogin_2
            {
                public static GameObject TutorialLaunch => GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch");
                public class TutorialLaunch_3
                {
                    public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/Panel");
                    public class Panel_4
                    {
                        public static GameObject Rectangle => GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/Panel/Rectangle");
                        public static GameObject MidRing => GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/Panel/MidRing");
                        public static GameObject InnerDashRing => GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/Panel/InnerDashRing");
                        public static GameObject RingGlow => GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/Panel/RingGlow");
                        public static GameObject ArrowLeft => GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/Panel/ArrowLeft");
                        public static GameObject ArrowRight => GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/Panel/ArrowRight");
                        public static GameObject CornerBL => GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/Panel/CornerBL");
                        public static GameObject CornerTL => GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/Panel/CornerTL");
                        public static GameObject CornerBR => GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/Panel/CornerBR");
                        public static GameObject CornerTR => GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/Panel/CornerTR");

                    }
                    public static GameObject ButtonDone => GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/ButtonDone");
                    public class ButtonDone_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/ButtonDone/Text");

                    }
                    public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/TitleText");
                    public static GameObject BodyTextMouse => GameObject.Find("/UserInterface/MenuContent/Screens/FirstLogin/TutorialLaunch/BodyTextMouse");

                }

            }
            public static GameObject Playlists => GameObject.Find("/UserInterface/MenuContent/Screens/Playlists");
            public class Playlists_2
            {
                public static GameObject Vertical_Scroll_View => GameObject.Find("/UserInterface/MenuContent/Screens/Playlists/Vertical Scroll View");
                public class Vertical_Scroll_View_3
                {
                    public static GameObject Viewport => GameObject.Find("/UserInterface/MenuContent/Screens/Playlists/Vertical Scroll View/Viewport");
                    public class Viewport_4
                    {
                        public static GameObject Content => GameObject.Find("/UserInterface/MenuContent/Screens/Playlists/Vertical Scroll View/Viewport/Content");
                        public class Content_5
                        {
                            public static GameObject FavoriteListTemplate => GameObject.Find("/UserInterface/MenuContent/Screens/Playlists/Vertical Scroll View/Viewport/Content/FavoriteListTemplate");

                        }

                    }

                }
                public static GameObject Header => GameObject.Find("/UserInterface/MenuContent/Screens/Playlists/Header");
                public class Header_3
                {
                    public static GameObject TitlePanel => GameObject.Find("/UserInterface/MenuContent/Screens/Playlists/Header/TitlePanel");
                    public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Screens/Playlists/Header/TitleText");
                    public static GameObject BackButton => GameObject.Find("/UserInterface/MenuContent/Screens/Playlists/Header/BackButton");
                    public class BackButton_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Playlists/Header/BackButton/Text");

                    }
                    public static GameObject TopLine => GameObject.Find("/UserInterface/MenuContent/Screens/Playlists/Header/TopLine");
                    public static GameObject BottomLine => GameObject.Find("/UserInterface/MenuContent/Screens/Playlists/Header/BottomLine");

                }
                public static GameObject DepthOverlay => GameObject.Find("/UserInterface/MenuContent/Screens/Playlists/DepthOverlay");

            }
            public static GameObject Settings_Safety => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety");
            public class Settings_Safety_2
            {
                public static GameObject TitlePanel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/TitlePanel");
                public class TitlePanel_3
                {
                    public static GameObject Button_PerformanceOptions => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/TitlePanel/Button_PerformanceOptions");
                    public class Button_PerformanceOptions_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/TitlePanel/Button_PerformanceOptions/Text");

                    }
                    public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/TitlePanel/TitleText");

                }
                public static GameObject _Buttons_SafetyLevel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel");
                public class _Buttons_SafetyLevel_3
                {
                    public static GameObject Button_Maxiumum => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Maxiumum");
                    public class Button_Maxiumum_4
                    {
                        public static GameObject OFF => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Maxiumum/OFF");
                        public static GameObject ON => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Maxiumum/ON");

                    }
                    public static GameObject Button_Normal => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Normal");
                    public class Button_Normal_4
                    {
                        public static GameObject OFF => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Normal/OFF");
                        public static GameObject ON => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Normal/ON");

                    }
                    public static GameObject Button_None => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_None");
                    public class Button_None_4
                    {
                        public static GameObject OFF => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_None/OFF");
                        public static GameObject ON => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_None/ON");

                    }
                    public static GameObject Button_Custom => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Custom");
                    public class Button_Custom_4
                    {
                        public static GameObject OFF => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Custom/OFF");
                        public static GameObject ON => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_Custom/ON");

                    }
                    public static GameObject Button_SafeMode => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_SafeMode");
                    public class Button_SafeMode_4
                    {
                        public static GameObject OFF => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_SafeMode/OFF");
                        public static GameObject ON => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_SafetyLevel/Button_SafeMode/ON");

                    }

                }
                public static GameObject _Description_SafetyLevel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Description_SafetyLevel");
                public class _Description_SafetyLevel_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Description_SafetyLevel/Text");

                }
                public static GameObject _SafetyMatrix => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix");
                public class _SafetyMatrix_3
                {
                    public static GameObject SocialRankBG => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/SocialRankBG");
                    public static GameObject _Bracket => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Bracket");
                    public class _Bracket_4
                    {
                        public static GameObject SocialRankBorder => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Bracket/SocialRankBorder");

                    }
                    public static GameObject _Toggles => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles");
                    public class _Toggles_4
                    {
                        public static GameObject Toggle_voice => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_voice");
                        public class Toggle_voice_5
                        {
                            public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_voice/Panel");
                            public static GameObject Text_Header => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_voice/Text_Header");
                            public static GameObject Text_onOff => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_voice/Text_onOff");
                            public static GameObject RawImage => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_voice/RawImage");
                            public static GameObject Toggle_Image => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_voice/Toggle_Image");

                        }
                        public static GameObject Toggle_Avatar => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Avatar");
                        public class Toggle_Avatar_5
                        {
                            public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Avatar/Panel");
                            public static GameObject Text_Header => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Avatar/Text_Header");
                            public static GameObject Text_onOff => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Avatar/Text_onOff");
                            public static GameObject RawImage => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Avatar/RawImage");
                            public static GameObject Toggle_Image => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Avatar/Toggle_Image");

                        }
                        public static GameObject Toggle_UserIcons => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_UserIcons");
                        public class Toggle_UserIcons_5
                        {
                            public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_UserIcons/Panel");
                            public static GameObject Text_Header => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_UserIcons/Text_Header");
                            public static GameObject Text_onOff => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_UserIcons/Text_onOff");
                            public static GameObject RawImage => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_UserIcons/RawImage");
                            public static GameObject Toggle_Image => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_UserIcons/Toggle_Image");

                        }
                        public static GameObject Toggle_Audio => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Audio");
                        public class Toggle_Audio_5
                        {
                            public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Audio/Panel");
                            public static GameObject Text_Header => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Audio/Text_Header");
                            public static GameObject Text_onOff => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Audio/Text_onOff");
                            public static GameObject RawImage => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Audio/RawImage");
                            public static GameObject Toggle_Image => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Audio/Toggle_Image");

                        }
                        public static GameObject Toggle_Particles => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Particles");
                        public class Toggle_Particles_5
                        {
                            public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Particles/Panel");
                            public static GameObject Text_Header => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Particles/Text_Header");
                            public static GameObject Text_onOff => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Particles/Text_onOff");
                            public static GameObject RawImage => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Particles/RawImage");
                            public static GameObject Toggle_Image => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Particles/Toggle_Image");

                        }
                        public static GameObject Toggle_Shaders => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Shaders");
                        public class Toggle_Shaders_5
                        {
                            public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Shaders/Panel");
                            public static GameObject Text_Header => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Shaders/Text_Header");
                            public static GameObject Text_onOff => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Shaders/Text_onOff");
                            public static GameObject RawImage => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Shaders/RawImage");
                            public static GameObject Toggle_Image => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_Shaders/Toggle_Image");

                        }
                        public static GameObject Toggle_CustomAnimations => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_CustomAnimations");
                        public class Toggle_CustomAnimations_5
                        {
                            public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_CustomAnimations/Panel");
                            public static GameObject Text_Header => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_CustomAnimations/Text_Header");
                            public static GameObject Text_onOff => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_CustomAnimations/Text_onOff");
                            public static GameObject RawImage => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_CustomAnimations/RawImage");
                            public static GameObject Toggle_Image => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_SafetyMatrix/_Toggles/Toggle_CustomAnimations/Toggle_Image");

                        }

                    }

                }
                public static GameObject Button_Reset => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/Button_Reset");
                public class Button_Reset_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/Button_Reset/Text");

                }
                public static GameObject _Buttons_UserLevel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel");
                public class _Buttons_UserLevel_3
                {
                    public static GameObject Button_Visitor => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Visitor");
                    public class Button_Visitor_4
                    {
                        public static GameObject Connector => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Visitor/Connector");
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Visitor/Text");

                    }
                    public static GameObject Button_New => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_New");
                    public class Button_New_4
                    {
                        public static GameObject Connector => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_New/Connector");
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_New/Text");

                    }
                    public static GameObject Button_User => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_User");
                    public class Button_User_4
                    {
                        public static GameObject Connector => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_User/Connector");
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_User/Text");

                    }
                    public static GameObject Button_Trusted => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Trusted");
                    public class Button_Trusted_4
                    {
                        public static GameObject Connector => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Trusted/Connector");
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Trusted/Text");

                    }
                    public static GameObject Button_Advanced => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Advanced");
                    public class Button_Advanced_4
                    {
                        public static GameObject Connector => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Advanced/Connector");
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Advanced/Text");

                    }
                    public static GameObject Button_Friends => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Friends");
                    public class Button_Friends_4
                    {
                        public static GameObject Connector => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Friends/Connector");
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Buttons_UserLevel/Button_Friends/Text");

                    }

                }
                public static GameObject _UserLevel_Tooltip => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_UserLevel_Tooltip");
                public class _UserLevel_Tooltip_3
                {
                    public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_UserLevel_Tooltip/Panel");
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_UserLevel_Tooltip/Text");

                }
                public static GameObject _Notification_CloseMenu => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Notification_CloseMenu");
                public class _Notification_CloseMenu_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Settings_Safety/_Notification_CloseMenu/Text");

                }

            }
            public static GameObject Settings => GameObject.Find("/UserInterface/MenuContent/Screens/Settings");
            public class Settings_2
            {
                public static GameObject TitlePanel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/TitlePanel");
                public class TitlePanel_3
                {
                    public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/TitlePanel/TitleText");
                    public static GameObject VersionText => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/TitlePanel/VersionText");

                }
                public static GameObject ComfortSafetyPanel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel");
                public class ComfortSafetyPanel_3
                {
                    public static GameObject Panel_Header => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/Panel_Header");
                    public static GameObject TitleText_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/TitleText (1)");
                    public static GameObject HoloportToggle => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/HoloportToggle");
                    public class HoloportToggle_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/HoloportToggle/Background");
                        public class Background_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/HoloportToggle/Background/Checkmark");

                        }
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/HoloportToggle/Label");

                    }
                    public static GameObject ComfortTurnToggle => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/ComfortTurnToggle");
                    public class ComfortTurnToggle_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/ComfortTurnToggle/Background");
                        public class Background_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/ComfortTurnToggle/Background/Checkmark");

                        }
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/ComfortTurnToggle/Label");

                    }
                    public static GameObject PersonalSpaceToggle => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/PersonalSpaceToggle");
                    public class PersonalSpaceToggle_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/PersonalSpaceToggle/Background");
                        public class Background_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/PersonalSpaceToggle/Background/Checkmark");

                        }
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/PersonalSpaceToggle/Label");

                    }
                    public static GameObject AllowUntrustedURL => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/AllowUntrustedURL");
                    public class AllowUntrustedURL_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/AllowUntrustedURL/Background");
                        public class Background_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/AllowUntrustedURL/Background/Checkmark");

                        }
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/AllowUntrustedURL/Label");

                    }
                    public static GameObject StreamerModeToggle => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/StreamerModeToggle");
                    public class StreamerModeToggle_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/StreamerModeToggle/Background");
                        public class Background_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/StreamerModeToggle/Background/Checkmark");

                        }
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/StreamerModeToggle/Label");
                        public static GameObject InfoButton => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/StreamerModeToggle/InfoButton");

                    }
                    public static GameObject MuteUsersToggle => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/MuteUsersToggle");
                    public class MuteUsersToggle_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/MuteUsersToggle/Background");
                        public class Background_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/MuteUsersToggle/Background/Checkmark");

                        }
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/MuteUsersToggle/Label");

                    }
                    public static GameObject BlockAvatarsToggle => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/BlockAvatarsToggle");
                    public class BlockAvatarsToggle_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/BlockAvatarsToggle/Background");
                        public class Background_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/BlockAvatarsToggle/Background/Checkmark");

                        }
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/BlockAvatarsToggle/Label");

                    }
                    public static GameObject HeadSetGazeToggle => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/HeadSetGazeToggle");
                    public class HeadSetGazeToggle_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/HeadSetGazeToggle/Background");
                        public class Background_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/HeadSetGazeToggle/Background/Checkmark");

                        }
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/HeadSetGazeToggle/Label");

                    }
                    public static GameObject KeyboardToggle => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/KeyboardToggle");
                    public class KeyboardToggle_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/KeyboardToggle/Background");
                        public class Background_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/KeyboardToggle/Background/Checkmark");

                        }
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/KeyboardToggle/Label");

                    }
                    public static GameObject GamepadToggle => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/GamepadToggle");
                    public class GamepadToggle_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/GamepadToggle/Background");
                        public class Background_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/GamepadToggle/Background/Checkmark");

                        }
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/GamepadToggle/Label");

                    }
                    public static GameObject PrimaryInputPanel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/PrimaryInputPanel");
                    public class PrimaryInputPanel_4
                    {
                        public static GameObject TitleText_2 => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/PrimaryInputPanel/TitleText (2)");
                        public static GameObject HardwareConfigToggle_ => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/PrimaryInputPanel/HardwareConfigToggle (3)");
                        public class HardwareConfigToggle__5
                        {
                            public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/PrimaryInputPanel/HardwareConfigToggle (3)/Background");
                            public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/PrimaryInputPanel/HardwareConfigToggle (3)/Label");

                        }
                        public static GameObject HardwareConfigToggle_4 => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/PrimaryInputPanel/HardwareConfigToggle (4)");
                        public class HardwareConfigToggle_4_5
                        {
                            public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/PrimaryInputPanel/HardwareConfigToggle (4)/Background");
                            public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/PrimaryInputPanel/HardwareConfigToggle (4)/Label");

                        }
                        public static GameObject HardwareConfigToggle_5 => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/PrimaryInputPanel/HardwareConfigToggle (5)");
                        public class HardwareConfigToggle_5_5
                        {
                            public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/PrimaryInputPanel/HardwareConfigToggle (5)/Background");
                            public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/PrimaryInputPanel/HardwareConfigToggle (5)/Label");

                        }

                    }
                    public static GameObject LocomotionInputPanel_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/LocomotionInputPanel (1)");
                    public class LocomotionInputPanel_1_4
                    {
                        public static GameObject TitleText_2 => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/ComfortSafetyPanel/LocomotionInputPanel (1)/TitleText (2)");

                    }

                }
                public static GameObject AudioDevicePanel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel");
                public class AudioDevicePanel_3
                {
                    public static GameObject Panel_Header => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/Panel_Header");
                    public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/TitleText");
                    public static GameObject LevelText => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/LevelText");
                    public static GameObject VolumeSlider => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/VolumeSlider");
                    public class VolumeSlider_4
                    {
                        public static GameObject Fill_Area => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/VolumeSlider/Fill Area");
                        public class Fill_Area_5
                        {
                            public static GameObject Fill => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/VolumeSlider/Fill Area/Fill");
                            public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/VolumeSlider/Fill Area/Label");

                        }

                    }
                    public static GameObject VolumeDisplay => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/VolumeDisplay");
                    public class VolumeDisplay_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/VolumeDisplay/Background");
                        public static GameObject Fill_Area => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/VolumeDisplay/Fill Area");
                        public class Fill_Area_5
                        {
                            public static GameObject Fill => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/VolumeDisplay/Fill Area/Fill");

                        }

                    }
                    public static GameObject SelectPrevMic => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/SelectPrevMic");
                    public static GameObject SelectNextMic => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/SelectNextMic");
                    public static GameObject MicDeviceText => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/AudioDevicePanel/MicDeviceText");

                }
                public static GameObject MousePanel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel");
                public class MousePanel_3
                {
                    public static GameObject Panel_Header => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/Panel_Header");
                    public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/TitleText");
                    public static GameObject MouseSensitivityText => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/MouseSensitivityText");
                    public static GameObject SensitivitySlider => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/SensitivitySlider");
                    public class SensitivitySlider_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/SensitivitySlider/Background");
                        public static GameObject Fill_Area => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/SensitivitySlider/Fill Area");
                        public class Fill_Area_5
                        {
                            public static GameObject Fill => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/SensitivitySlider/Fill Area/Fill");

                        }
                        public static GameObject Handle_Slide_Area => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/SensitivitySlider/Handle Slide Area");
                        public class Handle_Slide_Area_5
                        {
                            public static GameObject Handle => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/SensitivitySlider/Handle Slide Area/Handle");

                        }

                    }
                    public static GameObject InvertedMouse => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/InvertedMouse");
                    public class InvertedMouse_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/InvertedMouse/Background");
                        public class Background_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/InvertedMouse/Background/Checkmark");

                        }
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/MousePanel/InvertedMouse/Label");

                    }

                }
                public static GameObject HeightPanel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/HeightPanel");
                public class HeightPanel_3
                {
                    public static GameObject Panel_Header => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/HeightPanel/Panel_Header");
                    public static GameObject TitleText_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/HeightPanel/TitleText (1)");
                    public static GameObject HeightUP => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/HeightPanel/HeightUP");
                    public static GameObject HeightDOWN => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/HeightPanel/HeightDOWN");
                    public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/HeightPanel/Label");

                }
                public static GameObject VoiceOptionsPanel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel");
                public class VoiceOptionsPanel_3
                {
                    public static GameObject Panel_Header => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/Panel_Header");
                    public static GameObject TitleText_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/TitleText (1)");
                    public static GameObject HardwareConfigToggle_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (1)");
                    public class HardwareConfigToggle_1_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (1)/Background");
                        public class Background_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (1)/Background/Checkmark");

                        }
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (1)/Label");

                    }
                    public static GameObject HardwareConfigToggle_4 => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (4)");
                    public class HardwareConfigToggle_4_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (4)/Background");
                        public class Background_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (4)/Background/Checkmark");

                        }
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (4)/Label");

                    }
                    public static GameObject HardwareConfigToggle_6 => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (6)");
                    public class HardwareConfigToggle_6_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (6)/Background");
                        public class Background_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (6)/Background/Checkmark");

                        }
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (6)/Label");

                    }
                    public static GameObject HardwareConfigToggle_2 => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (2)");
                    public class HardwareConfigToggle_2_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (2)/Background");
                        public class Background_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (2)/Background/Checkmark");

                        }
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VoiceOptionsPanel/HardwareConfigToggle (2)/Label");

                    }

                }
                public static GameObject OtherOptionsPanel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel");
                public class OtherOptionsPanel_3
                {
                    public static GameObject Panel_Header_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/Panel_Header (1)");
                    public static GameObject TitleText_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/TitleText (1)");
                    public static GameObject HeadLookToggle => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/HeadLookToggle");
                    public class HeadLookToggle_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/HeadLookToggle/Background");
                        public class Background_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/HeadLookToggle/Background/Checkmark");

                        }
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/HeadLookToggle/Label");

                    }
                    public static GameObject TooltipsToggle => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/TooltipsToggle");
                    public class TooltipsToggle_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/TooltipsToggle/Background");
                        public class Background_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/TooltipsToggle/Background/Checkmark");

                        }
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/TooltipsToggle/Label");

                    }
                    public static GameObject PRotationToggle => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/3PRotationToggle");
                    public class PRotationToggle_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/3PRotationToggle/Background");
                        public class Background_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/3PRotationToggle/Background/Checkmark");

                        }
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/3PRotationToggle/Label");

                    }
                    public static GameObject ViveAdvancedToggle => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/ViveAdvancedToggle");
                    public class ViveAdvancedToggle_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/ViveAdvancedToggle/Background");
                        public class Background_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/ViveAdvancedToggle/Background/Checkmark");

                        }
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/ViveAdvancedToggle/Label");

                    }
                    public static GameObject SkipGoButtonInLoad => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/SkipGoButtonInLoad");
                    public class SkipGoButtonInLoad_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/SkipGoButtonInLoad/Background");
                        public class Background_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/SkipGoButtonInLoad/Background/Checkmark");

                        }
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/SkipGoButtonInLoad/Label");

                    }
                    public static GameObject DesktopReticle => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/DesktopReticle");
                    public class DesktopReticle_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/DesktopReticle/Background");
                        public class Background_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/DesktopReticle/Background/Checkmark");

                        }
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/DesktopReticle/Label");

                    }
                    public static GameObject AllowAvatarCopyingToggle => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/AllowAvatarCopyingToggle");
                    public class AllowAvatarCopyingToggle_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/AllowAvatarCopyingToggle/Background");
                        public class Background_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/AllowAvatarCopyingToggle/Background/Checkmark");

                        }
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/AllowAvatarCopyingToggle/Label");

                    }
                    public static GameObject ShowCommunityLabsToggle => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/ShowCommunityLabsToggle");
                    public class ShowCommunityLabsToggle_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/ShowCommunityLabsToggle/Background");
                        public class Background_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/ShowCommunityLabsToggle/Background/Checkmark");

                        }
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/OtherOptionsPanel/ShowCommunityLabsToggle/Label");

                    }

                }
                public static GameObject VolumePanel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel");
                public class VolumePanel_3
                {
                    public static GameObject Panel_Header_Top => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/Panel_Header Top");
                    public static GameObject Panel_Header_Side => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/Panel_Header Side");
                    public static GameObject TitleText_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/TitleText (1)");
                    public static GameObject VolumeMaster => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeMaster");
                    public class VolumeMaster_4
                    {
                        public static GameObject FillArea => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeMaster/FillArea");
                        public class FillArea_5
                        {
                            public static GameObject Fill => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeMaster/FillArea/Fill");

                        }
                        public static GameObject SliderLabel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeMaster/SliderLabel");
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeMaster/Label");

                    }
                    public static GameObject VolumeUi => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeUi");
                    public class VolumeUi_4
                    {
                        public static GameObject FillArea => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeUi/FillArea");
                        public class FillArea_5
                        {
                            public static GameObject Fill => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeUi/FillArea/Fill");

                        }
                        public static GameObject SliderLabel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeUi/SliderLabel");
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeUi/Label");

                    }
                    public static GameObject VolumeGameWorld => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameWorld");
                    public class VolumeGameWorld_4
                    {
                        public static GameObject FillArea => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameWorld/FillArea");
                        public class FillArea_5
                        {
                            public static GameObject Fill => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameWorld/FillArea/Fill");

                        }
                        public static GameObject SliderLabel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameWorld/SliderLabel");
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameWorld/Label");

                    }
                    public static GameObject VolumeGameVoice => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameVoice");
                    public class VolumeGameVoice_4
                    {
                        public static GameObject FillArea => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameVoice/FillArea");
                        public class FillArea_5
                        {
                            public static GameObject Fill => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameVoice/FillArea/Fill");

                        }
                        public static GameObject SliderLabel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameVoice/SliderLabel");
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameVoice/Label");

                    }
                    public static GameObject VolumeGameAvatars => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameAvatars");
                    public class VolumeGameAvatars_4
                    {
                        public static GameObject FillArea => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameAvatars/FillArea");
                        public class FillArea_5
                        {
                            public static GameObject Fill => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameAvatars/FillArea/Fill");

                        }
                        public static GameObject SliderLabel => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameAvatars/SliderLabel");
                        public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/VolumePanel/VolumeGameAvatars/Label");

                    }

                }
                public static GameObject Footer => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Footer");
                public class Footer_3
                {
                    public static GameObject Logout => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Footer/Logout");
                    public class Logout_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Footer/Logout/Text");

                    }
                    public static GameObject Exit => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Footer/Exit");
                    public class Exit_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Footer/Exit/Text");

                    }
                    public static GameObject NameText => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Footer/NameText");
                    public static GameObject UpgradeAccount => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Footer/UpgradeAccount");
                    public class UpgradeAccount_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Footer/UpgradeAccount/Text");

                    }

                }
                public static GameObject DepthOverlay => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/DepthOverlay");
                public static GameObject Button_AdvancedOptions => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Button_AdvancedOptions");
                public class Button_AdvancedOptions_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Button_AdvancedOptions/Text");

                }
                public static GameObject Button_EditBindings => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Button_EditBindings");
                public class Button_EditBindings_3
                {
                    public static GameObject Image_NEW => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Button_EditBindings/Image_NEW");
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/Button_EditBindings/Text");

                }
                public static GameObject UserVolumeOptions => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/UserVolumeOptions");
                public class UserVolumeOptions_3
                {
                    public static GameObject Panel_Header_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/UserVolumeOptions/Panel_Header (1)");
                    public static GameObject TitleText_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/UserVolumeOptions/TitleText (1)");
                    public static GameObject Button_ClearChanges => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/UserVolumeOptions/Button_ClearChanges");
                    public class Button_ClearChanges_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Settings/UserVolumeOptions/Button_ClearChanges/Text");

                    }

                }

            }
            public static GameObject Social => GameObject.Find("/UserInterface/MenuContent/Screens/Social");
            public class Social_2
            {
                public static GameObject Ticker => GameObject.Find("/UserInterface/MenuContent/Screens/Social/Ticker");
                public class Ticker_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Social/Ticker/Text");
                    public static GameObject TopLine => GameObject.Find("/UserInterface/MenuContent/Screens/Social/Ticker/TopLine");
                    public static GameObject TopLine_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Social/Ticker/TopLine (1)");

                }
                public static GameObject Vertical_Scroll_View => GameObject.Find("/UserInterface/MenuContent/Screens/Social/Vertical Scroll View");
                public class Vertical_Scroll_View_3
                {
                    public static GameObject Viewport => GameObject.Find("/UserInterface/MenuContent/Screens/Social/Vertical Scroll View/Viewport");
                    public class Viewport_4
                    {
                        public static GameObject Content => GameObject.Find("/UserInterface/MenuContent/Screens/Social/Vertical Scroll View/Viewport/Content");
                        public class Content_5
                        {
                            public static GameObject FavoriteListTemplate => GameObject.Find("/UserInterface/MenuContent/Screens/Social/Vertical Scroll View/Viewport/Content/FavoriteListTemplate");
                            public static GameObject Search => GameObject.Find("/UserInterface/MenuContent/Screens/Social/Vertical Scroll View/Viewport/Content/Search");
                            public static GameObject InRoom => GameObject.Find("/UserInterface/MenuContent/Screens/Social/Vertical Scroll View/Viewport/Content/InRoom");
                            public static GameObject FriendRequests => GameObject.Find("/UserInterface/MenuContent/Screens/Social/Vertical Scroll View/Viewport/Content/FriendRequests");
                            public static GameObject OnlineFriends => GameObject.Find("/UserInterface/MenuContent/Screens/Social/Vertical Scroll View/Viewport/Content/OnlineFriends");
                            public static GameObject FavoriteContent => GameObject.Find("/UserInterface/MenuContent/Screens/Social/Vertical Scroll View/Viewport/Content/FavoriteContent");
                            public static GameObject OfflineFriends => GameObject.Find("/UserInterface/MenuContent/Screens/Social/Vertical Scroll View/Viewport/Content/OfflineFriends");
                            public static GameObject Active => GameObject.Find("/UserInterface/MenuContent/Screens/Social/Vertical Scroll View/Viewport/Content/Active");

                        }

                    }

                }
                public static GameObject DepthOverlay => GameObject.Find("/UserInterface/MenuContent/Screens/Social/DepthOverlay");
                public static GameObject UserProfileAndStatusSection => GameObject.Find("/UserInterface/MenuContent/Screens/Social/UserProfileAndStatusSection");
                public class UserProfileAndStatusSection_3
                {
                    public static GameObject TitlePanel => GameObject.Find("/UserInterface/MenuContent/Screens/Social/UserProfileAndStatusSection/TitlePanel");
                    public static GameObject TopLine => GameObject.Find("/UserInterface/MenuContent/Screens/Social/UserProfileAndStatusSection/TopLine");
                    public static GameObject ViewProfileButton => GameObject.Find("/UserInterface/MenuContent/Screens/Social/UserProfileAndStatusSection/ViewProfileButton");
                    public class ViewProfileButton_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Social/UserProfileAndStatusSection/ViewProfileButton/Text");
                        public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Social/UserProfileAndStatusSection/ViewProfileButton/Image");

                    }
                    public static GameObject Status => GameObject.Find("/UserInterface/MenuContent/Screens/Social/UserProfileAndStatusSection/Status");
                    public class Status_4
                    {
                        public static GameObject EditStatusButton => GameObject.Find("/UserInterface/MenuContent/Screens/Social/UserProfileAndStatusSection/Status/EditStatusButton");
                        public class EditStatusButton_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Social/UserProfileAndStatusSection/Status/EditStatusButton/Text");
                            public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Social/UserProfileAndStatusSection/Status/EditStatusButton/Image");

                        }
                        public static GameObject CurrentStatus => GameObject.Find("/UserInterface/MenuContent/Screens/Social/UserProfileAndStatusSection/Status/CurrentStatus");
                        public class CurrentStatus_5
                        {
                            public static GameObject StatusIcon => GameObject.Find("/UserInterface/MenuContent/Screens/Social/UserProfileAndStatusSection/Status/CurrentStatus/StatusIcon");
                            public static GameObject StatusText => GameObject.Find("/UserInterface/MenuContent/Screens/Social/UserProfileAndStatusSection/Status/CurrentStatus/StatusText");

                        }

                    }
                    public static GameObject BottomLine => GameObject.Find("/UserInterface/MenuContent/Screens/Social/UserProfileAndStatusSection/BottomLine");

                }

            }
            public static GameObject Title => GameObject.Find("/UserInterface/MenuContent/Screens/Title");
            public class Title_2
            {
                public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/Title/Panel");
                public class Panel_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Title/Panel/Text");
                    public static GameObject TitleImage => GameObject.Find("/UserInterface/MenuContent/Screens/Title/Panel/TitleImage");

                }
                public static GameObject LogoContainer => GameObject.Find("/UserInterface/MenuContent/Screens/Title/LogoContainer");
                public class LogoContainer_3
                {
                    public static GameObject vrchatlogo2sided => GameObject.Find("/UserInterface/MenuContent/Screens/Title/LogoContainer/vrchatlogo2sided");

                }

            }
            public static GameObject UpdateRequired => GameObject.Find("/UserInterface/MenuContent/Screens/UpdateRequired");
            public class UpdateRequired_2
            {
                public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/UpdateRequired/Panel");
                public class Panel_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/UpdateRequired/Panel/Text");
                    public static GameObject TitleImage => GameObject.Find("/UserInterface/MenuContent/Screens/UpdateRequired/Panel/TitleImage");
                    public static GameObject ButtonUpdate => GameObject.Find("/UserInterface/MenuContent/Screens/UpdateRequired/Panel/ButtonUpdate");
                    public class ButtonUpdate_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/UpdateRequired/Panel/ButtonUpdate/Text");

                    }

                }

            }
            public static GameObject TitleXR => GameObject.Find("/UserInterface/MenuContent/Screens/TitleXR");
            public class TitleXR_2
            {
                public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/TitleXR/Panel");
                public class Panel_3
                {
                    public static GameObject TitleImage => GameObject.Find("/UserInterface/MenuContent/Screens/TitleXR/Panel/TitleImage");

                }

            }
            public static GameObject Gallery => GameObject.Find("/UserInterface/MenuContent/Screens/Gallery");
            public class Gallery_2
            {
                public static GameObject TitlePanel => GameObject.Find("/UserInterface/MenuContent/Screens/Gallery/TitlePanel");
                public class TitlePanel_3
                {
                    public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Screens/Gallery/TitlePanel/TitleText");
                    public static GameObject UploadUserIcon => GameObject.Find("/UserInterface/MenuContent/Screens/Gallery/TitlePanel/UploadUserIcon");
                    public class UploadUserIcon_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Gallery/TitlePanel/UploadUserIcon/Text");

                    }

                }
                public static GameObject DepthOverlay => GameObject.Find("/UserInterface/MenuContent/Screens/Gallery/DepthOverlay");
                public static GameObject Vertical_Scroll_View => GameObject.Find("/UserInterface/MenuContent/Screens/Gallery/Vertical Scroll View");
                public class Vertical_Scroll_View_3
                {
                    public static GameObject Viewport => GameObject.Find("/UserInterface/MenuContent/Screens/Gallery/Vertical Scroll View/Viewport");
                    public class Viewport_4
                    {
                        public static GameObject Content => GameObject.Find("/UserInterface/MenuContent/Screens/Gallery/Vertical Scroll View/Viewport/Content");
                        public class Content_5
                        {
                            public static GameObject My_User_Icons_List => GameObject.Find("/UserInterface/MenuContent/Screens/Gallery/Vertical Scroll View/Viewport/Content/My User Icons List");
                            public static GameObject My_Images_List => GameObject.Find("/UserInterface/MenuContent/Screens/Gallery/Vertical Scroll View/Viewport/Content/My Images List");

                        }

                    }

                }

            }
            public static GameObject ImageDetails => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails");
            public class ImageDetails_2
            {
                public static GameObject TitlePanel => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/TitlePanel");
                public class TitlePanel_3
                {
                    public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/TitlePanel/TitleText");

                }
                public static GameObject LargeImage => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/LargeImage");
                public class LargeImage_3
                {
                    public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/LargeImage/Image");
                    public static GameObject ImageBorder => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/LargeImage/ImageBorder");

                }
                public static GameObject ImageOptions => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions");
                public class ImageOptions_3
                {
                    public static GameObject SetAsProfilePic => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/SetAsProfilePic");
                    public class SetAsProfilePic_4
                    {
                        public static GameObject SetAsProfilePicButton => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/SetAsProfilePic/SetAsProfilePicButton");
                        public class SetAsProfilePicButton_5
                        {
                            public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/SetAsProfilePic/SetAsProfilePicButton/Image");

                        }

                    }
                    public static GameObject CreateUserIcon => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/CreateUserIcon");
                    public class CreateUserIcon_4
                    {
                        public static GameObject CreateUserIconButton => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/CreateUserIcon/CreateUserIconButton");
                        public class CreateUserIconButton_5
                        {
                            public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/CreateUserIcon/CreateUserIconButton/Image");

                        }

                    }
                    public static GameObject Delete => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/Delete");
                    public class Delete_4
                    {
                        public static GameObject DeleteButton => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/Delete/DeleteButton");
                        public class DeleteButton_5
                        {
                            public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/Delete/DeleteButton/Image");

                        }

                    }
                    public static GameObject Save => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/Save");
                    public class Save_4
                    {
                        public static GameObject SaveButton => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/Save/SaveButton");
                        public class SaveButton_5
                        {
                            public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImageOptions/Save/SaveButton/Image");

                        }

                    }

                }
                public static GameObject ImagesScrollView => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImagesScrollView");
                public class ImagesScrollView_3
                {
                    public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImagesScrollView/Panel");
                    public static GameObject Button => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImagesScrollView/Button");
                    public class Button_4
                    {
                        public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImagesScrollView/Button/TitleText");
                        public static GameObject ToggleIcon => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImagesScrollView/Button/ToggleIcon");

                    }
                    public static GameObject Viewport => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImagesScrollView/Viewport");
                    public class Viewport_4
                    {
                        public static GameObject Content => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImagesScrollView/Viewport/Content");
                        public class Content_5
                        {
                            public static GameObject Images => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/ImagesScrollView/Viewport/Content/Images");

                        }

                    }

                }
                public static GameObject BackButton => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/BackButton");
                public class BackButton_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/BackButton/Text");

                }
                public static GameObject DepthOverlay => GameObject.Find("/UserInterface/MenuContent/Screens/ImageDetails/DepthOverlay");

            }
            public static GameObject UserInfo => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo");
            public class UserInfo_2
            {
                public static GameObject Worlds => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Worlds");
                public class Worlds_3
                {
                    public static GameObject WorldScrollView => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Worlds/WorldScrollView");
                    public class WorldScrollView_4
                    {
                        public static GameObject Button => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Worlds/WorldScrollView/Button");
                        public class Button_5
                        {
                            public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Worlds/WorldScrollView/Button/TitleText");
                            public static GameObject WorldsPanel => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Worlds/WorldScrollView/Button/WorldsPanel");

                        }
                        public static GameObject Viewport => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Worlds/WorldScrollView/Viewport");
                        public class Viewport_5
                        {
                            public static GameObject Content => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Worlds/WorldScrollView/Viewport/Content");

                        }

                    }
                    public static GameObject CurrentWorld => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Worlds/CurrentWorld");
                    public class CurrentWorld_4
                    {
                        public static GameObject CurrentWorldPanel => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Worlds/CurrentWorld/CurrentWorldPanel");
                        public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Worlds/CurrentWorld/TitleText");
                        public static GameObject WorldUiPrefab => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Worlds/CurrentWorld/WorldUiPrefab");
                        public class WorldUiPrefab_5
                        {
                            public static GameObject RoomOutline => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Worlds/CurrentWorld/WorldUiPrefab/RoomOutline");
                            public static GameObject RoomImageShape => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Worlds/CurrentWorld/WorldUiPrefab/RoomImageShape");
                            public static GameObject Panel__Instance => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Worlds/CurrentWorld/WorldUiPrefab/Panel - Instance");

                        }

                    }

                }
                public static GameObject BackButton => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/BackButton");
                public class BackButton_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/BackButton/Text");

                }
                public static GameObject AvatarImage => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage");
                public class AvatarImage_3
                {
                    public static GameObject AvatarImageMask => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/AvatarImageMask");
                    public class AvatarImageMask_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/AvatarImageMask/Background");
                        public static GameObject AvatarImage => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/AvatarImageMask/AvatarImage");

                    }
                    public static GameObject HideUserAvatar => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/HideUserAvatar");
                    public class HideUserAvatar_4
                    {
                        public static GameObject PhotoHiddenText => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/HideUserAvatar/PhotoHiddenText");

                    }
                    public static GameObject AvatarBorder => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/AvatarBorder");
                    public static GameObject Icon => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/Icon");
                    public static GameObject SupporterIcon => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/SupporterIcon");
                    public static GameObject OverlayIcons => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/OverlayIcons");
                    public class OverlayIcons_4
                    {
                        public static GameObject FavoriteIcon => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/OverlayIcons/FavoriteIcon");
                        public static GameObject PlatformPCIcon => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/OverlayIcons/PlatformPCIcon");
                        public static GameObject PlatformMobileIcon => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/OverlayIcons/PlatformMobileIcon");
                        public static GameObject MobileIcons => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/OverlayIcons/MobileIcons");
                        public class MobileIcons_5
                        {
                            public static GameObject MobilePlatformPCIcon => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/OverlayIcons/MobileIcons/MobilePlatformPCIcon");
                            public static GameObject MobilePlatformMobileIcon => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/AvatarImage/OverlayIcons/MobileIcons/MobilePlatformMobileIcon");

                        }

                    }

                }
                public static GameObject SelfButtons => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SelfButtons");
                public class SelfButtons_3
                {
                    public static GameObject ChangeProfilePicButton => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SelfButtons/ChangeProfilePicButton");
                    public class ChangeProfilePicButton_4
                    {
                        public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SelfButtons/ChangeProfilePicButton/Image");
                        public class Image_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SelfButtons/ChangeProfilePicButton/Image/Text");

                        }
                        public static GameObject VRCPlus => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SelfButtons/ChangeProfilePicButton/VRC+");

                    }
                    public static GameObject UseAvatarAsProfilePicButton => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SelfButtons/UseAvatarAsProfilePicButton");
                    public class UseAvatarAsProfilePicButton_4
                    {
                        public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SelfButtons/UseAvatarAsProfilePicButton/Image");
                        public class Image_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SelfButtons/UseAvatarAsProfilePicButton/Image/Text");

                        }

                    }

                }
                public static GameObject OnlineFriendButtons => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/OnlineFriendButtons");
                public class OnlineFriendButtons_3
                {
                    public static GameObject JoinButton => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/OnlineFriendButtons/JoinButton");
                    public class JoinButton_4
                    {
                        public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/OnlineFriendButtons/JoinButton/Image");
                        public class Image_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/OnlineFriendButtons/JoinButton/Image/Text");

                        }

                    }
                    public static GameObject Invite => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/OnlineFriendButtons/Invite");
                    public class Invite_4
                    {
                        public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/OnlineFriendButtons/Invite/Image");
                        public class Image_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/OnlineFriendButtons/Invite/Image/Text");

                        }

                    }
                    public static GameObject Actions => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/OnlineFriendButtons/Actions");

                }
                public static GameObject ViewUserOnVRChatWebsiteButton => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ViewUserOnVRChatWebsiteButton");
                public class ViewUserOnVRChatWebsiteButton_3
                {
                    public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ViewUserOnVRChatWebsiteButton/Image");
                    public class Image_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ViewUserOnVRChatWebsiteButton/Image/Text");

                    }

                }
                public static GameObject User_Panel => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel");
                public class User_Panel_3
                {
                    public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/Panel");
                    public static GameObject PanelHeaderBackground => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/PanelHeaderBackground");
                    public static GameObject NameText => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/NameText");
                    public static GameObject UserIcon => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/UserIcon");
                    public class UserIcon_4
                    {
                        public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/UserIcon/Background");
                        public static GameObject User_Image => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/UserIcon/User Image");
                        public static GameObject Initials => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/UserIcon/Initials");

                    }
                    public static GameObject UserStatus => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/UserStatus");
                    public class UserStatus_4
                    {
                        public static GameObject StatusIcon => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/UserStatus/StatusIcon");
                        public static GameObject StatusText => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/UserStatus/StatusText");

                    }
                    public static GameObject TrustLevel => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/TrustLevel");
                    public class TrustLevel_4
                    {
                        public static GameObject TrustIcon => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/TrustLevel/TrustIcon");
                        public static GameObject TrustText => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/TrustLevel/TrustText");

                    }
                    public static GameObject VRCIcons => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/VRCIcons");
                    public class VRCIcons_4
                    {
                        public static GameObject VRCPlusEarlyAdopterIcon => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/VRCIcons/VRCPlusEarlyAdopterIcon");
                        public static GameObject VRCPlusSubscriberIcon => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/VRCIcons/VRCPlusSubscriberIcon");

                    }
                    public static GameObject UserBio => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/UserBio");
                    public class UserBio_4
                    {
                        public static GameObject Bio_Scroll_View => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/UserBio/Bio Scroll View");
                        public class Bio_Scroll_View_5
                        {
                            public static GameObject Viewport => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/UserBio/Bio Scroll View/Viewport");

                        }

                    }
                    public static GameObject InviteNotification => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/InviteNotification");
                    public class InviteNotification_4
                    {
                        public static GameObject Panel_Backdrop => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/InviteNotification/Panel_Backdrop");
                        public static GameObject Actions => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/InviteNotification/Actions");
                        public class Actions_5
                        {
                            public static GameObject Accept => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/InviteNotification/Actions/Accept");
                            public static GameObject Decline => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/InviteNotification/Actions/Decline");
                            public static GameObject Block => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/InviteNotification/Actions/Block");

                        }
                        public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/InviteNotification/Image");
                        public class Image_5
                        {
                            public static GameObject WorldImage => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/InviteNotification/Image/WorldImage");
                            public static GameObject WorldBorder => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/InviteNotification/Image/WorldBorder");

                        }
                        public static GameObject MessageText => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/User Panel/InviteNotification/MessageText");

                    }

                }
                public static GameObject Buttons => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons");
                public class Buttons_3
                {
                    public static GameObject RightSideButtons => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons");
                    public class RightSideButtons_4
                    {
                        public static GameObject RightUpperButtonColumn => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightUpperButtonColumn");
                        public class RightUpperButtonColumn_5
                        {
                            public static GameObject Supporter => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightUpperButtonColumn/Supporter");
                            public static GameObject PlaylistsButton => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightUpperButtonColumn/PlaylistsButton");
                            public static GameObject FavoriteButton => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightUpperButtonColumn/FavoriteButton");
                            public static GameObject EditBioButton => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightUpperButtonColumn/EditBioButton");
                            public static GameObject EditStatusButton => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightUpperButtonColumn/EditStatusButton");
                            public static GameObject GiftVRChatPlusButton => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightUpperButtonColumn/GiftVRChatPlusButton");

                        }
                        public static GameObject RightLowerButtonColumn => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightLowerButtonColumn");
                        public class RightLowerButtonColumn_5
                        {
                            public static GameObject UnfriendButton => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightLowerButtonColumn/UnfriendButton");
                            public static GameObject FriendButton => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightLowerButtonColumn/FriendButton");
                            public static GameObject ReportButton => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightLowerButtonColumn/ReportButton");
                            public static GameObject ModerateButton => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/Buttons/RightSideButtons/RightLowerButtonColumn/ModerateButton");

                        }

                    }

                }
                public static GameObject DepthOverlay => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/DepthOverlay");
                public static GameObject ReceivedFriendRequest => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest");
                public class ReceivedFriendRequest_3
                {
                    public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/Panel");
                    public static GameObject Actions => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/Actions");
                    public class Actions_4
                    {
                        public static GameObject Accept => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/Actions/Accept");
                        public class Accept_5
                        {
                            public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/Actions/Accept/Image");

                        }
                        public static GameObject Decline => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/Actions/Decline");
                        public class Decline_5
                        {
                            public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/Actions/Decline/Image");

                        }
                        public static GameObject Block => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/Actions/Block");
                        public class Block_5
                        {
                            public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/Actions/Block/Image");

                        }

                    }
                    public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/Image");
                    public class Image_4
                    {
                        public static GameObject WorldImage => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/Image/WorldImage");
                        public static GameObject WorldBorder => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/Image/WorldBorder");

                    }
                    public static GameObject MessageText => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ReceivedFriendRequest/MessageText");

                }
                public static GameObject SentFriendRequest => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SentFriendRequest");
                public class SentFriendRequest_3
                {
                    public static GameObject Actions => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SentFriendRequest/Actions");
                    public class Actions_4
                    {
                        public static GameObject Friend => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SentFriendRequest/Actions/Friend");
                        public class Friend_5
                        {
                            public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SentFriendRequest/Actions/Friend/Image");

                        }
                        public static GameObject Block => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SentFriendRequest/Actions/Block");
                        public class Block_5
                        {
                            public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SentFriendRequest/Actions/Block/Image");

                        }

                    }
                    public static GameObject WorldImage => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SentFriendRequest/WorldImage");
                    public class WorldImage_4
                    {
                        public static GameObject WorldImage => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SentFriendRequest/WorldImage/WorldImage");
                        public static GameObject WorldBorder => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/SentFriendRequest/WorldImage/WorldBorder");

                    }

                }
                public static GameObject ModerateDialog => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog");
                public class ModerateDialog_3
                {
                    public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Darkness");
                    public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel");
                    public class Panel_4
                    {
                        public static GameObject BorderImage => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/BorderImage");
                        public static GameObject PanelHeaderBackground => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/PanelHeaderBackground");
                        public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/TitleText");
                        public static GameObject ExitButton => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/ExitButton");
                        public static GameObject GeneralModerationTitleText => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/GeneralModerationTitleText");
                        public static GameObject GeneralModeration => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/GeneralModeration");
                        public class GeneralModeration_5
                        {
                            public static GameObject Mute => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/GeneralModeration/Mute");
                            public static GameObject Block => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/GeneralModeration/Block");
                            public static GameObject VoteKick => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/GeneralModeration/VoteKick");

                        }
                        public static GameObject AdminModerationTitleText => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/AdminModerationTitleText");
                        public static GameObject InstanceOwnerModerationTitleText => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/InstanceOwnerModerationTitleText");
                        public static GameObject ModerateButtons => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/ModerateButtons");
                        public class ModerateButtons_5
                        {
                            public static GameObject Actions => GameObject.Find("/UserInterface/MenuContent/Screens/UserInfo/ModerateDialog/Panel/ModerateButtons/Actions");

                        }

                    }

                }

            }
            public static GameObject VRCPlus => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+");
            public class VRCPlus_2
            {
                public static GameObject TitlePanel => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/TitlePanel");
                public class TitlePanel_3
                {
                    public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/TitlePanel/TitleText");
                    public static GameObject TermsAndConditions => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/TitlePanel/TermsAndConditions");
                    public class TermsAndConditions_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/TitlePanel/TermsAndConditions/Text");

                    }

                }
                public static GameObject Subscription => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription");
                public class Subscription_3
                {
                    public static GameObject NonSubscriberBanner => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/NonSubscriberBanner");
                    public static GameObject SubscriberBanner => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/SubscriberBanner");
                    public class SubscriberBanner_4
                    {
                        public static GameObject Viewport => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/SubscriberBanner/Viewport");
                        public class Viewport_5
                        {
                            public static GameObject Starfield => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/SubscriberBanner/Viewport/Starfield");
                            public static GameObject Asteroids => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/SubscriberBanner/Viewport/Asteroids");
                            public static GameObject Cockpit => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/SubscriberBanner/Viewport/Cockpit");
                            public static GameObject Lens_Flare => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/SubscriberBanner/Viewport/Lens Flare");

                        }
                        public static GameObject Frame => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/SubscriberBanner/Frame");

                    }
                    public static GameObject GROUP_Features => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Features");
                    public class GROUP_Features_4
                    {
                        public static GameObject Feature_UserIcon => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Features/Feature_UserIcon");
                        public class Feature_UserIcon_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Features/Feature_UserIcon/Text");

                        }
                        public static GameObject Feature_MoreFavorites => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Features/Feature_MoreFavorites");
                        public class Feature_MoreFavorites_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Features/Feature_MoreFavorites/Text");

                        }
                        public static GameObject Feature_EarlySupporter => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Features/Feature_EarlySupporter");
                        public class Feature_EarlySupporter_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Features/Feature_EarlySupporter/Text");

                        }
                        public static GameObject Feature_ProfileImage => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Features/Feature_ProfileImage");
                        public class Feature_ProfileImage_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Features/Feature_ProfileImage/Text");

                        }
                        public static GameObject Feature_PhotoInvites => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Features/Feature_PhotoInvites");
                        public class Feature_PhotoInvites_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Features/Feature_PhotoInvites/Text");

                        }

                    }
                    public static GameObject GROUP_Subscribe_Buttons => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons");
                    public class GROUP_Subscribe_Buttons_4
                    {
                        public static GameObject SubscribeGroup => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/SubscribeGroup");
                        public class SubscribeGroup_5
                        {
                            public static GameObject SubscribeButton_Monthly => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/SubscribeGroup/SubscribeButton_Monthly");
                            public static GameObject SubscribeButton_Yearly => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/SubscribeGroup/SubscribeButton_Yearly");

                        }
                        public static GameObject GROUP_Manage_Subscription => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/GROUP_Manage_Subscription");
                        public class GROUP_Manage_Subscription_5
                        {
                            public static GameObject SubscriptionName => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/GROUP_Manage_Subscription/SubscriptionName");
                            public static GameObject BillingDate => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/GROUP_Manage_Subscription/BillingDate");
                            public static GameObject Amount => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/GROUP_Manage_Subscription/Amount");
                            public static GameObject ManageSubscriptionButton => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/GROUP_Manage_Subscription/ManageSubscriptionButton");
                            public static GameObject SignifyAdminAccount => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/GROUP_Manage_Subscription/SignifyAdminAccount");

                        }
                        public static GameObject GROUP_Button_NotAvailable => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/GROUP_Button_NotAvailable");
                        public class GROUP_Button_NotAvailable_5
                        {
                            public static GameObject Button => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/GROUP_Button_NotAvailable/Button");

                        }
                        public static GameObject GROUP_IntroductoryOffer_Buttons => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/GROUP_IntroductoryOffer_Buttons");
                        public class GROUP_IntroductoryOffer_Buttons_5
                        {
                            public static GameObject Deal_HeaderPanel => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/GROUP_IntroductoryOffer_Buttons/Deal_HeaderPanel");
                            public static GameObject IntroductorySubscribeGroup => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_Subscribe_Buttons/GROUP_IntroductoryOffer_Buttons/IntroductorySubscribeGroup");

                        }

                    }
                    public static GameObject GROUP_FeatureHovers => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_FeatureHovers");
                    public class GROUP_FeatureHovers_4
                    {
                        public static GameObject IMG_FeatureHover_NameIcon => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_FeatureHovers/IMG_FeatureHover_NameIcon");
                        public static GameObject IMG_FeatureHover_MoreFavoriteAvatars => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_FeatureHovers/IMG_FeatureHover_MoreFavoriteAvatars");
                        public static GameObject IMG_FeatureHover_EarlySupporterBadge => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_FeatureHovers/IMG_FeatureHover_EarlySupporterBadge");
                        public static GameObject IMG_FeatureHover_ProfileImage => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_FeatureHovers/IMG_FeatureHover_ProfileImage");
                        public static GameObject IMG_FeatureHover_PhotoInvites => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/GROUP_FeatureHovers/IMG_FeatureHover_PhotoInvites");

                    }
                    public static GameObject ProcessingOverlay => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/ProcessingOverlay");
                    public class ProcessingOverlay_4
                    {
                        public static GameObject CloseButton => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/ProcessingOverlay/CloseButton");
                        public class CloseButton_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/ProcessingOverlay/CloseButton/Text");

                        }
                        public static GameObject GenericProcessingTransaction => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/ProcessingOverlay/GenericProcessingTransaction");
                        public class GenericProcessingTransaction_5
                        {
                            public static GameObject ProcessingText => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/ProcessingOverlay/GenericProcessingTransaction/ProcessingText");
                            public static GameObject ProcessingSpinner => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/ProcessingOverlay/GenericProcessingTransaction/ProcessingSpinner");

                        }
                        public static GameObject SteamProcessingTransaction => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/ProcessingOverlay/SteamProcessingTransaction");
                        public class SteamProcessingTransaction_5
                        {
                            public static GameObject ProcessingSpinner => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/ProcessingOverlay/SteamProcessingTransaction/ProcessingSpinner");
                            public static GameObject ProcessingText => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/ProcessingOverlay/SteamProcessingTransaction/ProcessingText");
                            public static GameObject CheckSteamText => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/ProcessingOverlay/SteamProcessingTransaction/CheckSteamText");
                            public static GameObject CheckSteamOptionsText => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/Subscription/ProcessingOverlay/SteamProcessingTransaction/CheckSteamOptionsText");

                        }

                    }

                }
                public static GameObject DepthOverlay => GameObject.Find("/UserInterface/MenuContent/Screens/VRC+/DepthOverlay");

            }
            public static GameObject WorldInfo => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo");
            public class WorldInfo_2
            {
                public static GameObject Panel_1 => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panel (1)");
                public static GameObject Back_Button => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Back Button");
                public class Back_Button_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Back Button/Text");

                }
                public static GameObject WorldButtons => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldButtons");
                public class WorldButtons_3
                {
                    public static GameObject GoButton => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldButtons/GoButton");
                    public class GoButton_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldButtons/GoButton/Text");

                    }
                    public static GameObject SecurePortalButton => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldButtons/SecurePortalButton");
                    public class SecurePortalButton_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldButtons/SecurePortalButton/Text");
                        public static GameObject Icon_Locked => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldButtons/SecurePortalButton/Icon_Locked");
                        public static GameObject Icon_Unlocked => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldButtons/SecurePortalButton/Icon_Unlocked");

                    }
                    public static GameObject SecurePortalButton_Disabled => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldButtons/SecurePortalButton_Disabled");
                    public class SecurePortalButton_Disabled_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldButtons/SecurePortalButton_Disabled/Text");
                        public static GameObject Icon_Unlocked => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldButtons/SecurePortalButton_Disabled/Icon_Unlocked");

                    }
                    public static GameObject OpenPortalButton => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldButtons/OpenPortalButton");
                    public class OpenPortalButton_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldButtons/OpenPortalButton/Text");
                        public static GameObject Subtext => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldButtons/OpenPortalButton/Subtext");

                    }
                    public static GameObject NewButton => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldButtons/NewButton");
                    public class NewButton_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldButtons/NewButton/Text");

                    }
                    public static GameObject InfoButton => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldButtons/InfoButton");

                }
                public static GameObject WorldImage => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage");
                public class WorldImage_3
                {
                    public static GameObject RoomImage => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/RoomImage");
                    public static GameObject RoomBorder => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/RoomBorder");
                    public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/Panel");
                    public class Panel_4
                    {
                        public static GameObject NameText => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/Panel/NameText");
                        public static GameObject PlayerCount => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/Panel/PlayerCount");
                        public class PlayerCount_5
                        {
                            public static GameObject IconPlayer => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/Panel/PlayerCount/IconPlayer");
                            public static GameObject CurrentCount => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/Panel/PlayerCount/CurrentCount");

                        }

                    }
                    public static GameObject CurrentInstance => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/CurrentInstance");
                    public class CurrentInstance_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/CurrentInstance/Text");

                    }
                    public static GameObject OverlayIcons => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/OverlayIcons");
                    public class OverlayIcons_4
                    {
                        public static GameObject FavoriteIcon => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/OverlayIcons/FavoriteIcon");
                        public class FavoriteIcon_5
                        {
                            public static GameObject IconBackground => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/OverlayIcons/FavoriteIcon/IconBackground");
                            public static GameObject IconImage => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/OverlayIcons/FavoriteIcon/IconImage");

                        }
                        public static GameObject CommunityLabsIcon => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/OverlayIcons/CommunityLabsIcon");
                        public class CommunityLabsIcon_5
                        {
                            public static GameObject IconBackground => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/OverlayIcons/CommunityLabsIcon/IconBackground");
                            public static GameObject IconImage => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/OverlayIcons/CommunityLabsIcon/IconImage");

                        }
                        public static GameObject PlatformIcon => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/OverlayIcons/PlatformIcon");
                        public class PlatformIcon_5
                        {
                            public static GameObject IconBackground => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/OverlayIcons/PlatformIcon/IconBackground");
                            public static GameObject IconImage => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/OverlayIcons/PlatformIcon/IconImage");

                        }
                                        
                        public static GameObject MobileIcons => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/OverlayIcons/MobileIcons");
                        public class MobileIcons_5
                        {
                            public static GameObject MobileIconPlatformPC => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/OverlayIcons/MobileIcons/MobileIconPlatformPC");
                            public static GameObject MobileIconPlatformMobile => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/OverlayIcons/MobileIcons/MobileIconPlatformMobile");
                            public static GameObject MobileIconPlatformAny => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/OverlayIcons/MobileIcons/MobileIconPlatformAny");

                        }

                    }
                    public static GameObject InstanceInfo => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/InstanceInfo");
                    public class InstanceInfo_4
                    {
                        public static GameObject InstanceNameBackground => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/InstanceInfo/InstanceNameBackground");
                        public class InstanceNameBackground_5
                        {
                            public static GameObject InstanceName => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/InstanceInfo/InstanceNameBackground/InstanceName");

                        }
                        public static GameObject InstanceOwnerBackground => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/InstanceInfo/InstanceOwnerBackground");
                        public class InstanceOwnerBackground_5
                        {
                            public static GameObject InstanceOwner => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/InstanceInfo/InstanceOwnerBackground/InstanceOwner");

                        }
                        public static GameObject InstanceTypeBackground => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/InstanceInfo/InstanceTypeBackground");
                        public class InstanceTypeBackground_5
                        {
                            public static GameObject InstanceType => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/InstanceInfo/InstanceTypeBackground/InstanceType");

                        }
                        public static GameObject InstanceRegionBackground => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/InstanceInfo/InstanceRegionBackground");
                        public class InstanceRegionBackground_5
                        {
                            public static GameObject InstanceRegion => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/WorldImage/InstanceInfo/InstanceRegionBackground/InstanceRegion");

                        }

                    }

                }
                public static GameObject OtherInstances => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/OtherInstances");
                public class OtherInstances_3
                {
                    public static GameObject ViewPort => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/OtherInstances/ViewPort");
                    public class ViewPort_4
                    {
                        public static GameObject Content => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/OtherInstances/ViewPort/Content");

                    }
                    public static GameObject Button => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/OtherInstances/Button");
                    public class Button_4
                    {
                        public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/OtherInstances/Button/TitleText");
                        public static GameObject ToggleIcon => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/OtherInstances/Button/ToggleIcon");

                    }

                }
                public static GameObject MakeHomeButton => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/MakeHomeButton");
                public class MakeHomeButton_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/MakeHomeButton/Text");

                }
                public static GameObject ResetHomeButton => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/ResetHomeButton");
                public class ResetHomeButton_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/ResetHomeButton/Text");

                }
                public static GameObject ReportButton => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/ReportButton");
                public class ReportButton_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/ReportButton/Text");

                }
                public static GameObject DepthOverlay => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/DepthOverlay");
                public static GameObject FavoriteButton => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/FavoriteButton");
                public class FavoriteButton_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/FavoriteButton/Text");

                }
                public static GameObject Panels => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels");
                public class Panels_3
                {
                    public static GameObject PanelBackground => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/PanelBackground");
                    public static GameObject DetailsPanel => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel");
                    public class DetailsPanel_4
                    {
                        public static GameObject AuthorTextTitle => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/AuthorText-Title");
                        public class AuthorTextTitle_5
                        {
                            public static GameObject AuthorButton => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/AuthorText-Title/AuthorButton");

                        }
                        public static GameObject WorldSizeTextTitle => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/WorldSizeTextTitle");
                        public class WorldSizeTextTitle_5
                        {
                            public static GameObject WorldSizeText => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/WorldSizeTextTitle/WorldSizeText");

                        }
                        public static GameObject PublishStatusData => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/PublishStatus-Data");
                        public static GameObject DescTextTitle => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/DescText-Title");
                        public class DescTextTitle_5
                        {
                            public static GameObject DescTextDesc => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/DescText-Title/DescText-Desc");

                        }
                        public static GameObject PublicTextTitle => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/PublicTextTitle");
                        public class PublicTextTitle_5
                        {
                            public static GameObject PublicText => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/PublicTextTitle/PublicText");

                        }
                        public static GameObject PrivateTextTitle => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/PrivateTextTitle");
                        public class PrivateTextTitle_5
                        {
                            public static GameObject PrivateText => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/PrivateTextTitle/PrivateText");

                        }
                        public static GameObject TagButton => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/TagButton");
                        public class TagButton_5
                        {
                            public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/DetailsPanel/TagButton/Image");

                        }

                    }
                    public static GameObject TagsPanel => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/TagsPanel");
                    public class TagsPanel_4
                    {
                        public static GameObject TagButtons => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/TagsPanel/TagButtons");
                        public class TagButtons_5
                        {
                            public static GameObject TagButton1 => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/TagsPanel/TagButtons/TagButton1");
                            public static GameObject TagButton2 => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/TagsPanel/TagButtons/TagButton2");
                            public static GameObject TagButton => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/TagsPanel/TagButtons/TagButton3");
                            public static GameObject TagButton4 => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/TagsPanel/TagButtons/TagButton4");
                            public static GameObject TagButton5 => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/TagsPanel/TagButtons/TagButton5");
                            public static GameObject TagsLabel => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/TagsPanel/TagButtons/TagsLabel");

                        }
                        public static GameObject DetailsButton => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/TagsPanel/DetailsButton");
                        public class DetailsButton_5
                        {
                            public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Panels/TagsPanel/DetailsButton/Image");

                        }

                    }

                }
                public static GameObject Secure_Portal_Info => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Secure Portal Info");
                public class Secure_Portal_Info_3
                {
                    public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Secure Portal Info/Darkness");
                    public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Secure Portal Info/Background");
                    public class Background_4
                    {
                        public static GameObject Header => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Secure Portal Info/Background/Header");
                        public class Header_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Secure Portal Info/Background/Header/Text");
                            public static GameObject Close_X => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Secure Portal Info/Background/Header/Close_X");

                        }
                        public static GameObject Locked_Portal_Info => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Secure Portal Info/Background/Locked Portal Info");
                        public class Locked_Portal_Info_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Secure Portal Info/Background/Locked Portal Info/Text");
                            public static GameObject Text_1 => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Secure Portal Info/Background/Locked Portal Info/Text (1)");
                            public static GameObject Icon => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Secure Portal Info/Background/Locked Portal Info/Icon");

                        }
                        public static GameObject Unlocked_Portal_Info => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Secure Portal Info/Background/Unlocked Portal Info");
                        public class Unlocked_Portal_Info_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Secure Portal Info/Background/Unlocked Portal Info/Text");
                            public static GameObject Text_1 => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Secure Portal Info/Background/Unlocked Portal Info/Text (1)");
                            public static GameObject Icon => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Secure Portal Info/Background/Unlocked Portal Info/Icon");

                        }
                        public static GameObject Close_Button => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Secure Portal Info/Background/Close Button");
                        public class Close_Button_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/WorldInfo/Secure Portal Info/Background/Close Button/Text");

                        }

                    }

                }

            }
            public static GameObject Worlds => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds");
            public class Worlds_2
            {
                public static GameObject Vertical_Scroll_View => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Vertical Scroll View");
                public class Vertical_Scroll_View_3
                {
                    public static GameObject Viewport => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Vertical Scroll View/Viewport");
                    public class Viewport_4
                    {
                        public static GameObject Content => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Vertical Scroll View/Viewport/Content");
                        public class Content_5
                        {
                            public static GameObject Title__beet => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Vertical Scroll View/Viewport/Content/Title : beet");
                            public static GameObject Hot => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Vertical Scroll View/Viewport/Content/Hot");
                            public static GameObject Spotlight__PC => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Vertical Scroll View/Viewport/Content/Spotlight - PC");
                            public static GameObject Spotlight__Cross_Platform => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Vertical Scroll View/Viewport/Content/Spotlight - Cross Platform");
                            public static GameObject Community_Labs => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Vertical Scroll View/Viewport/Content/Community Labs");
                            public static GameObject Active__Cross_Platform => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Vertical Scroll View/Viewport/Content/Active - Cross Platform");
                            public static GameObject Active__My_Platform => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Vertical Scroll View/Viewport/Content/Active - My Platform");
                            public static GameObject Random => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Vertical Scroll View/Viewport/Content/Random");
                            public static GameObject Avatar_Worlds => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Vertical Scroll View/Viewport/Content/Avatar Worlds");
                            public static GameObject Games => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Vertical Scroll View/Viewport/Content/Games");
                            public static GameObject Updated_Recently => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Vertical Scroll View/Viewport/Content/Updated Recently");
                            public static GameObject New => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Vertical Scroll View/Viewport/Content/New");
                            public static GameObject Recent => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Vertical Scroll View/Viewport/Content/Recent");
                            public static GameObject Mine => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Vertical Scroll View/Viewport/Content/Mine");
                            public static GameObject Classics => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Vertical Scroll View/Viewport/Content/Classics");
                            public static GameObject Search => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Vertical Scroll View/Viewport/Content/Search");
                            public static GameObject FavoriteListTemplate => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Vertical Scroll View/Viewport/Content/FavoriteListTemplate");
                            public static GameObject DynamicTemplate => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Vertical Scroll View/Viewport/Content/DynamicTemplate");
                            public static GameObject SavedSearchTemplate => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Vertical Scroll View/Viewport/Content/SavedSearchTemplate");

                        }

                    }

                }
                public static GameObject Current_Room => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room");
                public class Current_Room_3
                {
                    public static GameObject TitlePanel => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/TitlePanel");
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/Text");
                    public static GameObject ThisWorldButton => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/ThisWorldButton");
                    public class ThisWorldButton_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/ThisWorldButton/Text");

                    }
                    public static GameObject RespawnButton_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/RespawnButton (1)");
                    public class RespawnButton_1_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/RespawnButton (1)/Text");
                        public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/RespawnButton (1)/Image");

                    }
                    public static GameObject LikeButton_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/LikeButton (1)");
                    public class LikeButton_1_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/LikeButton (1)/Text");
                        public static GameObject Image => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/LikeButton (1)/Image");

                    }
                    public static GameObject TopLine => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/TopLine");
                    public static GameObject TopLine_1 => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/Current Room/TopLine (1)");

                }
                public static GameObject DepthOverlay => GameObject.Find("/UserInterface/MenuContent/Screens/Worlds/DepthOverlay");

            }

        }
        public static GameObject Popups => GameObject.Find("/UserInterface/MenuContent/Popups");
        public class Popups_1
        {
            public static GameObject AddToFavoriteListPopup => GameObject.Find("/UserInterface/MenuContent/Popups/AddToFavoriteListPopup");
            public class AddToFavoriteListPopup_2
            {
                public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Popups/AddToFavoriteListPopup/Darkness");
                public static GameObject Popup => GameObject.Find("/UserInterface/MenuContent/Popups/AddToFavoriteListPopup/Popup");
                public class Popup_3
                {
                    public static GameObject BorderImage => GameObject.Find("/UserInterface/MenuContent/Popups/AddToFavoriteListPopup/Popup/BorderImage");
                    public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Popups/AddToFavoriteListPopup/Popup/Panel");
                    public static GameObject InstanceText => GameObject.Find("/UserInterface/MenuContent/Popups/AddToFavoriteListPopup/Popup/InstanceText");
                    public static GameObject FavoriteToggleTemplate => GameObject.Find("/UserInterface/MenuContent/Popups/AddToFavoriteListPopup/Popup/FavoriteToggleTemplate");
                    public class FavoriteToggleTemplate_4
                    {
                        public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Popups/AddToFavoriteListPopup/Popup/FavoriteToggleTemplate/Checkmark");
                        public static GameObject Description => GameObject.Find("/UserInterface/MenuContent/Popups/AddToFavoriteListPopup/Popup/FavoriteToggleTemplate/Description");

                    }
                    public static GameObject Checkboxes => GameObject.Find("/UserInterface/MenuContent/Popups/AddToFavoriteListPopup/Popup/Checkboxes");
                    public static GameObject AddButton => GameObject.Find("/UserInterface/MenuContent/Popups/AddToFavoriteListPopup/Popup/AddButton");
                    public class AddButton_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/AddToFavoriteListPopup/Popup/AddButton/Text");

                    }
                    public static GameObject ExitButton => GameObject.Find("/UserInterface/MenuContent/Popups/AddToFavoriteListPopup/Popup/ExitButton");

                }

            }
            public static GameObject AddInviteMessagePopup => GameObject.Find("/UserInterface/MenuContent/Popups/AddInviteMessagePopup");
            public class AddInviteMessagePopup_2
            {
                public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Popups/AddInviteMessagePopup/Darkness");
                public static GameObject InviteResponseAddMessageMenu => GameObject.Find("/UserInterface/MenuContent/Popups/AddInviteMessagePopup/InviteResponseAddMessageMenu");
                public class InviteResponseAddMessageMenu_3
                {
                    public static GameObject BorderImage => GameObject.Find("/UserInterface/MenuContent/Popups/AddInviteMessagePopup/InviteResponseAddMessageMenu/BorderImage");
                    public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Popups/AddInviteMessagePopup/InviteResponseAddMessageMenu/Panel");
                    public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Popups/AddInviteMessagePopup/InviteResponseAddMessageMenu/TitleText");
                    public static GameObject BackButton => GameObject.Find("/UserInterface/MenuContent/Popups/AddInviteMessagePopup/InviteResponseAddMessageMenu/BackButton");
                    public class BackButton_4
                    {
                        public static GameObject ArrowImage => GameObject.Find("/UserInterface/MenuContent/Popups/AddInviteMessagePopup/InviteResponseAddMessageMenu/BackButton/ArrowImage");

                    }
                    public static GameObject ScrollRect => GameObject.Find("/UserInterface/MenuContent/Popups/AddInviteMessagePopup/InviteResponseAddMessageMenu/ScrollRect");
                    public class ScrollRect_4
                    {
                        public static GameObject Viewport => GameObject.Find("/UserInterface/MenuContent/Popups/AddInviteMessagePopup/InviteResponseAddMessageMenu/ScrollRect/Viewport");
                        public class Viewport_5
                        {
                            public static GameObject VerticalLayoutGroup => GameObject.Find("/UserInterface/MenuContent/Popups/AddInviteMessagePopup/InviteResponseAddMessageMenu/ScrollRect/Viewport/VerticalLayoutGroup");

                        }

                    }

                }

            }
            public static GameObject AlertPopup => GameObject.Find("/UserInterface/MenuContent/Popups/AlertPopup");
            public class AlertPopup_2
            {
                public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Popups/AlertPopup/Darkness");
                public static GameObject Lighter => GameObject.Find("/UserInterface/MenuContent/Popups/AlertPopup/Lighter");
                public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Popups/AlertPopup/TitleText");
                public static GameObject BodyText => GameObject.Find("/UserInterface/MenuContent/Popups/AlertPopup/BodyText");
                public static GameObject TimerText => GameObject.Find("/UserInterface/MenuContent/Popups/AlertPopup/TimerText");
                public static GameObject Button => GameObject.Find("/UserInterface/MenuContent/Popups/AlertPopup/Button");
                public class Button_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/AlertPopup/Button/Text");

                }

            }
            public static GameObject CreateUserIconFromImagePopup => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup");
            public class CreateUserIconFromImagePopup_2
            {
                public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Darkness");
                public static GameObject Popup => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup");
                public class Popup_3
                {
                    public static GameObject BorderImage => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/BorderImage");
                    public static GameObject UserIconRoundBorderImage => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/UserIconRoundBorderImage");
                    public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Panel");
                    public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/TitleText");
                    public static GameObject CreateUserIconGroup => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/CreateUserIconGroup");
                    public class CreateUserIconGroup_4
                    {
                        public static GameObject Preview_Window => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/CreateUserIconGroup/Preview Window");
                        public class Preview_Window_5
                        {
                            public static GameObject Preview => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/CreateUserIconGroup/Preview Window/Preview");
                            public static GameObject Overlay => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/CreateUserIconGroup/Preview Window/Overlay");
                            public static GameObject Bounds => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/CreateUserIconGroup/Preview Window/Bounds");

                        }
                        public static GameObject Zoom_Pan_Group => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/CreateUserIconGroup/Zoom Pan Group");
                        public class Zoom_Pan_Group_5
                        {
                            public static GameObject Zoom => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/CreateUserIconGroup/Zoom Pan Group/Zoom");
                            public static GameObject Move_Icon => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/CreateUserIconGroup/Zoom Pan Group/Move Icon");

                        }
                        public static GameObject SaveAndApplyButton => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/CreateUserIconGroup/SaveAndApplyButton");
                        public class SaveAndApplyButton_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/CreateUserIconGroup/SaveAndApplyButton/Text");

                        }

                    }
                    public static GameObject SetAsCurrentIconGroup => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/SetAsCurrentIconGroup");
                    public class SetAsCurrentIconGroup_4
                    {
                        public static GameObject Preview_Window => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/SetAsCurrentIconGroup/Preview Window");
                        public class Preview_Window_5
                        {
                            public static GameObject Preview => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/SetAsCurrentIconGroup/Preview Window/Preview");
                            public static GameObject Overlay => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/SetAsCurrentIconGroup/Preview Window/Overlay");

                        }
                        public static GameObject UserIconCreatedText => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/SetAsCurrentIconGroup/UserIconCreatedText");
                        public static GameObject SetAsCurrentIconButton => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/SetAsCurrentIconGroup/SetAsCurrentIconButton");
                        public class SetAsCurrentIconButton_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/SetAsCurrentIconGroup/SetAsCurrentIconButton/Text");

                        }
                        public static GameObject CloseCreateUserIconPopupButton => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/SetAsCurrentIconGroup/CloseCreateUserIconPopupButton");
                        public class CloseCreateUserIconPopupButton_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/SetAsCurrentIconGroup/CloseCreateUserIconPopupButton/Text");

                        }

                    }
                    public static GameObject ExitButton => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/ExitButton");
                    public static GameObject Max_Icons => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Max Icons");
                    public class Max_Icons_4
                    {
                        public static GameObject Manage_Icons => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Max Icons/Manage Icons");
                        public class Manage_Icons_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Max Icons/Manage Icons/Text");

                        }
                        public static GameObject BackButton => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Max Icons/BackButton");
                        public class BackButton_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Max Icons/BackButton/Text");

                        }
                        public static GameObject Info => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Max Icons/Info");
                        public class Info_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Max Icons/Info/Text");
                            public static GameObject InfoIcon => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Max Icons/Info/InfoIcon");

                        }

                    }
                    public static GameObject Upload_Group => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Upload Group");
                    public class Upload_Group_4
                    {
                        public static GameObject Info => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Upload Group/Info");
                        public class Info_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/CreateUserIconFromImagePopup/Popup/Upload Group/Info/Text");

                        }

                    }

                }

            }
            public static GameObject ClearFavoriteListPopup => GameObject.Find("/UserInterface/MenuContent/Popups/ClearFavoriteListPopup");
            public class ClearFavoriteListPopup_2
            {
                public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Popups/ClearFavoriteListPopup/Darkness");
                public static GameObject Popup => GameObject.Find("/UserInterface/MenuContent/Popups/ClearFavoriteListPopup/Popup");
                public class Popup_3
                {
                    public static GameObject BorderImage => GameObject.Find("/UserInterface/MenuContent/Popups/ClearFavoriteListPopup/Popup/BorderImage");
                    public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Popups/ClearFavoriteListPopup/Popup/Panel");
                    public static GameObject ExitButton => GameObject.Find("/UserInterface/MenuContent/Popups/ClearFavoriteListPopup/Popup/ExitButton");
                    public static GameObject ClearFavoriteListTitleText => GameObject.Find("/UserInterface/MenuContent/Popups/ClearFavoriteListPopup/Popup/ClearFavoriteListTitleText");
                    public static GameObject ClearFavoriteListInfoText => GameObject.Find("/UserInterface/MenuContent/Popups/ClearFavoriteListPopup/Popup/ClearFavoriteListInfoText");
                    public static GameObject Buttons => GameObject.Find("/UserInterface/MenuContent/Popups/ClearFavoriteListPopup/Popup/Buttons");
                    public class Buttons_4
                    {
                        public static GameObject CancelButton => GameObject.Find("/UserInterface/MenuContent/Popups/ClearFavoriteListPopup/Popup/Buttons/CancelButton");
                        public class CancelButton_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/ClearFavoriteListPopup/Popup/Buttons/CancelButton/Text");

                        }
                        public static GameObject ClearButton => GameObject.Find("/UserInterface/MenuContent/Popups/ClearFavoriteListPopup/Popup/Buttons/ClearButton");
                        public class ClearButton_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/ClearFavoriteListPopup/Popup/Buttons/ClearButton/Text");

                        }

                    }

                }

            }
            public static GameObject CommunityLabsPopup => GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup");
            public class CommunityLabsPopup_2
            {
                public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/Darkness");
                public static GameObject Rectangle => GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/Rectangle");
                public static GameObject UpperPanel => GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/UpperPanel");
                public static GameObject TitlePanel => GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/TitlePanel");
                public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/TitleText");
                public static GameObject Icon_CL => GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/Icon_CL");
                public static GameObject BodyText => GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/BodyText");
                public static GameObject ReportText => GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/ReportText");
                public static GameObject Graphic_CL_Report => GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/Graphic_CL_Report");
                public static GameObject Icon_Warning => GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/Icon_Warning");
                public static GameObject WarningText => GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/WarningText");
                public static GameObject CancelButton => GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/CancelButton");
                public class CancelButton_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/CancelButton/Text");

                }
                public static GameObject AcceptButton => GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/AcceptButton");
                public class AcceptButton_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/AcceptButton/Text");

                }
                public static GameObject ExitButton => GameObject.Find("/UserInterface/MenuContent/Popups/CommunityLabsPopup/ExitButton");

            }
            public static GameObject DatePopup => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup");
            public class DatePopup_2
            {
                public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/Darkness");
                public static GameObject Rectangle => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/Rectangle");
                public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/TitleText");
                public static GameObject ButtonLeft => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/ButtonLeft");
                public class ButtonLeft_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/ButtonLeft/Text");

                }
                public static GameObject ButtonRight => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/ButtonRight");
                public class ButtonRight_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/ButtonRight/Text");

                }
                public static GameObject ButtonCenter => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/ButtonCenter");
                public class ButtonCenter_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/ButtonCenter/Text");

                }
                public static GameObject MonthSpinner => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/MonthSpinner");
                public class MonthSpinner_3
                {
                    public static GameObject SpinnerInput => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/MonthSpinner/SpinnerInput");
                    public class SpinnerInput_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/MonthSpinner/SpinnerInput/Text");
                        public static GameObject Placeholder => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/MonthSpinner/SpinnerInput/Placeholder");
                        public static GameObject SpecialFormatText => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/MonthSpinner/SpinnerInput/SpecialFormatText");

                    }
                    public static GameObject Minus => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/MonthSpinner/Minus");
                    public static GameObject Plus => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/MonthSpinner/Plus");

                }
                public static GameObject DayTenSpinner => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/DayTenSpinner");
                public class DayTenSpinner_3
                {
                    public static GameObject SpinnerInput => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/DayTenSpinner/SpinnerInput");
                    public class SpinnerInput_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/DayTenSpinner/SpinnerInput/Text");
                        public static GameObject Placeholder => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/DayTenSpinner/SpinnerInput/Placeholder");

                    }
                    public static GameObject Minus => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/DayTenSpinner/Minus");
                    public static GameObject Plus => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/DayTenSpinner/Plus");

                }
                public static GameObject DayOneSpinner => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/DayOneSpinner");
                public class DayOneSpinner_3
                {
                    public static GameObject SpinnerInput => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/DayOneSpinner/SpinnerInput");
                    public class SpinnerInput_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/DayOneSpinner/SpinnerInput/Text");
                        public static GameObject Placeholder => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/DayOneSpinner/SpinnerInput/Placeholder");

                    }
                    public static GameObject Minus => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/DayOneSpinner/Minus");
                    public static GameObject Plus => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/DayOneSpinner/Plus");

                }
                public static GameObject YearCenturySpinner => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearCenturySpinner");
                public class YearCenturySpinner_3
                {
                    public static GameObject SpinnerInput => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearCenturySpinner/SpinnerInput");
                    public class SpinnerInput_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearCenturySpinner/SpinnerInput/Text");
                        public static GameObject Placeholder => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearCenturySpinner/SpinnerInput/Placeholder");
                        public static GameObject SpecialFormatText => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearCenturySpinner/SpinnerInput/SpecialFormatText");

                    }
                    public static GameObject Minus => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearCenturySpinner/Minus");
                    public static GameObject Plus => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearCenturySpinner/Plus");

                }
                public static GameObject YearTenSpinner => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearTenSpinner");
                public class YearTenSpinner_3
                {
                    public static GameObject SpinnerInput => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearTenSpinner/SpinnerInput");
                    public class SpinnerInput_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearTenSpinner/SpinnerInput/Text");
                        public static GameObject Placeholder => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearTenSpinner/SpinnerInput/Placeholder");

                    }
                    public static GameObject Minus => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearTenSpinner/Minus");
                    public static GameObject Plus => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearTenSpinner/Plus");

                }
                public static GameObject YearOneSpinner => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearOneSpinner");
                public class YearOneSpinner_3
                {
                    public static GameObject SpinnerInput => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearOneSpinner/SpinnerInput");
                    public class SpinnerInput_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearOneSpinner/SpinnerInput/Text");
                        public static GameObject Placeholder => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearOneSpinner/SpinnerInput/Placeholder");

                    }
                    public static GameObject Minus => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearOneSpinner/Minus");
                    public static GameObject Plus => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearOneSpinner/Plus");

                }
                public static GameObject MonthLabel => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/MonthLabel");
                public static GameObject DayLabel => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/DayLabel");
                public static GameObject YearLabel => GameObject.Find("/UserInterface/MenuContent/Popups/DatePopup/YearLabel");

            }
            public static GameObject EditFavoriteListPopup => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup");
            public class EditFavoriteListPopup_2
            {
                public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Darkness");
                public static GameObject Popup => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup");
                public class Popup_3
                {
                    public static GameObject BorderImage => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/BorderImage");
                    public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/Panel");
                    public static GameObject ExitButton => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/ExitButton");
                    public static GameObject EditPlaylistTitleText => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/EditPlaylistTitleText");
                    public static GameObject InputFieldPlaylistTitle => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/InputFieldPlaylistTitle");
                    public class InputFieldPlaylistTitle_4
                    {
                        public static GameObject Placeholder => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/InputFieldPlaylistTitle/Placeholder");
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/InputFieldPlaylistTitle/Text");

                    }
                    public static GameObject PrivacyStatus => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/PrivacyStatus");
                    public class PrivacyStatus_4
                    {
                        public static GameObject Public => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/PrivacyStatus/Public");
                        public class Public_5
                        {
                            public static GameObject PrivacyIcon => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/PrivacyStatus/Public/PrivacyIcon");
                            public static GameObject Description => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/PrivacyStatus/Public/Description");
                            public static GameObject Highlight => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/PrivacyStatus/Public/Highlight");

                        }
                        public static GameObject Friends => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/PrivacyStatus/Friends");
                        public class Friends_5
                        {
                            public static GameObject PrivacyIcon => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/PrivacyStatus/Friends/PrivacyIcon");
                            public static GameObject Description => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/PrivacyStatus/Friends/Description");
                            public static GameObject Highlight => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/PrivacyStatus/Friends/Highlight");

                        }
                        public static GameObject Private => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/PrivacyStatus/Private");
                        public class Private_5
                        {
                            public static GameObject PrivacyIcon => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/PrivacyStatus/Private/PrivacyIcon");
                            public static GameObject Description => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/PrivacyStatus/Private/Description");
                            public static GameObject Highlight => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/PrivacyStatus/Private/Highlight");

                        }

                    }
                    public static GameObject Buttons => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/Buttons");
                    public class Buttons_4
                    {
                        public static GameObject ClearButton => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/Buttons/ClearButton");
                        public class ClearButton_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/Buttons/ClearButton/Text");

                        }
                        public static GameObject UpdateButton => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/Buttons/UpdateButton");
                        public class UpdateButton_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/EditFavoriteListPopup/Popup/Buttons/UpdateButton/Text");

                        }

                    }

                }

            }
            public static GameObject LoadingPopup => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup");
            public class LoadingPopup_2
            {
                public static GameObject ButtonMiddle => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ButtonMiddle");
                public class ButtonMiddle_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ButtonMiddle/Text");

                }
                public static GameObject LoadingSound => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/LoadingSound");
                public static GameObject ProgressPanel => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel");
                public class ProgressPanel_3
                {
                    public static GameObject Parent_Loading_Progress => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress");
                    public class Parent_Loading_Progress_4
                    {
                        public static GameObject Panel_Backdrop => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Panel_Backdrop");
                        public static GameObject Decoration_Left => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Decoration_Left");
                        public static GameObject Decoration_Right => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Decoration_Right");
                        public static GameObject Loading_Elements => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements");
                        public class Loading_Elements_5
                        {
                            public static GameObject txt_LOADING => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/txt_LOADING");
                            public static GameObject txt_Percent => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/txt_Percent");
                            public static GameObject txt_LOADING_Size => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/txt_LOADING_Size");
                            public static GameObject LOADING_BAR_BG => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/LOADING_BAR_BG");
                            public static GameObject LOADING_BAR => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/LOADING_BAR");

                        }
                        public static GameObject GoButton => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/GoButton");
                        public class GoButton_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/GoButton/Text");

                        }

                    }

                }
                public static GameObject DElements => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements");
                public class DElements_3
                {
                    public static GameObject LoadingBackground_TealGradient => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient");
                    public class LoadingBackground_TealGradient_4
                    {
                        public static GameObject _FX_ParticleBubbles => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/_FX_ParticleBubbles");
                        public class _FX_ParticleBubbles_5
                        {
                            public static GameObject FX_snow => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/_FX_ParticleBubbles/FX_snow");
                            public static GameObject FX_floor => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/_FX_ParticleBubbles/FX_floor");
                            public static GameObject FX_CloseParticles => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/_FX_ParticleBubbles/FX_CloseParticles");

                        }
                        public static GameObject SkyCube_Baked => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/SkyCube_Baked");
                        public static GameObject _Lighting_1 => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/_Lighting (1)");
                        public class _Lighting_1_5
                        {
                            public static GameObject Reflection_Probe => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/_Lighting (1)/Reflection Probe");
                            public static GameObject Point_light => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/_Lighting (1)/Point light");
                            public static GameObject Light_Probe_Group => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/_Lighting (1)/Light Probe Group");

                        }

                    }
                    public static GameObject LoadingInfoPanel => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel");
                    public class LoadingInfoPanel_4
                    {
                        public static GameObject InfoPanel_Template_ANIM => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel/InfoPanel_Template_ANIM");
                        public class InfoPanel_Template_ANIM_5
                        {
                            public static GameObject ICON => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel/InfoPanel_Template_ANIM/ICON");
                            public static GameObject SCREEN => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel/InfoPanel_Template_ANIM/SCREEN");
                            public static GameObject TITLE => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel/InfoPanel_Template_ANIM/TITLE");
                            public static GameObject LoadingSceen_2_Sstatic_colliders => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel/InfoPanel_Template_ANIM/LoadingSceen_2_Sstatic_colliders");

                        }

                    }

                }
                public static GameObject MirroredElements => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements");
                public class MirroredElements_3
                {
                    public static GameObject ButtonMiddle_1 => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/ButtonMiddle (1)");
                    public class ButtonMiddle_1_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/ButtonMiddle (1)/Text");

                    }
                    public static GameObject ProgressPanel_1 => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/ProgressPanel (1)");
                    public class ProgressPanel_1_4
                    {
                        public static GameObject Parent_Loading_Progress => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/ProgressPanel (1)/Parent_Loading_Progress");
                        public class Parent_Loading_Progress_5
                        {
                            public static GameObject Panel_Backdrop => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/ProgressPanel (1)/Parent_Loading_Progress/Panel_Backdrop");
                            public static GameObject Decoration_Left => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/ProgressPanel (1)/Parent_Loading_Progress/Decoration_Left");
                            public static GameObject Decoration_Right => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/ProgressPanel (1)/Parent_Loading_Progress/Decoration_Right");
                            public static GameObject Loading_Elements => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/ProgressPanel (1)/Parent_Loading_Progress/Loading Elements");
                            public static GameObject GoButton => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/ProgressPanel (1)/Parent_Loading_Progress/GoButton");

                        }

                    }
                    public static GameObject LoadingInfoPanel => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/LoadingInfoPanel");
                    public class LoadingInfoPanel_4
                    {
                        public static GameObject InfoPanel_Template_ANIM => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/LoadingInfoPanel/InfoPanel_Template_ANIM");
                        public class InfoPanel_Template_ANIM_5
                        {
                            public static GameObject ICON => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/LoadingInfoPanel/InfoPanel_Template_ANIM/ICON");
                            public static GameObject SCREEN => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/LoadingInfoPanel/InfoPanel_Template_ANIM/SCREEN");
                            public static GameObject TITLE => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/LoadingInfoPanel/InfoPanel_Template_ANIM/TITLE");
                            public static GameObject LoadingSceen_2_Sstatic_colliders => GameObject.Find("/UserInterface/MenuContent/Popups/LoadingPopup/MirroredElements/LoadingInfoPanel/InfoPanel_Template_ANIM/LoadingSceen_2_Sstatic_colliders");

                        }

                    }

                }

            }
            public static GameObject ReportWorldPopup => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup");
            public class ReportWorldPopup_2
            {
                public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Darkness");
                public static GameObject Popup => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup");
                public class Popup_3
                {
                    public static GameObject BorderImage => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/BorderImage");
                    public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Panel");
                    public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/TitleText");
                    public static GameObject ExitButton => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/ExitButton");
                    public static GameObject EmailText => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/EmailText");
                    public static GameObject Pages => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages");
                    public class Pages_4
                    {
                        public static GameObject Page1 => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/Page1");
                        public class Page1_5
                        {
                            public static GameObject Checkboxes => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/Page1/Checkboxes");
                            public static GameObject NextButton => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/Page1/NextButton");
                            public static GameObject WhereText => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/Page1/WhereText");

                        }
                        public static GameObject Page2 => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/Page2");
                        public class Page2_5
                        {
                            public static GameObject Checkboxes => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/Page2/Checkboxes");
                            public static GameObject SubmitButton => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/Page2/SubmitButton");
                            public static GameObject WhereCategoryText => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/Page2/WhereCategoryText");
                            public static GameObject WhyText => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/Page2/WhyText");

                        }
                        public static GameObject ThanksPage => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/ThanksPage");
                        public class ThanksPage_5
                        {
                            public static GameObject CloseButton => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/ThanksPage/CloseButton");
                            public static GameObject ThanksText => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/ThanksPage/ThanksText");
                            public static GameObject WarningText => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/ThanksPage/WarningText");

                        }
                        public static GameObject ErrorPage => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/ErrorPage");
                        public class ErrorPage_5
                        {
                            public static GameObject CloseButton => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/ErrorPage/CloseButton");
                            public static GameObject ErrorText => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/ErrorPage/ErrorText");

                        }
                        public static GameObject ResetPage => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/ResetPage");
                        public class ResetPage_5
                        {
                            public static GameObject CloseButton => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/ResetPage/CloseButton");
                            public static GameObject Reset_Report => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/ResetPage/Reset Report");
                            public static GameObject ResetText => GameObject.Find("/UserInterface/MenuContent/Popups/ReportWorldPopup/Popup/Pages/ResetPage/ResetText");

                        }

                    }

                }

            }
            public static GameObject RoomInfoPopup => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup");
            public class RoomInfoPopup_2
            {
                public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Darkness");
                public static GameObject Popup => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup");
                public class Popup_3
                {
                    public static GameObject BorderImage => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/BorderImage");
                    public static GameObject RoomPicture => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/RoomPicture");
                    public class RoomPicture_4
                    {
                        public static GameObject RoomImage => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/RoomPicture/RoomImage");
                        public static GameObject RoomBorder => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/RoomPicture/RoomBorder");

                    }
                    public static GameObject NameText => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/NameText");
                    public static GameObject AuthorText => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/AuthorText");
                    public static GameObject Buttons => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/Buttons");
                    public class Buttons_4
                    {
                        public static GameObject PortalButton => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/Buttons/PortalButton");
                        public class PortalButton_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/Buttons/PortalButton/Text");

                        }
                        public static GameObject JoinButton => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/Buttons/JoinButton");
                        public class JoinButton_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/Buttons/JoinButton/Text");

                        }
                        public static GameObject CloseButton => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/Buttons/CloseButton");
                        public class CloseButton_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/Buttons/CloseButton/Text");

                        }

                    }
                    public static GameObject ExitButton => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInfoPopup/Popup/ExitButton");

                }

            }
            public static GameObject RoomInstancePopup => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup");
            public class RoomInstancePopup_2
            {
                public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Darkness");
                public static GameObject Popup => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup");
                public class Popup_3
                {
                    public static GameObject BorderImage => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/BorderImage");
                    public static GameObject BorderImage_1 => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/BorderImage (1)");
                    public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Panel");
                    public static GameObject InstanceText => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/InstanceText");
                    public static GameObject NameText => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/NameText");
                    public static GameObject Buttons => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons");
                    public class Buttons_4
                    {
                        public static GameObject PublicButton => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/PublicButton");
                        public class PublicButton_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/PublicButton/Text");
                            public static GameObject PublicDescription => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/PublicButton/PublicDescription");

                        }
                        public static GameObject FriendsOfGuestsButton => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/FriendsOfGuestsButton");
                        public class FriendsOfGuestsButton_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/FriendsOfGuestsButton/Text");
                            public static GameObject FOGDescription => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/FriendsOfGuestsButton/FOGDescription");

                        }
                        public static GameObject FriendsOnlyButton => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/FriendsOnlyButton");
                        public class FriendsOnlyButton_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/FriendsOnlyButton/Text");
                            public static GameObject FriendsDescription => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/FriendsOnlyButton/FriendsDescription");

                        }
                        public static GameObject InvitePlusButton => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/InvitePlusButton");
                        public class InvitePlusButton_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/InvitePlusButton/Text");
                            public static GameObject InviteDescription => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/InvitePlusButton/InviteDescription");

                        }
                        public static GameObject InviteOnlyButton => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/InviteOnlyButton");
                        public class InviteOnlyButton_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/InviteOnlyButton/Text");
                            public static GameObject InviteDescription => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Buttons/InviteOnlyButton/InviteDescription");

                        }

                    }
                    public static GameObject ExitButton => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/ExitButton");
                    public static GameObject Region => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Region");
                    public static GameObject RegionInfoButton => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/RegionInfoButton");
                    public static GameObject Regions => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Regions");
                    public class Regions_4
                    {
                        public static GameObject Region_US_West => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Regions/Region_US_West");
                        public class Region_US_West_5
                        {
                            public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Regions/Region_US_West/Darkness");
                            public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Regions/Region_US_West/Background");
                            public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Regions/Region_US_West/Label");

                        }
                        public static GameObject Region_US_East => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Regions/Region_US_East");
                        public class Region_US_East_5
                        {
                            public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Regions/Region_US_East/Darkness");
                            public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Regions/Region_US_East/Background");
                            public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Regions/Region_US_East/Label");

                        }
                        public static GameObject Region_EU => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Regions/Region_EU");
                        public class Region_EU_5
                        {
                            public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Regions/Region_EU/Darkness");
                            public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Regions/Region_EU/Background");
                            public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Regions/Region_EU/Label");

                        }
                        public static GameObject Region_JP => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Regions/Region_JP");
                        public class Region_JP_5
                        {
                            public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Regions/Region_JP/Darkness");
                            public static GameObject Background => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Regions/Region_JP/Background");
                            public static GameObject Label => GameObject.Find("/UserInterface/MenuContent/Popups/RoomInstancePopup/Popup/Regions/Region_JP/Label");

                        }

                    }

                }

            }
            public static GameObject SearchOptionsPopup => GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup");
            public class SearchOptionsPopup_2
            {
                public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Darkness");
                public static GameObject Popup => GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup");
                public class Popup_3
                {
                    public static GameObject BorderImage => GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/BorderImage");
                    public static GameObject Panel_1 => GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/Panel (1)");
                    public static GameObject InstanceText => GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/InstanceText");
                    public static GameObject Checkboxes => GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/Checkboxes");
                    public class Checkboxes_4
                    {
                        public static GameObject Tags => GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/Checkboxes/Tags");
                        public class Tags_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/Checkboxes/Tags/Checkmark");
                            public static GameObject Description => GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/Checkboxes/Tags/Description");

                        }
                        public static GameObject Title => GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/Checkboxes/Title");
                        public class Title_5
                        {
                            public static GameObject Checkmark => GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/Checkboxes/Title/Checkmark");
                            public static GameObject Description => GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/Checkboxes/Title/Description");

                        }

                    }
                    public static GameObject ConfirmButton => GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/ConfirmButton");
                    public class ConfirmButton_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/ConfirmButton/Text");

                    }
                    public static GameObject ExitButton => GameObject.Find("/UserInterface/MenuContent/Popups/SearchOptionsPopup/Popup/ExitButton");

                }

            }
            public static GameObject StandardPopup => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup");
            public class StandardPopup_2
            {
                public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/Darkness");
                public static GameObject Rectangle => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/Rectangle");
                public static GameObject MidRing => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/MidRing");
                public static GameObject InnerDashRing => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/InnerDashRing");
                public static GameObject RingGlow => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/RingGlow");
                public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/TitleText");
                public static GameObject BodyText => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/BodyText");
                public static GameObject ArrowLeft => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/ArrowLeft");
                public static GameObject ArrowRight => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/ArrowRight");
                public static GameObject CornerBL => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/CornerBL");
                public static GameObject CornerTL => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/CornerTL");
                public static GameObject CornerBR => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/CornerBR");
                public static GameObject CornerTR => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/CornerTR");
                public static GameObject ProgressLine => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/ProgressLine");
                public static GameObject LowPercent => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/LowPercent");
                public static GameObject HighPercent => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/HighPercent");
                public static GameObject ButtonLeft => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/ButtonLeft");
                public class ButtonLeft_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/ButtonLeft/Text");

                }
                public static GameObject ButtonMiddle => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/ButtonMiddle");
                public class ButtonMiddle_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/ButtonMiddle/Text");

                }
                public static GameObject ButtonRight => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/ButtonRight");
                public class ButtonRight_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopup/ButtonRight/Text");

                }

            }
            public static GameObject StandardPopupV2 => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2");
            public class StandardPopupV2_2
            {
                public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Darkness");
                public static GameObject Popup => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup");
                public class Popup_3
                {
                    public static GameObject BorderImage => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/BorderImage");
                    public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/Panel");
                    public static GameObject ExitButton => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/ExitButton");
                    public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/TitleText");
                    public static GameObject InfoText => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/InfoText");
                    public static GameObject Buttons => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/Buttons");
                    public class Buttons_4
                    {
                        public static GameObject LeftButton => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/Buttons/LeftButton");
                        public class LeftButton_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/Buttons/LeftButton/Text");

                        }
                        public static GameObject MiddleButton => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/Buttons/MiddleButton");
                        public class MiddleButton_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/Buttons/MiddleButton/Text");

                        }
                        public static GameObject RightButton => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/Buttons/RightButton");
                        public class RightButton_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/StandardPopupV2/Popup/Buttons/RightButton/Text");

                        }

                    }

                }

            }
            public static GameObject ReportUserPopup => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup");
            public class ReportUserPopup_2
            {
                public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Darkness");
                public static GameObject Popup => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup");
                public class Popup_3
                {
                    public static GameObject BorderImage => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/BorderImage");
                    public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Panel");
                    public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/TitleText");
                    public static GameObject ExitButton => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/ExitButton");
                    public static GameObject EmailText => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/EmailText");
                    public static GameObject Pages => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages");
                    public class Pages_4
                    {
                        public static GameObject Page1 => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/Page1");
                        public class Page1_5
                        {
                            public static GameObject Checkboxes => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/Page1/Checkboxes");
                            public static GameObject NextButton => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/Page1/NextButton");
                            public static GameObject WhereText => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/Page1/WhereText");

                        }
                        public static GameObject Page2 => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/Page2");
                        public class Page2_5
                        {
                            public static GameObject Checkboxes => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/Page2/Checkboxes");
                            public static GameObject SubmitButton => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/Page2/SubmitButton");
                            public static GameObject WhereCategoryText => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/Page2/WhereCategoryText");
                            public static GameObject WhyText => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/Page2/WhyText");

                        }
                        public static GameObject ThanksPage => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/ThanksPage");
                        public class ThanksPage_5
                        {
                            public static GameObject CloseButton => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/ThanksPage/CloseButton");
                            public static GameObject ThanksText => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/ThanksPage/ThanksText");
                            public static GameObject WarningText => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/ThanksPage/WarningText");

                        }
                        public static GameObject ErrorPage => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/ErrorPage");
                        public class ErrorPage_5
                        {
                            public static GameObject CloseButton => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/ErrorPage/CloseButton");
                            public static GameObject ErrorText => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/ErrorPage/ErrorText");

                        }
                        public static GameObject ResetPage => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/ResetPage");
                        public class ResetPage_5
                        {
                            public static GameObject CloseButton => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/ResetPage/CloseButton");
                            public static GameObject ResetButton => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/ResetPage/ResetButton");
                            public static GameObject ResetText => GameObject.Find("/UserInterface/MenuContent/Popups/ReportUserPopup/Popup/Pages/ResetPage/ResetText");

                        }

                    }

                }

            }
            public static GameObject UpdateStatusPopup => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup");
            public class UpdateStatusPopup_2
            {
                public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Darkness");
                public static GameObject Popup => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup");
                public class Popup_3
                {
                    public static GameObject BorderImage => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/BorderImage");
                    public static GameObject BorderImage_1 => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/BorderImage (1)");
                    public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/Panel");
                    public static GameObject ExitButton => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/ExitButton");
                    public static GameObject StatusHistoryButton => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusHistoryButton");
                    public class StatusHistoryButton_4
                    {
                        public static GameObject Icon => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusHistoryButton/Icon");
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusHistoryButton/Text");

                    }
                    public static GameObject UpdateStatusTitleText => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/UpdateStatusTitleText");
                    public static GameObject InputFieldStatus => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/InputFieldStatus");
                    public class InputFieldStatus_4
                    {
                        public static GameObject Placeholder => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/InputFieldStatus/Placeholder");
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/InputFieldStatus/Text");

                    }
                    public static GameObject StatusSettings => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings");
                    public class StatusSettings_4
                    {
                        public static GameObject JoinMeStatus => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/JoinMeStatus");
                        public class JoinMeStatus_5
                        {
                            public static GameObject StatusIcon => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/JoinMeStatus/StatusIcon");
                            public static GameObject Description => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/JoinMeStatus/Description");
                            public static GameObject Highlight => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/JoinMeStatus/Highlight");

                        }
                        public static GameObject OnlineStatus => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/OnlineStatus");
                        public class OnlineStatus_5
                        {
                            public static GameObject StatusIcon => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/OnlineStatus/StatusIcon");
                            public static GameObject Description => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/OnlineStatus/Description");
                            public static GameObject Highlight => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/OnlineStatus/Highlight");

                        }
                        public static GameObject AskMeStatus => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/AskMeStatus");
                        public class AskMeStatus_5
                        {
                            public static GameObject StatusIcon => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/AskMeStatus/StatusIcon");
                            public static GameObject Description => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/AskMeStatus/Description");
                            public static GameObject Highlight => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/AskMeStatus/Highlight");

                        }
                        public static GameObject DoNotDisturbStatus => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/DoNotDisturbStatus");
                        public class DoNotDisturbStatus_5
                        {
                            public static GameObject StatusIcon => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/DoNotDisturbStatus/StatusIcon");
                            public static GameObject Description => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/DoNotDisturbStatus/Description");
                            public static GameObject Highlight => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/DoNotDisturbStatus/Highlight");

                        }
                        public static GameObject OfflineStatus => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/OfflineStatus");
                        public class OfflineStatus_5
                        {
                            public static GameObject StatusIcon => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/OfflineStatus/StatusIcon");
                            public static GameObject Description => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/OfflineStatus/Description");
                            public static GameObject Highlight => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/StatusSettings/OfflineStatus/Highlight");

                        }

                    }
                    public static GameObject Buttons => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/Buttons");
                    public class Buttons_4
                    {
                        public static GameObject UpdateButton => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/Buttons/UpdateButton");
                        public class UpdateButton_5
                        {
                            public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/UpdateStatusPopup/Popup/Buttons/UpdateButton/Text");

                        }

                    }

                }

            }
            public static GameObject RequestInvitePopup => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup");
            public class RequestInvitePopup_2
            {
                public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/Darkness");
                public static GameObject RequestInviteMenu => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu");
                public class RequestInviteMenu_3
                {
                    public static GameObject BorderImage => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/BorderImage");
                    public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/Panel");
                    public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/TitleText");
                    public static GameObject SubscribeToAddPhotosButton => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/SubscribeToAddPhotosButton");
                    public static GameObject AddPhotoOrImageAttachment => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/AddPhotoOrImageAttachment");
                    public class AddPhotoOrImageAttachment_4
                    {
                        public static GameObject PhotoToAttach => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/AddPhotoOrImageAttachment/PhotoToAttach");
                        public class PhotoToAttach_5
                        {
                            public static GameObject AddPhotoOrImageGroup => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/AddPhotoOrImageAttachment/PhotoToAttach/AddPhotoOrImageGroup");

                        }
                        public static GameObject AddPhotoBackground => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/AddPhotoOrImageAttachment/AddPhotoBackground");
                        public static GameObject AddGalleryImageGroup => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/AddPhotoOrImageAttachment/AddGalleryImageGroup");
                        public static GameObject VRCPlus => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/AddPhotoOrImageAttachment/VRC+");

                    }
                    public static GameObject AddMessageButton => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/AddMessageButton");
                    public class AddMessageButton_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/AddMessageButton/Text");
                        public static GameObject Icon_AddMessage => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/AddMessageButton/Icon_AddMessage");

                    }
                    public static GameObject EditMessageButton => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/EditMessageButton");
                    public class EditMessageButton_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/EditMessageButton/Text");
                        public static GameObject Icon_EditMessage => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/EditMessageButton/Icon_EditMessage");
                        public static GameObject ClearSelectedMessage => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/EditMessageButton/ClearSelectedMessage");
                        public class ClearSelectedMessage_5
                        {
                            public static GameObject Icon => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/EditMessageButton/ClearSelectedMessage/Icon");

                        }

                    }
                    public static GameObject SendButton => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/SendButton");
                    public class SendButton_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/SendButton/Text");

                    }
                    public static GameObject CancelButton => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/CancelButton");
                    public class CancelButton_4
                    {
                        public static GameObject Icon => GameObject.Find("/UserInterface/MenuContent/Popups/RequestInvitePopup/RequestInviteMenu/CancelButton/Icon");

                    }

                }

            }
            public static GameObject SendInvitePopup => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup");
            public class SendInvitePopup_2
            {
                public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/Darkness");
                public static GameObject SendInviteMenu => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/SendInviteMenu");
                public class SendInviteMenu_3
                {
                    public static GameObject BorderImage => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/SendInviteMenu/BorderImage");
                    public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/SendInviteMenu/Panel");
                    public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/SendInviteMenu/TitleText");
                    public static GameObject SubscribeToAddPhotosButton => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/SendInviteMenu/SubscribeToAddPhotosButton");
                    public static GameObject AddPhotoOrImageAttachment => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/SendInviteMenu/AddPhotoOrImageAttachment");
                    public class AddPhotoOrImageAttachment_4
                    {
                        public static GameObject PhotoToAttach => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/SendInviteMenu/AddPhotoOrImageAttachment/PhotoToAttach");
                        public class PhotoToAttach_5
                        {
                            public static GameObject AddPhotoOrImageGroup => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/SendInviteMenu/AddPhotoOrImageAttachment/PhotoToAttach/AddPhotoOrImageGroup");

                        }
                        public static GameObject AddPhotoBackground => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/SendInviteMenu/AddPhotoOrImageAttachment/AddPhotoBackground");
                        public static GameObject AddGalleryImageGroup => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/SendInviteMenu/AddPhotoOrImageAttachment/AddGalleryImageGroup");
                        public static GameObject VRCPlus => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/SendInviteMenu/AddPhotoOrImageAttachment/VRC+");

                    }
                    public static GameObject AddMessageButton => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/SendInviteMenu/AddMessageButton");
                    public class AddMessageButton_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/SendInviteMenu/AddMessageButton/Text");
                        public static GameObject Icon_AddMessage => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/SendInviteMenu/AddMessageButton/Icon_AddMessage");

                    }
                    public static GameObject EditMessageButton => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/SendInviteMenu/EditMessageButton");
                    public class EditMessageButton_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/SendInviteMenu/EditMessageButton/Text");
                        public static GameObject Icon_EditMessage => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/SendInviteMenu/EditMessageButton/Icon_EditMessage");
                        public static GameObject ClearSelectedMessage => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/SendInviteMenu/EditMessageButton/ClearSelectedMessage");
                        public class ClearSelectedMessage_5
                        {
                            public static GameObject Icon => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/SendInviteMenu/EditMessageButton/ClearSelectedMessage/Icon");

                        }

                    }
                    public static GameObject SendButton => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/SendInviteMenu/SendButton");
                    public class SendButton_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/SendInviteMenu/SendButton/Text");

                    }
                    public static GameObject CancelButton => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/SendInviteMenu/CancelButton");
                    public class CancelButton_4
                    {
                        public static GameObject Icon => GameObject.Find("/UserInterface/MenuContent/Popups/SendInvitePopup/SendInviteMenu/CancelButton/Icon");

                    }

                }

            }
            public static GameObject InputKeypadPopup => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup");
            public class InputKeypadPopup_2
            {
                public static GameObject Darkness => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/Darkness");
                public static GameObject Rectangle => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/Rectangle");
                public class Rectangle_3
                {
                    public static GameObject Panel => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/Rectangle/Panel");

                }
                public static GameObject TitleText => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/TitleText");
                public static GameObject InputField => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/InputField");
                public class InputField_3
                {
                    public static GameObject Placeholder => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/InputField/Placeholder");
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/InputField/Text");

                }
                public static GameObject Keyboard => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/Keyboard");
                public class Keyboard_3
                {
                    public static GameObject Keys => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/Keyboard/Keys");
                    public class Keys_4
                    {
                        public static GameObject Row_1 => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/Keyboard/Keys/Row 1");
                        public class Row_1_5
                        {
                            public static GameObject Row0_Column0 => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/Keyboard/Keys/Row 1/Row:0 Column:0");
                            public static GameObject Row0_Column1 => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/Keyboard/Keys/Row 1/Row:0 Column:1");
                            public static GameObject Row0_Column2 => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/Keyboard/Keys/Row 1/Row:0 Column:2");

                        }
                        public static GameObject Row_2 => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/Keyboard/Keys/Row 2");
                        public class Row_2_5
                        {
                            public static GameObject Row1_Column0 => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/Keyboard/Keys/Row 2/Row:1 Column:0");
                            public static GameObject Row1_Column1 => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/Keyboard/Keys/Row 2/Row:1 Column:1");
                            public static GameObject Row1_Column2 => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/Keyboard/Keys/Row 2/Row:1 Column:2");

                        }
                        public static GameObject Row_ => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/Keyboard/Keys/Row 3");
                        public class Row__5
                        {
                            public static GameObject Row2_Column0 => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/Keyboard/Keys/Row 3/Row:2 Column:0");
                            public static GameObject Row2_Column1 => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/Keyboard/Keys/Row 3/Row:2 Column:1");
                            public static GameObject Row2_Column2 => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/Keyboard/Keys/Row 3/Row:2 Column:2");

                        }
                        public static GameObject Row_4 => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/Keyboard/Keys/Row 4");
                        public class Row_4_5
                        {
                            public static GameObject Row_Column0 => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/Keyboard/Keys/Row 4/Row:3 Column:0");
                            public static GameObject Row_Column1 => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/Keyboard/Keys/Row 4/Row:3 Column:1");
                            public static GameObject Row_Column2 => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/Keyboard/Keys/Row 4/Row:3 Column:2");

                        }

                    }

                }
                public static GameObject ButtonLeft => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/ButtonLeft");
                public class ButtonLeft_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/ButtonLeft/Text");

                }
                public static GameObject ButtonRight => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/ButtonRight");
                public class ButtonRight_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/ButtonRight/Text");

                }
                public static GameObject ButtonCenter => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/ButtonCenter");
                public class ButtonCenter_3
                {
                    public static GameObject Text => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/ButtonCenter/Text");

                }
                public static GameObject PasswordVisibilityToggle => GameObject.Find("/UserInterface/MenuContent/Popups/InputKeypadPopup/PasswordVisibilityToggle");

            }

        }
        public static GameObject Interupts => GameObject.Find("/UserInterface/MenuContent/Interupts");
        public static GameObject MenuAudio => GameObject.Find("/UserInterface/MenuContent/MenuAudio");
    }
    public class QuickMenuContent
    {
        public static GameObject Container => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container");
        public class Container_1
        {
            public static GameObject Back_Window => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Back Window");
            public class Back_Window_2
            {
                public static GameObject Background => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Back Window/Background");
                public static GameObject Logo => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Back Window/Logo");

            }
            public static GameObject ThankYouCharacter => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/ThankYouCharacter");
            public class ThankYouCharacter_2
            {
                public static GameObject Character => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/ThankYouCharacter/Character");
                public class Character_3
                {
                    public static GameObject VRCat_Back => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/ThankYouCharacter/Character/VRCat_Back");
                    public static GameObject VRCat_Front => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/ThankYouCharacter/Character/VRCat_Front");

                }
                public static GameObject Dialog_Bubble => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/ThankYouCharacter/Dialog Bubble");
                public class Dialog_Bubble_3
                {
                    public static GameObject Bubble => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/ThankYouCharacter/Dialog Bubble/Bubble");
                    public class Bubble_4
                    {
                        public static GameObject Text => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/ThankYouCharacter/Dialog Bubble/Bubble/Text");

                    }

                }

            }
            public static GameObject Window => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window");
            public class Window_2
            {
                public static GameObject Wing_Left => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Left");
                public class Wing_Left_3
                {
                    public static GameObject Button => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Left/Button");
                    public class Button_4
                    {
                        public static GameObject Icon => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Left/Button/Icon");

                    }
                    public static GameObject Container => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Left/Container");
                    public class Container_4
                    {
                        public static GameObject InnerContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Left/Container/InnerContainer");
                        public class InnerContainer_5
                        {
                            public static GameObject Background => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Left/Container/InnerContainer/Background");
                            public static GameObject WingMenu => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Left/Container/InnerContainer/WingMenu");
                            public static GameObject Emoji => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Left/Container/InnerContainer/Emoji");
                            public static GameObject Wing_EmojisFilter => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Left/Container/InnerContainer/Wing_EmojisFilter");
                            public static GameObject Emotes => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Left/Container/InnerContainer/Emotes");
                            public static GameObject Explore => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Left/Container/InnerContainer/Explore");
                            public static GameObject Avatars => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Left/Container/InnerContainer/Avatars");
                            public static GameObject Wing_AvatarsFilter => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Left/Container/InnerContainer/Wing_AvatarsFilter");
                            public static GameObject Friends => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Left/Container/InnerContainer/Friends");
                            public static GameObject Wing_FriendsFilter => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Left/Container/InnerContainer/Wing_FriendsFilter");
                            public static GameObject Profile => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Left/Container/InnerContainer/Profile");
                            public static GameObject Wing_Menu_Worlds => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Left/Container/InnerContainer/Wing_Menu_Worlds");
                            public static GameObject Wing_Menu_Worlds_Filter => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Left/Container/InnerContainer/Wing_Menu_Worlds_Filter");

                        }

                    }

                }
                public static GameObject Wing_Right => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right");
                public class Wing_Right_3
                {
                    public static GameObject Button => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Button");
                    public class Button_4
                    {
                        public static GameObject Icon => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Button/Icon");

                    }
                    public static GameObject Container => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Container");
                    public class Container_4
                    {
                        public static GameObject InnerContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Container/InnerContainer");
                        public class InnerContainer_5
                        {
                            public static GameObject Background => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Container/InnerContainer/Background");
                            public static GameObject WingMenu => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Container/InnerContainer/WingMenu");
                            public static GameObject Emoji => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Container/InnerContainer/Emoji");
                            public static GameObject Wing_EmojisFilter => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Container/InnerContainer/Wing_EmojisFilter");
                            public static GameObject Emotes => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Container/InnerContainer/Emotes");
                            public static GameObject Explore => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Container/InnerContainer/Explore");
                            public static GameObject Friends => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Container/InnerContainer/Friends");
                            public static GameObject Wing_FriendsFilter => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Container/InnerContainer/Wing_FriendsFilter");
                            public static GameObject Avatars => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Container/InnerContainer/Avatars");
                            public static GameObject Wing_AvatarsFilter => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Container/InnerContainer/Wing_AvatarsFilter");
                            public static GameObject Profile => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Container/InnerContainer/Profile");
                            public static GameObject Wing_Menu_Worlds => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Container/InnerContainer/Wing_Menu_Worlds");
                            public static GameObject Wing_Menu_Worlds_Filter => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Wing_Right/Container/InnerContainer/Wing_Menu_Worlds_Filter");

                        }

                    }

                }
                public static GameObject QMNotificationsArea => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea");
                public class QMNotificationsArea_3
                {
                    public static GameObject Notifications => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/Notifications");
                    public class Notifications_4
                    {
                        public static GameObject SocialNotificationsOverlay => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/Notifications/SocialNotificationsOverlay");
                        public class SocialNotificationsOverlay_5
                        {
                            public static GameObject AvatarButton0 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/Notifications/SocialNotificationsOverlay/AvatarButton0");
                            public static GameObject AvatarButton1 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/Notifications/SocialNotificationsOverlay/AvatarButton1");
                            public static GameObject AvatarButton2 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/Notifications/SocialNotificationsOverlay/AvatarButton2");
                            public static GameObject AvatarButton => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/Notifications/SocialNotificationsOverlay/AvatarButton3");

                        }

                    }
                    public static GameObject DebugInfoPanel => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/DebugInfoPanel");
                    public class DebugInfoPanel_4
                    {
                        public static GameObject Panel => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/DebugInfoPanel/Panel");
                        public class Panel_5
                        {
                            public static GameObject Background => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/DebugInfoPanel/Panel/Background");
                            public static GameObject Text_FPS => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/DebugInfoPanel/Panel/Text_FPS");
                            public static GameObject Text_Ping => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/DebugInfoPanel/Panel/Text_Ping");

                        }

                    }
                    public static GameObject Header_SafeMode => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/Header_SafeMode");
                    public class Header_SafeMode_4
                    {
                        public static GameObject Header => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/Header_SafeMode/Header");
                        public class Header_5
                        {
                            public static GameObject HeaderBackground => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/Header_SafeMode/Header/HeaderBackground");
                            public static GameObject LeftItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/Header_SafeMode/Header/LeftItemContainer");
                            public static GameObject RightItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/Header_SafeMode/Header/RightItemContainer");

                        }

                    }
                    public static GameObject Header_StreamerMode => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/Header_StreamerMode");
                    public class Header_StreamerMode_4
                    {
                        public static GameObject Header => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/Header_StreamerMode/Header");
                        public class Header_5
                        {
                            public static GameObject HeaderBackground => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/Header_StreamerMode/Header/HeaderBackground");
                            public static GameObject LeftItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/Header_StreamerMode/Header/LeftItemContainer");
                            public static GameObject RightItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMNotificationsArea/Header_StreamerMode/Header/RightItemContainer");

                        }

                    }

                }
                public static GameObject Page_Buttons_QM => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM");
                public class Page_Buttons_QM_3
                {
                    public static GameObject HorizontalLayoutGroup => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup");
                    public class HorizontalLayoutGroup_4
                    {
                        public static GameObject Background_QM_PagePanel => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Background_QM_PagePanel");
                        public static GameObject Page_Dashboard => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Dashboard");
                        public class Page_Dashboard_5
                        {
                            public static GameObject Badge => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Dashboard/Badge");
                            public static GameObject Background => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Dashboard/Background");
                            public static GameObject Icon => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Dashboard/Icon");

                        }
                        public static GameObject Page_Notifications => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Notifications");
                        public class Page_Notifications_5
                        {
                            public static GameObject Badge => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Notifications/Badge");
                            public static GameObject Background => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Notifications/Background");
                            public static GameObject Icon => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Notifications/Icon");

                        }
                        public static GameObject Page_Here => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Here");
                        public class Page_Here_5
                        {
                            public static GameObject Badge => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Here/Badge");
                            public static GameObject Background => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Here/Background");
                            public static GameObject Icon => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Here/Icon");

                        }
                        public static GameObject Page_Camera => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Camera");
                        public class Page_Camera_5
                        {
                            public static GameObject Badge => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Camera/Badge");
                            public static GameObject Background => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Camera/Background");
                            public static GameObject Icon => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Camera/Icon");

                        }
                        public static GameObject Page_AudioSettings => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_AudioSettings");
                        public class Page_AudioSettings_5
                        {
                            public static GameObject Badge => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_AudioSettings/Badge");
                            public static GameObject Background => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_AudioSettings/Background");
                            public static GameObject Icon => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_AudioSettings/Icon");

                        }
                        public static GameObject Page_Settings => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Settings");
                        public class Page_Settings_5
                        {
                            public static GameObject Badge => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Settings/Badge");
                            public static GameObject Background => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Settings/Background");
                            public static GameObject Icon => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_Settings/Icon");

                        }
                        public static GameObject Page_DevTools => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_DevTools");
                        public class Page_DevTools_5
                        {
                            public static GameObject Badge => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_DevTools/Badge");
                            public static GameObject Background => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_DevTools/Background");
                            public static GameObject Icon => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Page_Buttons_QM/HorizontalLayoutGroup/Page_DevTools/Icon");

                        }

                    }

                }
                public static GameObject QMParent => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent");
                public class QMParent_3
                {
                    public static GameObject BackgroundLayer01 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/BackgroundLayer01");
                    public static GameObject BackgroundLayer02 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/BackgroundLayer02");
                    public static GameObject MenuControllers => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/MenuControllers");
                    public class MenuControllers_4
                    {
                        public static GameObject SelectedUserMenuController => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/MenuControllers/SelectedUserMenuController");

                    }
                    public static GameObject Menu_Dashboard => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard");
                    public class Menu_Dashboard_4
                    {
                        public static GameObject Header_H1 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/Header_H1");
                        public class Header_H1_5
                        {
                            public static GameObject HeaderBackground => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/Header_H1/HeaderBackground");
                            public static GameObject LeftItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/Header_H1/LeftItemContainer");
                            public static GameObject RightItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/Header_H1/RightItemContainer");

                        }
                        public static GameObject ScrollRect => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect");
                        public class ScrollRect_5
                        {
                            public static GameObject Viewport => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Viewport");
                            public static GameObject Scrollbar => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Dashboard/ScrollRect/Scrollbar");

                        }

                    }
                    public static GameObject Menu_Notifications => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Notifications");
                    public class Menu_Notifications_4
                    {
                        public static GameObject QMHeader_H1 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Notifications/QMHeader_H1");
                        public class QMHeader_H1_5
                        {
                            public static GameObject HeaderBackground => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Notifications/QMHeader_H1/HeaderBackground");
                            public static GameObject LeftItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Notifications/QMHeader_H1/LeftItemContainer");
                            public static GameObject RightItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Notifications/QMHeader_H1/RightItemContainer");

                        }
                        public static GameObject Panel_Notification_Tabs => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Notifications/Panel_Notification_Tabs");
                        public class Panel_Notification_Tabs_5
                        {
                            public static GameObject Tabs => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Notifications/Panel_Notification_Tabs/Tabs");
                            public static GameObject Button_ClearNotifications => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Notifications/Panel_Notification_Tabs/Button_ClearNotifications");
                            public static GameObject Button_HideInvitePhotos => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Notifications/Panel_Notification_Tabs/Button_HideInvitePhotos");

                        }
                        public static GameObject Panel_NoNotifications_Message => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Notifications/Panel_NoNotifications_Message");
                        public class Panel_NoNotifications_Message_5
                        {
                            public static GameObject Icon => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Notifications/Panel_NoNotifications_Message/Icon");

                        }
                        public static GameObject Panel_Content => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Notifications/Panel_Content");
                        public class Panel_Content_5
                        {
                            public static GameObject Invites => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Notifications/Panel_Content/Invites");
                            public static GameObject Friend_Requests => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Notifications/Panel_Content/Friend Requests");
                            public static GameObject Other => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Notifications/Panel_Content/Other");

                        }

                    }
                    public static GameObject Menu_Camera => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Camera");
                    public class Menu_Camera_4
                    {
                        public static GameObject Header_Camera => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Camera/Header_Camera");
                        public class Header_Camera_5
                        {
                            public static GameObject HeaderBackground => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Camera/Header_Camera/HeaderBackground");
                            public static GameObject LeftItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Camera/Header_Camera/LeftItemContainer");
                            public static GameObject RightItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Camera/Header_Camera/RightItemContainer");

                        }
                        public static GameObject Scrollrect => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Camera/Scrollrect");
                        public class Scrollrect_5
                        {
                            public static GameObject Viewport => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Camera/Scrollrect/Viewport");
                            public static GameObject Scrollbar => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Camera/Scrollrect/Scrollbar");

                        }
                        public static GameObject Panel_Info => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Camera/Panel_Info");
                        public class Panel_Info_5
                        {
                            public static GameObject Icon_Info => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Camera/Panel_Info/Icon_Info");
                            public static GameObject Text_H4 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Camera/Panel_Info/Text_H4");

                        }

                    }
                    public static GameObject Menu_Here => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Here");
                    public class Menu_Here_4
                    {
                        public static GameObject QMHeader_H1 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Here/QMHeader_H1");
                        public class QMHeader_H1_5
                        {
                            public static GameObject HeaderBackground => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Here/QMHeader_H1/HeaderBackground");
                            public static GameObject LeftItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Here/QMHeader_H1/LeftItemContainer");
                            public static GameObject RightItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Here/QMHeader_H1/RightItemContainer");

                        }
                        public static GameObject ScrollRect => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Here/ScrollRect");
                        public class ScrollRect_5
                        {
                            public static GameObject Viewport => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Here/ScrollRect/Viewport");
                            public static GameObject Scrollbar => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Here/ScrollRect/Scrollbar");

                        }

                    }
                    public static GameObject Menu_Settings => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Settings");
                    public class Menu_Settings_4
                    {
                        public static GameObject QMHeader_H1 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Settings/QMHeader_H1");
                        public class QMHeader_H1_5
                        {
                            public static GameObject HeaderBackground => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Settings/QMHeader_H1/HeaderBackground");
                            public static GameObject LeftItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Settings/QMHeader_H1/LeftItemContainer");
                            public static GameObject RightItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Settings/QMHeader_H1/RightItemContainer");

                        }
                        public static GameObject Panel_QM_ScrollRect => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect");
                        public class Panel_QM_ScrollRect_5
                        {
                            public static GameObject Viewport => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Viewport");
                            public static GameObject Scrollbar => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_Settings/Panel_QM_ScrollRect/Scrollbar");

                        }

                    }
                    public static GameObject Menu_AudioSettings => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_AudioSettings");
                    public class Menu_AudioSettings_4
                    {
                        public static GameObject QMHeader_H1 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_AudioSettings/QMHeader_H1");
                        public class QMHeader_H1_5
                        {
                            public static GameObject HeaderBackground => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_AudioSettings/QMHeader_H1/HeaderBackground");
                            public static GameObject LeftItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_AudioSettings/QMHeader_H1/LeftItemContainer");
                            public static GameObject RightItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_AudioSettings/QMHeader_H1/RightItemContainer");

                        }
                        public static GameObject Content => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_AudioSettings/Content");
                        public class Content_5
                        {
                            public static GameObject Header_H2 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_AudioSettings/Content/Header_H2");
                            public static GameObject Audio => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_AudioSettings/Content/Audio");
                            public static GameObject Header_H2_1 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_AudioSettings/Content/Header_H2 (1)");
                            public static GameObject Mic => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_AudioSettings/Content/Mic");

                        }

                    }
                    public static GameObject Menu_QM_Emojis => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Emojis");
                    public class Menu_QM_Emojis_4
                    {
                        public static GameObject Header_Emojis => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Emojis/Header_Emojis");
                        public class Header_Emojis_5
                        {
                            public static GameObject HeaderBackground => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Emojis/Header_Emojis/HeaderBackground");
                            public static GameObject LeftItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Emojis/Header_Emojis/LeftItemContainer");
                            public static GameObject RightItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Emojis/Header_Emojis/RightItemContainer");

                        }
                        public static GameObject ScrollRect => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Emojis/ScrollRect");
                        public class ScrollRect_5
                        {
                            public static GameObject Viewport => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Emojis/ScrollRect/Viewport");
                            public static GameObject Scrollbar => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Emojis/ScrollRect/Scrollbar");

                        }

                    }
                    public static GameObject Menu_DevTools => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_DevTools");
                    public class Menu_DevTools_4
                    {
                        public static GameObject Header_DevTools => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_DevTools/Header_DevTools");
                        public class Header_DevTools_5
                        {
                            public static GameObject HeaderBackground => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_DevTools/Header_DevTools/HeaderBackground");
                            public static GameObject LeftItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_DevTools/Header_DevTools/LeftItemContainer");
                            public static GameObject RightItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_DevTools/Header_DevTools/RightItemContainer");

                        }
                        public static GameObject Scrollrect => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_DevTools/Scrollrect");
                        public class Scrollrect_5
                        {
                            public static GameObject Viewport => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_DevTools/Scrollrect/Viewport");
                            public static GameObject Scrollbar => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_DevTools/Scrollrect/Scrollbar");

                        }

                    }
                    public static GameObject Menu_SelectedUser_Local => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Local");
                    public class Menu_SelectedUser_Local_4
                    {
                        public static GameObject ScrollRect => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Local/ScrollRect");
                        public class ScrollRect_5
                        {
                            public static GameObject Viewport => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Local/ScrollRect/Viewport");
                            public static GameObject Scrollbar => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Local/ScrollRect/Scrollbar");

                        }
                        public static GameObject Header_H1 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Local/Header_H1");
                        public class Header_H1_5
                        {
                            public static GameObject HeaderBackground => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Local/Header_H1/HeaderBackground");
                            public static GameObject LeftItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Local/Header_H1/LeftItemContainer");
                            public static GameObject RightItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Local/Header_H1/RightItemContainer");

                        }

                    }
                    public static GameObject Menu_SelectedUser_Remote => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Remote");
                    public class Menu_SelectedUser_Remote_4
                    {
                        public static GameObject Header_H1 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Remote/Header_H1");
                        public class Header_H1_5
                        {
                            public static GameObject HeaderBackground => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Remote/Header_H1/HeaderBackground");
                            public static GameObject LeftItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Remote/Header_H1/LeftItemContainer");
                            public static GameObject RightItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Remote/Header_H1/RightItemContainer");

                        }
                        public static GameObject ScrollRect => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Remote/ScrollRect");
                        public class ScrollRect_5
                        {
                            public static GameObject Viewport => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Remote/ScrollRect/Viewport");
                            public static GameObject Scrollbar => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_SelectedUser_Remote/ScrollRect/Scrollbar");

                        }

                    }
                    public static GameObject Menu_InviteResponse => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_InviteResponse");
                    public class Menu_InviteResponse_4
                    {
                        public static GameObject Header_H1 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_InviteResponse/Header_H1");
                        public class Header_H1_5
                        {
                            public static GameObject HeaderBackground => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_InviteResponse/Header_H1/HeaderBackground");
                            public static GameObject LeftItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_InviteResponse/Header_H1/LeftItemContainer");
                            public static GameObject RightItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_InviteResponse/Header_H1/RightItemContainer");

                        }
                        public static GameObject ScrollRect => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_InviteResponse/ScrollRect");
                        public class ScrollRect_5
                        {
                            public static GameObject Viewport => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_InviteResponse/ScrollRect/Viewport");
                            public static GameObject Scrollbar => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_InviteResponse/ScrollRect/Scrollbar");

                        }

                    }
                    public static GameObject Menu_QM_Gallery => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Gallery");
                    public class Menu_QM_Gallery_4
                    {
                        public static GameObject Header_H1 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Gallery/Header_H1");
                        public class Header_H1_5
                        {
                            public static GameObject HeaderBackground => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Gallery/Header_H1/HeaderBackground");
                            public static GameObject LeftItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Gallery/Header_H1/LeftItemContainer");
                            public static GameObject RightItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Gallery/Header_H1/RightItemContainer");

                        }
                        public static GameObject ScrollRect => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Gallery/ScrollRect");
                        public class ScrollRect_5
                        {
                            public static GameObject Viewport => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Gallery/ScrollRect/Viewport");
                            public static GameObject Scrollbar => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Gallery/ScrollRect/Scrollbar");

                        }

                    }
                    public static GameObject Menu_QM_Report_Issue => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Report_Issue");
                    public class Menu_QM_Report_Issue_4
                    {
                        public static GameObject Panel => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Report_Issue/Panel");
                        public class Panel_5
                        {
                            public static GameObject Background_Modal => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Report_Issue/Panel/Background_Modal");
                            public static GameObject Header_QM_Modal_H1 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Report_Issue/Panel/Header_QM_Modal_H1");
                            public static GameObject Header_H2 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Report_Issue/Panel/Header_H2");
                            public static GameObject Panel_QM_ScrollRect => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Report_Issue/Panel/Panel_QM_ScrollRect");
                            public static GameObject Panel_Button_Submit => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Report_Issue/Panel/Panel_Button_Submit");
                            public static GameObject Text_MM_H_1 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Report_Issue/Panel/Text_MM_H3 (1)");

                        }

                    }
                    public static GameObject Menu_QM_Report_Details => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Report_Details");
                    public class Menu_QM_Report_Details_4
                    {
                        public static GameObject Panel => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Report_Details/Panel");
                        public class Panel_5
                        {
                            public static GameObject Background_Modal => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Report_Details/Panel/Background_Modal");
                            public static GameObject Header_QM_Modal_H1 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Report_Details/Panel/Header_QM_Modal_H1");
                            public static GameObject Header_H2 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Report_Details/Panel/Header_H2");
                            public static GameObject Panel_QM_ScrollRect => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Report_Details/Panel/Panel_QM_ScrollRect");
                            public static GameObject Panel_Button_Submit => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Report_Details/Panel/Panel_Button_Submit");
                            public static GameObject Text_MM_H_1 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_Report_Details/Panel/Text_MM_H3 (1)");

                        }

                    }
                    public static GameObject Menu_QM_GiftVRCPlus => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_GiftVRCPlus");
                    public class Menu_QM_GiftVRCPlus_4
                    {
                        public static GameObject Background_Scrim => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_GiftVRCPlus/Background_Scrim");
                        public static GameObject Container => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_GiftVRCPlus/Container");
                        public class Container_5
                        {
                            public static GameObject Header => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_GiftVRCPlus/Container/Header");
                            public static GameObject ScrollRect => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_QM_GiftVRCPlus/Container/ScrollRect");

                        }

                    }
                    public static GameObject Menu_UserIconCamera => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_UserIconCamera");
                    public class Menu_UserIconCamera_4
                    {
                        public static GameObject Header_H1 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_UserIconCamera/Header_H1");
                        public class Header_H1_5
                        {
                            public static GameObject HeaderBackground => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_UserIconCamera/Header_H1/HeaderBackground");
                            public static GameObject LeftItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_UserIconCamera/Header_H1/LeftItemContainer");
                            public static GameObject RightItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_UserIconCamera/Header_H1/RightItemContainer");

                        }
                        public static GameObject ScrollRect => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_UserIconCamera/ScrollRect");
                        public class ScrollRect_5
                        {
                            public static GameObject Viewport => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_UserIconCamera/ScrollRect/Viewport");
                            public static GameObject Scrollbar => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_UserIconCamera/ScrollRect/Scrollbar");

                        }
                        public static GameObject MaxIcons => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_UserIconCamera/MaxIcons");
                        public class MaxIcons_5
                        {
                            public static GameObject Panel_MaxIconsText => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_UserIconCamera/MaxIcons/Panel_MaxIconsText");
                            public static GameObject Button_ManageIcons => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_UserIconCamera/MaxIcons/Button_ManageIcons");

                        }
                        public static GameObject MaxImages => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_UserIconCamera/MaxImages");
                        public class MaxImages_5
                        {
                            public static GameObject Panel_MaxImagesText => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_UserIconCamera/MaxImages/Panel_MaxImagesText");
                            public static GameObject Button_ManageImages => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_UserIconCamera/MaxImages/Button_ManageImages");

                        }
                        public static GameObject Camera => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_UserIconCamera/Camera");

                    }
                    public static GameObject Menu_ChangeAudioInputDevice => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_ChangeAudioInputDevice");
                    public class Menu_ChangeAudioInputDevice_4
                    {
                        public static GameObject Header_H1 => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_ChangeAudioInputDevice/Header_H1");
                        public class Header_H1_5
                        {
                            public static GameObject HeaderBackground => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_ChangeAudioInputDevice/Header_H1/HeaderBackground");
                            public static GameObject LeftItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_ChangeAudioInputDevice/Header_H1/LeftItemContainer");
                            public static GameObject RightItemContainer => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_ChangeAudioInputDevice/Header_H1/RightItemContainer");

                        }
                        public static GameObject ScrollRect => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_ChangeAudioInputDevice/ScrollRect");
                        public class ScrollRect_5
                        {
                            public static GameObject Viewport => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_ChangeAudioInputDevice/ScrollRect/Viewport");
                            public static GameObject Scrollbar => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/QMParent/Menu_ChangeAudioInputDevice/ScrollRect/Scrollbar");

                        }

                    }

                }
                public static GameObject ToolTipPanel => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/ToolTipPanel");
                public class ToolTipPanel_3
                {
                    public static GameObject Panel => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/ToolTipPanel/Panel");
                    public class Panel_4
                    {
                        public static GameObject Text_H => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/ToolTipPanel/Panel/Text_H3");

                    }

                }
                public static GameObject MicButton => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/MicButton");
                public class MicButton_3
                {
                    public static GameObject Icon => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/MicButton/Icon");

                }
                public static GameObject NewFeatureCallouts => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/NewFeatureCallouts");
                public class NewFeatureCallouts_3
                {
                    public static GameObject Panel_QM_Callout_Wing => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/NewFeatureCallouts/Panel_QM_Callout_Wing");
                    public class Panel_QM_Callout_Wing_4
                    {
                        public static GameObject Panel => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/NewFeatureCallouts/Panel_QM_Callout_Wing/Panel");
                        public class Panel_5
                        {
                            public static GameObject Text_H => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/NewFeatureCallouts/Panel_QM_Callout_Wing/Panel/Text_H3");

                        }
                        public static GameObject Button_Close => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/NewFeatureCallouts/Panel_QM_Callout_Wing/Button_Close");
                        public class Button_Close_5
                        {
                            public static GameObject Icon => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/NewFeatureCallouts/Panel_QM_Callout_Wing/Button_Close/Icon");

                        }
                        public static GameObject NewIcon => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/NewFeatureCallouts/Panel_QM_Callout_Wing/NewIcon");
                        public class NewIcon_5
                        {
                            public static GameObject NotificationsText => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/NewFeatureCallouts/Panel_QM_Callout_Wing/NewIcon/NotificationsText");

                        }

                    }
                    public static GameObject Panel_QM_Callout_SelectUser => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/NewFeatureCallouts/Panel_QM_Callout_SelectUser");
                    public class Panel_QM_Callout_SelectUser_4
                    {
                        public static GameObject Panel => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/NewFeatureCallouts/Panel_QM_Callout_SelectUser/Panel");
                        public class Panel_5
                        {
                            public static GameObject Text_H => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/NewFeatureCallouts/Panel_QM_Callout_SelectUser/Panel/Text_H3");

                        }
                        public static GameObject Button_Close => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/NewFeatureCallouts/Panel_QM_Callout_SelectUser/Button_Close");
                        public class Button_Close_5
                        {
                            public static GameObject Icon => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/NewFeatureCallouts/Panel_QM_Callout_SelectUser/Button_Close/Icon");

                        }
                        public static GameObject NewIcon => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/NewFeatureCallouts/Panel_QM_Callout_SelectUser/NewIcon");
                        public class NewIcon_5
                        {
                            public static GameObject NotificationsText => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/NewFeatureCallouts/Panel_QM_Callout_SelectUser/NewIcon/NotificationsText");

                        }

                    }
                    public static GameObject Panel_QM_Callout_AvInteractCycle => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/NewFeatureCallouts/Panel_QM_Callout_AvInteractCycle");
                    public class Panel_QM_Callout_AvInteractCycle_4
                    {
                        public static GameObject Panel => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/NewFeatureCallouts/Panel_QM_Callout_AvInteractCycle/Panel");
                        public class Panel_5
                        {
                            public static GameObject Text_H => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/NewFeatureCallouts/Panel_QM_Callout_AvInteractCycle/Panel/Text_H3");

                        }
                        public static GameObject Button_Close => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/NewFeatureCallouts/Panel_QM_Callout_AvInteractCycle/Button_Close");
                        public class Button_Close_5
                        {
                            public static GameObject Icon => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/NewFeatureCallouts/Panel_QM_Callout_AvInteractCycle/Button_Close/Icon");

                        }
                        public static GameObject NewIcon => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/NewFeatureCallouts/Panel_QM_Callout_AvInteractCycle/NewIcon");
                        public class NewIcon_5
                        {
                            public static GameObject NotificationsText => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/NewFeatureCallouts/Panel_QM_Callout_AvInteractCycle/NewIcon/NotificationsText");

                        }

                    }

                }
                public static GameObject Toggle_SafeMode => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Toggle_SafeMode");
                public class Toggle_SafeMode_3
                {
                    public static GameObject Icon => GameObject.Find("/UserInterface/Canvas_QuickMenu(Clone)/Container/Window/Toggle_SafeMode/Icon");

                }

            }

        }
    }
}