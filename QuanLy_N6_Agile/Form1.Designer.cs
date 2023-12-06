namespace QuanLy_N6_Agile
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
            label1 = new Label();
            btnCancel = new Button();
            txtUers = new TextBox();
            btnLogin = new Button();
            label2 = new Label();
            txtPass = new TextBox();
            grLogin = new GroupBox();
            chkS = new CheckBox();
            grLogin.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 56);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 0;
            label1.Text = "Tài Khoản";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(294, 181);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 29);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Thoát";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtUers
            // 
            txtUers.Location = new Point(162, 48);
            txtUers.Name = "txtUers";
            txtUers.Size = new Size(226, 28);
            txtUers.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(131, 181);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 103);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(162, 82);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(226, 28);
            txtPass.TabIndex = 3;
            // 
            // grLogin
            // 
            grLogin.Controls.Add(chkS);
            grLogin.Controls.Add(label1);
            grLogin.Controls.Add(btnCancel);
            grLogin.Controls.Add(txtUers);
            grLogin.Controls.Add(btnLogin);
            grLogin.Controls.Add(label2);
            grLogin.Controls.Add(txtPass);
            grLogin.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            grLogin.Location = new Point(175, 110);
            grLogin.Name = "grLogin";
            grLogin.Size = new Size(450, 231);
            grLogin.TabIndex = 7;
            grLogin.TabStop = false;
            grLogin.Text = "Đăng Nhập Hệ Thống";
            // 
            // chkS
            // 
            chkS.AutoSize = true;
            chkS.Location = new Point(162, 139);
            chkS.Name = "chkS";
            chkS.Size = new Size(173, 24);
            chkS.TabIndex = 6;
            chkS.Text = "Hiện Thị Mật Khẩu";
            chkS.UseVisualStyleBackColor = true;
            chkS.CheckedChanged += chkS_CheckedChanged;
            chkS.Click += chkS_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grLogin);
            Name = "Form1";
            Text = "Form1";
            grLogin.ResumeLayout(false);
            grLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnCancel;
        private TextBox txtUers;
        private Button btnLogin;
        private Label label2;
        private TextBox txtPass;
        private GroupBox grLogin;
        private CheckBox chkS;
    }
}
