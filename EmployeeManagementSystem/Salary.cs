using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    public partial class Salary : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-G0GMS99;Initial Catalog=MYDB;Integrated Security=True; Encrypt=False");
        public Salary()
        {
            InitializeComponent();
            displayEmployee();
            disableFiels();
        }
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            displayEmployee();
            disableFiels();
        }
        public void disableFiels()
        {
            Salary_employeeID.Enabled = false;
            Salary_employeefullname.Enabled = false;
            Salary_employeepotision.Enabled = false;
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void clearFields()
        {
            Salary_employeeID.Text = "";
            Salary_employeefullname.Text = "";
            Salary_employeepotision.Text = "";
            Salary_employeesalar.Text = "";
        }
        public void displayEmployee()
        {
            SalaryData ed = new SalaryData();
            List<SalaryData> listData = ed.salaryemployeeListData();

            dataGridView1.DataSource = listData;
        }
        private void salary_updateBtn_Click(object sender, EventArgs e)
        {
            if (Salary_employeeID.Text == ""
                 || Salary_employeefullname.Text == ""
                || Salary_employeepotision.Text == ""
                || Salary_employeesalar.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                  , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Employee ID: "
                   + Salary_employeeID.Text.Trim() + "?", "Confirmation Message"
                   , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();
                            DateTime today = DateTime.Today;

                            string updateData = "UPDATE employee1 SET salary = @salary" +
                                ", update_date = @updateData WHERE employee_id = @employeeID";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@salary", Salary_employeesalar.Text.Trim());
                                cmd.Parameters.AddWithValue("@updateData", today);
                                cmd.Parameters.AddWithValue("@employeeID", Salary_employeeID.Text.Trim());

                                cmd.ExecuteNonQuery();

                                displayEmployee();

                                MessageBox.Show("Updated successfully!"
                                    , "Information Message", MessageBoxButtons.OK
                                    , MessageBoxIcon.Information);

                                clearFields();

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled", "Information Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Salary_employeeID.Text = row.Cells[0].Value.ToString();
                Salary_employeefullname.Text = row.Cells[1].Value.ToString();
                Salary_employeepotision.Text = row.Cells[4].Value.ToString();
                Salary_employeesalar.Text = row.Cells[5].Value.ToString();



            }
        }
        private void salary_ClearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
