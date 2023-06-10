using ContactsApp.Model;

namespace ContactsApp.View
{
    /// <summary>
    /// Описывает форму для добавления и редактирования контакта.
    /// </summary>
    public partial class ContactForm : Form
    {
        /// <summary>
        /// Цвет для текстовых полей, если нет ошибок.
        /// </summary>
        private readonly Color DefaultBackColor = Color.White;

        /// <summary>
        /// Цвет для текстовых полей, если есть ошибки.
        /// </summary>
        private readonly Color ErrorBackColor = Color.LightPink;

        /// <summary>
        /// Словарь с ошибками в текстовых полях формы.
        /// </summary>
        private Dictionary<string, string> _errorsDictionary = new Dictionary<string, string>
        {
            {nameof(Model.Contact.FullName), "" },
            {nameof(Model.Contact.Email), "" },
            {nameof(Model.Contact.PhoneNumber), "" },
            {nameof(Model.Contact.DateOfBirth), "" },
            {nameof(Model.Contact.IdVk), "" }
        };

        /// <summary>
        /// Объект класса <see cref="Contact"/>.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Возвращает или задает контакт.
        /// </summary>
        public Contact Contact
        {
            get
            {
                return _contact;
            }
            set
            {
                _contact = value;
                if (_contact.FullName != null)
                {
                    UpdateForm();
                }
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="ContactForm"/>.
        /// </summary>
        public ContactForm()
        {
            InitializeComponent();
            DateOfBirthDateTimePicker.MaxDate = DateTime.Now;
        }

        /// <summary>
        /// Метод Обновление текстовых полей на форме.
        /// </summary>
        private void UpdateForm()
        {
            FullNameTextBox.Text = Contact.FullName;
            EmailTextBox.Text = Contact.Email;
            PhoneNumberTextBox.Text = Contact.PhoneNumber;
            DateOfBirthDateTimePicker.Value = Contact.DateOfBirth;
            VKTextBox.Text = Contact.IdVk;
        }

        /// <summary>
        /// Метод передачи информации с текстовых полей формы 
        /// в свойства объекта класса Contact.
        /// </summary>
        private void UpdateContact()
        {
            Contact.FullName = FullNameTextBox.Text;
            Contact.Email = EmailTextBox.Text;
            Contact.PhoneNumber = PhoneNumberTextBox.Text;
            Contact.DateOfBirth = DateOfBirthDateTimePicker.Value;
            Contact.IdVk = VKTextBox.Text;
        }

        /// <summary>
        /// Метод проверки текстовых полей на ошибки заполнения.
        /// </summary>
        /// <returns>false - есть ошибки; true- ошибок нет.</returns>
        private bool CheckFormsOnErrors()
        {
            string allErrors = "";

            foreach (var error in _errorsDictionary)
            {
                if (error.Value != "")
                {
                    allErrors += error.Value + "\n";
                }
            }

            if (allErrors != "")
            {
                MessageBox.Show(allErrors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Обработчик события изменения текста <see cref="FullNameTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.FullName = FullNameTextBox.Text;
                FullNameTextBox.BackColor = DefaultBackColor;
                _errorsDictionary[nameof(Model.Contact.FullName)] = "";
            }
            catch (ArgumentException exception)
            {
                FullNameTextBox.BackColor = ErrorBackColor;
                _errorsDictionary[nameof(Model.Contact.FullName)] = exception.Message;
            }
        }

        /// <summary>
        /// Обработчик события изменения текста <see cref="EmailTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.Email = EmailTextBox.Text;
                EmailTextBox.BackColor = DefaultBackColor;
                _errorsDictionary[nameof(Model.Contact.Email)] = "";
            }
            catch (ArgumentException exception)
            {
                EmailTextBox.BackColor = ErrorBackColor;
                _errorsDictionary[nameof(Model.Contact.Email)] = exception.Message;
            }
        }

        /// <summary>
        /// Обработчик события изменения текста <see cref="PhoneNumberTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.PhoneNumber = PhoneNumberTextBox.Text;
                PhoneNumberTextBox.BackColor = DefaultBackColor;
                _errorsDictionary[nameof(Model.Contact.PhoneNumber)] = "";
            }
            catch (ArgumentException exception)
            {
                PhoneNumberTextBox.BackColor = ErrorBackColor;
                _errorsDictionary[nameof(Model.Contact.PhoneNumber)] = exception.Message;
            }
        }

        /// <summary>
        /// Обработчик события изменения значения <see cref="DateOfBirthDateTimePicker"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateOfBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.DateOfBirth = DateOfBirthDateTimePicker.Value;
                _errorsDictionary[nameof(Model.Contact.DateOfBirth)] = "";
            }
            catch (ArgumentException exception)
            {
                _errorsDictionary[nameof(Model.Contact.DateOfBirth)] = exception.Message;
            }
        }

        /// <summary>
        /// Обработчик события изменения текста <see cref="VKTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VKTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Contact.IdVk = VKTextBox.Text;
                VKTextBox.BackColor = DefaultBackColor;
                _errorsDictionary[nameof(Model.Contact.IdVk)] = "";
            }
            catch (ArgumentException exception)
            {
                VKTextBox.BackColor = ErrorBackColor;
                _errorsDictionary[nameof(Model.Contact.IdVk)] = exception.Message;
            }
        }

        /// <summary>
        /// Обработчик события нажатия на кнопку <see cref="OKButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (CheckFormsOnErrors())
            {
                DialogResult = DialogResult.OK;
                UpdateContact();
                this.Close();
            }
        }

        /// <summary>
        /// Обработчик события наведения указателя мыши на <see cref="AddPhotoButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPhotoButton_MouseEnter(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32;
        }

        /// <summary>
        /// Обработчик события пропадания указателя мыши с <see cref="AddPhotoButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPhotoButton_MouseLeave(object sender, EventArgs e)
        {
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
        }
    }
}
