﻿using System.ComponentModel;

namespace Steven.Domain.Enums
{
    public enum TableSource
    {
        [Description("默认")]
        None = 0,
        [Description("用户")]
        Users = 1,
        [Description("配置")]
        SysConfig = 2,
        [Description("部门")]
        SysApartment = 3,
        [Description("按钮")]
        SysButtons = 4,
        [Description("附件")]
        Attachments = 5,
        [Description("菜单")]
        SysMenu = 6,
        [Description("文章分类")]
        ArticleClassify = 7,
        [Description("角色")]
        UserRole = 8,
        [Description("文章")]
        Article = 9,
        [Description("广告位")]
        AdPositions = 10,
        [Description("广告")]
        Adverts = 11,
        [Description("角色数据规则")]
        UserRole2Filter = 12,
        [Description("任务")]
        JobTask = 13,
        [Description("代理")]
        Agent = 14,
        [Description("商户")]
        Shop = 15,
        [Description("商户App信息")]
        ShopAppInfo = 16,
        [Description("商品")]
        Product = 17,
        [Description("商品分类")]
        ProductClassify = 18,
        [Description("规格")]
        SysSpecs = 19,
        [Description("店铺装修")]
        ShopFitting = 20,
        [Description("案例")]
        SysCase = 21,
        [Description("合作伙伴")]
        SysPartner = 22,
        [Description("单位")]
        SysUnit = 23,
        [Description("订单")]
        ShopOrder = 24,
        [Description("快递")]
        SysExpress = 25
    }
}
