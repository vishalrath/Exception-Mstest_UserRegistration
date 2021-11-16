using ExceptionUserRegistrationUc1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTestProjectUc1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstName()
        {
            //AAA Methodology

            //Arrange
            string Name = "Ram";
            string expected = "Valid";

            //Act
            RegExWithException testing = new RegExWithException(Name);
            string actual = testing.validFirstName();

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
