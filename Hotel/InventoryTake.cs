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
    
    public partial class InventoryTake
    {
        public string ID_InventoryTake { get; set; }
        public string ID_InventoryHistory { get; set; }
        public string ID_Items { get; set; }
        public Nullable<int> Number { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public string ID_Room { get; set; }
        public string ID_Labor { get; set; }
    
        public virtual InventoryHistory InventoryHistory { get; set; }
        public virtual Item Item { get; set; }
        public virtual Labor Labor { get; set; }
        public virtual Room Room { get; set; }
    }
}
