using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace RegexTestCase.UserRegistration
{
    [TestClass]
    public class UnitTest1
    {
        Registrations user = new Registrations();
        [TestMethod]
        public void FirstNameTest()
        {
            string name = "Iqbal";
            bool result = user.FirstName(name);
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void LastNameTest()
        {
            string name = "Ahmad";
            bool result = user.LastName(name);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void EmailTest()
        {
            string email1 = "ahmadiqbal.a786@gmail.com";
            string email2 = "iqbal143@yahoo.com";
            string email3 = "abc.200@yahoo.com";
            string email4 = "abc-567@abc.com";
            string email5 = "abc200@abc.co.in";
            bool result = user.Email(email1);
            bool result3 = user.Email(email3);
            bool result4 = user.Email(email4);
            bool result5 = user.Email(email5);
            bool result2 = user.Email(email2);
            Assert.AreEqual(true, result);
            Assert.AreEqual(true, result2);
            Assert.AreEqual(true, result3);
            Assert.AreEqual(true, result4);
            Assert.AreEqual(true, result5);
        }
        [TestMethod]
        public void MobileTest()
        {
            string mobile = "91 7989501656";
            bool result = user.PhoneNumber(mobile);
            Assert.AreEqual(true, result);

        }
        [TestMethod]
        public void PasswordTest()
        {
            string password = "Iqbal@a786";
            bool result = user.Password(password);
            Assert.AreEqual(true, result);
        }
    }
}
