namespace EmployeeManagementSystem
{
    partial class Salary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Salary_employeeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Salary_employeefullname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Salary_employeepotision = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Salary_employeesalar = new System.Windows.Forms.TextBox();
            this.salary_updateBtn = new System.Windows.Forms.Button();
            this.salary_ClearBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employees";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(291, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(660, 517);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(22, 40);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(603, 456);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee ID :";
            // 
            // Salary_employeeID
            // 
            this.Salary_employeeID.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary_employeeID.Location = new System.Drawing.Point(18, 60);
            this.Salary_employeeID.Multiline = true;
            this.Salary_employeeID.Name = "Salary_employeeID";
            this.Salary_employeeID.Size = new System.Drawing.Size(219, 25);
            this.Salary_employeeID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Full Name :";
            // 
            // Salary_employeefullname
            // 
            this.Salary_employeefullname.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary_employeefullname.Location = new System.Drawing.Point(20, 139);
            this.Salary_employeefullname.Multiline = true;
            this.Salary_employeefullname.Name = "Salary_employeefullname";
            this.Salary_employeefullname.Size = new System.Drawing.Size(219, 25);
            this.Salary_employeefullname.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Position :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Salary_employeepotision
            // 
            this.Salary_employeepotision.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary_employeepotision.Location = new System.Drawing.Point(18, 219);
            this.Salary_employeepotision.Multiline = true;
            this.Salary_employeepotision.Name = "Salary_employeepotision";
            this.Salary_employeepotision.Size = new System.Drawing.Size(219, 25);
            this.Salary_employeepotision.TabIndex = 5;
            this.Salary_employeepotision.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Salary :";
            // 
            // Salary_employeesalar
            // 
            this.Salary_employeesalar.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary_employeesalar.Location = new System.Drawing.Point(18, 290);
            this.Salary_employeesalar.Multiline = true;
            this.Salary_employeesalar.Name = "Salary_employeesalar";
            this.Salary_employeesalar.Size = new System.Drawing.Size(219, 25);
            this.Salary_employeesalar.TabIndex = 7;
            // 
            // salary_updateBtn
            // 
            this.salary_updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.salary_updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salary_updateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salary_updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salary_updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salary_updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salary_updateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salary_updateBtn.Location = new System.Drawing.Point(20, 367);
            this.salary_updateBtn.Name = "salary_updateBtn";
            this.salary_updateBtn.Size = new System.Drawing.Size(95, 39);
            this.salary_updateBtn.TabIndex = 15;
            this.salary_updateBtn.Text = "UPDATE";
            this.salary_updateBtn.UseVisualStyleBackColor = false;
            this.salary_updateBtn.Click += new System.EventHandler(this.salary_updateBtn_Click);
            // 
            // salary_ClearBtn
            // 
            this.salary_ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.salary_ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salary_ClearBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salary_ClearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salary_ClearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.salary_ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salary_ClearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.salary_ClearBtn.Location = new System.Drawing.Point(142, 367);
            this.salary_ClearBtn.Name = "salary_ClearBtn";
            this.salary_ClearBtn.Size = new System.Drawing.Size(95, 39);
            this.salary_ClearBtn.TabIndex = 17;
            this.salary_ClearBtn.Text = "CLEAR";
            this.salary_ClearBtn.UseVisualStyleBackColor = false;
            this.salary_ClearBtn.Click += new System.EventHandler(this.salary_ClearBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.salary_ClearBtn);
            this.panel1.Controls.Add(this.salary_updateBtn);
            this.panel1.Controls.Add(this.Salary_employeesalar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Salary_employeepotision);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Salary_employeefullname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Salary_employeeID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(18, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 517);
            this.panel1.TabIndex = 0;
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Salary";
            this.Size = new System.Drawing.Size(971, 551);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Salary_employeeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Salary_employeefullname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Salary_employeepotision;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Salary_employeesalar;
        private System.Windows.Forms.Button salary_updateBtn;
        private System.Windows.Forms.Button salary_ClearBtn;
        private System.Windows.Forms.Panel panel1;
    }
}
