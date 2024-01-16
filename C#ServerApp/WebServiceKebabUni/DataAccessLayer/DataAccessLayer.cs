using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Xml.Linq;
using WebServiceKebabUni;
using WebServiceKebabUni.DTO;

public static class DataAccessLayer
{
    public static string FirstLetterToUpperCase(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }
        else
        {
            return char.ToUpper(input[0]) + input.Substring(1);
        }
    }
    public static string FirstToSecondLetterToUpperCase(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }
        else
        {
            return char.ToUpper(input[0]).ToString() + char.ToUpper(input[1]).ToString() + input.Substring(2);
        }
    }
    public static List<CourseDTO> GetCourses()
    {
        using (var context = new SchoolEntities())
        {
            List<Course> courses = context.Courses.ToList();
            List<CourseDTO> courseDTOs = new List<CourseDTO>();
            foreach (var course in courses)
            {
                var faculty = new FacultyDTO
                {
                    FacultyId = course.FacultyID,
                    FacultyName = course.Faculty.FacultyName,
                    Address = course.Faculty.Address
                };

                var employee = new EmployeeDTO
                {
                    EmpId = course.EmpID,
                    EmployeeName = course.Employee.EmployeeName,
                    Salary = (int)course.Employee.Salary,
                    Faculty = faculty
                };

                CourseDTO courseDTO = new CourseDTO
                {
                    CourseId = course.CourseID,
                    Faculty = faculty,
                    Credits = (int)course.Credits,
                    Description = course.Description,
                    Employee = employee
                };

                foreach (var studentStudy in course.StudentStudies)
                {
                    courseDTO.StudentStudyList.Add(new StudentStudyDTO
                    {
                        Student = new StudentDTO { StudentId = studentStudy.StudentID, StudentName = studentStudy.Student.StudentName, Address = studentStudy.Student.Address },
                        StartDate = studentStudy.StartDate,
                        //have to fix this problem---- gives 0001 0001 on null values
                        EndDate = studentStudy.EndDate.GetValueOrDefault()
                    }) ;
                }

                courseDTOs.Add(courseDTO);
            }
            return courseDTOs;
        }
    }
    public static void DeleteCourse(string CourseID)
    {
        using (var context = new SchoolEntities())
        {
            // Query the database for the entity to be deleted
            var course= context.Courses.Find(CourseID);
            if (course != null)
            {
                // Remove the entity from the DbSet
                context.Courses.Remove(course);

                // Save the changes to the database
                context.SaveChanges();
            }
        }
    }
    public static void AddCourse(string facultyId, int credits, string description, string empId)
    {
        facultyId = FirstLetterToUpperCase(facultyId);
        empId = FirstLetterToUpperCase(empId);
        description = FirstLetterToUpperCase(description);
        using (var context = new SchoolEntities())
        {
            string id = StudentDTO.GenerateId("C");
            Course newCourse = new Course
            {
                CourseID = id,
                FacultyID = facultyId,
                Credits  = credits,
                Description = description,
                EmpID = empId

            };
            context.Courses.Add(newCourse);
            context.SaveChanges();
        }
    }
    public static void UpdateCourse(string courseId, string facultyId, int credits, string description, string empId)
    {
        courseId = FirstLetterToUpperCase(courseId);
        facultyId = FirstLetterToUpperCase(facultyId);
        empId = FirstLetterToUpperCase(empId);
        using (var context = new SchoolEntities())
        {

            var course = context.Courses.Find(courseId);

            if (course != null)
            {
                course.CourseID = courseId;
                course.FacultyID = facultyId;
                course.Credits = credits;
                course.Description = description;
                course.EmpID = empId;
                context.SaveChanges();
            }
        }
    }

    public static void AddStudentStudy(string courseId, string studentId, DateTime startDate, DateTime endDate)
    {
        courseId = FirstLetterToUpperCase(courseId);
        studentId = FirstLetterToUpperCase(studentId);
        using (var context = new SchoolEntities())
        {
            StudentStudy newStudentStudy = new StudentStudy
            {
                CourseID = courseId,
                StudentID = studentId,
                StartDate = startDate,
                EndDate = endDate

            };
            context.StudentStudies.Add(newStudentStudy);
            context.SaveChanges();
        }
    }
    public static void DeleteStudentStudy(string studentId, string courseId)
    {
        using (var context = new SchoolEntities())
        {
            // Query the database for the entity to be deleted
            var studentStudy = context.StudentStudies.Find(studentId, courseId);
            if (studentStudy != null)
            {
                // Remove the entity from the DbSet
                context.StudentStudies.Remove(studentStudy);

                // Save the changes to the database
                context.SaveChanges();
            }
        }
    }
    public static void UpdateStudentStudy(string courseId, string studentId, DateTime startDate, DateTime endDate)
    {
        courseId = FirstLetterToUpperCase(courseId);
        studentId = FirstLetterToUpperCase(studentId);
        using (var context = new SchoolEntities())
        {
            var studentStudy = context.StudentStudies.Find(studentId, courseId);

            if (studentStudy != null)
            {
                studentStudy.CourseID = courseId;
                studentStudy.StudentID = studentId;
                studentStudy.StartDate = startDate;
                studentStudy.EndDate =  endDate;

                context.SaveChanges();
            }
        }
    }
    public static List<StudentStudyDTO> GetStudentStudy()
    {
        using (var context = new SchoolEntities())
        {
            List<StudentStudy> studentStudyList = context.StudentStudies.ToList();
            List<StudentStudyDTO> studentStudyDTOs = new List<StudentStudyDTO>();
            foreach (var studentStudy in studentStudyList)
            {
                var faculty = new FacultyDTO
                {
                    FacultyId = studentStudy.Course.FacultyID,
                    FacultyName = studentStudy.Course.Faculty.FacultyName,
                    Address = studentStudy.Course.Faculty.Address
                };

                var employee = new EmployeeDTO
                {
                    EmpId = studentStudy.Course.EmpID,
                    EmployeeName = studentStudy.Course.Employee.EmployeeName,
                    Salary = (int)studentStudy.Course.Employee.Salary,
                    Faculty = faculty
                };

                var course = new CourseDTO
                {
                    CourseId = studentStudy.CourseID,
                    Faculty = faculty,
                    Credits = (int)studentStudy.Course.Credits,
                    Description = studentStudy.Course.Description,
                    Employee = employee
                };

                var student = new StudentDTO
                {
                    StudentId = studentStudy.StudentID,
                    StudentName = studentStudy.Student.StudentName,
                    Address = studentStudy.Student.Address
                };

                StudentStudyDTO studentStudyDTO = new StudentStudyDTO
                {
                    Course = course,
                    Student = student,
                    StartDate = studentStudy.StartDate,
                    //have to fix this problem---- gives 0001 0001 on null values
                    EndDate = studentStudy.EndDate.GetValueOrDefault()
                };
                studentStudyDTOs.Add(studentStudyDTO);
            }
            return studentStudyDTOs;
        }
    }
    public static void AddStudent(string name, string address)
    {
        name = FirstLetterToUpperCase(name);
        address = FirstLetterToUpperCase(address);
        using (var context = new SchoolEntities())
        {
            string id = StudentDTO.GenerateId("S");
            Student newStudent = new Student
            {
                StudentID = id,
                StudentName = name,
                Address = address
            };
            context.Students.Add(newStudent);
            context.SaveChanges();
        }
    }
    public static void DeleteStudent(string studentId)
    {
        using (var context = new SchoolEntities())
        {
            // Query the database for the entity to be deleted
            var student = context.Students.Find(studentId);

            // Remove the entity from the DbSet
            context.Students.Remove(student);

            // Save the changes to the database
            context.SaveChanges();
        }
    }
    public static void UpdateStudent(string studentId, string name, string address)
    {
        studentId = FirstLetterToUpperCase(studentId);
        using (var context = new SchoolEntities())
        {
            var student = context.Students.Find(studentId);

            if (student != null)
            {
                student.StudentName = name;
                student.Address = address;

                context.SaveChanges();
            }
        }
    }

    public static List<StudentDTO> GetStudents()
    {
        using (var context = new SchoolEntities())
        {
            List<Student> students = context.Students.ToList();
            List<StudentDTO> studentDTOs = new List<StudentDTO>();
            foreach (var student in students)
            {
                StudentDTO studentDTO = new StudentDTO
                {
                    StudentId = student.StudentID,
                    StudentName = student.StudentName,
                    Address = student.Address
                };

                foreach (var studentStudy in student.StudentStudies)
                {
                    var faculty = new FacultyDTO
                    {
                        FacultyId = studentStudy.Course.FacultyID,
                        FacultyName = studentStudy.Course.Faculty.FacultyName,
                        Address = studentStudy.Course.Faculty.Address
                    };

                    var employee = new EmployeeDTO
                    {
                        EmpId = studentStudy.Course.EmpID,
                        EmployeeName = studentStudy.Course.Employee.EmployeeName,
                        Salary = (int)studentStudy.Course.Employee.Salary,
                        Faculty = faculty
                    };

                    var course = new CourseDTO
                    {
                        CourseId = studentStudy.CourseID,
                        Faculty = faculty,
                        Credits = (int)studentStudy.Course.Credits,
                        Description = studentStudy.Course.Description,
                        Employee = employee
                    };
                    studentDTO.StudentStudyList.Add(new StudentStudyDTO
                    {
                        Course = course,
                        StartDate = studentStudy.StartDate,
                        //have to fix this pro
                        //blem---- gives 0001 0001 on null values
                        EndDate = studentStudy.EndDate.GetValueOrDefault()
                    });
                }

                foreach (var result in student.Results)
                {
                    var faculty = new FacultyDTO
                    {
                        FacultyId = result.Exam.Course.FacultyID,
                        FacultyName = result.Exam.Course.Faculty.FacultyName,
                        Address = result.Exam.Course.Faculty.Address
                    };

                    var employee = new EmployeeDTO
                    {
                        EmpId = result.Exam.Course.EmpID,
                        EmployeeName = result.Exam.Course.Employee.EmployeeName,
                        Salary = (int)result.Exam.Course.Employee.Salary,
                        Faculty = faculty
                    };

                    var course = new CourseDTO
                    {
                        CourseId = result.Exam.CourseID,
                        Faculty = faculty,
                        Credits = (int)result.Exam.Course.Credits,
                        Description = result.Exam.Course.Description,
                        Employee = employee
                    };

                    var exam = new ExamDTO
                    {
                        ExamID = result.ExamID,
                        Course = course,
                        Room = result.Exam.Room,
                        ExamDate = (DateTime)result.Exam.ExamDate,
                        Credits = (int)result.Exam.Credits
                    };

                    studentDTO.ResultList.Add(new ResultDTO
                    {
                        Exam = exam,  
                        Points = (int)result.Points
                    });
                }
                studentDTOs.Add(studentDTO);
            }
            return studentDTOs;
        }
    }

    public static void DeleteEmployee(string employeeId)
    {
        using (var context = new SchoolEntities())
        {
            var employee = context.Employees.Find(employeeId);
            if (employee != null)
            {
                context.Employees.Remove(employee);

                context.SaveChanges();
            }
        }
    }



    public static List<EmployeeDTO> GetEmployees()
    {
        using (var context = new SchoolEntities())
        {
            List<Employee> employees = context.Employees.ToList();
            List<EmployeeDTO> employeeDTOs = new List<EmployeeDTO>();
            foreach (var employee in employees)
            {
                EmployeeDTO employeeDTO = new EmployeeDTO
                {
                    EmpId = employee.EmpID,
                    EmployeeName = employee.EmployeeName,
                    Salary = (int)employee.Salary,
                    Faculty = new FacultyDTO { FacultyId = employee.FacultyID, FacultyName = employee.Faculty.FacultyName, Address = employee.Faculty.Address  }
                };
                employeeDTOs.Add(employeeDTO);
            }
            return employeeDTOs;
        }
    }
    public static void AddEmployee(string employeeName, int salary, string facultyId)
    {
        employeeName = FirstLetterToUpperCase(employeeName);
        facultyId = FirstLetterToUpperCase(facultyId);
        using (var context = new SchoolEntities())
        {
            string id = EmployeeDTO.GenerateId("E");
            Employee newEmp = new Employee
            {
                EmpID = id,
                EmployeeName = employeeName,
                Salary = salary,
                FacultyID = facultyId
            };
            context.Employees.Add(newEmp);
            context.SaveChanges();
        }
    }
    public static void UpdateEmployee(string empId, string employeeName, int salary, string facultyId)
    {
        empId = FirstLetterToUpperCase(empId);
        facultyId = FirstLetterToUpperCase(facultyId);
        using (var context = new SchoolEntities())
        {
            var employee = context.Employees.Find(empId);

            if (employee != null)
            {
                employee.EmployeeName = employeeName;
                employee.Salary = salary;
                employee.FacultyID = facultyId;
                context.SaveChanges();
            }
        }
    }
    public static List<FacultyDTO> GetFaculties()
    {
        using (var context = new SchoolEntities())
        {
            List<Faculty> faculties = context.Faculties.ToList();
            List<FacultyDTO> facultyDTOs = new List<FacultyDTO>();
            foreach (var faculty in faculties)
            {
                FacultyDTO facultyDTO = new FacultyDTO
                {
                    FacultyId = faculty.FacultyID,
                    FacultyName = faculty.FacultyName,
                    Address = faculty.Address,
                };
                foreach (var employee in faculty.Employees)
                {
                    EmployeeDTO employeeDTO = new EmployeeDTO
                    {
                        EmpId = employee.EmpID,
                        EmployeeName = employee.EmployeeName,
                        Salary = (int)employee.Salary
                    };
                    facultyDTO.Employees.Add(employeeDTO);

                    foreach (var course in faculty.Courses)
                    {
                        facultyDTO.Courses.Add(new CourseDTO
                        {
                            CourseId = course.CourseID,
                            Credits = (int)course.Credits,
                            Description = course.Description,
                            Employee = employeeDTO
                        });
                    }
                }        
                    facultyDTOs.Add(facultyDTO);
            }
            return facultyDTOs;
        }
    }
    public static void DeleteFaculty(string FacultyId)
    {
        using (var context = new SchoolEntities())
        {
            var faculty = context.Faculties.Find(FacultyId);
            if (faculty != null)
            {
                context.Faculties.Remove(faculty);

                context.SaveChanges();
            }
        }
    }
    public static void AddFaculty(string facultyName, string address)
    {
        facultyName = FirstLetterToUpperCase(facultyName);
        address = FirstLetterToUpperCase(facultyName);
        using (var context = new SchoolEntities())
        {
            string id = FacultyDTO.GenerateId("F");
            Faculty newFaculty = new Faculty
            {
                FacultyID = id,
                FacultyName = facultyName,
                Address = address
            };
            context.Faculties.Add(newFaculty);
            context.SaveChanges();
        }
    }
    public static void UpdateFaculty(string facultyId, string facultyName, string address)
    {
        facultyId = FirstLetterToUpperCase(facultyId);
        using (var context = new SchoolEntities())
        {
            var faculty = context.Faculties.Find(facultyId);

            if (faculty != null)
            {
                faculty.FacultyName = facultyName;
                faculty.Address = address;

                context.SaveChanges();
            }
        }
    }

    public static List<ExamDTO> GetExams()
    {
        using (var context = new SchoolEntities())
        {
            var exams = context.Exams.ToList();
            var examDTOs = new List<ExamDTO>();

            foreach (var exam in exams)
            {
                var course = exam.Course;
                var faculty = course.Faculty;
                var employee = course.Employee;

                var facultyDTO = new FacultyDTO
                {
                    FacultyId = faculty.FacultyID,
                    FacultyName = faculty.FacultyName,
                    Address = faculty.Address
                };

                var employeeDTO = new EmployeeDTO
                {
                    EmpId = employee.EmpID,
                    EmployeeName = employee.EmployeeName,
                    Salary = (int)employee.Salary,
                    Faculty = facultyDTO
                };

                var courseDTO = new CourseDTO
                {
                    CourseId = course.CourseID,
                    Description = course.Description,
                    Credits = (int)course.Credits,
                    Employee = employeeDTO,
                    Faculty = facultyDTO
                };

                var examDTO = new ExamDTO
                {
                    ExamID = exam.ExamID,
                    Room = exam.Room,
                    ExamDate = exam.ExamDate.GetValueOrDefault(),
                    Credits = (int)exam.Credits,
                    Course = courseDTO
                };

                examDTOs.Add(examDTO);
            }

            return examDTOs;
        }
    }
    public static void AddExam(string courseId, string room, DateTime examDate, int credits)
    {
        courseId = FirstLetterToUpperCase(courseId);
        using (var context = new SchoolEntities())
        {
            string id = ExamDTO.GenerateId("EX");
            Exam newExam = new Exam
            {
                ExamID = id,
                CourseID = courseId,
                Room= room,
                ExamDate = examDate,
                Credits = credits
            };
            context.Exams.Add(newExam);
            context.SaveChanges();
        }
    }
    public static void UpdateExam(string examId, string courseId, string room, DateTime examDate, int credits)
    {
        examId = FirstToSecondLetterToUpperCase(examId);
        courseId = FirstLetterToUpperCase(courseId);
        using (var context = new SchoolEntities())
        {
            var exam = context.Exams.Find(examId);

            if (exam != null)
            {
                exam.ExamID = examId;
                exam.CourseID = courseId;
                exam.Room = room;
                exam.ExamDate = examDate;
                exam.Credits = credits;
                context.SaveChanges();
            }
        }
    }

    public static void DeleteExam(string examId)
    {
        using (var context = new SchoolEntities())
        {
            var exam = context.Exams.Find(examId);
            if (exam != null)
            {
                context.Exams.Remove(exam);

                context.SaveChanges();
            }
        }
    }


    public static List<ResultDTO> GetResults()
    {
        using (var context = new SchoolEntities())
        {
            List<Result> resultList = context.Results.ToList();
            List<ResultDTO> resultDTOs = new List<ResultDTO>();
            foreach (var result in resultList)
            {

                var faculty = new FacultyDTO
                {
                    FacultyId = result.Exam.Course.FacultyID,
                    FacultyName = result.Exam.Course.Faculty.FacultyName,
                    Address = result.Exam.Course.Faculty.Address
                };

                var employee = new EmployeeDTO
                {
                    EmpId = result.Exam.Course.EmpID,
                    EmployeeName = result.Exam.Course.Employee.EmployeeName,
                    Salary = (int)result.Exam.Course.Employee.Salary,
                    Faculty = faculty
                };

                var course = new CourseDTO
                {
                    CourseId = result.Exam.CourseID,
                    Faculty = faculty,
                    Credits = (int)result.Exam.Course.Credits,
                    Description = result.Exam.Course.Description,
                    Employee = employee
                };

                var exam = new ExamDTO
                {
                    ExamID = result.Exam.ExamID,
                    Course = course,
                    Room = result.Exam.Room
                };

                var student = new StudentDTO
                {
                    StudentId = result.StudentID,
                    StudentName = result.Student.StudentName,
                    Address = result.Student.Address
                };

                ResultDTO resultDTO = new ResultDTO
                {
                    Exam = exam,
                    Student = student,
                    Points = (int)result.Points
                };
                resultDTOs.Add(resultDTO);
            }
            return resultDTOs;
        }
    }
    public static void AddResult(string examId, string studentId, int points)
    {
        examId = FirstToSecondLetterToUpperCase(examId);
        studentId = FirstLetterToUpperCase(studentId);
        using (var context = new SchoolEntities())
        {   
            Result newResult= new Result
            {
                ExamID = examId,
                StudentID = studentId,
                Points = points
            };
            context.Results.Add(newResult);
            context.SaveChanges();
        }
    }
    public static void UpdateResult(string examId, string studentId, int points)
    {
        examId = FirstToSecondLetterToUpperCase(examId);
        studentId = FirstLetterToUpperCase(studentId);
        using (var context = new SchoolEntities())
        {
            var result = context.Results.Find(studentId, examId);

            if (result != null)
            {
                result.ExamID = examId;
                result.StudentID = studentId;
                result.Points = points;

                context.SaveChanges();
            }
        }
    }
    public static void DeleteResult(string examId, string studentId)
    {
        using (var context = new SchoolEntities())
        {
            var result = context.Results.Find(studentId, examId);

            if (result != null)
            {
                context.Results.Remove(result);

                context.SaveChanges();
            }
        }
    }
}


