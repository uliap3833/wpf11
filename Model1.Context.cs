﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPF_SQL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities1 : DbContext
    {
        public Entities1()
            : base("name=Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Age_group> Age_group { get; set; }
        public virtual DbSet<Parties> Parties { get; set; }
        public virtual DbSet<Record> Record { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Sex> Sex { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}