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
    
    public partial class transaction
    {
        public string id { get; set; }
        public string userID { get; set; }
        public string staffID { get; set; }
        public string type { get; set; }
        public double amount { get; set; }
        public string orderID { get; set; }
        public string description { get; set; }
        public System.DateTime time { get; set; }
    
        public virtual order order { get; set; }
        public virtual user user { get; set; }
        public virtual user user1 { get; set; }
    }
}
