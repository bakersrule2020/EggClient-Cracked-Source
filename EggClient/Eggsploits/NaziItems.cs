
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;

namespace EggClient
{
    class Funni
    {
        public static bool arroworbittoggle = false;
        public static bool sovasticabool = false;
        public static int arrowpoz = 0;

        public static VRC_Pickup[] array;

        public static Vector3 Rotation;

        public static Vector3 vec3poz;
        public static void arroworbit()
        {
            if (!arroworbittoggle) return;


            var a = vec3poz;
            var io = Resources.FindObjectsOfTypeAll<VRC.SDKBase.VRC_Pickup>().ToArray<VRC.SDKBase.VRC_Pickup>();

            try
            {

                foreach (var bc in io)
                {
                    bc.transform.localEulerAngles = Rotation;
                    EggClient.Extentions.Extentions.TakeOwnershipIfNecessary(bc.gameObject);

                }
                if (arrowpoz == 0)
                {
                    io[0].transform.position = new Vector3(a.x - 0.3f, a.y * 3, a.z);
                    io[1].transform.position = new Vector3(a.x, a.y * 3, a.z);
                    io[2].transform.position = new Vector3(a.x + 0f, a.y * 3, a.z);
                    io[3].transform.position = new Vector3(a.x + 0.3f, a.y * 3, a.z);
                    io[4].transform.position = new Vector3(a.x + 0.6f, a.y * 3, a.z);
                    io[5].transform.position = new Vector3(a.x + 0.9f, a.y * 3, a.z);
                    io[6].transform.position = new Vector3(a.x + 1.2f, a.y * 3, a.z);
                    io[7].transform.position = new Vector3(a.x + 1.5f, a.y * 3, a.z);
                    io[8].transform.position = new Vector3(a.x + 1.8f, a.y * 3, a.z);
                    io[9].transform.position = new Vector3(a.x + 2.1f, a.y * 3, a.z);
                    io[10].transform.position = new Vector3(a.x + 2.4f, a.y * 3, a.z);
                    io[11].transform.position = new Vector3(a.x + 2.7f, a.y * 3, a.z);
                    io[12].transform.position = new Vector3(a.x + 2.55f, a.y + 0.4f * 3, a.z);
                    io[13].transform.position = new Vector3(a.x + 2.55f, a.y - 0.4f * 3, a.z);
                    io[14].transform.position = new Vector3(a.x + 2.35f, a.y - 0.8f * 3, a.z);
                    io[15].transform.position = new Vector3(a.x + 2.35f, a.y + 0.8f * 3, a.z);
                }
                else if (arrowpoz == 1)
                {
                    io[0].transform.position = new Vector3(a.x, a.y * 3, a.z - 0.3f);
                    io[1].transform.position = new Vector3(a.x, a.y * 3, a.z);
                    io[2].transform.position = new Vector3(a.x, a.y * 3, a.z);
                    io[3].transform.position = new Vector3(a.x, a.y * 3, a.z + 0.3f);
                    io[4].transform.position = new Vector3(a.x, a.y * 3, a.z + 0.6f);
                    io[5].transform.position = new Vector3(a.x, a.y * 3, a.z + 0.9f);
                    io[6].transform.position = new Vector3(a.x, a.y * 3, a.z + 1.2f);
                    io[7].transform.position = new Vector3(a.x, a.y * 3, a.z + 1.5f);
                    io[8].transform.position = new Vector3(a.x, a.y * 3, a.z + 1.8f);
                    io[9].transform.position = new Vector3(a.x, a.y * 3, a.z + 2.1f);
                    io[10].transform.position = new Vector3(a.x, a.y * 3, a.z + 2.4f);
                    io[11].transform.position = new Vector3(a.x, a.y * 3, a.z + 2.7f);
                    io[12].transform.position = new Vector3(a.x, a.y + 0.4f * 3, a.z + 2.55f);
                    io[13].transform.position = new Vector3(a.x, a.y - 0.4f * 3, a.z + 2.55f);
                    io[14].transform.position = new Vector3(a.x, a.y - 0.8f * 3, a.z + 2.35f);
                    io[15].transform.position = new Vector3(a.x, a.y + 0.8f * 3, a.z + 2.35f);
                }
                else if (arrowpoz == 2)
                {
                    io[0].transform.position = new Vector3(a.x, a.y - 0.3f * 3, a.z);
                    io[1].transform.position = new Vector3(a.x, a.y * 3, a.z);
                    io[2].transform.position = new Vector3(a.x, a.y * 3, a.z);
                    io[3].transform.position = new Vector3(a.x, a.y + 0.3f * 3, a.z);
                    io[4].transform.position = new Vector3(a.x, a.y + 0.6f * 3, a.z);
                    io[5].transform.position = new Vector3(a.x, a.y + 0.9f * 3, a.z);
                    io[6].transform.position = new Vector3(a.x, a.y + 1.2f * 3, a.z);
                    io[7].transform.position = new Vector3(a.x, a.y + 1.5f * 3, a.z);
                    io[8].transform.position = new Vector3(a.x, a.y + 1.8f * 3, a.z);
                    io[9].transform.position = new Vector3(a.x, a.y + 2.1f * 3, a.z);
                    io[10].transform.position = new Vector3(a.x, a.y + 2.4f * 3, a.z);
                    io[11].transform.position = new Vector3(a.x, a.y + 2.7f * 3, a.z);
                    io[12].transform.position = new Vector3(a.x, a.y + 2.55f * 3, a.z + 0.4f);
                    io[13].transform.position = new Vector3(a.x, a.y + 2.55f * 3, a.z - 0.4f);
                    io[14].transform.position = new Vector3(a.x, a.y + 2.35f * 3, a.z - 0.8f);
                    io[15].transform.position = new Vector3(a.x, a.y + 2.35f * 3, a.z + 0.8f);
                }
                else if (arrowpoz == 3)
                {
                    io[0].transform.position = new Vector3(a.x, a.y - 0.3f * 3, a.z);
                    io[1].transform.position = new Vector3(a.x, a.y * 3, a.z);
                    io[2].transform.position = new Vector3(a.x, a.y * 3, a.z);
                    io[3].transform.position = new Vector3(a.x, a.y + 0.3f * 3, a.z);
                    io[4].transform.position = new Vector3(a.x, a.y + 0.6f * 3, a.z);
                    io[5].transform.position = new Vector3(a.x, a.y + 0.9f * 3, a.z);
                    io[6].transform.position = new Vector3(a.x, a.y + 1.2f * 3, a.z);
                    io[7].transform.position = new Vector3(a.x, a.y + 1.5f * 3, a.z);
                    io[8].transform.position = new Vector3(a.x, a.y + 1.8f * 3, a.z);
                    io[9].transform.position = new Vector3(a.x, a.y + 2.1f * 3, a.z);
                    io[10].transform.position = new Vector3(a.x, a.y + 2.4f * 3, a.z);
                    io[11].transform.position = new Vector3(a.x, a.y + 2.7f * 3, a.z);
                    io[12].transform.position = new Vector3(a.x + 0.3f, a.y + 1.3f * 3, a.z);
                    io[13].transform.position = new Vector3(a.x - 0.3f, a.y + 1.3f * 3, a.z);
                    io[14].transform.position = new Vector3(a.x - 0.6f, a.y + 1.3f * 3, a.z);
                    io[15].transform.position = new Vector3(a.x + 0.6f, a.y + 1.3f * 3, a.z);
                    io[16].transform.position = new Vector3(a.x - 0.9f, a.y + 1.3f * 3, a.z);
                    io[17].transform.position = new Vector3(a.x + 0.9f, a.y + 1.3f * 3, a.z);
                }

            }
            catch { }


        }

