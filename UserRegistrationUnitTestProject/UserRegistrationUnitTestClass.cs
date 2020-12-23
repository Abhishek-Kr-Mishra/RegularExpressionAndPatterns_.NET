using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpressionAndPatternsProgram;

namespace UserRegistrationUnitTestProject
{
    [TestClass]
    public class UserRegistrationUnitTestClass
    {
        readonly PatternsMatching patternsMatching = new PatternsMatching();
        [TestMethod]
        public void ValidateFirsNameTestMethod()
        {
            Assert.AreEqual(true, patternsMatching.ValidateFirstName("Abhishek"));
        }
        [TestMethod]
        public void ValidateLastNameTestMethod()
        {
            Assert.AreEqual(true, patternsMatching.ValidateLastName("Mishra"));
        }
        [TestMethod]
        public void ValidateEmailTestMethod()
        {
            Assert.AreEqual(true, patternsMatching.ValidateEmail("abh224272@gmail.com"));
        }
        [TestMethod]
        public void ValidatePasswordTestMethod()
        {
            Assert.AreEqual(true, patternsMatching.ValidatePassword("abhishekMishrA@124"));
        }
        [TestMethod]
        public void ValidatePhoneNumber()
        {
            Assert.AreEqual(true, patternsMatching.ValidatePhoneNumber("+917559171697"));
        }
    }
}
