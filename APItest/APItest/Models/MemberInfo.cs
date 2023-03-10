﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace APItest.Models
{
    public partial class MemberInfo
    {
        public MemberInfo()
        {
            SelfOrder = new HashSet<SelfOrder>();
            SetOrder = new HashSet<SetOrder>();
            ShopOrder = new HashSet<ShopOrder>();
        }

        public int 會員id { get; set; }
        public string 姓名 { get; set; }
        public bool? 性別 { get; set; }
        public DateTime? 出生日期 { get; set; }
        public string 電話號碼 { get; set; }
        public string 連絡信箱 { get; set; }
        public string 會員帳號 { get; set; }
        public string 會員密碼 { get; set; }
        public string 照片 { get; set; }
        public bool? 權限 { get; set; }
        public DateTime? 建立時間 { get; set; }
        public DateTime? 修改時間 { get; set; }
        public string 修改人 { get; set; }

        public virtual ICollection<SelfOrder> SelfOrder { get; set; }
        public virtual ICollection<SetOrder> SetOrder { get; set; }
        public virtual ICollection<ShopOrder> ShopOrder { get; set; }
    }
}