        public static void NaziItems()
        {
            if (!sovasticabool) return;

            int b = 0;
            var a = vec3poz;
            var io = Resources.FindObjectsOfTypeAll<VRC.SDKBase.VRC_Pickup>().ToArray<VRC.SDKBase.VRC_Pickup>();

            try
            {
                io[0].transform.position = new Vector3(a.x, a.y, a.z);
                io[1].transform.position = new Vector3(a.x, a.y + 0.5f, a.z);
                io[2].transform.position = new Vector3(a.x, a.y + 1f, a.z);
                io[3].transform.position = new Vector3(a.x, a.y + 1.5f, a.z);
                io[4].transform.position = new Vector3(a.x, a.y + 2f, a.z);
                io[17].transform.position = new Vector3(a.x, a.y + 0.5f, a.z);
                io[18].transform.position = new Vector3(a.x, a.y + 1f, a.z);
                io[19].transform.position = new Vector3(a.x, a.y + 1.5f, a.z);
                io[20].transform.position = new Vector3(a.x, a.y, a.z);
                io[21].transform.position = new Vector3(a.x, a.y + 2.5f, a.z);
                io[22].transform.position = new Vector3(a.x, a.y + 3f, a.z);

                io[5].transform.position = new Vector3(a.x + 0.5f, a.y + 1.5f, a.z);
                io[6].transform.position = new Vector3(a.x + 1f, a.y + 1.5f, a.z);
                io[7].transform.position = new Vector3(a.x - 0.5f, a.y + 1.5f, a.z);
                io[8].transform.position = new Vector3(a.x - 1f, a.y + 1.5f, a.z);
                io[27].transform.position = new Vector3(a.x + 1.5f, a.y + 1.5f, a.z);
                io[28].transform.position = new Vector3(a.x - 1.5f, a.y + 1.5f, a.z);

                io[9].transform.position = new Vector3(a.x + 1.5f, a.y + 1.7f, a.z);
                io[10].transform.position = new Vector3(a.x + 1.5f, a.y + 1.9f, a.z);
                io[23].transform.position = new Vector3(a.x + 1.5f, a.y + 2.1f, a.z);

                io[11].transform.position = new Vector3(a.x - 1.5f, a.y + 1.3f, a.z);
                io[12].transform.position = new Vector3(a.x - 1.5f, a.y + 1.1f, a.z);
                io[24].transform.position = new Vector3(a.x - 1.5f, a.y + 1.3f, a.z);

                io[13].transform.position = new Vector3(a.x - 0.2f, a.y + 3f, a.z);
                io[14].transform.position = new Vector3(a.x - 0.4f, a.y + 3f, a.z);
                io[25].transform.position = new Vector3(a.x - 0.6f, a.y + 3f, a.z);

                io[15].transform.position = new Vector3(a.x + 0.2f, a.y, a.z);
                io[16].transform.position = new Vector3(a.x + 0.4f, a.y, a.z);
                io[26].transform.position = new Vector3(a.x + 0.6f, a.y, a.z);

            }
            catch { }


        }







    }
}
