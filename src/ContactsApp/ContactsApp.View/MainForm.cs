using ContactsApp.Model;

namespace ContactsApp.View
{
    /// <summary>
    /// ��������� ������� ����� ���� ����������.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// ������ ������ <see cref="ProjectSerializer"/>.
        /// </summary>
        private ProjectSerializer _projectSerializer = new ProjectSerializer();

        /// <summary>
        /// ������ ������ <see cref="Project"/>.
        /// </summary>
        private Project _project;

        /// <summary>
        /// ������ ���������, ������������ � ������ ��������� ��� ������ �� ���������.
        /// </summary>
        private List<Contact> _currentContacts = new List<Contact>();

        /// <summary>
        /// ������� ��������� <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _project = _projectSerializer.LoadFromFile();
            _currentContacts = _project.Contacts;
            UpdateListBox();
            UpdateBirthdaySurnamesLabel();
        }

        /// <summary>
        /// ����� ��� ���������� ������ ��������� �� �����.
        /// </summary>
        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();
            for (int i = 0; i < _currentContacts.Count; i++)
            {
                ContactsListBox.Items.Add(_currentContacts[i].FullName);
            }
        }

        /// <summary>
        /// ����� ��� ���������� ������ � ������������
        /// </summary>
        private void UpdateBirthdaySurnamesLabel()
        {            
            int maxCountOfDisplayedContacts = 3;
            var birthdayContacts = _project.FindBirthdayContacts();
            BirthdaySurnamesLabel.Text = "";

            if (birthdayContacts.Count > maxCountOfDisplayedContacts)
            {
                for (int i = 0; i < maxCountOfDisplayedContacts; i++)
                {
                    if (i != maxCountOfDisplayedContacts - 1)
                    {
                        BirthdaySurnamesLabel.Text += birthdayContacts[i].FullName + ", ";
                    }
                    else
                    {
                        BirthdaySurnamesLabel.Text += birthdayContacts[i].FullName + " � ��.";
                    }
                }
            }
            else
            {
                for (int i = 0; i < birthdayContacts.Count; i++)
                {
                    if (i != birthdayContacts.Count - 1)
                    {
                        BirthdaySurnamesLabel.Text += birthdayContacts[i].FullName + ", ";
                    }
                    else
                    {
                        BirthdaySurnamesLabel.Text += birthdayContacts[i].FullName + ".";
                    }
                }
            }
        }

        /// <summary>
        /// ����� ���������� ������ ��������.
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
        /// ����� ��������� ���������� � ��������.
        /// </summary>
        private void EditContact(int index)
        {
            if (index == -1)
                return;

            var contactForm = new ContactForm();
            var indexOfCurrentContact =
                        _project.Contacts.IndexOf(_currentContacts[index]);

            contactForm.Contact =
                (Contact)_project.Contacts[indexOfCurrentContact].Clone();

            if (contactForm.ShowDialog() == DialogResult.OK)
            {
                var updatedContact = contactForm.Contact;

                _project.Contacts.Remove(_currentContacts[index]);
                _project.Contacts.Insert(index, updatedContact);
            }
        }

        /// <summary>
        /// ����� �������� ��������
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
                _project.Contacts.Remove(_currentContacts[index]);

                if (_currentContacts.Count == 0)
                {
                    FindTextBox.Text = "";
                }
            }
        }

        /// <summary>
        /// ����� ���������� ��������� ����� �� �����.
        /// </summary>
        /// <param name="index"></param>
        private void UpdateSelectedContact(int index)
        {
            var selectedContact = _currentContacts[index];

            FullNameTextBox.Text = selectedContact.FullName;
            EmailTextBox.Text = selectedContact.Email;
            PhoneNumberTextBox.Text = selectedContact.PhoneNumber;
            DateOfBirthTextBox.Text = selectedContact.DateOfBirth.ToString();
            VKTextBox.Text = selectedContact.IdVk;
        }

        /// <summary>
        /// ����� ������� ��������� ����� �� �����.
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
        /// ���������� ������� �������� �� ������ <see cref="AddContactButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_Click(object sender, EventArgs e)
        {
            AddContact();
            _project.SortContactsByFullName();
            _currentContacts = _project.Contacts;
            UpdateListBox();
            UpdateBirthdaySurnamesLabel();
            _projectSerializer.SaveToFile(_project);
        }

        /// <summary>
        /// ���������� ������� �������� �� ������ <see cref="EditContactButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            EditContact(ContactsListBox.SelectedIndex);
            _project.SortContactsByFullName();
            _currentContacts = _project.FindContactsBySubstring(FindTextBox.Text);
            UpdateListBox();
            UpdateBirthdaySurnamesLabel();
            ClearSelectedContact();
            _projectSerializer.SaveToFile(_project);
        }

        /// <summary>
        /// ���������� ������� �������� �� ������ <see cref="RemoveContactButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
            _project.SortContactsByFullName();
            _currentContacts = _project.FindContactsBySubstring(FindTextBox.Text);           
            UpdateListBox();
            UpdateBirthdaySurnamesLabel();
            ClearSelectedContact();
            _projectSerializer.SaveToFile(_project);
        }

        /// <summary>
        /// ���������� ������� ��������� ������� <see cref="ContactsListBox"/>.
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
        /// ���������� ������� ��������� ������ <see cref="FindTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {   
            _currentContacts = _project.FindContactsBySubstring(FindTextBox.Text);
            UpdateListBox();
        }

        /// <summary>
        /// ���������� ������� ���������� <see cref="MainForm"/>.
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
            else
            {
                _projectSerializer.SaveToFile(_project);
            }
        }

        /// <summary>
        /// ���������� ������� ������� ������ �� ����� <see cref="MainForm"/>.
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
        /// ���������� ������� ��������� ��������� ���� �� <see cref="AddContactButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_MouseEnter(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32;
            AddContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        /// <summary>
        /// ���������� ������� ���������� ��������� ���� � <see cref="AddContactButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddContactButton_MouseLeave(object sender, EventArgs e)
        {
            AddContactButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddContactButton.BackColor = Color.White;
        }

        /// <summary>
        /// ���������� ������� ��������� ��������� ���� �� <see cref="EditContactButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_MouseEnter(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32;
            EditContactButton.BackColor = ColorTranslator.FromHtml("#F5F5FF");
        }

        /// <summary>
        /// ���������� ������� ���������� ��������� ���� � <see cref="EditContactButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditContactButton_MouseLeave(object sender, EventArgs e)
        {
            EditContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditContactButton.BackColor = Color.White;
        }

        /// <summary>
        /// ���������� ������� ��������� ��������� ���� �� <see cref="RemoveContactButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32;
            RemoveContactButton.BackColor = ColorTranslator.FromHtml("#FAF5F5");
        }

        /// <summary>
        /// ���������� ������� ���������� ��������� ���� � <see cref="RemoveContactButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveContactButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveContactButton.BackColor = Color.White;
        }

        /// <summary>
        /// ���������� ������� ������� ������ ���������� � <see cref="FullNameTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// ���������� ������� ������� ������ ���������� � <see cref="EmailTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// ���������� ������� ������� ������ ���������� � <see cref="PhoneNumberTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// ���������� ������� ������� ������ ���������� � <see cref="DateOfBirthTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DateOfBirthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// ���������� ������� ������� ������ ���������� � <see cref="VKTextBox"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VKTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// ���������� ������� ������� ������ <see cref="BirthdayPanelCloseButton"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BirthdayPanelCloseButton_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Visible = false;
        }
    }
}