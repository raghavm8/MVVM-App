using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Module4__Assignment3.Models
{
    class DataAccess
    {
        SqlConnection con = new SqlConnection("Data Source = SONY\\RAGHAV; Initial Catalog = EmployeeWPF; User ID = sa; Password =raghav");

        internal ObservableCollection<Employee> getData()
        {
            ObservableCollection<Employee> lst = new ObservableCollection<Employee>();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from EmpData", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Employee c = new Employee();

                    c.Name = reader["Name"].ToString();
                    c.Gender = reader["Gender"].ToString();
                    c.Address = reader["Address"].ToString();
                    c.Age = Convert.ToInt32(reader["Age"]);

                    lst.Add(c);
                }
                con.Close();

                return lst;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return lst;
        }

        internal void postData(Employee e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into EmpData values(@Name, @Age, @Gender, @Address) ", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@Name", e.Name);
                cmd.Parameters.AddWithValue("@Age", e.Age);
                cmd.Parameters.AddWithValue("@Gender", e.Gender);
                cmd.Parameters.AddWithValue("@Address", e.Address);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        internal Employee getEmployee(object empId)
        {
            Employee e = new Employee();
            try
            {
                string equation = "Select * from EmpData where Id = " + "'" + empId + "'";
                SqlCommand cmd = new SqlCommand(equation, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    e.Name = reader["Name"].ToString();
                    e.Gender = reader["Gender"].ToString();
                    e.Address = reader["Address"].ToString();
                    e.Age = Convert.ToInt32(reader["Age"]);
                }
                con.Close();
                return e;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return e;
        }

        internal Employee makeEmpty(Employee e)
        {
            e.Name = "";
            e.Age = 0;
            e.Gender = "";
            e.Address = "";

            return e;
        }

        internal Employee putData(Employee e, int empId)
        {
            Employee employee = new Employee();
            try
            {
                con.Open();

                string equation = "update EmpData set Name = '" + e.Name + "',Age = '" + e.Age + "',Gender = '" + e.Gender + "',Address = '" + e.Address + "' where Id= '" + empId + "'";
                SqlCommand cmd = new SqlCommand(equation, con);
                cmd.ExecuteNonQuery();

                equation = "Select * from EmpData where Id = '" + empId + "'";
                cmd = new SqlCommand(equation, con);
                cmd.ExecuteNonQuery();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    employee.Name = reader["Name"].ToString();
                    employee.Gender = reader["Gender"].ToString();
                    employee.Address = reader["Address"].ToString();
                    employee.Age = Convert.ToInt32(reader["Age"]);
                }

                con.Close();

                return employee;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            return employee;
        }

        internal void deleteData(int empId)
        {
            try
            {
                con.Open();

                string equation = "Delete from EmpData where Id=" + empId;
                SqlCommand cmd = new SqlCommand(equation, con);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}