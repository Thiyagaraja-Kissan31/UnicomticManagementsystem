﻿using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Model;
using UnicomTICManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    internal class AttendanceController
    {
        public List<Attendance> GetAllAttendance()
        {
            List<Attendance> attendanceList = new List<Attendance>();

            using (var conn = DbCon.GetConnection())
            {
                string query = "SELECT * FROM Attendance";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    attendanceList.Add(new Attendance
                    {
                        AttendanceId = Convert.ToInt32(reader["AttendanceId"]),
                        StudentName = reader["StudentName"].ToString(),
                        SubjectName = reader["SubjectName"].ToString(),
                        Date = reader["Date"].ToString(),
                        Status = reader["Status"].ToString()
                    });
                }
            }

            return attendanceList;
        }


        public void AddAttendance(Attendance attendance)
        {
            using (var conn = DbCon.GetConnection())
            {
                string query = "INSERT INTO Attendance (StudentName, SubjectName, Date, Status) VALUES (@StudentName, @SubjectName, @Date, @Status)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentName", attendance.StudentName);
                cmd.Parameters.AddWithValue("@SubjectName", attendance.SubjectName);
                cmd.Parameters.AddWithValue("@Date", attendance.Date);
                cmd.Parameters.AddWithValue("@Status", attendance.Status);
                cmd.ExecuteNonQuery();
            }
        }

        
        public void UpdateAttendance(Attendance attendance)
        {
            using (var conn = DbCon.GetConnection())
            {
                string query = "UPDATE Attendance SET StudentName=@StudentName, SubjectName=@SubjectName, Date=@Date, @Status=Status WHERE AttendanceId=@Id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentName", attendance.StudentName);
                cmd.Parameters.AddWithValue("@SubjectName", attendance.SubjectName);
                cmd.Parameters.AddWithValue("@Date", attendance.Date);
                cmd.Parameters.AddWithValue("@Status", attendance.Status);
                cmd.Parameters.AddWithValue("@Id", attendance.AttendanceId);
                cmd.ExecuteNonQuery();
            }
        }


        public void DeleteAttendance(int id)
        {
            using (var conn = DbCon.GetConnection())
            {
                string query = "DELETE FROM Attendance WHERE AttendanceId=@Id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
