using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceKebabUni.DTO
{
    public class FacultyDTO
    {
        public string FacultyId { get; set; }
        public string FacultyName { get; set; }
        public string Address { get; set; }
        public List<EmployeeDTO> Employees { get; set; }
        public List<CourseDTO> Courses{ get; set; }
        public FacultyDTO()
        {
            Employees = new List<EmployeeDTO>();
            Courses = new List<CourseDTO>();
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