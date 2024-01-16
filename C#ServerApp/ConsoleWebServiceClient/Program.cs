//// See https://aka.ms/new-console-template for more information
//using System.Text.RegularExpressions;
//using System.Xml.Linq;
//using KebabUniService;


//var endpointConfiguration = KebabUniServiceSoapClient.EndpointConfiguration.KebabUniServiceSoap;

//KebabUniServiceSoapClient kebabUniService = new(endpointConfiguration);



//List<EmployeeDTO> employees = kebabUniService.GetEmployees();
//List<StudentDTO> students = kebabUniService.GetStudents();
//List<FacultyDTO> faculties = kebabUniService.GetFaculties();
//List<ExamDTO> exams = kebabUniService.GetExams();
//List<ResultDTO> results = kebabUniService.GetResults();
//List<CourseDTO> courses = kebabUniService.GetCourses();
//List<StudentStudyDTO> studentStudies = kebabUniService.GetStudentStudy();


//Console.WriteLine("Welcome to the KebabServiceUni Manager!");
//string userInput = "";
//while (!userInput.Equals("Exit", StringComparison.OrdinalIgnoreCase))
//{
//    Console.WriteLine("What would you like to do? (Add, Read, Update, Delete, Exit)");
//    userInput = Console.ReadLine();

//    if (userInput.Equals("Exit", StringComparison.OrdinalIgnoreCase))
//    {
//        break;
//    }
//    else if (userInput.Equals("Add", StringComparison.OrdinalIgnoreCase))
//    {
//        Console.WriteLine("Would you like to add an Employee, Student, Faculty, Course, Exam, Result, or StudentStudy?");

//        string addInput = Console.ReadLine();
//        if (addInput.Equals("Employee", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Enter the first name of the Employee: ");
//            string firstName = Console.ReadLine();
//            if (!Regex.IsMatch(firstName, @"^[a-zA-ZÅÄÖåäö]+$"))
//            {
//                Console.WriteLine("Error: Please enter a valid first name using only letters.");
//                continue;
//            }
//            Console.WriteLine("Enter the surname of the Employee: ");
//            string lastName = Console.ReadLine();
//            if (!Regex.IsMatch(lastName, @"^[a-zA-ZÅÄÖåäö]+$"))
//            {
//                Console.WriteLine("Error: Please enter a valid first name using only letters.");
//                continue;
//            }
//            string name = firstName + " " + lastName;

//            Console.WriteLine("Enter the faculty assigned of the Employee: ");
//            string faculty = Console.ReadLine();

//            if (!Regex.IsMatch(faculty, @"^[a-zA-Z 0-9]+$"))
//            {
//                Console.WriteLine("Error: Please enter a valid faculty using only letters and numbers.");
//                continue;
//            }

//            Console.WriteLine("Enter the salary of the Employee: ");
//            string salaryInput = Console.ReadLine();
//            int salary;

//            if (!int.TryParse(salaryInput, out salary))
//            {
//                Console.WriteLine("Error: Please enter a valid salary in number format.");
//                continue;
//            }

//            kebabUniService.AddEmployee(name, salary, faculty);
//            Console.WriteLine("Employee: " + name + " added successfully.");
//            employees = kebabUniService.GetEmployees();
//        }

//        else if (addInput.Equals("Student", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Enter the first name of the Student: ");
//            string firstName = Console.ReadLine();
//            if (!Regex.IsMatch(firstName, @"^[a-zA-ZÅÄÖåäö]+$"))
//            {
//                Console.WriteLine("Error: Please enter a valid first name using only letters.");
//                continue;
//            }
//            Console.WriteLine("Enter the surname of the Student: ");
//            string lastName = Console.ReadLine();
//            if (!Regex.IsMatch(lastName, @"^[a-zA-ZÅÄÖåäö]+$"))
//            {
//                Console.WriteLine("Error: Please enter a valid first name using only letters.");
//                continue;
//            }
//            string name = firstName + " " + lastName;

//            Console.WriteLine("Enter the address of Student: ");
//            string address = Console.ReadLine();




//            kebabUniService.AddStudent(name, address);
//            Console.WriteLine("Student: " + name + " added successfully.");
//            students = kebabUniService.GetStudents();

//        }
//        else if (addInput.Equals("Faculty", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Enter the name of the Faculty: ");
//            string name = Console.ReadLine();
//            if (!Regex.IsMatch(name, @"^[a-zA-ZÅÄÖåäö ]+$"))
//            {
//                Console.WriteLine("Error: Please enter a valid  name using only letters.");
//                continue;
//            }


//            Console.WriteLine("Enter the address of Faculty: ");
//            string address = Console.ReadLine();




