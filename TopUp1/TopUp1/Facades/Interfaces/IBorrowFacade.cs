using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopUp1.Facades.Interfaces
{
    public interface IBorrowFacade
    {
        public bool SaveBorrow(BorrowBook borrowBook);
        public BorrowBook GetBorrowInfo(int ssn, string isbn, int volumeNumber, string lendDate);
    }
}