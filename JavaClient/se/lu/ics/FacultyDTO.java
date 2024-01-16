/**
 * FacultyDTO.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package se.lu.ics;

public class FacultyDTO  implements java.io.Serializable {
    private java.lang.String facultyId;

    private java.lang.String facultyName;

    private java.lang.String address;

    private se.lu.ics.EmployeeDTO[] employees;

    private se.lu.ics.CourseDTO[] courses;

    public FacultyDTO() {
    }

    public FacultyDTO(
           java.lang.String facultyId,
           java.lang.String facultyName,
           java.lang.String address,
           se.lu.ics.EmployeeDTO[] employees,
           se.lu.ics.CourseDTO[] courses) {
           this.facultyId = facultyId;
           this.facultyName = facultyName;
           this.address = address;
           this.employees = employees;
           this.courses = courses;
    }


    /**
     * Gets the facultyId value for this FacultyDTO.
     * 
     * @return facultyId
     */
    public java.lang.String getFacultyId() {
        return facultyId;
    }


    /**
     * Sets the facultyId value for this FacultyDTO.
     * 
     * @param facultyId
     */
    public void setFacultyId(java.lang.String facultyId) {
        this.facultyId = facultyId;
    }


    /**
     * Gets the facultyName value for this FacultyDTO.
     * 
     * @return facultyName
     */
    public java.lang.String getFacultyName() {
        return facultyName;
    }


    /**
     * Sets the facultyName value for this FacultyDTO.
     * 
     * @param facultyName
     */
    public void setFacultyName(java.lang.String facultyName) {
        this.facultyName = facultyName;
    }


    /**
     * Gets the address value for this FacultyDTO.
     * 
     * @return address
     */
    public java.lang.String getAddress() {
        return address;
    }


    /**
     * Sets the address value for this FacultyDTO.
     * 
     * @param address
     */
    public void setAddress(java.lang.String address) {
        this.address = address;
    }


    /**
     * Gets the employees value for this FacultyDTO.
     * 
     * @return employees
     */
    public se.lu.ics.EmployeeDTO[] getEmployees() {
        return employees;
    }


    /**
     * Sets the employees value for this FacultyDTO.
     * 
     * @param employees
     */
    public void setEmployees(se.lu.ics.EmployeeDTO[] employees) {
        this.employees = employees;
    }


    /**
     * Gets the courses value for this FacultyDTO.
     * 
     * @return courses
     */
    public se.lu.ics.CourseDTO[] getCourses() {
        return courses;
    }


    /**
     * Sets the courses value for this FacultyDTO.
     * 
     * @param courses
     */
    public void setCourses(se.lu.ics.CourseDTO[] courses) {
        this.courses = courses;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof FacultyDTO)) return false;
        FacultyDTO other = (FacultyDTO) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.facultyId==null && other.getFacultyId()==null) || 
             (this.facultyId!=null &&
              this.facultyId.equals(other.getFacultyId()))) &&
            ((this.facultyName==null && other.getFacultyName()==null) || 
             (this.facultyName!=null &&
              this.facultyName.equals(other.getFacultyName()))) &&
            ((this.address==null && other.getAddress()==null) || 
             (this.address!=null &&
              this.address.equals(other.getAddress()))) &&
            ((this.employees==null && other.getEmployees()==null) || 
             (this.employees!=null &&
              java.util.Arrays.equals(this.employees, other.getEmployees()))) &&
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
        if (getFacultyId() != null) {
            _hashCode += getFacultyId().hashCode();
        }
        if (getFacultyName() != null) {
            _hashCode += getFacultyName().hashCode();
        }
        if (getAddress() != null) {
            _hashCode += getAddress().hashCode();
        }
        if (getEmployees() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getEmployees());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getEmployees(), i);
                if (obj != null &&
                    !obj.getClass().isArray()) {
                    _hashCode += obj.hashCode();
                }
            }
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
        new org.apache.axis.description.TypeDesc(FacultyDTO.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://ics.lu.se/", "FacultyDTO"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("facultyId");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "FacultyId"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("facultyName");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "FacultyName"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("address");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "Address"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("employees");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "Employees"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://ics.lu.se/", "EmployeeDTO"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        elemField.setItemQName(new javax.xml.namespace.QName("http://ics.lu.se/", "EmployeeDTO"));
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
