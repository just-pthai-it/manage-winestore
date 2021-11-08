
namespace Views
{
    partial class FormLogin
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
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Credit = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Welcome.Location = new System.Drawing.Point(96, 40);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(120, 25);
            this.lbl_Welcome.TabIndex = 10;
            this.lbl_Welcome.Text = "Wine Store";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(171, 232);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(87, 29);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_Password);
            this.panel1.Controls.Add(this.lbl_Username);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(26, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 122);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(46, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Undefined username or password!";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(21, 64);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(56, 13);
            this.lbl_Password.TabIndex = 7;
            this.lbl_Password.Text = "Password:";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(21, 27);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(58, 13);
            this.lbl_Username.TabIndex = 6;
            this.lbl_Username.Text = "Username:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(51, 232);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(87, 29);
            this.btn_Login.TabIndex = 7;
            this.btn_Login.Text = "Confirm";
            this.btn_Login.UseVisualStyleBackColor = true;
            // 
            // lbl_Credit
            // 
            this.lbl_Credit.AutoSize = true;
            this.lbl_Credit.Location = new System.Drawing.Point(158, 285);
            this.lbl_Credit.Name = "lbl_Credit";
            this.lbl_Credit.Size = new System.Drawing.Size(145, 13);
            this.lbl_Credit.TabIndex = 11;
            this.lbl_Credit.Text = "Cre: Bach N., Hai P., Minh P.";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 307);
            this.Controls.Add(this.lbl_Credit);
            this.Controls.Add(this.lbl_Welcome);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Login);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Credit;
        private System.Windows.Forms.Label label1;
    }
}

