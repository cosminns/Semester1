using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using TopUp1.Facades;
using TopUp1.DAL.Interfaces;

namespace TopUp1Test
{
    [TestFixture]
    public class MemberTest
    {
        IDAO<Member> memberDAO;
        Member existingMember;

        [SetUp]
        public void Setup()
        {
            SetUpMember();
            Mock<IDAO<Member>> meberDAOMock = new Mock<IDAO<Member>>(MockBehavior.Loose);
            meberDAOMock.Setup<Member>
            (
                b => b.GetById
                (
                    It.Is<Member>(m => m.SSN == existingMember.SSN)
                )
            )
            .Returns(existingMember);
            memberDAO = meberDAOMock.Object;
        }

        private void SetUpMember()
        {
            existingMember = new Member();
            existingMember.SSN = 10002354;
            existingMember.Name = "Monte N Bass";
        }

        [Test]
        [TestCase(10002354, "Monte N Bass")]
        public void GetMemberHappyPathTest(int ssn, string expectedName)
        {
            var member = memberDAO.GetById(new Member { SSN = ssn });
            Assert.That(member, Is.Not.Null);
            Assert.That(member.Name, Is.EqualTo(expectedName));
        }

        [Test]
        [TestCase(123, "123")]
        public void GetMemberNonexistentPathTest(int ssn, string expectedName)
        {
            var member = memberDAO.GetById(new Member { SSN = ssn });
            Assert.That(member, Is.Null);
        }
    }
}