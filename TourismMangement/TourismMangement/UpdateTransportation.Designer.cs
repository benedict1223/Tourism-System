﻿namespace TourismMangement
{
    partial class UpdateTransportation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateTransportation));
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.TextBoxOrigin = new System.Windows.Forms.TextBox();
            this.TextBoxDestination = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxIDOfTrans = new System.Windows.Forms.ComboBox();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.comboArrivalMinutes = new System.Windows.Forms.ComboBox();
            this.comboArrivalHours = new System.Windows.Forms.ComboBox();
            this.comboDepartureMinutes = new System.Windows.Forms.ComboBox();
            this.comboDepartureHour = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(311, 129);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(253, 35);
            this.textBoxType.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(422, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 29);
            this.label7.TabIndex = 58;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(422, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 29);
            this.label6.TabIndex = 55;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(114, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 24);
            this.label5.TabIndex = 52;
            this.label5.Text = "Departure Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 51;
            this.label4.Text = "Arrival Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 50;
            this.label3.Text = "Origin: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Destination:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "Type:";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(79, 40);
            this.BackButton.TabIndex = 62;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // TextBoxOrigin
            // 
            this.TextBoxOrigin.Location = new System.Drawing.Point(311, 279);
            this.TextBoxOrigin.Name = "TextBoxOrigin";
            this.TextBoxOrigin.Size = new System.Drawing.Size(253, 35);
            this.TextBoxOrigin.TabIndex = 67;
            // 
            // TextBoxDestination
            // 
            this.TextBoxDestination.Location = new System.Drawing.Point(311, 336);
            this.TextBoxDestination.Name = "TextBoxDestination";
            this.TextBoxDestination.Size = new System.Drawing.Size(253, 35);
            this.TextBoxDestination.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(114, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 24);
            this.label8.TabIndex = 69;
            this.label8.Text = "ID:";
            // 
            // comboBoxIDOfTrans
            // 
            this.comboBoxIDOfTrans.FormattingEnabled = true;
            this.comboBoxIDOfTrans.Location = new System.Drawing.Point(311, 68);
            this.comboBoxIDOfTrans.Name = "comboBoxIDOfTrans";
            this.comboBoxIDOfTrans.Size = new System.Drawing.Size(253, 36);
            this.comboBoxIDOfTrans.TabIndex = 70;
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonUpdate.ForeColor = System.Drawing.Color.White;
            this.ButtonUpdate.Location = new System.Drawing.Point(263, 405);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(140, 47);
            this.ButtonUpdate.TabIndex = 71;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = false;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // comboArrivalMinutes
            // 
            this.comboArrivalMinutes.FormattingEnabled = true;
            this.comboArrivalMinutes.Location = new System.Drawing.Point(449, 230);
            this.comboArrivalMinutes.Name = "comboArrivalMinutes";
            this.comboArrivalMinutes.Size = new System.Drawing.Size(51, 36);
            this.comboArrivalMinutes.TabIndex = 72;
            // 
            // comboArrivalHours
            // 
            this.comboArrivalHours.FormattingEnabled = true;
            this.comboArrivalHours.Location = new System.Drawing.Point(365, 230);
            this.comboArrivalHours.Name = "comboArrivalHours";
            this.comboArrivalHours.Size = new System.Drawing.Size(51, 36);
            this.comboArrivalHours.TabIndex = 73;
            // 
            // comboDepartureMinutes
            // 
            this.comboDepartureMinutes.FormattingEnabled = true;
            this.comboDepartureMinutes.Location = new System.Drawing.Point(449, 178);
            this.comboDepartureMinutes.Name = "comboDepartureMinutes";
            this.comboDepartureMinutes.Size = new System.Drawing.Size(51, 36);
            this.comboDepartureMinutes.TabIndex = 74;
            // 
            // comboDepartureHour
            // 
            this.comboDepartureHour.FormattingEnabled = true;
            this.comboDepartureHour.Location = new System.Drawing.Point(365, 178);
            this.comboDepartureHour.Name = "comboDepartureHour";
            this.comboDepartureHour.Size = new System.Drawing.Size(51, 36);
            this.comboDepartureHour.TabIndex = 75;
            // 
            // UpdateTransportation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 567);
            this.Controls.Add(this.comboDepartureHour);
            this.Controls.Add(this.comboDepartureMinutes);
            this.Controls.Add(this.comboArrivalHours);
            this.Controls.Add(this.comboArrivalMinutes);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.comboBoxIDOfTrans);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TextBoxDestination);
            this.Controls.Add(this.TextBoxOrigin);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "UpdateTransportation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateTransportation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox TextBoxOrigin;
        private System.Windows.Forms.TextBox TextBoxDestination;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxIDOfTrans;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.ComboBox comboArrivalMinutes;
        private System.Windows.Forms.ComboBox comboArrivalHours;
        private System.Windows.Forms.ComboBox comboDepartureMinutes;
        private System.Windows.Forms.ComboBox comboDepartureHour;
    }
}