using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EggClient.Utils;
using UnityEngine;
using VRC;
using VRC.Core;

namespace EggClient
{
	// Token: 0x02000015 RID: 21
	public class NetworkEvents : MelonLoaderEvents
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600009F RID: 159 RVA: 0x0000586C File Offset: 0x00003A6C
		// (remove) Token: 0x060000A0 RID: 160 RVA: 0x000058A0 File Offset: 0x00003AA0
		
		public static event Action<Player> OnPlayerJoined;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060000A1 RID: 161 RVA: 0x000058D4 File Offset: 0x00003AD4
		// (remove) Token: 0x060000A2 RID: 162 RVA: 0x00005908 File Offset: 0x00003B08
		
		public static event Action<Player> OnPlayerLeft;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060000A3 RID: 163 RVA: 0x0000593C File Offset: 0x00003B3C
		// (remove) Token: 0x060000A4 RID: 164 RVA: 0x00005970 File Offset: 0x00003B70
		
		public static event Action<Player> OnLocalPlayerJoined;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060000A5 RID: 165 RVA: 0x000059A4 File Offset: 0x00003BA4
		// (remove) Token: 0x060000A6 RID: 166 RVA: 0x000059D8 File Offset: 0x00003BD8
	
		public static event Action<Player> OnLocalPlayerLeft;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060000A7 RID: 167 RVA: 0x00005A0C File Offset: 0x00003C0C
		// (remove) Token: 0x060000A8 RID: 168 RVA: 0x00005A40 File Offset: 0x00003C40
	
		public static event Action<VRCPlayer> OnVRCPlayerAwoke;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060000A9 RID: 169 RVA: 0x00005A74 File Offset: 0x00003C74
		// (remove) Token: 0x060000AA RID: 170 RVA: 0x00005AA8 File Offset: 0x00003CA8
		
		public static event Action<VRCPlayer> OnVRCPlayerDestroyed;

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x060000AB RID: 171 RVA: 0x00005ADC File Offset: 0x00003CDC
		// (remove) Token: 0x060000AC RID: 172 RVA: 0x00005B10 File Offset: 0x00003D10
	
		public static event Action<VRCPlayer, ApiAvatar, GameObject> OnAvatarInstantiated;
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x060000AD RID: 173 RVA: 0x00005B44 File Offset: 0x00003D44
		// (remove) Token: 0x060000AE RID: 174 RVA: 0x00005B78 File Offset: 0x00003D78		
		public static event Action<ApiWorld, ApiWorldInstance> OnInstanceChanged;

		// Token: 0x060000AF RID: 175 RVA: 0x00005BAC File Offset: 0x00003DAC
		public static void OnPlayerJoin(Player player)
		{
			bool flag = player == null;
			if (!flag)
			{
				Console.WriteLine("OnPlayerJoin: " + player.ToString());
				try
				{
					bool flag2 = player.field_Private_APIUser_0 == null || player.field_Private_APIUser_0.IsSelf;
					if (flag2)
					{
						Action<Player> onLocalPlayerJoined = NetworkEvents.OnLocalPlayerJoined;
						if (onLocalPlayerJoined != null)
						{
							onLocalPlayerJoined.Invoke(player);
							
						}
					}
					else
					{
						Action<Player> onPlayerJoined = NetworkEvents.OnPlayerJoined;
						if (onPlayerJoined != null)
						{
							onPlayerJoined.Invoke(player);
						}
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error while executing OnPlayerJoin:\n" + ex.ToString());
				}
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00005C64 File Offset: 0x00003E64


		// Token: 0x060000B5 RID: 181 RVA: 0x00005FD0 File Offset: 0x000041D0
		public override void OnUiManagerInit()
		{
			ObjectPublicHa1UnT1Unique<Player> field_Internal_ObjectPublicHa1UnT1Unique_1_Player_ = NetworkManager.field_Internal_Static_NetworkManager_0.field_Internal_ObjectPublicHa1UnT1Unique_1_Player_0;
			ObjectPublicHa1UnT1Unique<Player> field_Internal_ObjectPublicHa1UnT1Unique_1_Player_2 = NetworkManager.field_Internal_Static_NetworkManager_0.field_Internal_ObjectPublicHa1UnT1Unique_1_Player_2;
			field_Internal_ObjectPublicHa1UnT1Unique_1_Player_.field_Private_HashSet_1_UnityAction_1_T_0.Add(new Action<Player>(NetworkEvents.OnPlayerJoin));
			
			
		}
	}
}