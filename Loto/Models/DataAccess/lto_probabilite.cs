//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class lto_probabilite
    {
        public lto_probabilite()
        {
            this.lto_utilisateur = new HashSet<lto_utilisateur>();
        }
    
        public int pro_id { get; set; }
        public short pro_boule1 { get; set; }
        public short pro_boule2 { get; set; }
        public short pro_boule3 { get; set; }
        public short pro_boule4 { get; set; }
        public short pro_boule5 { get; set; }
        public Nullable<short> pro_numeroChance { get; set; }
        public string pro_combinaisonGagnanteCroissant { get; set; }
        public string pro_numeroJokerplus { get; set; }
    
        public virtual ICollection<lto_utilisateur> lto_utilisateur { get; set; }
    }
}