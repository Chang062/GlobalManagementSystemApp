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
    
    public partial class Invoice
    {
        public int ID { get; set; }
        public int Product_ID { get; set; }
        public int Transaction_ID { get; set; }
        public decimal Vat { get; set; }
        public int Qty { get; set; }
    
        public virtual Product_details Product_details { get; set; }
        public virtual Transaction_info Transaction_info { get; set; }
    }
}