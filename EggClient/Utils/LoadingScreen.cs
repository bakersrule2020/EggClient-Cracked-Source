
using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace EggClient
{
    internal class LoadingScreen
    {

        public static void runti()
        {
            GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Loading Elements/txt_Percent").transform.localPosition = new Vector3(-98.0401f, 115.42f, 0.0f);
            GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/LoadingPopup/3DElements/LoadingInfoPanel").gameObject.SetActive(false);
            GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/LoadingPopup/3DElements/LoadingBackground_TealGradient/SkyCube_Baked").gameObject.SetActive(false);
            GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/RingGlow").GetComponent<Image>().color = Color.black;
            GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/Rectangle").gameObject.SetActive(false);
            GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/InnerDashRing").GetComponent<Image>().color = new Color(0.0f, 0.0f, 0.0f, 0.8f);
            GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/MidRing").GetComponent<Image>().color = Color.red;
            GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/ProgressLine").GetComponent<Image>().color = Color.red;
            GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/TitleText").GetComponent<Text>().color = Color.red;
            GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/TitleText").GetComponent<Outline>().enabled = false;
            GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/TitleText").GetComponent<Text>().color = Color.red;
            GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/ArrowRight").gameObject.SetActive(false);
            GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/ArrowLeft").gameObject.SetActive(false);
            GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/BodyText").GetComponent<Text>().color = Color.red;
            GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/HighPercent").GetComponent<Text>().color = Color.red;
            GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/LowPercent").GetComponent<Text>().color = Color.red;
            GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Panel_Backdrop").GetComponent<Image>().color = Color.black;
            GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Decoration_Left").GetComponent<Image>().color = Color.black;
            GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/LoadingPopup/ProgressPanel/Parent_Loading_Progress/Decoration_Right").GetComponent<Image>().color = Color.black;
            GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/LoadingPopup/MirroredElements/ProgressPanel (1)/Parent_Loading_Progress/Panel_Backdrop").GetComponent<Image>().color = Color.black;
            GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/LoadingPopup/MirroredElements/ProgressPanel (1)/Parent_Loading_Progress/Decoration_Left").GetComponent<Image>().color = Color.black;
            GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/LoadingPopup/MirroredElements/ProgressPanel (1)/Parent_Loading_Progress/Decoration_Right").GetComponent<Image>().color = Color.black;

            ColorBlock colors1 = new ColorBlock
            {
                normalColor = Color.red,
                highlightedColor = Color.red,
                pressedColor = Color.red,
                disabledColor = Color.red,
                selectedColor = Color.red,
            };
            GameObject gameObject = GameObject.Find("UserInterface/MenuContent");

            foreach (UnityEngine.UI.Button componentsInChild in gameObject.GetComponentsInChildren<UnityEngine.UI.Button>(true))
            {
                if (componentsInChild.gameObject.GetComponentsInChildren<Transform>(true).Any<Transform>((Func<Transform, bool>)(a => a.name == "emmVRCDoNotColor")) || componentsInChild.name != "SubscribeToAddPhotosButton" && componentsInChild.name != "SupporterButton" && componentsInChild.name != "ModerateButton" && componentsInChild.transform.parent.name != "VRC+PageTab" && (componentsInChild.name != "ReportButton" || componentsInChild.transform.parent.name.Contains("WorldInfo")))
                {
                    componentsInChild.colors = colors1;
                }
                GameObject.Find("/UserInterface").transform.Find("MenuContent/Popups/StandardPopup/ButtonMiddle").GetComponent<Button>().colors = colors1;


                ColorBlock colors = new ColorBlock
                {
                    normalColor = new Color(0.0f, 0.0f, 0.0f, 0.6f),
                    highlightedColor = new Color(0.0f, 0.0f, 0.0f, 0.9f),
                    pressedColor = new Color(0.0f, 0.0f, 0.0f, 1f),
                    disabledColor = new Color(0.0f, 0.0f, 0.0f, 0.3f),
                    selectedColor = new Color(0.0f, 0.0f, 0.0f, 0.8f)
                };

                GameObject.Find("/UserInterface").transform.Find("LoadingBackground_TealGradient_Music/SkyCube_Baked").gameObject.SetActive(false);
                GameObject.Find("/UserInterface").transform.Find("LoadingBackground_TealGradient_Music/LoadingSound").gameObject.SetActive(false);
            }

        }
    }
}
   