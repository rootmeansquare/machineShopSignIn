using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ESSApp
{
    class SQLClass
    {
        string connectionString = ESSApp.Properties.Settings.Default.Setting1;
        
        
        DataTable queryESS (string command)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            DataTable results = new DataTable();
            SqlDataAdapter query = new SqlDataAdapter(command, conn);
            
            try
            {
                query.Fill(results);
            }
            catch (Exception error)
            {

            }
            finally
            {
                conn.Close();
            }
            return results;
        }

        public void newstudent()
        {
            string querystring = "INSERT INTO Students (StudentNumber, FirstName, LastName, Class, Type, Email) VALUES ('" + Variables.newstudentid + "','" + Variables.newfirstname
                +"','" + Variables.newlastname + "','" + Variables.newclass + "','" + Variables.newtype + "','" +Variables.newemail + "')" ;

            queryESS(querystring);
        }

        public DataTable getStudent(string studentID)
        {
            string querystring = "SELECT * FROM Students WHERE StudentNumber = '" + studentID + "'";
            return(queryESS(querystring));
        }
    }
}
