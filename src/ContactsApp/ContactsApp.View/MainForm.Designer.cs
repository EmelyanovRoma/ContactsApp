namespace ContactsApp.View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainTableLayoutPanel = new TableLayoutPanel();
            ListContactsPanel = new Panel();
            ButtonsTableLayoutPanel = new TableLayoutPanel();
            RemoveContactButton = new PictureBox();
            EditContactButton = new PictureBox();
            AddContactButton = new PictureBox();
            FindLabel = new Label();
            FindTextBox = new TextBox();
            ContactsListBox = new ListBox();
            InformationAboutContactPanel = new Panel();
            BirthdayPanel = new Panel();
            BirthdayPanelCloseButton = new PictureBox();
            BirthdaySurnamesLabel = new Label();
            TodayIsBirthdayOfLabel = new Label();
            BirthdayPanelPictureBox = new PictureBox();
            VKTextBox = new TextBox();
            VKLabel = new Label();
            DateOfBirthTextBox = new TextBox();
            DateOfBirthLabel = new Label();
            PhoneNumberTextBox = new TextBox();
            PhoneNumberLabel = new Label();
            EmailTextBox = new TextBox();
            EmailLabel = new Label();
            FullNameTextBox = new TextBox();
            FullNameLabel = new Label();
            PhotoPictureBox = new PictureBox();
            MainTableLayoutPanel.SuspendLayout();
            ListContactsPanel.SuspendLayout();
            ButtonsTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RemoveContactButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EditContactButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddContactButton).BeginInit();
            InformationAboutContactPanel.SuspendLayout();
            BirthdayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BirthdayPanelCloseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BirthdayPanelPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhotoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // MainTableLayoutPanel
            // 
            MainTableLayoutPanel.ColumnCount = 2;
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            MainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            MainTableLayoutPanel.Controls.Add(ListContactsPanel, 0, 0);
            MainTableLayoutPanel.Controls.Add(InformationAboutContactPanel, 1, 0);
            MainTableLayoutPanel.Dock = DockStyle.Fill;
            MainTableLayoutPanel.Location = new Point(0, 0);
            MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            MainTableLayoutPanel.RowCount = 1;
            MainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            MainTableLayoutPanel.Size = new Size(800, 450);
            MainTableLayoutPanel.TabIndex = 0;
            // 
            // ListContactsPanel
            // 
            ListContactsPanel.Controls.Add(ButtonsTableLayoutPanel);
            ListContactsPanel.Controls.Add(FindLabel);
            ListContactsPanel.Controls.Add(FindTextBox);
            ListContactsPanel.Controls.Add(ContactsListBox);
            ListContactsPanel.Dock = DockStyle.Fill;
            ListContactsPanel.Location = new Point(3, 3);
            ListContactsPanel.Name = "ListContactsPanel";
            ListContactsPanel.Size = new Size(244, 444);
            ListContactsPanel.TabIndex = 0;
            // 
            // ButtonsTableLayoutPanel
            // 
            ButtonsTableLayoutPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonsTableLayoutPanel.ColumnCount = 3;
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ButtonsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ButtonsTableLayoutPanel.Controls.Add(RemoveContactButton, 2, 0);
            ButtonsTableLayoutPanel.Controls.Add(EditContactButton, 1, 0);
            ButtonsTableLayoutPanel.Controls.Add(AddContactButton, 0, 0);
            ButtonsTableLayoutPanel.Location = new Point(3, 411);
            ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            ButtonsTableLayoutPanel.RowCount = 1;
            ButtonsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            ButtonsTableLayoutPanel.Size = new Size(238, 33);
            ButtonsTableLayoutPanel.TabIndex = 3;
            // 
            // RemoveContactButton
            // 
            RemoveContactButton.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveContactButton.Location = new Point(158, 0);
            RemoveContactButton.Margin = new Padding(0);
            RemoveContactButton.Name = "RemoveContactButton";
            RemoveContactButton.Size = new Size(80, 33);
            RemoveContactButton.SizeMode = PictureBoxSizeMode.CenterImage;
            RemoveContactButton.TabIndex = 2;
            RemoveContactButton.TabStop = false;
            RemoveContactButton.Click += RemoveContactButton_Click;
            RemoveContactButton.MouseEnter += RemoveContactButton_MouseEnter;
            RemoveContactButton.MouseLeave += RemoveContactButton_MouseLeave;
            // 
            // EditContactButton
            // 
            EditContactButton.Image = Properties.Resources.edit_contact_32x32_gray;
            EditContactButton.Location = new Point(79, 0);
            EditContactButton.Margin = new Padding(0);
            EditContactButton.Name = "EditContactButton";
            EditContactButton.Size = new Size(79, 33);
            EditContactButton.SizeMode = PictureBoxSizeMode.CenterImage;
            EditContactButton.TabIndex = 3;
            EditContactButton.TabStop = false;
            EditContactButton.Click += EditContactButton_Click;
            EditContactButton.MouseEnter += EditContactButton_MouseEnter;
            EditContactButton.MouseLeave += EditContactButton_MouseLeave;
            // 
            // AddContactButton
            // 
            AddContactButton.Image = Properties.Resources.add_contact_32x32_gray;
            AddContactButton.Location = new Point(0, 0);
            AddContactButton.Margin = new Padding(0);
            AddContactButton.Name = "AddContactButton";
            AddContactButton.Size = new Size(79, 33);
            AddContactButton.SizeMode = PictureBoxSizeMode.CenterImage;
            AddContactButton.TabIndex = 4;
            AddContactButton.TabStop = false;
            AddContactButton.Click += AddContactButton_Click;
            AddContactButton.MouseEnter += AddContactButton_MouseEnter;
            AddContactButton.MouseLeave += AddContactButton_MouseLeave;
            // 
            // FindLabel
            // 
            FindLabel.AutoSize = true;
            FindLabel.Location = new Point(3, 6);
            FindLabel.Name = "FindLabel";
            FindLabel.Size = new Size(33, 15);
            FindLabel.TabIndex = 2;
            FindLabel.Text = "Find:";
            // 
            // FindTextBox
            // 
            FindTextBox.Location = new Point(48, 3);
            FindTextBox.Name = "FindTextBox";
            FindTextBox.Size = new Size(193, 23);
            FindTextBox.TabIndex = 1;
            // 
            // ContactsListBox
            // 
            ContactsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ContactsListBox.FormattingEnabled = true;
            ContactsListBox.IntegralHeight = false;
            ContactsListBox.ItemHeight = 15;
            ContactsListBox.Items.AddRange(new object[] { "Абакумов Дмитрий", "Абалышев Михаил", "Балтабаев Егор", "Веденин Семен", "Виргунов Михаил", "Глазков Павел", "Голов Станислав" });
            ContactsListBox.Location = new Point(3, 32);
            ContactsListBox.Name = "ContactsListBox";
            ContactsListBox.Size = new Size(238, 379);
            ContactsListBox.TabIndex = 0;
            ContactsListBox.SelectedIndexChanged += ContactsListBox_SelectedIndexChanged;
            // 
            // InformationAboutContactPanel
            // 
            InformationAboutContactPanel.Controls.Add(BirthdayPanel);
            InformationAboutContactPanel.Controls.Add(VKTextBox);
            InformationAboutContactPanel.Controls.Add(VKLabel);
            InformationAboutContactPanel.Controls.Add(DateOfBirthTextBox);
            InformationAboutContactPanel.Controls.Add(DateOfBirthLabel);
            InformationAboutContactPanel.Controls.Add(PhoneNumberTextBox);
            InformationAboutContactPanel.Controls.Add(PhoneNumberLabel);
            InformationAboutContactPanel.Controls.Add(EmailTextBox);
            InformationAboutContactPanel.Controls.Add(EmailLabel);
            InformationAboutContactPanel.Controls.Add(FullNameTextBox);
            InformationAboutContactPanel.Controls.Add(FullNameLabel);
            InformationAboutContactPanel.Controls.Add(PhotoPictureBox);
            InformationAboutContactPanel.Dock = DockStyle.Fill;
            InformationAboutContactPanel.Location = new Point(253, 3);
            InformationAboutContactPanel.Name = "InformationAboutContactPanel";
            InformationAboutContactPanel.Size = new Size(544, 444);
            InformationAboutContactPanel.TabIndex = 1;
            // 
            // BirthdayPanel
            // 
            BirthdayPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BirthdayPanel.BackColor = Color.FromArgb(245, 245, 255);
            BirthdayPanel.Controls.Add(BirthdayPanelCloseButton);
            BirthdayPanel.Controls.Add(BirthdaySurnamesLabel);
            BirthdayPanel.Controls.Add(TodayIsBirthdayOfLabel);
            BirthdayPanel.Controls.Add(BirthdayPanelPictureBox);
            BirthdayPanel.Location = new Point(3, 365);
            BirthdayPanel.Name = "BirthdayPanel";
            BirthdayPanel.Size = new Size(538, 76);
            BirthdayPanel.TabIndex = 11;
            // 
            // BirthdayPanelCloseButton
            // 
            BirthdayPanelCloseButton.Anchor = AnchorStyles.Right;
            BirthdayPanelCloseButton.Cursor = Cursors.Hand;
            BirthdayPanelCloseButton.Image = Properties.Resources.close_32x32;
            BirthdayPanelCloseButton.Location = new Point(503, 3);
            BirthdayPanelCloseButton.Name = "BirthdayPanelCloseButton";
            BirthdayPanelCloseButton.Size = new Size(32, 32);
            BirthdayPanelCloseButton.SizeMode = PictureBoxSizeMode.StretchImage;
            BirthdayPanelCloseButton.TabIndex = 3;
            BirthdayPanelCloseButton.TabStop = false;
            BirthdayPanelCloseButton.Click += BirthdayPanelCloseButton_Click;
            // 
            // BirthdaySurnamesLabel
            // 
            BirthdaySurnamesLabel.AutoSize = true;
            BirthdaySurnamesLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BirthdaySurnamesLabel.ForeColor = Color.FromArgb(0, 144, 255);
            BirthdaySurnamesLabel.Location = new Point(68, 39);
            BirthdaySurnamesLabel.Name = "BirthdaySurnamesLabel";
            BirthdaySurnamesLabel.Size = new Size(192, 15);
            BirthdaySurnamesLabel.TabIndex = 2;
            BirthdaySurnamesLabel.Text = "Абакумов, Петров, Иванов и др.";
            // 
            // TodayIsBirthdayOfLabel
            // 
            TodayIsBirthdayOfLabel.AutoSize = true;
            TodayIsBirthdayOfLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TodayIsBirthdayOfLabel.ForeColor = Color.FromArgb(0, 144, 255);
            TodayIsBirthdayOfLabel.Location = new Point(68, 22);
            TodayIsBirthdayOfLabel.Name = "TodayIsBirthdayOfLabel";
            TodayIsBirthdayOfLabel.Size = new Size(118, 15);
            TodayIsBirthdayOfLabel.TabIndex = 1;
            TodayIsBirthdayOfLabel.Text = "Today is Birthday of:";
            // 
            // BirthdayPanelPictureBox
            // 
            BirthdayPanelPictureBox.Image = Properties.Resources.info_48x48;
            BirthdayPanelPictureBox.Location = new Point(13, 14);
            BirthdayPanelPictureBox.Name = "BirthdayPanelPictureBox";
            BirthdayPanelPictureBox.Size = new Size(48, 48);
            BirthdayPanelPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            BirthdayPanelPictureBox.TabIndex = 0;
            BirthdayPanelPictureBox.TabStop = false;
            // 
            // VKTextBox
            // 
            VKTextBox.Location = new Point(109, 242);
            VKTextBox.Name = "VKTextBox";
            VKTextBox.Size = new Size(181, 23);
            VKTextBox.TabIndex = 10;
            VKTextBox.KeyPress += VKTextBox_KeyPress;
            // 
            // VKLabel
            // 
            VKLabel.AutoSize = true;
            VKLabel.Location = new Point(109, 224);
            VKLabel.Margin = new Padding(3, 10, 3, 0);
            VKLabel.Name = "VKLabel";
            VKLabel.Size = new Size(24, 15);
            VKLabel.TabIndex = 9;
            VKLabel.Text = "VK:";
            // 
            // DateOfBirthTextBox
            // 
            DateOfBirthTextBox.Location = new Point(109, 188);
            DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            DateOfBirthTextBox.Size = new Size(181, 23);
            DateOfBirthTextBox.TabIndex = 8;
            DateOfBirthTextBox.KeyPress += DateOfBirthTextBox_KeyPress;
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.Location = new Point(109, 170);
            DateOfBirthLabel.Margin = new Padding(3, 10, 3, 0);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new Size(76, 15);
            DateOfBirthLabel.TabIndex = 7;
            DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(109, 134);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(181, 23);
            PhoneNumberTextBox.TabIndex = 6;
            PhoneNumberTextBox.Text = "+7 (999) 111-22-33";
            PhoneNumberTextBox.KeyPress += PhoneNumberTextBox_KeyPress;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(109, 116);
            PhoneNumberLabel.Margin = new Padding(3, 10, 3, 0);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(88, 15);
            PhoneNumberLabel.TabIndex = 5;
            PhoneNumberLabel.Text = "PhoneNumber:";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EmailTextBox.Location = new Point(109, 80);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(426, 23);
            EmailTextBox.TabIndex = 4;
            EmailTextBox.Text = "abakumov@no.mail";
            EmailTextBox.KeyPress += EmailTextBox_KeyPress;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(109, 60);
            EmailLabel.Margin = new Padding(3, 10, 3, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(44, 15);
            EmailLabel.TabIndex = 3;
            EmailLabel.Text = "E-mail:";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.Location = new Point(109, 24);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(426, 23);
            FullNameTextBox.TabIndex = 2;
            FullNameTextBox.Text = "Абакумов Дмитрий Николаевич";
            FullNameTextBox.KeyPress += FullNameTextBox_KeyPress;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(109, 6);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(64, 15);
            FullNameLabel.TabIndex = 1;
            FullNameLabel.Text = "Full Name:";
            // 
            // PhotoPictureBox
            // 
            PhotoPictureBox.Image = Properties.Resources.photo_placeholder_100x100;
            PhotoPictureBox.Location = new Point(3, 3);
            PhotoPictureBox.Name = "PhotoPictureBox";
            PhotoPictureBox.Size = new Size(100, 100);
            PhotoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            PhotoPictureBox.TabIndex = 0;
            PhotoPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(MainTableLayoutPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ContactsApp";
            FormClosing += MainForm_FormClosing;
            KeyDown += MainForm_KeyDown;
            MainTableLayoutPanel.ResumeLayout(false);
            ListContactsPanel.ResumeLayout(false);
            ListContactsPanel.PerformLayout();
            ButtonsTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)RemoveContactButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)EditContactButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddContactButton).EndInit();
            InformationAboutContactPanel.ResumeLayout(false);
            InformationAboutContactPanel.PerformLayout();
            BirthdayPanel.ResumeLayout(false);
            BirthdayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BirthdayPanelCloseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)BirthdayPanelPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhotoPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel MainTableLayoutPanel;
        private Panel ListContactsPanel;
        private TextBox FindTextBox;
        private ListBox ContactsListBox;
        private Panel InformationAboutContactPanel;
        private Label FindLabel;
        private TableLayoutPanel ButtonsTableLayoutPanel;
        private TextBox VKTextBox;
        private Label VKLabel;
        private TextBox DateOfBirthTextBox;
        private Label DateOfBirthLabel;
        private TextBox PhoneNumberTextBox;
        private Label PhoneNumberLabel;
        private TextBox EmailTextBox;
        private Label EmailLabel;
        private TextBox FullNameTextBox;
        private Label FullNameLabel;
        private PictureBox PhotoPictureBox;
        private Panel BirthdayPanel;
        private Label BirthdaySurnamesLabel;
        private Label TodayIsBirthdayOfLabel;
        private PictureBox BirthdayPanelPictureBox;
        private PictureBox RemoveContactButton;
        private PictureBox EditContactButton;
        private PictureBox AddContactButton;
        private PictureBox BirthdayPanelCloseButton;
    }
}