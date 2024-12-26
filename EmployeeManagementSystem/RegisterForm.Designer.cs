namespace EmployeeManagementSystem
{
    partial class RegisterForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.signup_loginbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.signup_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exit = new System.Windows.Forms.Label();
            this.signup_btn = new System.Windows.Forms.Button();
            this.signup_showPassword = new System.Windows.Forms.CheckBox();
            this.signup_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.signup_loginbtn);
            this.panel1.Controls.Add(this.label5);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.ForeColor = System.Drawing.Color.RosyBrown;
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::EmployeeManagementSystem.Properties.Resources.icon;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // signup_loginbtn
            // 
            this.signup_loginbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.signup_loginbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_loginbtn.FlatAppearance.BorderSize = 0;
            this.signup_loginbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.signup_loginbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            resources.ApplyResources(this.signup_loginbtn, "signup_loginbtn");
            this.signup_loginbtn.ForeColor = System.Drawing.Color.White;
            this.signup_loginbtn.Name = "signup_loginbtn";
            this.signup_loginbtn.UseVisualStyleBackColor = false;
            this.signup_loginbtn.Click += new System.EventHandler(this.signup_loginbtn_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // signup_username
            // 
            resources.ApplyResources(this.signup_username, "signup_username");
            this.signup_username.Name = "signup_username";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Name = "label2";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // exit
            // 
            resources.ApplyResources(this.exit, "exit");
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Name = "exit";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.signup_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            resources.ApplyResources(this.signup_btn, "signup_btn");
            this.signup_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // signup_showPassword
            // 
            resources.ApplyResources(this.signup_showPassword, "signup_showPassword");
            this.signup_showPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.signup_showPassword.Name = "signup_showPassword";
            this.signup_showPassword.UseVisualStyleBackColor = true;
            this.signup_showPassword.CheckedChanged += new System.EventHandler(this.signup_showPassword_CheckedChanged);
            // 
            // signup_password
            // 
            resources.ApplyResources(this.signup_password, "signup_password");
            this.signup_password.Name = "signup_password";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Name = "label4";
            // 
            // RegisterForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.signup_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.signup_btn);
            this.Controls.Add(this.signup_showPassword);
            this.Controls.Add(this.signup_password);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button signup_loginbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.CheckBox signup_showPassword;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.Label label4;
    }
}