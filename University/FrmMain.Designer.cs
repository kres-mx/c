namespace University
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnMessages = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPersonalInfo = new System.Windows.Forms.Button();
            this.buttonExitAcc = new System.Windows.Forms.Button();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPostion = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelLastSignIn = new System.Windows.Forms.Label();
            this.textBoxLast = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUniID = new System.Windows.Forms.TextBox();
            this.panelMessages = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.textBoxSearchID = new System.Windows.Forms.TextBox();
            this.buttonSendSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxSearchName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBoxUsers = new System.Windows.Forms.RichTextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listViewMsg = new System.Windows.Forms.ListView();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.textBoxRecipient = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSortByFavorite = new System.Windows.Forms.Button();
            this.btnSortBySenderPosition = new System.Windows.Forms.Button();
            this.btnSortByDate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnOptions);
            this.panel1.Controls.Add(this.btnMessages);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnPersonalInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(605, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 583);
            this.panel1.TabIndex = 0;
            // 
            // btnOptions
            // 
            this.btnOptions.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOptions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOptions.Location = new System.Drawing.Point(32, 492);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(163, 62);
            this.btnOptions.TabIndex = 3;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = false;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // btnMessages
            // 
            this.btnMessages.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMessages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMessages.Location = new System.Drawing.Point(32, 199);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(163, 62);
            this.btnMessages.TabIndex = 1;
            this.btnMessages.Text = "Messages";
            this.btnMessages.UseVisualStyleBackColor = false;
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(32, 339);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(163, 62);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search for others";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPersonalInfo
            // 
            this.btnPersonalInfo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPersonalInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonalInfo.Location = new System.Drawing.Point(32, 51);
            this.btnPersonalInfo.Name = "btnPersonalInfo";
            this.btnPersonalInfo.Size = new System.Drawing.Size(163, 62);
            this.btnPersonalInfo.TabIndex = 0;
            this.btnPersonalInfo.Text = "Personal Information";
            this.btnPersonalInfo.UseVisualStyleBackColor = false;
            this.btnPersonalInfo.Click += new System.EventHandler(this.btnPersonalInfo_Click);
            // 
            // buttonExitAcc
            // 
            this.buttonExitAcc.Location = new System.Drawing.Point(0, 0);
            this.buttonExitAcc.Name = "buttonExitAcc";
            this.buttonExitAcc.Size = new System.Drawing.Size(75, 23);
            this.buttonExitAcc.TabIndex = 0;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(0, 0);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(100, 22);
            this.textBoxFullName.TabIndex = 0;
            // 
            // labelFullName
            // 
            this.labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelFullName.Location = new System.Drawing.Point(57, 253);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(117, 26);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "Full Name";
            this.labelFullName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAddress
            // 
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAddress.Location = new System.Drawing.Point(57, 418);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(117, 26);
            this.labelAddress.TabIndex = 1;
            this.labelAddress.Text = "Address";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPosition
            // 
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPosition.Location = new System.Drawing.Point(57, 459);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(117, 26);
            this.labelPosition.TabIndex = 2;
            this.labelPosition.Text = "Position";
            this.labelPosition.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(0, 0);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(100, 22);
            this.textBoxAddress.TabIndex = 0;
            // 
            // textBoxPostion
            // 
            this.textBoxPostion.Location = new System.Drawing.Point(0, 0);
            this.textBoxPostion.Name = "textBoxPostion";
            this.textBoxPostion.Size = new System.Drawing.Size(100, 22);
            this.textBoxPostion.TabIndex = 0;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(0, 0);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 22);
            this.textBoxAge.TabIndex = 0;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(0, 0);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 22);
            this.textBoxPhone.TabIndex = 0;
            // 
            // labelAge
            // 
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAge.Location = new System.Drawing.Point(57, 376);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(117, 26);
            this.labelAge.TabIndex = 7;
            this.labelAge.Text = "Age";
            this.labelAge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelNumber
            // 
            this.labelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelNumber.Location = new System.Drawing.Point(64, 293);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(117, 26);
            this.labelNumber.TabIndex = 8;
            this.labelNumber.Text = "Phone number";
            this.labelNumber.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(92, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "My Account Info";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelUserName
            // 
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelUserName.Location = new System.Drawing.Point(57, 182);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(117, 26);
            this.labelUserName.TabIndex = 10;
            this.labelUserName.Text = "User name";
            this.labelUserName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelPass
            // 
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPass.Location = new System.Drawing.Point(57, 218);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(117, 26);
            this.labelPass.TabIndex = 11;
            this.labelPass.Text = "Password";
            this.labelPass.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(0, 0);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(100, 22);
            this.textBoxPass.TabIndex = 0;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(0, 0);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(100, 22);
            this.textBoxUserName.TabIndex = 0;
            // 
            // labelID
            // 
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelID.Location = new System.Drawing.Point(57, 335);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(117, 26);
            this.labelID.TabIndex = 14;
            this.labelID.Text = "ID";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(0, 0);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 0;
            // 
            // labelLastSignIn
            // 
            this.labelLastSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelLastSignIn.Location = new System.Drawing.Point(57, 500);
            this.labelLastSignIn.Name = "labelLastSignIn";
            this.labelLastSignIn.Size = new System.Drawing.Size(117, 26);
            this.labelLastSignIn.TabIndex = 17;
            this.labelLastSignIn.Text = "Last sign in";
            this.labelLastSignIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxLast
            // 
            this.textBoxLast.Location = new System.Drawing.Point(0, 0);
            this.textBoxLast.Name = "textBoxLast";
            this.textBoxLast.Size = new System.Drawing.Size(100, 22);
            this.textBoxLast.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(57, 544);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 26);
            this.label6.TabIndex = 20;
            this.label6.Text = "University ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxUniID
            // 
            this.textBoxUniID.Location = new System.Drawing.Point(0, 0);
            this.textBoxUniID.Name = "textBoxUniID";
            this.textBoxUniID.Size = new System.Drawing.Size(100, 22);
            this.textBoxUniID.TabIndex = 0;
            // 
            // panelMessages
            // 
            this.panelMessages.Location = new System.Drawing.Point(0, 0);
            this.panelMessages.Name = "panelMessages";
            this.panelMessages.Size = new System.Drawing.Size(200, 100);
            this.panelMessages.TabIndex = 0;
            // 
            // panelSearch
            // 
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(200, 100);
            this.panelSearch.TabIndex = 0;
            // 
            // panelOptions
            // 
            this.panelOptions.Location = new System.Drawing.Point(0, 0);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(200, 100);
            this.panelOptions.TabIndex = 0;
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.Location = new System.Drawing.Point(0, 0);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(75, 23);
            this.buttonSignOut.TabIndex = 0;
            // 
            // textBoxSearchID
            // 
            this.textBoxSearchID.Location = new System.Drawing.Point(412, 79);
            this.textBoxSearchID.Name = "textBoxSearchID";
            this.textBoxSearchID.Size = new System.Drawing.Size(220, 22);
            this.textBoxSearchID.TabIndex = 25;
            // 
            // buttonSendSearch
            // 
            this.buttonSendSearch.Location = new System.Drawing.Point(0, 0);
            this.buttonSendSearch.Name = "buttonSendSearch";
            this.buttonSendSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSendSearch.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(428, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Search users by name:";
            // 
            // textBoxSearchName
            // 
            this.textBoxSearchName.Location = new System.Drawing.Point(112, 79);
            this.textBoxSearchName.Name = "textBoxSearchName";
            this.textBoxSearchName.Size = new System.Drawing.Size(220, 22);
            this.textBoxSearchName.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Search users by name:";
            // 
            // richTextBoxUsers
            // 
            this.richTextBoxUsers.Location = new System.Drawing.Point(93, 215);
            this.richTextBoxUsers.Name = "richTextBoxUsers";
            this.richTextBoxUsers.Size = new System.Drawing.Size(590, 216);
            this.richTextBoxUsers.TabIndex = 0;
            this.richTextBoxUsers.Text = "";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(0, 0);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 0;
            // 
            // listViewMsg
            // 
            this.listViewMsg.HideSelection = false;
            this.listViewMsg.Location = new System.Drawing.Point(0, 0);
            this.listViewMsg.Name = "listViewMsg";
            this.listViewMsg.Size = new System.Drawing.Size(121, 97);
            this.listViewMsg.TabIndex = 0;
            this.listViewMsg.UseCompatibleStateImageBehavior = false;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Location = new System.Drawing.Point(614, 406);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(90, 38);
            this.btnSendMessage.TabIndex = 11;
            this.btnSendMessage.Text = "&Send";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Location = new System.Drawing.Point(614, 206);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(404, 178);
            this.richTextBoxMessage.TabIndex = 10;
            this.richTextBoxMessage.Text = "";
            // 
            // textBoxRecipient
            // 
            this.textBoxRecipient.Location = new System.Drawing.Point(724, 105);
            this.textBoxRecipient.Name = "textBoxRecipient";
            this.textBoxRecipient.Size = new System.Drawing.Size(152, 22);
            this.textBoxRecipient.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(610, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Recipient :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(610, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Write your message here";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "All messages :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sort by:";
            // 
            // btnSortByFavorite
            // 
            this.btnSortByFavorite.Location = new System.Drawing.Point(0, 0);
            this.btnSortByFavorite.Name = "btnSortByFavorite";
            this.btnSortByFavorite.Size = new System.Drawing.Size(75, 23);
            this.btnSortByFavorite.TabIndex = 0;
            // 
            // btnSortBySenderPosition
            // 
            this.btnSortBySenderPosition.Location = new System.Drawing.Point(0, 0);
            this.btnSortBySenderPosition.Name = "btnSortBySenderPosition";
            this.btnSortBySenderPosition.Size = new System.Drawing.Size(75, 23);
            this.btnSortBySenderPosition.TabIndex = 0;
            // 
            // btnSortByDate
            // 
            this.btnSortByDate.Location = new System.Drawing.Point(0, 0);
            this.btnSortByDate.Name = "btnSortByDate";
            this.btnSortByDate.Size = new System.Drawing.Size(75, 23);
            this.btnSortByDate.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.Location = new System.Drawing.Point(97, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(325, 29);
            this.label9.TabIndex = 1;
            this.label9.Text = "Welcome to Ariel University";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.Location = new System.Drawing.Point(12, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(584, 338);
            this.label10.TabIndex = 2;
            this.label10.Text = resources.GetString("label10.Text");
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 583);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnMessages;
        private System.Windows.Forms.Button btnPersonalInfo;
        private System.Windows.Forms.Button buttonExitAcc;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxPostion;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelLastSignIn;
        private System.Windows.Forms.TextBox textBoxLast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUniID;
        private System.Windows.Forms.Panel panelMessages;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.TextBox textBoxSearchID;
        private System.Windows.Forms.Button buttonSendSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxSearchName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBoxUsers;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListView listViewMsg;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.TextBox textBoxRecipient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSortByFavorite;
        private System.Windows.Forms.Button btnSortBySenderPosition;
        private System.Windows.Forms.Button btnSortByDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}