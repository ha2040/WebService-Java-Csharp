/**
 * ExamDTO.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package se.lu.ics;

public class ExamDTO  implements java.io.Serializable {
    private java.lang.String examID;

    private se.lu.ics.CourseDTO course;

    private java.lang.String room;

    private java.util.Calendar examDate;

    private int credits;

    private se.lu.ics.ResultDTO[] results;

    public ExamDTO() {
    }

    public ExamDTO(
           java.lang.String examID,
           se.lu.ics.CourseDTO course,
           java.lang.String room,
           java.util.Calendar examDate,
           int credits,
           se.lu.ics.ResultDTO[] results) {
           this.examID = examID;
           this.course = course;
           this.room = room;
           this.examDate = examDate;
           this.credits = credits;
           this.results = results;
    }


    /**
     * Gets the examID value for this ExamDTO.
     * 
     * @return examID
     */
    public java.lang.String getExamID() {
        return examID;
    }


    /**
     * Sets the examID value for this ExamDTO.
     * 
     * @param examID
     */
    public void setExamID(java.lang.String examID) {
        this.examID = examID;
    }


    /**
     * Gets the course value for this ExamDTO.
     * 
     * @return course
     */
    public se.lu.ics.CourseDTO getCourse() {
        return course;
    }


    /**
     * Sets the course value for this ExamDTO.
     * 
     * @param course
     */
    public void setCourse(se.lu.ics.CourseDTO course) {
        this.course = course;
    }


    /**
     * Gets the room value for this ExamDTO.
     * 
     * @return room
     */
    public java.lang.String getRoom() {
        return room;
    }


    /**
     * Sets the room value for this ExamDTO.
     * 
     * @param room
     */
    public void setRoom(java.lang.String room) {
        this.room = room;
    }


    /**
     * Gets the examDate value for this ExamDTO.
     * 
     * @return examDate
     */
    public java.util.Calendar getExamDate() {
        return examDate;
    }


    /**
     * Sets the examDate value for this ExamDTO.
     * 
     * @param examDate
     */
    public void setExamDate(java.util.Calendar examDate) {
        this.examDate = examDate;
    }


    /**
     * Gets the credits value for this ExamDTO.
     * 
     * @return credits
     */
    public int getCredits() {
        return credits;
    }


    /**
     * Sets the credits value for this ExamDTO.
     * 
     * @param credits
     */
    public void setCredits(int credits) {
        this.credits = credits;
    }


    /**
     * Gets the results value for this ExamDTO.
     * 
     * @return results
     */
    public se.lu.ics.ResultDTO[] getResults() {
        return results;
    }


    /**
     * Sets the results value for this ExamDTO.
     * 
     * @param results
     */
    public void setResults(se.lu.ics.ResultDTO[] results) {
        this.results = results;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof ExamDTO)) return false;
        ExamDTO other = (ExamDTO) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.examID==null && other.getExamID()==null) || 
             (this.examID!=null &&
              this.examID.equals(other.getExamID()))) &&
            ((this.course==null && other.getCourse()==null) || 
             (this.course!=null &&
              this.course.equals(other.getCourse()))) &&
            ((this.room==null && other.getRoom()==null) || 
             (this.room!=null &&
              this.room.equals(other.getRoom()))) &&
            ((this.examDate==null && other.getExamDate()==null) || 
             (this.examDate!=null &&
              this.examDate.equals(other.getExamDate()))) &&
            this.credits == other.getCredits() &&
            ((this.results==null && other.getResults()==null) || 
             (this.results!=null &&
              java.util.Arrays.equals(this.results, other.getResults())));
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
        if (getExamID() != null) {
            _hashCode += getExamID().hashCode();
        }
        if (getCourse() != null) {
            _hashCode += getCourse().hashCode();
        }
        if (getRoom() != null) {
            _hashCode += getRoom().hashCode();
        }
        if (getExamDate() != null) {
            _hashCode += getExamDate().hashCode();
        }
        _hashCode += getCredits();
        if (getResults() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getResults());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getResults(), i);
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
        new org.apache.axis.description.TypeDesc(ExamDTO.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://ics.lu.se/", "ExamDTO"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("examID");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "ExamID"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("course");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "Course"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://ics.lu.se/", "CourseDTO"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("room");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "Room"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("examDate");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "ExamDate"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "dateTime"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("credits");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "Credits"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "int"));
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
        elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("results");
        elemField.setXmlName(new javax.xml.namespace.QName("http://ics.lu.se/", "Results"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://ics.lu.se/", "ResultDTO"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        elemField.setItemQName(new javax.xml.namespace.QName("http://ics.lu.se/", "ResultDTO"));
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
