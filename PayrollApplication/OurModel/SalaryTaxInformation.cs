//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PayrollApplication.OurModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalaryTaxInformation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalaryTaxInformation()
        {
            this.SalaryInformations = new HashSet<SalaryInformation>();
        }
    
        public int ID { get; set; }
        public Nullable<decimal> Taxpercent { get; set; }
        public Nullable<decimal> MaxValue { get; set; }
        public Nullable<decimal> MinValue { get; set; }
        public Nullable<decimal> TaxValue { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalaryInformation> SalaryInformations { get; set; }
    }
}
