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
    internal class MarkController
    {
        public List<Mark> GetAllMarks()
        {
            List<Mark> marks = new List<Mark>();

            using (var conn = DbCon.GetConnection())
            {
                string query = "SELECT * FROM Marks";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    marks.Add(new Mark
                    {
                        MarksID = Convert.ToInt32(reader["MarksID"]),
                        StudentName = reader["StudentName"].ToString(),
                        SubjectName = reader["SubjectName"].ToString(),
                        Marks = reader["Marks"].ToString(),
                        Date = reader["Date"].ToString(),
                    });
                }
            }

            return marks;
        }


        public void AddMark(Mark mark)
            {
                using (var conn = DbCon.GetConnection())
            {
                    string query = "INSERT INTO Marks (StudentName, SubjectName, Marks,Date) VALUES (@StudentName, @SubjectName, @Marks, @Date)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@StudentName", mark.StudentName);
                    cmd.Parameters.AddWithValue("@SubjectName", mark.SubjectName);
                    cmd.Parameters.AddWithValue("@Marks", mark.Marks);
                    cmd.Parameters.AddWithValue("@Date", mark.Date);
                    cmd.ExecuteNonQuery();
                }
            }

           
            public void UpdateMark(Mark mark)
            {
                using (var conn = DbCon.GetConnection())
                {
                    string query = "UPDATE Marks SET StudentName=@StudentName, SubjectName=@SubjectName, Marks=@Marks, Date=@Date WHERE MarksID=@MarksID";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);

                    cmd.Parameters.AddWithValue("@StudentName", mark.StudentName);
                    cmd.Parameters.AddWithValue("@SubjectName", mark.SubjectName);
                    cmd.Parameters.AddWithValue("@Marks", mark.Marks);
                    cmd.Parameters.AddWithValue("@Date", mark.Date);
                    cmd.Parameters.AddWithValue("@MarksID", mark.MarksID);

                    cmd.ExecuteNonQuery();
            }
            }


            public void DeleteMark(int id)
            {
                using (var conn = DbCon.GetConnection())
                {
                string query = "DELETE FROM Marks WHERE MarksID=@Id";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
            }
        
    }
}
