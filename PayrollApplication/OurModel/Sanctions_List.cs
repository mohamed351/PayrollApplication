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
    
    public partial class Sanctions_List
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sanctions_List()
        {
            this.SubTractSalaries = new HashSet<SubTractSalary>();
        }
    
        public int ID { get; set; }
        public string Sanction_Name { get; set; }
        public string Sanction_Decription { get; set; }
        public Nullable<bool> ISDeleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubTractSalary> SubTractSalaries { get; set; }
    }
}
