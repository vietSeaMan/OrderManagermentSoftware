namespace Order_Managerment_For_Photography_Studio
{
    partial class CreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            this.label1 = new System.Windows.Forms.Label();
            this.customerNamel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.orderCode = new System.Windows.Forms.TextBox();
            this.createOrderCodeButton = new System.Windows.Forms.Button();
            this.orderDate = new System.Windows.Forms.DateTimePicker();
            this.totalPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.upRootFile = new System.Windows.Forms.Button();
            this.rootFile = new System.Windows.Forms.OpenFileDialog();
            this.editedFile = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.noteTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.payment = new System.Windows.Forms.RadioButton();
            this.notPaymentYet = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rootImageBox = new System.Windows.Forms.PictureBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.resetAllFieldButton = new System.Windows.Forms.Button();
            this.createNewOrderButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rootImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Tên khách hàng (Name):";
            // 
            // customerNamel
            // 
            this.customerNamel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNamel.Location = new System.Drawing.Point(276, 33);
            this.customerNamel.Name = "customerNamel";
            this.customerNamel.Size = new System.Drawing.Size(200, 26);
            this.customerNamel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "*Ngày chụp (Order Date):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng thanh toán (Total):";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 42);
            this.label5.TabIndex = 7;
            this.label5.Text = "Trạng thái thanh toán (Payment Status ):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã đơn hàng (Code):";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.orderCode);
            this.flowLayoutPanel1.Controls.Add(this.createOrderCodeButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(276, 204);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(214, 67);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // orderCode
            // 
            this.orderCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderCode.Location = new System.Drawing.Point(3, 3);
            this.orderCode.Name = "orderCode";
            this.orderCode.ReadOnly = true;
            this.orderCode.Size = new System.Drawing.Size(200, 26);
            this.orderCode.TabIndex = 13;
            // 
            // createOrderCodeButton
            // 
            this.createOrderCodeButton.Location = new System.Drawing.Point(3, 35);
            this.createOrderCodeButton.Name = "createOrderCodeButton";
            this.createOrderCodeButton.Size = new System.Drawing.Size(171, 32);
            this.createOrderCodeButton.TabIndex = 10;
            this.createOrderCodeButton.Text = "Tạo mã đơn hàng (Create code)";
            this.createOrderCodeButton.UseVisualStyleBackColor = true;
            this.createOrderCodeButton.Click += new System.EventHandler(this.createOrderCodeButton_Click_1);
            // 
            // orderDate
            // 
            this.orderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.orderDate.Location = new System.Drawing.Point(276, 77);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(200, 20);
            this.orderDate.TabIndex = 11;
            this.orderDate.Value = System.DateTime.Today;
            // 
            // totalPrice
            // 
            this.totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice.Location = new System.Drawing.Point(3, 3);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(156, 26);
            this.totalPrice.TabIndex = 11;
            this.totalPrice.TextChanged += new System.EventHandler(this.totalPrice_TextChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(165, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "VNĐ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upRootFile
            // 
            this.upRootFile.Location = new System.Drawing.Point(221, 412);
            this.upRootFile.Name = "upRootFile";
            this.upRootFile.Size = new System.Drawing.Size(75, 23);
            this.upRootFile.TabIndex = 16;
            this.upRootFile.Text = "Tải lên";
            this.upRootFile.UseVisualStyleBackColor = true;
            this.upRootFile.Click += new System.EventHandler(this.upRootFile_Click_1);
            // 
            // rootFile
            // 
            this.rootFile.FileName = "openFileDialog1";
            this.rootFile.FileOk += new System.ComponentModel.CancelEventHandler(this.rootFile_FileOk);
            // 
            // editedFile
            // 
            this.editedFile.FileName = "openFileDialog1";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.totalPrice);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(276, 116);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(214, 32);
            this.flowLayoutPanel2.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(144, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 21);
            this.label10.TabIndex = 20;
            this.label10.Text = "Ghi chú (Note):";
            // 
            // noteTextBox
            // 
            this.noteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noteTextBox.Location = new System.Drawing.Point(276, 289);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(312, 166);
            this.noteTextBox.TabIndex = 18;
            this.noteTextBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.payment);
            this.groupBox1.Controls.Add(this.notPaymentYet);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.customerNamel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Controls.Add(this.orderDate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.noteTextBox);
            this.groupBox1.Location = new System.Drawing.Point(33, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 493);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Location = new System.Drawing.Point(279, 177);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(93, 17);
            this.payment.TabIndex = 25;
            this.payment.TabStop = true;
            this.payment.Text = "Đã thanh toán";
            this.payment.UseVisualStyleBackColor = true;
            // 
            // notPaymentYet
            // 
            this.notPaymentYet.AutoSize = true;
            this.notPaymentYet.Location = new System.Drawing.Point(279, 155);
            this.notPaymentYet.Name = "notPaymentYet";
            this.notPaymentYet.Size = new System.Drawing.Size(104, 17);
            this.notPaymentYet.TabIndex = 24;
            this.notPaymentYet.TabStop = true;
            this.notPaymentYet.Text = "Chưa thanh toán";
            this.notPaymentYet.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 471);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Các mục có dấu * không được để chống!";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.rootImageBox);
            this.groupBox2.Controls.Add(this.upRootFile);
            this.groupBox2.Location = new System.Drawing.Point(726, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 493);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File ảnh chụp";
            // 
            // rootImageBox
            // 
            this.rootImageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rootImageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rootImageBox.Location = new System.Drawing.Point(28, 36);
            this.rootImageBox.Name = "rootImageBox";
            this.rootImageBox.Size = new System.Drawing.Size(467, 358);
            this.rootImageBox.TabIndex = 12;
            this.rootImageBox.TabStop = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.Red;
            this.cancelButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelButton.Image")));
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.Location = new System.Drawing.Point(770, 546);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(167, 62);
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Hủy (Cancel)";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // resetAllFieldButton
            // 
            this.resetAllFieldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetAllFieldButton.ForeColor = System.Drawing.Color.Black;
            this.resetAllFieldButton.Image = ((System.Drawing.Image)(resources.GetObject("resetAllFieldButton.Image")));
            this.resetAllFieldButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resetAllFieldButton.Location = new System.Drawing.Point(633, 546);
            this.resetAllFieldButton.Name = "resetAllFieldButton";
            this.resetAllFieldButton.Size = new System.Drawing.Size(131, 62);
            this.resetAllFieldButton.TabIndex = 19;
            this.resetAllFieldButton.Text = "Reset";
            this.resetAllFieldButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resetAllFieldButton.UseVisualStyleBackColor = true;
            this.resetAllFieldButton.Click += new System.EventHandler(this.resetAllFieldButton_Click);
            // 
            // createNewOrderButton
            // 
            this.createNewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewOrderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.createNewOrderButton.Image = ((System.Drawing.Image)(resources.GetObject("createNewOrderButton.Image")));
            this.createNewOrderButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createNewOrderButton.Location = new System.Drawing.Point(460, 546);
            this.createNewOrderButton.Name = "createNewOrderButton";
            this.createNewOrderButton.Size = new System.Drawing.Size(167, 62);
            this.createNewOrderButton.TabIndex = 18;
            this.createNewOrderButton.Text = "Tạo (Create)";
            this.createNewOrderButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createNewOrderButton.UseVisualStyleBackColor = true;
            this.createNewOrderButton.Click += new System.EventHandler(this.createNewOrderButton_Click);
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1323, 625);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.resetAllFieldButton);
            this.Controls.Add(this.createNewOrderButton);
            this.Name = "CreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rootImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerNamel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox orderCode;
        private System.Windows.Forms.TextBox totalPrice;
        private System.Windows.Forms.Button createOrderCodeButton;
        private System.Windows.Forms.DateTimePicker orderDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox rootImageBox;
        private System.Windows.Forms.Button upRootFile;
        private System.Windows.Forms.OpenFileDialog rootFile;
        private System.Windows.Forms.OpenFileDialog editedFile;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.RichTextBox noteTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button createNewOrderButton;
        private System.Windows.Forms.Button resetAllFieldButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton payment;
        private System.Windows.Forms.RadioButton notPaymentYet;
    }
}