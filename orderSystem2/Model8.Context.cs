﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace orderSystem2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OrderSystemDBEntities8 : DbContext
    {
        public OrderSystemDBEntities8()
            : base("name=OrderSystemDBEntities8")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<myFavorite> myFavorite { get; set; }
        public virtual DbSet<order> order { get; set; }
        public virtual DbSet<orderLine> orderLine { get; set; }
        public virtual DbSet<productData> productData { get; set; }
        public virtual DbSet<user> user { get; set; }
    }
}