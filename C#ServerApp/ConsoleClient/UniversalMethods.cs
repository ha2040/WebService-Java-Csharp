using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServiceKebabUni.DTO
{
    public class UniversalMethods
    {

        public static string SqlErrors(string sqlText, SqlException exception)
        {
            int errorCode = exception.Number;
            string errorMessage = exception.Message;
            if (errorCode == 0)
            {
                sqlText = "Could not connect to database server. Please contact Bjorn. Bjorn is available on Thursdays between 13:00-15:00";
            }
            else if (errorCode == 245 && errorMessage.Contains("converting the varchar value"))
            {
                sqlText = "This value must only contain numerical values. Additional error message: " + errorMessage;
            }
            else if (errorCode == 2627)
            {
                sqlText = "This value already exists. Additional error message: " + errorMessage;
            }
            else if (errorCode == 547)
            {
                sqlText = "No negative values may be inserted. Additional error message: " + errorMessage;
            }
            else if (errorMessage.Contains("pk_Employee"))
            {
                sqlText = ("Employee with this id already exist please try with a new one");
            }
            else if (errorMessage.Contains("pk_Faculty"))
            {
                sqlText = ("Faculty with this id already exist please try with a new one");
            }
            else if (errorMessage.Contains("pk_Course"))
            {
                sqlText = ("Course with this id already exist please try with a new one");
            }
            else if (errorMessage.Contains("pk_Exam"))
            {
                sqlText = ("Exam with this id already exist please try with a new one");
            }
            else if (errorMessage.Contains("pk_Student"))
            {
                sqlText = ("Student with this id already exist please try with a new one");
            }
            else
            {
                Console.WriteLine(exception.StackTrace);
                sqlText = "Oh no! An unexpected error has occurred. Please contact support for assistance. Error message: " + errorMessage;
            }
            return sqlText;
        }

    }
}