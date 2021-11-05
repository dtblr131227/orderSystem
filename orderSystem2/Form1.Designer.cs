
namespace orderSystem2
{
    partial class Form1
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
            this.panel_signIn = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnSignIn = new System.Windows.Forms.Button();
            this.txtPwdSignIn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccountSignIn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSelectSignUppp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSelectSignIn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_SignUp = new System.Windows.Forms.Panel();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.signUpPage_BtnSignIn = new System.Windows.Forms.Button();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.panel_signIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_SignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_signIn
            // 
            this.panel_signIn.Controls.Add(this.pictureBox2);
            this.panel_signIn.Controls.Add(this.BtnSignIn);
            this.panel_signIn.Controls.Add(this.txtPwdSignIn);
            this.panel_signIn.Controls.Add(this.label5);
            this.panel_signIn.Controls.Add(this.txtAccountSignIn);
            this.panel_signIn.Controls.Add(this.label4);
            this.panel_signIn.Location = new System.Drawing.Point(72, 76);
            this.panel_signIn.Name = "panel_signIn";
            this.panel_signIn.Size = new System.Drawing.Size(250, 238);
            this.panel_signIn.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(-55, -78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // BtnSignIn
            // 
            this.BtnSignIn.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnSignIn.FlatAppearance.BorderSize = 0;
            this.BtnSignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignIn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnSignIn.Location = new System.Drawing.Point(22, 170);
            this.BtnSignIn.Name = "BtnSignIn";
            this.BtnSignIn.Size = new System.Drawing.Size(209, 33);
            this.BtnSignIn.TabIndex = 30;
            this.BtnSignIn.Text = "登入";
            this.BtnSignIn.UseVisualStyleBackColor = false;
            this.BtnSignIn.Click += new System.EventHandler(this.BtnSignIn_Click);
            // 
            // txtPwdSignIn
            // 
            this.txtPwdSignIn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPwdSignIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPwdSignIn.Location = new System.Drawing.Point(22, 110);
            this.txtPwdSignIn.Name = "txtPwdSignIn";
            this.txtPwdSignIn.PasswordChar = '*';
            this.txtPwdSignIn.Size = new System.Drawing.Size(208, 29);
            this.txtPwdSignIn.TabIndex = 29;
            this.txtPwdSignIn.Text = "Passw0rd!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(19, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "密碼";
            // 
            // txtAccountSignIn
            // 
            this.txtAccountSignIn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAccountSignIn.Location = new System.Drawing.Point(22, 56);
            this.txtAccountSignIn.Name = "txtAccountSignIn";
            this.txtAccountSignIn.Size = new System.Drawing.Size(208, 29);
            this.txtAccountSignIn.TabIndex = 27;
            this.txtAccountSignIn.Text = "kenny123";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(19, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "帳號";
            // 
            // btnSelectSignUppp
            // 
            this.btnSelectSignUppp.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectSignUppp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectSignUppp.FlatAppearance.BorderSize = 0;
            this.btnSelectSignUppp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSelectSignUppp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSelectSignUppp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSignUppp.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSelectSignUppp.Location = new System.Drawing.Point(126, 48);
            this.btnSelectSignUppp.Name = "btnSelectSignUppp";
            this.btnSelectSignUppp.Size = new System.Drawing.Size(66, 30);
            this.btnSelectSignUppp.TabIndex = 34;
            this.btnSelectSignUppp.Text = "註冊";
            this.btnSelectSignUppp.UseVisualStyleBackColor = false;
            this.btnSelectSignUppp.Click += new System.EventHandler(this.btnSelectSignUppp_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(177, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 30);
            this.button1.TabIndex = 33;
            this.button1.Text = "|";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnSelectSignIn
            // 
            this.btnSelectSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSelectSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectSignIn.FlatAppearance.BorderSize = 0;
            this.btnSelectSignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSelectSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSelectSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSignIn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSelectSignIn.Location = new System.Drawing.Point(198, 48);
            this.btnSelectSignIn.Name = "btnSelectSignIn";
            this.btnSelectSignIn.Size = new System.Drawing.Size(66, 30);
            this.btnSelectSignIn.TabIndex = 32;
            this.btnSelectSignIn.Text = "登入";
            this.btnSelectSignIn.UseVisualStyleBackColor = false;
            this.btnSelectSignIn.Click += new System.EventHandler(this.btnSelectSignIn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::orderSystem2.Properties.Resources.logoNEW;
            this.pictureBox1.Location = new System.Drawing.Point(3, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // panel_SignUp
            // 
            this.panel_SignUp.Controls.Add(this.txtEmpId);
            this.panel_SignUp.Controls.Add(this.label7);
            this.panel_SignUp.Controls.Add(this.txtAddress);
            this.panel_SignUp.Controls.Add(this.label6);
            this.panel_SignUp.Controls.Add(this.label3);
            this.panel_SignUp.Controls.Add(this.txtPwd);
            this.panel_SignUp.Controls.Add(this.txtPhone);
            this.panel_SignUp.Controls.Add(this.label1);
            this.panel_SignUp.Controls.Add(this.txtName);
            this.panel_SignUp.Controls.Add(this.txtAccount);
            this.panel_SignUp.Controls.Add(this.label2);
            this.panel_SignUp.Controls.Add(this.label8);
            this.panel_SignUp.Controls.Add(this.signUpPage_BtnSignIn);
            this.panel_SignUp.Controls.Add(this.BtnSignUp);
            this.panel_SignUp.Location = new System.Drawing.Point(67, 76);
            this.panel_SignUp.Name = "panel_SignUp";
            this.panel_SignUp.Size = new System.Drawing.Size(260, 425);
            this.panel_SignUp.TabIndex = 36;
            this.panel_SignUp.Visible = false;
            // 
            // txtEmpId
            // 
            this.txtEmpId.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmpId.Location = new System.Drawing.Point(27, 311);
            this.txtEmpId.MaxLength = 20;
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(209, 29);
            this.txtEmpId.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(25, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "員工編號";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddress.Location = new System.Drawing.Point(27, 257);
            this.txtAddress.MaxLength = 20;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(209, 29);
            this.txtAddress.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(25, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(24, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "電話";
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPwd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPwd.Location = new System.Drawing.Point(28, 203);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(208, 29);
            this.txtPwd.TabIndex = 47;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPhone.Location = new System.Drawing.Point(28, 95);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(208, 29);
            this.txtPhone.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(25, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "密碼";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(28, 41);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 29);
            this.txtName.TabIndex = 41;
            // 
            // txtAccount
            // 
            this.txtAccount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAccount.Location = new System.Drawing.Point(28, 149);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(208, 29);
            this.txtAccount.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(25, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "帳號";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(25, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "姓名";
            // 
            // signUpPage_BtnSignIn
            // 
            this.signUpPage_BtnSignIn.BackColor = System.Drawing.Color.Goldenrod;
            this.signUpPage_BtnSignIn.FlatAppearance.BorderSize = 0;
            this.signUpPage_BtnSignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.signUpPage_BtnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.signUpPage_BtnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpPage_BtnSignIn.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.signUpPage_BtnSignIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signUpPage_BtnSignIn.Location = new System.Drawing.Point(27, 371);
            this.signUpPage_BtnSignIn.Name = "signUpPage_BtnSignIn";
            this.signUpPage_BtnSignIn.Size = new System.Drawing.Size(209, 33);
            this.signUpPage_BtnSignIn.TabIndex = 53;
            this.signUpPage_BtnSignIn.TabStop = false;
            this.signUpPage_BtnSignIn.Text = "登入";
            this.signUpPage_BtnSignIn.UseVisualStyleBackColor = false;
            this.signUpPage_BtnSignIn.Visible = false;
            this.signUpPage_BtnSignIn.Click += new System.EventHandler(this.signUpPage_BtnSignIn_Click);
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnSignUp.FlatAppearance.BorderSize = 0;
            this.BtnSignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignUp.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BtnSignUp.Location = new System.Drawing.Point(27, 371);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(209, 33);
            this.BtnSignUp.TabIndex = 48;
            this.BtnSignUp.Text = "註冊";
            this.BtnSignUp.UseVisualStyleBackColor = false;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.btnSelectSignIn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSelectSignUppp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel_signIn);
            this.Controls.Add(this.panel_SignUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_signIn.ResumeLayout(false);
            this.panel_signIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_SignUp.ResumeLayout(false);
            this.panel_SignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_signIn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnSignIn;
        private System.Windows.Forms.Button btnSelectSignUppp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPwdSignIn;
        private System.Windows.Forms.Button btnSelectSignIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAccountSignIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_SignUp;
        private System.Windows.Forms.Button signUpPage_BtnSignIn;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
    }
}

