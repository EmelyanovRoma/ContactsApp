namespace ContactsApp.View
{
    partial class ContactForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            InformationAboutContactPanel = new Panel();
            DateOfBirthDateTimePicker = new DateTimePicker();
            AddPhotoButton = new PictureBox();
            VKTextBox = new TextBox();
            VKLabel = new Label();
            DateOfBirthLabel = new Label();
            PhoneNumberTextBox = new TextBox();
            PhoneNumberLabel = new Label();
            EmailTextBox = new TextBox();
            EmailLabel = new Label();
            FullNameTextBox = new TextBox();
            FullNameLabel = new Label();
            PhotoPictureBox = new PictureBox();
            ControlPanel = new Panel();
            OKButton = new Button();
            CancelButton = new Button();
            InformationAboutContactPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddPhotoButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PhotoPictureBox).BeginInit();
            ControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // InformationAboutContactPanel
            // 
            InformationAboutContactPanel.Controls.Add(DateOfBirthDateTimePicker);
            InformationAboutContactPanel.Controls.Add(AddPhotoButton);
            InformationAboutContactPanel.Controls.Add(VKTextBox);
            InformationAboutContactPanel.Controls.Add(VKLabel);
            InformationAboutContactPanel.Controls.Add(DateOfBirthLabel);
            InformationAboutContactPanel.Controls.Add(PhoneNumberTextBox);
            InformationAboutContactPanel.Controls.Add(PhoneNumberLabel);
            InformationAboutContactPanel.Controls.Add(EmailTextBox);
            InformationAboutContactPanel.Controls.Add(EmailLabel);
            InformationAboutContactPanel.Controls.Add(FullNameTextBox);
            InformationAboutContactPanel.Controls.Add(FullNameLabel);
            InformationAboutContactPanel.Controls.Add(PhotoPictureBox);
            InformationAboutContactPanel.Dock = DockStyle.Top;
            InformationAboutContactPanel.Location = new Point(0, 0);
            InformationAboutContactPanel.Name = "InformationAboutContactPanel";
            InformationAboutContactPanel.Size = new Size(525, 304);
            InformationAboutContactPanel.TabIndex = 0;
            // 
            // DateOfBirthDateTimePicker
            // 
            DateOfBirthDateTimePicker.Location = new Point(118, 197);
            DateOfBirthDateTimePicker.Name = "DateOfBirthDateTimePicker";
            DateOfBirthDateTimePicker.Size = new Size(181, 23);
            DateOfBirthDateTimePicker.TabIndex = 22;
            // 
            // AddPhotoButton
            // 
            AddPhotoButton.Image = Properties.Resources.add_photo_32x32_gray;
            AddPhotoButton.Location = new Point(46, 113);
            AddPhotoButton.Name = "AddPhotoButton";
            AddPhotoButton.Size = new Size(32, 32);
            AddPhotoButton.TabIndex = 21;
            AddPhotoButton.TabStop = false;
            AddPhotoButton.Click += AddPhotoButton_Click;
            AddPhotoButton.MouseEnter += AddPhotoButton_MouseEnter;
            AddPhotoButton.MouseLeave += AddPhotoButton_MouseLeave;
            // 
            // VKTextBox
            // 
            VKTextBox.Location = new Point(118, 251);
            VKTextBox.Name = "VKTextBox";
            VKTextBox.Size = new Size(181, 23);
            VKTextBox.TabIndex = 20;
            // 
            // VKLabel
            // 
            VKLabel.AutoSize = true;
            VKLabel.Location = new Point(118, 233);
            VKLabel.Margin = new Padding(3, 10, 3, 0);
            VKLabel.Name = "VKLabel";
            VKLabel.Size = new Size(24, 15);
            VKLabel.TabIndex = 19;
            VKLabel.Text = "VK:";
            // 
            // DateOfBirthLabel
            // 
            DateOfBirthLabel.AutoSize = true;
            DateOfBirthLabel.Location = new Point(118, 179);
            DateOfBirthLabel.Margin = new Padding(3, 10, 3, 0);
            DateOfBirthLabel.Name = "DateOfBirthLabel";
            DateOfBirthLabel.Size = new Size(76, 15);
            DateOfBirthLabel.TabIndex = 17;
            DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(118, 143);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(181, 23);
            PhoneNumberTextBox.TabIndex = 16;
            PhoneNumberTextBox.Text = "+7 (999) 111-22-33";
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(118, 125);
            PhoneNumberLabel.Margin = new Padding(3, 10, 3, 0);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(88, 15);
            PhoneNumberLabel.TabIndex = 15;
            PhoneNumberLabel.Text = "PhoneNumber:";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            EmailTextBox.Location = new Point(118, 89);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(395, 23);
            EmailTextBox.TabIndex = 14;
            EmailTextBox.Text = "abakumov@no.mail";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(118, 69);
            EmailLabel.Margin = new Padding(3, 10, 3, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(44, 15);
            EmailLabel.TabIndex = 13;
            EmailLabel.Text = "E-mail:";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.Location = new Point(118, 33);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(395, 23);
            FullNameTextBox.TabIndex = 12;
            FullNameTextBox.Text = "Абакумов Дмитрий Николаевич";
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(118, 15);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(64, 15);
            FullNameLabel.TabIndex = 11;
            FullNameLabel.Text = "Full Name:";
            // 
            // PhotoPictureBox
            // 
            PhotoPictureBox.Image = Properties.Resources.photo_placeholder_100x100;
            PhotoPictureBox.Location = new Point(12, 12);
            PhotoPictureBox.Name = "PhotoPictureBox";
            PhotoPictureBox.Size = new Size(100, 100);
            PhotoPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            PhotoPictureBox.TabIndex = 2;
            PhotoPictureBox.TabStop = false;
            // 
            // ControlPanel
            // 
            ControlPanel.BackColor = Color.WhiteSmoke;
            ControlPanel.Controls.Add(OKButton);
            ControlPanel.Controls.Add(CancelButton);
            ControlPanel.Dock = DockStyle.Bottom;
            ControlPanel.Location = new Point(0, 304);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(525, 46);
            ControlPanel.TabIndex = 1;
            // 
            // OKButton
            // 
            OKButton.DialogResult = DialogResult.OK;
            OKButton.Location = new Point(357, 11);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(75, 23);
            OKButton.TabIndex = 1;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.Location = new Point(438, 11);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 0;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // ContactForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(525, 350);
            Controls.Add(ControlPanel);
            Controls.Add(InformationAboutContactPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ContactForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            InformationAboutContactPanel.ResumeLayout(false);
            InformationAboutContactPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddPhotoButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)PhotoPictureBox).EndInit();
            ControlPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel InformationAboutContactPanel;
        private Panel ControlPanel;
        private Button OKButton;
        private Button CancelButton;
        private PictureBox PhotoPictureBox;
        private PictureBox AddPhotoButton;
        private TextBox VKTextBox;
        private Label VKLabel;
        private Label DateOfBirthLabel;
        private TextBox PhoneNumberTextBox;
        private Label PhoneNumberLabel;
        private TextBox EmailTextBox;
        private Label EmailLabel;
        private TextBox FullNameTextBox;
        private Label FullNameLabel;
        private DateTimePicker DateOfBirthDateTimePicker;
    }
}