//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Company.Domain.Repository.GenericRepository
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.Visits = new HashSet<Visit>();
        }
    
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public System.DateTime DateAdded { get; set; }
        public System.DateTime DateTimeAdded { get; set; }
        public System.DateTime LastUpdated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visit> Visits { get; set; }
        public string Email { get; internal set; }
    }
}
