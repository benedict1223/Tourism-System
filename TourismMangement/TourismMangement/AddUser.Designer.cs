﻿namespace TourismMangement
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.AddUserButton = new System.Windows.Forms.Button();
            this.AddUserPhoneTextbox = new System.Windows.Forms.TextBox();
            this.AdduserEmailtextbox = new System.Windows.Forms.TextBox();
            this.Adduserpasswordtextbox = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelWayOfPayment = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.AddusertextBoxUsername = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.adduserconfirmpasswordtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddUserButton
            // 
            this.AddUserButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddUserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddUserButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddUserButton.FlatAppearance.BorderSize = 2;
            this.AddUserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddUserButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserButton.ForeColor = System.Drawing.Color.White;
            this.AddUserButton.Location = new System.Drawing.Point(258, 387);
            this.AddUserButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(140, 47);
            this.AddUserButton.TabIndex = 42;
            this.AddUserButton.Text = "Add";
            this.AddUserButton.UseVisualStyleBackColor = false;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // AddUserPhoneTextbox
            // 
            this.AddUserPhoneTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddUserPhoneTextbox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserPhoneTextbox.Location = new System.Drawing.Point(303, 274);
            this.AddUserPhoneTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddUserPhoneTextbox.Name = "AddUserPhoneTextbox";
            this.AddUserPhoneTextbox.Size = new System.Drawing.Size(245, 32);
            this.AddUserPhoneTextbox.TabIndex = 40;
            this.AddUserPhoneTextbox.TextChanged += new System.EventHandler(this.AddUserPhoneTextbox_TextChanged);
            // 
            // AdduserEmailtextbox
            // 
            this.AdduserEmailtextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdduserEmailtextbox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdduserEmailtextbox.Location = new System.Drawing.Point(303, 228);
            this.AdduserEmailtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdduserEmailtextbox.Name = "AdduserEmailtextbox";
            this.AdduserEmailtextbox.Size = new System.Drawing.Size(245, 32);
            this.AdduserEmailtextbox.TabIndex = 39;
            // 
            // Adduserpasswordtextbox
            // 
            this.Adduserpasswordtextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Adduserpasswordtextbox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adduserpasswordtextbox.Location = new System.Drawing.Point(303, 139);
            this.Adduserpasswordtextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Adduserpasswordtextbox.Name = "Adduserpasswordtextbox";
            this.Adduserpasswordtextbox.PasswordChar = '*';
            this.Adduserpasswordtextbox.Size = new System.Drawing.Size(245, 32);
            this.Adduserpasswordtextbox.TabIndex = 38;
            this.Adduserpasswordtextbox.UseSystemPasswordChar = true;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.ForeColor = System.Drawing.Color.Black;
            this.labelPhone.Location = new System.Drawing.Point(97, 276);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(80, 24);
            this.labelPhone.TabIndex = 37;
            this.labelPhone.Text = "Phone:";
            // 
            // labelWayOfPayment
            // 
            this.labelWayOfPayment.AutoSize = true;
            this.labelWayOfPayment.BackColor = System.Drawing.Color.Transparent;
            this.labelWayOfPayment.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWayOfPayment.ForeColor = System.Drawing.Color.Black;
            this.labelWayOfPayment.Location = new System.Drawing.Point(97, 323);
            this.labelWayOfPayment.Name = "labelWayOfPayment";
            this.labelWayOfPayment.Size = new System.Drawing.Size(183, 24);
            this.labelWayOfPayment.TabIndex = 36;
            this.labelWayOfPayment.Text = "Way of payment:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.Black;
            this.labelPassword.Location = new System.Drawing.Point(97, 141);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(114, 24);
            this.labelPassword.TabIndex = 35;
            this.labelPassword.Text = "Password:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.Black;
            this.labelEmail.Location = new System.Drawing.Point(97, 230);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(72, 24);
            this.labelEmail.TabIndex = 34;
            this.labelEmail.Text = "Email:";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.Black;
            this.labelUsername.Location = new System.Drawing.Point(97, 95);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(119, 24);
            this.labelUsername.TabIndex = 33;
            this.labelUsername.Text = "Username:";
            // 
            // AddusertextBoxUsername
            // 
            this.AddusertextBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddusertextBoxUsername.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddusertextBoxUsername.Location = new System.Drawing.Point(303, 93);
            this.AddusertextBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddusertextBoxUsername.Name = "AddusertextBoxUsername";
            this.AddusertextBoxUsername.Size = new System.Drawing.Size(245, 32);
            this.AddusertextBoxUsername.TabIndex = 32;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Visa Card"});
            this.comboBox1.Location = new System.Drawing.Point(303, 320);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(245, 32);
            this.comboBox1.TabIndex = 43;
            // 
            // adduserconfirmpasswordtextBox
            // 
            this.adduserconfirmpasswordtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adduserconfirmpasswordtextBox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adduserconfirmpasswordtextBox.Location = new System.Drawing.Point(303, 186);
            this.adduserconfirmpasswordtextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adduserconfirmpasswordtextBox.Name = "adduserconfirmpasswordtextBox";
            this.adduserconfirmpasswordtextBox.PasswordChar = '*';
            this.adduserconfirmpasswordtextBox.Size = new System.Drawing.Size(245, 32);
            this.adduserconfirmpasswordtextBox.TabIndex = 44;
            this.adduserconfirmpasswordtextBox.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(97, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Confirm Password:";
            // 
            // backbutton
            // 
            this.backbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.backbutton.ForeColor = System.Drawing.Color.White;
            this.backbutton.Location = new System.Drawing.Point(12, 12);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(78, 44);
            this.backbutton.TabIndex = 46;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 567);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adduserconfirmpasswordtextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.AddUserPhoneTextbox);
            this.Controls.Add(this.AdduserEmailtextbox);
            this.Controls.Add(this.Adduserpasswordtextbox);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelWayOfPayment);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.AddusertextBoxUsername);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.TextBox AddUserPhoneTextbox;
        private System.Windows.Forms.TextBox AdduserEmailtextbox;
        private System.Windows.Forms.TextBox Adduserpasswordtextbox;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelWayOfPayment;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox AddusertextBoxUsername;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox adduserconfirmpasswordtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backbutton;
    }
}