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
        /// Список контактов, отображаемых в списке контактов при поиске по подстроке.
        /// </summary>
        private List<Contact> _currentContacts = new List<Contact>();

        /// <summary>
        /// Конструктор главной формы.
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
            if (FindTextBox.Text == "")
            {
                for (int i = 0; i < _project.Contacts.Count; i++)
                {
                    ContactsListBox.Items.Add(_project.Contacts[i].FullName);
                }
            }
            else
            {
                for (int i = 0; i < _currentContacts.Count; i++)
                {
                    ContactsListBox.Items.Add(_currentContacts[i].FullName);
                }              
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

                FindTextBox.Text = "";
            }
        }

        /// <summary>
        /// Метод изменения информации о контакте.
        /// </summary>
        private void EditContact(int index)
        {
            var contactForm = new ContactForm();

            if (FindTextBox.Text == "")
            {
                contactForm.Contact = (Contact)_project.Contacts[index].Clone();
            }
            else
            {
                var indexOfCurrentContact =
                        _project.Contacts.IndexOf(_currentContacts[index]);
            
                contactForm.Contact = 
                    (Contact)_project.Contacts[indexOfCurrentContact].Clone();
            }
            

            if (contactForm.ShowDialog() == DialogResult.OK)
            {
                var updatedContact = contactForm.Contact;

                if (FindTextBox.Text == "")
                {
                    _project.Contacts.RemoveAt(index);
                    _project.Contacts.Insert(index, updatedContact);                   
                }
                else
                {
                    _project.Contacts.Remove(_currentContacts[index]);                    
                    _project.Contacts.Insert(index, updatedContact);

                    _currentContacts.RemoveAt(index);
                    _currentContacts.Insert(index, updatedContact);
                }
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
                if (FindTextBox.Text == "")
                {
                    _project.Contacts.RemoveAt(index);                 
                }
                else
                {
                    _project.Contacts.Remove(_currentContacts[index]);
                    _currentContacts.RemoveAt(index);

                    if (_currentContacts.Count == 0)
                    {
                        FindTextBox.Text = "";
                    }
                }         
            }           
        }

        /// <summary>
        /// Метод обновления текстовых полей на форме.
        /// </summary>
        /// <param name="index"></param>
        private void UpdateSelectedContact(int index)
        {
            Contact selectedContact;
            if (FindTextBox.Text == "")
                selectedContact = _project.Contacts[index];
            else
                selectedContact = _currentContacts[index];

            FullNameTextBox.Text = selectedContact.FullName;
            EmailTextBox.Text = selectedContact.Email;
            PhoneNumberTextBox.Text = selectedContact.PhoneNumber;
            DateOfBirthTextBox.Text = selectedContact.DateOfBirth.ToString();
            VKTextBox.Text = selectedContact.IDVK;
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

        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddContact();
            _project.SortByName();
            UpdateListBox();
        }

        private void EditContactButton_Click(object sender, EventArgs e)
        {
            EditContact(ContactsListBox.SelectedIndex);
            _project.SortByName();
            UpdateListBox();
        }

        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
            _project.SortByName();
            UpdateListBox();
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1)
                ClearSelectedContact();
            else
                UpdateSelectedContact(ContactsListBox.SelectedIndex);
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FindTextBox.Text == "")
            {
                _currentContacts.Clear();
            }
            else
            {
                _currentContacts = _project.SearchContactsBySubstring(FindTextBox.Text);         
            }

            UpdateListBox();
        }

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

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var form = new AboutForm();
                form.ShowDialog();
            }
        }

        private void AddContactButton_MouseEnter(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32;
            AddContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        private void AddContactButton_MouseLeave(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddContactButton.BackColor = Color.White;
        }

        private void EditContactButton_MouseEnter(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32;
            EditContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        private void EditContactButton_MouseLeave(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditContactButton.BackColor = Color.White;
        }

        private void RemoveContactButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32;
            RemoveContactButton.BackColor = ColorTranslator.FromHtml("#FAF5F5");
        }

        private void RemoveContactButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveContactButton.BackColor = Color.White;
        }

        private void FullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void DateOfBirthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void VKTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BirthdayPanelCloseButton_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Visible = false;
        }    
    }
}