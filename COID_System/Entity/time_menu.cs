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
    
    public partial class time_menu
    {
        public System.DateTime date_service { get; set; }
        public Nullable<int> breakfast_mId { get; set; }
        public Nullable<int> lunch_mId { get; set; }
        public Nullable<int> dinner_mId { get; set; }
    
        public virtual menu menu { get; set; }
        public virtual menu menu1 { get; set; }
        public virtual menu menu2 { get; set; }
    }
}
