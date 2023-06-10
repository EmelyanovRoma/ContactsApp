using System.Globalization;
using System.Text.RegularExpressions;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает контакт.
    /// </summary>
    public class Contact : ICloneable
    {
        /// <summary>
        /// Паттерн для проверки имени.
        /// </summary>
        private const string FullNameRegex = @"^[A-Яа-я]+\s?[A-Яа-я]*$";

        /// <summary>
        /// Паттерн для проверки номера телефона.
        /// +79500000001,
        /// 79500000001,
        /// 89500000001,
        /// 8(950)000-00-01,
        /// 380(67)777-7-777,
        /// +13435465566.
        /// </summary>
        private const string PhoneNumberRegex = @"^([+]?[0-9\s-\(\)]{3,25})*$";

        /// <summary>
        /// Паттерн для проверки электронного адреса.
        /// example@no.mail,
        /// example_ex@no.mail,
        /// example-ex@no.mail.
        /// </summary>
        private const string EmailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        /// <summary>
        /// Полное имя контакта.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Электронная почта контакта.
        /// </summary>
        private string _email;

        /// <summary>
        /// Телефонный номер контакта.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Дата рождения контакта.
        /// </summary>
        private DateTime _dateOfBirth;

        /// <summary>
        /// Идентификационный номер VK контакта.
        /// </summary>
        private string _idVk;

        /// <summary>
        /// Возвращает или задает полное имя контакта.
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                if (value.Length > 100 || !Regex.IsMatch(value, FullNameRegex) || value == "")
                {
                    throw new ArgumentException(
                        $"Full name length must not exceed 100 characters.");
                }
                _fullName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);             
            }
        }

        /// <summary>
        /// Возвращает или задает электронную почту контакта.
        /// </summary>
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Length > 100 || !Regex.IsMatch(value, EmailRegex) || value == "")
                {
                    throw new ArgumentException(
                        $"Invalid email address. Email example: " +
                        $"example@no.mail");
                }
                _email = value;
            }
        }

        /// <summary>
        /// Возвращает или задает телефонный номер контакта.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                if (!Regex.IsMatch(value, PhoneNumberRegex) || value == "")
                {
                    throw new ArgumentException(
                       $"The phone number must contain the following" +
                       $" characters: '0-9', '+', '(', ')', '-'.");
                }
                _phoneNumber = value;
            }
        }

        /// <summary>
        /// Возвращает или задает дату рождения контакта.
        /// </summary>
        public DateTime DateOfBirth
        {
            get 
            {
                return _dateOfBirth;
            }
            set
            {
                if (value.Year < 1900 || value > DateTime.Now)
                {
                    throw new ArgumentException($"Invalid date format.");
                }
                _dateOfBirth = value;
            }
        }

        /// <summary>
        /// Возвращает или задает идентификационный номер VK контакта.
        /// </summary>
        public string IdVk
        {
            get
            {
                return _idVk;
            }
            set
            {
                if (value.Length > 50 || value == "")
                {
                    throw new ArgumentException(
                        $"ID VK length must not exceed 50 characters.");
                }
                _idVk = value;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="Contact"/>.
        /// </summary>
        /// <param name="fullName">Полное имя контакта.</param>
        /// <param name="email">Электронная поча контакта.</param>
        /// <param name="phoneNumber">Телефонный номер контакта.</param>
        /// <param name="dateOfBirth">Дата рождения контакта.</param>
        /// <param name="idVk">Идентификационный номер VK контакта.</param>
        public Contact(string fullName, string email, string phoneNumber, DateTime dateOfBirth, string idVk)
        {
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
            IdVk = idVk;
        }

        /// <summary>
        /// Создает экземпляр <see cref="Contact"/>.
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Клонирует существующий экземпляр <see cref="Contact"/>.
        /// </summary>
        /// <returns>Возвращает новый экземпляр <see cref="Contact"/>.</returns>
        public object Clone()
        {
            return new Contact(FullName, Email, PhoneNumber, DateOfBirth, IdVk);
        }
    }
}
