namespace RestaurantBooking.Forms
{
    partial class CustomerFrm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtAdress = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            label5 = new Label();
            btnAdd = new Button();
            dtGridCustomer = new DataGridView();
            btnDelete = new Button();
            lblCustomerAddress = new Label();
            lbl7 = new Label();
            txtCstmrAdress = new TextBox();
            txtCstmrEmail = new TextBox();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dtGridCustomer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Surname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Adress:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 152);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Phone:";
            // 
            // txtName
            // 
            txtName.Location = new Point(74, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 4;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(74, 64);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(100, 23);
            txtSurname.TabIndex = 5;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(74, 103);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(100, 23);
            txtAdress.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(74, 149);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(74, 192);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 195);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 9;
            label5.Text = "Email:";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 234);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtGridCustomer
            // 
            dtGridCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridCustomer.Location = new Point(190, 26);
            dtGridCustomer.Name = "dtGridCustomer";
            dtGridCustomer.Size = new Size(376, 231);
            dtGridCustomer.TabIndex = 11;
            dtGridCustomer.CellClick += dtGridCustomer_CellClick;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Location = new Point(99, 234);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblCustomerAddress
            // 
            lblCustomerAddress.AutoSize = true;
            lblCustomerAddress.Location = new Point(578, 93);
            lblCustomerAddress.Name = "lblCustomerAddress";
            lblCustomerAddress.Size = new Size(107, 15);
            lblCustomerAddress.TabIndex = 13;
            lblCustomerAddress.Text = "Customer Address:";
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Location = new Point(588, 126);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(94, 15);
            lbl7.TabIndex = 14;
            lbl7.Text = "Customer Email:";
            // 
            // txtCstmrAdress
            // 
            txtCstmrAdress.Location = new Point(688, 90);
            txtCstmrAdress.Name = "txtCstmrAdress";
            txtCstmrAdress.Size = new Size(100, 23);
            txtCstmrAdress.TabIndex = 15;
            // 
            // txtCstmrEmail
            // 
            txtCstmrEmail.Location = new Point(688, 123);
            txtCstmrEmail.Name = "txtCstmrEmail";
            txtCstmrEmail.Size = new Size(100, 23);
            txtCstmrEmail.TabIndex = 16;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(713, 166);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // CustomerFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUpdate);
            Controls.Add(txtCstmrEmail);
            Controls.Add(txtCstmrAdress);
            Controls.Add(lbl7);
            Controls.Add(lblCustomerAddress);
            Controls.Add(btnDelete);
            Controls.Add(dtGridCustomer);
            Controls.Add(btnAdd);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtAdress);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerFrm";
            Text = "CustomerFrm";
            Load += CustomerFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dtGridCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtAdress;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Label label5;
        private Button btnAdd;
        private DataGridView dtGridCustomer;
        private Button btnDelete;
        private Label lblCustomerAddress;
        private Label lbl7;
        private TextBox txtCstmrAdress;
        private TextBox txtCstmrEmail;
        private Button btnUpdate;
    }
}