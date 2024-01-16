/**
 * StudentDTO.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package se.lu.ics;

public class StudentDTO  implements java.io.Serializable {
    private java.lang.String studentName;

    private java.lang.String studentId;

    private java.lang.String address;

    private se.lu.ics.ResultDTO[] resultList;

    private se.lu.ics.StudentStudyDTO[] studentStudyList;

    public StudentDTO() {
    }

    public StudentDTO(
           java.lang.String studentName,
           java.lang.String studentId,
           java.lang.String address,
           se.lu.ics.ResultDTO[] resultList,
           se.lu.ics.StudentStudyDTO[] studentStudyList) {
           this.studentName = studentName;
           this.studentId = studentId;
           this.address = address;
           this.resultList = resultList;
           this.studentStudyList = studentStudyList;
    }


    /**
     * Gets the studentName value for this StudentDTO.
     * 
     * @return studentName
     */
    public java.lang.String getStudentName() {
        return studentName;
    }


    /**
     * Sets the studentName value for this StudentDTO.
     * 
     * @param studentName
     */
    public void setStudentName(java.lang.String studentName) {
        this.studentName = studentName;
    }


    /**
     * Gets the studentId value for this StudentDTO.
     * 
     * @return studentId
     */
    public java.lang.String getStudentId() {
        return studentId;
    }


    /**
     * Sets the studentId value for this StudentDTO.
     * 
     * @param studentId
     */
    public void setStudentId(java.lang.String studentId) {
        this.studentId = studentId;
    }


    /**
     * Gets the address value for this StudentDTO.
     * 
     * @return address
     */
    public java.lang.String getAddress() {
        return address;
    }


    /**
     * Sets the address value for this StudentDTO.
     * 
     * @param address
     */
    public void setAddress(java.lang.String address) {
        this.address = address;
    }


    /**
     * Gets the resultList value for this StudentDTO.
     * 
     * @return resultList
     */
    public se.lu.ics.ResultDTO[] getResultList() {
        return resultList;
    }


    /**
     * Sets the resultList value for this StudentDTO.
     * 
     * @param resultList
     */
    public void setResultList(se.lu.ics.ResultDTO[] resultList) {
        this.resultList = resultList;
    }


    /**
     * Gets the studentStudyList value for this StudentDTO.
     * 
     * @return studentStudyList
     */
    public se.lu.ics.StudentStudyDTO[] getStudentStudyList() {
        return studentStudyList;
    }


    /**
     * Sets the studentStudyList value for this StudentDTO.
     * 
     * @param studentStudyList
     */
    public void setStudentStudyList(se.lu.ics.StudentStudyDTO[] studentStudyList) {
        this.studentStudyList = studentStudyList;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof StudentDTO)) return false;
        StudentDTO other = (StudentDTO) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.studentName==null && other.getStudentName()==null) || 
             (this.studentName!=null &&
              this.studentName.equals(other.getStudentName()))) &&
            ((this.studentId==null && other.getStudentId()==null) || 
             (this.studentId!=null &&
              this.studentId.equals(other.getStudentId()))) &&
            ((this.address==null && other.getAddress()==null) || 
             (this.address!=null &&
              this.address.equals(other.getAddress()))) &&
            ((this.resultList==null && other.getResultList()==null) || 
             (this.resultList!=null &&
              java.util.Arrays.equals(this.resultList, other.getResultList()))) &&
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
        if (getStudentName() != null) {
            _hashCode += getStudentName().hashCode();
        }
        if (getStudentId() != null) {
            _hashCode += getStudentId().hashCode();
        }
        if (getAddress() != null) {
            _hashCode += getAddress().hashCode();
        }
        if (getResultList() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getResultList());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getResultList(), i);
                if (obj != null &&
                    !obj.getClass().isArray()) {
                    _hashCode += obj.hashCode();
                }
            }
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
        new org.apache.axis.description.TypeDesc(StudentDTO.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://ics.lu.se/", "StudentDTO"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("studentName");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "StudentName"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("studentId");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "StudentId"));
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
        elemField.setFieldName("resultList");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "ResultList"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://ics.lu.se/", "ResultDTO"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        elemField.setItemQName(new javax.xml.namespace.QName("http://ics.lu.se/", "ResultDTO"));
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
