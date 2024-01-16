using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceKebabUni.DTO
{
    public class StudentDTO
    {
        public string StudentName { get; set; }
        public string StudentId { get; set; }
        public string Address { get; set; }
        public List<ResultDTO> ResultList { get; set; }
        public List<StudentStudyDTO> StudentStudyList { get; set; }
        public StudentDTO()
        {
            ResultList = new List<ResultDTO>();
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
