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
    internal class ExamController
    {  
        public void AddExam(Exam exam)
        {
            using (var conn = DbCon.GetConnection())
            {
                
                string query = "INSERT INTO Exams (SubjectName, Date, Time) VALUES (@SubjectName, @Date, @Time)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@SubjectName", exam.SubjectName);
                cmd.Parameters.AddWithValue("@Date", exam.Date);
                cmd.Parameters.AddWithValue("@Time", exam.Time);
                cmd.ExecuteNonQuery();
            }
        }

        public List<Exam> GetAllExams()
        {
            List<Exam> exams = new List<Exam>();

            using (var conn = DbCon.GetConnection())
            {
                
                string query = "SELECT * FROM Exams";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    exams.Add(new Exam
                    {
                        Id = Convert.ToInt32(reader["ExamID"]),
                        SubjectName = reader["SubjectName"].ToString(),
                        Date = reader["Date"].ToString(),
                        Time = reader["Time"].ToString()
                    }
                    );
                }
            }

            return exams;
        }

        public void UpdateExam(Exam exam)
        {
            using (var conn = DbCon.GetConnection())
            {
                
                string query = "UPDATE Exams SET SubjectName=@SubjectName, Date=@Date, Time=@Time WHERE ExamID=@Id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@SubjectName", exam.SubjectName);
                cmd.Parameters.AddWithValue("@Date", exam.Date);
                cmd.Parameters.AddWithValue("@Time", exam.Time);
                cmd.Parameters.AddWithValue("@Id", exam.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteExam(int id)
        {
            using (var conn = DbCon.GetConnection())
            {
                string query = "DELETE FROM Exams WHERE ExamId=@Id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
