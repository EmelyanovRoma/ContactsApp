using ContactsApp.Model;
using System.Text.RegularExpressions;

namespace ContactsApp.View
{
    /// <summary>
    /// Описывает форму для добавления и редактирования контакта.
    /// </summary>
    public partial class ContactForm : Form
    {
        /// <summary>
        /// Объект класса <see cref="Contact"/>.
        /// </summary>
        private Contact _contact = ContactFactory.GenerateRandom();

        /// <summary>
        /// Строковое поле с сообщением ошибки в полном имени.
        /// </summary>
        private string _fullNameError;

        /// <summary>
        /// Строковое поле с сообщением ошибки в электронной почте.
        /// </summary>
        private string _emailError;

        /// <summary>
        /// Строковое поле с сообщением ошибки в телефонном номере.
        /// </summary>
        private string _phoneNumberError;

        /// <summary>
        /// Строковое поле с сообщением ошибки в дате рождения.
        /// </summary>
        private string _dateOfBirthError;

        /// <summary>
        /// Строковое поле с сообщением ошибки в идентифиционном номере VK.
        /// </summary>
        private string _idVKError;

        /// <summary>
        /// Конструктор формы для добавления и редактирования контакта.
        /// </summary>
        public ContactForm()
        {
            InitializeComponent();
            UpdateForm();
        }

        /// <summary>
        /// Обновление текстовых полей на форме.
        /// </summary>
        private void UpdateForm()
        {
            FullNameTextBox.Text = _contact.FullName;
            EmailTextBox.Text = _contact.Email;
            PhoneNumberTextBox.Text = _contact.PhoneNumber;
            DateOfBirthDateTimePicker.Text = _contact.DateOfBirth.ToString();
            VKTextBox.Text = _contact.IDVK;
        }

        private void UpdateContact()
        {
            _contact.FullName = FullNameTextBox.Text;
            _contact.Email = EmailTextBox.Text;
            _contact.PhoneNumber = PhoneNumberTextBox.Text;
            _contact.DateOfBirth = DateOfBirthDateTimePicker.Value;
            _contact.IDVK = VKTextBox.Text;
        }

        private bool CheckFormsOnErrors()
        {
            if (_fullNameError != "" || 
                _emailError != "" ||
                _phoneNumberError != "" ||
                _dateOfBirthError != "" ||
                _idVKError != "")
            {
                if (_fullNameError != "")
                {
                    MessageBox.Show(
                        _fullNameError, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (_emailError != "")
                {
                    MessageBox.Show(
                        _emailError, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (_phoneNumberError != "")
                {
                    MessageBox.Show(
                        _phoneNumberError, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (_dateOfBirthError != "")
                {
                    MessageBox.Show(
                        _dateOfBirthError, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (_idVKError != "")
                {
                    MessageBox.Show(
                        _idVKError, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false;
            }
            return true;
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.FullName = FullNameTextBox.Text;
                FullNameTextBox.BackColor = Color.White;
                _fullNameError = "";
            }
            catch (Exception exception)
            {
                FullNameTextBox.BackColor = Color.LightPink;
                _fullNameError = exception.Message;
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Email = EmailTextBox.Text;
                EmailTextBox.BackColor = Color.White;
                _emailError = "";
            }
            catch (Exception exception)
            {
                EmailTextBox.BackColor = Color.LightPink;
                _emailError = exception.Message;
            }
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.PhoneNumber = PhoneNumberTextBox.Text;
                PhoneNumberTextBox.BackColor = Color.White;
                _phoneNumberError = "";
            }
            catch (Exception exception)
            {
                PhoneNumberTextBox.BackColor = Color.LightPink;
                _phoneNumberError = exception.Message;
            }
        }

        private void DateOfBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.DateOfBirth = DateOfBirthDateTimePicker.Value;
                DateOfBirthDateTimePicker.BackColor = Color.White;
                _dateOfBirthError = "";
            }
            catch (Exception exception)
            {
                DateOfBirthDateTimePicker.BackColor = Color.LightPink;
                _dateOfBirthError = exception.Message;
            }
        }

        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.IDVK = VKTextBox.Text;
                VKTextBox.BackColor = Color.White;
                _idVKError = "";
            }
            catch (Exception exception)
            {
                VKTextBox.BackColor = Color.LightPink;
                _idVKError = exception.Message;
            }
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

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (CheckFormsOnErrors())
            {
                UpdateContact();
            }           
        }
    }
}
