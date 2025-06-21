using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Repositories
{
    internal class DatabaseManager
    {
        public static void CreateTables()
        {
            using (var conn = DbCon.GetConnection())
            {
                var cmd = conn.CreateCommand();

                cmd.CommandText = @"
                    CREATE TABLE IF NOT EXISTS Students 
                    (
                        StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentName TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        Gender TEXT,
                        [Date_of_Birth] TEXT,
                        [SubjectName] TEXT,
                        PhoneNumber TEXT NOT NULL,
                        EmailId TEXT NOT NULL
                    );
                      
                    CREATE TABLE IF NOT EXISTS Subjects
                    (
                        SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                        SubjectName TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS EXAMS
                    (
                        ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                        SubjectName TEXT NOT NULL,
                        Date TEXT ,
                        Time TEXT,
                        FOREIGN KEY (SubjectID) REFERENCES Subjects(ID)
                    );

                    CREATE TABLE IF NOT EXISTS Attendance
                    (
                        AttendanceID INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentName TEXT NOT NULL,
                        SubjectName TEXT NOT NULL ,
                        Date TEXT,
                        Status TEXT,
                        FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
                        FOREIGN KEY (SubjectID) REFERENCES Subjects(ID)
                    );

                    CREATE TABLE IF NOT EXISTS Lectures
                    (
                        LectureID INTEGER PRIMARY KEY AUTOINCREMENT,
                        LecturerName TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        Gender TEXT,
                        [Dateofbirth] TEXT,
                        [SubjectName] TEXT NOT NULL,
                        MobileNumber TEXT NOT NULL,
                        Email TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS NewStaff
                    (
                        StaffID INTEGER PRIMARY KEY AUTOINCREMENT,
                        StaffName TEXT NOT NULL,
                        Address TEXT NOT NULL,
                        Gender TEXT,
                        [Dateofbirth] TEXT,
                        MobileNumber TEXT NOT NULL,
                        EmailID TEXT NOT NULL
                    );

                    CREATE TABLE IF NOT EXISTS Timetable
                    (
                        TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
                        SubjectName TEXT NOT NULL,
                        Lecturername TEXT NOT NULL,
                        Date TEXT NOT NULL                        
                    );

                    CREATE TABLE IF NOT EXISTS Marks
                    (
                        MarksID INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentName TEXT NOT NULL,
                        SubjectName TEXT NOT NULL,
                        Marks INTEGER,
                        Date TEXT,
                        FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
                        FOREIGN KEY (SubjectID) REFERENCES Subjects(ID)
                    );

                    CREATE TABLE IF NOT EXISTS AttendanceReport
                    (
                        ReportID INTEGER PRIMARY KEY AUTOINCREMENT,
                        StudentID INTEGER NOT NULL,
                        SubjectID INTEGER NOT NULL,
                        StudentName TEXT NOT NULL,
                        SubjectName TEXT NOT NULL,
                        Date TEXT NOT NULL,
                        Status TEXT NOT NULL,
                        FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
                        FOREIGN KEY (SubjectID) REFERENCES Subjects(ID)
                    );

                    CREATE TABLE IF NOT EXISTS LecturerSubjects
                    (
                        LecturerID INTEGER,
                        SubjectID INTEGER,
                        PRIMARY KEY (LecturerID, SubjectID),
                        FOREIGN KEY (LecturerID) REFERENCES Lectures(LectureID),
                        FOREIGN KEY (SubjectID) REFERENCES Subjects(ID)
                    );

                    CREATE TABLE IF NOT EXISTS StudentSubjects 
                    (
                        StudentID INTEGER,
                        SubjectID INTEGER,
                        PRIMARY KEY (StudentID, SubjectID),
                        FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
                        FOREIGN KEY (SubjectID) REFERENCES Subjects(ID)
                    );

                    CREATE TABLE IF NOT EXISTS ExamSubjects 
                    (
                        ExamID INTEGER,
                        SubjectID INTEGER,
                        PRIMARY KEY (ExamID, SubjectID),
                        FOREIGN KEY (ExamID) REFERENCES EXAMS(ExamID),
                        FOREIGN KEY (SubjectID) REFERENCES Subjects(ID)
                    );

                    CREATE TABLE IF NOT EXISTS StudentsExams
                    (
                        StudentID INTEGER,
                        ExamID INTEGER,
                        PRIMARY KEY (ExamID, StudentID),
                        FOREIGN KEY (ExamID) REFERENCES EXAMS(ExamID),
                        FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
                    );

                    CREATE TABLE IF NOT EXISTS ExamMarks
                    (
                        ExamID INTEGER,
                        StudentID INTEGER,
                        Marks INTEGER NOT NULL,
                        PRIMARY KEY (ExamID, StudentID),
                        FOREIGN KEY (ExamID) REFERENCES EXAMS(ExamID),
                        FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
                    );

                    CREATE TABLE IF NOT EXISTS StudentAttendance
                    (
                        StudentID INTEGER,
                        SubjectID INTEGER,
                        Date TEXT NOT NULL,
                        Status TEXT NOT NULL,
                        PRIMARY KEY (StudentID, SubjectID, Date),
                        FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
                        FOREIGN KEY (SubjectID) REFERENCES Subjects(ID)
                    );

                    CREATE TABLE IF NOT EXISTS StudentLectures
                    (
                        StudentID INTEGER,
                        LectureID INTEGER,
                        PRIMARY KEY (StudentID, LectureID),
                        FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
                        FOREIGN KEY (LectureID) REFERENCES Lectures(LectureID)
                    );

                    CREATE TABLE IF NOT EXISTS StudentMarks
                    (
                        StudentID INTEGER,
                        SubjectID INTEGER,
                        Marks INTEGER NOT NULL,
                        Date TEXT NOT NULL,
                        PRIMARY KEY (StudentID, SubjectID, Date),
                        FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
                        FOREIGN KEY (SubjectID) REFERENCES Subjects(ID)
                    );

                ";

                cmd.ExecuteNonQuery();
            }
        }
    }
}
