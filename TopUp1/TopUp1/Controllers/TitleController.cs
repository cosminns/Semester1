using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace TopUp1.Controllers
{
    public class TitleController : Controller
    {
        
        [HttpGet]
        [Route("api/title/{isbn}")]
        public Title GetTitleById(string isbn)
        {
            using (SqlConnection conn = new SqlConnection("Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;"))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prGetTitleInfo", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@TitleISBN", isbn));
                SqlDataReader rdr;
                // execute the command
                rdr = cmd.ExecuteReader();
                Title title = new Title();
                while (rdr.Read())
                {
                    title.ISBN = (string)rdr["ISBN"];
                    title.TitleDesc = (string)rdr["TitleDesc"];
                    title.TitleTitle = (string)rdr["Title"];
                    title.Publisher = (string)rdr["Publisher"];
                    title.PublishingDate = ((DateTime)rdr["PublishingDate"]).ToShortDateString();
                    title.SubjectArea = (string)rdr["SubjectArea"];
                    title.TitleType = (string)rdr["TitleType"];
                    title.TitleStatus = (string)rdr["TitleStatus"];
                }

                //create a command to get the authors and add them to the title

                cmd = new SqlCommand("prGetTitleAuthors", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ISBN", isbn));
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    title.Authors.Add((string)rdr["Name"]);
                }

                return title;
            }
        }
        [HttpPost]
        [Route("api/title")]
        public bool CreateTitle(string iSBN, string titleDesc, string title, string publisher, string publishingDate, string subjectArea, string titleType, string titleStatus)
        {
            using (SqlConnection conn = new SqlConnection("Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;"))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prInsertTitle", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@TitleISBN", iSBN));
                cmd.Parameters.Add(new SqlParameter("@Description", titleDesc));
                cmd.Parameters.Add(new SqlParameter("@Title", title));
                cmd.Parameters.Add(new SqlParameter("@Publisher", publisher));
                cmd.Parameters.Add(new SqlParameter("@PublishingDate", publishingDate));
                cmd.Parameters.Add(new SqlParameter("@SubjectArea", subjectArea));
                cmd.Parameters.Add(new SqlParameter("@TitleType", titleType));
                cmd.Parameters.Add(new SqlParameter("@TitleStatus", titleStatus));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }
        [HttpPut]
        [Route("api/title/{isbn}")]
        public bool UpdateTitle(string isbn, string titleDesc, string title, string publisher, string publishingDate, string subjectArea, string titleType, string titleStatus)
        {
            using (SqlConnection conn = new SqlConnection("Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;"))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prUpdateTitle", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@TitleISBN", isbn));
                cmd.Parameters.Add(new SqlParameter("@Description", titleDesc));
                cmd.Parameters.Add(new SqlParameter("@Title", title));
                cmd.Parameters.Add(new SqlParameter("@Publisher", publisher));
                cmd.Parameters.Add(new SqlParameter("@PublishingDate", publishingDate));
                cmd.Parameters.Add(new SqlParameter("@SubjectArea", subjectArea));
                cmd.Parameters.Add(new SqlParameter("@TitleType", titleType));
                cmd.Parameters.Add(new SqlParameter("@TitleStatus", titleStatus));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }
        [HttpDelete]
        [Route("api/title/{isbn}")]
        public bool DeleteTitle(string isbn)
        {
            using (SqlConnection conn = new SqlConnection("Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;"))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prDeleteTitle", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@TitleISBN", isbn));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }
    }
}
