using Microsoft.AspNetCore.Mvc;
using TopUp1.Facades;
using TopUp1.DAL;
using TopUp1.Facades.Interfaces;

namespace TopUp1.Controllers
{
    public class BorrowBookController : Controller
    {
        IBorrowFacade borrowFacade = new BorrowFacade(
            new BorrowDAO(),
            new VolumeFacade(
                new VolumeDAO(),
                new TitleFacade(new TitleDAO())
            ),
            new MemberFacade(new MemberDAO())
        );

        // [Route("api/borrowBook")]
        // [HttpGet]
        // public List<BorrowBook>GetBorrowBook()
        // {
        //     var borrowBooks=new List<BorrowBook>();
        //     return borrowBooks;
        // }

        [HttpGet]
        [Route("api/borrowBook/{isbn}/{volumeNumber}/{ssn}/{lendDate}")]
        public BorrowBook GetBorrowBookById(string isbn, int volumeNumber, int ssn, string lendDate)
        {
            return borrowFacade.GetBorrowInfo(ssn, isbn, volumeNumber, lendDate);
        }

        [HttpPost]
        [Route("api/borrowBook")]
        public bool CreateBorrowBook(int memberSSN, string titleISBN, int volumeNumber)
        {
            BorrowBook borrowBook = new BorrowBook();
            borrowBook.Member.SSN = memberSSN;
            borrowBook.Volume.VolumeNumber = volumeNumber;
            borrowBook.Volume.Title.ISBN = titleISBN;
            return borrowFacade.SaveBorrow(borrowBook);
        }

        [HttpPut]
        [Route("api/borrowBook/{isbn}/{volumeNumber}/{ssn}/{lendDate}")]
        public bool ReturnBorrowBook(string isbn, int volumeNumber, int ssn, string lendDate)
        {
            return borrowFacade.ReturnBorrow(ssn, isbn, volumeNumber, lendDate);
        }
        // [HttpDelete]
        // [Route("api/borrowBook/{id}")]
        // public bool DeleteBorrowBook(int id)
        // {
        //     bool result = true;
        //     return result;
        // }
    }
}
