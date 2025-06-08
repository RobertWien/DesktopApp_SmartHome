namespace Controlling_Real_CSharp
{
    partial class Reset_Door_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reset_Door_Password));
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.con_password = new System.Windows.Forms.TextBox();
            this.new_password = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trajan Pro", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Chartreuse;
            this.label3.Location = new System.Drawing.Point(101, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(848, 76);
            this.label3.TabIndex = 13;
            this.label3.Text = "RESET DOOR PASSWORD";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.Info;
            this.password.Location = new System.Drawing.Point(483, 286);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(321, 22);
            this.password.TabIndex = 12;
            this.password.UseSystemPasswordChar = true;
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.SystemColors.Info;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(483, 202);
            this.user.Multiline = true;
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(321, 31);
            this.user.TabIndex = 11;
            this.user.Tag = "";
            this.user.UseSystemPasswordChar = true;
            this.user.UseWaitCursor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(124, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(365, 38);
            this.label12.TabIndex = 10;
            this.label12.Text = "CONFIRM  PASSWORD";
            this.label12.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(238, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = " USERNAME    ";
            // 
            // btn_login
            // 
            this.btn_login.AutoEllipsis = true;
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_login.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.Red;
            this.btn_login.Location = new System.Drawing.Point(245, 387);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(559, 55);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "CONFIRM";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("VNI-Couri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(39, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(976, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "To reset your door password, please enter exactly your own account below !";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("VNI-Couri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(195, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(696, 31);
            this.label10.TabIndex = 15;
            this.label10.Text = "Please enter your new door password below !";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(160, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(317, 38);
            this.label11.TabIndex = 16;
            this.label11.Text = "NEW   PASSWORD   ";
            this.label11.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(237, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 38);
            this.label2.TabIndex = 17;
            this.label2.Text = " PASSWORD";
            // 
            // con_password
            // 
            this.con_password.BackColor = System.Drawing.SystemColors.Info;
            this.con_password.Location = new System.Drawing.Point(530, 286);
            this.con_password.Name = "con_password";
            this.con_password.Size = new System.Drawing.Size(321, 22);
            this.con_password.TabIndex = 18;
            this.con_password.UseSystemPasswordChar = true;
            this.con_password.Visible = false;
            // 
            // new_password
            // 
            this.new_password.BackColor = System.Drawing.SystemColors.Info;
            this.new_password.Location = new System.Drawing.Point(530, 202);
            this.new_password.Name = "new_password";
            this.new_password.Size = new System.Drawing.Size(321, 22);
            this.new_password.TabIndex = 19;
            this.new_password.UseSystemPasswordChar = true;
            this.new_password.Visible = false;
            // 
            // btn_reset
            // 
            this.btn_reset.AutoEllipsis = true;
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_reset.Font = new System.Drawing.Font("Papyrus", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.Navy;
            this.btn_reset.Location = new System.Drawing.Point(245, 387);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(559, 55);
            this.btn_reset.TabIndex = 20;
            this.btn_reset.Text = "RESET";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Visible = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Reset_Door_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1175, 552);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.new_password);
            this.Controls.Add(this.con_password);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reset_Door_Password";
            this.Text = "Reset Door Password";
            this.Load += new System.EventHandler(this.Reset_Door_Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox con_password;
        private System.Windows.Forms.TextBox new_password;
        private System.Windows.Forms.Button btn_reset;
    }
}