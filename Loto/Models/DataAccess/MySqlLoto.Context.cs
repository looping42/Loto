﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Loto.Models.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class lotoEntities : DbContext
    {
        public lotoEntities()
            : base("name=lotoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<lto_probabilite> lto_probabilite { get; set; }
        public virtual DbSet<lto_utilisateur> lto_utilisateur { get; set; }
        public virtual DbSet<lto_tirage> lto_tirage { get; set; }
    }
}