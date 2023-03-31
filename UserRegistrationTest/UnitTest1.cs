using RegexProblem.Email;
using RegexProblem.UserRegistrationProblem;

namespace UserRegistrationTest
{
    public class Tests
    {
        UserRegistrationValidateTest userRegistrationValidateTest = new UserRegistrationValidateTest();

        [Test]
        public void ValidateFirstName()
        {
            string excepted = "Prabhu";
            string firstname = "Raghu";
            string actual = userRegistrationValidateTest.ValidateFirstName(firstname);
            Assert.AreEqual(actual, excepted);
        }
        [Test]
        public void ValidateLastName()
        {
            string excepted = "Goyal";
            string lastname = "Royal";
            string actual = userRegistrationValidateTest.ValidateLastName(lastname);
            Assert.AreEqual(actual, excepted);
        }
        [Test]
        public void ValidatePhoneNumber()
        {
            string excepted = "91 9149218712";
            string phonenumber = "91 8794561230";
            string actual = userRegistrationValidateTest.ValidatePhoneNumber(phonenumber);
            Assert.AreEqual(actual, excepted);
        }
        [Test]
        public void ValidateEmail()
        {
            string excepted = "abc.xyz@bl.co.in";
            string email = "abc.der@bl.co.com";
            string actual = userRegistrationValidateTest.ValidateEmail(email);
            Assert.AreEqual(actual, excepted);
        }
        [Test]
        public void ValidatePassword()
        {
            string excepted = "Prabhu@821";
            string password = "Pra821@wcc";
            string actual = userRegistrationValidateTest.ValidatePassword1(password);
            Assert.AreEqual(actual, excepted);
        }

        [Test]
        public void ValidateMultipleEmail()
        {
            //Arrange
            string excepted = "prabhugoyal821@gmail.com";
            string email = "abc.ram@bl.co.im";
            //Act
            ValidateMultipleEmailAddress validateMultipleEmailAddress = new ValidateMultipleEmailAddress();
            string actual = validateMultipleEmailAddress.MultipleEmailAddress(email);
            //Assert
            Assert.AreEqual(actual, excepted);
        }
    }
}