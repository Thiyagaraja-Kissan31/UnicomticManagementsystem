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
    internal class StaffController
    {
       
        public static void AddStaff(NewStaff staff)
        {
            using (var conn = DbCon.GetConnection())
            {
                string query = "INSERT INTO NewStaff (StaffName, Address, Gender, Dateofbirth, MobileNumber, EmailId) VALUES (@StaffName, @Address, @Gender, @Dateofbirth, @MobileNumber, @EmailId)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@StaffName", staff.StaffName);
                cmd.Parameters.AddWithValue("@Address", staff.Address);
                cmd.Parameters.AddWithValue("@Gender", staff.Gender);
                cmd.Parameters.AddWithValue("@Dateofbirth", staff.Dateofbirth);
                cmd.Parameters.AddWithValue("@MobileNumber", staff.MobileNumber);
                cmd.Parameters.AddWithValue("@EmailId", staff.EmailId);
                cmd.ExecuteNonQuery();
            }
        }

        public List<NewStaff> GetAllStaff()
        {
            List<NewStaff> staffList = new List<NewStaff>();

            using (var conn = DbCon.GetConnection())
            {
                
                string query = "SELECT * FROM NewStaff";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    staffList.Add(new NewStaff
                    {
                        StaffID = Convert.ToInt32(reader["StaffID"]),
                        StaffName = reader["StaffName"].ToString(),
                        Address = reader["Address"].ToString(),
                        Gender = reader["Gender"].ToString(),
                        Dateofbirth = reader["Dateofbirth"].ToString(),
                        MobileNumber = reader["MobileNumber"].ToString(),
                        EmailId = reader["EmailId"].ToString()
                    });
                }
            }

            return staffList;
        }

        public void UpdateStaff(NewStaff staff)
        {
            using (var conn = DbCon.GetConnection())
            {
                
                string query = "UPDATE NewStaff SET StaffName=@StaffName, Address=@Address, Gender=@Gender, Dateofbirth=@Dateofbirth, MobileNumber=@MobileNumber, EmailId=@EmailId WHERE StaffID=@Id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@StaffName", staff.StaffName);
                cmd.Parameters.AddWithValue("@Address", staff.Address);
                cmd.Parameters.AddWithValue("@Gender", staff.Gender);
                cmd.Parameters.AddWithValue("@Dateofbirth", staff.Dateofbirth);
                cmd.Parameters.AddWithValue("@MobileNumber", staff.MobileNumber);
                cmd.Parameters.AddWithValue("@EmailId", staff.EmailId);
                cmd.Parameters.AddWithValue("@Id", staff.StaffID);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStaff(int StaffID)
        {
            using (var conn = DbCon.GetConnection())
            {
                string query = "DELETE FROM NewStaff WHERE StaffID = @StaffID";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StaffID", StaffID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
