using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceKebabUni.DTO
{
    public class EmployeeDTO
    {
        public string EmpId { get; set; }
        public string EmployeeName { get; set; }
        public int Salary { get; set; }
        public FacultyDTO Faculty { get; set; }
        public List<CourseDTO> Courses { get; set; }

        public EmployeeDTO()
        {
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