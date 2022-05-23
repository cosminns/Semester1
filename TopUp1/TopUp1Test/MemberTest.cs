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
        Mock<IMemberDAO> mockMemberDAO = default!;
        MemberFacade systemUnderTest = default!;

        [TestCase(10002354, "Monte N Bass")]
        public void GetMemberTest(int ssn, string expectedName)
        {
            mockMemberDAO = new Mock<IMemberDAO>(MockBehavior.Strict);
            mockMemberDAO.Setup(x => x.GetMemberBySSN(ssn).Name).Returns(expectedName);
            systemUnderTest = new MemberFacade(mockMemberDAO.Object);
            var result = systemUnderTest.GetMemberBySSN(ssn);

            Assert.That(result.Name, Is.EqualTo(expectedName));
        }
    }
}