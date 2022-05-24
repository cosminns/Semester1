using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TopUp1.DAL.Interfaces;

namespace TopUp1.DAL
{
    public class VolumeDAO : IDAO<Volume>
    {
        public static readonly string connectionString = "Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;";

        public bool Create(Volume v)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prInsertVolume", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@TitleISBN", v.Title.ISBN));
                cmd.Parameters.Add(new SqlParameter("@VolumeNumber", v.VolumeNumber));
                cmd.Parameters.Add(new SqlParameter("@Borrowed", v.Borrowed));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }

        public bool Delete(Volume v)
        {
            using (SqlConnection conn = new SqlConnection("Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;"))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prDeleteVolume", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@TitleISBN", v.Title.ISBN));
                cmd.Parameters.Add(new SqlParameter("@TitleISBN", v.VolumeNumber));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }

        public Volume GetById(Volume v)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prGetVolumeInfo", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@TitleISBN", v.Title.ISBN));
                cmd.Parameters.Add(new SqlParameter("@VolumeNumber", v.VolumeNumber));
                SqlDataReader rdr;
                // execute the commandF
                rdr = cmd.ExecuteReader();
                Volume volume = new Volume();
                while (rdr.Read())
                {
                    volume.Title.ISBN = (string)rdr["TitleISBN"]; 
                    volume.VolumeNumber = (int)rdr["VolumeNumber"];
                    volume.Borrowed = (bool)rdr["Borrowed"];
                }
                rdr.Close();
                
                return volume;
            }
        }

        public bool Update(Volume v)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prUpdateVolume", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@TitleISBN", v.Title.ISBN));
                cmd.Parameters.Add(new SqlParameter("@VolumeNumber", v.VolumeNumber));
                cmd.Parameters.Add(new SqlParameter("@Borrowed", v.Borrowed));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }
    }
}