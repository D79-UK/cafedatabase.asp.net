//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace cafedatabase.asp.net.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class assortiment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public assortiment()
        {
            this.available_assortiments = new HashSet<available_assortiments>();
        }
    
        public int id { get; set; }
        public string title { get; set; }
        public Nullable<double> price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<available_assortiments> available_assortiments { get; set; }
    }
}
