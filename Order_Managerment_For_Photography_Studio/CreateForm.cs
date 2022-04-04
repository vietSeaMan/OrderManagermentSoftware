
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

        private void rootFile_FileOk(object sender, CancelEventArgs e)
        {
            this.rootImageBox.BackgroundImage = Image.FromFile(this.rootFile.FileName);
        }

        private void upRootFile_Click_1(object sender, EventArgs e)
        {
            this.rootFile.ShowDialog();
        }

        private void upEditedFile_Click(object sender, EventArgs e)
        {
            this.editedFile.ShowDialog();
        }

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

                Order newOrder = new Order(customerName, orderDate, totalFee, payment, orderCode, note, pathOfImage);

                HomeScreen.orderList.Add(newOrder);

                HomeScreen.file.writeLineToFile(newOrder.ToString());

                MessageBox.Show("Tạo đơn hàng mới thành công!");
                this.Close();
  
            }
        }

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
