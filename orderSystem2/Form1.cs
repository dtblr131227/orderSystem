using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orderSystem2
{
    public partial class Form1 : Form
    {
        OrderSystemDBEntities9 db = new OrderSystemDBEntities9();
        Thread th;
        public Form1()
        {
            InitializeComponent();
        }

        //  登入及註冊切換方法
        public void change(Panel Active, Panel InActive, Button btnActive, Button btnInActive, int height)
        {
            Active.Visible = true;
            InActive.Visible = false;
            btnFontStyleChange(btnActive);
            btnInActive.Font = new Font(btnInActive.Font, FontStyle.Regular);
            this.Size = new Size(400, height);
        }
        // 按鈕樣式切換
        public void btnFontStyleChange(Button x)
        {
            var Style = x.Font.Underline ? FontStyle.Regular : FontStyle.Underline;
            x.Font = new Font(x.Font, Style);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            change(panel_signIn, panel_SignUp, btnSelectSignIn, btnSelectSignUppp, 385);
        }

        private void btnSelectSignIn_Click(object sender, EventArgs e)
        {
            change(panel_signIn, panel_SignUp, btnSelectSignIn, btnSelectSignUppp, 385);
        }

        private void btnSelectSignUppp_Click(object sender, EventArgs e)
        {
            change(panel_SignUp, panel_signIn, btnSelectSignUppp, btnSelectSignIn, 600);
        }

        // 開啟client form及employee form方法
        private void openClientForm(object obj)
        {
            Application.Run(new Form2());
        }

        private void openEmpForm(object obj)
        {
            Application.Run(new Form3());
        }
        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            string inputAccount = txtAccountSignIn.Text;
            string inputPwd = StringHelper.Tosha256((txtPwdSignIn.Text).Trim());

            // 查詢資料庫中的帳號密碼
            var a = from data in db.user
                    select data.Account;
            var p = from data in db.user
                    select data.Password;

            Console.WriteLine(a.ToList());

            // 判斷帳號密碼是否和輸入值相同
            int i = 0, n = 0;
            bool accountCorrect = false, passwordCorrect = false;

            while (!accountCorrect)
            {
                if (a.ToList()[i] == inputAccount && i<=a.Count())
                    accountCorrect = true;
                else
                    i++;
            }
            while (!passwordCorrect)
            {
                if (p.ToList()[n] == inputPwd && i <= a.Count())
                    passwordCorrect = true;
                else
                    n++;
            }

            // 判斷是否登入成功
            if (accountCorrect && passwordCorrect)
            {
                MessageBox.Show("登入成功", "提示");

                var q = from c in db.user
                               where c.Account == inputAccount
                               select new
                               {
                                   id = c.id,
                                   account = c.Account,
                                   userName = c.userName,
                                   phone = c.phone,
                                   address = c.Address,
                                   employeeId = c.EmployeeId
                               };
                var nowUserData = q.ToList()[0];

                if (nowUserData.employeeId == null)
                {
                    GlobalVar.NowUser.id = nowUserData.id;
                    GlobalVar.NowUser.Account = nowUserData.account;
                    GlobalVar.NowUser.userName = nowUserData.userName;
                    GlobalVar.NowUser.phone = nowUserData.phone;
                    GlobalVar.NowUser.Address = nowUserData.address;

                    // close form from userControl https://stackoverflow.com/questions/13527474/how-to-close-a-form-in-usercontrol
                    ((Form)this.TopLevelControl).Close();

                    // thread https://www.youtube.com/watch?v=T06aHrAqfRw&ab_channel=winforms
                    th = new Thread(openClientForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    ((Form)this.TopLevelControl).Close();

                    th = new Thread(openEmpForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }

            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤", "提示");
            }
        }

        private void signUpPage_BtnSignIn_Click(object sender, EventArgs e)
        {
            string inputAccount = txtAccount.Text;
            string inputPwd = StringHelper.Tosha256((txtPwd.Text).Trim());

            // 查詢資料庫中的帳號密碼
            var a = from data in db.user
                    select data.Account;
            var p = from data in db.user
                    select data.Password;

            // 判斷帳號密碼是否和輸入值相同
            int i = 0, n = 0;
            bool accountCorrect = false, passwordCorrect = false;

            while (!accountCorrect)
            {
                if (a.ToList()[i] == inputAccount && i <= a.Count())
                    accountCorrect = true;
                else
                    i++;
            }
            while (!passwordCorrect)
            {
                if (p.ToList()[n] == inputPwd && i <= a.Count())
                    passwordCorrect = true;
                else
                    n++;
            }

            // 判斷是否登入成功
            if (accountCorrect && passwordCorrect)
            {
                MessageBox.Show("登入成功", "提示");

                var q = from c in db.user
                        where c.Account == inputAccount
                        select new
                        {
                            id = c.id,
                            account = c.Account,
                            userName = c.userName,
                            phone = c.phone,
                            address = c.Address,
                            employeeId = c.EmployeeId
                        };
                var nowUserData = q.ToList()[0];

                if (nowUserData.employeeId == null)
                {
                    GlobalVar.NowUser.id = nowUserData.id;
                    GlobalVar.NowUser.Account = nowUserData.account;
                    GlobalVar.NowUser.userName = nowUserData.userName;
                    GlobalVar.NowUser.phone = nowUserData.phone;
                    GlobalVar.NowUser.Address = nowUserData.address;

                    // close form from userControl https://stackoverflow.com/questions/13527474/how-to-close-a-form-in-usercontrol
                    ((Form)this.TopLevelControl).Close();

                    // thread https://www.youtube.com/watch?v=T06aHrAqfRw&ab_channel=winforms
                    th = new Thread(openClientForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
                else
                {
                    ((Form)this.TopLevelControl).Close();

                    th = new Thread(openEmpForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }


            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤", "提示");
            }
        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("請確認是否進行註冊", "提示", MessageBoxButtons.OKCancel);

            // 取得使用者輸入值
            string inputName = (txtName.Text).ToString();
            Int32.TryParse(txtPhone.Text, out int inputPhone);
            string inputAccount = (txtAccount.Text).ToString();
            string inputpwd = StringHelper.Tosha256((txtPwd.Text).Trim());
            string inputAddress = (txtAddress.Text).ToString();
            bool EmpIdSucess = Int32.TryParse(txtEmpId.Text, out int inputEmpId);

            if (result == DialogResult.OK)
            {
                // insert
                user u = new user
                {
                    userName = inputName,
                    phone = inputPhone,
                    Account = inputAccount,
                    Password = inputpwd
                };

                if (inputAddress != "")
                {
                    u.Address = inputAddress;
                }
                else { }

                if (EmpIdSucess)
                {
                    u.EmployeeId = inputEmpId;
                }
                else { }

                db.user.Add(u);
                db.SaveChanges();
                MessageBox.Show("註冊成功");

                // 使用註冊資料登入
                signUpPage_BtnSignIn.Visible = true;
            }
            else
            { }
        }
    }
}
