using Microsoft.VisualStudio.TestTools.UnitTesting;
using PasswordValidate.Services;

namespace PasswordValidateTest
{
    [TestClass]
    public class PasswordValidateTest
    {
        [TestMethod]
        public void SuccessTest()
        {
            string pass = "Admin@123";
            Assert.AreEqual(PasswordValidateService.Validate(pass), true);
        }
        [TestMethod]
        public void FailTest()
        {
            string pass = "Admin@111";
            Assert.AreEqual(PasswordValidateService.Validate(pass), false);
        }
        [TestMethod]
        public void FailTest1()
        {
            string pass = "";
            Assert.AreEqual(PasswordValidateService.Validate(pass), false);
        }
        [TestMethod]
        public void FailTest2()
        {
            string pass = "Admm";
            Assert.AreEqual(PasswordValidateService.Validate(pass), false);
        }
        [TestMethod]
        public void FailTest3()
        {
            string pass = "Ad";
            Assert.AreEqual(PasswordValidateService.Validate(pass), false);
        }
        [TestMethod]
        public void FailTest4()
        {
            string pass = "AAddmmiinn";
            Assert.AreEqual(PasswordValidateService.Validate(pass), false);
        }
        [TestMethod]
        public void FailTest5()
        {
            string pass = "Admin@12";
            Assert.AreEqual(PasswordValidateService.Validate(pass), false);
        }
    }
}
