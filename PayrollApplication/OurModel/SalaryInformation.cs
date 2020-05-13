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
    
    public partial class SalaryInformation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalaryInformation()
        {
            this.Bank_Informations = new HashSet<Bank_Informations>();
            this.SalaryInfomation_AddSalary = new HashSet<SalaryInfomation_AddSalary>();
            this.SalaryInformation_SubTrack = new HashSet<SalaryInformation_SubTrack>();
            this.Bank_Informations1 = new HashSet<Bank_Informations>();
        }
    
        public int ID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<System.DateTime> DateOFSalary { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public Nullable<decimal> AllSalary { get; set; }
        public string AccountName { get; set; }
        public Nullable<int> TaxInformationID { get; set; }
        public Nullable<decimal> Insurance { get; set; }
        public Nullable<decimal> SalaryAfterInsurance { get; set; }
        public Nullable<decimal> TaxValue { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bank_Informations> Bank_Informations { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalaryInfomation_AddSalary> SalaryInfomation_AddSalary { get; set; }
        public virtual SalaryTaxInformation SalaryTaxInformation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalaryInformation_SubTrack> SalaryInformation_SubTrack { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bank_Informations> Bank_Informations1 { get; set; }
    }
}
