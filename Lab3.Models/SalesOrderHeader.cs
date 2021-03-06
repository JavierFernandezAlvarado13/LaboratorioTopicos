//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab3.Models
{
    using System;
    using System.Collections.Generic;
     
using System.Runtime.Serialization;
    [DataContract]
public partial class SalesOrderHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalesOrderHeader()
        {
            this.SalesOrderDetails = new HashSet<SalesOrderDetail>();
        }
    
        	[DataMember]
public int SalesOrderID { get; set; }
        	[DataMember]
public byte RevisionNumber { get; set; }
        	[DataMember]
public System.DateTime OrderDate { get; set; }
        	[DataMember]
public System.DateTime DueDate { get; set; }
        	[DataMember]
public Nullable<System.DateTime> ShipDate { get; set; }
        	[DataMember]
public byte Status { get; set; }
        	[DataMember]
public bool OnlineOrderFlag { get; set; }
        	[DataMember]
public string SalesOrderNumber { get; set; }
        	[DataMember]
public string PurchaseOrderNumber { get; set; }
        	[DataMember]
public string AccountNumber { get; set; }
        	[DataMember]
public int CustomerID { get; set; }
        	[DataMember]
public Nullable<int> SalesPersonID { get; set; }
        	[DataMember]
public Nullable<int> TerritoryID { get; set; }
        	[DataMember]
public int BillToAddressID { get; set; }
        	[DataMember]
public int ShipToAddressID { get; set; }
        	[DataMember]
public int ShipMethodID { get; set; }
        	[DataMember]
public Nullable<int> CreditCardID { get; set; }
        	[DataMember]
public string CreditCardApprovalCode { get; set; }
        	[DataMember]
public Nullable<int> CurrencyRateID { get; set; }
        	[DataMember]
public decimal SubTotal { get; set; }
        	[DataMember]
public decimal TaxAmt { get; set; }
        	[DataMember]
public decimal Freight { get; set; }
        	[DataMember]
public decimal TotalDue { get; set; }
        	[DataMember]
public string Comment { get; set; }
        	[DataMember]
public System.Guid rowguid { get; set; }
        	[DataMember]
public System.DateTime ModifiedDate { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual Address Address1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
    }
}
