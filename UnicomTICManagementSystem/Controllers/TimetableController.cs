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
    internal class TimetableController
    {
        public void AddTimetable(Timetable timetable)
        {
            using (var conn = DbCon.GetConnection())
            {

                string query = "INSERT INTO Timetable (SubjectName, LecturerName, Date) VALUES (@SubjectName, @LecturerName, @Date)";
                using (var command = new SQLiteCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@SubjectName", timetable.SubjectName);
                    command.Parameters.AddWithValue("@LecturerName", timetable.LecturerName);
                    command.Parameters.AddWithValue("@Date", timetable.Date);
                    command.ExecuteNonQuery();
                }
            }
        }


        public void UpdateTimetable(Timetable timetable)
        {
            using (var conn = DbCon.GetConnection())
            {

                string query = "UPDATE Timetable SET SubjectName=@SubjectName, Date=@Date WHERE TimetableID=@Id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@SubjectName", timetable.SubjectName);
                cmd.Parameters.AddWithValue("@Date", timetable.Date);
                cmd.Parameters.AddWithValue("@Id", timetable.TimetableID);
                cmd.ExecuteNonQuery();
            }
        }


        public List<Timetable> GetAllTimetables()
        {
            var timetables = new List<Timetable>();
            using (var conn = DbCon.GetConnection())
            {
                string query = "SELECT TimetableID, SubjectName, Lecturername, Date FROM Timetable";
                using (var command = new SQLiteCommand(query, conn))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        timetables.Add(new Timetable
                        {
                            TimetableID = reader.GetInt32(0),
                            SubjectName = reader["SubjectName"].ToString(),
                            LecturerName = reader["Lecturername"].ToString(),
                            Date = reader["Date"].ToString()
                        });
                    }
                }
            }
            return timetables;
        }

        public void DeleteTimetable(int id)
        {
            using (var conn = DbCon.GetConnection())
            {  
                    string query = "DELETE FROM Timetable WHERE TimetableID=@Id";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                
            }
            
        }
    }
}
