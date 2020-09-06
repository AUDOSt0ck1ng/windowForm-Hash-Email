namespace hash
{
    partial class hash_gui
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hash_gui));
            this.btn_calculate = new System.Windows.Forms.Button();
            this.tb_package = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lab_hash_value = new System.Windows.Forms.Label();
            this.lab_receiver = new System.Windows.Forms.Label();
            this.lab_sender = new System.Windows.Forms.Label();
            this.pb_Run = new System.Windows.Forms.PictureBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.gb_mailuser = new System.Windows.Forms.GroupBox();
            this.gb_sender_info = new System.Windows.Forms.GroupBox();
            this.btn_sender_info_set = new System.Windows.Forms.Button();
            this.tb_password_input = new System.Windows.Forms.TextBox();
            this.tb_sender_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sender_info_cancel = new System.Windows.Forms.Button();
            this.lab_sender_acno = new System.Windows.Forms.Label();
            this.tb_receiver = new System.Windows.Forms.RichTextBox();
            this.btn_change_sender = new System.Windows.Forms.Button();
            this.gb_input = new System.Windows.Forms.GroupBox();
            this.gb_mail = new System.Windows.Forms.GroupBox();
            this.btn_email = new System.Windows.Forms.Button();
            this.tb_value = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Run)).BeginInit();
            this.gb_mailuser.SuspendLayout();
            this.gb_sender_info.SuspendLayout();
            this.gb_input.SuspendLayout();
            this.gb_mail.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_calculate.BackgroundImage")));
            this.btn_calculate.Location = new System.Drawing.Point(245, 115);
            this.btn_calculate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(160, 60);
            this.btn_calculate.TabIndex = 2;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // tb_package
            // 
            this.tb_package.Location = new System.Drawing.Point(20, 58);
            this.tb_package.Margin = new System.Windows.Forms.Padding(4);
            this.tb_package.Name = "tb_package";
            this.tb_package.Size = new System.Drawing.Size(540, 27);
            this.tb_package.TabIndex = 0;
            this.tb_package.TextChanged += new System.EventHandler(this.tb_package_TextChanged);
            // 
            // btn_browse
            // 
            this.btn_browse.Image = ((System.Drawing.Image)(resources.GetObject("btn_browse.Image")));
            this.btn_browse.Location = new System.Drawing.Point(565, 57);
            this.btn_browse.Margin = new System.Windows.Forms.Padding(4);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(35, 25);
            this.btn_browse.TabIndex = 1;
            this.btn_browse.Text = "...";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please input file path :";
            // 
            // lab_hash_value
            // 
            this.lab_hash_value.AutoSize = true;
            this.lab_hash_value.Location = new System.Drawing.Point(28, 191);
            this.lab_hash_value.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_hash_value.Name = "lab_hash_value";
            this.lab_hash_value.Size = new System.Drawing.Size(59, 19);
            this.lab_hash_value.TabIndex = 6;
            this.lab_hash_value.Text = "value : ";
            // 
            // lab_receiver
            // 
            this.lab_receiver.AutoSize = true;
            this.lab_receiver.Location = new System.Drawing.Point(4, 55);
            this.lab_receiver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_receiver.Name = "lab_receiver";
            this.lab_receiver.Size = new System.Drawing.Size(76, 19);
            this.lab_receiver.TabIndex = 5;
            this.lab_receiver.Text = "receiver :";
            // 
            // lab_sender
            // 
            this.lab_sender.AutoSize = true;
            this.lab_sender.Location = new System.Drawing.Point(13, 23);
            this.lab_sender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_sender.Name = "lab_sender";
            this.lab_sender.Size = new System.Drawing.Size(67, 19);
            this.lab_sender.TabIndex = 4;
            this.lab_sender.Text = "sender :";
            // 
            // pb_Run
            // 
            this.pb_Run.Image = ((System.Drawing.Image)(resources.GetObject("pb_Run.Image")));
            this.pb_Run.Location = new System.Drawing.Point(267, 215);
            this.pb_Run.Margin = new System.Windows.Forms.Padding(4);
            this.pb_Run.Name = "pb_Run";
            this.pb_Run.Size = new System.Drawing.Size(102, 42);
            this.pb_Run.TabIndex = 7;
            this.pb_Run.TabStop = false;
            // 
            // btn_send
            // 
            this.btn_send.Image = ((System.Drawing.Image)(resources.GetObject("btn_send.Image")));
            this.btn_send.Location = new System.Drawing.Point(242, 202);
            this.btn_send.Margin = new System.Windows.Forms.Padding(4);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(160, 60);
            this.btn_send.TabIndex = 5;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // gb_mailuser
            // 
            this.gb_mailuser.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gb_mailuser.Controls.Add(this.gb_sender_info);
            this.gb_mailuser.Controls.Add(this.lab_sender_acno);
            this.gb_mailuser.Controls.Add(this.tb_receiver);
            this.gb_mailuser.Controls.Add(this.btn_change_sender);
            this.gb_mailuser.Controls.Add(this.lab_receiver);
            this.gb_mailuser.Controls.Add(this.lab_sender);
            this.gb_mailuser.Location = new System.Drawing.Point(9, 18);
            this.gb_mailuser.Name = "gb_mailuser";
            this.gb_mailuser.Size = new System.Drawing.Size(620, 177);
            this.gb_mailuser.TabIndex = 87;
            this.gb_mailuser.TabStop = false;
            // 
            // gb_sender_info
            // 
            this.gb_sender_info.Controls.Add(this.btn_sender_info_set);
            this.gb_sender_info.Controls.Add(this.tb_password_input);
            this.gb_sender_info.Controls.Add(this.tb_sender_input);
            this.gb_sender_info.Controls.Add(this.label3);
            this.gb_sender_info.Controls.Add(this.label2);
            this.gb_sender_info.Controls.Add(this.btn_sender_info_cancel);
            this.gb_sender_info.Location = new System.Drawing.Point(0, 2);
            this.gb_sender_info.Name = "gb_sender_info";
            this.gb_sender_info.Size = new System.Drawing.Size(620, 162);
            this.gb_sender_info.TabIndex = 90;
            this.gb_sender_info.TabStop = false;
            // 
            // btn_sender_info_set
            // 
            this.btn_sender_info_set.Image = ((System.Drawing.Image)(resources.GetObject("btn_sender_info_set.Image")));
            this.btn_sender_info_set.Location = new System.Drawing.Point(274, 134);
            this.btn_sender_info_set.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sender_info_set.Name = "btn_sender_info_set";
            this.btn_sender_info_set.Size = new System.Drawing.Size(75, 25);
            this.btn_sender_info_set.TabIndex = 93;
            this.btn_sender_info_set.Text = "Set";
            this.btn_sender_info_set.UseVisualStyleBackColor = true;
            this.btn_sender_info_set.Click += new System.EventHandler(this.btn_sender_info_set_Click);
            // 
            // tb_password_input
            // 
            this.tb_password_input.Location = new System.Drawing.Point(149, 87);
            this.tb_password_input.Margin = new System.Windows.Forms.Padding(4);
            this.tb_password_input.Name = "tb_password_input";
            this.tb_password_input.PasswordChar = '*';
            this.tb_password_input.Size = new System.Drawing.Size(354, 27);
            this.tb_password_input.TabIndex = 5;
            // 
            // tb_sender_input
            // 
            this.tb_sender_input.Location = new System.Drawing.Point(149, 23);
            this.tb_sender_input.Margin = new System.Windows.Forms.Padding(4);
            this.tb_sender_input.Name = "tb_sender_input";
            this.tb_sender_input.Size = new System.Drawing.Size(354, 27);
            this.tb_sender_input.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 92;
            this.label3.Text = "password : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 90;
            this.label2.Text = "sender : ";
            // 
            // btn_sender_info_cancel
            // 
            this.btn_sender_info_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_sender_info_cancel.Image")));
            this.btn_sender_info_cancel.Location = new System.Drawing.Point(525, 18);
            this.btn_sender_info_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sender_info_cancel.Name = "btn_sender_info_cancel";
            this.btn_sender_info_cancel.Size = new System.Drawing.Size(75, 25);
            this.btn_sender_info_cancel.TabIndex = 91;
            this.btn_sender_info_cancel.Text = "cancel";
            this.btn_sender_info_cancel.UseVisualStyleBackColor = true;
            this.btn_sender_info_cancel.Click += new System.EventHandler(this.btn_sender_info_cancel_Click);
            // 
            // lab_sender_acno
            // 
            this.lab_sender_acno.AutoSize = true;
            this.lab_sender_acno.Location = new System.Drawing.Point(62, 23);
            this.lab_sender_acno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_sender_acno.Name = "lab_sender_acno";
            this.lab_sender_acno.Size = new System.Drawing.Size(59, 19);
            this.lab_sender_acno.TabIndex = 7;
            this.lab_sender_acno.Text = "sender";
            // 
            // tb_receiver
            // 
            this.tb_receiver.Location = new System.Drawing.Point(62, 52);
            this.tb_receiver.Name = "tb_receiver";
            this.tb_receiver.Size = new System.Drawing.Size(538, 110);
            this.tb_receiver.TabIndex = 6;
            this.tb_receiver.Text = "";
            this.tb_receiver.TextChanged += new System.EventHandler(this.tb_receiver_TextChanged);
            // 
            // btn_change_sender
            // 
            this.btn_change_sender.Image = ((System.Drawing.Image)(resources.GetObject("btn_change_sender.Image")));
            this.btn_change_sender.Location = new System.Drawing.Point(525, 20);
            this.btn_change_sender.Margin = new System.Windows.Forms.Padding(4);
            this.btn_change_sender.Name = "btn_change_sender";
            this.btn_change_sender.Size = new System.Drawing.Size(75, 25);
            this.btn_change_sender.TabIndex = 4;
            this.btn_change_sender.Text = "Alter";
            this.btn_change_sender.UseVisualStyleBackColor = true;
            this.btn_change_sender.Click += new System.EventHandler(this.btn_change_sender_Click);
            // 
            // gb_input
            // 
            this.gb_input.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gb_input.Controls.Add(this.btn_browse);
            this.gb_input.Controls.Add(this.tb_package);
            this.gb_input.Controls.Add(this.label1);
            this.gb_input.Location = new System.Drawing.Point(12, 8);
            this.gb_input.Name = "gb_input";
            this.gb_input.Size = new System.Drawing.Size(620, 100);
            this.gb_input.TabIndex = 0;
            this.gb_input.TabStop = false;
            // 
            // gb_mail
            // 
            this.gb_mail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gb_mail.Controls.Add(this.gb_mailuser);
            this.gb_mail.Controls.Add(this.pb_Run);
            this.gb_mail.Controls.Add(this.btn_send);
            this.gb_mail.Location = new System.Drawing.Point(3, 218);
            this.gb_mail.Name = "gb_mail";
            this.gb_mail.Size = new System.Drawing.Size(639, 277);
            this.gb_mail.TabIndex = 88;
            this.gb_mail.TabStop = false;
            // 
            // btn_email
            // 
            this.btn_email.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_email.BackgroundImage")));
            this.btn_email.Location = new System.Drawing.Point(472, 115);
            this.btn_email.Margin = new System.Windows.Forms.Padding(4);
            this.btn_email.Name = "btn_email";
            this.btn_email.Size = new System.Drawing.Size(160, 60);
            this.btn_email.TabIndex = 89;
            this.btn_email.Text = "Email";
            this.btn_email.UseVisualStyleBackColor = true;
            this.btn_email.Click += new System.EventHandler(this.btn_email_Click);
            // 
            // tb_value
            // 
            this.tb_value.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tb_value.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_value.Location = new System.Drawing.Point(84, 191);
            this.tb_value.Margin = new System.Windows.Forms.Padding(4);
            this.tb_value.Name = "tb_value";
            this.tb_value.ReadOnly = true;
            this.tb_value.Size = new System.Drawing.Size(548, 20);
            this.tb_value.TabIndex = 4;
            // 
            // hash_gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(642, 493);
            this.Controls.Add(this.tb_value);
            this.Controls.Add(this.btn_email);
            this.Controls.Add(this.gb_mail);
            this.Controls.Add(this.gb_input);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.lab_hash_value);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "hash_gui";
            this.Text = "Hash Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.hash_gui_FormClosing);
            this.Load += new System.EventHandler(this.hash_gui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Run)).EndInit();
            this.gb_mailuser.ResumeLayout(false);
            this.gb_mailuser.PerformLayout();
            this.gb_sender_info.ResumeLayout(false);
            this.gb_sender_info.PerformLayout();
            this.gb_input.ResumeLayout(false);
            this.gb_input.PerformLayout();
            this.gb_mail.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.TextBox tb_package;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_hash_value;
        private System.Windows.Forms.Label lab_receiver;
        private System.Windows.Forms.Label lab_sender;
        private System.Windows.Forms.PictureBox pb_Run;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.GroupBox gb_mailuser;
        private System.Windows.Forms.GroupBox gb_input;
        private System.Windows.Forms.GroupBox gb_mail;
        private System.Windows.Forms.Button btn_email;
        private System.Windows.Forms.Button btn_change_sender;
        private System.Windows.Forms.RichTextBox tb_receiver;
        private System.Windows.Forms.Label lab_sender_acno;
        private System.Windows.Forms.GroupBox gb_sender_info;
        private System.Windows.Forms.TextBox tb_password_input;
        private System.Windows.Forms.TextBox tb_sender_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_sender_info_cancel;
        private System.Windows.Forms.Button btn_sender_info_set;
        private System.Windows.Forms.TextBox tb_value;
    }
}

