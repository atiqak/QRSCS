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
    
    public partial class Speech_Therapy_Assessment
    {
        public int Speech_Therapy_Assessment_ID { get; set; }
        public int GR_NO { get; set; }
        public string Speech_Test_Image { get; set; }
        public System.DateTime Date_of_Assessment { get; set; }
    
        public virtual New_Admission New_Admission { get; set; }
    }
}
