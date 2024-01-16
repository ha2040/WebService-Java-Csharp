using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceKebabUni.DTO
{
    public class StudentStudyDTO
    {
        public CourseDTO Course { get; set; }
        public StudentDTO Student { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        
    }
}