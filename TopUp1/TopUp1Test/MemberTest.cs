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
        Mock<IDAO<Member>> mockMemberDAO = default!;
        MemberFacade systemUnderTest = default!;

        [Test]
        [TestCase(10002354, "Monte N Bass")]
        public void GetMemberTest(int ssn, string expectedName)
        {
            mockMemberDAO = new Mock<IDAO<Member>>(MockBehavior.Strict);
            mockMemberDAO.Setup(x => x.GetById(ssn)).Returns(new Member { Name = expectedName });
            systemUnderTest = new MemberFacade(mockMemberDAO.Object);
            var result = systemUnderTest.GetMemberInfo(ssn);

            Assert.That(result.Name, Is.EqualTo(expectedName));
        }
    }
}