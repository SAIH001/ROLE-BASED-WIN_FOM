namespace Aptech
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            employeename = new TextBox();
            label1 = new Label();
            label2 = new Label();
            employeeemail = new TextBox();
            label3 = new Label();
            employeepassword = new TextBox();
            RegistrationButton = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // employeename
            // 
            employeename.Location = new Point(483, 126);
            employeename.Name = "employeename";
            employeename.Size = new Size(277, 23);
            employeename.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(483, 97);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 1;
            label1.Text = "Employee Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(483, 172);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 3;
            label2.Text = "Employee Email";
            // 
            // employeeemail
            // 
            employeeemail.Location = new Point(483, 201);
            employeeemail.Name = "employeeemail";
            employeeemail.Size = new Size(277, 23);
            employeeemail.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(483, 249);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 5;
            label3.Text = "Employee Password";
            // 
            // employeepassword
            // 
            employeepassword.Location = new Point(483, 278);
            employeepassword.Name = "employeepassword";
            employeepassword.PasswordChar = '*';
            employeepassword.Size = new Size(277, 23);
            employeepassword.TabIndex = 4;
            // 
            // RegistrationButton
            // 
            RegistrationButton.BackColor = Color.Violet;
            RegistrationButton.Location = new Point(561, 341);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(103, 26);
            RegistrationButton.TabIndex = 6;
            RegistrationButton.Text = "Registration";
            RegistrationButton.UseVisualStyleBackColor = false;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.registration_4x;
            pictureBox1.Location = new Point(23, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(411, 395);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Violet;
            button1.Location = new Point(561, 388);
            button1.Name = "button1";
            button1.Size = new Size(103, 26);
            button1.TabIndex = 8;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(RegistrationButton);
            Controls.Add(label3);
            Controls.Add(employeepassword);
            Controls.Add(label2);
            Controls.Add(employeeemail);
            Controls.Add(label1);
            Controls.Add(employeename);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox employeename;
        private Label label1;
        private Label label2;
        private TextBox employeeemail;
        private Label label3;
        private TextBox employeepassword;
        private Button RegistrationButton;
        private PictureBox pictureBox1;
        private Button button1;
    }
}