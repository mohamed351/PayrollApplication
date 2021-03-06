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
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.AttendanceDays_Employees = new HashSet<AttendanceDays_Employees>();
            this.Departments = new HashSet<Department>();
            this.Have_Login_Program = new HashSet<Have_Login_Program>();
            this.SalaryInformations = new HashSet<SalaryInformation>();
            this.Bank_Informations = new HashSet<Bank_Informations>();
        }
    
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
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttendanceDays_Employees> AttendanceDays_Employees { get; set; }
        public virtual Department Department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Department> Departments { get; set; }
        public virtual JobTitle JobTitle { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Have_Login_Program> Have_Login_Program { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalaryInformation> SalaryInformations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bank_Informations> Bank_Informations { get; set; }
    }
}
