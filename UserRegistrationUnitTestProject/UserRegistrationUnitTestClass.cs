using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegularExpressionAndPatternsProgram;
using System;

namespace UserRegistrationUnitTestProject
{
    [TestClass]
    public class UserRegistrationUnitTestClass
    {
        readonly PatternsMatching patternsMatching = new PatternsMatching();
        [TestMethod]
        public void GivenFirstName_WhenValidate_ShouldReturnTrue()
        {
            try
            {
                Assert.AreEqual("First Name is Valid", patternsMatching.ValidateFirstNameByUsingLambda("Abhishek"));
            }
            catch(RegularExpressionCustomException rec)
            {
                Assert.AreEqual("Invalid First Name", rec.Message);
            }
        }
        [TestMethod]
        public void GivenLastName_WhenValidate_ShouldReturnTrue()
        {
            try
            {
                Assert.AreEqual("Last Name is Valid", patternsMatching.ValidateLastNameByUsingLambda("Mishra"));
            }
            catch (RegularExpressionCustomException rec)
            {
                Assert.AreEqual("Invalid Last Name", rec.Message);
            }
        }
        [TestMethod]
        public void GivenEmail_WhenValidate_ShouldReturnTrue()
        {
            try
            {
                Assert.AreEqual("Email ID is Valid", patternsMatching.ValidateEmailByUsingLambda("abh224272@gmail.com"));
            }
            catch (RegularExpressionCustomException rec)
            {
                Assert.AreEqual("Invalid Email ID", rec.Message);
            }
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnTrue()
        {
            try
            {
                Assert.AreEqual("Password is Valid", patternsMatching.ValidatePasswordByUsingLambda("abhishekMishrA@124"));
            }
            catch (RegularExpressionCustomException rec) 
            {
                Assert.AreEqual("Invalid Password", rec.Message);
            }
        }
        [TestMethod]
        public void GivenPhoneNumber_WhenValidate_ShouldReturnTrue()
        {
            try
            {
                Assert.AreEqual("Phone Number is Valid", patternsMatching.ValidatePhoneNumberByUsingLambda("+917559171697"));
            }
            catch (RegularExpressionCustomException rec) 
            { 
                Assert.AreEqual("Invalid Phone Number", rec.Message); 
            }
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
            Assert.AreEqual(true, patternsMatching.ValidateEmailByUsingLambda(email));
        }
    }
}