//            kebabUniService.AddFaculty(name, address);
//            Console.WriteLine("Faculty: " + name + " added successfully.");
//            faculties = kebabUniService.GetFaculties();

//        }
//        else if (addInput.Equals("Course", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Enter the Description of the Course: ");
//            string description = Console.ReadLine();
//            if (!Regex.IsMatch(description, @"^[a-zA-Z0-9]+$"))
//            {
//                Console.WriteLine("Error: Please enter a valid Description using only letters.");
//                continue;
//            }
//            Console.WriteLine("Enter the facultyid that the course belongs to: ");
//            string faculty = Console.ReadLine();
//            if (!Regex.IsMatch(faculty, @"^[a-zA-ZåäöÅÄÖ0-9 ]+$"))
//            {
//                Console.WriteLine("Error: Please enter a valid facultyid using only letters.");
//                continue;
//            }
//            Console.WriteLine("Enter the amount of credits the course holds: ");

//            string creditinput = Console.ReadLine();
//            int credits;

//            if (!int.TryParse(creditinput, out credits))
//            {
//                Console.WriteLine("Error: Please enter a valid credits in number format.");
//                continue;
//            }

//            Console.WriteLine("Enter the employeeID of the responsible employee on the course: ");
//            string empId = Console.ReadLine();
//            if (!Regex.IsMatch(empId, @"^[a-zA-ZåäöÅÄÖ0-9 ]+$"))
//            {
//                Console.WriteLine("Error: Please enter a valid employeeID using only letters.");
//                continue;
//            }

//            kebabUniService.AddCourse(faculty, credits, description, empId);
//            Console.WriteLine("Course: " + description + " added successfully.");
//            courses = kebabUniService.GetCourses();

//        }

//        else if (addInput.Equals("Exam", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Enter the Course Id of the exam: ");
//            string courseId = Console.ReadLine();
//            if (!Regex.IsMatch(courseId, @"^[a-zA-Z0-9]+$"))
//            {
//                Console.WriteLine("Error: Please enter a valid Course Id using only letters and numbers.");
//                continue;
//            }

//            Console.WriteLine("Enter the room where the exam will take place: ");
//            string room = Console.ReadLine();
//            if (!Regex.IsMatch(room, @"^[a-zA-Z0-9 ]+$"))
//            {
//                Console.WriteLine("Error: Please enter a valid room using only letters and numbers.");
//                continue;
//            }

//            Console.WriteLine("Enter the date of the exam (format: yyyy-mm-dd): ");
//            string dateInput = Console.ReadLine();
//            DateTime examDate;
//            if (!DateTime.TryParse(dateInput, out examDate))
//            {
//                Console.WriteLine("Error: Please enter a valid date using the format yyyy-mm-dd.");
//                continue;
//            }

//            Console.WriteLine("Enter the number of credits for the exam: ");
//            string creditInput = Console.ReadLine();
//            int credits;
//            if (!int.TryParse(creditInput, out credits))
//            {
//                Console.WriteLine("Error: Please enter a valid credit number.");
//                continue;
//            }

//            kebabUniService.AddExam(courseId, room, examDate, credits);
//            Console.WriteLine("Exam added successfully.");
//            exams = kebabUniService.GetExams();

//        }

//        else if (addInput.Equals("Result", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Enter the Student Id:");
//            string studentId = Console.ReadLine();
//            if (!Regex.IsMatch(studentId, @"^[a-zA-Z0-9]+$"))
//            {
//                Console.WriteLine("Error: Please enter a valid Student Id using only letters and numbers.");
//                continue;
//            }

//            Console.WriteLine("Enter the Course Id: ");
//            string courseId = Console.ReadLine();
//            if (!Regex.IsMatch(courseId, @"^[a-zA-Z0-9]+$"))
//            {
//                Console.WriteLine("Error: Please enter a valid Course Id using only letters and numbers.");
//                continue;
//            }

//            Console.WriteLine("Enter the Exam Id: ");
//            string examId = Console.ReadLine();
//            if (!Regex.IsMatch(examId, @"^[a-zA-Z0-9]+$"))
//            {
//                Console.WriteLine("Error: Please enter a valid Exam Id using only letters and numbers.");
//                continue;
//            }

//            Console.WriteLine("Enter the result of the exam: ");
//            string resultInput = Console.ReadLine();
//            int points;
//            if (!int.TryParse(resultInput, out points))
//            {
//                Console.WriteLine("Error: Please enter a valid result in number format.");
//                continue;
//            }

//            kebabUniService.AddResult(examId, studentId, points);
//            Console.WriteLine("Result added successfully.");
//            results = kebabUniService.GetResults();

//        }

