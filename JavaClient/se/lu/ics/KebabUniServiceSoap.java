/**
 * KebabUniServiceSoap.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package se.lu.ics;

public interface KebabUniServiceSoap extends java.rmi.Remote {

    /**
     * Returns a list of all courses and their respective faculties
     * and employees
     */
    public se.lu.ics.CourseDTO[] getCourses() throws java.rmi.RemoteException;

    /**
     * Adds a new Course to the database
     */
    public void addCourse(java.lang.String facultyId, int credits, java.lang.String description, java.lang.String empId) throws java.rmi.RemoteException;

    /**
     * Updates a Course with the new values
     */
    public void updateCourse(java.lang.String courseId, java.lang.String facultyId, int credits, java.lang.String description, java.lang.String empId) throws java.rmi.RemoteException;

    /**
     * Deletes a Course from the database
     */
    public void deleteCourse(java.lang.String id) throws java.rmi.RemoteException;

    /**
     * Adds a new StudentStudy to the database
     */
    public void addStudentStudy(java.lang.String courseId, java.lang.String studentId, java.util.Calendar startDate, java.util.Calendar endDate) throws java.rmi.RemoteException;

    /**
     * Returns a list of all StudentStudy and their respective courses
     * and students
     */
    public se.lu.ics.StudentStudyDTO[] getStudentStudy() throws java.rmi.RemoteException;

    /**
     * Deletes a StudentStudy from the database
     */
    public void deleteStudentStudy(java.lang.String studentId, java.lang.String courseId) throws java.rmi.RemoteException;

    /**
     * Updates a StudentStudy with the new values
     */
    public void updateStudentStudy(java.lang.String courseId, java.lang.String studentId, java.util.Calendar startDate, java.util.Calendar endDate) throws java.rmi.RemoteException;

    /**
     * Returns a list of all employees and their respective Faculties
     */
    public se.lu.ics.EmployeeDTO[] getEmployees() throws java.rmi.RemoteException;

    /**
     * Adds a new Employee to the database
     */
    public void addEmployee(java.lang.String employeeName, int salary, java.lang.String faculty) throws java.rmi.RemoteException;

    /**
     * Deletes a Employee from the database
     */
    public void deleteEmployee(java.lang.String id) throws java.rmi.RemoteException;

    /**
     * Updates a Employee with the new values
     */
    public void updateEmployee(java.lang.String empId, java.lang.String employeeName, int salary, java.lang.String facultyId) throws java.rmi.RemoteException;

    /**
     * Returns a list of all Faculties
     */
    public se.lu.ics.FacultyDTO[] getFaculties() throws java.rmi.RemoteException;

    /**
     * Adds a new Faculty to the database
     */
    public void addFaculty(java.lang.String facultyName, java.lang.String address) throws java.rmi.RemoteException;

    /**
     * Updates a Faculty with the new values
     */
    public void updateFaculty(java.lang.String facultyId, java.lang.String facultyName, java.lang.String address) throws java.rmi.RemoteException;

    /**
     * Deletes a Faculty from the database
     */
    public void deleteFaculty(java.lang.String id) throws java.rmi.RemoteException;

    /**
     * Adds a new student to the database
     */
    public void addStudent(java.lang.String name, java.lang.String address) throws java.rmi.RemoteException;

    /**
     * Returns a list of all students
     */
    public se.lu.ics.StudentDTO[] getStudents() throws java.rmi.RemoteException;

    /**
     * Deletes a student from the database
     */
    public void deleteStudent(java.lang.String id) throws java.rmi.RemoteException;

    /**
     * Updates a student with the new values
     */
    public void updateStudent(java.lang.String studentId, java.lang.String name, java.lang.String address) throws java.rmi.RemoteException;

    /**
     * Returns a list of all exams and their respective courses and
     * employees and their faculties
     */
    public se.lu.ics.ExamDTO[] getExams() throws java.rmi.RemoteException;

    /**
     * Updates an Exam with the new values
     */
    public void updateExam(java.lang.String examId, java.lang.String courseId, java.lang.String room, java.util.Calendar examDate, int credits) throws java.rmi.RemoteException;

    /**
     * Adds a new Exam to the database
     */
    public void addExam(java.lang.String courseId, java.lang.String room, java.util.Calendar examDate, int credits) throws java.rmi.RemoteException;

    /**
     * Deletes a Exam from the database
     */
    public void deleteExam(java.lang.String examId) throws java.rmi.RemoteException;

    /**
     * Returns a list of all Results and their respective exams and
     * students
     */
    public se.lu.ics.ResultDTO[] getResults() throws java.rmi.RemoteException;

    /**
     * Updates a Result with the new values
     */
    public void updateResult(java.lang.String examId, java.lang.String studentId, int points) throws java.rmi.RemoteException;

    /**
     * Adds a new Result to the database
     */
    public void addResult(java.lang.String examId, java.lang.String studentId, int points) throws java.rmi.RemoteException;

    /**
     * Deletes a Result from the database
     */
    public void deleteResult(java.lang.String examId, java.lang.String studentId) throws java.rmi.RemoteException;
}
