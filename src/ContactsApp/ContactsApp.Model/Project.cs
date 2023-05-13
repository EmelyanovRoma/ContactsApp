namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает проект.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Список контактов.
        /// </summary>
        public List<Contact> Contacts { get; set; } 

        /// <summary>
        /// Создает экземпляр <see cref="Project"/>.
        /// </summary>
        /// <param name="contacts">Список контактов.</param>
        public Project(List<Contact> contacts)
        {
            Contacts = contacts;
        }

        /// <summary>
        /// Сортировка списка контактов по имени в алфавитном порядке.
        /// </summary>
        public void SortByName()
        {
            Contacts = Contacts.OrderBy(contact => contact.FullName).ToList();
        }

        /// <summary>
        /// Поиск именинников в списке контактов.
        /// </summary>
        /// <returns>Список именинников</returns>
        public List<Contact> SearchBirthdayContacts()
        {
            List<Contact> contacts = new List<Contact>();
            for (int i = 0; i < Contacts.Count; i++)
            {
                if (Contacts[i].DateOfBirth.Month == DateTime.Today.Month && 
                    Contacts[i].DateOfBirth.Day == DateTime.Today.Day)
                {
                    contacts.Add(Contacts[i]);
                }
            }
            return contacts;
        }

        /// <summary>
        /// Поиск контактов по подстроке в списке контактов.
        /// </summary>
        /// <param name="substring">Подстрока для поиска.</param>
        /// <returns>Список найденных контактов по подстроке.</returns>
        public List<Contact> SearchContactsBySubstring(string substring)
        {
            if (substring == "")
            {
                return Contacts;
            }

            List<Contact> contacts = new List<Contact>();
            for (int i = 0; i < Contacts.Count; i++)
            {
                if (Contacts[i].FullName.ToLower().Contains(substring.ToLower()))
                {
                    contacts.Add(Contacts[i]);
                }
            }
            return contacts;
        }
    }
}