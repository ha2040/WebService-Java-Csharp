using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceKebabUni.DTO
{
    public class ResultDTO
    {
        public ExamDTO Exam { get; set; }
        public StudentDTO Student { get; set; }
        public int Points { get; set; } 
    }
}