//        else if (addInput.Equals("StudentStudy", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Enter the Course Id of the study: ");
//            string courseId = Console.ReadLine();
//            if (!Regex.IsMatch(courseId, @"^[a-zA-Z0-9]+$"))
//            {
//                Console.WriteLine("Error: Please enter a valid Course Id using only letters and numbers.");
//                continue;
//            }

//            Console.WriteLine("Enter the Id of the student: ");
//            string studentId = Console.ReadLine();
//            if (!Regex.IsMatch(studentId, @"^[a-zA-Z0-9]+$"))
//            {
//                Console.WriteLine("Error: Please enter a valid student Id using only letters and numbers.");
//                continue;
//            }

//            Console.WriteLine("Enter the start date of the study (format: yyyy-mm-dd): ");
//            string startDateInput = Console.ReadLine();
//            DateTime startDate;
//            if (!DateTime.TryParse(startDateInput, out startDate))
//            {
//                Console.WriteLine("Error: Please enter a valid date using the format yyyy-mm-dd.");
//                continue;
//            }

//            Console.WriteLine("Enter the end date of the study (format: yyyy-mm-dd): ");
//            string endDateInput = Console.ReadLine();
//            DateTime endDate;
//            if (!DateTime.TryParse(endDateInput, out endDate))
//            {
//                Console.WriteLine("Error: Please enter a valid date using the format yyyy-mm-dd.");
//                continue;
//            }

//            kebabUniService.AddStudentStudy(courseId, studentId, startDate, endDate);
//            Console.WriteLine("Student study added successfully.");
//            studentStudies = kebabUniService.GetStudentStudy();
//        }

//    }
//    else if (userInput.Equals("Delete", StringComparison.OrdinalIgnoreCase))
//    {
//        Console.WriteLine("Would you like to Delete an Employee, Student, Faculty, Course, Exam, Result, or StudentStudy?");

//        string deleteInput = Console.ReadLine();
//        if (deleteInput.Equals("Employee", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Enter the ID of the employee to delete: ");
//            string deleteId = Console.ReadLine();

//            bool found = false;
//            foreach (EmployeeDTO employee in employees)
//            {
//                if (employee.EmpId.Equals(deleteId, StringComparison.OrdinalIgnoreCase))
//                {
//                     Found a matching employee, perform the deletion
//                    kebabUniService.DeleteEmployee(deleteId);
//                    Console.WriteLine(deleteId + " deleted.");
//                    employees = kebabUniService.GetEmployees();
//                    found = true;
//                    break;
//                }
//            }

//            if (!found)
//            {
//                Console.WriteLine("Employee with ID " + deleteId + " not found.");
//            }

//        }
//        else if (deleteInput.Equals("Student", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Enter the ID of the Student to delete: ");
//            string deleteId = Console.ReadLine();


//            bool found = false;
//            foreach (StudentDTO student in students)
//            {
//                if (student.StudentId.Equals(deleteId, StringComparison.OrdinalIgnoreCase))
//                {
//                     Found a matching student, perform the deletion
//                    kebabUniService.DeleteStudent(deleteId);
//                    Console.WriteLine(deleteId + " deleted.");
//                    students = kebabUniService.GetStudents();
//                    found = true;
//                    break;
//                }
//            }

//            if (!found)
//            {
//                Console.WriteLine("student with ID " + deleteId + " not found.");
//            }
//        }
//        else if (deleteInput.Equals("Faculty", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Enter the ID of the Faculty to delete: ");
//            string deleteId = Console.ReadLine();
//            bool found = false;
//            foreach (FacultyDTO faculty in faculties)
//            {
//                if (faculty.FacultyId.Equals(deleteId, StringComparison.OrdinalIgnoreCase))
//                {
//                     Found a matching faculty, perform the deletion
//                    kebabUniService.DeleteFaculty(deleteId);
//                    Console.WriteLine(deleteId + " deleted.");
//                    faculties = kebabUniService.GetFaculties();
//                    found = true;
//                    break;
//                }
//            }

//            if (!found)
//            {
//                Console.WriteLine("faculty with ID " + deleteId + " not found.");
//            }
//        }
//        else if (deleteInput.Equals("Course", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Enter the ID of the Course to delete: ");
//            string deleteId = Console.ReadLine();

//            bool found = false;
//            foreach (CourseDTO course in courses)
//            {
//                if (course.CourseId.Equals(deleteId, StringComparison.OrdinalIgnoreCase))
//                {
//                     Found a matching faculty, perform the deletion
//                    kebabUniService.DeleteCourse(deleteId);
//                    Console.WriteLine(deleteId + " deleted.");
//                    courses = kebabUniService.GetCourses();
//                    found = true;
//                    break;
//                }
//            }

//            if (!found)
//            {
//                Console.WriteLine("course with ID " + deleteId + " not found.");
//            }
//        }
//        else if (deleteInput.Equals("Exam", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Enter the ID of the exam to delete: ");
//            string deleteId = Console.ReadLine();

