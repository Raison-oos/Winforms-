namespace Login
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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            txtLoginPassword = new TextBox();
            btnLogin = new Button();
            txtLoginUsername = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSignUpPassword = new TextBox();
            btnSignUp = new Button();
            txtSignUpUsername = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtLoginPassword);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtLoginUsername);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 450);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 186);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 131);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtLoginPassword.Location = new Point(101, 204);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PasswordChar = '•';
            txtLoginPassword.Size = new Size(200, 25);
            txtLoginPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Emoji", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(156, 269);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(84, 45);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "→";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtLoginUsername.Location = new Point(101, 149);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.Size = new Size(200, 25);
            txtLoginUsername.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(161, 92);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.ForeColor = Color.White;
            label4.Location = new Point(501, 186);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 11;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Black;
            label5.ForeColor = Color.White;
            label5.Location = new Point(501, 131);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 10;
            label5.Text = "Username";
            // 
            // txtSignUpPassword
            // 
            txtSignUpPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtSignUpPassword.Location = new Point(501, 204);
            txtSignUpPassword.Name = "txtSignUpPassword";
            txtSignUpPassword.PasswordChar = '•';
            txtSignUpPassword.Size = new Size(200, 25);
            txtSignUpPassword.TabIndex = 9;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.Black;
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI Emoji", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(556, 269);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(84, 45);
            btnSignUp.TabIndex = 8;
            btnSignUp.Text = "→";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // txtSignUpUsername
            // 
            txtSignUpUsername.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtSignUpUsername.Location = new Point(501, 149);
            txtSignUpUsername.Name = "txtSignUpUsername";
            txtSignUpUsername.Size = new Size(200, 25);
            txtSignUpUsername.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(561, 92);
            label6.Name = "label6";
            label6.Size = new Size(101, 32);
            label6.TabIndex = 6;
            label6.Text = "Sign up";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(txtSignUpPassword);
            Controls.Add(label6);
            Controls.Add(btnSignUp);
            Controls.Add(txtSignUpUsername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtLoginPassword;
        private Button btnLogin;
        private TextBox txtLoginUsername;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtSignUpPassword;
        private Button btnSignUp;
        private TextBox txtSignUpUsername;
        private Label label6;
    }
}
