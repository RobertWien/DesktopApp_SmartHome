namespace Controlling_Real_CSharp
{
    partial class Kitchen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kitchen));
            this.label4 = new System.Windows.Forms.Label();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_light = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.securityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livingroomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bedroomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_fan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.pic_line_out = new System.Windows.Forms.PictureBox();
            this.pic_line_in = new System.Windows.Forms.PictureBox();
            this.pic_light_off = new System.Windows.Forms.PictureBox();
            this.pic_fan_off = new System.Windows.Forms.PictureBox();
            this.pic_fan_on = new System.Windows.Forms.PictureBox();
            this.pic_light_on = new System.Windows.Forms.PictureBox();
            this.pic_rain_in = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_line_out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_line_in)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_light_off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fan_off)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fan_on)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_light_on)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rain_in)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Papyrus", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(391, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 52);
            this.label4.TabIndex = 95;
            this.label4.Text = "ALARM";
            // 
            // btn_line
            // 
            this.btn_line.BackColor = System.Drawing.Color.Red;
            this.btn_line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_line.ForeColor = System.Drawing.Color.Blue;
            this.btn_line.Location = new System.Drawing.Point(743, 399);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(176, 61);
            this.btn_line.TabIndex = 94;
            this.btn_line.Text = "IN";
            this.btn_line.UseVisualStyleBackColor = false;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_light
            // 
            this.btn_light.BackColor = System.Drawing.Color.Red;
            this.btn_light.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_light.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_light.ForeColor = System.Drawing.Color.Blue;
            this.btn_light.Location = new System.Drawing.Point(64, 399);
            this.btn_light.Name = "btn_light";
            this.btn_light.Size = new System.Drawing.Size(176, 61);
            this.btn_light.TabIndex = 93;
            this.btn_light.Text = "CLOSE";
            this.btn_light.UseVisualStyleBackColor = false;
            this.btn_light.Click += new System.EventHandler(this.btn_light_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.securityToolStripMenuItem,
            this.livingroomToolStripMenuItem,
            this.bedroomToolStripMenuItem,
            this.kitchenToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 28);
            this.menuStrip1.TabIndex = 92;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // securityToolStripMenuItem
            // 
            this.securityToolStripMenuItem.Name = "securityToolStripMenuItem";
            this.securityToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.securityToolStripMenuItem.Text = "Security";
            this.securityToolStripMenuItem.Click += new System.EventHandler(this.securityToolStripMenuItem_Click);
            // 
            // livingroomToolStripMenuItem
            // 
            this.livingroomToolStripMenuItem.Name = "livingroomToolStripMenuItem";
            this.livingroomToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.livingroomToolStripMenuItem.Text = "Livingroom";
            this.livingroomToolStripMenuItem.Click += new System.EventHandler(this.livingroomToolStripMenuItem_Click);
            // 
            // bedroomToolStripMenuItem
            // 
            this.bedroomToolStripMenuItem.Name = "bedroomToolStripMenuItem";
            this.bedroomToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.bedroomToolStripMenuItem.Text = "Bedroom";
            this.bedroomToolStripMenuItem.Click += new System.EventHandler(this.bedroomToolStripMenuItem_Click);
            // 
            // kitchenToolStripMenuItem
            // 
            this.kitchenToolStripMenuItem.Name = "kitchenToolStripMenuItem";
            this.kitchenToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.kitchenToolStripMenuItem.Text = "Kitchen";
            this.kitchenToolStripMenuItem.Click += new System.EventHandler(this.kitchenToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btn_fan
            // 
            this.btn_fan.BackColor = System.Drawing.Color.Red;
            this.btn_fan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_fan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fan.ForeColor = System.Drawing.Color.Blue;
            this.btn_fan.Location = new System.Drawing.Point(391, 399);
            this.btn_fan.Name = "btn_fan";
            this.btn_fan.Size = new System.Drawing.Size(176, 61);
            this.btn_fan.TabIndex = 91;
            this.btn_fan.Text = "CLOSE";
            this.btn_fan.UseVisualStyleBackColor = false;
            this.btn_fan.Click += new System.EventHandler(this.btn_fan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Papyrus", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(655, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 52);
            this.label3.TabIndex = 90;
            this.label3.Text = "CLOTHES  LINE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("VNI-Scribble", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 96);
            this.label2.TabIndex = 89;
            this.label2.Text = "KITCHEN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Papyrus", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(69, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 52);
            this.label1.TabIndex = 88;
            this.label1.Text = "LIGHT";
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_update.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_update.Location = new System.Drawing.Point(381, 60);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(176, 61);
            this.btn_update.TabIndex = 87;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // pic_line_out
            // 
            this.pic_line_out.Image = ((System.Drawing.Image)(resources.GetObject("pic_line_out.Image")));
            this.pic_line_out.Location = new System.Drawing.Point(734, 210);
            this.pic_line_out.Name = "pic_line_out";
            this.pic_line_out.Size = new System.Drawing.Size(195, 183);
            this.pic_line_out.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_line_out.TabIndex = 86;
            this.pic_line_out.TabStop = false;
            this.pic_line_out.Visible = false;
            this.pic_line_out.Click += new System.EventHandler(this.pic_air_on_Click);
            // 
            // pic_line_in
            // 
            this.pic_line_in.Image = ((System.Drawing.Image)(resources.GetObject("pic_line_in.Image")));
            this.pic_line_in.Location = new System.Drawing.Point(734, 210);
            this.pic_line_in.Name = "pic_line_in";
            this.pic_line_in.Size = new System.Drawing.Size(195, 183);
            this.pic_line_in.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_line_in.TabIndex = 85;
            this.pic_line_in.TabStop = false;
            this.pic_line_in.Visible = false;
            // 
            // pic_light_off
            // 
            this.pic_light_off.Image = ((System.Drawing.Image)(resources.GetObject("pic_light_off.Image")));
            this.pic_light_off.Location = new System.Drawing.Point(54, 210);
            this.pic_light_off.Name = "pic_light_off";
            this.pic_light_off.Size = new System.Drawing.Size(195, 183);
            this.pic_light_off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_light_off.TabIndex = 84;
            this.pic_light_off.TabStop = false;
            this.pic_light_off.Visible = false;
            // 
            // pic_fan_off
            // 
            this.pic_fan_off.Image = ((System.Drawing.Image)(resources.GetObject("pic_fan_off.Image")));
            this.pic_fan_off.Location = new System.Drawing.Point(381, 210);
            this.pic_fan_off.Name = "pic_fan_off";
            this.pic_fan_off.Size = new System.Drawing.Size(195, 183);
            this.pic_fan_off.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_fan_off.TabIndex = 83;
            this.pic_fan_off.TabStop = false;
            this.pic_fan_off.Visible = false;
            // 
            // pic_fan_on
            // 
            this.pic_fan_on.Image = ((System.Drawing.Image)(resources.GetObject("pic_fan_on.Image")));
            this.pic_fan_on.Location = new System.Drawing.Point(381, 210);
            this.pic_fan_on.Name = "pic_fan_on";
            this.pic_fan_on.Size = new System.Drawing.Size(195, 183);
            this.pic_fan_on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_fan_on.TabIndex = 82;
            this.pic_fan_on.TabStop = false;
            this.pic_fan_on.Visible = false;
            // 
            // pic_light_on
            // 
            this.pic_light_on.Image = ((System.Drawing.Image)(resources.GetObject("pic_light_on.Image")));
            this.pic_light_on.Location = new System.Drawing.Point(54, 210);
            this.pic_light_on.Name = "pic_light_on";
            this.pic_light_on.Size = new System.Drawing.Size(195, 183);
            this.pic_light_on.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_light_on.TabIndex = 81;
            this.pic_light_on.TabStop = false;
            this.pic_light_on.Visible = false;
            // 
            // pic_rain_in
            // 
            this.pic_rain_in.Image = ((System.Drawing.Image)(resources.GetObject("pic_rain_in.Image")));
            this.pic_rain_in.Location = new System.Drawing.Point(734, 210);
            this.pic_rain_in.Name = "pic_rain_in";
            this.pic_rain_in.Size = new System.Drawing.Size(195, 183);
            this.pic_rain_in.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_rain_in.TabIndex = 96;
            this.pic_rain_in.TabStop = false;
            this.pic_rain_in.Visible = false;
            // 
            // Kitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 556);
            this.Controls.Add(this.pic_rain_in);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_line);
            this.Controls.Add(this.btn_light);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_fan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.pic_line_out);
            this.Controls.Add(this.pic_line_in);
            this.Controls.Add(this.pic_light_off);
            this.Controls.Add(this.pic_fan_off);
            this.Controls.Add(this.pic_fan_on);
            this.Controls.Add(this.pic_light_on);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kitchen";
            this.Text = "Kitchen";
            this.Load += new System.EventHandler(this.Kitchen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_line_out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_line_in)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_light_off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fan_off)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_fan_on)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_light_on)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rain_in)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_light;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem securityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livingroomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bedroomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitchenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btn_fan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.PictureBox pic_line_out;
        private System.Windows.Forms.PictureBox pic_line_in;
        private System.Windows.Forms.PictureBox pic_light_off;
        private System.Windows.Forms.PictureBox pic_fan_off;
        private System.Windows.Forms.PictureBox pic_fan_on;
        private System.Windows.Forms.PictureBox pic_light_on;
        private System.Windows.Forms.PictureBox pic_rain_in;
    }
}