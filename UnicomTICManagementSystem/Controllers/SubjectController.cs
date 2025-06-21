using System;
using System.Collections.Generic;
using System.Data.SQLite;
using UnicomTICManagementSystem.Model;
using UnicomTICManagementSystem.Repositories;
using static System.Collections.Specialized.BitVector32;

namespace UnicomTICManagementSystem.Controllers
{
    internal class SubjectController
    {
        
        public static List<Subject> GetAllSubject()
        {
            var subject = new List<Subject>();

            using (var conn = DbCon.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Subjects", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    subject.Add(new Subject
                    {
                        Id = reader.GetInt32(0),
                        SubjectName = reader.GetString(1)
                    });
                }
            }

            return subject;
        }

        public void AddSubject(Subject subject)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO Subjects (SubjectName) VALUES (@name)";
                cmd.Parameters.AddWithValue("@SubjectName", subject.SubjectName);
                cmd = new SQLiteCommand("INSERT INTO Subjects (SubjectName) VALUES (@SubjectName)", conn);
                cmd.Parameters.AddWithValue("@SubjectName", subject.SubjectName);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateSubject(Subject subject)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE Subjects SET SubjectName = @name WHERE Id = @id";
                cmd.Parameters.AddWithValue("@name", subject.SubjectName);
                cmd.Parameters.AddWithValue("@id", subject.Id);
                cmd = new SQLiteCommand("UPDATE Subjects SET SubjectName = @Name WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Name", subject.SubjectName);
                cmd.Parameters.AddWithValue("@Id", subject.Id);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteSubject(int subjectId)
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM Subjects WHERE Id = @id";
                cmd.Parameters.AddWithValue("@id", subjectId);
                cmd = new SQLiteCommand("DELETE FROM Subjects WHERE Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", subjectId);
                cmd.ExecuteNonQuery();
            }
        }
    }
    
    
}

