using System.Data;
using System.Data.SqlClient;
using TopUp1.DAL.Interfaces;

namespace TopUp1.DAL
{
    public class TitleDAO : IDAO<Title>
    {
        public static readonly string connectionString = "Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;";
        public bool Create(Title title)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prInsertTitle", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@TitleISBN", title.ISBN));
                cmd.Parameters.Add(new SqlParameter("@Description", title.TitleDesc));
                cmd.Parameters.Add(new SqlParameter("@Title", title.TitleTitle));
                cmd.Parameters.Add(new SqlParameter("@Publisher", title.Publisher));
                cmd.Parameters.Add(new SqlParameter("@PublishingDate", title.PublishingDate));
                cmd.Parameters.Add(new SqlParameter("@SubjectArea", title.SubjectArea));
                cmd.Parameters.Add(new SqlParameter("@TitleType", title.TitleType));
                cmd.Parameters.Add(new SqlParameter("@TitleStatus", title.TitleStatus));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }

        public bool Delete(Title title)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prDeleteTitle", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@TitleISBN", title.ISBN));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }

        public Title GetById(Title t)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prGetTitleInfo", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@TitleISBN", t.ISBN));
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
                    title.PublishingDate = ((DateTime)rdr["PublishingDate"]).ToString("yyyy-MM-dd");
                    title.SubjectArea = (string)rdr["SubjectArea"];
                    title.TitleType = (string)rdr["TitleType"];
                    title.TitleStatus = (string)rdr["TitleStatus"];
                }
                rdr.Close();

                //create a command to get the authors and add them to the title

                cmd = new SqlCommand("prGetTitleAuthors", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ISBN", t.ISBN));
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    title.Authors.Add((string)rdr["Name"]);
                }
                rdr.Close();

                return title;
            }
        }

        public bool Update(Title title)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prUpdateTitle", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@TitleISBN", title.ISBN));
                cmd.Parameters.Add(new SqlParameter("@Description", title.TitleDesc));
                cmd.Parameters.Add(new SqlParameter("@Title", title.TitleTitle));
                cmd.Parameters.Add(new SqlParameter("@Publisher", title.Publisher));
                cmd.Parameters.Add(new SqlParameter("@PublishingDate", title.PublishingDate));
                cmd.Parameters.Add(new SqlParameter("@SubjectArea", title.SubjectArea));
                cmd.Parameters.Add(new SqlParameter("@TitleType", title.TitleType));
                cmd.Parameters.Add(new SqlParameter("@TitleStatus", title.TitleStatus));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }
    }
}