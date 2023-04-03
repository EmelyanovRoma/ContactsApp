using System.ComponentModel.Design;
using ContactsApp.Model;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        private Project _project = new Project(new List<Contact>());

        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();
            for (int i = 0; i < _project.Contacts.Count; i++)
            {
                ContactsListBox.Items.Add(_project.Contacts[i].FullName);
            }
        }

        private void AddContact()
        {           
            string[] fullNames =
            {
                "Романович Генадий",
                "Иванов Иван",
                "Петров Алексей",
                "Сидоров Александр",
                "Миронов Игорь"
            };
            string[] emails =
            {
                "1@no.mail",
                "2@no.mail",
                "3@no.mail",
                "4@no.mail",
                "5@no.mail"
            };
            string[] phoneNumbers =
            {
                "+79500000001",
                "+79500000002",
                "+79500000003",
                "+79500000004",
                "+79500000005",
            };
            string[] idVK =
            {
                "123456789",
                "987654321",
                "100000000",
                "200000000",
                "300000000"
            };

            Random random = new Random();
            int value = random.Next(0, 4);
            Contact newContact = new Contact(fullNames[value], emails[value],
                phoneNumbers[value], DateTime.Today, idVK[value]);
            _project.Contacts.Add(newContact);
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
    }
}