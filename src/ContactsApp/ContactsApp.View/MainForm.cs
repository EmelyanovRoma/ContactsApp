using System;
using System.ComponentModel.Design;
using ContactsApp.Model;

namespace ContactsApp.View
{
    /// <summary>
    /// Класс главнйо формы окна приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Объект класса Project.
        /// </summary>
        private Project _project = new Project(new List<Contact>());

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
            _project.Contacts.Add(ContactFactory.GenerateRandon());
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
                ContactsListBox.Items.RemoveAt(index);
                _project.Contacts.RemoveAt(index);
            }
        }

        /// <summary>
        /// Метод обновления текстовых полей на форме.
        /// </summary>
        /// <param name="index"></param>
        private void UpdateSelectedContact(int index)
        {
            FullNameTextBox.Text = _project.Contacts[index].FullName;
            EmailTextBox.Text = _project.Contacts[index].Email;
            PhoneNumberTextBox.Text = _project.Contacts[index].PhoneNumber;
            DateOfBirthTextBox.Text = _project.Contacts[index].DateOfBirth.ToString();
            VKTextBox.Text = _project.Contacts[index].IDVK;
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
            //var form = new ContactForm();
            //form.ShowDialog();            
            AddContact();
            UpdateListBox();
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

        private void EditContactButton_Click(object sender, EventArgs e)
        {
            var form = new ContactForm();
            form.ShowDialog();
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

        private void RemoveContactButton_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
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

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var form = new AboutForm();
                form.ShowDialog();
            }
        }

        private void BirthdayPanelCloseButton_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Visible = false;
        }

        private void BirthdayPanelCloseButton_MouseEnter(object sender, EventArgs e)
        {
            BirthdayPanelCloseButton.Width = 33;
            BirthdayPanelCloseButton.Height = 33;
        }

        private void BirthdayPanelCloseButton_MouseLeave(object sender, EventArgs e)
        {
            BirthdayPanelCloseButton.Width = 32;
            BirthdayPanelCloseButton.Height = 32;
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1)
                ClearSelectedContact();
            else
                UpdateSelectedContact(ContactsListBox.SelectedIndex);
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
    }
}