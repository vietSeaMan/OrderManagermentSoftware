using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Order_Managerment_For_Photography_Studio
{
    public partial class SearchForm : Form
    {
        bool saveCheck = true;
        List<Order> mainOrderList = HomeScreen.orderList;
        public SearchForm()
        {
            InitializeComponent();
        }

        private void showResult(Order order, int shilt)
        {
         

            RichTextBox note = new RichTextBox();
            this.panel1.Controls.Add(note);
            Label payment = new Label();
            this.panel1.Controls.Add(payment);
            TextBox totalFee = new TextBox();
            this.panel1.Controls.Add(totalFee);
            DateTimePicker orderDate = new DateTimePicker();
            this.panel1.Controls.Add(orderDate);
            TextBox customerName = new TextBox();
            this.panel1.Controls.Add(customerName);
            TextBox orderCode = new TextBox();
            this.panel1.Controls.Add(orderCode);
            Label Line = new Label();
            this.panel1.Controls.Add(Line);
            Button preview = new Button();
            this.panel1.Controls.Add(preview);
            Button updateInfo = new Button();
            this.panel1.Controls.Add(updateInfo);


            // 
            // note
            // 
            note.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            note.Location = new System.Drawing.Point(766, 21 + shilt);
            note.ReadOnly = true;
            note.Size = new System.Drawing.Size(157, 80);
            note.Text = order.Note;
            note.DoubleClick += delegate
            {
                saveCheck = false;
                note.BackColor = System.Drawing.Color.GreenYellow;
                note.ReadOnly = false;
            };
            // 
            // payment
            // 
            if (order.Payment) payment.Image = global::Order_Managerment_For_Photography_Studio.Properties.Resources._299110_check_sign_icon;
            else payment.Image = global::Order_Managerment_For_Photography_Studio.Properties.Resources._1282956_close_delete_deny_no_out_icon;
            payment.Location = new System.Drawing.Point(707, 45 + shilt);
            
            payment.Size = new System.Drawing.Size(53, 46);
            payment.Click += delegate
            {
                saveCheck = false;
                if (order.Payment)
                {
                    order.Payment = false;
                    payment.Image = global::Order_Managerment_For_Photography_Studio.Properties.Resources._1282956_close_delete_deny_no_out_icon;
                }
                else
                {
                    order.Payment = true;
                    payment.Image = global::Order_Managerment_For_Photography_Studio.Properties.Resources._299110_check_sign_icon;

                }
            };

            // 
            // orderDate
            // 
            
            orderDate.Value = Convert.ToDateTime(order.OrderDate);
            orderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            orderDate.Location = new System.Drawing.Point(361, 59 + shilt);
            orderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            orderDate.Size = new System.Drawing.Size(164, 17);
            orderDate.Enabled = true;
            orderDate.CloseUp += delegate
            {
                saveCheck = false;
                orderDate.CalendarTitleForeColor = System.Drawing.Color.GreenYellow;
            };
            
            // 
            // orderCode
            // 
            orderCode.BackColor = System.Drawing.Color.Yellow;
            orderCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            orderCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            orderCode.Location = new System.Drawing.Point(15, 59 + shilt); 
            orderCode.ReadOnly = true;
            orderCode.Size = new System.Drawing.Size(164, 17);
            orderCode.Text = ""+order.OrderCode;

            // 
            // totalFee
            // 
            totalFee.BackColor = System.Drawing.Color.White;
            totalFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            totalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            totalFee.Location = new System.Drawing.Point(534, 59 + shilt);
            totalFee.ReadOnly = true;
            totalFee.Size = new System.Drawing.Size(164, 17);
            totalFee.Text = "" + order.TotalFee;
            totalFee.DoubleClick += delegate
            {
                saveCheck = false;
                totalFee.ReadOnly = false;
                totalFee.BackColor = System.Drawing.Color.GreenYellow;
            };
            // 
            // customerName
            // 
            customerName.BackColor = System.Drawing.Color.White;
            customerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            customerName.Location = new System.Drawing.Point(188, 59 + shilt);
            customerName.ReadOnly = true;
            customerName.Size = new System.Drawing.Size(164, 17);
            customerName.Text = order.CustomerName;
            customerName.DoubleClick += delegate
            {
                saveCheck = false;
                customerName.ReadOnly = false;
                customerName.BackColor = System.Drawing.Color.GreenYellow;
            };
            // 
            // preview button
            // 
            preview.Location = new System.Drawing.Point(15, 80 + shilt);
            preview.Size = new System.Drawing.Size(111, 23);
            preview.Text = "preview";
            preview.UseVisualStyleBackColor = true;
            preview.Click += delegate
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
            // 
            // updateInfo button
            // 
            updateInfo.Location = new System.Drawing.Point(534, 80 + shilt);
            updateInfo.Size = new System.Drawing.Size(111, 23);
            updateInfo.Text = "Cập nhập thông tin";
            updateInfo.UseVisualStyleBackColor = true;
            updateInfo.Click += delegate
            {
                order.CustomerName = customerName.Text;
                order.OrderDate = orderDate.Text;
                order.OrderCode = Convert.ToInt32(orderCode.Text);
                order.TotalFee = Convert.ToInt32(totalFee.Text);
                order.Note = note.Text;

                customerName.BackColor = System.Drawing.Color.White;
                totalFee.BackColor = System.Drawing.Color.White;
                orderDate.CalendarTitleForeColor = System.Drawing.Color.White;
                note.BackColor = System.Drawing.Color.White;

                saveCheck = true;
                MessageBox.Show("Cập nhập thành công!");
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();

            this.label1.Refresh();
        
            List<Order> searchList = null;
            if(this.searchByNameCheckBox.Checked && !this.searcByDataCheckBox.Checked)
            {
                searchList = mainProcess.findOrderbyName(mainOrderList, this.customerNameSeach.Text);
            }
            else if (!this.searchByNameCheckBox.Checked && this.searcByDataCheckBox.Checked)
            {
                searchList = mainProcess.findOrderByDate(mainOrderList, this.orderDateSearch.Text);
            }
            else if(this.searchByNameCheckBox.Checked && this.searcByDataCheckBox.Checked)
            {
                searchList = mainProcess.findOrder(mainOrderList, this.customerNameSeach.Text, this.orderDateSearch.Text);
            }
            

            if (searchList == null)
            {
                MessageBox.Show("Not found any order!");
                return;
            }
               
            else
            {
                int shilt = 0;
                foreach(Order order in searchList)
                {
                    showResult(order, shilt);
                    shilt += 95;
                }
                
            }
            searchList.Clear();

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            this.orderDateSearch.Value = DateTime.Today;
        }

        

        private void SaveAndExit_Click(object sender, EventArgs e)
        {
            if (!saveCheck)
                MessageBox.Show("Bạn chưa lưu thông tin vừa sửa đổi!");
            else
            {
                List<String> stringList = new List<String>();
                foreach (Order order in mainOrderList)
                {
                    stringList.Add(order.ToString());
                }
                HomeScreen.file.writeAllToFile(stringList);
                MessageBox.Show("Cập nhập thông tin thành công!");
                this.Close();
            }
            

        }

        private void CancelAndExti_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
