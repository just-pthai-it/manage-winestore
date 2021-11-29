
namespace Views
{
    partial class FormChangePass
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
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkPasswordBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComfirmPassword = new System.Windows.Forms.TextBox();
            this.comfirmBt = new System.Windows.Forms.Button();
            this.backBt = new System.Windows.Forms.Button();
            this.wrongPasswordLb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(154, 55);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(164, 20);
            this.txtCurrentPassword.TabIndex = 0;
            this.txtCurrentPassword.TextChanged += new System.EventHandler(this.txtCurrentPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current password:";
            // 
            // checkPasswordBt
            // 
            this.checkPasswordBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkPasswordBt.Location = new System.Drawing.Point(324, 55);
            this.checkPasswordBt.Name = "checkPasswordBt";
            this.checkPasswordBt.Size = new System.Drawing.Size(52, 20);
            this.checkPasswordBt.TabIndex = 2;
            this.checkPasswordBt.Text = "Check";
            this.checkPasswordBt.UseVisualStyleBackColor = true;
            this.checkPasswordBt.Click += new System.EventHandler(this.checkPasswordBt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "New password:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Enabled = false;
            this.txtNewPassword.Location = new System.Drawing.Point(154, 120);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(164, 20);
            this.txtNewPassword.TabIndex = 3;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm password:";
            // 
            // txtComfirmPassword
            // 
            this.txtComfirmPassword.Enabled = false;
            this.txtComfirmPassword.Location = new System.Drawing.Point(154, 146);
            this.txtComfirmPassword.Name = "txtComfirmPassword";
            this.txtComfirmPassword.PasswordChar = '*';
            this.txtComfirmPassword.Size = new System.Drawing.Size(164, 20);
            this.txtComfirmPassword.TabIndex = 5;
            this.txtComfirmPassword.TextChanged += new System.EventHandler(this.txtComfirmPassword_TextChanged);
            // 
            // comfirmBt
            // 
            this.comfirmBt.BackColor = System.Drawing.Color.Beige;
            this.comfirmBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comfirmBt.Enabled = false;
            this.comfirmBt.Location = new System.Drawing.Point(154, 217);
            this.comfirmBt.Name = "comfirmBt";
            this.comfirmBt.Size = new System.Drawing.Size(68, 27);
            this.comfirmBt.TabIndex = 7;
            this.comfirmBt.Text = "Confirm";
            this.comfirmBt.UseVisualStyleBackColor = false;
            this.comfirmBt.Click += new System.EventHandler(this.comfirmBt_Click);
            // 
            // backBt
            // 
            this.backBt.BackColor = System.Drawing.Color.Beige;
            this.backBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBt.Location = new System.Drawing.Point(256, 217);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(68, 27);
            this.backBt.TabIndex = 8;
            this.backBt.Text = "Back";
            this.backBt.UseVisualStyleBackColor = false;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // wrongPasswordLb
            // 
            this.wrongPasswordLb.AutoSize = true;
            this.wrongPasswordLb.ForeColor = System.Drawing.Color.Red;
            this.wrongPasswordLb.Location = new System.Drawing.Point(151, 88);
            this.wrongPasswordLb.Name = "wrongPasswordLb";
            this.wrongPasswordLb.Size = new System.Drawing.Size(139, 13);
            this.wrongPasswordLb.TabIndex = 9;
            this.wrongPasswordLb.Text = "Mật khẩu không chính xác!";
            this.wrongPasswordLb.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(151, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mật khẩu không trùng khớp!";
            this.label4.Visible = false;
            // 
            // FormChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(460, 275);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wrongPasswordLb);
            this.Controls.Add(this.backBt);
            this.Controls.Add(this.comfirmBt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtComfirmPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.checkPasswordBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCurrentPassword);
            this.Name = "FormChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkPasswordBt;
        private System.Windows.Forms.Button backBt;
        private System.Windows.Forms.Button comfirmBt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label wrongPasswordLb;
        private System.Windows.Forms.Label label4;
    }
}