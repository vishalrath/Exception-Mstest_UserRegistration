using ExceptionUserRegistrastionUc7;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTestProject1
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

        [TestMethod]
        public void TestMobileNo()
        {
            //AAA Methodology

            //Arrange
            string Mobile = "91 7038762577";
            string expected = "Valid";

            //Act
            RegExWithException testing = new RegExWithException(Mobile);
            string actual = testing.MobileNo(Mobile);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestPassword()
        {
            //AAA Methodology

            //Arrange
            string Pass = "rathodab";
            string expected = "Valid";

            //Act
            RegExWithException testing = new RegExWithException(Pass);
            string actual = testing.Validpassword1(Pass);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestPassword2()
        {
            //AAA Methodology

            //Arrange
            string Pass = "Vishalhi";
            string expected = "Valid";

            //Act
            RegExWithException testing = new RegExWithException(Pass);
            string actual = testing.Validpassword2(Pass);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestPassword3()
        {
            //AAA Methodology

            //Arrange
            string Pass = "Vishalh1";
            string expected = "Valid";

            //Act
            RegExWithException testing = new RegExWithException(Pass);
            string actual = testing.Validpassword3(Pass);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
