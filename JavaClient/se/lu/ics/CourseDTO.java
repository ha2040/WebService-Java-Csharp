/**
 * CourseDTO.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package se.lu.ics;

public class CourseDTO  implements java.io.Serializable {
    private java.lang.String courseId;

    private se.lu.ics.FacultyDTO faculty;

    private int credits;

    private java.lang.String description;

    private se.lu.ics.EmployeeDTO employee;

    private se.lu.ics.StudentStudyDTO[] studentStudyList;

    public CourseDTO() {
    }

    public CourseDTO(
           java.lang.String courseId,
           se.lu.ics.FacultyDTO faculty,
           int credits,
           java.lang.String description,
           se.lu.ics.EmployeeDTO employee,
           se.lu.ics.StudentStudyDTO[] studentStudyList) {
           this.courseId = courseId;
           this.faculty = faculty;
           this.credits = credits;
           this.description = description;
           this.employee = employee;
           this.studentStudyList = studentStudyList;
    }


    /**
     * Gets the courseId value for this CourseDTO.
     * 
     * @return courseId
     */
    public java.lang.String getCourseId() {
        return courseId;
    }


    /**
     * Sets the courseId value for this CourseDTO.
     * 
     * @param courseId
     */
    public void setCourseId(java.lang.String courseId) {
        this.courseId = courseId;
    }


    /**
     * Gets the faculty value for this CourseDTO.
     * 
     * @return faculty
     */
    public se.lu.ics.FacultyDTO getFaculty() {
        return faculty;
    }


    /**
     * Sets the faculty value for this CourseDTO.
     * 
     * @param faculty
     */
    public void setFaculty(se.lu.ics.FacultyDTO faculty) {
        this.faculty = faculty;
    }


    /**
     * Gets the credits value for this CourseDTO.
     * 
     * @return credits
     */
    public int getCredits() {
        return credits;
    }


    /**
     * Sets the credits value for this CourseDTO.
     * 
     * @param credits
     */
    public void setCredits(int credits) {
        this.credits = credits;
    }


    /**
     * Gets the description value for this CourseDTO.
     * 
     * @return description
     */
    public java.lang.String getDescription() {
        return description;
    }


    /**
     * Sets the description value for this CourseDTO.
     * 
     * @param description
     */
    public void setDescription(java.lang.String description) {
        this.description = description;
    }


    /**
     * Gets the employee value for this CourseDTO.
     * 
     * @return employee
     */
    public se.lu.ics.EmployeeDTO getEmployee() {
        return employee;
    }


    /**
     * Sets the employee value for this CourseDTO.
     * 
     * @param employee
     */
    public void setEmployee(se.lu.ics.EmployeeDTO employee) {
        this.employee = employee;
    }


    /**
     * Gets the studentStudyList value for this CourseDTO.
     * 
     * @return studentStudyList
     */
    public se.lu.ics.StudentStudyDTO[] getStudentStudyList() {
        return studentStudyList;
    }


    /**
     * Sets the studentStudyList value for this CourseDTO.
     * 
     * @param studentStudyList
     */
    public void setStudentStudyList(se.lu.ics.StudentStudyDTO[] studentStudyList) {
        this.studentStudyList = studentStudyList;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof CourseDTO)) return false;
        CourseDTO other = (CourseDTO) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.courseId==null && other.getCourseId()==null) || 
             (this.courseId!=null &&
              this.courseId.equals(other.getCourseId()))) &&
            ((this.faculty==null && other.getFaculty()==null) || 
             (this.faculty!=null &&
              this.faculty.equals(other.getFaculty()))) &&
            this.credits == other.getCredits() &&
            ((this.description==null && other.getDescription()==null) || 
             (this.description!=null &&
              this.description.equals(other.getDescription()))) &&
            ((this.employee==null && other.getEmployee()==null) || 
             (this.employee!=null &&
              this.employee.equals(other.getEmployee()))) &&
            ((this.studentStudyList==null && other.getStudentStudyList()==null) || 
             (this.studentStudyList!=null &&
              java.util.Arrays.equals(this.studentStudyList, other.getStudentStudyList())));
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
        if (getCourseId() != null) {
            _hashCode += getCourseId().hashCode();
        }
        if (getFaculty() != null) {
            _hashCode += getFaculty().hashCode();
        }
        _hashCode += getCredits();
        if (getDescription() != null) {
            _hashCode += getDescription().hashCode();
        }
        if (getEmployee() != null) {
            _hashCode += getEmployee().hashCode();
        }
        if (getStudentStudyList() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getStudentStudyList());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getStudentStudyList(), i);
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
        new org.apache.axis.description.TypeDesc(CourseDTO.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://ics.lu.se/", "CourseDTO"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("courseId");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "CourseId"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
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
        elemField.setFieldName("credits");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "Credits"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("description");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "Description"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("employee");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "Employee"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://ics.lu.se/", "EmployeeDTO"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("studentStudyList");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "StudentStudyList"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://ics.lu.se/", "StudentStudyDTO"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        elemField.setItemQName(new javax.xml.namespace.QName("http://ics.lu.se/", "StudentStudyDTO"));
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
