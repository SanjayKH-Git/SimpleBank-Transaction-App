namespace Bank_Transaction
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.acc_no_lb = new System.Windows.Forms.Label();
            this.Login_Panel = new System.Windows.Forms.Panel();
            this.Login_Btn = new System.Windows.Forms.Button();
            this.pswd = new System.Windows.Forms.TextBox();
            this.acc_no = new System.Windows.Forms.TextBox();
            this.pswd_lb = new System.Windows.Forms.Label();
            this.Home_Panel = new System.Windows.Forms.Panel();
            this.logout_Btn = new System.Windows.Forms.Button();
            this.Bal_lb = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Bal_Btn = new System.Windows.Forms.Button();
            this.send_Btn = new System.Windows.Forms.Button();
            this.Transaction_Panel = new System.Windows.Forms.Panel();
            this.send_cnf_Btn = new System.Windows.Forms.Button();
            this.Target_Account_No = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Transfer_Amount = new System.Windows.Forms.TextBox();
            this.deb_acc_no = new System.Windows.Forms.TextBox();
            this.Target_lb = new System.Windows.Forms.Label();
            this.tf_lb = new System.Windows.Forms.Label();
            this.deb_lb = new System.Windows.Forms.Label();
            this.cancel_Btn = new System.Windows.Forms.Button();
            this.Login_Panel.SuspendLayout();
            this.Home_Panel.SuspendLayout();
            this.Transaction_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To MyBankApp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login to get Services";
            // 
            // acc_no_lb
            // 
            this.acc_no_lb.AutoSize = true;
            this.acc_no_lb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acc_no_lb.Location = new System.Drawing.Point(22, 94);
            this.acc_no_lb.Name = "acc_no_lb";
            this.acc_no_lb.Size = new System.Drawing.Size(92, 20);
            this.acc_no_lb.TabIndex = 2;
            this.acc_no_lb.Text = "Account No";
            // 
            // Login_Panel
            // 
            this.Login_Panel.Controls.Add(this.Login_Btn);
            this.Login_Panel.Controls.Add(this.pswd);
            this.Login_Panel.Controls.Add(this.acc_no_lb);
            this.Login_Panel.Controls.Add(this.label2);
            this.Login_Panel.Controls.Add(this.acc_no);
            this.Login_Panel.Controls.Add(this.label1);
            this.Login_Panel.Controls.Add(this.pswd_lb);
            this.Login_Panel.Location = new System.Drawing.Point(21, 11);
            this.Login_Panel.Name = "Login_Panel";
            this.Login_Panel.Size = new System.Drawing.Size(381, 240);
            this.Login_Panel.TabIndex = 4;
            // 
            // Login_Btn
            // 
            this.Login_Btn.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Btn.Location = new System.Drawing.Point(195, 182);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(86, 32);
            this.Login_Btn.TabIndex = 8;
            this.Login_Btn.Text = "Login";
            this.Login_Btn.UseVisualStyleBackColor = true;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // pswd
            // 
            this.pswd.Location = new System.Drawing.Point(142, 139);
            this.pswd.Name = "pswd";
            this.pswd.Size = new System.Drawing.Size(204, 20);
            this.pswd.TabIndex = 7;
            // 
            // acc_no
            // 
            this.acc_no.Location = new System.Drawing.Point(142, 96);
            this.acc_no.Name = "acc_no";
            this.acc_no.Size = new System.Drawing.Size(204, 20);
            this.acc_no.TabIndex = 5;
            // 
            // pswd_lb
            // 
            this.pswd_lb.AutoSize = true;
            this.pswd_lb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswd_lb.Location = new System.Drawing.Point(38, 137);
            this.pswd_lb.Name = "pswd_lb";
            this.pswd_lb.Size = new System.Drawing.Size(76, 20);
            this.pswd_lb.TabIndex = 4;
            this.pswd_lb.Text = "password";
            // 
            // Home_Panel
            // 
            this.Home_Panel.Controls.Add(this.logout_Btn);
            this.Home_Panel.Controls.Add(this.Bal_lb);
            this.Home_Panel.Controls.Add(this.label5);
            this.Home_Panel.Controls.Add(this.label4);
            this.Home_Panel.Controls.Add(this.Bal_Btn);
            this.Home_Panel.Controls.Add(this.send_Btn);
            this.Home_Panel.Location = new System.Drawing.Point(13, 258);
            this.Home_Panel.Name = "Home_Panel";
            this.Home_Panel.Size = new System.Drawing.Size(402, 191);
            this.Home_Panel.TabIndex = 5;
            // 
            // logout_Btn
            // 
            this.logout_Btn.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_Btn.Location = new System.Drawing.Point(313, 156);
            this.logout_Btn.Name = "logout_Btn";
            this.logout_Btn.Size = new System.Drawing.Size(86, 32);
            this.logout_Btn.TabIndex = 9;
            this.logout_Btn.Text = "Logout";
            this.logout_Btn.UseVisualStyleBackColor = true;
            this.logout_Btn.Click += new System.EventHandler(this.logout_Btn_Click);
            // 
            // Bal_lb
            // 
            this.Bal_lb.AutoSize = true;
            this.Bal_lb.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bal_lb.Location = new System.Drawing.Point(11, 150);
            this.Bal_lb.Name = "Bal_lb";
            this.Bal_lb.Size = new System.Drawing.Size(0, 19);
            this.Bal_lb.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Login Successful";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "MyBankApp Services";
            // 
            // Bal_Btn
            // 
            this.Bal_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Bal_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bal_Btn.Font = new System.Drawing.Font("MotoyaLCedar", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bal_Btn.ForeColor = System.Drawing.Color.GreenYellow;
            this.Bal_Btn.Location = new System.Drawing.Point(186, 47);
            this.Bal_Btn.Name = "Bal_Btn";
            this.Bal_Btn.Size = new System.Drawing.Size(165, 92);
            this.Bal_Btn.TabIndex = 2;
            this.Bal_Btn.Text = "Check Balance";
            this.Bal_Btn.UseVisualStyleBackColor = false;
            this.Bal_Btn.Click += new System.EventHandler(this.Bal_Btn_Click);
            // 
            // send_Btn
            // 
            this.send_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.send_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send_Btn.Font = new System.Drawing.Font("MotoyaLCedar", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_Btn.ForeColor = System.Drawing.Color.FloralWhite;
            this.send_Btn.Location = new System.Drawing.Point(15, 47);
            this.send_Btn.Name = "send_Btn";
            this.send_Btn.Size = new System.Drawing.Size(165, 92);
            this.send_Btn.TabIndex = 1;
            this.send_Btn.Text = "Send Money ";
            this.send_Btn.UseVisualStyleBackColor = false;
            this.send_Btn.Click += new System.EventHandler(this.send_Btn_Click);
            // 
            // Transaction_Panel
            // 
            this.Transaction_Panel.Controls.Add(this.cancel_Btn);
            this.Transaction_Panel.Controls.Add(this.send_cnf_Btn);
            this.Transaction_Panel.Controls.Add(this.Target_Account_No);
            this.Transaction_Panel.Controls.Add(this.label3);
            this.Transaction_Panel.Controls.Add(this.Transfer_Amount);
            this.Transaction_Panel.Controls.Add(this.deb_acc_no);
            this.Transaction_Panel.Controls.Add(this.Target_lb);
            this.Transaction_Panel.Controls.Add(this.tf_lb);
            this.Transaction_Panel.Controls.Add(this.deb_lb);
            this.Transaction_Panel.Font = new System.Drawing.Font("Microsoft JhengHei Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transaction_Panel.Location = new System.Drawing.Point(408, 21);
            this.Transaction_Panel.Name = "Transaction_Panel";
            this.Transaction_Panel.Size = new System.Drawing.Size(412, 265);
            this.Transaction_Panel.TabIndex = 3;
            // 
            // send_cnf_Btn
            // 
            this.send_cnf_Btn.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_cnf_Btn.Location = new System.Drawing.Point(272, 180);
            this.send_cnf_Btn.Name = "send_cnf_Btn";
            this.send_cnf_Btn.Size = new System.Drawing.Size(59, 30);
            this.send_cnf_Btn.TabIndex = 5;
            this.send_cnf_Btn.Text = "Send";
            this.send_cnf_Btn.UseVisualStyleBackColor = true;
            this.send_cnf_Btn.Click += new System.EventHandler(this.send_cnf_Btn_Click);
            // 
            // Target_Account_No
            // 
            this.Target_Account_No.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Target_Account_No.Location = new System.Drawing.Point(26, 183);
            this.Target_Account_No.Name = "Target_Account_No";
            this.Target_Account_No.Size = new System.Drawing.Size(205, 23);
            this.Target_Account_No.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(237, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "₹";
            // 
            // Transfer_Amount
            // 
            this.Transfer_Amount.Font = new System.Drawing.Font("Gill Sans MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transfer_Amount.Location = new System.Drawing.Point(27, 111);
            this.Transfer_Amount.Name = "Transfer_Amount";
            this.Transfer_Amount.Size = new System.Drawing.Size(205, 21);
            this.Transfer_Amount.TabIndex = 8;
            // 
            // deb_acc_no
            // 
            this.deb_acc_no.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deb_acc_no.Location = new System.Drawing.Point(28, 37);
            this.deb_acc_no.Name = "deb_acc_no";
            this.deb_acc_no.Size = new System.Drawing.Size(204, 21);
            this.deb_acc_no.TabIndex = 7;
            // 
            // Target_lb
            // 
            this.Target_lb.AutoSize = true;
            this.Target_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Target_lb.Location = new System.Drawing.Point(24, 162);
            this.Target_lb.Name = "Target_lb";
            this.Target_lb.Size = new System.Drawing.Size(111, 15);
            this.Target_lb.TabIndex = 6;
            this.Target_lb.Text = "Target Account No";
            // 
            // tf_lb
            // 
            this.tf_lb.AutoSize = true;
            this.tf_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tf_lb.Location = new System.Drawing.Point(24, 90);
            this.tf_lb.Name = "tf_lb";
            this.tf_lb.Size = new System.Drawing.Size(101, 15);
            this.tf_lb.TabIndex = 5;
            this.tf_lb.Text = "Transfer Amount";
            // 
            // deb_lb
            // 
            this.deb_lb.AutoSize = true;
            this.deb_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deb_lb.Location = new System.Drawing.Point(23, 19);
            this.deb_lb.Name = "deb_lb";
            this.deb_lb.Size = new System.Drawing.Size(119, 15);
            this.deb_lb.TabIndex = 4;
            this.deb_lb.Text = "Debit From Account";
            // 
            // cancel_Btn
            // 
            this.cancel_Btn.AccessibleDescription = "Cancel Transaction";
            this.cancel_Btn.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_Btn.Location = new System.Drawing.Point(26, 226);
            this.cancel_Btn.Name = "cancel_Btn";
            this.cancel_Btn.Size = new System.Drawing.Size(71, 30);
            this.cancel_Btn.TabIndex = 11;
            this.cancel_Btn.Text = "Cancel";
            this.cancel_Btn.UseVisualStyleBackColor = true;
            this.cancel_Btn.Click += new System.EventHandler(this.cancel_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 404);
            this.Controls.Add(this.Transaction_Panel);
            this.Controls.Add(this.Home_Panel);
            this.Controls.Add(this.Login_Panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Login_Panel.ResumeLayout(false);
            this.Login_Panel.PerformLayout();
            this.Home_Panel.ResumeLayout(false);
            this.Home_Panel.PerformLayout();
            this.Transaction_Panel.ResumeLayout(false);
            this.Transaction_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label acc_no_lb;
        private System.Windows.Forms.Panel Login_Panel;
        private System.Windows.Forms.Button Login_Btn;
        private System.Windows.Forms.TextBox pswd;
        private System.Windows.Forms.TextBox acc_no;
        private System.Windows.Forms.Label pswd_lb;
        private System.Windows.Forms.Panel Home_Panel;
        private System.Windows.Forms.Panel Transaction_Panel;
        private System.Windows.Forms.Label Target_lb;
        private System.Windows.Forms.Label tf_lb;
        private System.Windows.Forms.Label deb_lb;
        private System.Windows.Forms.Button Bal_Btn;
        private System.Windows.Forms.Button send_Btn;
        private System.Windows.Forms.Button send_cnf_Btn;
        private System.Windows.Forms.TextBox Target_Account_No;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Transfer_Amount;
        private System.Windows.Forms.TextBox deb_acc_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Bal_lb;
        private System.Windows.Forms.Button logout_Btn;
        private System.Windows.Forms.Button cancel_Btn;
    }
}

