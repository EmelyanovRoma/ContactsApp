using ContactsApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static Contact GenerateRandon()
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
            string[] idVK =
            {
                "123456789",
                "987654321",
                "100000000",
                "200000000",
                "300000000"
            };

            Random random = new Random();
            int value = random.Next(0, 4);
            return new Contact(fullNames[value], emails[value], 
                phoneNumbers[value], DateTime.Today, idVK[value]);
        }
    }
}
