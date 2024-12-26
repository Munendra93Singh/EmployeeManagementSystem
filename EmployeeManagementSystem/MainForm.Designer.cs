namespace EmployeeManagementSystem
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.salary_btn = new System.Windows.Forms.Button();
            this.AddEmp_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.greet_user = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dashboard1 = new EmployeeManagementSystem.Dashboard();
            this.addEmployee1 = new EmployeeManagementSystem.AddEmployee();
            this.salary1 = new EmployeeManagementSystem.Salary();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1439, 46);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Management System";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Location = new System.Drawing.Point(1406, 9);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 21);
            this.exit.TabIndex = 0;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.salary_btn);
            this.panel2.Controls.Add(this.AddEmp_btn);
            this.panel2.Controls.Add(this.dashboard_btn);
            this.panel2.Controls.Add(this.greet_user);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 684);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(72, 597);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sign Out";
            // 
            // logout_btn
            // 
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.ForeColor = System.Drawing.Color.White;
            this.logout_btn.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_logout_rounded_up_filled_25px;
            this.logout_btn.Location = new System.Drawing.Point(31, 588);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(35, 35);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // salary_btn
            // 
            this.salary_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.salary_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salary_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salary_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salary_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salary_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salary_btn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.salary_btn.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_Salary_male_30px;
            this.salary_btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.salary_btn.Location = new System.Drawing.Point(31, 526);
            this.salary_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.salary_btn.Name = "salary_btn";
            this.salary_btn.Size = new System.Drawing.Size(244, 40);
            this.salary_btn.TabIndex = 4;
            this.salary_btn.Text = "SALARY";
            this.salary_btn.UseVisualStyleBackColor = false;
            this.salary_btn.Click += new System.EventHandler(this.salary_btn_Click);
            // 
            // AddEmp_btn
            // 
            this.AddEmp_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.AddEmp_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddEmp_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.AddEmp_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.AddEmp_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.AddEmp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEmp_btn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmp_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.AddEmp_btn.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_employee_card_30px;
            this.AddEmp_btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AddEmp_btn.Location = new System.Drawing.Point(31, 465);
            this.AddEmp_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddEmp_btn.Name = "AddEmp_btn";
            this.AddEmp_btn.Size = new System.Drawing.Size(244, 40);
            this.AddEmp_btn.TabIndex = 3;
            this.AddEmp_btn.Text = "ADD EMPLOYEE";
            this.AddEmp_btn.UseVisualStyleBackColor = false;
            this.AddEmp_btn.Click += new System.EventHandler(this.AddEmp_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.dashboard_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard_btn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.dashboard_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.dashboard_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.dashboard_btn.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_dashboard_30px;
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(31, 409);
            this.dashboard_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(244, 40);
            this.dashboard_btn.TabIndex = 2;
            this.dashboard_btn.Text = "DASHBOARD";
            this.dashboard_btn.UseVisualStyleBackColor = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // greet_user
            // 
            this.greet_user.AutoSize = true;
            this.greet_user.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greet_user.Location = new System.Drawing.Point(88, 162);
            this.greet_user.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.greet_user.Name = "greet_user";
            this.greet_user.Size = new System.Drawing.Size(122, 21);
            this.greet_user.TabIndex = 1;
            this.greet_user.Text = "Welcome, User";
            this.greet_user.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::EmployeeManagementSystem.Properties.Resources.icons8_employee_card_100px;
            this.pictureBox1.Location = new System.Drawing.Point(90, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 95);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dashboard1);
            this.panel3.Controls.Add(this.addEmployee1);
            this.panel3.Controls.Add(this.salary1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(304, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1135, 684);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dashboard1
            // 
            this.dashboard1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dashboard1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard1.Location = new System.Drawing.Point(0, 0);
            this.dashboard1.Margin = new System.Windows.Forms.Padding(4);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1135, 680);
            this.dashboard1.TabIndex = 5;
            // 
            // addEmployee1
            // 
            this.addEmployee1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addEmployee1.Location = new System.Drawing.Point(0, -1);
            this.addEmployee1.Margin = new System.Windows.Forms.Padding(4);
            this.addEmployee1.Name = "addEmployee1";
            this.addEmployee1.Size = new System.Drawing.Size(1222, 685);
            this.addEmployee1.TabIndex = 4;
            this.addEmployee1.Load += new System.EventHandler(this.addEmployee1_Load);
            // 
            // salary1
            // 
            this.salary1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.salary1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.salary1.Location = new System.Drawing.Point(0, 0);
            this.salary1.Margin = new System.Windows.Forms.Padding(4);
            this.salary1.Name = "salary1";
            this.salary1.Size = new System.Drawing.Size(1431, 684);
            this.salary1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 730);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label greet_user;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button salary_btn;
        private System.Windows.Forms.Button AddEmp_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private Salary salary1;
        private AddEmployee addEmployee1;
        private Dashboard dashboard1;
    }
}