//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GlobalManagementSystemApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Transaction_info = new HashSet<Transaction_info>();
        }
    
        public int ID { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email_addr { get; set; }
        public decimal Contact_no { get; set; }
        public Nullable<int> Parish_ID { get; set; }
        public string Address { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Transaction_info> Transaction_info { get; set; }
        public virtual Parish Parish { get; set; }
    }
}