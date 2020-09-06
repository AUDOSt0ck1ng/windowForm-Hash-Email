using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Configuration;
using System.Threading;

namespace hash
{
    public partial class hash_gui : Form
    {
        private System.Security.SecureString pw = getPwdSecurity("");
        SmtpClient smtpClient;
        MailMessage msgMail;
        MailMessage msgMail_sned_value;
        public my_hash file_info = new my_hash();
        public hash_gui()
        {
            InitializeComponent();
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, cert, chain, sslPolicyErrors) => true;
        }

        private void setTab(ArrayList objs)
        {
            int i = 0;
            foreach (Control item in objs) { item.TabIndex = i++; }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog().Equals(System.Windows.Forms.DialogResult.OK))
            {
                file_info.file_path = op.FileName;
                tb_package.Text = op.FileName;
                btn_email.Visible = gb_mail.Visible = false;
                Size = new System.Drawing.Size(660, 250);
                tb_value.Text = "";
            }
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            if (gb_mail.Visible)
            {
                gb_mail.Visible = !gb_mail.Visible;
                Size = new System.Drawing.Size(660, 250);
            }

            if (File.Exists(@file_info.file_path))
            {
                var hash = new SHA256Managed();
               
                using (var fileStream = new FileStream(@file_info.file_path, FileMode.Open))
                {
                    var bytes = hash.ComputeHash(fileStream);
                    file_info.value = string.Concat(Array.ConvertAll(bytes, x => x.ToString("X2")));
                    //fileStream.Dispose();
                }
                tb_value.Text =  file_info.value;
                if (!getConfigStr("mail_skip").Trim().ToLower().Equals("skip"))
                {
                    btn_email.Visible = true;
                    btn_email.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }

        private void tb_package_TextChanged(object sender, EventArgs e)
        {
            file_info.file_path = tb_package.Text;
            btn_email.Visible = gb_mail.Visible = false;
            Size = new System.Drawing.Size(660, 250);
            tb_value.Text = "";
        }
        private void tb_receiver_TextChanged(object sender, EventArgs e) {} 

        private void hash_gui_FormClosing(object sender, FormClosingEventArgs e) => Dispose();

        private void btn_send_Click(object sender, EventArgs e)
        {
            string[] temp = file_info.file_path.Split('\\');
            string package_name = temp[temp.Count() - 1];
            smtpClient = new SmtpClient();
            string err_msg = "";
            err_msg += set(smtpClient);
            if (err_msg.Equals(""))
            {
                try
                {
                    //解析寄信名單
                    string[] receiver_list = tb_receiver.Text.Replace("\n","").Split(';');

                    //第一封
                    msgMail = new MailMessage
                    {
                        From = new
                            MailAddress(lab_sender_acno.Text.Trim(), ""),
                        SubjectEncoding = Encoding.UTF8,
                        Subject = getConfigStr("mail_subject") + package_name,
                        BodyEncoding = Encoding.UTF8,
                        Body = getConfigStr("mail_body"),
                        IsBodyHtml = bool.Parse(getConfigStr("mail_IsBodyHtml"))
                    };
                    //依照寄信名單添加receiver
                    foreach (string receiver in receiver_list){if(!receiver.Equals(string.Empty)){ msgMail.To.Add(new MailAddress(receiver.Trim(), "")); }}
                    //夾帶檔案
                    msgMail.Attachments.Add(new Attachment(@file_info.file_path));

                    //第二封
                    msgMail_sned_value= new MailMessage
                    {
                        From = new
                            MailAddress(lab_sender_acno.Text.Trim(), ""),
                        SubjectEncoding = Encoding.UTF8,
                        Subject = getConfigStr("mail_2_subject") + package_name,
                        BodyEncoding = Encoding.UTF8,
                        Body = getConfigStr("mail_2_body"),
                        IsBodyHtml = bool.Parse(getConfigStr("mail_IsBodyHtml"))
                    };
                    //依照寄信名單添加receiver
                    foreach (string receiver in receiver_list) { if (!receiver.Equals(string.Empty)) { msgMail_sned_value.To.Add(new MailAddress(receiver.Trim(), "")); } }
                    //賦值
                    msgMail_sned_value.Body += "\r\nHash值: " + file_info.value;

                    var background_thread = new Thread(background);
                    background_thread.Start();
                    //background_thread.Join();
                    //                    background_thread.Join();
                    //msgMail.Dispose();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else { MessageBox.Show(err_msg); }
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            gb_mail.Visible = !gb_mail.Visible;
            if (gb_mail.Visible)//mail group開啟時設定tab順序
            {
                ArrayList items = new ArrayList { gb_mail, gb_mailuser, tb_receiver, btn_send };
                setTab(items);
            }
            else//mail group關閉時設定tab順序
            {
                ArrayList items = new ArrayList { gb_input, tb_package, btn_browse, btn_calculate, gb_mail, gb_mailuser, btn_change_sender, tb_receiver, btn_send };
                setTab(items);
                Size = new System.Drawing.Size(660, 250);
            }
        }

        string set(SmtpClient smtpClient)
        {
            string result = "";
            try
            {
                smtpClient.Host = getConfigStr("mail_server").Trim();
                smtpClient.Port = int.Parse(getConfigStr("mail_server_port").Trim());
                smtpClient.EnableSsl = bool.Parse(getConfigStr("mail_server_EnableSsl"));
                smtpClient.UseDefaultCredentials = bool.Parse(getConfigStr("mail_server_UseDefaultCredentials").Trim());
            }
            catch (Exception e) { return "Setting Fail: \r\nHost = " + smtpClient.Host + "\r\nPort = " + smtpClient.Port + "\r\nEnableSsl = " + smtpClient.EnableSsl + "\r\nUseDefaultCredentials = " + smtpClient.UseDefaultCredentials+ "\r\n Err: "+e; }
            finally
            {
                string sendertmp = lab_sender_acno.Text.Split('@').GetValue(0).ToString();
                if (SecureStringToString(pw).Equals("")) { result = "Didn't input password!"; }
                else { smtpClient.Credentials = new NetworkCredential(sendertmp.Trim(), SecureStringToString(pw)); }
            }
            return result;
        }
        private void background()
        {
            Invoke((MethodInvoker)delegate () { running(pb_Run); });
            smtpClient.Send(msgMail);
            smtpClient.Send(msgMail_sned_value);
            MessageBox.Show("Finish.");
            
            Invoke((MethodInvoker)delegate () { running(pb_Run); });
            Invoke((MethodInvoker)delegate () { loading(gb_mail); });
            
            smtpClient.Dispose();
            msgMail.Dispose();
        }
  
        delegate void email_running(PictureBox run);
        void running(PictureBox run)
        {
            if (run.InvokeRequired) { Invoke(new email_running(running), new PictureBox[] { run }); }
            else { run.Visible = !run.Visible; }
        }

        delegate void gui_loading(GroupBox gbm);
        void loading(GroupBox gbm)
        {
            if (gbm.InvokeRequired) { Invoke(new gui_loading(loading), new GroupBox[] { gbm }); }
            else { load(); }
        }

        public void load()
        {
            pb_Run.Visible = gb_mail.Visible = btn_email.Visible = gb_sender_info.Visible = false;//起始該項予隱藏。
            ArrayList items = new ArrayList { gb_input, tb_package, btn_browse, btn_calculate, gb_mail, gb_mailuser, btn_change_sender, tb_receiver, btn_send };
            setTab(items);
            Size = new System.Drawing.Size(660, 250);            
        }

        private void hash_gui_Load(object sender, EventArgs e)
        {
            load();
            //寄、收信者可能使用途中會更改，只需在程式啟動時讀取即可。
            lab_sender_acno.Text = getConfigStr("mail_account").Trim();
            tb_receiver.Text = getConfigStr("receiver").Trim();
            pw = getPwdSecurity(getConfigStr("password").Trim());
        }

        private void btn_change_sender_Click(object sender, EventArgs e)
        {
            //按下alter讀取sender帳密
            gb_sender_info.Visible = true;
            tb_sender_input.Text = lab_sender_acno.Text;
            tb_password_input.Text = SecureStringToString(pw);
            ArrayList items = new ArrayList { tb_sender_input, tb_password_input, btn_sender_info_cancel };
            setTab(items);
        }

        private void btn_sender_info_set_Click(object sender, EventArgs e)
        {
            // 按下set覆寫sender帳密
            lab_sender_acno.Text = tb_sender_input.Text;
            pw = getPwdSecurity(tb_password_input.Text);
            ArrayList items = new ArrayList { gb_input, tb_package, btn_browse, btn_calculate, gb_mail, gb_mailuser, btn_change_sender, tb_receiver, btn_send };
            setTab(items);
            gb_sender_info.Visible = false;
            MessageBox.Show("Sender info updates!");
        }

        private void btn_sender_info_cancel_Click(object sender, EventArgs e)
        {
            gb_sender_info.Visible = false;
            ArrayList items = new ArrayList { gb_input, tb_package, btn_browse, btn_calculate, gb_mail, gb_mailuser, btn_change_sender, tb_receiver, btn_send };
            setTab(items);
        }
        //why you shouldn't use SecureString, QQ Idon't know wat to do else.
        static System.Security.SecureString getPwdSecurity(string value)
        {
            System.Security.SecureString result = new System.Security.SecureString();
            foreach (char c in value){result.AppendChar(c);}
            return result;
        }
        static string SecureStringToString(System.Security.SecureString value)
        {
            IntPtr valuePtr = IntPtr.Zero;
            try
            {
                valuePtr = System.Runtime.InteropServices.Marshal.SecureStringToGlobalAllocUnicode(value);
                return System.Runtime.InteropServices.Marshal.PtrToStringUni(valuePtr);
            }
            finally{System.Runtime.InteropServices.Marshal.ZeroFreeGlobalAllocUnicode(valuePtr);}
        }

        string getConfigStr(string str) => ConfigurationManager.AppSettings[str];
    }
}
