using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceKebabUni.DTO
{
    public class ExamDTO
    {
        public string ExamID { get; set; }
        public CourseDTO Course { get; set; }
        public string Room { get; set; }
        public DateTime ExamDate { get; set; }
        public int Credits { get; set; }
        public List<ResultDTO> Results { get; set; }
        public ExamDTO()
        {
            Results = new List<ResultDTO>();
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