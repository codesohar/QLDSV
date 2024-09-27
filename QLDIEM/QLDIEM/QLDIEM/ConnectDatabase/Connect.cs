using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLDIEM.ConnectDatabase
{
    internal class Connect
    {
        private String connect = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLDSV;Integrated Security=True";
        private SqlConnection sqlConnection = new SqlConnection();

        public Connect()
        {
            try
            {
                sqlConnection.ConnectionString = connect;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không kết nối được với Database!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        public void ExecuteNonQuery(String query)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Câu query ExecuteNonQuery bị lỗi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int ExecuteScalar(String query)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                int count = (int)sqlCommand.ExecuteScalar();
                sqlConnection.Close();
                return count;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public void QueryData(string query, DataGridView dataGridView)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
                dataGridView.DataSource = dataTable;
            }
            catch (Exception)
            {
                MessageBox.Show("Câu query QueryData bị lỗi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable DataTable(string query)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
                return dataTable;
            }
            catch (Exception)
            {
                MessageBox.Show("Câu query QueryData bị lỗi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable ReportData(string query)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();
                return dataTable;
            }
            catch (Exception)
            {
                MessageBox.Show("Câu query QueryData bị lỗi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
