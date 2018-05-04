using System.Windows.Forms;

namespace iPlanner
{
    partial class LoginForm
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
            this.Login = new System.Windows.Forms.Button();
            this.passWord = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutLogin = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Login.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Login.Location = new System.Drawing.Point(3, 275);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(167, 21);
            this.Login.TabIndex = 3;
            this.Login.Text = "LOGIN";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // passWord
            // 
            this.passWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passWord.Location = new System.Drawing.Point(3, 248);
            this.passWord.Name = "passWord";
            this.passWord.PasswordChar = '*';
            this.passWord.Size = new System.Drawing.Size(167, 20);
            this.passWord.TabIndex = 2;
            this.passWord.KeyDown += (sender, args) => {
                if (args.KeyCode == Keys.Return)
                {
                    Login.PerformClick();
                    args.SuppressKeyPress = true;
                    args.Handled = true;
                }
            };
            // 
            // userName
            // 
            this.userName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.userName.Location = new System.Drawing.Point(3, 215);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(167, 20);
            this.userName.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::iPlanner.Properties.Resources.logo_Iplaner_smoler;
            this.pictureBox1.Location = new System.Drawing.Point(27, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutLogin
            // 
            this.tableLayoutLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutLogin.ColumnCount = 1;
            this.tableLayoutLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutLogin.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutLogin.Controls.Add(this.userName, 0, 1);
            this.tableLayoutLogin.Controls.Add(this.passWord, 0, 2);
            this.tableLayoutLogin.Controls.Add(this.Login, 0, 3);
            this.tableLayoutLogin.Location = new System.Drawing.Point(48, 68);
            this.tableLayoutLogin.Name = "tableLayoutLogin";
            this.tableLayoutLogin.RowCount = 4;
            this.tableLayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.52941F));
            this.tableLayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.47059F));
            this.tableLayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutLogin.Size = new System.Drawing.Size(173, 299);
            this.tableLayoutLogin.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 412);
            this.Controls.Add(this.tableLayoutLogin);
            this.Name = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutLogin.ResumeLayout(false);
            this.tableLayoutLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox passWord;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutLogin;

        #endregion

        //private void getLoginInfo()
        //{
        //    public string userId = userName.Text;
        //    public string userPass = passWord.Text;
        //}
    }
}