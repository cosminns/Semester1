using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;


namespace TopUp1Test
{
    public class BorrowTest
    {
        IBorrowFacade borrowFacade;
        BorrowBook existingBorrow;

        [SetUp]
        public void Setup()
        {
            SetUpBorrow();
            Mock<IBorrowFacade> borrowFacadeMock = new Mock<IBorrowFacade>(MockBehavior.Loose);
            borrowFacadeMock.Setup<BorrowBook>
            (
                b => b.GetBorrowInfo
                (
                    existingBorrow.Member.SSN,
                    existingBorrow.Volume.Title.ISBN,
                    existingBorrow.Volume.VolumeNumber,
                    existingBorrow.LendDate
                )
            )
            .Returns(existingBorrow);
            borrowFacade = borrowFacadeMock.Object;
        }

        private void SetUpBorrow()
        {
            existingBorrow = new BorrowBook();
            existingBorrow.Member.SSN = 123;
            existingBorrow.Volume.VolumeNumber = 12;
            existingBorrow.Volume.Title.ISBN = "123";
            existingBorrow.LendDate = "123";
        }

        [Test]
        public void BorrowInfoHappyPathTest()
        {
            var borrow = borrowFacade.GetBorrowInfo
            (
                existingBorrow.Member.SSN,
                existingBorrow.Volume.Title.ISBN,
                existingBorrow.Volume.VolumeNumber,
                existingBorrow.LendDate
            );
            Assert.That(borrow.Member.SSN, Is.EqualTo(existingBorrow.Member.SSN));
            Assert.That(borrow.Volume.VolumeNumber, Is.EqualTo(existingBorrow.Volume.VolumeNumber));
            Assert.That(borrow.Volume.Title.ISBN, Is.EqualTo(existingBorrow.Volume.Title.ISBN));
            Assert.That(borrow.LendDate, Is.EqualTo(existingBorrow.LendDate));
        }

        [Test]
        [TestCase(21, "21", 21, "21")]
        public void BorrowInfoNonexistentPathTest(int ssn, string isbn, int volumeNumber, string lendDate)
        {
            var borrow = borrowFacade.GetBorrowInfo
            (
                ssn,
                isbn,
                volumeNumber,
                lendDate
            );
            Assert.That(borrow, Is.Null);
        }
    }
}