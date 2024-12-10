namespace University
{
    partial class signUpForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPhoneNum = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNum = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelAs = new System.Windows.Forms.Label();
            this.radioButtonStudent = new System.Windows.Forms.RadioButton();
            this.radioButtonLectturer = new System.Windows.Forms.RadioButton();
            this.radioButtonDepartmentHead = new System.Windows.Forms.RadioButton();
            this.buttonCreateAccount = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.radioButtonPractitioner = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelRole = new System.Windows.Forms.Panel();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonJava = new System.Windows.Forms.RadioButton();
            this.radioButtonPython = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButtonJS = new System.Windows.Forms.RadioButton();
            this.panelCourse = new System.Windows.Forms.Panel();
            this.panelRole.SuspendLayout();
            this.panelCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(221, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign up ";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFullName.Location = new System.Drawing.Point(74, 308);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(87, 20);
            this.labelFullName.TabIndex = 1;
            this.labelFullName.Text = "Full name:";
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userName.Location = new System.Drawing.Point(69, 85);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(96, 20);
            this.userName.TabIndex = 0;
            this.userName.Text = "User name:";
            this.userName.TextChanged += new System.EventHandler(this.textBoxuserName_TextChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPassword.Location = new System.Drawing.Point(74, 225);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(88, 20);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            // 
            // labelPhoneNum
            // 
            this.labelPhoneNum.AutoSize = true;
            this.labelPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPhoneNum.Location = new System.Drawing.Point(328, 86);
            this.labelPhoneNum.Name = "labelPhoneNum";
            this.labelPhoneNum.Size = new System.Drawing.Size(122, 20);
            this.labelPhoneNum.TabIndex = 4;
            this.labelPhoneNum.Text = "Phone number:";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelID.Location = new System.Drawing.Point(330, 153);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(31, 20);
            this.labelID.TabIndex = 5;
            this.labelID.Text = "ID:";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(76, 331);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(134, 22);
            this.textBoxFullName.TabIndex = 4;
            // 
            // textBoxPhoneNum
            // 
            this.textBoxPhoneNum.Location = new System.Drawing.Point(332, 109);
            this.textBoxPhoneNum.Name = "textBoxPhoneNum";
            this.textBoxPhoneNum.Size = new System.Drawing.Size(134, 22);
            this.textBoxPhoneNum.TabIndex = 5;
            this.textBoxPhoneNum.TextChanged += new System.EventHandler(this.textBoxPhoneNum_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(74, 248);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(134, 22);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxuserName_TextChanged);
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(71, 108);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(134, 22);
            this.textBoxUserName.TabIndex = 1;
            this.textBoxUserName.TextChanged += new System.EventHandler(this.textBoxUserName_TextChanged);
            // 
            // labelAs
            // 
            this.labelAs.AutoSize = true;
            this.labelAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAs.Location = new System.Drawing.Point(28, 15);
            this.labelAs.Name = "labelAs";
            this.labelAs.Size = new System.Drawing.Size(86, 20);
            this.labelAs.TabIndex = 11;
            this.labelAs.Text = "sign up as";
            this.labelAs.Click += new System.EventHandler(this.labelAs_Click);
            // 
            // radioButtonStudent
            // 
            this.radioButtonStudent.AutoSize = true;
            this.radioButtonStudent.Location = new System.Drawing.Point(32, 58);
            this.radioButtonStudent.Name = "radioButtonStudent";
            this.radioButtonStudent.Size = new System.Drawing.Size(73, 20);
            this.radioButtonStudent.TabIndex = 9;
            this.radioButtonStudent.TabStop = true;
            this.radioButtonStudent.Text = "Student";
            this.radioButtonStudent.UseVisualStyleBackColor = true;
            this.radioButtonStudent.CheckedChanged += new System.EventHandler(this.radioButtonStudent_CheckedChanged);
            // 
            // radioButtonLectturer
            // 
            this.radioButtonLectturer.AutoSize = true;
            this.radioButtonLectturer.Location = new System.Drawing.Point(32, 84);
            this.radioButtonLectturer.Name = "radioButtonLectturer";
            this.radioButtonLectturer.Size = new System.Drawing.Size(75, 20);
            this.radioButtonLectturer.TabIndex = 10;
            this.radioButtonLectturer.TabStop = true;
            this.radioButtonLectturer.Text = "Lectture";
            this.radioButtonLectturer.UseVisualStyleBackColor = true;
            this.radioButtonLectturer.CheckedChanged += new System.EventHandler(this.radioButtonLectturer_CheckedChanged);
            // 
            // radioButtonDepartmentHead
            // 
            this.radioButtonDepartmentHead.AutoSize = true;
            this.radioButtonDepartmentHead.Location = new System.Drawing.Point(32, 110);
            this.radioButtonDepartmentHead.Name = "radioButtonDepartmentHead";
            this.radioButtonDepartmentHead.Size = new System.Drawing.Size(135, 20);
            this.radioButtonDepartmentHead.TabIndex = 11;
            this.radioButtonDepartmentHead.TabStop = true;
            this.radioButtonDepartmentHead.Text = "Department Head";
            this.radioButtonDepartmentHead.UseVisualStyleBackColor = true;
            this.radioButtonDepartmentHead.CheckedChanged += new System.EventHandler(this.radioButtonDepartmentHead_CheckedChanged);
            // 
            // buttonCreateAccount
            // 
            this.buttonCreateAccount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonCreateAccount.Location = new System.Drawing.Point(46, 646);
            this.buttonCreateAccount.Name = "buttonCreateAccount";
            this.buttonCreateAccount.Size = new System.Drawing.Size(139, 52);
            this.buttonCreateAccount.TabIndex = 17;
            this.buttonCreateAccount.Text = "Create Account";
            this.buttonCreateAccount.UseVisualStyleBackColor = false;
            this.buttonCreateAccount.Click += new System.EventHandler(this.buttonCreateAccount_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBack.Location = new System.Drawing.Point(228, 646);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 52);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonPractitioner
            // 
            this.radioButtonPractitioner.AutoSize = true;
            this.radioButtonPractitioner.Location = new System.Drawing.Point(32, 136);
            this.radioButtonPractitioner.Name = "radioButtonPractitioner";
            this.radioButtonPractitioner.Size = new System.Drawing.Size(95, 20);
            this.radioButtonPractitioner.TabIndex = 12;
            this.radioButtonPractitioner.TabStop = true;
            this.radioButtonPractitioner.Text = "Practitioner";
            this.radioButtonPractitioner.UseVisualStyleBackColor = true;
            this.radioButtonPractitioner.CheckedChanged += new System.EventHandler(this.radioButtonPractitioner_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(332, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(332, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Age";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(334, 176);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(134, 22);
            this.textBoxID.TabIndex = 6;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(334, 331);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(134, 22);
            this.textBoxAddress.TabIndex = 8;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(332, 248);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(134, 22);
            this.textBoxAge.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(73, 175);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(134, 22);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(72, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "E-mail:";
            // 
            // panelRole
            // 
            this.panelRole.Controls.Add(this.radioButtonPractitioner);
            this.panelRole.Controls.Add(this.labelAs);
            this.panelRole.Controls.Add(this.radioButtonStudent);
            this.panelRole.Controls.Add(this.radioButtonLectturer);
            this.panelRole.Controls.Add(this.radioButtonDepartmentHead);
            this.panelRole.Location = new System.Drawing.Point(46, 399);
            this.panelRole.Name = "panelRole";
            this.panelRole.Size = new System.Drawing.Size(181, 176);
            this.panelRole.TabIndex = 23;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(41, 84);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(44, 20);
            this.radioButtonC.TabIndex = 14;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "C#";
            this.radioButtonC.UseVisualStyleBackColor = true;
            this.radioButtonC.CheckedChanged += new System.EventHandler(this.radioButtonC_CheckedChanged);
            // 
            // radioButtonJava
            // 
            this.radioButtonJava.AutoSize = true;
            this.radioButtonJava.Location = new System.Drawing.Point(41, 58);
            this.radioButtonJava.Name = "radioButtonJava";
            this.radioButtonJava.Size = new System.Drawing.Size(58, 20);
            this.radioButtonJava.TabIndex = 13;
            this.radioButtonJava.TabStop = true;
            this.radioButtonJava.Text = "Java";
            this.radioButtonJava.UseVisualStyleBackColor = true;
            this.radioButtonJava.CheckedChanged += new System.EventHandler(this.radioButtonJava_CheckedChanged);
            // 
            // radioButtonPython
            // 
            this.radioButtonPython.AutoSize = true;
            this.radioButtonPython.Location = new System.Drawing.Point(41, 110);
            this.radioButtonPython.Name = "radioButtonPython";
            this.radioButtonPython.Size = new System.Drawing.Size(69, 20);
            this.radioButtonPython.TabIndex = 15;
            this.radioButtonPython.TabStop = true;
            this.radioButtonPython.Text = "Python";
            this.radioButtonPython.UseVisualStyleBackColor = true;
            this.radioButtonPython.CheckedChanged += new System.EventHandler(this.radioButtonPython_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(37, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Choose Course";
            // 
            // radioButtonJS
            // 
            this.radioButtonJS.AutoSize = true;
            this.radioButtonJS.Location = new System.Drawing.Point(41, 136);
            this.radioButtonJS.Name = "radioButtonJS";
            this.radioButtonJS.Size = new System.Drawing.Size(93, 20);
            this.radioButtonJS.TabIndex = 16;
            this.radioButtonJS.TabStop = true;
            this.radioButtonJS.Text = "Java script";
            this.radioButtonJS.UseVisualStyleBackColor = true;
            this.radioButtonJS.CheckedChanged += new System.EventHandler(this.radioButtonJS_CheckedChanged);
            // 
            // panelCourse
            // 
            this.panelCourse.Controls.Add(this.radioButtonJS);
            this.panelCourse.Controls.Add(this.label4);
            this.panelCourse.Controls.Add(this.radioButtonPython);
            this.panelCourse.Controls.Add(this.radioButtonJava);
            this.panelCourse.Controls.Add(this.radioButtonC);
            this.panelCourse.Location = new System.Drawing.Point(314, 399);
            this.panelCourse.Name = "panelCourse";
            this.panelCourse.Size = new System.Drawing.Size(181, 176);
            this.panelCourse.TabIndex = 22;
            this.panelCourse.Paint += new System.Windows.Forms.PaintEventHandler(this.panelCourse_Paint);
            // 
            // signUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 719);
            this.Controls.Add(this.panelCourse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.buttonCreateAccount);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxPhoneNum);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelPhoneNum);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelRole);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "signUpForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign up";
            this.Load += new System.EventHandler(this.signUpForm_Load);
            this.panelRole.ResumeLayout(false);
            this.panelRole.PerformLayout();
            this.panelCourse.ResumeLayout(false);
            this.panelCourse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPhoneNum;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxPhoneNum;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelAs;
        private System.Windows.Forms.RadioButton radioButtonStudent;
        private System.Windows.Forms.RadioButton radioButtonLectturer;
        private System.Windows.Forms.RadioButton radioButtonDepartmentHead;
        private System.Windows.Forms.Button buttonCreateAccount;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RadioButton radioButtonPractitioner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelRole;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonJava;
        private System.Windows.Forms.RadioButton radioButtonPython;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButtonJS;
        private System.Windows.Forms.Panel panelCourse;
    }
}