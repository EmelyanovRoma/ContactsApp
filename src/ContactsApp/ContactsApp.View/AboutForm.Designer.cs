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
            label1 = new Label();
            label2 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            MITLicenseTextBox = new TextBox();
            GithubLinkLabel = new LinkLabel();
            label8 = new Label();
            linkLabel1 = new LinkLabel();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 1;
            label1.Text = "ContactsApp";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 59);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "v 1.0";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(108, 93);
            label6.Margin = new Padding(3, 10, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 3;
            label6.Text = "Roman Emelyanov";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(16, 93);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 0;
            label3.Text = "Author:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(16, 118);
            label4.Margin = new Padding(3, 10, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 1;
            label4.Text = "E-mail:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Location = new Point(16, 143);
            label5.Margin = new Padding(3, 10, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 2;
            label5.Text = "Github:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(108, 118);
            label7.Margin = new Padding(3, 10, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(129, 15);
            label7.TabIndex = 4;
            label7.Text = "Jerryonimo@yandex.ru";
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
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 328);
            label8.Margin = new Padding(3, 0, 0, 0);
            label8.Name = "label8";
            label8.Size = new Size(194, 15);
            label8.TabIndex = 8;
            label8.Text = "All used images are download from";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(206, 328);
            linkLabel1.Margin = new Padding(0, 0, 3, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(68, 15);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "icons8.com";
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(525, 407);
            Controls.Add(linkLabel1);
            Controls.Add(label8);
            Controls.Add(GithubLinkLabel);
            Controls.Add(MITLicenseTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label5);
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
        private Label label1;
        private Label label2;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox MITLicenseTextBox;
        private LinkLabel GithubLinkLabel;
        private Label label8;
        private LinkLabel linkLabel1;
    }
}