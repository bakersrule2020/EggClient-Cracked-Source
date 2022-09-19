using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VRC;
using VRC.Core;
using VRC.DataModel;
using VRC.UI.Elements;
using VRC.UI.Elements.Menus;
using VRC.UI.Elements.Controls;
using MelonLoader;
using UnityEngine;
using EggClient.Utils;

namespace EggClient
{
    // Made by XoX-Toxic
    public static class IUserExtension
    {
        public static SelectedUserMenuQM GetTarget()
        {
            return ButtonAPI.GetQuickMenuInstance().field_Private_UIPage_1.GetComponent<SelectedUserMenuQM>();
        }
        #region IUser
        public static Player GetPlayer(this InterfacePublicAbstractStCoStBoObSt1BoSi1Unique value)
        {
            return value.prop_String_0.GetPlayer();
        }
        public static VRCPlayer GetVRCPlayer(this InterfacePublicAbstractStCoStBoObSt1BoSi1Unique value)
        {
            return value.GetPlayer()._vrcplayer;
        }
        public static APIUser GetAPIUser(this InterfacePublicAbstractStCoStBoObSt1BoSi1Unique value)
        {
            return value.GetPlayer().prop_APIUser_0;
        }
        public static ApiAvatar GetApiAvatar(this InterfacePublicAbstractStCoStBoObSt1BoSi1Unique value)
        {
            return value.GetPlayer().prop_ApiAvatar_0;
        }
        #endregion

        #region SelectedUserMenuQM
        public static InterfacePublicAbstractStCoStBoObSt1BoSi1Unique SelectedIUser()
        {
            return GetTarget().field_Private_InterfacePublicAbstractStCoStBoObSt1BoSi1Unique_0;
        }
        public static VRCPlayer GetVRCPlayer()
        {
            return GetTarget().field_Private_InterfacePublicAbstractStCoStBoObSt1BoSi1Unique_0.GetPlayer()._vrcplayer;
        }
        public static APIUser GetAPIUser()
        {
            return GetTarget().field_Private_InterfacePublicAbstractStCoStBoObSt1BoSi1Unique_0.GetPlayer().field_Private_APIUser_0;
        }
        public static ApiAvatar GetApiAvatar()
        {
            return GetTarget().field_Private_InterfacePublicAbstractStCoStBoObSt1BoSi1Unique_0.GetPlayer().prop_ApiAvatar_0;
        }

   
        
        #endregion
    }
}
