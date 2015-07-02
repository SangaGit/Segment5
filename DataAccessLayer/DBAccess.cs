using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DBAccess
    {
        private string connectionString = ConfigurationSettings.AppSettings["ConnectionString"];

        public List<Student> GetAllStudents()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            List<Student> studentList = new List<Student>();

            cmd.CommandText = "spGetAllStudents";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            conn.Open();

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                studentList.Add(new Student
                {
                    ID = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    DOB = reader.GetDateTime(2),
                    GradePointAverage = reader.GetDecimal(3),
                    IsActive = reader.GetBoolean(4)
                });
            }
            conn.Close();
            return studentList;
        }

        public void InsertStudent(Student student)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "spAddStudents";
            cmd.Connection = conn;

            cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = student.Name;
            cmd.Parameters.Add("@dob", SqlDbType.Date).Value = student.DOB;
            cmd.Parameters.Add("@gpa", SqlDbType.Decimal).Value = student.GradePointAverage;
            cmd.Parameters.Add("@isActive", SqlDbType.Bit).Value = student.IsActive;
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
