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
    
    public partial class SalaryInfomation_AddSalary
    {
        public int ID { get; set; }
        public Nullable<int> SalaryInformationID { get; set; }
        public Nullable<int> AddSalaryID { get; set; }
        public Nullable<decimal> amount { get; set; }
    
        public virtual AddSalary AddSalary { get; set; }
        public virtual SalaryInformation SalaryInformation { get; set; }
    }
}
