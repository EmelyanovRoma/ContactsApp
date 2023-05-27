using NUnit.Framework;
using ContactsApp.Model;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ProjectTests
    {
        [Test(Description = "Positive contacts getter test")]
        public void Contacts_GetContacts_ReturnsSameValue()
        {
            // Arrange
            var project = new Project();
            var contact = new Contact();
            var expectedContact = contact;

            // Act
            project.Contacts.Add(contact);
            var actualContact = project.Contacts[0];

            // Assert
            Assert.AreEqual(expectedContact, actualContact);
        }

        [Test(Description = "Positive sort of contacts test")]
        public void SortContactsByFullName_SortContacts_SortedListContacts()
        {
            // Arrange
            var project = new Project();
            var sortedContacts = new List<Contact>();

            var firstContact = new Contact();
            var secondContact = new Contact();
            var thirdContact = new Contact();

            var firstFullName = "Богданов Максим";
            var secondFullName = "Иванов Иван";
            var thirdFullName = "Петров Александр";

            firstContact.FullName = firstFullName;
            secondContact.FullName = secondFullName;
            thirdContact.FullName = thirdFullName;

            sortedContacts.Add(firstContact);
            sortedContacts.Add(secondContact);
            sortedContacts.Add(thirdContact);

            project.Contacts.Add(thirdContact);
            project.Contacts.Add(firstContact);
            project.Contacts.Add(secondContact);

            var expectedSortedContacts = sortedContacts;

            // Act           
            project.SortContactsByFullName();
            var actualSortedContacts = project.Contacts;

            // Assert
            AssertCompareContactsList(expectedSortedContacts, actualSortedContacts);
        }

        [Test(Description = "Positive test of finding birthday contacts")]
        public void FindBirthdayContacts_FindContacts_ReturnsBirthdayContacts()
        {
            // Arrange
            var project = new Project();
            var birthdayContactsList = new List<Contact>();

            var birthdayContact = new Contact();
            var somethingContact = new Contact();

            var todayDateOfBirth = DateTime.Today;
            var somethingDateOfBirth = todayDateOfBirth.AddDays(-1);

            birthdayContact.DateOfBirth = todayDateOfBirth;
            somethingContact.DateOfBirth = somethingDateOfBirth;

            birthdayContactsList.Add(birthdayContact);
            project.Contacts.Add(birthdayContact);
            project.Contacts.Add(somethingContact);

            var expectedContactsList = birthdayContactsList;

            // Act
            var actualContactsList = project.FindBirthdayContacts();

            // Assert
            AssertCompareContactsList(expectedContactsList, actualContactsList);
        }

        [Test(Description = "Positive test of finding contacts by substring")]
        public void FindContactsBySubstring_FindContacts_ReturnsFoundedContacts()
        {
            // Arrange
            var project = new Project();
            var firstContact = new Contact();
            var secondContact = new Contact();
            var findedContacts = new List<Contact>(); 

            var fullnameFirstContact = "Иванов Иван";
            var fullnameSecondContact = "Борисов Борис";
            var substring = "Иван";

            firstContact.FullName = fullnameFirstContact;
            secondContact.FullName = fullnameSecondContact;

            findedContacts.Add(firstContact);
            project.Contacts.Add(firstContact);
            project.Contacts.Add(secondContact);

            var expectedContactsList = findedContacts;

            // Act
            var actualContactsList = project.FindContactsBySubstring(substring);

            // Assert
            AssertCompareContactsList(expectedContactsList, actualContactsList);
        }

        [Test(Description = "Positive test of finding contacts by empty substring")]
        public void FindContactsBySubstring_FindContactsByEmptySubstring_ReturnsAllContacts()
        {
            // Arrange
            var project = new Project();
            var firstContact = new Contact();
            var secondContact = new Contact();
            var findedContacts = new List<Contact>();

            var fullnameFirstContact = "Иванов Иван";
            var fullnameSecondContact = "Борисов Борис";
            var substring = "";

            firstContact.FullName = fullnameFirstContact;
            secondContact.FullName = fullnameSecondContact;

            findedContacts.Add(firstContact);
            findedContacts.Add(secondContact);
            project.Contacts.Add(firstContact);
            project.Contacts.Add(secondContact);

            var expectedContactsList = findedContacts;

            // Act
            var actualContactsList = project.FindContactsBySubstring(substring);

            // Assert
            AssertCompareContactsList(expectedContactsList, actualContactsList);
        }

        public void AssertCompareContactsList(
            List<Contact> expectedContactsList, 
            List<Contact> actualContactsList)
        {
            Assert.AreEqual(expectedContactsList.Count, actualContactsList.Count);

            for (int i = 0; i < actualContactsList.Count; i++)
            {
                Assert.Multiple(() =>
                {
                    Assert.AreEqual(
                        expectedContactsList[i].FullName, 
                        actualContactsList[i].FullName);
                    Assert.AreEqual(
                        expectedContactsList[i].Email, 
                        actualContactsList[i].Email);
                    Assert.AreEqual(
                        expectedContactsList[i].PhoneNumber, 
                        actualContactsList[i].PhoneNumber);
                    Assert.AreEqual(
                        expectedContactsList[i].DateOfBirth, 
                        actualContactsList[i].DateOfBirth);
                    Assert.AreEqual(
                        expectedContactsList[i].IdVk, 
                        actualContactsList[i].IdVk);
                }
            );
            }
        }
    }
}
