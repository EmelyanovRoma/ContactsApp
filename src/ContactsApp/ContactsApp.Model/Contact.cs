using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        /// Полное имя контакта
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
        private string _idVK;

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
                if (value.Length > 100)
                {
                    throw new ArgumentException(
                        $"Full name length must not exceed 100 characters.");
                }
                else
                {
                    _fullName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(value);
                }               
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
                if (value.Length > 100)
                {
                    throw new ArgumentException(
                        $"E-mail length must not exceed 100 characters.");
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
                string pattern = @"^([+]?[0-9\s-\(\)]{3,25})*$";
                if (Regex.IsMatch(value, pattern))
                {
                    _phoneNumber = value;
                }
                else
                {
                    throw new ArgumentException(
                        $"The phone number must contain the following" +
                        $" characters: '0-9', '+', '(', ')', '-'.");
                }
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
                if (value > DateTime.Today || value.Year < 1900)
                {
                    throw new ArgumentException($"Invalid date format.");
                }
                _dateOfBirth = value;
            }
        }

        /// <summary>
        /// Возвращает или задает идентификационный номер VK контакта.
        /// </summary>
        public string IDVK
        {
            get
            {
                return _idVK;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException(
                        $"ID VK length must not exceed 100 characters.");
                }
                _idVK = value;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="Contact">.
        /// </summary>
        /// <param name="fullName">Полное имя контакта.</param>
        /// <param name="email">Электронная поча контакта.</param>
        /// <param name="phoneNumber">Телефонный номер контакта.</param>
        /// <param name="dateOfBirth">Дата рождения контакта.</param>
        /// <param name="idVK">Идентификационный номер VK контакта.</param>
        public Contact(string fullName, string email, string phoneNumber, DateTime dateOfBirth, string idVK)
        {
            FullName = fullName;
            Email = email;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
            IDVK = idVK;
        }

        /// <summary>
        /// Клонирует существующий экземпляр <see cref="Contact">.
        /// </summary>
        /// <returns>Возвращает новый экземпляр <see cref="Contact">.</returns>
        public object Clone()
        {
            return new Contact(FullName, Email, PhoneNumber, DateOfBirth, IDVK);
        }
    }
}
