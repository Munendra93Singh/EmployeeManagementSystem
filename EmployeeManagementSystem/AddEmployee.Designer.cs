namespace EmployeeManagementSystem
{
    partial class AddEmployee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.addEmployee_Id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addEmployee_Fullname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addEmployee_phone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addEmployee_position = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addEmployee_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addEmployee_clrbtn = new System.Windows.Forms.Button();
            this.addEmployee_dltbtn = new System.Windows.Forms.Button();
            this.addEmployee_updatebtn = new System.Windows.Forms.Button();
            this.addEmployee_Addbtn = new System.Windows.Forms.Button();
            this.addEmployee_Importpic = new System.Windows.Forms.Button();
            this.addEmployee_picture = new System.Windows.Forms.PictureBox();
            this.addEmployee_gender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataSet1 = new System.Data.DataSet();
            this.dataSet2 = new System.Data.DataSet();
            this.dataSet3 = new System.Data.DataSet();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 268);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(846, 189);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Employee\'s Data";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(3, 260);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1139, 269);
            this.panel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID :";
            // 
            // addEmployee_Id
            // 
            this.addEmployee_Id.Location = new System.Drawing.Point(161, 22);
            this.addEmployee_Id.Name = "addEmployee_Id";
            this.addEmployee_Id.Size = new System.Drawing.Size(157, 27);
            this.addEmployee_Id.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Full Name :";
            // 
            // addEmployee_Fullname
            // 
            this.addEmployee_Fullname.Location = new System.Drawing.Point(161, 74);
            this.addEmployee_Fullname.Name = "addEmployee_Fullname";
            this.addEmployee_Fullname.Size = new System.Drawing.Size(157, 27);
            this.addEmployee_Fullname.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone Number :";
            // 
            // addEmployee_phone
            // 
            this.addEmployee_phone.Location = new System.Drawing.Point(480, 22);
            this.addEmployee_phone.Name = "addEmployee_phone";
            this.addEmployee_phone.Size = new System.Drawing.Size(176, 27);
            this.addEmployee_phone.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(402, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Position :";
            // 
            // addEmployee_position
            // 
            this.addEmployee_position.FormattingEnabled = true;
            this.addEmployee_position.Items.AddRange(new object[] {
            "Business Manager",
            "Backend Engineer",
            "Frontand Engineer",
            "Data Administrator",
            "UI/UX Engineer"});
            this.addEmployee_position.Location = new System.Drawing.Point(484, 75);
            this.addEmployee_position.Name = "addEmployee_position";
            this.addEmployee_position.Size = new System.Drawing.Size(172, 28);
            this.addEmployee_position.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.addEmployee_status);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.addEmployee_clrbtn);
            this.panel3.Controls.Add(this.addEmployee_dltbtn);
            this.panel3.Controls.Add(this.addEmployee_updatebtn);
            this.panel3.Controls.Add(this.addEmployee_Addbtn);
            this.panel3.Controls.Add(this.addEmployee_Importpic);
            this.panel3.Controls.Add(this.addEmployee_picture);
            this.panel3.Controls.Add(this.addEmployee_position);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.addEmployee_phone);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.addEmployee_gender);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.addEmployee_Fullname);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.addEmployee_Id);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(16, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(932, 246);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // addEmployee_status
            // 
            this.addEmployee_status.FormattingEnabled = true;
            this.addEmployee_status.Items.AddRange(new object[] {
            "Active",
            "InActive"});
            this.addEmployee_status.Location = new System.Drawing.Point(485, 115);
            this.addEmployee_status.Name = "addEmployee_status";
            this.addEmployee_status.Size = new System.Drawing.Size(172, 28);
            this.addEmployee_status.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(414, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Status :";
            // 
            // addEmployee_clrbtn
            // 
            this.addEmployee_clrbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addEmployee_clrbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_clrbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_clrbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_clrbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_clrbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_clrbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEmployee_clrbtn.Location = new System.Drawing.Point(628, 179);
            this.addEmployee_clrbtn.Name = "addEmployee_clrbtn";
            this.addEmployee_clrbtn.Size = new System.Drawing.Size(157, 44);
            this.addEmployee_clrbtn.TabIndex = 17;
            this.addEmployee_clrbtn.Text = "CLEAR";
            this.addEmployee_clrbtn.UseVisualStyleBackColor = false;
            this.addEmployee_clrbtn.Click += new System.EventHandler(this.addEmployee_clrbtn_Click);
            // 
            // addEmployee_dltbtn
            // 
            this.addEmployee_dltbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addEmployee_dltbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_dltbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_dltbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_dltbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_dltbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_dltbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEmployee_dltbtn.Location = new System.Drawing.Point(445, 179);
            this.addEmployee_dltbtn.Name = "addEmployee_dltbtn";
            this.addEmployee_dltbtn.Size = new System.Drawing.Size(157, 44);
            this.addEmployee_dltbtn.TabIndex = 16;
            this.addEmployee_dltbtn.Text = "DELETE";
            this.addEmployee_dltbtn.UseVisualStyleBackColor = false;
            this.addEmployee_dltbtn.Click += new System.EventHandler(this.addEmployee_dltbtn_Click);
            // 
            // addEmployee_updatebtn
            // 
            this.addEmployee_updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addEmployee_updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_updatebtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_updatebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_updatebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_updatebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEmployee_updatebtn.Location = new System.Drawing.Point(267, 179);
            this.addEmployee_updatebtn.Name = "addEmployee_updatebtn";
            this.addEmployee_updatebtn.Size = new System.Drawing.Size(157, 44);
            this.addEmployee_updatebtn.TabIndex = 15;
            this.addEmployee_updatebtn.Text = "UPDATE";
            this.addEmployee_updatebtn.UseVisualStyleBackColor = false;
            this.addEmployee_updatebtn.Click += new System.EventHandler(this.addEmployee_updatebtn_Click);
            // 
            // addEmployee_Addbtn
            // 
            this.addEmployee_Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addEmployee_Addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_Addbtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_Addbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_Addbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_Addbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEmployee_Addbtn.Location = new System.Drawing.Point(79, 179);
            this.addEmployee_Addbtn.Name = "addEmployee_Addbtn";
            this.addEmployee_Addbtn.Size = new System.Drawing.Size(157, 44);
            this.addEmployee_Addbtn.TabIndex = 14;
            this.addEmployee_Addbtn.Text = "ADD";
            this.addEmployee_Addbtn.UseVisualStyleBackColor = false;
            this.addEmployee_Addbtn.Click += new System.EventHandler(this.addEmployee_addBtn_Click);
            // 
            // addEmployee_Importpic
            // 
            this.addEmployee_Importpic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(11)))), ((int)(((byte)(97)))));
            this.addEmployee_Importpic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee_Importpic.FlatAppearance.BorderSize = 0;
            this.addEmployee_Importpic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_Importpic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(8)))), ((int)(((byte)(138)))));
            this.addEmployee_Importpic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee_Importpic.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee_Importpic.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addEmployee_Importpic.Location = new System.Drawing.Point(763, 118);
            this.addEmployee_Importpic.Name = "addEmployee_Importpic";
            this.addEmployee_Importpic.Size = new System.Drawing.Size(118, 37);
            this.addEmployee_Importpic.TabIndex = 13;
            this.addEmployee_Importpic.Text = "Import";
            this.addEmployee_Importpic.UseVisualStyleBackColor = false;
            this.addEmployee_Importpic.Click += new System.EventHandler(this.addEmployee_Importpic_Click);
            // 
            // addEmployee_picture
            // 
            this.addEmployee_picture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addEmployee_picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addEmployee_picture.Location = new System.Drawing.Point(763, 17);
            this.addEmployee_picture.Name = "addEmployee_picture";
            this.addEmployee_picture.Size = new System.Drawing.Size(118, 101);
            this.addEmployee_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addEmployee_picture.TabIndex = 12;
            this.addEmployee_picture.TabStop = false;
            // 
            // addEmployee_gender
            // 
            this.addEmployee_gender.FormattingEnabled = true;
            this.addEmployee_gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.addEmployee_gender.Location = new System.Drawing.Point(161, 123);
            this.addEmployee_gender.Name = "addEmployee_gender";
            this.addEmployee_gender.Size = new System.Drawing.Size(157, 28);
            this.addEmployee_gender.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "NewDataSet";
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "NewDataSet";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(964, 660);
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployee_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addEmployee_Id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addEmployee_Fullname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addEmployee_phone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox addEmployee_position;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addEmployee_clrbtn;
        private System.Windows.Forms.Button addEmployee_dltbtn;
        private System.Windows.Forms.Button addEmployee_updatebtn;
        private System.Windows.Forms.Button addEmployee_Addbtn;
        private System.Windows.Forms.Button addEmployee_Importpic;
        private System.Windows.Forms.PictureBox addEmployee_picture;
        private System.Windows.Forms.ComboBox addEmployee_gender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox addEmployee_status;
        private System.Windows.Forms.Label label7;
        private System.Data.DataSet dataSet1;
        private System.Data.DataSet dataSet2;
        private System.Data.DataSet dataSet3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
