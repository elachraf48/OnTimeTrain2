//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Projet_login_1
{
    using System;
    using System.Collections.Generic;
    
    public partial class fournisseur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fournisseur()
        {
            this.commande_achat = new HashSet<commande_achat>();
        }
    
        public short Num_F { get; set; }
        public string Nom_Entreprise { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Ville { get; set; }
        public string Adresse { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<commande_achat> commande_achat { get; set; }
    }
}
