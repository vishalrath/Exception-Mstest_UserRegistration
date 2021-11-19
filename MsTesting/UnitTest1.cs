using Microsoft.VisualStudio.TestTools.UnitTesting;
using Uc10_Using_LamdaFun_Exception_Mstesting_UserRegistration;

namespace MsTesting
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
            UsingLamda_UserRegistration testing = new UsingLamda_UserRegistration(Name);
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
            UsingLamda_UserRegistration testing = new UsingLamda_UserRegistration(LName);
            string actual = testing.validLastName();

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
            UsingLamda_UserRegistration testing = new UsingLamda_UserRegistration(MailId);
            string actual = testing.validMail();

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
            UsingLamda_UserRegistration testing = new UsingLamda_UserRegistration(Mobile);
            string actual = testing.MobileNo();

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
            UsingLamda_UserRegistration testing = new UsingLamda_UserRegistration(Pass);
            string actual = testing.Validpassword1();

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
            UsingLamda_UserRegistration testing = new UsingLamda_UserRegistration(Pass);
            string actual = testing.Validpassword2();

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
            UsingLamda_UserRegistration testing = new UsingLamda_UserRegistration(Pass);
            string actual = testing.Validpassword3();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestPassword4()
        {
            //AAA Methodology

            //Arrange
            string Pass = "Vish@lh1";
            string expected = "Valid";

            //Act
            UsingLamda_UserRegistration testing = new UsingLamda_UserRegistration(Pass);
            string actual = testing.Validpassword4();

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]

        public void ValidMailFormat()
        {
            //Arrange
            string pass1 = "abc@gmail.com";
            string expected = "Valid";

            //Act
            UsingLamda_UserRegistration testing = new UsingLamda_UserRegistration(pass1);
            string actual = testing.VlidMailFormat();
            //string reg = RegExWithException.CompleteMailPattern(name);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
