﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IMSEntities : DbContext
    {
        public IMSEntities()
            : base("name=IMSEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<company> companies { get; set; }
        public virtual DbSet<configdb> configdbs { get; set; }
        public virtual DbSet<configemail> configemails { get; set; }
        public virtual DbSet<emailcurrent> emailcurrents { get; set; }
        public virtual DbSet<emailerror> emailerrors { get; set; }
        public virtual DbSet<emailhistory> emailhistories { get; set; }
        public virtual DbSet<frequency> frequencies { get; set; }
        public virtual DbSet<jenkinsproject> jenkinsprojects { get; set; }
        public virtual DbSet<jenkinsserver> jenkinsservers { get; set; }
        public virtual DbSet<jerkinsjob> jerkinsjobs { get; set; }
        public virtual DbSet<jerkinsjobhi> jerkinsjobhis { get; set; }
        public virtual DbSet<monitor> monitors { get; set; }
        public virtual DbSet<monitoritemlastresult> monitoritemlastresults { get; set; }
        public virtual DbSet<monitoritemresulthistory> monitoritemresulthistories { get; set; }
        public virtual DbSet<project> projects { get; set; }
        public virtual DbSet<sysconfig> sysconfigs { get; set; }
        public virtual DbSet<monitoritem_his> monitoritem_his { get; set; }
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<job_running_list> job_running_list { get; set; }
        public virtual DbSet<monitoritem> monitoritems { get; set; }
    }
}
