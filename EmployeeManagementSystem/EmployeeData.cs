﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagementSystem
{
    internal class EmployeeData
    {

        public int ID { set; get; } // 0
        public string EmployeeID { set; get; } // 1
        public string Name { set; get; } // 2
        public string Gender { set; get; } // 3
        public string Contact { set; get; } // 4
        public string Position { set; get; } // 5
        public string Image { set; get; } // 6
        public int Salary { set; get; } // 7
        public string Status { set; get; } // 8


        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-G0GMS99;Initial Catalog=MYDB;Integrated Security=True; Encrypt=False");


        public List<EmployeeData> employeeListData()
        {
            List<EmployeeData> listdata = new List<EmployeeData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM employee1 WHERE delete_date IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            EmployeeData ed = new EmployeeData();
                            ed.ID = (int)reader["id"];
                            ed.EmployeeID = reader["employee_id"].ToString();
                            ed.Name = reader["full_name"].ToString();
                            ed.Gender = reader["gender"].ToString();
                            ed.Contact = reader["contact_number"].ToString();
                            ed.Position = reader["position"].ToString();
                            ed.Image = reader["image"].ToString();
                            ed.Salary = (int)reader["salary"];
                            ed.Status = reader["status"].ToString();

                            listdata.Add(ed);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listdata;
        }

  
    }
}
