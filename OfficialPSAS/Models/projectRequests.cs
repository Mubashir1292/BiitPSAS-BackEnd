//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OfficialPSAS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class projectRequests
    {
        public int req_id { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<System.DateTime> req_date { get; set; }
    
        public virtual group group { get; set; }
        public virtual Project Project { get; set; }
        public virtual teacher teacher { get; set; }
    }
}
