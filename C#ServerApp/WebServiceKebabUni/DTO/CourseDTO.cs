using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceKebabUni.DTO
{
    public class CourseDTO
    {
        public string CourseId { get; set; }
        public FacultyDTO Faculty { get; set; }
        public int Credits { get; set; }
        public string Description { get; set; }
        public EmployeeDTO Employee { get; set; }
        public List<StudentStudyDTO> StudentStudyList { get; set; }
        public CourseDTO()
        {
            StudentStudyList = new List<StudentStudyDTO>();
        }
        public static string GenerateId(string prefix)
        {
            string newId = prefix;
            Random rnd = new Random();
            newId += rnd.Next(1, 1000).ToString("D3");
            return newId;
        }
    }
}