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
    
    public partial class jerkinsjob
    {
        public int JobId { get; set; }
        public string JobName { get; set; }
        public Nullable<int> MaxDuration { get; set; }
        public Nullable<int> L7MaxDuration { get; set; }
        public Nullable<System.DateTime> BeginTime { get; set; }
        public Nullable<bool> IsManualCron { get; set; }
        public string Corn { get; set; }
        public string PYCorn { get; set; }
        public Nullable<int> Duration { get; set; }
        public string Status { get; set; }
        public Nullable<int> Threshold { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public Nullable<System.DateTime> LastUpdateTime { get; set; }
        public string DependenceJobId { get; set; }
        public string DependenceJobName { get; set; }
    }
}
