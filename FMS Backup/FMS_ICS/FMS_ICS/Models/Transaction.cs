//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FMS_ICS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int TransactionID { get; set; }
        public int PurchaseID { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public decimal AmountPaid { get; set; }
        public Nullable<decimal> RemainingAmount { get; set; }
    
        public virtual Purchase Purchase { get; set; }
    }
}
