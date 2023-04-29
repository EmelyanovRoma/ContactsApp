using ContactsApp.Model;

namespace ContactsApp.View
{
    /// <summary>
    /// Описывает главную форму окна приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Объект класса <see cref="Project"/>.
        /// </summary>
        private Project _project = new Project(new List<Contact>());

        /// <summary>
        /// Создает экземпляр <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод для обновления списка контактов на форме.
        /// </summary>
        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();
            for (int i = 0; i < _project.Contacts.Count; i++)
            {
                ContactsListBox.Items.Add(_project.Contacts[i].FullName);
            }
        }

        /// <summary>
        /// Метод добавления нового контакта.
        /// </summary>
        private void AddContact()
        {
            var contactForm = new ContactForm();

            if (contactForm.ShowDialog() == DialogResult.OK)
            {
                var newContact = contactForm.Contact;
                _project.Contacts.Add(newContact);
            }
        }

        /// <summary>
        /// Метод изменения информации о контакте.
        /// </summary>
        private void EditContact(int index)
        {
            var contactForm = new ContactForm();
            contactForm.Contact = (Contact)_project.Contacts[index].Clone();

            if (contactForm.ShowDialog() == DialogResult.OK)
            {
                var updatedContact = contactForm.Contact;

                _project.Contacts.RemoveAt(index);
                _project.Contacts.Insert(index, updatedContact);
            }
        }

        /// <summary>
        /// Метод удаления контакта
        /// </summary>
        /// <param name="index"></param>
        private void RemoveContact(int index)
        {
            if (index == -1)
                return;

            var message = MessageBox.Show(
                "Do you really want to remove " + ContactsListBox.Items[index],
                "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (message == DialogResult.OK)
            {
                _project.Contacts.RemoveAt(index);
            }
        }

        /// <summary>
        /// Метод обновления текстовых полей на форме.
        /// </summary>
        /// <param name="index"></param>
        private void UpdateSelectedContact(int index)
        {
            var contact = _project.Contacts[index];

            FullNameTextBox.Text = contact.FullName;
            EmailTextBox.Text = contact.Email;
            PhoneNumberTextBox.Text = contact.PhoneNumber;
            DateOfBirthTextBox.Text = contact.DateOfBirth.ToString();
            VKTextBox.Text = contact.IDVK;
        }

        /// <summary>
        /// Метод очитски текстовых полей на форме.
        /// </summary>
        private void ClearSelectedContact()
        {
            FullNameTextBox.Text = "";
            EmailTextBox.Text = "";
            PhoneNumberTextBox.Text = "";
            DateOfBirthTextBox.Text = "";
            VKTextBox.Text = "";
        }

        /// <summary>
        /// Обработчик события нажантия на кнопку <see cref="AddContactButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddContact();
            UpdateListBox();
        }

        /// <summary>
        /// Обработчик события нажантия на кнопку <see cref="EditContactButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            EditContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Обработчик события нажантия на кнопку <see cref="RemoveContactButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Обработчик события изменения индекса <see cref="ContactsListBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1)
                ClearSelectedContact();
            else
                UpdateSelectedContact(ContactsListBox.SelectedIndex);
        }

        /// <summary>
        /// Обработчик события закрывания формы <see cref="MainForm"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var message = MessageBox.Show(
                "Do you really want to close the program?", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (message == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Обработчик события нажатия кнопки на форме <see cref="MainForm"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var form = new AboutForm();
                form.ShowDialog();
            }
        }

        /// <summary>
        /// Обработчик события наведения указателя мыши на <see cref="AddContactButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_MouseEnter(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32;
            AddContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        /// <summary>
        /// Обработчик события пропадания указателя мыши с <see cref="AddContactButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_MouseLeave(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddContactButton.BackColor = Color.White;
        }

        /// <summary>
        /// Обработчик события наведения указателя мыши на <see cref="EditContactButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_MouseEnter(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32;
            EditContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        /// <summary>
        /// Обработчик события пропадания указателя мыши с <see cref="EditContactButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_MouseLeave(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditContactButton.BackColor = Color.White;
        }

        /// <summary>
        /// Обработчик события наведения указателя мыши на <see cref="RemoveContactButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32;
            RemoveContactButton.BackColor = ColorTranslator.FromHtml("#FAF5F5");
        }

        /// <summary>
        /// Обработчик события пропадания указателя мыши с <see cref="RemoveContactButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveContactButton.BackColor = Color.White;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки клавиатуры в <see cref="FullNameTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки клавиатуры в <see cref="EmailTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки клавиатуры в <see cref="PhoneNumberTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки клавиатуры в <see cref="DateOfBirthTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateOfBirthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки клавиатуры в <see cref="VKTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VKTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Обработчик события нажатия кнопки <see cref="BirthdayPanelCloseButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BirthdayPanelCloseButton_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Visible = false;
        }
    }
}