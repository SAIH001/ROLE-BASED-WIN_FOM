namespace Aptech
{
    partial class Login
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
            LoginButton = new Button();
            LoginEmail = new TextBox();
            Loginpassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.DodgerBlue;
            LoginButton.Location = new Point(508, 302);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(100, 34);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginEmail
            // 
            LoginEmail.Location = new Point(454, 159);
            LoginEmail.Name = "LoginEmail";
            LoginEmail.Size = new Size(212, 23);
            LoginEmail.TabIndex = 1;
            // 
            // Loginpassword
            // 
            Loginpassword.Location = new Point(454, 238);
            Loginpassword.Name = "Loginpassword";
            Loginpassword.Size = new Size(212, 23);
            Loginpassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(453, 123);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 3;
            label1.Text = "Employee Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(454, 207);
            label2.Name = "label2";
            label2.Size = new Size(112, 15);
            label2.TabIndex = 4;
            label2.Text = "Employee Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.registration_4x;
            pictureBox1.Location = new Point(53, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(346, 374);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Loginpassword);
            Controls.Add(LoginEmail);
            Controls.Add(LoginButton);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private TextBox LoginEmail;
        private TextBox Loginpassword;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}