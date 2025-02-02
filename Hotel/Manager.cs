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
    
    public partial class Manager
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Manager()
        {
            this.CalendarManagers = new HashSet<CalendarManager>();
            this.InventoryAdds = new HashSet<InventoryAdd>();
            this.Payrolls = new HashSet<Payroll>();
            this.Penalties = new HashSet<Penalty>();
            this.ReportIncomes = new HashSet<ReportIncome>();
            this.ReportInventories = new HashSet<ReportInventory>();
        }
    
        public string ID_Manager { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public byte[] Picture { get; set; }
    
        public virtual AccountManager AccountManager { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalendarManager> CalendarManagers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InventoryAdd> InventoryAdds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payroll> Payrolls { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Penalty> Penalties { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportIncome> ReportIncomes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReportInventory> ReportInventories { get; set; }
    }
}
