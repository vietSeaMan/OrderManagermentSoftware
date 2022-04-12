
//The user will use this from to create a new order and save it to file
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
    public partial class CreateForm : Form
    {

        public CreateForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button for create new order code after have enough information liek name, date,...
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createOrderCodeButton_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.customerNamel.Text) || String.IsNullOrEmpty(this.orderDate.Text))
                MessageBox.Show("Please fill the name and Order Date box:");
            else
            {
                String componentString = this.customerNamel.Text + this.orderDate.Text;

                var odCode = Math.Abs(componentString.GetHashCode());
                this.orderCode.Text = odCode + "";
            }
        }

        /// <summary>
        /// method is run when ok Button of the Open dialog is click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rootFile_FileOk(object sender, CancelEventArgs e)
        {
            this.rootImageBox.BackgroundImage = Image.FromFile(this.rootFile.FileName);
        }

        /// <summary>
        /// Show Open Dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void upRootFile_Click_1(object sender, EventArgs e)
        {
            this.rootFile.ShowDialog();
        }

        /// <summary>
        /// Create new order Code and save to the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createNewOrderButton_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(this.orderCode.Text))
            {
                MessageBox.Show("Not enough information to create a new Order.");
            }
            else
            {
                String customerName = this.customerNamel.Text;
                String orderDate = this.orderDate.Text;
                
                int totalFee = Convert.ToInt32(this.totalPrice.Text);

                Boolean payment = false;
                if (this.payment.Checked) payment = true;
                if (this.notPaymentYet.Checked) payment = false;

                int orderCode = Convert.ToInt32(this.orderCode.Text);
                String note = this.noteTextBox.Text;
                String pathOfImage = this.rootFile.FileName;

               //Create new Order object to store information of new order
                Order newOrder = new Order(customerName, orderDate, totalFee, payment, orderCode, note, pathOfImage);

                //Add new Order object to orderList
                HomeScreen.orderList.Add(newOrder);
                //Write data append to file
                HomeScreen.file.writeLineToFile(newOrder.ToString());

                MessageBox.Show("Tạo đơn hàng mới thành công!");
                this.Close();
  
            }
        }

        /// <summary>
        /// check the format of total price data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void totalPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = Convert.ToInt32(this.totalPrice.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Total price must be a number!");
            }
        }

        /// <summary>
        /// Reset all information in all field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetAllFieldButton_Click(object sender, EventArgs e)
        {
            this.customerNamel.Text = "";
            this.orderDate.Text = "";
            this.totalPrice.Text = "";
            this.orderCode.Text = "";
            this.noteTextBox.Text = "";
        }
    }
}
