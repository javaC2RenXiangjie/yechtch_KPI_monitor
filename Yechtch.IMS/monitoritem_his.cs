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
    
    public partial class monitoritem_his
    {
        public int id { get; set; }
        public string companycode { get; set; }
        public string projectcode { get; set; }
        public string monitorcode { get; set; }
        public string monitoritemcode { get; set; }
        public string monitoritemname { get; set; }
        public string executesql { get; set; }
        public string val { get; set; }
        public string status { get; set; }
        public Nullable<System.DateTime> createtime { get; set; }
        public string createby { get; set; }
        public Nullable<System.DateTime> lastupdatetime { get; set; }
        public string lastupdateby { get; set; }
    }
}