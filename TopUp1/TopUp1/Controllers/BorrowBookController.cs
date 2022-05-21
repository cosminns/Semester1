using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace TopUp1.Controllers
{
    public class BorrowBookController : Controller
    {
        MemberController memberController = new MemberController();
        VolumeController volumeController = new VolumeController();

        // [Route("api/borrowBook")]
        // [HttpGet]
        // public List<BorrowBook>GetBorrowBook()
        // {
        //     var borrowBooks=new List<BorrowBook>();
        //     return borrowBooks;
        // }

        [HttpGet]
        [Route("api/borrowBook/{isbn}/{volumeNumber}/{ssn}/{lendDate}")]
        public BorrowBook GetBorrowBookById(string isbn, int volumeNumber, int ssn, DateTime lendDate)
        {
            using (SqlConnection conn = new SqlConnection("Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;"))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prGetBorrowInfo", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@TitleISBN", isbn));
                cmd.Parameters.Add(new SqlParameter("@VolumeNumber", volumeNumber));
                cmd.Parameters.Add(new SqlParameter("@MemberSSN", ssn));
                cmd.Parameters.Add(new SqlParameter("@LendDate", lendDate));
                SqlDataReader rdr;
                // execute the command
                rdr = cmd.ExecuteReader();
                BorrowBook borrowBook = new BorrowBook();
                while (rdr.Read())
                {
                    borrowBook.LendDate = ((DateTime)rdr["LendDate"]).ToShortDateString();
                    borrowBook.ReturnDate = ((DateTime)rdr["ReturnDate"]).ToShortDateString();
                    borrowBook.Member = memberController.GetMemberById(ssn);
                    borrowBook.Volume = volumeController.GetVolumeById(isbn, volumeNumber);
                }

                return borrowBook;
            }
        }

        [HttpPost]
        [Route("api/borrowBook")]
        public bool CreateBorrowBook(int memberSSN, string titleISBN, int volumeNumber)
        {
            using (SqlConnection conn = new SqlConnection("Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;"))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prInsertBorrow", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@MemberSSN", memberSSN));
                cmd.Parameters.Add(new SqlParameter("@TitleISBN", titleISBN));
                cmd.Parameters.Add(new SqlParameter("@VolumeNumber", volumeNumber));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }

        // [HttpPut]
        // [Route("api/district/{id}")]
        // public bool UpdateBorrowBook(int memberSSN, string titleISBN, int volumeNumber, string lendDate, string returnDate)
        // {
        //     //Checks for null parameters
        //     var result=true;
        //     return result;
        // }
        // [HttpDelete]
        // [Route("api/borrowBook/{id}")]
        // public bool DeleteBorrowBook(int id)
        // {
        //     bool result = true;
        //     return result;
        // }
    }
}
