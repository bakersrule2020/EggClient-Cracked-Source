using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EggClient.Utils
{
    public class MelonLoaderEvents
    {
        // Token: 0x060000F2 RID: 242 RVA: 0x000078B1 File Offset: 0x00005AB1
        public virtual void OnApplicationStart()
        {
        }

        // Token: 0x060000F3 RID: 243 RVA: 0x000078B4 File Offset: 0x00005AB4
        public virtual void OnUiManagerInit()
        {
        }

        // Token: 0x060000F4 RID: 244 RVA: 0x000078B7 File Offset: 0x00005AB7
        public virtual void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
        }

        // Token: 0x060000F5 RID: 245 RVA: 0x000078BA File Offset: 0x00005ABA
        public virtual void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
        }

        // Token: 0x060000F6 RID: 246 RVA: 0x000078BD File Offset: 0x00005ABD
        public virtual void OnSceneWasUnloaded(int buildIndex, string sceneName)
        {
        }

        // Token: 0x060000F7 RID: 247 RVA: 0x000078C0 File Offset: 0x00005AC0
        public virtual void OnApplicationQuit()
        {
        }
    }
}