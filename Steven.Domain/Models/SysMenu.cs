﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成
//     如果重新生成代码，将丢失对此文件所做的更改。
// </auto-generated>
//------------------------------------------------------------------------------
using Steven.Domain.Infrastructure;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Steven.Core.Utilities;
using Steven.Domain.Enums;
using Dapper.Contrib.Extensions;

namespace Steven.Domain.Models
{
    [Table("SysMenu")]
    public partial class SysMenu : AggregateRoot
    {
        public virtual long Pid
        {
            get;
            set;
        }

        [DisplayName("名称")]
        [MaxLength(20,ErrorMessage =ErrorMsgUtils.MaxStringLength),Required(ErrorMessage =ErrorMsgUtils.Required)]
        public virtual string Name
        {
            get;
            set;
        }

        [DisplayName("备注")]
        [MaxLength(250, ErrorMessage = ErrorMsgUtils.MaxStringLength)]
        public virtual string Remark
        {
            get;
            set;
        }

        [DisplayName("地址")]
        [MaxLength(250, ErrorMessage = ErrorMsgUtils.MaxStringLength)]
        public virtual string Url
        {
            get;
            set;
        }

        [DisplayName("Icon")]
        [MaxLength(20, ErrorMessage = ErrorMsgUtils.MaxStringLength)]
        public virtual string Icon
        {
            get;
            set;
        }

        public virtual int Sort
        {
            get;
            set;
        }

        [DisplayName("数据源")]
        [MaxLength(20, ErrorMessage = ErrorMsgUtils.MaxStringLength)]
        public virtual string Source
        {
            get;
            set;
        }


        [MaxLength(100)]
        public string TreePath { get; set; }

        public SysButton Buttons { get; set; }
    }

}