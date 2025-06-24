using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Model;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    internal class LecturerController
    {
        public List<Lecturer> GetAllLecturers()
        {
            List<Lecturer> lecturers = new List<Lecturer>();

            using (var conn = DbCon.GetConnection())
            {

                string query = "SELECT * FROM Lectures";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lecturers.Add(new Lecturer
                    {
                        LectureID = Convert.ToInt32(reader["LectureID"]),
                        LecturerName = reader["LecturerName"].ToString(),
                        SubjectName = reader["SubjectName"].ToString(),
                        Address = reader["Address"].ToString(),
                        Gender = reader["Gender"].ToString(),
                        Dateofbirth = reader["Dateofbirth"].ToString(),
                        MobileNumber = reader["MobileNumber"].ToString(),
                        Email = reader["Email"].ToString()
                    });
                }
            }

            return lecturers;
        }


        public void AddLecturer(Lecturer lecturer)
        {
            using (var conn = DbCon.GetConnection())
            {
                string cleanSubjectName = lecturer.SubjectName.Replace("Subject Name: ", "").Trim();


                string query = "INSERT INTO Lectures (LecturerName, SubjectName, Address, Gender, Dateofbirth, MobileNumber, Email) " +
                               "VALUES (@LecturerName, @SubjectName, @Address, @Gender, @Dateofbirth, @MobileNumber, @Email)";

                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@LecturerName", lecturer.LecturerName);
                cmd.Parameters.AddWithValue("@SubjectName", lecturer.SubjectName);
                cmd.Parameters.AddWithValue("@Address", lecturer.Address);
                cmd.Parameters.AddWithValue("@Gender", lecturer.Gender);
                cmd.Parameters.AddWithValue("@Dateofbirth", lecturer.Dateofbirth);
                cmd.Parameters.AddWithValue("@MobileNumber", lecturer.MobileNumber);
                cmd.Parameters.AddWithValue("@Email", lecturer.Email);
                cmd.ExecuteNonQuery();
            }
        }

        
        public void UpdateLecturer(Lecturer lecturer)
        {
            using (var conn = DbCon.GetConnection())
            {

                string cleanSubjectName = lecturer.SubjectName.Replace("Subject Name: ", "").Trim();

                string query = "UPDATE Lectures SET LecturerName=@LecturerName, SubjectName=@SubjectName, Address=@Address, " +
                               "Gender=@Gender, Dateofbirth=@Dateofbirth, MobileNumber=@MobileNumber, Email=@Email WHERE LectureID=@LectureID";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@LecturerName", lecturer.LecturerName);
                cmd.Parameters.AddWithValue("@SubjectName", lecturer.SubjectName);
                cmd.Parameters.AddWithValue("@Address", lecturer.Address);
                cmd.Parameters.AddWithValue("@Gender", lecturer.Gender);
                cmd.Parameters.AddWithValue("@Dateofbirth", lecturer.Dateofbirth);
                cmd.Parameters.AddWithValue("@MobileNumber", lecturer.MobileNumber);
                cmd.Parameters.AddWithValue("@Email", lecturer.Email);
                cmd.Parameters.AddWithValue("@LectureID", lecturer.LectureID);
                cmd.ExecuteNonQuery();
            }
        }


        public void DeleteLecturer(int id)
        {
            using (var conn = DbCon.GetConnection())
            {  
                string query = "DELETE FROM Lectures WHERE LectureID=@LectureID";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@LectureID", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
