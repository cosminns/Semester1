using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TopUp1.DAL.Interfaces;

namespace TopUp1.DAL
{
    public class StaffDAO : IDAO<Staff>
    {
        public static readonly string connectionString = "Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;";
        public bool Create(Staff t)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prInsertStaff", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@SSN", t.SSN));
                cmd.Parameters.Add(new SqlParameter("@Role_ID", t.Role.RoleID));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }

        public bool Delete(Staff t)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prDeleteStaff", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@SSN", t.SSN));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }

        public Staff GetById(Staff t)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prGetStaffInfo", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@SSN", t.SSN));
                SqlDataReader rdr;
                // execute the command
                rdr = cmd.ExecuteReader();
                Staff staff = new Staff();
                while (rdr.Read())
                {
                    staff.SSN = (int)rdr["SSN"];
                    staff.Name = (string)rdr["Name"];
                    staff.HomeAddress = (string)rdr["HomeAddress"];
                    staff.BirthDate = ((DateTime)rdr["DoB"]).ToShortDateString();
                    staff.Role.RoleName = (string)rdr["RoleName"];
                   
                }
                rdr.Close();

                //create a command to get the phone numbers and add them to the staff

                cmd = new SqlCommand("prGetPersonPhoneNumbers", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SSN", t.SSN));
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    staff.PhoneNumbers.Add((string)rdr["PhoneNumber"]);
                }
                rdr.Close();

                return staff;
            }
        }

        public bool Update(Staff t)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prUpdateStaff", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@SSN", t.SSN));
                cmd.Parameters.Add(new SqlParameter("@Role_ID", t.Role.RoleID));
                cmd.Parameters.Add(new SqlParameter("@HomeAddress", t.HomeAddress));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }
    }
}