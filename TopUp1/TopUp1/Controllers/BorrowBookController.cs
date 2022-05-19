using Microsoft.AspNetCore.Mvc;
namespace TopUp1.Controllers
{
    public class BorrowBookController : Controller
    {
        [Route("api/borrowBook")]
        [HttpGet]
        public List<BorrowBook>GetBorrowBook()
        {
            var borrowBooks=new List<BorrowBook>();
            return borrowBooks;
        }
        [HttpGet]
        [Route("api/borrowBook/{id}")]
        public BorrowBook GetBorrowBookById(int id)
        {
            var borrowBook= new BorrowBook(1,"string",1,"string","string");
            return borrowBook;
        }
        [HttpPost]
        [Route("api/borrowBook")]
        public bool CreateBorrowBook(int memberSSN, string titleISBN, int volumeNumber, string lendDate, string returnDate)
        {
            var borrowBook = true;
            return borrowBook;
        }
        [HttpPut]
        [Route("api/district/{id}")]
        public bool UpdateBorrowBook(int memberSSN, string titleISBN, int volumeNumber, string lendDate, string returnDate)
        {
            //Checks for null parameters
            var result=true;
            return result;
        }
        [HttpDelete]
        [Route("api/borrowBook/{id}")]
        public bool DeleteBorrowBook(int id)
        {
            bool result = true;
            return result;
        }
            
    }
}
