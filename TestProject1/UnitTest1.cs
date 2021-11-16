using ExceptionUserRegistrationUc3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
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
        [TestMethod]
        public void TestLastName()
        {
            //AAA Methodology

            //Arrange
            string LName = "Rat";
            string expected = "Valid";

            //Act
            RegExWithException testing = new RegExWithException(LName);
            string actual = testing.validFirstName();

            //Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void TestMail()
        {
            //AAA Methodology

            //Arrange
            string MailId = "abc.xyz@bl.co.in";
            string expected = "Valid";

            //Act
            RegExWithException testing = new RegExWithException(MailId);
            string actual = testing.validMail(MailId);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
