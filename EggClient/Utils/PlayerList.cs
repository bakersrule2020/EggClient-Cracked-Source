using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using EggClient.Extentions;
using EggClient.Wrapper;



namespace ReModCE.Components
{




    internal class PlayersListComponent
    {
        private bool PlayerListEnabled;
    
        private QMLablePlayer playerList;

        public PlayersListComponent()
        {
            PlayerListEnabled = new ConfigValue<bool>(nameof(PlayerListEnabled), false);
            PlayerListEnabled.OnValueChanged += () => _playerListToggle.Toggle(PlayerListEnabled);
        }

        public override void OnUiManagerInit(UiManager uiManager)
        {
            base.OnUiManagerInit(uiManager);

            var menu = uiManager.MainMenu.GetCategoryPage("Utility").AddCategory("Players");
            _playerListToggle = menu.AddToggle("Player List",
                "Enable/Disable player List", TogglePlayerList,
                PlayerListEnabled);

            playerList = new QMLablePlayer(QuickMenuEx.LeftWing.field_Public_Button_0.transform, 609.902f, 457.9203f, "PlayerList");
            DrawOverlay();
        }

        public void DrawOverlay()
        {
            if (PlayerListEnabled)
            {
                playerList.lable.SetActive(true);
                playerList.lable.transform.localPosition = new Vector3(-106.6402f, -30f, 0f);
                playerList.text.enableWordWrapping = false;
                playerList.text.fontSizeMin = 30f;
                playerList.text.fontSizeMax = 30f;
                playerList.text.alignment = TextAlignmentOptions.Right;
                playerList.text.color = Color.white;
                //debugLog.lable.transform.localPosition = new Vector3(609.902f, 457.9203f, 0);
                //debugLog.text.enableWordWrapping = false;
                //debugLog.text.fontSizeMin = 30;
                //debugLog.text.fontSizeMax = 30;
                //debugLog.text.alignment = TMPro.TextAlignmentOptions.Left;
                //debugLog.text.verticalAlignment = TMPro.VerticalAlignmentOptions.Top;
                //debugLog.text.color = Color.white;
            }
            else
            {
                playerList.lable.SetActive(false);
            }
        }

        public void TogglePlayerList(bool value)
        {
            PlayerListEnabled.SetValue(value);
            DrawOverlay();
        }
        private byte frames;
        private byte ping;
        private int noUpdateCount = 0;
        public static void OnUpdate()
        {
            try
            {
                if (PlayerListEnabled)
                {
                    string text = "";
                    for (int i = 0; i < Extensions.GetAllPlayers().Count; i++)
                    {

                        VRC.Player player = Wrapper.GetAllPlayers()[i];

                        if (frames == player._playerNet.field_Private_Byte_0 && ping == player._playerNet.field_Private_Byte_1)
                        {
                            noUpdateCount++;
                        }
                        else
                        {
                            noUpdateCount = 0;
                        }

                        frames = player._playerNet.field_Private_Byte_0;
                        ping = player._playerNet.field_Private_Byte_1;


                        if (player.GetIsMaster())
                        {
                            text += " [<color=#FFB300>H</color>]";
                        }
                        string textStatus = "<color=green>Stable</color>";
                        if (noUpdateCount > 30)
                            textStatus = "<color=yellow>Lagging</color>";
                        if (noUpdateCount > 150)
                            textStatus = "<color=red>Crashed</color>";
                        text = text + " [" + textStatus + "]";
                        text = text + " [" + player.GetAvatarStatus() + "]";
                        text = text + " [" + player.GetPlatform() + "]";
                        text = text + " [<color=#FFB300>P</color>] " + player.GetPingColord();
                        text = text + " [<color=#FFB300>F</color>] " + player.GetFramesColord();
                        text = text + " <color=#" + ColorUtility.ToHtmlStringRGB(player.GetTrustColor()) + ">" + player.GetAPIUser().displayName + "</color>\n";
                    }
                    playerList.text.text = text;
                }
            }
            catch
            {
            }
        }
    }
}