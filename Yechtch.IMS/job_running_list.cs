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
    
    public partial class job_running_list
    {
        public int monitor_item_id { get; set; }
        public string cron { get; set; }
        public string execute_sql { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public Nullable<int> update_flag { get; set; }
        public string field2 { get; set; }
    }
}