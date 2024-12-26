using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace EmployeeManagementSystem
{
    public partial class AddEmployee : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-G0GMS99;Initial Catalog=MYDB;Integrated Security=True; Encrypt=False");

        public AddEmployee()
        {
            InitializeComponent();

            // TO DISPLAY THE DATA FROM DATABASE TO YOUR DATA GRID VIEW
            displayEmployeeData();
        }
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayEmployeeData();
        }
        public void displayEmployeeData()
        {
            EmployeeData ed = new EmployeeData();
            List<EmployeeData> listData = ed.employeeListData();

            dataGridView1.DataSource = listData;
        }
        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addEmployee_addBtn_Click(object sender, EventArgs e)
        {
            if (addEmployee_Id.Text == ""
                || addEmployee_Fullname.Text == ""
                || addEmployee_gender.Text == ""
                || addEmployee_phone.Text == ""
                || addEmployee_position.Text == ""
                || addEmployee_status.Text == ""
                || addEmployee_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        //string checkEmID = "SELECT COUNT(*) FROM employees WHERE employee_id = @emID AND delete_date IS NULL";
                        string checkEmID = "SELECT COUNT(*) FROM employee1 WHERE employee_id = @emID AND delete_date IS NULL";

                        using (SqlCommand checkEm = new SqlCommand(checkEmID, connect))
                        {
                            checkEm.Parameters.AddWithValue("@emID", addEmployee_Id.Text.Trim());
                            int count = (int)checkEm.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(addEmployee_Id.Text.Trim() + " is already taken"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO employee1 " +
                                    "(employee_id, full_name, gender, contact_number" +
                                    ", position, image, salary, insert_date, status) " +
                                    " VALUES(@employeeID, @fullName, @gender, @contactNum" +
                                    ", @position, @image,@salary, @insertDate, @status)";

                                string path = Path.Combine(@"E:\Practice_Project\DotNet2024\EmployeeManagementSystem\EmployeeManagementSystem\Directory\"
                                    + addEmployee_Id.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(addEmployee_picture.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@employeeID", addEmployee_Id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullName", addEmployee_Fullname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", addEmployee_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contactNum", addEmployee_phone.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", addEmployee_position.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@salary", 0);
                                    cmd.Parameters.AddWithValue("@insertDate", today);
                                    cmd.Parameters.AddWithValue("@status", addEmployee_status.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    displayEmployeeData();

                                    MessageBox.Show("Added successfully!"
                                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void addEmployee_Importpic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";

                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    addEmployee_picture.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                addEmployee_Id.Text = row.Cells[1].Value.ToString();
                addEmployee_Fullname.Text = row.Cells[2].Value.ToString();
                addEmployee_gender.Text = row.Cells[3].Value.ToString();
                addEmployee_phone.Text = row.Cells[4].Value.ToString();
                addEmployee_position.Text = row.Cells[5].Value.ToString();
                string imagePath = row.Cells[6].Value.ToString();

                if (imagePath != null)
                {
                    addEmployee_picture.Image = Image.FromFile(imagePath);
                }
                else
                {
                    addEmployee_picture.Image = null;
                }

                addEmployee_status.Text = row.Cells[8].Value.ToString();

            }
        }
        public void clearFields()
        {
            addEmployee_Id.Text = "";
            addEmployee_Fullname.Text = "";
            addEmployee_gender.SelectedIndex = -1;
            addEmployee_phone.Text = "";
            addEmployee_position.SelectedIndex = -1;
            addEmployee_status.SelectedIndex = -1;
            addEmployee_picture.Image = null;
        }
        private void addEmployee_updatebtn_Click(object sender, EventArgs e)
        {
            if (addEmployee_Id.Text == ""
                || addEmployee_Fullname.Text == ""
                || addEmployee_gender.Text == ""
                || addEmployee_phone.Text == ""
                || addEmployee_position.Text == ""
                || addEmployee_status.Text == ""
                || addEmployee_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you Sure, You want to UPDATE "+
                    "Employee ID:" +addEmployee_Id.Text.Trim() +"?","Confirmation Message"
                    ,MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "Update employee1 SET full_name = @full_name" +
                           ", gender = @gender, contact_number = @contact_number" +
                            ", position = @position, update_date = @updateDate, status = @status " +
                            "WHERE employee_id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@full_name", addEmployee_Fullname.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", addEmployee_gender.Text.Trim());
                            cmd.Parameters.AddWithValue("@contact_number", addEmployee_phone.Text.Trim());
                            cmd.Parameters.AddWithValue("@position", addEmployee_position.Text.Trim());
                            cmd.Parameters.AddWithValue("@updateDate", today);
                            cmd.Parameters.AddWithValue("@status", addEmployee_status.Text.Trim());
                            cmd.Parameters.AddWithValue("@employeeID", addEmployee_Id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();

                            MessageBox.Show("Update successfully!"
                               , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                      , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }   
                else
                {
                    MessageBox.Show("Calcelled: "
                     , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
        }
        private void addEmployee_clrbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void addEmployee_dltbtn_Click(object sender, EventArgs e)
        {
            if (addEmployee_Id.Text == ""
                || addEmployee_Fullname.Text == ""
                || addEmployee_gender.Text == ""
                || addEmployee_phone.Text == ""
                || addEmployee_position.Text == ""
                || addEmployee_status.Text == ""
                || addEmployee_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                    "Employee ID: " + addEmployee_Id.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE employee1 SET delete_date = @deleteDate " +
                            "WHERE employee_id = @employeeID";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@deleteDate", today);
                            cmd.Parameters.AddWithValue("@employeeID", addEmployee_Id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployeeData();

                            MessageBox.Show("Update successfully!"
                                , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                        , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled."
                        , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
}