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
    
    public partial class food_combo
    {
        public string foodID { get; set; }
        public string comboID { get; set; }
        public double price { get; set; }
    
        public virtual combo combo { get; set; }
        public virtual food food { get; set; }
    }
}