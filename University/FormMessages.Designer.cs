namespace University
{
    partial class FormMessages
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
            this.listViewMsg = new System.Windows.Forms.ListView();
            this.btnSortByDate = new System.Windows.Forms.Button();
            this.btnSortByFavorite = new System.Windows.Forms.Button();
            this.btnSortBySenderPosition = new System.Windows.Forms.Button();
            this.textBoxRecipient = new System.Windows.Forms.TextBox();
            this.richTextBoxMessage = new System.Windows.Forms.RichTextBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFavorite = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewMsg
            // 
            this.listViewMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listViewMsg.HideSelection = false;
            this.listViewMsg.Location = new System.Drawing.Point(97, 99);
            this.listViewMsg.Name = "listViewMsg";
            this.listViewMsg.Size = new System.Drawing.Size(488, 284);
            this.listViewMsg.TabIndex = 0;
            this.listViewMsg.UseCompatibleStateImageBehavior = false;
            this.listViewMsg.View = System.Windows.Forms.View.Details;
            // 
            // btnSortByDate
            // 
            this.btnSortByDate.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSortByDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSortByDate.Location = new System.Drawing.Point(180, 536);
            this.btnSortByDate.Name = "btnSortByDate";
            this.btnSortByDate.Size = new System.Drawing.Size(104, 54);
            this.btnSortByDate.TabIndex = 5;
            this.btnSortByDate.Text = "&Date";
            this.btnSortByDate.UseVisualStyleBackColor = false;
            this.btnSortByDate.Click += new System.EventHandler(this.btnSortByDate_Click_1);
            // 
            // btnSortByFavorite
            // 
            this.btnSortByFavorite.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSortByFavorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSortByFavorite.Location = new System.Drawing.Point(333, 536);
            this.btnSortByFavorite.Name = "btnSortByFavorite";
            this.btnSortByFavorite.Size = new System.Drawing.Size(104, 54);
            this.btnSortByFavorite.TabIndex = 6;
            this.btnSortByFavorite.Text = "&Favorite";
            this.btnSortByFavorite.UseVisualStyleBackColor = false;
            this.btnSortByFavorite.Click += new System.EventHandler(this.btnSortByFavorite_Click);
            // 
            // btnSortBySenderPosition
            // 
            this.btnSortBySenderPosition.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSortBySenderPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSortBySenderPosition.Location = new System.Drawing.Point(481, 536);
            this.btnSortBySenderPosition.Name = "btnSortBySenderPosition";
            this.btnSortBySenderPosition.Size = new System.Drawing.Size(104, 54);
            this.btnSortBySenderPosition.TabIndex = 7;
            this.btnSortBySenderPosition.Text = "&Position";
            this.btnSortBySenderPosition.UseVisualStyleBackColor = false;
            this.btnSortBySenderPosition.Click += new System.EventHandler(this.btnSortBySenderPosition_Click_1);
            // 
            // textBoxRecipient
            // 
            this.textBoxRecipient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxRecipient.Location = new System.Drawing.Point(805, 110);
            this.textBoxRecipient.Name = "textBoxRecipient";
            this.textBoxRecipient.Size = new System.Drawing.Size(178, 26);
            this.textBoxRecipient.TabIndex = 1;
            // 
            // richTextBoxMessage
            // 
            this.richTextBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.richTextBoxMessage.Location = new System.Drawing.Point(703, 197);
            this.richTextBoxMessage.Name = "richTextBoxMessage";
            this.richTextBoxMessage.Size = new System.Drawing.Size(341, 152);
            this.richTextBoxMessage.TabIndex = 2;
            this.richTextBoxMessage.Text = "";
            this.richTextBoxMessage.TextChanged += new System.EventHandler(this.richTextBoxMessage_TextChanged);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSendMessage.Location = new System.Drawing.Point(758, 390);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(104, 54);
            this.btnSendMessage.TabIndex = 3;
            this.btnSendMessage.Text = "&Send";
            this.btnSendMessage.UseVisualStyleBackColor = false;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(133, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "All Messages:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(699, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Recipient:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(133, 499);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Sort By:";
            // 
            // btnFavorite
            // 
            this.btnFavorite.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFavorite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnFavorite.Location = new System.Drawing.Point(137, 439);
            this.btnFavorite.Name = "btnFavorite";
            this.btnFavorite.Size = new System.Drawing.Size(111, 57);
            this.btnFavorite.TabIndex = 4;
            this.btnFavorite.Text = "&Add to Favorite";
            this.btnFavorite.UseVisualStyleBackColor = false;
            this.btnFavorite.Click += new System.EventHandler(this.btnFavorite_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(142, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Select the message to add to Favorite";
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonReturn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonReturn.Location = new System.Drawing.Point(920, 568);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(130, 58);
            this.buttonReturn.TabIndex = 8;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // FormMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 670);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnFavorite);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.richTextBoxMessage);
            this.Controls.Add(this.textBoxRecipient);
            this.Controls.Add(this.btnSortBySenderPosition);
            this.Controls.Add(this.btnSortByFavorite);
            this.Controls.Add(this.btnSortByDate);
            this.Controls.Add(this.listViewMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMessages";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.FormMessages_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewMsg;
        private System.Windows.Forms.Button btnSortByDate;
        private System.Windows.Forms.Button btnSortByFavorite;
        private System.Windows.Forms.Button btnSortBySenderPosition;
        private System.Windows.Forms.TextBox textBoxRecipient;
        private System.Windows.Forms.RichTextBox richTextBoxMessage;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFavorite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonReturn;
    }
}