//            bool found = false;
//            foreach (ExamDTO exam in exams)
//            {
//                if (exam.ExamID.Equals(deleteId, StringComparison.OrdinalIgnoreCase))
//                {
//                     Found a matching faculty, perform the deletion
//                    kebabUniService.DeleteExam(deleteId);
//                    Console.WriteLine(deleteId + " deleted.");
//                    exams = kebabUniService.GetExams();
//                    found = true;
//                    break;
//                }
//            }

//            if (!found)
//            {
//                Console.WriteLine("exam with ID " + deleteId + " not found.");
//            }
//        }
//        else if (deleteInput.Equals("Result", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Enter the ID of the student to delete: ");
//            string studentId = Console.ReadLine();
//            Console.WriteLine("Enter the ID of the exam to delete: ");
//            string examId = Console.ReadLine();

//            bool found = false;
//            foreach (ResultDTO result in results)
//            {
//                if (result.Student.StudentId.Equals(studentId, StringComparison.OrdinalIgnoreCase) && result.Exam.ExamID.Equals(studentId, StringComparison.OrdinalIgnoreCase))
//                {
//                     Found a matching faculty, perform the deletion
//                    kebabUniService.DeleteResult(studentId, examId);
//                    Console.WriteLine("result from " + studentId + "and exam id:" + examId + " deleted.");
//                    results = kebabUniService.GetResults();
//                    found = true;
//                    break;
//                }
//            }

//            if (!found)
//            {
//                Console.WriteLine("Result with examId: " + examId + " written by:" + studentId + " not found");
//            }
//        }
//        else if (deleteInput.Equals("StudentStudy", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Enter the ID of the student to delete: ");
//            string studentId = Console.ReadLine();
//            Console.WriteLine("Enter the ID of the course to delete: ");
//            string courseId = Console.ReadLine();
//            kebabUniService.DeleteStudentStudy(studentId, courseId);
//            bool found = false;
//            foreach (StudentStudyDTO studentStudy in studentStudies)
//            {
//                if (studentStudy.Student.StudentId.Equals(studentId, StringComparison.OrdinalIgnoreCase) && studentStudy.Course.CourseId.Equals(courseId, StringComparison.OrdinalIgnoreCase))
//                {
//                     Found a matching faculty, perform the deletion
//                    kebabUniService.DeleteStudentStudy(studentId, courseId);
//                    Console.WriteLine(studentId + "studying in course: " + courseId + " deleted.");
//                    studentStudies = kebabUniService.GetStudentStudy();
//                    found = true;
//                    break;
//                }
//            }

//            if (!found)
//            {
//                Console.WriteLine("StudentStudy with ID " + studentId + " or " + courseId + "was not found");
//            }

//        }


//    }
//    else if (userInput.Equals("Read", StringComparison.OrdinalIgnoreCase))
//    {
//        Console.WriteLine("Would you like to retrive the list of all Employee, Student, Faculty, Course, Exam, Result, or StudentStudy?");
//        string readInput = Console.ReadLine();
//        if (readInput.Equals("Employee", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Employees:");
//            foreach (EmployeeDTO employee in employees)
//            {
//                Console.WriteLine($"Id: {employee.EmpId}, Name: {employee.EmployeeName}, Salary: {employee.Salary}, Faculty: {employee.Faculty.FacultyName} (ID: {employee.Faculty.FacultyId}) ");
//            }
//        }
//        else if (readInput.Equals("Student", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Students:");
//            foreach (StudentDTO student in students)
//            {
//                Console.WriteLine($"Id: {student.StudentId}, Name: {student.StudentName}, Address: {student.Address}");
//            }
//        }
//        else if (readInput.Equals("Faculty", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Faculties:");
//            foreach (FacultyDTO faculty in faculties)
//            {
//                Console.WriteLine($"Id: {faculty.FacultyId}, Name: {faculty.FacultyName}, Address: {faculty.Address}");
//            }
//        }
//        else if (readInput.Equals("Course", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Courses:");
//            foreach (CourseDTO course in courses)
//            {
//                Console.WriteLine($"Id: {course.CourseId}, FacultyName: {course.Faculty.FacultyName} (ID: {course.Faculty.FacultyId}), Credits: {course.Credits}, " +
//                    $"Description: {course.Description}, Employee: {course.Employee.EmployeeName} (ID: {course.Employee.EmpId}");
//            }
//        }
//        else if (readInput.Equals("Exam", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Exams:");
//            foreach (ExamDTO exam in exams)
//            {
//                Console.WriteLine($"Id: {exam.ExamID}, Course: {exam.Course.Description} (ID: {exam.Course.CourseId}), Room: {exam.Room}, ExamDate: {exam.ExamDate}, Credits: {exam.Credits}");
//            }
//        }
//        else if (readInput.Equals("Result", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Results:");
//            foreach (ResultDTO result in results)
//            {
//                Console.WriteLine($"StudentID: {result.Student.StudentId}, ExamID: {result.Exam.ExamID}, Points: {result.Points}");
//            }
//        }
//        else if (readInput.Equals("StudentStudy", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("StudentStudies:");
//            foreach (StudentStudyDTO studentStudy in studentStudies)
//            {
//                Console.WriteLine($"StudentID: {studentStudy.Student.StudentId}, CourseID: {studentStudy.Course.CourseId}, StartDate: {studentStudy.StartDate}, EndDate: {studentStudy.EndDate}");
//            }
//        }
//        else
//        {
//            Console.WriteLine(readInput + " could not be retrieved");
//        }

