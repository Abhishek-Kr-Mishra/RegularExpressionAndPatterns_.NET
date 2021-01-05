using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpressionAndPatternsProgram;

namespace UserRegistrationUnitTestProject
{
    [TestClass]
    public class UserRegistrationUnitTestClass
    {
        readonly PatternsMatching patternsMatching = new PatternsMatching();
        [TestMethod]
        public void GivenFirstName_WhenValidate_ShouldReturnTrue()
        {
            Assert.AreEqual(true, patternsMatching.ValidateFirstName("Abhishek"));
        }
        [TestMethod]
        public void GivenLastName_WhenValidate_ShouldReturnTrue()
        {
            Assert.AreEqual(true, patternsMatching.ValidateLastName("Mishra"));
        }
        [TestMethod]
        public void GivenEmail_WhenValidate_ShouldReturnTrue()
        {
            Assert.AreEqual(true, patternsMatching.ValidateEmail("abh224272@gmail.com"));
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnTrue()
        {
            Assert.AreEqual(true, patternsMatching.ValidatePassword("abhishekMishrA@124"));
        }
        [TestMethod]
        public void GivenPhoneNumber_WhenValidate_ShouldReturnTrue()
        {
            Assert.AreEqual(true, patternsMatching.ValidatePhoneNumber("+917559171697"));
        }
        [DataRow("1.abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataTestMethod]
        public void GivenMultipleEntryOfEmailAddress_WhenValidate_ShouldReturnTrue(string email)
        {
            Assert.AreEqual(true, patternsMatching.ValidateEmail(email));
        }
    }
}
