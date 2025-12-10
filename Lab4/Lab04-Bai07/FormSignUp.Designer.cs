namespace Lab04_Bai07
{
    partial class FormSignUp
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
            groupBox1 = new GroupBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label10 = new Label();
            label9 = new Label();
            cbbLanguage = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            txtPhone = new TextBox();
            txtLastname = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtFirstname = new TextBox();
            txtEmail = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnClear = new Button();
            btnSubmit = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(37, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(731, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sign Up";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(241, 127);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(376, 39);
            txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(241, 56);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(376, 39);
            txtUsername.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(68, 129);
            label3.Name = "label3";
            label3.Size = new Size(128, 37);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 55);
            label2.Name = "label2";
            label2.Size = new Size(136, 37);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightSalmon;
            label1.Location = new Point(216, 21);
            label1.Name = "label1";
            label1.Size = new Size(368, 59);
            label1.TabIndex = 1;
            label1.Text = "Hôm Nay Ăn Gì?";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cbbLanguage);
            groupBox2.Controls.Add(dateTimePicker1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtPhone);
            groupBox2.Controls.Add(txtLastname);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtFirstname);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(37, 338);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(731, 574);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "User Information";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(459, 491);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(122, 36);
            radioButton2.TabIndex = 15;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(241, 493);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(98, 36);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(60, 491);
            label10.Name = "label10";
            label10.Size = new Size(57, 37);
            label10.TabIndex = 14;
            label10.Text = "Sex\r\n";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(60, 415);
            label9.Name = "label9";
            label9.Size = new Size(134, 37);
            label9.TabIndex = 13;
            label9.Text = "Language";
            // 
            // cbbLanguage
            // 
            cbbLanguage.FormattingEnabled = true;
            cbbLanguage.Location = new Point(241, 412);
            cbbLanguage.Name = "cbbLanguage";
            cbbLanguage.Size = new Size(242, 40);
            cbbLanguage.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(241, 344);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(400, 39);
            dateTimePicker1.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(60, 344);
            label8.Name = "label8";
            label8.Size = new Size(115, 37);
            label8.TabIndex = 10;
            label8.Text = "Birthday";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(241, 269);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(376, 39);
            txtPhone.TabIndex = 9;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(241, 197);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(376, 39);
            txtLastname.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(60, 271);
            label7.Name = "label7";
            label7.Size = new Size(92, 37);
            label7.TabIndex = 7;
            label7.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(60, 199);
            label6.Name = "label6";
            label6.Size = new Size(130, 37);
            label6.TabIndex = 6;
            label6.Text = "Lastname";
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(241, 127);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(376, 39);
            txtFirstname.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(241, 56);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(376, 39);
            txtEmail.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(60, 127);
            label4.Name = "label4";
            label4.Size = new Size(132, 37);
            label4.TabIndex = 3;
            label4.Text = "Firstname";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(60, 55);
            label5.Name = "label5";
            label5.Size = new Size(82, 37);
            label5.TabIndex = 2;
            label5.Text = "Email";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(370, 961);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 57);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(570, 961);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 57);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // FormSignUp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(800, 1060);
            Controls.Add(btnSubmit);
            Controls.Add(btnClear);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "FormSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSignUp";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label3;
        private GroupBox groupBox2;
        private Label label10;
        private Label label9;
        private ComboBox cbbLanguage;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private TextBox txtPhone;
        private TextBox txtLastname;
        private Label label7;
        private Label label6;
        private TextBox txtFirstname;
        private TextBox txtEmail;
        private Label label4;
        private Label label5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button btnClear;
        private Button btnSubmit;
    }
}