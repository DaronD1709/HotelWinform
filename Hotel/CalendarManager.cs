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
    
    public partial class CalendarManager
    {
        public string ID_CalendarManager { get; set; }
        public string ID_Shift { get; set; }
        public Nullable<System.TimeSpan> Timein { get; set; }
        public Nullable<System.TimeSpan> Timeout { get; set; }
        public string ID_Manager { get; set; }
        public string Name_Manager { get; set; }
        public Nullable<System.DateTime> Day { get; set; }
    
        public virtual Manager Manager { get; set; }
        public virtual Shift Shift { get; set; }
    }
}