using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace EggClient.Utils
{
    class FPSStuff
    {
        public static void SetFPS90()
        {
            Application.targetFrameRate = 90;
        }

        public static void UltraLow()
        {
            QualitySettings.antiAliasing = 0;
            QualitySettings.pixelLightCount = 0;
            QualitySettings.lodBias = 0.3f;
            QualitySettings.shadowDistance = 1f;
            QualitySettings.masterTextureLimit = 2;
      
        }

        public static void low()
        {
            QualitySettings.antiAliasing = 0;
            QualitySettings.pixelLightCount = 0;
            QualitySettings.lodBias = 0.4f;
            QualitySettings.shadowDistance = 20f;
           
        }
    }
}
            
   
