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
            try
            {
                bool result = user.FirstName(null);
                Assert.AreEqual(true, result);
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid FirstName", e.Message);
            }

        }
        [TestMethod]
        public void LastNameTest()
        {
            try
            {
                bool result = user.LastName(null);
                Assert.AreEqual(true, result);
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid LastName", e.Message);
            }

        }
        [TestMethod]
        public void EmailTest()
        {
            try
            {
                bool result = user.Email(null);
                Assert.AreEqual(true, result);
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid Email Id", e.Message);
            }
        }
        [TestMethod]
        public void MobileTest()
        {
            try
            {
                bool result = user.PhoneNumber(null);
                Assert.AreEqual(true, result);
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid Phone Number", e.Message);
            }

        }
        [TestMethod]
        public void PasswordTest()
        {
            try
            {
                bool result = user.Password(null);
                Assert.AreEqual(true, result);
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid Password", e.Message);
            }
        }
    }
}
