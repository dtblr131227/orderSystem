using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace orderSystem2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        OrderSystemDBEntities9 db = new OrderSystemDBEntities9();

        //頁面改變方法
        public void change(Panel PanelActive, Panel PanelInActive1,Panel PanelInActive2, Panel PanelInActive3, Button BtnActive, Button BtnInActive, Button BtnInActive2)
        {
            PanelActive.Visible = true;
            PanelInActive1.Visible = false;
            PanelInActive2.Visible = false;
            PanelInActive3.Visible = false;
            BtnActive.Font = new Font(BtnActive.Font, FontStyle.Bold);
            BtnInActive.Font = new Font(BtnInActive.Font, FontStyle.Regular);
            BtnInActive2.Font = new Font(BtnInActive.Font, FontStyle.Regular);

        }

        // 購物車內資料筆數
        int rowAmount = 0;
        // 此筆訂單訂購時間
        string time = GlobalVar.orderTime.ToString();
        public void contentChange(PictureBox pBoxYouClick)
        {
            // 載入所選picbox image
            pictureBox_product.Image = pBoxYouClick.Image;

            // 為所選的picbox內的image加上Tag
            string num = (pBoxYouClick.Name.ToString());
            string[] numArr = num.Split('x');
            pBoxYouClick.Image.Tag = "lunchBox"+numArr[1];

            string tag = pBoxYouClick.Image.Tag.ToString();

            // 用tag查找該便當資訊
            var q = from p in db.productData
                    where p.ImageTag == tag
                    select p;

            var nowProductData = q.ToList()[0];
            GlobalVar.NowProduct.id = nowProductData.id;
            GlobalVar.NowProduct.Name = nowProductData.Name;
            GlobalVar.NowProduct.ImageTag = nowProductData.ImageTag;
            GlobalVar.NowProduct.price = nowProductData.price;
            GlobalVar.NowProduct.description = nowProductData.description;

            lblProductName.Text = GlobalVar.NowProduct.Name;
            lblProductPrice.Text = "售價 :  NTD " + GlobalVar.NowProduct.price.ToString();
            lblProductDesciption.Text = GlobalVar.NowProduct.description;

            // 重設numericUpDown
            numUpDown.Value = 1;

            
        }
       
        private void Form2_Load(object sender, EventArgs e)
        {
            change(panelMenu, panelMenu_product, panelCart, panel_myFavorite, btn_menu, btn_cart, btn_myFavorite);
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            change(panelMenu, panelMenu_product, panelCart, panel_myFavorite, btn_menu, btn_cart, btn_myFavorite);
            
        }

        private void picBox1_Click(object sender, EventArgs e)
        {
            change(panelMenu_product, panelMenu, panelCart, panel_myFavorite, btn_menu, btn_cart, btn_myFavorite);
            contentChange(picBox1);
        }

        private void picBox2_Click(object sender, EventArgs e)
        {
            change(panelMenu_product, panelMenu, panelCart, panel_myFavorite, btn_menu, btn_cart, btn_myFavorite);
            contentChange(picBox2);
        }

        private void picBox3_Click(object sender, EventArgs e)
        {
            change(panelMenu_product, panelMenu, panelCart, panel_myFavorite, btn_menu, btn_cart, btn_myFavorite);
            contentChange(picBox3);
        }

        private void picBox4_Click(object sender, EventArgs e)
        {
            change(panelMenu_product, panelMenu, panelCart, panel_myFavorite, btn_menu, btn_cart, btn_myFavorite);
            contentChange(picBox4);
        }

        private void picBox5_Click(object sender, EventArgs e)
        {
            change(panelMenu_product, panelMenu, panelCart, panel_myFavorite, btn_menu, btn_cart, btn_myFavorite);
            contentChange(picBox5);
        }

        private void picBox6_Click(object sender, EventArgs e)
        {
            change(panelMenu_product, panelMenu, panelCart, panel_myFavorite, btn_menu, btn_cart, btn_myFavorite);
            contentChange(picBox6);
        }

        private void picBox7_Click(object sender, EventArgs e)
        {
            change(panelMenu_product, panelMenu, panelCart, panel_myFavorite, btn_menu, btn_cart, btn_myFavorite);
            contentChange(picBox7);
        }

        private void btn_addToCart_Click(object sender, EventArgs e)
        {
            //將訂單資訊加入資料表orderLine

            orderLine AnOrderline = new orderLine
            {
                orderLine_user_id = GlobalVar.NowUser.id,
                product_id = GlobalVar.NowProduct.id,
                price = GlobalVar.NowProduct.price,
                quantity = (int)numUpDown.Value,
                orderDateTime = time
            };

            db.orderLine.Add(AnOrderline);
            db.SaveChanges();

            // 改變購物車內資料筆數及顯示提示
            rowAmount++;
            btn_cart.Text = $"購物車({rowAmount})";
            MessageBox.Show("已加入購物車", "提示");
        }

        private void btn_cart_Click(object sender, EventArgs e)
        {
            // 頁面及按鈕樣式改變
            change(panelCart, panelMenu_product, panelMenu, panel_myFavorite, btn_cart, btn_menu, btn_myFavorite);
            listBox_orderLine.Items.Clear();

            //載入顧客資訊
            txtBoxAddress.Text = GlobalVar.NowUser.Address;
            txtBoxName.Text = GlobalVar.NowUser.userName;
            txtBoxPhone.Text = GlobalVar.NowUser.phone.ToString();

            
            //查詢顧客訂單
            var q = from row in db.orderLine
                    join pData in db.productData on row.product_id equals pData.id
                    where row.orderLine_user_id == GlobalVar.NowUser.id && row.orderDateTime.ToString() == time
                    select new
                    {
                        pName = pData.Name,
                        pQuantity = row.quantity,
                        pPrice = row.price,
                        pTime = row.orderDateTime
                    };
            var userOrder = q.ToList();
            int total = 0;

            //加入listBox
            for (int i = 0; i < userOrder.Count(); i++)
            {
                listBox_orderLine.Items.Add
                (userOrder[i].pName + " " + "x " + userOrder[i].pQuantity + "     " + "NTD " + (userOrder[i].pPrice) * (userOrder[i].pQuantity));
                total += (userOrder[i].pPrice) * (userOrder[i].pQuantity);
            }
            labelTotal.Text = $"總價  NTD {total}";
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            // 新增此筆訂單至table order
            order anOrder = new order
            {
                user_id = GlobalVar.NowUser.id,
                orderDateTime = time,
                ClientAddress = txtBoxAddress.Text,
                ClientName = txtBoxName.Text,
                ClientPhone = Convert.ToInt32(txtBoxPhone.Text)
            };

            db.order.Add(anOrder);
            db.SaveChanges();

            DialogResult result = MessageBox.Show("請確認是否送出訂單", "提示", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                btn_cart.Visible = false;
                btn_menu.Visible = false;
                btn_myFavorite.Visible = false;
                panelCart.Visible = false;
                panel_submitted.Visible = true;
                panel_myFavorite.Visible = false;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void btn_addToMyFav_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已加入我的最愛", "提示");
            myFavorite favProduct = new myFavorite
            {
                myFav_product_id = GlobalVar.NowProduct.id,
                myFav_user_id = GlobalVar.NowUser.id
            };

            db.myFavorite.Add(favProduct);
            db.SaveChanges();
        }
        private void btn_myFavorite_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            change(panel_myFavorite, panelCart, panelMenu_product, panelMenu, btn_myFavorite, btn_cart, btn_menu);
            int width = 220;
            int height = 310;

            // 尋找該位user已加入我的最愛的產品
            var q = from myFav in db.myFavorite
                    join pData in db.productData on myFav.myFav_product_id equals pData.id
                    where myFav.myFav_user_id == GlobalVar.NowUser.id
                    select new
                    {
                        pName = pData.Name,
                        pPrice = pData.price,
                        pImgTag = pData.ImageTag
                    };

            // 加入我的最愛
            for (int i = 0; i < q.ToList().Count(); i++)
            {
                //產生MyPanel
                Panel myPanel = new Panel();
                myPanel.Location = new System.Drawing.Point(3+width, 3);
                myPanel.Name = "myPanel";
                myPanel.Size = new System.Drawing.Size(width, height);
                //myPanel.BackColor = Color.DarkGray;
                myPanel.Margin = new Padding(10);
                myPanel.TabIndex = 0;

                //產生MyBtnAddToCart
                Button MyBtnAddToCart = new Button();
                MyBtnAddToCart.FlatAppearance.BorderSize = 0;
                MyBtnAddToCart.FlatStyle = FlatStyle.Flat;
                MyBtnAddToCart.BackColor = Color.Red;
                MyBtnAddToCart.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136)));
                MyBtnAddToCart.Location = new Point(7, 267);
                MyBtnAddToCart.Name = "MyBtnAddToCart";
                MyBtnAddToCart.Size = new System.Drawing.Size(209, 29);
                MyBtnAddToCart.TabIndex = 4;
                MyBtnAddToCart.Text = "Add To Cart";
                MyBtnAddToCart.UseVisualStyleBackColor = true;
                myPanel.Controls.Add(MyBtnAddToCart);

                //產生 MyNumUpDown
                NumericUpDown MyNumUpDown = new NumericUpDown();
                MyNumUpDown.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136)));
                MyNumUpDown.Location = new System.Drawing.Point(139, 233);
                MyNumUpDown.Name = "MyNumUpDown";
                MyNumUpDown.Size = new System.Drawing.Size(75, 29);
                MyNumUpDown.TabIndex = 3;
                myPanel.Controls.Add(MyNumUpDown);

                //產生 MyLblPprice
                Label MyLblPprice = new Label();
                MyLblPprice.AutoSize = true;
                MyLblPprice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                MyLblPprice.Location = new System.Drawing.Point(8, 237);
                MyLblPprice.Name = "MyLblPprice";
                MyLblPprice.Size = new System.Drawing.Size(114, 20);
                MyLblPprice.TabIndex = 2;
                MyLblPprice.Text = "價格 : NTD " + q.ToList()[i].pPrice;
                myPanel.Controls.Add(MyLblPprice);

                //產生 MyLblPname
                Label MyLblPname = new Label();
                MyLblPname.AutoSize = true;
                MyLblPname.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                MyLblPname.Location = new System.Drawing.Point(8, 204);
                MyLblPname.Name = "MyLblPname1";
                MyLblPname.Size = new System.Drawing.Size(73, 20);
                MyLblPname.TabIndex = 1;
                MyLblPname.Text = $"{q.ToList()[i].pName}";
                myPanel.Controls.Add(MyLblPname);

                // MyPBox1
                PictureBox MyPBox = new PictureBox();
                MyPBox.Image = Image.FromFile(@"meal\" + (q.ToList()[i].pImgTag).ToString()+".jpg");
                MyPBox.Location = new System.Drawing.Point(6, 14);
                MyPBox.Name = "MyPBox1";
                MyPBox.Size = new Size(208, 174);
                MyPBox.SizeMode = PictureBoxSizeMode.Zoom;
                MyPBox.TabIndex = 0;
                MyPBox.TabStop = false;
                myPanel.Controls.Add(MyPBox);

                flowLayoutPanel1.Controls.Add(myPanel);
            }

           
            
        }

        
    }
}
