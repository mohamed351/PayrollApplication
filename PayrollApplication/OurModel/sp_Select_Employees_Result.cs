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
    
    public partial class sp_Select_Employees_Result
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<System.Guid> EmployeeNumber { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public Nullable<System.DateTime> HireDate { get; set; }
        public Nullable<System.DateTime> DateOFBirth { get; set; }
        public byte[] Picture { get; set; }
        public string PictureUrl { get; set; }
        public Nullable<bool> ISActive { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public string password { get; set; }
        public Nullable<int> FingerPrintNumber { get; set; }
        public string Marital_status { get; set; }
        public string Gender { get; set; }
        public Nullable<int> JobID { get; set; }
        public string username { get; set; }
    }
}