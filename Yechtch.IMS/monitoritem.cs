//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yechtch.IMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class monitoritem
    {
        public int id { get; set; }
        public string companycode { get; set; }
        public string projectcode { get; set; }
        public string monitorcode { get; set; }
        public string monitoritemcode { get; set; }
        public string monitoritemname { get; set; }
        public string description { get; set; }
        public Nullable<int> dbtype { get; set; }
        public string configdbcode { get; set; }
        public Nullable<int> daypart { get; set; }
        public string dateidformatprefix { get; set; }
        public Nullable<int> dateidformat { get; set; }
        public string dateidformatsuffix { get; set; }
        public Nullable<int> resultformat { get; set; }
        public Nullable<int> comparemode { get; set; }
        public Nullable<decimal> comparemodefixedvalue { get; set; }
        public Nullable<decimal> comparemoderangevalue { get; set; }
        public Nullable<decimal> comparemodethreshold { get; set; }
        public Nullable<bool> enabled { get; set; }
        public string cron { get; set; }
        public Nullable<bool> enbalefailureretry { get; set; }
        public Nullable<int> failureretryexecuteinterval { get; set; }
        public Nullable<bool> enablecache { get; set; }
        public Nullable<int> cachetime { get; set; }
        public Nullable<int> cachetimedaypart { get; set; }
        public Nullable<bool> enablereflash { get; set; }
        public Nullable<int> reflashtime { get; set; }
        public Nullable<int> reflashdaypart { get; set; }
        public Nullable<bool> enablesuccessnotify { get; set; }
        public Nullable<bool> enablefailurenotify { get; set; }
        public string failureemails { get; set; }
        public string successemails { get; set; }
        public string executesql { get; set; }
        public Nullable<System.DateTime> createtime { get; set; }
        public string createby { get; set; }
        public Nullable<System.DateTime> lastupdatetime { get; set; }
        public string lastupdateby { get; set; }
    }
}