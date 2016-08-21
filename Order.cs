//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MangoCarrierSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.ShippingLabels = new HashSet<ShippingLabel>();
        }
    
        public int ID { get; set; }
        public string FULL_NAME { get; set; }
        public Nullable<System.DateTime> SHIPMENT_DATE { get; set; }
        public Nullable<int> BOX_NUMBER { get; set; }
        public string ORDERID { get; set; }
        public string COUNTRY { get; set; }
        public string ZIPCODE { get; set; }
        public string LOCATION { get; set; }
        public string PROVINCE { get; set; }
        public string ADDRESS { get; set; }
        public string WEIGHT { get; set; }
        public string TOTALOFBOXES { get; set; }
        public string TOTALAMOUNT { get; set; }
        public string CURRENCY_EUR { get; set; }
        public string VOTF { get; set; }
        public string SERVICECODE { get; set; }
        public string SERVICE { get; set; }
        public string MERCHANDISE_TYPE { get; set; }
        public string INVOICING_COMPANY { get; set; }
        public string DEBTOR { get; set; }
        public string STORE_TELEPHONE { get; set; }
        public string DELIVER_TO { get; set; }
        public string STORE { get; set; }
        public string BOX_VOLUME { get; set; }
        public string BOX_MEASUREMENTS { get; set; }
        public string ID_CARD { get; set; }
        public string COD { get; set; }
        public string TRACKING_NR_DEVO { get; set; }
        public string CIF_VALUE { get; set; }
        public string CURRENCY_NON_UE { get; set; }
        public string EMAIL { get; set; }
        public string COMPANY { get; set; }
        public string NAME_PACKSTATION { get; set; }
        public string PHONE { get; set; }
        public int STAUTS { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShippingLabel> ShippingLabels { get; set; }
    }
}