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

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.FullName = FullNameTextBox.Text;
                FullNameTextBox.BackColor = Color.White;
            }
            catch
            {
                FullNameTextBox.BackColor = Color.LightPink;
            }
        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Email = EmailTextBox.Text;
                EmailTextBox.BackColor = Color.White;
            }
            catch
            {
                EmailTextBox.BackColor = Color.LightPink;
            }
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.PhoneNumber = PhoneNumberTextBox.Text;
                PhoneNumberTextBox.BackColor = Color.White;
            }
            catch
            {
                PhoneNumberTextBox.BackColor = Color.LightPink;
            }
        }

        private void DateOfBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.DateOfBirth = DateOfBirthDateTimePicker.Value;
                DateOfBirthDateTimePicker.BackColor = Color.White;
            }
            catch
            {
                DateOfBirthDateTimePicker.BackColor = Color.LightPink;
            }
        }

        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.IDVK = VKTextBox.Text;
                VKTextBox.BackColor = Color.White;
            }
            catch
            {
                VKTextBox.BackColor = Color.LightPink;
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
    }
}
