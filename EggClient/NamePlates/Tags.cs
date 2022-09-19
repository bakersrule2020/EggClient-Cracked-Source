using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using VRC;

namespace EggClient
{
    class Tags
    {
        public static Player player;
        public static object tagObject;
        public static float spacing = 30f;
        public static void AddTag(Player p, JArray tagArray, int tagAmount)
        {
            for (int j = 0; j < tagAmount; j++)
            {
                GameObject val = UnityEngine.Object.Instantiate<GameObject>(GameObject.Find(((UnityEngine.Object)((Component)p).gameObject).name + "/Player Nameplate/Canvas/Nameplate/Contents/Quick Stats/"));
                ((UnityEngine.Object)val).name = $"{tagAmount}ShadowTag";
                val.transform.localScale = Vector3.one;
                val.transform.rotation = GameObject.Find(((UnityEngine.Object)((Component)p).gameObject).name + "/Player Nameplate/Canvas/Nameplate/Contents/Quick Stats/").transform.parent
                    .rotation;
                val.transform.parent = GameObject.Find(((UnityEngine.Object)((Component)p).gameObject).name + "/Player Nameplate/Canvas/Nameplate/Contents/Quick Stats/").transform.parent;
                val.transform.localScale = Vector3.one;
                val.transform.localPosition = new Vector3(0f, spacing + 30f, 0f);
                ((Graphic)val.GetComponent<ImageThreeSlice>()).color = Color.white; // new Color(0f, 0f, 0f, 0.7f);
                if (p.field_Private_APIUser_0.last_platform == "android" && p.field_Private_VRCPlayerApi_0.IsUserInVR())
                {
                    ((Component)val.transform.parent.Find("Quest/Quest Icon")).gameObject.SetActive(false);
                    ((Component)val.transform.parent.Find("Quest/Quest Text")).gameObject.SetActive(false);
                }
                UnityEngine.Object.Destroy((UnityEngine.Object)(object)((Component)val.transform.Find("Trust Icon")).gameObject);
                UnityEngine.Object.Destroy((UnityEngine.Object)(object)((Component)val.transform.Find("Performance Icon")).gameObject);
                UnityEngine.Object.Destroy((UnityEngine.Object)(object)((Component)val.transform.Find("Friend Anchor Stats")).gameObject);
                UnityEngine.Object.Destroy((UnityEngine.Object)(object)((Component)val.transform.Find("Trust Text")).gameObject);
                UnityEngine.Object.Destroy((UnityEngine.Object)(object)((Component)val.transform.Find("Performance Text/TMP SubMeshUI [Namplete Text + NotoSans-Bold Atlas]")).gameObject);
                ((UnityEngine.Object)val.transform.Find("Performance Text")).name = $"{tagAmount}ShadowText";
                ((TMP_Text)((Component)val.transform.Find($"{tagAmount}ShadowText")).GetComponent<TextMeshProUGUI>()).color = Color.white;
                ((Component)val.transform.Find($"{tagAmount}ShadowText")).gameObject.SetActive(true);
                var textObj = ((Component)val.transform.Find($"{tagAmount}ShadowText")).GetComponent<TextMeshProUGUI>();
                for (int i = 0; i < val.transform.GetChildCount(); i++)
                {
                    if (((UnityEngine.Object)val.transform.GetChild(i)).name != $"{tagAmount}ShadowText")
                    {
                        UnityEngine.Object.Destroy((UnityEngine.Object)(object)((Component)val.transform.GetChild(i)).gameObject);
                    }
                }
                ((TMP_Text)textObj).color = Color.white;
                // ((TMP_Text)textObj).outlineWidth = 0.5f;
                ((TMP_Text)textObj).outlineColor = Color.magenta;
                ((TMP_Text)textObj).text = tagArray[j].ToString();
                val.SetActive(true);
                tagObject = val;
                player = p;
                spacing += 30f;
                if (j == tagAmount - 1)
                {
                    spacing = 30f;
                }
            }
        }
    }
}
