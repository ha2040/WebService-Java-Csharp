package se.lu.ics;

public class KebabUniServiceSoapProxy implements se.lu.ics.KebabUniServiceSoap {
  private String _endpoint = null;
  private se.lu.ics.KebabUniServiceSoap kebabUniServiceSoap = null;
  
  public KebabUniServiceSoapProxy() {
    _initKebabUniServiceSoapProxy();
  }
  
  public KebabUniServiceSoapProxy(String endpoint) {
    _endpoint = endpoint;
    _initKebabUniServiceSoapProxy();
  }
  
  private void _initKebabUniServiceSoapProxy() {
    try {
      kebabUniServiceSoap = (new se.lu.ics.KebabUniServiceLocator()).getKebabUniServiceSoap();
      if (kebabUniServiceSoap != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)kebabUniServiceSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)kebabUniServiceSoap)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (kebabUniServiceSoap != null)
      ((javax.xml.rpc.Stub)kebabUniServiceSoap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public se.lu.ics.KebabUniServiceSoap getKebabUniServiceSoap() {
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    return kebabUniServiceSoap;
  }
  
  public se.lu.ics.CourseDTO[] getCourses() throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    return kebabUniServiceSoap.getCourses();
  }
  
  public void addCourse(java.lang.String facultyId, int credits, java.lang.String description, java.lang.String empId) throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    kebabUniServiceSoap.addCourse(facultyId, credits, description, empId);
  }
  
  public void updateCourse(java.lang.String courseId, java.lang.String facultyId, int credits, java.lang.String description, java.lang.String empId) throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    kebabUniServiceSoap.updateCourse(courseId, facultyId, credits, description, empId);
  }
  
  public void deleteCourse(java.lang.String id) throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    kebabUniServiceSoap.deleteCourse(id);
  }
  
  public void addStudentStudy(java.lang.String courseId, java.lang.String studentId, java.util.Calendar startDate, java.util.Calendar endDate) throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    kebabUniServiceSoap.addStudentStudy(courseId, studentId, startDate, endDate);
  }
  
  public se.lu.ics.StudentStudyDTO[] getStudentStudy() throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    return kebabUniServiceSoap.getStudentStudy();
  }
  
  public void deleteStudentStudy(java.lang.String studentId, java.lang.String courseId) throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    kebabUniServiceSoap.deleteStudentStudy(studentId, courseId);
  }
  
  public void updateStudentStudy(java.lang.String courseId, java.lang.String studentId, java.util.Calendar startDate, java.util.Calendar endDate) throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    kebabUniServiceSoap.updateStudentStudy(courseId, studentId, startDate, endDate);
  }
  
  public se.lu.ics.EmployeeDTO[] getEmployees() throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    return kebabUniServiceSoap.getEmployees();
  }
  
  public void addEmployee(java.lang.String employeeName, int salary, java.lang.String faculty) throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    kebabUniServiceSoap.addEmployee(employeeName, salary, faculty);
  }
  
  public void deleteEmployee(java.lang.String id) throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    kebabUniServiceSoap.deleteEmployee(id);
  }
  
  public void updateEmployee(java.lang.String empId, java.lang.String employeeName, int salary, java.lang.String facultyId) throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    kebabUniServiceSoap.updateEmployee(empId, employeeName, salary, facultyId);
  }
  
  public se.lu.ics.FacultyDTO[] getFaculties() throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    return kebabUniServiceSoap.getFaculties();
  }
  
  public void addFaculty(java.lang.String facultyName, java.lang.String address) throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    kebabUniServiceSoap.addFaculty(facultyName, address);
  }
  
  public void updateFaculty(java.lang.String facultyId, java.lang.String facultyName, java.lang.String address) throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    kebabUniServiceSoap.updateFaculty(facultyId, facultyName, address);
  }
  
  public void deleteFaculty(java.lang.String id) throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    kebabUniServiceSoap.deleteFaculty(id);
  }
  
  public void addStudent(java.lang.String name, java.lang.String address) throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    kebabUniServiceSoap.addStudent(name, address);
  }
  
  public se.lu.ics.StudentDTO[] getStudents() throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    return kebabUniServiceSoap.getStudents();
  }
  
  public void deleteStudent(java.lang.String id) throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    kebabUniServiceSoap.deleteStudent(id);
  }
  
  public void updateStudent(java.lang.String studentId, java.lang.String name, java.lang.String address) throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    kebabUniServiceSoap.updateStudent(studentId, name, address);
  }
  
  public se.lu.ics.ExamDTO[] getExams() throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    return kebabUniServiceSoap.getExams();
  }
  
  public void updateExam(java.lang.String examId, java.lang.String courseId, java.lang.String room, java.util.Calendar examDate, int credits) throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    kebabUniServiceSoap.updateExam(examId, courseId, room, examDate, credits);
  }
  
  public void addExam(java.lang.String courseId, java.lang.String room, java.util.Calendar examDate, int credits) throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    kebabUniServiceSoap.addExam(courseId, room, examDate, credits);
  }
  
  public void deleteExam(java.lang.String examId) throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    kebabUniServiceSoap.deleteExam(examId);
  }
  
  public se.lu.ics.ResultDTO[] getResults() throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    return kebabUniServiceSoap.getResults();
  }
  
  public void updateResult(java.lang.String examId, java.lang.String studentId, int points) throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    kebabUniServiceSoap.updateResult(examId, studentId, points);
  }
  
  public void addResult(java.lang.String examId, java.lang.String studentId, int points) throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    kebabUniServiceSoap.addResult(examId, studentId, points);
  }
  
  public void deleteResult(java.lang.String examId, java.lang.String studentId) throws java.rmi.RemoteException{
    if (kebabUniServiceSoap == null)
      _initKebabUniServiceSoapProxy();
    kebabUniServiceSoap.deleteResult(examId, studentId);
  }
  
  
}