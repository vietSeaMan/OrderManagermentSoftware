using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Order_Managerment_For_Photography_Studio
{
    public partial class HomeScreen : Form
    {
        
        public static List<Order> orderList = new List<Order>();
        public static ExternalFile file = new ExternalFile();
        public HomeScreen()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateForm crForm = new CreateForm();
            crForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchForm srForm = new SearchForm();
            srForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AboutForm abForm = new AboutForm();
            abForm.Show();
        }

        public void loadButton_Click(object sender, EventArgs e)
        {
            orderList.Clear();
            this.panel1.Controls.Clear();
            mainProcess.getDataFromFile(orderList, file);
            int shift = 0;
            foreach (Order order in orderList)
            {
                showData(order, shift);
                shift += 100;
            }
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            mainProcess.getDataFromFile(orderList, file);
            int shift = 0;
            foreach (Order order in orderList)
            {
                showData(order, shift);
                shift += 100;
            }
            this.KeyPreview = true;
        }

        private void showData(Order order, int shift)
        {
            Label note = new Label();
            this.panel1.Controls.Add(note);
            Label payment = new Label();
            this.panel1.Controls.Add(payment);
            Label totalFee = new Label();
            this.panel1.Controls.Add(totalFee);
            Label orderDate = new Label();
            this.panel1.Controls.Add(orderDate);
            Label customerName = new Label();
            this.panel1.Controls.Add(customerName);
            Label orderCode = new Label();
            this.panel1.Controls.Add(orderCode);
            Label Line = new Label();
            this.panel1.Controls.Add(Line);
            Button showPreview = new Button();
            this.panel1.Controls.Add(showPreview);

            // 
            // note
            // 
            note.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            note.BackColor = Color.White;
            note.Location = new System.Drawing.Point(680, 10 + shift);
            note.Name = "note";
            note.Size = new System.Drawing.Size(184, 73);
            note.TabIndex = 5;
            note.Text = order.Note;
            note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // payment
            // 
            payment.Location = new System.Drawing.Point(590, 20 + shift);
            payment.Size = new System.Drawing.Size(50, 46);
            payment.TabIndex = 4;
            if (order.Payment) payment.Image = global::Order_Managerment_For_Photography_Studio.Properties.Resources._299110_check_sign_icon;
            else payment.Image = global::Order_Managerment_For_Photography_Studio.Properties.Resources._1282956_close_delete_deny_no_out_icon;
            // 
            // totalFee
            // 
            totalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalFee.Location = new System.Drawing.Point(406, 36 + shift);
            totalFee.BackColor = Color.White;
            totalFee.Size = new System.Drawing.Size(113, 21);
            totalFee.TabIndex = 3;
            totalFee.Text = order.TotalFee + " VND";
            totalFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderDate
            // 
            orderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            orderDate.Location = new System.Drawing.Point(285, 36 + shift);
            orderDate.BackColor = Color.White;
            orderDate.Size = new System.Drawing.Size(115, 21);
            orderDate.TabIndex = 2;
            orderDate.Text = order.OrderDate;
            orderDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showPreview
            // 
            showPreview.BackColor = Color.White;
            showPreview.Location = new System.Drawing.Point(285, 60 + shift);
            //Click button
            showPreview.Click += delegate
            {
                try
                {
                    this.previewImage.BackgroundImage = Image.FromFile(order.PathOfImage);
                }
                catch (Exception)
                {
                    MessageBox.Show("File Not Found!");  
                }
                
            };
            showPreview.Size = new System.Drawing.Size(115, 21);
            showPreview.Text = "Preview";
            // 
            // customerName
            // 
            customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerName.Location = new System.Drawing.Point(138, 36 + shift);
            customerName.BackColor = Color.White;
            customerName.Size = new System.Drawing.Size(137, 21);
            customerName.TabIndex = 1;
            customerName.Text = order.CustomerName;
            customerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // orderCode
            // 
            orderCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            orderCode.Location = new System.Drawing.Point(12, 36 + shift);
            orderCode.BackColor = Color.White;
            orderCode.Size = new System.Drawing.Size(118, 21);
            orderCode.TabIndex = 0;
            orderCode.Text = ""+order.OrderCode;
            orderCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        }

        private void HomeScreen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                button1_Click(sender, e);

            if (e.KeyCode == Keys.F3) 
                button2_Click(sender, e);

            if (e.KeyCode == Keys.F5) 
                loadButton_Click(sender, e);

            if (e.KeyCode == Keys.F1) 
                button3_Click(sender, e);
        }

       
    }
}
