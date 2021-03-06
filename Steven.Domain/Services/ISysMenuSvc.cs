﻿using Steven.Domain.ViewModels;
using System.Collections.Generic;

namespace Steven.Domain.Services
{
    public interface ISysMenuSvc
    {
        List<JsTreeJsonModel> GetJsonList(long roleId);

        IEnumerable<SysUserRole2MenuModel> GetRole2MenuList(long roleId);

        IEnumerable<UserMenuModel> GetList(List<long> lstRoleId);
    }
}
