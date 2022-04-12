///Use this form for search and edit function
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
        //check the new information is saved or not
        bool saveCheck = true;
        //get the Order List form HomeScreen class
        List<Order> mainOrderList = HomeScreen.orderList;
        public SearchForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Show the result of after search
        /// </summary>
        /// <param name="order"></param>
        /// <param name="shilt"></param>
        private void showResult(Order order, int shilt)
        {
         
            //Create new panel to show in formation 
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
            //Get Double Click event
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
            //Get Double Click event
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
            //Get Double Click event
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
            //Get Double Click event
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
            //Get Click event to show preview image
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
            //Click button to save all new data to this.object (Order object)
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

        /// <summary>
        /// Search button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //clear the old result 
            this.panel1.Controls.Clear();
            //Create a list to store result of order 
            List<Order> searchList = null;

            //Search by Name
            if(this.searchByNameCheckBox.Checked && !this.searcByDataCheckBox.Checked)
            {
                searchList = mainProcess.findOrderbyName(mainOrderList, this.customerNameSeach.Text);
            }
            //Search by Date
            else if (!this.searchByNameCheckBox.Checked && this.searcByDataCheckBox.Checked)
            {
                searchList = mainProcess.findOrderByDate(mainOrderList, this.orderDateSearch.Text);
            }
            //Search by name and date
            else if(this.searchByNameCheckBox.Checked && this.searcByDataCheckBox.Checked)
            {
                searchList = mainProcess.findOrder(mainOrderList, this.customerNameSeach.Text, this.orderDateSearch.Text);
            }
            
            //Show the message if have no order found
            if (searchList == null)
            {
                MessageBox.Show("Not found any order!");
                return;
            } 
            //if oreder is found then show them to screen
            else
            {
                int shiltOfRow = 0;
                foreach(Order order in searchList)
                {
                    //Call showResult method
                    showResult(order, shiltOfRow);
                    //Shilt of Row when the result be showed
                    shiltOfRow += 95;
                }
                
            }
            //Reset searchList for the next other search
            searchList.Clear();

        }
        /// <summary>
        /// Set value of Date search 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchForm_Load(object sender, EventArgs e)
        {
            this.orderDateSearch.Value = DateTime.Today;
        }

        
        /// <summary>
        /// Save and exit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveAndExit_Click(object sender, EventArgs e)
        {
            if (!saveCheck)
                MessageBox.Show("Bạn chưa lưu thông tin vừa sửa đổi!");
            else
            {
                //create new String list to save data to file
                List<String> stringList = new List<String>();
                foreach (Order order in mainOrderList)
                {
                    stringList.Add(order.ToString());
                }
                //Call write data to FIle method from file object in HomeScreen class
                HomeScreen.file.writeAllToFile(stringList);
                MessageBox.Show("Cập nhập thông tin thành công!");
                this.Close();
            }
            

        }
        /// <summary>
        /// Cancel and Exit button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelAndExti_Click(object sender, EventArgs e)
        {   
            
            this.Close();
        }
    }
}
