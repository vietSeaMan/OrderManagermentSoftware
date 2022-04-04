namespace Order_Managerment_For_Photography_Studio
{
    partial class SearchForm
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
            this.customerNameSeach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderDateSearch = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SaveAndExit = new System.Windows.Forms.Button();
            this.CancelAndExti = new System.Windows.Forms.Button();
            this.searcByDataCheckBox = new System.Windows.Forms.CheckBox();
            this.searchByNameCheckBox = new System.Windows.Forms.CheckBox();
            this.previewImage = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameSeach
            // 
            this.customerNameSeach.Location = new System.Drawing.Point(322, 74);
            this.customerNameSeach.Name = "customerNameSeach";
            this.customerNameSeach.Size = new System.Drawing.Size(314, 20);
            this.customerNameSeach.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên khách hàng cần tìm kiếm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm và chỉnh sửa";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(101, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 495);
            this.panel1.TabIndex = 3;
            // 
            // orderDateSearch
            // 
            this.orderDateSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.orderDateSearch.Location = new System.Drawing.Point(850, 73);
            this.orderDateSearch.Name = "orderDateSearch";
            this.orderDateSearch.Size = new System.Drawing.Size(200, 20);
            this.orderDateSearch.TabIndex = 4;
            this.orderDateSearch.Value = new System.DateTime(2022, 4, 3, 11, 24, 59, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(663, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chọn ngày cần tìm kiếm:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1072, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveAndExit
            // 
            this.SaveAndExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAndExit.Location = new System.Drawing.Point(509, 664);
            this.SaveAndExit.Name = "SaveAndExit";
            this.SaveAndExit.Size = new System.Drawing.Size(178, 32);
            this.SaveAndExit.TabIndex = 7;
            this.SaveAndExit.Text = "Lưu thông tin và thoát";
            this.SaveAndExit.UseVisualStyleBackColor = true;
            this.SaveAndExit.Click += new System.EventHandler(this.SaveAndExit_Click);
            // 
            // CancelAndExti
            // 
            this.CancelAndExti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelAndExti.Location = new System.Drawing.Point(703, 664);
            this.CancelAndExti.Name = "CancelAndExti";
            this.CancelAndExti.Size = new System.Drawing.Size(159, 32);
            this.CancelAndExti.TabIndex = 8;
            this.CancelAndExti.Text = "Hủy thay đổi";
            this.CancelAndExti.UseVisualStyleBackColor = true;
            this.CancelAndExti.Click += new System.EventHandler(this.CancelAndExti_Click);
            // 
            // searcByDataCheckBox
            // 
            this.searcByDataCheckBox.AutoSize = true;
            this.searcByDataCheckBox.Location = new System.Drawing.Point(850, 101);
            this.searcByDataCheckBox.Name = "searcByDataCheckBox";
            this.searcByDataCheckBox.Size = new System.Drawing.Size(118, 17);
            this.searcByDataCheckBox.TabIndex = 9;
            this.searcByDataCheckBox.Text = "Tìm kiếm theo ngày";
            this.searcByDataCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchByNameCheckBox
            // 
            this.searchByNameCheckBox.AutoSize = true;
            this.searchByNameCheckBox.Location = new System.Drawing.Point(322, 100);
            this.searchByNameCheckBox.Name = "searchByNameCheckBox";
            this.searchByNameCheckBox.Size = new System.Drawing.Size(110, 17);
            this.searchByNameCheckBox.TabIndex = 10;
            this.searchByNameCheckBox.Text = "Tìm kiếm theo tên";
            this.searchByNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // previewImage
            // 
            this.previewImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.previewImage.Location = new System.Drawing.Point(1072, 124);
            this.previewImage.Name = "previewImage";
            this.previewImage.Size = new System.Drawing.Size(249, 186);
            this.previewImage.TabIndex = 6;
            this.previewImage.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(98, 630);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(761, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Note: Nhấn đúp chuột vào thông tin cần thay đổi để chỉnh sửa. (Ô màu vàng không c" +
    "ho phép thay đổi thông tin)";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1333, 742);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchByNameCheckBox);
            this.Controls.Add(this.searcByDataCheckBox);
            this.Controls.Add(this.CancelAndExti);
            this.Controls.Add(this.SaveAndExit);
            this.Controls.Add(this.previewImage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.orderDateSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerNameSeach);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.previewImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerNameSeach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker orderDateSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox previewImage;
        private System.Windows.Forms.Button SaveAndExit;
        private System.Windows.Forms.Button CancelAndExti;
        private System.Windows.Forms.CheckBox searcByDataCheckBox;
        private System.Windows.Forms.CheckBox searchByNameCheckBox;
        private System.Windows.Forms.Label label4;
    }
}