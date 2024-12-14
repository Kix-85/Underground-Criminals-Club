﻿namespace ProjectX
{
    partial class SignPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignPage));
            SignPanel = new Panel();
            label3 = new Label();
            signUpButton = new Button();
            signInButton = new Button();
            label2 = new Label();
            label1 = new Label();
            passWordBox = new TextBox();
            criminalIDBox = new TextBox();
            SignLabel = new Label();
            SignPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SignPanel
            // 
            SignPanel.BackColor = Color.FromArgb(180, 36, 46, 50);
            SignPanel.BackgroundImageLayout = ImageLayout.None;
            SignPanel.BorderStyle = BorderStyle.Fixed3D;
            SignPanel.Controls.Add(label3);
            SignPanel.Controls.Add(signUpButton);
            SignPanel.Controls.Add(signInButton);
            SignPanel.Controls.Add(label2);
            SignPanel.Controls.Add(label1);
            SignPanel.Controls.Add(passWordBox);
            SignPanel.Controls.Add(criminalIDBox);
            SignPanel.Controls.Add(SignLabel);
            SignPanel.Location = new Point(214, 110);
            SignPanel.Name = "SignPanel";
            SignPanel.Size = new Size(856, 484);
            SignPanel.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(243, 251, 253);
            label3.Location = new Point(312, 359);
            label3.Name = "label3";
            label3.Size = new Size(246, 28);
            label3.TabIndex = 5;
            label3.Text = "New criminal? no problem.";
            // 
            // signUpButton
            // 
            signUpButton.Font = new Font("Segoe UI", 20F);
            signUpButton.ForeColor = Color.FromArgb(36, 46, 50);
            signUpButton.Location = new Point(195, 395);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(485, 53);
            signUpButton.TabIndex = 4;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = true;
            // 
            // signInButton
            // 
            signInButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signInButton.ForeColor = Color.FromArgb(36, 46, 50);
            signInButton.Location = new Point(195, 297);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(485, 53);
            signInButton.TabIndex = 4;
            signInButton.Text = "Sign In";
            signInButton.UseVisualStyleBackColor = true;
            signInButton.Click += signInButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(243, 251, 253);
            label2.Location = new Point(195, 186);
            label2.Name = "label2";
            label2.Size = new Size(177, 50);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(243, 251, 253);
            label1.Location = new Point(195, 84);
            label1.Name = "label1";
            label1.Size = new Size(203, 50);
            label1.TabIndex = 2;
            label1.Text = "Criminal ID";
            // 
            // passWordBox
            // 
            passWordBox.BackColor = Color.WhiteSmoke;
            passWordBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passWordBox.Location = new Point(195, 244);
            passWordBox.Name = "passWordBox";
            passWordBox.PasswordChar = '*';
            passWordBox.Size = new Size(485, 38);
            passWordBox.TabIndex = 1;
            // 
            // criminalIDBox
            // 
            criminalIDBox.BackColor = Color.WhiteSmoke;
            criminalIDBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            criminalIDBox.Location = new Point(195, 141);
            criminalIDBox.Name = "criminalIDBox";
            criminalIDBox.Size = new Size(485, 38);
            criminalIDBox.TabIndex = 1;
            // 
            // SignLabel
            // 
            SignLabel.AutoSize = true;
            SignLabel.BackColor = Color.Transparent;
            SignLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignLabel.ForeColor = Color.FromArgb(243, 251, 253);
            SignLabel.Location = new Point(112, 12);
            SignLabel.Name = "SignLabel";
            SignLabel.Size = new Size(653, 62);
            SignLabel.TabIndex = 0;
            SignLabel.Text = "Underground Criminals Club";
            SignLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SignPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(234, 224, 204);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1262, 673);
            Controls.Add(SignPanel);
            ForeColor = Color.Goldenrod;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "SignPage";
            Text = "UCC";
            TransparencyKey = Color.White;
            SignPanel.ResumeLayout(false);
            SignPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SignPanel;
        private Label SignLabel;
        private TextBox criminalIDBox;
        private TextBox passWordBox;
        private Label label1;
        private Button signUpButton;
        private Button signInButton;
        private Label label2;
        private Label label3;
    }
}