//    }
//    else if (userInput.Equals("Update", StringComparison.OrdinalIgnoreCase))
//    {
//        Console.WriteLine("Would you like to update an Employee, Student, Faculty, Course, Exam, Result, or StudentStudy?");
//        string updateInput = Console.ReadLine();

//        if (updateInput.Equals("Employee", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Enter the ID of the employee to update: ");
//            string employeeId = Console.ReadLine();

//            bool found = false;
//            foreach (EmployeeDTO employee in employees)
//            {
//                if (employeeId.Equals(employee.EmpId, StringComparison.OrdinalIgnoreCase))
//                {
//                    Console.WriteLine("What value would u like to update: Name, FacultyID or Salary?");
//                    string operation = Console.ReadLine();

//                    switch (operation.ToLower())
//                    {
//                        case "name":
//                            Console.WriteLine("Enter the first name of the Employee: ");
//                            string firstName = Console.ReadLine();
//                            if (!Regex.IsMatch(firstName, @"^[a-zA-ZÅÄÖåäö]+$"))
//                            {
//                                Console.WriteLine("Error: Please enter a valid first name using only letters.");
//                                continue;
//                            }
//                            Console.WriteLine("Enter the surname of the Employee: ");
//                            string lastName = Console.ReadLine();
//                            if (!Regex.IsMatch(lastName, @"^[a-zA-ZÅÄÖåäö]+$"))
//                            {
//                                Console.WriteLine("Error: Please enter a valid first name using only letters.");
//                                continue;
//                            }
//                            string name = firstName + " " + lastName;
//                            kebabUniService.UpdateEmployee(employeeId, name, employee.Salary, employee.Faculty.FacultyId);
//                            employee.EmployeeName = name;
//                            Console.WriteLine($"Successfully updated {employeeId}");
//                            break;

//                        case "facultyid":
//                            Console.WriteLine($"Enter the new facultyID assigned to the Employee:");
//                            string facultyId = Console.ReadLine();
//                            bool foundFaculty = false;
//                            foreach (FacultyDTO faculty in faculties)
//                            {
//                                if (facultyId.Equals(faculty.FacultyId, StringComparison.OrdinalIgnoreCase))
//                                {
//                                    kebabUniService.UpdateEmployee(employeeId, employee.EmployeeName, employee.Salary, facultyId);
//                                    employee.Faculty = faculty;
//                                    foundFaculty = true;
//                                    Console.WriteLine($"Successfully updated {employeeId}");
//                                }
//                            }
//                            if (!foundFaculty)
//                            {
//                                Console.WriteLine($"FacultyID does not exist.");
//                            }
//                            break;

//                        case "salary":
//                            Console.WriteLine("Enter the new salary of the Employee: ");
//                            string salaryInput = Console.ReadLine();
//                            int salary;

//                            if (!int.TryParse(salaryInput, out salary))
//                            {
//                                Console.WriteLine("Error: Please enter a valid salary in number format.");
//                                continue;
//                            }

//                            kebabUniService.UpdateEmployee(employeeId, employee.EmployeeName, salary, employee.Faculty.FacultyId);
//                            Console.WriteLine($"Successfully updated {employeeId}");
//                            employee.Salary = salary;
//                            break;
//                    }
//                    found = true;
//                }
//            }
//            if (!found)
//            {
//                Console.WriteLine($"Employee {employeeId} not found.");
//            }

//        }


//        else if (updateInput.Equals("Student", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Enter the ID of the student to update: ");
//            string studentId = Console.ReadLine();

//            bool found = false;
//            foreach (StudentDTO student in students)
//            {
//                if (studentId.Equals(student.StudentId, StringComparison.OrdinalIgnoreCase))
//                {
//                    Console.WriteLine("What value would u like to update: Name or Address?");
//                    string operation = Console.ReadLine();

