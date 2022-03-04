//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QRSCS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.New_Admission = new HashSet<New_Admission>();
            this.Create_Teacher = new HashSet<Create_Teacher>();
        }
    
        public int User_ID { get; set; }
        public string Picture { get; set; }
        public string Full_Name { get; set; }
        public string Father_Name { get; set; }
        public string NIC { get; set; }
        public string Gender { get; set; }
        public System.DateTime DOB { get; set; }
        public string Contact_Number { get; set; }
        public string Rank { get; set; }
        public string Designation_Role { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Nullable<System.DateTime> Creation_Date { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Update_Date { get; set; }
        public string Updated_By { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<New_Admission> New_Admission { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Create_Teacher> Create_Teacher { get; set; }
    }
}