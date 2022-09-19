using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRC;

namespace EggClient
{
    public static class PlayerExtension
    {
        #region PlayerManager
        public static List<Player> AllPlayers(this PlayerManager Instance)
        {
            return Instance.field_Private_List_1_Player_0.ToArray().ToList<Player>();
        }
        public static Player GetPlayer(this PlayerManager instance, string UserID)
        {
            foreach (Player player in instance.AllPlayers())
            {
                if (player.field_Private_APIUser_0.id == UserID)
                {
                    return player;
                }
            }
            return null;
        }
        public static Player GetPlayer(this string UserID)
        {
            foreach (Player player in PlayerManager.prop_PlayerManager_0.AllPlayers())
            {
                if (player.field_Private_APIUser_0.id == UserID)
                {
                    return player;
                }
            }
            return null;
        }
        #endregion PlayerManager
    }
}
