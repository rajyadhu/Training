namespace Login
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
            this.Login_btn = new System.Windows.Forms.Button();
            this.Username_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Username_txt = new System.Windows.Forms.TextBox();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.Login_heading = new System.Windows.Forms.Label();
            this.Remember_me = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(306, 325);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(112, 42);
            this.Login_btn.TabIndex = 0;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_click);
            // 
            // Username_label
            // 
            this.Username_label.AutoSize = true;
            this.Username_label.Location = new System.Drawing.Point(225, 125);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(70, 16);
            this.Username_label.TabIndex = 1;
            this.Username_label.Text = "Username";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(228, 205);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(67, 16);
            this.Password_label.TabIndex = 2;
            this.Password_label.Text = "Password";
            // 
            // Username_txt
            // 
            this.Username_txt.Location = new System.Drawing.Point(231, 145);
            this.Username_txt.Name = "Username_txt";
            this.Username_txt.Size = new System.Drawing.Size(268, 22);
            this.Username_txt.TabIndex = 3;
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(228, 224);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.PasswordChar = '*';
            this.Password_txt.Size = new System.Drawing.Size(268, 22);
            this.Password_txt.TabIndex = 4;
            // 
            // Login_heading
            // 
            this.Login_heading.AutoSize = true;
            this.Login_heading.Location = new System.Drawing.Point(352, 66);
            this.Login_heading.Name = "Login_heading";
            this.Login_heading.Size = new System.Drawing.Size(74, 16);
            this.Login_heading.TabIndex = 5;
            this.Login_heading.Text = "Login Form";
            // 
            // Remember_me
            // 
            this.Remember_me.AutoSize = true;
            this.Remember_me.Location = new System.Drawing.Point(231, 275);
            this.Remember_me.Name = "Remember_me";
            this.Remember_me.Size = new System.Drawing.Size(119, 20);
            this.Remember_me.TabIndex = 6;
            this.Remember_me.Text = "Remember me";
            this.Remember_me.UseVisualStyleBackColor = true;
            this.Remember_me.CheckedChanged += new System.EventHandler(this.Remember_me_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Remember_me);
            this.Controls.Add(this.Login_heading);
            this.Controls.Add(this.Password_txt);
            this.Controls.Add(this.Username_txt);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Username_label);
            this.Controls.Add(this.Login_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox Username_txt;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.Label Login_heading;
        private System.Windows.Forms.CheckBox Remember_me;
    }
}

