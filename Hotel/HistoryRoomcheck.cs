//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel
{
    using System;
    using System.Collections.Generic;
    
    public partial class HistoryRoomcheck
    {
        public string ID_TakeItem { get; set; }
        public string ID_Customer { get; set; }
        public string ID_Room { get; set; }
        public Nullable<System.DateTime> Timecheckin { get; set; }
        public Nullable<System.DateTime> Timecheckout { get; set; }
        public Nullable<System.DateTime> Timehavetocheckout { get; set; }
        public string ID_Receiptor { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Receiptor Receiptor { get; set; }
        public virtual Room Room { get; set; }
    }
}
