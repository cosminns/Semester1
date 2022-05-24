using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopUp1.Facades.Interfaces;
using TopUp1.DAL.Interfaces;

namespace TopUp1.Facades
{
    public class BorrowFacade : IBorrowFacade
    {
        private IDAO<BorrowBook> borrowDAO;
        private IMemberFacade memberFacade;
        private IVolumeFacade volumeFacade;
        public BorrowFacade(IDAO<BorrowBook> borrowDAO, IVolumeFacade volumeFacade, IMemberFacade memberFacade)
        {
            this.borrowDAO = borrowDAO;
            this.memberFacade = memberFacade;
            this.volumeFacade = volumeFacade;
        }

        public BorrowBook GetBorrowInfo(int ssn, string isbn, int volumeNumber, string lendDate)
        {
            BorrowBook borrowBook;
            borrowBook = borrowDAO.GetById(new BorrowBook
            {
                LendDate = lendDate,
                Member = new Member { SSN = ssn },
                Volume = new Volume
                {
                    VolumeNumber = volumeNumber,
                    Title = new Title { ISBN = isbn }
                }
            });
            borrowBook.Volume = volumeFacade.GetVolumeInfo(borrowBook.Volume.Title.ISBN, borrowBook.Volume.VolumeNumber);
            borrowBook.Member = memberFacade.GetMemberInfo(borrowBook.Member.SSN);
            return borrowBook;
        }

        public bool SaveBorrow(BorrowBook borrowBook)
        {
            return borrowDAO.Create(borrowBook);
        }
    }
}