//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace COID_System.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class combo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public combo()
        {
            this.food_combo = new HashSet<food_combo>();
        }
    
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public double discount_price { get; set; }
        public System.DateTime create_time { get; set; }
        public Nullable<bool> disable { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<food_combo> food_combo { get; set; }
        public override string ToString()
        {
            return name;
        }
    }
}
