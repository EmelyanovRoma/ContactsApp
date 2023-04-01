namespace ContactsApp.View
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            ControlPanel = new Panel();
            OKButton = new Button();
            NameProgramLabel = new Label();
            VersionProgramLabel = new Label();
            AuthorSurnameLabel = new Label();
            AuthorLabel = new Label();
            EmailLabel = new Label();
            GithubLabel = new Label();
            EmailAddressLabel = new Label();
            MITLicenseTextBox = new TextBox();
            GithubLinkLabel = new LinkLabel();
            ImagesDownloadLabel = new Label();
            WebsiteOfImagesLinkLabel = new LinkLabel();
            ControlPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ControlPanel
            // 
            ControlPanel.BackColor = Color.WhiteSmoke;
            ControlPanel.Controls.Add(OKButton);
            ControlPanel.Dock = DockStyle.Bottom;
            ControlPanel.Location = new Point(0, 361);
            ControlPanel.Name = "ControlPanel";
            ControlPanel.Size = new Size(525, 46);
            ControlPanel.TabIndex = 0;
            // 
            // OKButton
            // 
            OKButton.DialogResult = DialogResult.OK;
            OKButton.Location = new Point(438, 11);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(75, 23);
            OKButton.TabIndex = 0;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            // 
            // NameProgramLabel
            // 
            NameProgramLabel.AutoSize = true;
            NameProgramLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            NameProgramLabel.Location = new Point(12, 28);
            NameProgramLabel.Name = "NameProgramLabel";
            NameProgramLabel.Size = new Size(147, 30);
            NameProgramLabel.TabIndex = 1;
            NameProgramLabel.Text = "ContactsApp";
            // 
            // VersionProgramLabel
            // 
            VersionProgramLabel.AutoSize = true;
            VersionProgramLabel.Location = new Point(16, 59);
            VersionProgramLabel.Name = "VersionProgramLabel";
            VersionProgramLabel.Size = new Size(31, 15);
            VersionProgramLabel.TabIndex = 2;
            VersionProgramLabel.Text = "v 1.0";
            // 
            // AuthorSurnameLabel
            // 
            AuthorSurnameLabel.Anchor = AnchorStyles.Left;
            AuthorSurnameLabel.AutoSize = true;
            AuthorSurnameLabel.Location = new Point(108, 93);
            AuthorSurnameLabel.Margin = new Padding(3, 10, 3, 0);
            AuthorSurnameLabel.Name = "AuthorSurnameLabel";
            AuthorSurnameLabel.Size = new Size(106, 15);
            AuthorSurnameLabel.TabIndex = 3;
            AuthorSurnameLabel.Text = "Roman Emelyanov";
            // 
            // AuthorLabel
            // 
            AuthorLabel.Anchor = AnchorStyles.Left;
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(16, 93);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(47, 15);
            AuthorLabel.TabIndex = 0;
            AuthorLabel.Text = "Author:";
            // 
            // EmailLabel
            // 
            EmailLabel.Anchor = AnchorStyles.Left;
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(16, 118);
            EmailLabel.Margin = new Padding(3, 10, 3, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(44, 15);
            EmailLabel.TabIndex = 1;
            EmailLabel.Text = "E-mail:";
            // 
            // GithubLabel
            // 
            GithubLabel.Anchor = AnchorStyles.Left;
            GithubLabel.AutoSize = true;
            GithubLabel.Location = new Point(16, 143);
            GithubLabel.Margin = new Padding(3, 10, 3, 0);
            GithubLabel.Name = "GithubLabel";
            GithubLabel.Size = new Size(46, 15);
            GithubLabel.TabIndex = 2;
            GithubLabel.Text = "Github:";
            // 
            // EmailAddressLabel
            // 
            EmailAddressLabel.Anchor = AnchorStyles.Left;
            EmailAddressLabel.AutoSize = true;
            EmailAddressLabel.Location = new Point(108, 118);
            EmailAddressLabel.Margin = new Padding(3, 10, 3, 0);
            EmailAddressLabel.Name = "EmailAddressLabel";
            EmailAddressLabel.Size = new Size(129, 15);
            EmailAddressLabel.TabIndex = 4;
            EmailAddressLabel.Text = "Jerryonimo@yandex.ru";
            // 
            // MITLicenseTextBox
            // 
            MITLicenseTextBox.Location = new Point(16, 168);
            MITLicenseTextBox.Margin = new Padding(3, 10, 3, 3);
            MITLicenseTextBox.Multiline = true;
            MITLicenseTextBox.Name = "MITLicenseTextBox";
            MITLicenseTextBox.ScrollBars = ScrollBars.Vertical;
            MITLicenseTextBox.Size = new Size(497, 157);
            MITLicenseTextBox.TabIndex = 6;
            MITLicenseTextBox.Text = resources.GetString("MITLicenseTextBox.Text");
            MITLicenseTextBox.KeyPress += MITLicenseTextBox_KeyPress;
            // 
            // GithubLinkLabel
            // 
            GithubLinkLabel.AutoSize = true;
            GithubLinkLabel.Location = new Point(108, 143);
            GithubLinkLabel.Margin = new Padding(3, 10, 3, 0);
            GithubLinkLabel.Name = "GithubLinkLabel";
            GithubLinkLabel.Size = new Size(203, 15);
            GithubLinkLabel.TabIndex = 7;
            GithubLinkLabel.TabStop = true;
            GithubLinkLabel.Text = "https://github.com/EmelyanovRoma";
            GithubLinkLabel.LinkClicked += GithubLinkLabel_LinkClicked;
            // 
            // ImagesDownloadLabel
            // 
            ImagesDownloadLabel.AutoSize = true;
            ImagesDownloadLabel.Location = new Point(16, 328);
            ImagesDownloadLabel.Margin = new Padding(3, 0, 0, 0);
            ImagesDownloadLabel.Name = "ImagesDownloadLabel";
            ImagesDownloadLabel.Size = new Size(207, 15);
            ImagesDownloadLabel.TabIndex = 8;
            ImagesDownloadLabel.Text = "All used images are downloaded from";
            // 
            // WebsiteOfImagesLinkLabel
            // 
            WebsiteOfImagesLinkLabel.AutoSize = true;
            WebsiteOfImagesLinkLabel.Location = new Point(219, 328);
            WebsiteOfImagesLinkLabel.Margin = new Padding(0, 0, 3, 0);
            WebsiteOfImagesLinkLabel.Name = "WebsiteOfImagesLinkLabel";
            WebsiteOfImagesLinkLabel.Size = new Size(68, 15);
            WebsiteOfImagesLinkLabel.TabIndex = 9;
            WebsiteOfImagesLinkLabel.TabStop = true;
            WebsiteOfImagesLinkLabel.Text = "icons8.com";
            WebsiteOfImagesLinkLabel.LinkClicked += WebsiteOfImagesLinkLabel_LinkClicked;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(525, 407);
            Controls.Add(WebsiteOfImagesLinkLabel);
            Controls.Add(ImagesDownloadLabel);
            Controls.Add(GithubLinkLabel);
            Controls.Add(MITLicenseTextBox);
            Controls.Add(EmailAddressLabel);
            Controls.Add(AuthorSurnameLabel);
            Controls.Add(AuthorLabel);
            Controls.Add(VersionProgramLabel);
            Controls.Add(EmailLabel);
            Controls.Add(NameProgramLabel);
            Controls.Add(GithubLabel);
            Controls.Add(ControlPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AboutForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            ControlPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel ControlPanel;
        private Button OKButton;
        private Label NameProgramLabel;
        private Label VersionProgramLabel;
        private Label AuthorSurnameLabel;
        private Label AuthorLabel;
        private Label EmailLabel;
        private Label GithubLabel;
        private Label EmailAddressLabel;
        private TextBox MITLicenseTextBox;
        private LinkLabel GithubLinkLabel;
        private Label ImagesDownloadLabel;
        private LinkLabel WebsiteOfImagesLinkLabel;
    }
}