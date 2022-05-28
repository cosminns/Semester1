using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TopUp1.DAL.Interfaces;

namespace TopUp1.DAL
{
    public class BorrowDAO : IDAO<BorrowBook>
    {
        public static readonly string connectionString = "Server=gtlgroup5.database.windows.net; Database=GTL; User Id = gtlgroup5admin; Password=5Pn4HVsMtZwmJYv;";

        public bool Create(BorrowBook b)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prInsertBorrow", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@MemberSSN", b.Member.SSN));
                cmd.Parameters.Add(new SqlParameter("@TitleISBN", b.Volume.Title.ISBN));
                cmd.Parameters.Add(new SqlParameter("@VolumeNumber", b.Volume.VolumeNumber));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }

        public bool Delete(BorrowBook b)
        {
            return false;
        }

        public BorrowBook GetById(BorrowBook b)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prGetBorrowInfo", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@TitleISBN", b.Volume.Title.ISBN));
                cmd.Parameters.Add(new SqlParameter("@VolumeNumber", b.Volume.VolumeNumber));
                cmd.Parameters.Add(new SqlParameter("@MemberSSN", b.Member.SSN));
                cmd.Parameters.Add(new SqlParameter("@LendDate", b.LendDate));
                SqlDataReader rdr;
                // execute the command
                rdr = cmd.ExecuteReader();
                BorrowBook borrowBook = new BorrowBook();
                while (rdr.Read())
                {
                    borrowBook.LendDate = ((DateTime)rdr["LendDate"]).ToString("yyyy-MM-dd");
                    borrowBook.DeadLine = ((DateTime)rdr["DeadLine"]).ToString("yyyy-MM-dd");
                    var returnDate = rdr["ReturnDate"];
                    if (returnDate is not System.DBNull)
                        borrowBook.ReturnDate = ((DateTime)returnDate).ToString("yyyy-MM-dd");
                    else
                        borrowBook.ReturnDate = String.Empty;
                    borrowBook.Member.SSN = (int)rdr["MemberSSN"];
                    borrowBook.Volume.Title.ISBN = (string)rdr["TitleISBN"];
                    borrowBook.Volume.VolumeNumber = (int)rdr["VolumeNumber"];
                }
                rdr.Close();

                return borrowBook;
            }
        }

        public bool Update(BorrowBook b)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("prReturnBorrow", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@TitleISBN", b.Volume.Title.ISBN));
                cmd.Parameters.Add(new SqlParameter("@VolumeNumber", b.Volume.VolumeNumber));
                cmd.Parameters.Add(new SqlParameter("@MemberSSN", b.Member.SSN));
                cmd.Parameters.Add(new SqlParameter("@LendDate", b.LendDate));
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    return true;
                }
                else return false;
            }
        }
    }
}