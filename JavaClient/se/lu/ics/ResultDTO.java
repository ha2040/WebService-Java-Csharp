/**
 * ResultDTO.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package se.lu.ics;

public class ResultDTO  implements java.io.Serializable {
    private se.lu.ics.ExamDTO exam;

    private se.lu.ics.StudentDTO student;

    private int points;

    public ResultDTO() {
    }

    public ResultDTO(
           se.lu.ics.ExamDTO exam,
           se.lu.ics.StudentDTO student,
           int points) {
           this.exam = exam;
           this.student = student;
           this.points = points;
    }


    /**
     * Gets the exam value for this ResultDTO.
     * 
     * @return exam
     */
    public se.lu.ics.ExamDTO getExam() {
        return exam;
    }


    /**
     * Sets the exam value for this ResultDTO.
     * 
     * @param exam
     */
    public void setExam(se.lu.ics.ExamDTO exam) {
        this.exam = exam;
    }


    /**
     * Gets the student value for this ResultDTO.
     * 
     * @return student
     */
    public se.lu.ics.StudentDTO getStudent() {
        return student;
    }


    /**
     * Sets the student value for this ResultDTO.
     * 
     * @param student
     */
    public void setStudent(se.lu.ics.StudentDTO student) {
        this.student = student;
    }


    /**
     * Gets the points value for this ResultDTO.
     * 
     * @return points
     */
    public int getPoints() {
        return points;
    }


    /**
     * Sets the points value for this ResultDTO.
     * 
     * @param points
     */
    public void setPoints(int points) {
        this.points = points;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof ResultDTO)) return false;
        ResultDTO other = (ResultDTO) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.exam==null && other.getExam()==null) || 
             (this.exam!=null &&
              this.exam.equals(other.getExam()))) &&
            ((this.student==null && other.getStudent()==null) || 
             (this.student!=null &&
              this.student.equals(other.getStudent()))) &&
            this.points == other.getPoints();
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
        if (getExam() != null) {
            _hashCode += getExam().hashCode();
        }
        if (getStudent() != null) {
            _hashCode += getStudent().hashCode();
        }
        _hashCode += getPoints();
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(ResultDTO.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://ics.lu.se/", "ResultDTO"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("exam");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "Exam"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://ics.lu.se/", "ExamDTO"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("student");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "Student"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://ics.lu.se/", "StudentDTO"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("points");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "Points"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        elemField.setNillable(false);
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
