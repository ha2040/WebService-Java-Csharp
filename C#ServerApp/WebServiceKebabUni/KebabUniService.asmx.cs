using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Services;
using WebServiceKebabUni.DTO;

namespace WebServiceKebabUni
{
    /// <summary>
    /// Summary description for KebabUniService
    /// </summary>
    [WebService(Namespace = "http://ics.lu.se/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class KebabUniService : System.Web.Services.WebService
    {
        [WebMethod(Description = "Returns a list of all courses and their respective faculties and employees")]
        public List<CourseDTO> GetCourses()
        {
            return DataAccessLayer.GetCourses();
        }
        [WebMethod(Description = "Adds a new Course to the database")]
        public void AddCourse(string facultyId, int credits, string description, string EmpId)
        {
            DataAccessLayer.AddCourse(facultyId, credits, description, EmpId);
        }
        [WebMethod(Description = "Updates a Course with the new values")]
        public void UpdateCourse(string courseId, string facultyId, int credits, string description, string EmpId)
        {
            DataAccessLayer.UpdateCourse(courseId, facultyId, credits, description, EmpId);
        }
        [WebMethod(Description = "Deletes a Course from the database")]
        public void DeleteCourse(string id)
        {
            DataAccessLayer.DeleteCourse(id);
        }
        [WebMethod(Description = "Adds a new StudentStudy to the database")]
        public void AddStudentStudy(string courseId, string studentId, DateTime startDate, DateTime endDate) 
        {
            DataAccessLayer.AddStudentStudy(courseId, studentId, startDate, endDate);
        }
        [WebMethod(Description = "Returns a list of all StudentStudy and their respective courses and students")]
        public List<StudentStudyDTO> GetStudentStudy()
        {
            return DataAccessLayer.GetStudentStudy();
        }
        [WebMethod(Description = "Deletes a StudentStudy from the database")]
        public void DeleteStudentStudy(string studentId, string courseId)
        {
            DataAccessLayer.DeleteStudentStudy(studentId, courseId);
        }
        [WebMethod(Description = "Updates a StudentStudy with the new values")]
        public void UpdateStudentStudy(string courseId, string studentId, DateTime startDate, DateTime endDate)
        {
            DataAccessLayer.UpdateStudentStudy(courseId, studentId, startDate, endDate);
        }
        [WebMethod(Description = "Returns a list of all employees and their respective Faculties")]
        public List<EmployeeDTO> GetEmployees()
        {
            List<EmployeeDTO> employees = DataAccessLayer.GetEmployees();
            return employees;
        }

        [WebMethod(Description = "Adds a new Employee to the database")]
        public void AddEmployee(string employeeName, int salary, string faculty)
        {
            DataAccessLayer.AddEmployee( employeeName,  salary, faculty);
        }
        [WebMethod(Description = "Deletes a Employee from the database")]
        public void DeleteEmployee(string id)
        {
            DataAccessLayer.DeleteEmployee(id);
        }
        [WebMethod(Description = "Updates a Employee with the new values")]
        public void UpdateEmployee(string empId, string employeeName, int salary, string facultyId)
        {
            DataAccessLayer.UpdateEmployee(empId, employeeName, salary, facultyId);
        }
        [WebMethod(Description = "Returns a list of all Faculties")]
        public List<FacultyDTO> GetFaculties()
        {
            List<FacultyDTO> faculties = DataAccessLayer.GetFaculties();
            return faculties;
        }
        [WebMethod(Description = "Adds a new Faculty to the database")]
        public void AddFaculty(string facultyName, string address)
        {
            DataAccessLayer.AddFaculty(facultyName, address);
        }
        [WebMethod(Description = "Updates a Faculty with the new values")]
        public void UpdateFaculty(string facultyId, string facultyName, string address)
        {
            DataAccessLayer.UpdateFaculty(facultyId, facultyName, address);
        }
        [WebMethod(Description = "Deletes a Faculty from the database")]
        public void DeleteFaculty(string id)
        {
            DataAccessLayer.DeleteFaculty(id);
        }


        [WebMethod(Description = "Adds a new student to the database")]
        public void AddStudent(string name, string address)
        {
            DataAccessLayer.AddStudent(name, address);
        }

        [WebMethod(Description = "Returns a list of all students")]
        public List<StudentDTO> GetStudents()
        {
            List<StudentDTO> students = DataAccessLayer.GetStudents();
            return students;
        }
        [WebMethod(Description = "Deletes a student from the database")]
        public void DeleteStudent(string id)
        {
            DataAccessLayer.DeleteStudent(id);
        }
        [WebMethod(Description = "Updates a student with the new values")]
        public void UpdateStudent(string studentId, string name, string address)
        {
            DataAccessLayer.UpdateStudent(studentId, name, address);
        }
        [WebMethod(Description = "Returns a list of all exams and their respective courses and employees and their faculties")]
        public List<ExamDTO> GetExams()
        {
            return DataAccessLayer.GetExams();
        }
        [WebMethod(Description = "Updates an Exam with the new values")]
        public void UpdateExam(string examId, string courseId, string room, DateTime examDate, int credits)
        {
            DataAccessLayer.UpdateExam(examId, courseId, room, examDate,credits);
        }
        [WebMethod(Description = "Adds a new Exam to the database")]
        public void AddExam(string courseId, string room, DateTime examDate, int credits)
        {
            DataAccessLayer.AddExam(courseId, room, examDate, credits);
        }
        [WebMethod(Description = "Deletes a Exam from the database")]
        public void DeleteExam(string examId)
        {
            DataAccessLayer.DeleteExam(examId);
        }

        [WebMethod(Description = "Returns a list of all Results and their respective exams and students")]
        public List<ResultDTO> GetResults() 
        {
            return DataAccessLayer.GetResults();
        }
        [WebMethod(Description = "Updates a Result with the new values")]
        public void UpdateResult(string examId, string studentId, int points)
        {
            DataAccessLayer.UpdateResult(examId, studentId, points);
        }
        [WebMethod(Description = "Adds a new Result to the database")]
        public void AddResult (string examId, string studentId, int points)
        {
            DataAccessLayer.AddResult(examId, studentId, points);
        }
        [WebMethod(Description = "Deletes a Result from the database")]
        public void DeleteResult(string examId, string studentId)
        {
            DataAccessLayer.DeleteResult(examId, studentId);
        }


    }
}
