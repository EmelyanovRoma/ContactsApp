using NUnit.Framework;
using ContactsApp.Model;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ContactTests
    {
        [Test(Description = "Negative full name setter test")]
        [TestCase("", "An exception should be thrown if full name length is 0 characters", 
            TestName = "Assigning an empty string to a full name")]
        [TestCase("This is a very very very very very very very very very very very very " +
            "very very very very long full name", 
            "An exception should be thrown if full name length is more than 100 characters", 
            TestName = "Assigning a string greater than 100 characters to a full name")]
        [TestCase("Ив4нов И1ан",
            "An exception should be thrown if full name contains numbers or other characters " +
            "other than these: А-Я, а-я",
            TestName = "Assigning a string contains other symbols than these: А-Я, а-я")]
        public void Fullname_SetUncorrectValue_ThrowsArgumentException(
            string wrongFullname, string message)
        {
            // Arrange
            var contact = new Contact();

            // Assert
            Assert.Throws<ArgumentException>(() => 
            { 
                // Act
                contact.FullName = wrongFullname; 
            },
            message);
        }

        [Test(Description = "Positive full name setter test")]
        public void Fullname_SetCorrectValue_ReturnsSameValue()
        {
            // Arrange
            var contact = new Contact();
            var correctFullname = "Иванов Иван";
            var expected = correctFullname;

            // Act
            contact.FullName = correctFullname;
            var actual = contact.FullName;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Negative email setter test")]
        public void Email_SetUncorrectValue_ThrowsArgumentException()
        {
            // Arrange
            var contact = new Contact();
            var wrongEmail = "This is a very very very very very very very " +
                "very very very very very very very very very very long email";
            var message = "An exception should be thrown if email length more " +
                "than 100 characters";

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                contact.Email = wrongEmail;
            },
            message);
        }

        [Test(Description = "Positive email setter test")]
        public void Email_SetCorrectValue_ReturnsSameValue()
        {
            // Arrange
            var contact = new Contact();
            var correctEmail = "1@no.mail";
            var expected = correctEmail;  

            // Act
            contact.Email = correctEmail;
            var actual = contact.Email;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Negative phone number setter test")]
        public void PhoneNumber_SetLettersInPhoneNumber_ThrowsArgumentException()
        {
            // Arrange
            var contact = new Contact();
            var wrongPhoneNumber = "8 954 fgg 66 00";
            var message = "An exception should be thrown if the phone number " +
                "contains characters other than these: '0-9', '+', '(', ')', '-'.";

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                contact.PhoneNumber = wrongPhoneNumber;
            },
            message);
        }

        [Test(Description = "Positive phone number setter test")]
        public void PhoneNumber_SetCorrectValue_ReturnsSameValue()
        {
            // Arrange
            var contact = new Contact();
            var correctPhoneNumber = "+79500000001";
            var expected = correctPhoneNumber;

            // Act
            contact.PhoneNumber = correctPhoneNumber;
            var actual = contact.PhoneNumber;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Negative date of birth setter test")]
        public void DateOfBirth_SetDateTimeGreaterThanNow_ThrowsArgumentException()
        {
            // Arrange
            var contact = new Contact();
            var wrongDateOfBirth = DateTime.Now.AddDays(1);
            var message = "An exception should be thrown if the date " +
                "of birth is greater than now date";

            // Assert
            Assert.Throws<ArgumentException>(() => 
            {
                // Act
                contact.DateOfBirth = wrongDateOfBirth;
            },
            message);
        }

        [Test(Description = "Negative date of birth setter test")]
        public void DateOfBirth_SetDateTimeLower1900Year_ThrowsArgumentException()
        {
            // Arrange
            var contact = new Contact();
            var wrongDateOfBirth = new DateTime(1899, 1, 1);
            var message = "An exception should be thrown if the date" +
                " of birth is lower than 1900 year";

            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Act
                contact.DateOfBirth = wrongDateOfBirth;
            },
            message);
        }

        [Test(Description = "Positive date of birth setter test")]
        public void DateOfBirth_SetCorrectValue_ReturnsSameValue()
        {
            // Arrange
            var contact = new Contact();
            var correctDateOfBirth = new DateTime(2002, 9, 22);
            var expected = correctDateOfBirth;

            // Act
            contact.DateOfBirth = correctDateOfBirth;
            var actual = contact.DateOfBirth; 

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Negative vk id setter test")]
        public void IDVK_SetStringGreaterThan50Symbols_ThrowsArgumentException()
        {
            // Arrange
            var contact = new Contact();
            var wrongIDVK = "This is a very very very very very " +
                "very very long vk id";
            var message = "An exception should be thrown if the " +
                "vk id length more than 50 characters";

            // Assert
            Assert.Throws<ArgumentException>( () => 
            {
                // Act
                contact.IdVk = wrongIDVK;
            },
            message);
        }

        [Test(Description = "Positive vk id setter test")]
        public void IDVK_SetCorrectValue_ReturnsSameValue()
        {
            // Arrange
            var contact = new Contact();
            var correctIDVK = "12345678";
            var expected = correctIDVK;

            // Act
            contact.IdVk = correctIDVK;
            var actual = contact.IdVk;  

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Negative contact contructor test with uncorrect full name")]
        public void Constructor_CreationWithUncorrectFullname_ThrowsArgumentException()
        {
            // Arrange
            var wrongFullname = "This is a very very very very very very very very " +
                "very very very very very very very very long full name";
            var message = "An exception should be thrown if the full name of " +
                "constructor is uncorrect";

            // Assert
            Assert.Throws<AssertionException>( () => 
            {
                // Act
                new Contact(wrongFullname, "1@no.mail", "+79500000001", 
                    new DateTime(2002, 0, 22), "12345678");
            },
            message);
        }

        [Test(Description = "Negative contact contructor test with uncorrect email")]
        public void Constructor_CreationWithUncorrectEmail_ThrowsArgumentException()
        {
            // Arrange
            var wrongEmail = "This is a very very very very very very very very " +
                "very very very very very very very very very long email";
            var message = "An exception should be thrown if the email of " +
                "constructor is uncorrect";

            // Assert
            Assert.Throws<AssertionException>(() =>
            {
                // Act
                new Contact("Иванов Иван", wrongEmail, "+79500000001",
                    new DateTime(2002, 0, 22), "12345678");
            },
            message);
        }

        [Test(Description = "Negative contact contructor test with uncorrect phone number")]
        public void Constructor_CreationWithUncorrectPhoneNumber_ThrowsArgumentException()
        {
            // Arrange
            var wrongPhoneNumber = "8 fgf 721 00 90";
            var message = "An exception should be thrown if the phone number of " +
                "constructor is uncorrect";

            // Assert
            Assert.Throws<AssertionException>(() =>
            {
                // Act
                new Contact("Иванов Иван", "1@no.mail", wrongPhoneNumber,
                    new DateTime(2002, 0, 22), "12345678");
            },
            message);
        }

        [Test(Description = "Negative contact contructor test with uncorrect date time")]
        public void Constructor_CreationWithUncorrectDateTime_ThrowsArgumentException()
        {
            // Arrange
            var wrongDateTime = DateTime.Now.AddDays(1);
            var message = "An exception should be thrown if the date time of " +
                "constructor is uncorrect";

            // Assert
            Assert.Throws<AssertionException>(() =>
            {
                // Act
                new Contact("Иванов Иван", "1@no.mail", "+79500000001",
                    wrongDateTime, "12345678");
            },
            message);
        }

        [Test(Description = "Negative contact contructor test with uncorrect vk id")]
        public void Constructor_CreationWithUncorrectVkId_ThrowsArgumentException()
        {
            // Arrange
            var wrongIdVk = "This is a very very very very very " +
                "very very long vk id";
            var message = "An exception should be thrown if the date time of " +
                "constructor is uncorrect";

            // Assert
            Assert.Throws<AssertionException>(() =>
            {
                // Act
                new Contact("Иванов Иван", "1@no.mail", "+79500000001",
                    new DateTime(2002, 0, 22), wrongIdVk);
            },
            message);
        }

        [Test(Description = "Positive contact contructor test")]
        public void Constructor_CreationWithCorrectParametrs_ReturnsSameValue()
        {
            // Arrange
            Contact contact;

            var fullName = "Иванов Иван";
            var email = "1@no.mail";
            var phoneNumber = "+79500000001";
            var dateOfBirth = new DateTime(2002, 9, 22);
            var idVk = "12345678";

            var expectedFullName = fullName;
            var expectedEmail = email;
            var expectedPhoneNumber = phoneNumber;
            var expectedDateOfBirth = dateOfBirth;
            var expectedIdVk = idVk;

            // Act
            contact = new Contact(fullName, email, phoneNumber, dateOfBirth, idVk);

            var actualFullName = contact.FullName;
            var actualEmail = contact.Email;
            var actualPhoneNumber = contact.PhoneNumber;
            var actualDateOfBirth = contact.DateOfBirth;
            var actualIdVk = contact.IdVk;

            // Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedFullName, actualFullName);
                Assert.AreEqual(expectedEmail, actualEmail);
                Assert.AreEqual(expectedPhoneNumber, actualPhoneNumber);
                Assert.AreEqual(expectedDateOfBirth, actualDateOfBirth);
                Assert.AreEqual(expectedIdVk, actualIdVk);
            }
            );
        }

        [Test(Description = "Positive clone contact test")]
        public void Clone_CloneObject_ReturnsSameValue()
        {
            // Arrange
            var fullName = "Иванов Иван";
            var email = "1@no.mail";
            var phoneNumber = "+79500000001";
            var dateOfBirth = new DateTime(2002, 9, 22);
            var idVk = "12345678";

            var expectedContact = 
                new Contact(fullName, email, phoneNumber, dateOfBirth, idVk);

            // Act
            var actualContact = (Contact)expectedContact.Clone();

            // Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual(expectedContact.FullName, actualContact.FullName);
                Assert.AreEqual(expectedContact.Email, actualContact.Email);
                Assert.AreEqual(expectedContact.PhoneNumber, actualContact.PhoneNumber);
                Assert.AreEqual(expectedContact.DateOfBirth, actualContact.DateOfBirth);
                Assert.AreEqual(expectedContact.IdVk, actualContact.IdVk);
            }
            );
        }
    }
}