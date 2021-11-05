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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        OrderSystemDBEntities9 db = new OrderSystemDBEntities9();
        private void Form3_Load(object sender, EventArgs e)
        {
            var q = from item in db.productData
                    select item;

            for (int i = 0; i < q.ToList().Count(); i++)
            {
                //產生MyPanel
                Panel myPanel = new Panel();
                myPanel.Location = new System.Drawing.Point(3, 3);
                myPanel.Name = "myPanel";
                myPanel.Size = new System.Drawing.Size(220, 310);
                myPanel.Margin = new Padding(10);
                myPanel.TabIndex = 0;

                //產生MyBtnAddToCart
                //Button MyBtnAddToCart = new Button();
                //MyBtnAddToCart.FlatAppearance.BorderSize = 0;
                //MyBtnAddToCart.FlatStyle = FlatStyle.Flat;
                //MyBtnAddToCart.BackColor = Color.Red;
                //MyBtnAddToCart.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136)));
                //MyBtnAddToCart.Location = new Point(7, 267);
                //MyBtnAddToCart.Name = "MyBtnAddToCart";
                //MyBtnAddToCart.Size = new System.Drawing.Size(209, 29);
                //MyBtnAddToCart.TabIndex = 4;
                //MyBtnAddToCart.Text = "Add To Cart";
                //MyBtnAddToCart.UseVisualStyleBackColor = true;
                //myPanel.Controls.Add(MyBtnAddToCart);

                //產生 MyNumUpDown
                //NumericUpDown MyNumUpDown = new NumericUpDown();
                //MyNumUpDown.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136)));
                //MyNumUpDown.Location = new System.Drawing.Point(139, 233);
                //MyNumUpDown.Name = "MyNumUpDown";
                //MyNumUpDown.Size = new System.Drawing.Size(75, 29);
                //MyNumUpDown.TabIndex = 3;
                //myPanel.Controls.Add(MyNumUpDown);

                //產生 MyLblPprice
                Label MyLblPprice = new Label();
                MyLblPprice.AutoSize = true;
                MyLblPprice.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                MyLblPprice.Location = new System.Drawing.Point(8, 237);
                MyLblPprice.Name = "MyLblPprice";
                MyLblPprice.Size = new System.Drawing.Size(114, 20);
                MyLblPprice.TabIndex = 2;
                MyLblPprice.Text = "價格 : NTD " + q.ToList()[i].price;
                myPanel.Controls.Add(MyLblPprice);

                //產生 MyLblPname
                Label MyLblPname = new Label();
                MyLblPname.AutoSize = true;
                MyLblPname.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
                MyLblPname.Location = new System.Drawing.Point(8, 204);
                MyLblPname.Name = "MyLblPname1";
                MyLblPname.Size = new System.Drawing.Size(73, 20);
                MyLblPname.TabIndex = 1;
                MyLblPname.Text = $"{q.ToList()[i].Name}";
                myPanel.Controls.Add(MyLblPname);

                // MyPBox1
                PictureBox MyPBox = new PictureBox();
                MyPBox.Image = Image.FromFile(@"meal\" + (q.ToList()[i].ImageTag).ToString() + ".jpg");
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

        private void btn_addData_Click(object sender, EventArgs e)
        {
            panel_addData.Visible = true;
            flowLayoutPanel1.Visible = false;
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            panel_addData.Visible = false;
            flowLayoutPanel1.Visible = true;
        }
    }
}