//                    switch (operation.ToLower())
//                    {
//                        case "name":
//                            Console.WriteLine("Enter the first name of the Student: ");
//                            string firstName = Console.ReadLine();
//                            if (!Regex.IsMatch(firstName, @"^[a-zA-ZÅÄÖåäö]+$"))
//                            {
//                                Console.WriteLine("Error: Please enter a valid first name using only letters.");
//                                continue;
//                            }
//                            Console.WriteLine("Enter the surname of the Student: ");
//                            string lastName = Console.ReadLine();
//                            if (!Regex.IsMatch(lastName, @"^[a-zA-ZÅÄÖåäö]+$"))
//                            {
//                                Console.WriteLine("Error: Please enter a valid surname using only letters.");
//                                continue;
//                            }
//                            string name = firstName + " " + lastName;
//                            kebabUniService.UpdateStudent(studentId, name, student.Address);
//                            student.StudentName = name;
//                            Console.WriteLine($"Successfully updated {studentId}");
//                            break;

//                        case "address":
//                            Console.WriteLine("Enter the new Address of the Student: ");
//                            string address = Console.ReadLine();

//                            if (!Regex.IsMatch(address, @"^[a-zA-Z 0-9]+$"))
//                            {
//                                Console.WriteLine("Error: Please enter a valid address using only letters.");
//                                continue;
//                            }

//                            kebabUniService.UpdateStudent(studentId, student.StudentName, address);
//                            Console.WriteLine($"Successfully updated {studentId}");
//                            student.Address = address;
//                            break;
//                    }
//                    found = true;
//                }
//            }
//            if (!found)
//            {
//                Console.WriteLine($"Student: {studentId} not found.");
//            }

//        }

//        else if (updateInput.Equals("Faculty", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Enter the ID of the Faculty to update: ");
//            string facultyId = Console.ReadLine();

//            bool found = false;
//            foreach (FacultyDTO faculty in faculties)
//            {
//                if (facultyId.Equals(faculty.FacultyId, StringComparison.OrdinalIgnoreCase))
//                {
//                    Console.WriteLine("What value would u like to update: FacultyName or Address?");
//                    string operation = Console.ReadLine();

//                    switch (operation.ToLower())
//                    {
//                        case "name":
//                            Console.WriteLine("Enter the name of the Faculty: ");
//                            string name = Console.ReadLine();
//                            if (!Regex.IsMatch(name, @"^[a-zA-ZÅÄÖåäö]+$"))
//                            {
//                                Console.WriteLine("Error: Please enter a valid first name using only letters.");
//                                continue;
//                            }

//                            kebabUniService.UpdateFaculty(facultyId, name, faculty.Address);
//                            faculty.FacultyName = name;
//                            Console.WriteLine($"Successfully updated {facultyId}");
//                            break;

//                        case "address":
//                            Console.WriteLine("Enter the new Address of the Student: ");
//                            string address = Console.ReadLine();

//                            if (!Regex.IsMatch(address, @"^[a-zA-Z 0-9]+$"))
//                            {
//                                Console.WriteLine("Error: Please enter a valid address using only letters.");
//                                continue;
//                            }

//                            kebabUniService.UpdateFaculty(facultyId, faculty.FacultyName, address);
//                            Console.WriteLine($"Successfully updated {facultyId}");
//                            faculty.Address = address;
//                            break;
//                    }
//                    found = true;
//                }
//            }
//            if (!found)
//            {
//                Console.WriteLine($"Faculty: {facultyId} not found.");
//            }

//        }
//        else if (updateInput.Equals("Course", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Enter the ID of the Course to update: ");
//            string courseId = Console.ReadLine();

//            bool found = false;
//            foreach (CourseDTO course in courses)
//            {
//                if (courseId.Equals(course.CourseId, StringComparison.OrdinalIgnoreCase))
//                {
//                    Console.WriteLine("What value would u like to update: FacultyID, Credits, Description or Employee?");
//                    string operation = Console.ReadLine();

//                    switch (operation.ToLower())
//                    {
//                        case "facultyid":
//                            Console.WriteLine($"Enter the new FacultyID assigned to the Employee:");
//                            string facultyId = Console.ReadLine();
//                            bool foundFaculty = false;
//                            foreach (FacultyDTO faculty in faculties)
//                            {
//                                if (facultyId.Equals(faculty.FacultyId, StringComparison.OrdinalIgnoreCase))
//                                {
//                                    kebabUniService.UpdateCourse(courseId, facultyId, course.Credits, course.Description, course.Employee.EmpId);
//                                    course.Faculty = faculty;
//                                    foundFaculty = true;
//                                    Console.WriteLine($"Successfully updated {facultyId}");
//                                }
//                            }
//                            if (!foundFaculty)
//                            {
//                                Console.WriteLine($"FacultyID does not exist.");
//                            }
//                            break;

