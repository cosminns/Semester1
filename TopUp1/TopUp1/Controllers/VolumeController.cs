using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace TopUp1.Controllers
{
    public class VolumeController : Controller
    {
        TitleController titleController = new TitleController();

        [Route("api/volume")]
        [HttpGet]
        public List<Volume> GetVolume()
        {
            var volumes = new List<Volume>();
            return volumes;
        }
        [HttpGet]
        [Route("api/volume/{titleISBN}/{volumeNumber}")]
        public Volume GetVolumeById(string titleISBN, int volumeNumber)
        {
            using (SqlConnection conn = new SqlConnection("Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;"))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prGetVolumeInfo", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@TitleISBN", titleISBN));
                cmd.Parameters.Add(new SqlParameter("@VolumeNumber", volumeNumber));
                SqlDataReader rdr;
                // execute the commandF
                rdr = cmd.ExecuteReader();
                Volume volume = new Volume();
                while (rdr.Read())
                {
                    volume.Title = titleController.GetTitleById((string)rdr["TitleISBN"]); 
                    volume.VolumeNumber = (int)rdr["VolumeNumber"];
                    volume.Borrowed = (bool)rdr["Borrowed"];
                }
                rdr.Close();
                
                return volume;
            }
        }
        [HttpPost]
        [Route("api/volume")]
        public bool CreateVolume(string titleISBN, int volumeNumber, byte borrowed)
        {
            using (SqlConnection conn = new SqlConnection("Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;"))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prInsertVolume", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@TitleISBN", titleISBN));
                cmd.Parameters.Add(new SqlParameter("@VolumeNumber", volumeNumber));
                cmd.Parameters.Add(new SqlParameter("@Borrowed", borrowed));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }
        [HttpPut]
        [Route("api/volume/{titleISBN}/{volumeNumber}")]
        public bool UpdateVolume(string titleISBN, int volumeNumber, byte borrowed)
        {
            using (SqlConnection conn = new SqlConnection("Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;"))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prUpdateVolume", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@TitleISBN", titleISBN));
                cmd.Parameters.Add(new SqlParameter("@VolumeNumber", volumeNumber));
                cmd.Parameters.Add(new SqlParameter("@Borrowed", borrowed));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }
        [HttpDelete]
        [Route("api/volume/{titleISBN}/{volumeNumber}")]
        public bool DeleteVolume(string titleISBN, int volumeNumber)
        {
            using (SqlConnection conn = new SqlConnection("Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;"))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prDeleteVolume", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@TitleISBN", titleISBN));
                cmd.Parameters.Add(new SqlParameter("@TitleISBN", volumeNumber));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }
    }
}
