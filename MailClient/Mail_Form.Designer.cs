namespace MailClient
{
    partial class Mail_Form
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
            this.EmailFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SubjectMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TagsMail = new System.Windows.Forms.TextBox();
            this.ContentMail = new System.Windows.Forms.TextBox();
            this.SendMailButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmailFrom
            // 
            this.EmailFrom.Location = new System.Drawing.Point(62, 12);
            this.EmailFrom.Name = "EmailFrom";
            this.EmailFrom.Size = new System.Drawing.Size(307, 20);
            this.EmailFrom.TabIndex = 0;
            this.EmailFrom.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To:";
            // 
            // EmailTo
            // 
            this.EmailTo.Location = new System.Drawing.Point(62, 38);
            this.EmailTo.Name = "EmailTo";
            this.EmailTo.Size = new System.Drawing.Size(307, 20);
            this.EmailTo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subject:";
            // 
            // SubjectMail
            // 
            this.SubjectMail.Location = new System.Drawing.Point(62, 64);
            this.SubjectMail.Name = "SubjectMail";
            this.SubjectMail.Size = new System.Drawing.Size(307, 20);
            this.SubjectMail.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tags:";
            // 
            // TagsMail
            // 
            this.TagsMail.Location = new System.Drawing.Point(62, 91);
            this.TagsMail.Name = "TagsMail";
            this.TagsMail.Size = new System.Drawing.Size(307, 20);
            this.TagsMail.TabIndex = 7;
            // 
            // ContentMail
            // 
            this.ContentMail.Location = new System.Drawing.Point(6, 117);
            this.ContentMail.Multiline = true;
            this.ContentMail.Name = "ContentMail";
            this.ContentMail.Size = new System.Drawing.Size(773, 288);
            this.ContentMail.TabIndex = 8;
            // 
            // SendMailButton
            // 
            this.SendMailButton.Location = new System.Drawing.Point(693, 411);
            this.SendMailButton.Name = "SendMailButton";
            this.SendMailButton.Size = new System.Drawing.Size(86, 35);
            this.SendMailButton.TabIndex = 9;
            this.SendMailButton.Text = "Send";
            this.SendMailButton.UseVisualStyleBackColor = true;
            this.SendMailButton.Click += new System.EventHandler(this.SendMailButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(6, 411);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(86, 35);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(403, 98);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(30, 13);
            this.DateLabel.TabIndex = 11;
            this.DateLabel.Text = "Date";
            this.DateLabel.Visible = false;
            // 
            // Mail_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SendMailButton);
            this.Controls.Add(this.ContentMail);
            this.Controls.Add(this.TagsMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubjectMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmailTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmailFrom);
            this.MaximizeBox = false;
            this.Name = "Mail_Form";
            this.Text = "New Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SubjectMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TagsMail;
        private System.Windows.Forms.TextBox ContentMail;
        private System.Windows.Forms.Button SendMailButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label DateLabel;
    }
}