//                        case "credits":
//                            Console.WriteLine($"Enter the new credits value: ");
//                            string creditinput = Console.ReadLine();
//                            int credits;

//                            if (!int.TryParse(creditinput, out credits))
//                            {
//                                Console.WriteLine("Error: Please enter a valid credits in number format.");
//                                continue;
//                            }
//                            kebabUniService.UpdateCourse(courseId, course.Faculty.FacultyId, credits, course.Description, course.Employee.EmpId);
//                            Console.WriteLine($"Successfully updated {courseId}");
//                            course.Credits= credits;
//                            break;

//                        case "description":
//                            Console.WriteLine("Enter the new Description of the Course: ");
//                            string description = Console.ReadLine();
//                            if (!Regex.IsMatch(description, @"^[a-zA-Z0-9]+$"))
//                            {
//                                Console.WriteLine("Error: Please enter a valid Description using only letters.");
//                                continue;
//                            }
//                            kebabUniService.UpdateCourse(courseId, course.Faculty.FacultyId, course.Credits, description, course.Employee.EmpId);
//                            Console.WriteLine($"Successfully updated {courseId}");
//                            course.Description = description;
//                            break;

//                        case "employee":
//                            Console.WriteLine($"Enter the new EmployeeID assigned to the Course:");
//                            string empId = Console.ReadLine();
//                            bool foundEmp = false;
//                            foreach (EmployeeDTO employee in employees)
//                            {
//                                if (empId.Equals(employee.EmpId, StringComparison.OrdinalIgnoreCase))
//                                {
//                                    kebabUniService.UpdateCourse(courseId, course.Faculty.FacultyId, course.Credits, course.Description, empId);
//                                    course.Employee = employee;
//                                    foundEmp = true;
//                                    Console.WriteLine($"Successfully updated {courseId}");
//                                }
//                            }
//                            if (!foundEmp)
//                            {
//                                Console.WriteLine($"EmployeeID does not exist.");
//                            }
//                            break;
//                    }
//                    found = true;
//                }
//            }
//            if (!found)
//            {
//                Console.WriteLine($"Course: {courseId} not found.");
//            }

//        }
//        else if (updateInput.Equals("Exam", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Enter the ID of the Exam to update: ");
//            string examId = Console.ReadLine();

//            bool found = false;
//            foreach (ExamDTO exam in exams)
//            {
//                if (examId.Equals(exam.ExamID, StringComparison.OrdinalIgnoreCase))
//                {
//                    Console.WriteLine("What value would u like to update: CourseID, Room, ExamDate or Credits?");
//                    string operation = Console.ReadLine();

//                    switch (operation.ToLower())
//                    {
//                        case "courseid":
//                            Console.WriteLine($"Enter the new CourseID assigned to the Exam:");
//                            string courseId = Console.ReadLine();
//                            bool foundCourse = false;
//                            foreach (CourseDTO course in courses)
//                            {
//                                if (courseId.Equals(course.CourseId, StringComparison.OrdinalIgnoreCase))
//                                {
//                                    kebabUniService.UpdateExam(examId, courseId, exam.Room, exam.ExamDate, exam.Credits);
//                                    exam.Course.CourseId= courseId;
//                                    foundCourse = true;
//                                    Console.WriteLine($"Successfully updated {examId}");
//                                }
//                            }
//                            if (!foundCourse)
//                            {
//                                Console.WriteLine($"CourseID does not exist.");
//                            }
//                            break;

//                        case "room":
//                            Console.WriteLine("Enter the new room where the exam will take place: ");
//                            string room = Console.ReadLine();
//                            if (!Regex.IsMatch(room, @"^[a-zA-Z0-9 ]+$"))
//                            {
//                                Console.WriteLine("Error: Please enter a valid room using only letters and numbers.");
//                                continue;
//                            }
//                            kebabUniService.UpdateExam(examId, exam.Course.CourseId, room, exam.ExamDate, exam.Credits);
//                            exam.Room = room;
//                            Console.WriteLine($"Successfully updated {examId}");
//                            break;

//                        case "examdate":
//                            Console.WriteLine("Enter the new date of the exam (format: yyyy-mm-dd): ");
//                            string dateInput = Console.ReadLine();
//                            DateTime examDate;
//                            if (!DateTime.TryParse(dateInput, out examDate))
//                            {
//                                Console.WriteLine("Error: Please enter a valid date using the format yyyy-mm-dd.");
//                                continue;
//                            }
//                            kebabUniService.UpdateExam(examId, exam.Course.CourseId, exam.Room, examDate, exam.Credits);
//                            exam.ExamDate = examDate;
//                            Console.WriteLine($"Successfully updated {examId}");
//                            break;

