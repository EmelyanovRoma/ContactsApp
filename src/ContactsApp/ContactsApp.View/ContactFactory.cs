using ContactsApp.Model;

namespace ContactsApp.View
{
    /// <summary>
    /// Описывает создание контакта.
    /// </summary>
    public static class ContactFactory
    {
        /// <summary>
        /// Генерирует случайный новый контакт.
        /// </summary>
        /// <returns>Новый контакт.</returns>
        public static Contact GenerateRandom()
        {
            string[] fullNames =
            {
                "романович Генадий",
                "иванов Иван",
                "петров Алексей",
                "сидоров Александр",
                "миронов Игорь"
            };
            string[] emails =
            {
                "1@no.mail",
                "2@no.mail",
                "3@no.mail",
                "4@no.mail",
                "5@no.mail"
            };
            string[] phoneNumbers =
            {
                "+79500000001",
                "+79500000002",
                "+79500000003",
                "+79500000004",
                "+79500000005",
            };
            string[] idVk =
            {
                "123456789",
                "987654321",
                "100000000",
                "200000000",
                "300000000"
            };

            Random random = new Random();
            int[] index = new int[4];

            for (int i = 0; i < index.Length; i++)
            {
                index[i] = random.Next(0, 5);
            }

            return new Contact(fullNames[index[0]], emails[index[1]], 
                phoneNumbers[index[2]], DateTime.Today, idVk[index[3]]);
        }
    }
}
