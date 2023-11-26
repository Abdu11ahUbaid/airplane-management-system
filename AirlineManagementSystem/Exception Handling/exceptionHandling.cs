using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineManagementSystem.Exception_Handling
{
    internal class exceptionHandling
    {
        // Method to log exception in the database
        public static void LogException(Exception ex, string className, string methodName)
        {
            try
            {
                var con = configuration.getInstance().getConnection();

                string insertQuery = "INSERT INTO log_exception (ClassName, MethodName, ErrorMessage, LineNumber, ExceptionDateTime) " +
                                     "VALUES (@ClassName, @MethodName, @ErrorMessage, @LineNumber, @ExceptionDateTime)";

                // Get the stack trace information
                string stackTrace = ex.StackTrace;

                // Extract the line number from the stack trace
                int lineNumber = ExtractLineNumber(stackTrace);

                using (SqlCommand command = new SqlCommand(insertQuery, con))
                {
                    command.Parameters.AddWithValue("@ClassName", className);
                    command.Parameters.AddWithValue("@MethodName", methodName);
                    command.Parameters.AddWithValue("@ErrorMessage", ex.Message);
                    command.Parameters.AddWithValue("@LineNumber", lineNumber);
                    command.Parameters.AddWithValue("@ExceptionDateTime", DateTime.Now);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception logEx)
            {
                // Log the error in a log file or display it as needed
                MessageBox.Show("Error : ", logEx.Message);
                Console.WriteLine("Error logging exception: " + logEx.Message);
            }
        }

        // Helper method to extract the line number from the stack trace
        private static int ExtractLineNumber(string stackTrace)
        {
            // Example stack trace: "at Namespace.Class.Method() in C:\path\to\file.cs:line 123"
            int lineNumber = 0;

            // Find the "line" keyword in the stack trace
            int lineIndex = stackTrace.IndexOf(":line");

            if (lineIndex != -1)
            {
                // Try to parse the line number
                if (int.TryParse(stackTrace.Substring(lineIndex + 5), out lineNumber))
                {
                    return lineNumber;
                }
            }

            // Return 0 if the line number couldn't be extracted
            return lineNumber;
        }

    }
}