//                        case "credits":
//                            Console.WriteLine("Enter the new number of credits for the exam: ");
//                            string creditInput = Console.ReadLine();
//                            int credits;
//                            if (!int.TryParse(creditInput, out credits))
//                            {
//                                Console.WriteLine("Error: Please enter a valid credit number.");
//                                continue;
//                            }
//                            kebabUniService.UpdateExam(examId, exam.Course.CourseId, exam.Room, exam.ExamDate, credits);
//                            exam.Credits = credits;
//                            Console.WriteLine($"Successfully updated {examId}");
//                            break;
//                    }
//                    found = true;
//                }
//            }
//            if (!found)
//            {
//                Console.WriteLine($"Exam: {examId} not found.");
//            }

//        }
//        else if (updateInput.Equals("Result", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Enter the ID of the Student that the Result belongs to: ");
//            string studentId = Console.ReadLine();
//            Console.WriteLine("Enter the ID of the Exam that the Result belongs to: ");
//            string examId = Console.ReadLine();

//            bool found = false;
//            foreach (ResultDTO result in results)
//            {
//                if (studentId.Equals(result.Student.StudentId, StringComparison.OrdinalIgnoreCase) && examId.Equals(result.Exam.ExamID, StringComparison.OrdinalIgnoreCase) )
//                {
//                    Console.WriteLine("What value would u like to update: Points?");
//                    string operation = Console.ReadLine();

//                    switch (operation.ToLower())
//                    {
//                        case "points":
//                            Console.WriteLine("Enter the new Points of the result: ");
//                            string resultInput = Console.ReadLine();
//                            int points;
//                            if (!int.TryParse(resultInput, out points))
//                            {
//                                Console.WriteLine("Error: Please enter a valid result in number format.");
//                                continue;
//                            }
//                            kebabUniService.UpdateResult(examId, studentId, points);
//                            result.Points = points;
//                            Console.WriteLine($"Successfully updated result for {studentId} on exam: {examId}");
//                            break;
//                    }
//                    found = true;
//                }
//            }
//            if (!found)
//            {
//                Console.WriteLine($"Result for: {studentId} on Exam: {examId} not found.");
//            }
//        }
//        else if (updateInput.Equals("StudentStudy", StringComparison.OrdinalIgnoreCase))
//        {
//            Console.WriteLine("Enter the ID of the Student that the StudentStudy belongs to: ");
//            string studentId = Console.ReadLine();
//            Console.WriteLine("Enter the ID of the Course that the StudentStudy belongs to: ");
//            string courseId = Console.ReadLine();

//            bool found = false;
//            foreach (StudentStudyDTO studentStudy in studentStudies)
//            {
//                if (studentId.Equals(studentStudy.Student.StudentId, StringComparison.OrdinalIgnoreCase) && courseId.Equals(studentStudy.Course.CourseId, StringComparison.OrdinalIgnoreCase))
//                {
//                    Console.WriteLine("What value would u like to update: StartDate or EndDate?");
//                    string operation = Console.ReadLine();

//                    switch (operation.ToLower())
//                    {
//                        case "startdate":
//                            Console.WriteLine("Enter the start date of the study (format: yyyy-mm-dd): ");
//                            string startDateInput = Console.ReadLine();
//                            DateTime startDate;
//                            if (!DateTime.TryParse(startDateInput, out startDate))
//                            {
//                                Console.WriteLine("Error: Please enter a valid date using the format yyyy-mm-dd.");
//                                continue;
//                            }
//                            kebabUniService.UpdateStudentStudy(courseId, studentId, startDate, studentStudy.EndDate);
//                            studentStudy.StartDate = startDate;
//                            Console.WriteLine($"Successfully updated StudentStudy for {studentId} on course: {courseId}");
//                            break;

//                        case "enddate":
//                            Console.WriteLine("Enter the start date of the study (format: yyyy-mm-dd): ");
//                            string endDateInput = Console.ReadLine();
//                            DateTime endDate;
//                            if (!DateTime.TryParse(endDateInput, out endDate))
//                            {
//                                Console.WriteLine("Error: Please enter a valid date using the format yyyy-mm-dd.");
//                                continue;
//                            }
//                            kebabUniService.UpdateStudentStudy(courseId, studentId, studentStudy.StartDate, endDate);
//                            studentStudy.EndDate = endDate;
//                            Console.WriteLine($"Successfully updated StudentStudy for {studentId} on course: {courseId}");
//                            break;
//                    }
//                    found = true;
//                }
//            }
//            if (!found)
//            {
//                Console.WriteLine($"StudentStudy for: {studentId} on course: {courseId} not found.");
//            }
//        }
//    }

//}
static void Main(string[] args)
{
}

