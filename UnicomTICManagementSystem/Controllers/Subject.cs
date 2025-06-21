using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Repositories;
using static System.Collections.Specialized.BitVector32;

using System;
using System.Collections.Generic;
using System.Linq;

namespace UnicomTICManagementSystem.Controllers
{
    internal class Subject
    {
        public string Name { get; internal set; }
        public int Id { get; internal set; }

        private static List<Subject> subjectList = new List<Subject>();

        internal static void DeleteSubject(int id)
        {
            using (var connection = new SQLiteConnection("Data Source=your_database_path.db"))
            {
                connection.Open();
                string query = "DELETE FROM Subjects WHERE Id = @Id";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        internal static List<Subject> GetAllSubjects()
        {
            return subjectList;
        }

        internal static void UpdateSubject(Subject subject)
        {
            var existing = subjectList.FirstOrDefault(s => s.Id == subject.Id);
            if (existing != null)
            {
                existing.Name = subject.Name;
            }
        }

        internal void addbtn(Subject subject)
        {
            subjectList.Add(subject);
        }

        internal void Clear()
        {
            Name = string.Empty;
            Id = 0;
        }
    }
}
