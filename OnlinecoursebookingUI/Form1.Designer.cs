namespace OnlinecoursebookingUI
{
    partial class Form1
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
            label1 = new Label();
            txtUserName = new TextBox();
            label2 = new Label();
            txtAddAmount = new TextBox();
            rdoGuest = new RadioButton();
            rdoRegistered = new RadioButton();
            btnCreateAccount = new Button();
            cmbCourseType = new ComboBox();
            label3 = new Label();
            lblBalance = new TextBox();
            lblStatus = new TextBox();
            label4 = new Label();
            btnRegisterCourse = new Button();
            btnAddAmount = new Button();
            dgvCourses = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(21, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 28);
            label1.TabIndex = 0;
            label1.Text = "userName :";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 12F);
            txtUserName.Location = new Point(138, 26);
            txtUserName.Margin = new Padding(4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(280, 34);
            txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(35, 527);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 28);
            label2.TabIndex = 2;
            label2.Text = "Amount : ";
            // 
            // txtAddAmount
            // 
            txtAddAmount.Font = new Font("Segoe UI", 12F);
            txtAddAmount.Location = new Point(138, 527);
            txtAddAmount.Margin = new Padding(4);
            txtAddAmount.Name = "txtAddAmount";
            txtAddAmount.Size = new Size(170, 34);
            txtAddAmount.TabIndex = 3;
            // 
            // rdoGuest
            // 
            rdoGuest.AutoSize = true;
            rdoGuest.Font = new Font("Segoe UI", 12F);
            rdoGuest.Location = new Point(423, 26);
            rdoGuest.Margin = new Padding(4);
            rdoGuest.Name = "rdoGuest";
            rdoGuest.Size = new Size(83, 32);
            rdoGuest.TabIndex = 4;
            rdoGuest.TabStop = true;
            rdoGuest.Text = "Guest";
            rdoGuest.UseVisualStyleBackColor = true;
            // 
            // rdoRegistered
            // 
            rdoRegistered.AutoSize = true;
            rdoRegistered.Font = new Font("Segoe UI", 12F);
            rdoRegistered.Location = new Point(547, 26);
            rdoRegistered.Margin = new Padding(4);
            rdoRegistered.Name = "rdoRegistered";
            rdoRegistered.Size = new Size(125, 32);
            rdoRegistered.TabIndex = 5;
            rdoRegistered.TabStop = true;
            rdoRegistered.Text = "Registered";
            rdoRegistered.UseVisualStyleBackColor = true;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Font = new Font("Segoe UI", 12F);
            btnCreateAccount.Location = new Point(689, 26);
            btnCreateAccount.Margin = new Padding(4);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(280, 41);
            btnCreateAccount.TabIndex = 6;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            btnCreateAccount.Click += btnCreateAccount_Click;
            // 
            // cmbCourseType
            // 
            cmbCourseType.Font = new Font("Segoe UI", 12F);
            cmbCourseType.FormattingEnabled = true;
            cmbCourseType.Location = new Point(35, 109);
            cmbCourseType.Margin = new Padding(4);
            cmbCourseType.Name = "cmbCourseType";
            cmbCourseType.Size = new Size(383, 36);
            cmbCourseType.TabIndex = 7;
            cmbCourseType.SelectedIndexChanged += cmbCourseType_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(599, 126);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 9;
            label3.Text = "Balance : ";
            // 
            // lblBalance
            // 
            lblBalance.Font = new Font("Segoe UI", 12F);
            lblBalance.Location = new Point(699, 123);
            lblBalance.Margin = new Padding(4);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(270, 34);
            lblBalance.TabIndex = 10;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 12F);
            lblStatus.Location = new Point(118, 439);
            lblStatus.Margin = new Padding(4);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(851, 34);
            lblStatus.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(31, 439);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 28);
            label4.TabIndex = 12;
            label4.Text = "Status : ";
            // 
            // btnRegisterCourse
            // 
            btnRegisterCourse.Font = new Font("Segoe UI", 12F);
            btnRegisterCourse.Location = new Point(726, 527);
            btnRegisterCourse.Margin = new Padding(4);
            btnRegisterCourse.Name = "btnRegisterCourse";
            btnRegisterCourse.Size = new Size(243, 41);
            btnRegisterCourse.TabIndex = 13;
            btnRegisterCourse.Text = "Register Course";
            btnRegisterCourse.UseVisualStyleBackColor = true;
            btnRegisterCourse.Click += btnRegisterCourse_Click;
            // 
            // btnAddAmount
            // 
            btnAddAmount.Font = new Font("Segoe UI", 12F);
            btnAddAmount.Location = new Point(332, 527);
            btnAddAmount.Margin = new Padding(4);
            btnAddAmount.Name = "btnAddAmount";
            btnAddAmount.Size = new Size(161, 41);
            btnAddAmount.TabIndex = 14;
            btnAddAmount.Text = "Add Amount";
            btnAddAmount.UseVisualStyleBackColor = true;
            btnAddAmount.Click += btnAddAmount_Click;
            // 
            // dgvCourses
            // 
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Location = new Point(31, 165);
            dgvCourses.Margin = new Padding(4);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.RowHeadersWidth = 51;
            dgvCourses.Size = new Size(938, 263);
            dgvCourses.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1061, 934);
            Controls.Add(dgvCourses);
            Controls.Add(btnAddAmount);
            Controls.Add(btnRegisterCourse);
            Controls.Add(label4);
            Controls.Add(lblStatus);
            Controls.Add(lblBalance);
            Controls.Add(label3);
            Controls.Add(cmbCourseType);
            Controls.Add(btnCreateAccount);
            Controls.Add(rdoRegistered);
            Controls.Add(rdoGuest);
            Controls.Add(txtAddAmount);
            Controls.Add(label2);
            Controls.Add(txtUserName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUserName;
        private Label label2;
        private TextBox txtAddAmount;
        private RadioButton rdoGuest;
        private RadioButton rdoRegistered;
        private Button btnCreateAccount;
        private ComboBox cmbCourseType;
        private Label label3;
        private TextBox lblBalance;
        private TextBox lblStatus;
        private Label label4;
        private Button btnRegisterCourse;
        private Button btnAddAmount;
        private DataGridView dgvCourses;
    }
}
