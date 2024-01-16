/**
 * EmployeeDTO.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package se.lu.ics;

public class EmployeeDTO  implements java.io.Serializable {
    private java.lang.String empId;

    private java.lang.String employeeName;

    private int salary;

    private se.lu.ics.FacultyDTO faculty;

    private se.lu.ics.CourseDTO[] courses;

    public EmployeeDTO() {
    }

    public EmployeeDTO(
           java.lang.String empId,
           java.lang.String employeeName,
           int salary,
           se.lu.ics.FacultyDTO faculty,
           se.lu.ics.CourseDTO[] courses) {
           this.empId = empId;
           this.employeeName = employeeName;
           this.salary = salary;
           this.faculty = faculty;
           this.courses = courses;
    }


    /**
     * Gets the empId value for this EmployeeDTO.
     * 
     * @return empId
     */
    public java.lang.String getEmpId() {
        return empId;
    }


    /**
     * Sets the empId value for this EmployeeDTO.
     * 
     * @param empId
     */
    public void setEmpId(java.lang.String empId) {
        this.empId = empId;
    }


    /**
     * Gets the employeeName value for this EmployeeDTO.
     * 
     * @return employeeName
     */
    public java.lang.String getEmployeeName() {
        return employeeName;
    }


    /**
     * Sets the employeeName value for this EmployeeDTO.
     * 
     * @param employeeName
     */
    public void setEmployeeName(java.lang.String employeeName) {
        this.employeeName = employeeName;
    }


    /**
     * Gets the salary value for this EmployeeDTO.
     * 
     * @return salary
     */
    public int getSalary() {
        return salary;
    }


    /**
     * Sets the salary value for this EmployeeDTO.
     * 
     * @param salary
     */
    public void setSalary(int salary) {
        this.salary = salary;
    }


    /**
     * Gets the faculty value for this EmployeeDTO.
     * 
     * @return faculty
     */
    public se.lu.ics.FacultyDTO getFaculty() {
        return faculty;
    }


    /**
     * Sets the faculty value for this EmployeeDTO.
     * 
     * @param faculty
     */
    public void setFaculty(se.lu.ics.FacultyDTO faculty) {
        this.faculty = faculty;
    }


    /**
     * Gets the courses value for this EmployeeDTO.
     * 
     * @return courses
     */
    public se.lu.ics.CourseDTO[] getCourses() {
        return courses;
    }


    /**
     * Sets the courses value for this EmployeeDTO.
     * 
     * @param courses
     */
    public void setCourses(se.lu.ics.CourseDTO[] courses) {
        this.courses = courses;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof EmployeeDTO)) return false;
        EmployeeDTO other = (EmployeeDTO) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.empId==null && other.getEmpId()==null) || 
             (this.empId!=null &&
              this.empId.equals(other.getEmpId()))) &&
            ((this.employeeName==null && other.getEmployeeName()==null) || 
             (this.employeeName!=null &&
              this.employeeName.equals(other.getEmployeeName()))) &&
            this.salary == other.getSalary() &&
            ((this.faculty==null && other.getFaculty()==null) || 
             (this.faculty!=null &&
              this.faculty.equals(other.getFaculty()))) &&
            ((this.courses==null && other.getCourses()==null) || 
             (this.courses!=null &&
              java.util.Arrays.equals(this.courses, other.getCourses())));
        __equalsCalc = null;
        return _equals;
    }

    private boolean __hashCodeCalc = false;
    public synchronized int hashCode() {
        if (__hashCodeCalc) {
            return 0;
        }
        __hashCodeCalc = true;
        int _hashCode = 1;
        if (getEmpId() != null) {
            _hashCode += getEmpId().hashCode();
        }
        if (getEmployeeName() != null) {
            _hashCode += getEmployeeName().hashCode();
        }
        _hashCode += getSalary();
        if (getFaculty() != null) {
            _hashCode += getFaculty().hashCode();
        }
        if (getCourses() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getCourses());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getCourses(), i);
                if (obj != null &&
                    !obj.getClass().isArray()) {
                    _hashCode += obj.hashCode();
                }
            }
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(EmployeeDTO.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://ics.lu.se/", "EmployeeDTO"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("empId");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "EmpId"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("employeeName");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "EmployeeName"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("salary");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "Salary"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("faculty");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "Faculty"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://ics.lu.se/", "FacultyDTO"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("courses");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "Courses"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://ics.lu.se/", "CourseDTO"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        elemField.setItemQName(new javax.xml.namespace.QName("http://ics.lu.se/", "CourseDTO"));
        typeDesc.addFieldDesc(elemField);
    }

    /**
     * Return type metadata object
     */
    public static org.apache.axis.description.TypeDesc getTypeDesc() {
        return typeDesc;
    }

    /**
     * Get Custom Serializer
     */
    public static org.apache.axis.encoding.Serializer getSerializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanSerializer(
            _javaType, _xmlType, typeDesc);
    }

    /**
     * Get Custom Deserializer
     */
    public static org.apache.axis.encoding.Deserializer getDeserializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanDeserializer(
            _javaType, _xmlType, typeDesc);
    }

}
