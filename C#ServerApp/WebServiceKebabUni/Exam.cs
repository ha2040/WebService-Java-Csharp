//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceKebabUni
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Exam()
        {
            this.Results = new HashSet<Result>();
        }
    
        public string ExamID { get; set; }
        public string CourseID { get; set; }
        public string Room { get; set; }
        public Nullable<System.DateTime> ExamDate { get; set; }
        public Nullable<int> Credits { get; set; }
    
        public virtual Course Course { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual HashSet<Result> Results { get; set; }
    }
}
