namespace MailClient
{
    partial class Main_Form
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
            this.NewMailButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMailButton = new System.Windows.Forms.Button();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.RadioBtnGroup = new System.Windows.Forms.GroupBox();
            this.SubjectRadioBtn = new System.Windows.Forms.RadioButton();
            this.EmailFromRadioBtn = new System.Windows.Forms.RadioButton();
            this.ContentRadioBtn = new System.Windows.Forms.RadioButton();
            this.TagsRadioBtn = new System.Windows.Forms.RadioButton();
            this.DateRadioBtn = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.RadioBtnGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewMailButton
            // 
            this.NewMailButton.Location = new System.Drawing.Point(10, 415);
            this.NewMailButton.Name = "NewMailButton";
            this.NewMailButton.Size = new System.Drawing.Size(75, 23);
            this.NewMailButton.TabIndex = 0;
            this.NewMailButton.Text = "New Mail";
            this.NewMailButton.UseVisualStyleBackColor = true;
            this.NewMailButton.Click += new System.EventHandler(this.NewMailButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(641, 382);
            this.dataGridView1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inboxToolStripMenuItem,
            this.sentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inboxToolStripMenuItem
            // 
            this.inboxToolStripMenuItem.Name = "inboxToolStripMenuItem";
            this.inboxToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inboxToolStripMenuItem.Text = "Inbox";
            this.inboxToolStripMenuItem.Click += new System.EventHandler(this.inboxToolStripMenuItem_Click);
            // 
            // sentToolStripMenuItem
            // 
            this.sentToolStripMenuItem.Name = "sentToolStripMenuItem";
            this.sentToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.sentToolStripMenuItem.Text = "Sent";
            this.sentToolStripMenuItem.Click += new System.EventHandler(this.sentToolStripMenuItem_Click);
            // 
            // ViewMailButton
            // 
            this.ViewMailButton.Location = new System.Drawing.Point(105, 415);
            this.ViewMailButton.Name = "ViewMailButton";
            this.ViewMailButton.Size = new System.Drawing.Size(75, 23);
            this.ViewMailButton.TabIndex = 4;
            this.ViewMailButton.Text = "View Mail";
            this.ViewMailButton.UseVisualStyleBackColor = true;
            this.ViewMailButton.Click += new System.EventHandler(this.ViewMailButton_Click);
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(659, 27);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(187, 20);
            this.SearchTextBox.TabIndex = 5;
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // RadioBtnGroup
            // 
            this.RadioBtnGroup.Controls.Add(this.dateTimePicker1);
            this.RadioBtnGroup.Controls.Add(this.DateRadioBtn);
            this.RadioBtnGroup.Controls.Add(this.TagsRadioBtn);
            this.RadioBtnGroup.Controls.Add(this.ContentRadioBtn);
            this.RadioBtnGroup.Controls.Add(this.EmailFromRadioBtn);
            this.RadioBtnGroup.Controls.Add(this.SubjectRadioBtn);
            this.RadioBtnGroup.Location = new System.Drawing.Point(658, 53);
            this.RadioBtnGroup.Name = "RadioBtnGroup";
            this.RadioBtnGroup.Size = new System.Drawing.Size(188, 140);
            this.RadioBtnGroup.TabIndex = 6;
            this.RadioBtnGroup.TabStop = false;
            this.RadioBtnGroup.Text = "Search by";
            // 
            // SubjectRadioBtn
            // 
            this.SubjectRadioBtn.AutoSize = true;
            this.SubjectRadioBtn.Checked = true;
            this.SubjectRadioBtn.Location = new System.Drawing.Point(6, 19);
            this.SubjectRadioBtn.Name = "SubjectRadioBtn";
            this.SubjectRadioBtn.Size = new System.Drawing.Size(61, 17);
            this.SubjectRadioBtn.TabIndex = 0;
            this.SubjectRadioBtn.TabStop = true;
            this.SubjectRadioBtn.Text = "Subject";
            this.SubjectRadioBtn.UseVisualStyleBackColor = true;
            // 
            // EmailFromRadioBtn
            // 
            this.EmailFromRadioBtn.AutoSize = true;
            this.EmailFromRadioBtn.Location = new System.Drawing.Point(6, 42);
            this.EmailFromRadioBtn.Name = "EmailFromRadioBtn";
            this.EmailFromRadioBtn.Size = new System.Drawing.Size(50, 17);
            this.EmailFromRadioBtn.TabIndex = 1;
            this.EmailFromRadioBtn.Text = "Email";
            this.EmailFromRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ContentRadioBtn
            // 
            this.ContentRadioBtn.AutoSize = true;
            this.ContentRadioBtn.Location = new System.Drawing.Point(6, 65);
            this.ContentRadioBtn.Name = "ContentRadioBtn";
            this.ContentRadioBtn.Size = new System.Drawing.Size(62, 17);
            this.ContentRadioBtn.TabIndex = 2;
            this.ContentRadioBtn.Text = "Content";
            this.ContentRadioBtn.UseVisualStyleBackColor = true;
            // 
            // TagsRadioBtn
            // 
            this.TagsRadioBtn.AutoSize = true;
            this.TagsRadioBtn.Location = new System.Drawing.Point(5, 88);
            this.TagsRadioBtn.Name = "TagsRadioBtn";
            this.TagsRadioBtn.Size = new System.Drawing.Size(49, 17);
            this.TagsRadioBtn.TabIndex = 3;
            this.TagsRadioBtn.Text = "Tags";
            this.TagsRadioBtn.UseVisualStyleBackColor = true;
            // 
            // DateRadioBtn
            // 
            this.DateRadioBtn.AutoSize = true;
            this.DateRadioBtn.Location = new System.Drawing.Point(6, 111);
            this.DateRadioBtn.Name = "DateRadioBtn";
            this.DateRadioBtn.Size = new System.Drawing.Size(48, 17);
            this.DateRadioBtn.TabIndex = 4;
            this.DateRadioBtn.Text = "Date";
            this.DateRadioBtn.UseVisualStyleBackColor = true;
            this.DateRadioBtn.CheckedChanged += new System.EventHandler(this.DateRadioBtn_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(74, 111);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 446);
            this.Controls.Add(this.RadioBtnGroup);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.ViewMailButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NewMailButton);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.Text = "Mail Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.RadioBtnGroup.ResumeLayout(false);
            this.RadioBtnGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewMailButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sentToolStripMenuItem;
        private System.Windows.Forms.Button ViewMailButton;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.GroupBox RadioBtnGroup;
        private System.Windows.Forms.RadioButton ContentRadioBtn;
        private System.Windows.Forms.RadioButton EmailFromRadioBtn;
        private System.Windows.Forms.RadioButton SubjectRadioBtn;
        private System.Windows.Forms.RadioButton TagsRadioBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton DateRadioBtn;
    }
}

