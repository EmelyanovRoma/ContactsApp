using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp.Model;

namespace ContactsApp.View
{
    public partial class ContactForm : Form
    {
        private Contact _contact = ContactFactory.GenerateRandon();
        private const string _fullNameRegex = @"^[a-zA-Zа-яА-Я\s]+$";
        private const string _emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        private const string _phoneNumberRegex = @"^([+]?[0-9\s-\(\)]{3,25})*$";

        public ContactForm()
        {
            InitializeComponent();
            UpdateForm();
        }

        private void UpdateForm()
        {
            FullNameTextBox.Text = _contact.FullName;
            EmailTextBox.Text = _contact.Email;
            PhoneNumberTextBox.Text = _contact.PhoneNumber;
            DateOfBirthDateTimePicker.Text = _contact.DateOfBirth.ToString();
            VKTextBox.Text = _contact.IDVK;
        }

        private void AddPhotoButton_Click(object sender, EventArgs e)
        {

        }

        private void AddPhotoButton_MouseEnter(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32;
        }

        private void AddPhotoButton_MouseLeave(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text.Length > 100 ||
                !Regex.IsMatch(FullNameTextBox.Text, _fullNameRegex))
            {
                throw new ArgumentException(
                    $"The full name must contain only Russian or English " +
                    $"characters and the length must not exceed 100 characters.");
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(EmailTextBox.Text, _emailRegex))
            {
                throw new ArgumentException(
                    $"Invalid email address. Email example: " +
                    $"characters: '0-9', '+', '(', ')', '-'.");
            }
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(PhoneNumberTextBox.Text, _phoneNumberRegex))
            {
                throw new ArgumentException(
                    $"The phone number must contain the following " +
                    $"characters: '0-9', '+', '(', ')', '-'.");
            }
        }
    }
}
