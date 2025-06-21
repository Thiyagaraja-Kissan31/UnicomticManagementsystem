using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Model;
using UnicomTICManagementSystem.Repositories;
using UnicomTICManagementSystem.Views;

namespace UnicomTICManagementSystem.Controllers
{
    internal class StudentController
    {
        public void AddStudent(Students student)
        {
            using (var conn = DbCon.GetConnection())
            { 
               string query = "INSERT INTO Students (StudentName, Address, Gender, Date_of_Birth, SubjectName, PhoneNumber, EmailId) VALUES (@StudentName, @Address, @Gender, @Date_of_Birth, @SubjectName, @PhoneNumber, @EmailId)";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentName", student.StudentName);
                cmd.Parameters.AddWithValue("@Address", student.Address);
                cmd.Parameters.AddWithValue("@Gender", student.Gender);
                cmd.Parameters.AddWithValue("@Date_of_Birth", student.Date_of_Birth);
                cmd.Parameters.AddWithValue("@SubjectName", student.SubjectName);
                cmd.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber);
                cmd.Parameters.AddWithValue("@EmailId", student.EmailId);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Students> GetAllStudents()
        {
            List<Students> students = new List<Students>();

            using (var conn = DbCon.GetConnection())
            {
                string query = "SELECT * FROM Students";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    students.Add(new Students
                    {
                        StudentID = Convert.ToInt32(reader["StudentID"]),
                        StudentName = reader["StudentName"].ToString(),
                        Address = reader["Address"].ToString(),
                        Gender = reader["Gender"].ToString(),
                        Date_of_Birth = reader["Date_of_Birth"].ToString(),
                        SubjectName = reader["SubjectName"].ToString(),
                        PhoneNumber = reader["PhoneNumber"].ToString(),
                        EmailId = reader["EmailId"].ToString(),
                    });

                }
            }

            return students;
        }

        public void UpdateStudent(Students student)
        {
            using (var conn = DbCon.GetConnection())
            {
                string query = "UPDATE Students SET StudentName=@StudentName, Address=@Address, Gender=@Gender, Date_of_Birth=@Date_of_Birth, SubjectName=@SubjectName, PhoneNumber=@PhoneNumber, EmailId=@EmailId  WHERE StudentID=@StudentID";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentName", student.StudentName);
                cmd.Parameters.AddWithValue("@Address", student.Address);
                cmd.Parameters.AddWithValue("@Gender", student.Gender);
                cmd.Parameters.AddWithValue("@Date_of_Birth", student.Date_of_Birth);
                cmd.Parameters.AddWithValue("@SubjectName", student.SubjectName);
                cmd.Parameters.AddWithValue("@PhoneNumber", student.PhoneNumber);
                cmd.Parameters.AddWithValue("@EmailId", student.EmailId); 
                cmd.Parameters.AddWithValue("@StudentID", student.StudentID);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(int id)
        {
            using (var conn = DbCon.GetConnection())
            {
                
                string query = "DELETE FROM Students WHERE StudentID=@StudentID";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentID",id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
