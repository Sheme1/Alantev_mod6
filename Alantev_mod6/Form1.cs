using System.Data;
using System.Data.SqlClient;
using System.Xml.Serialization;

namespace Alantev_mod6
{
    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateColums()
        {
            dataGridView1.Columns.Add("EmployeeID", "id");
            dataGridView1.Columns.Add("FirstName", "FirstName");
            dataGridView1.Columns.Add("LastName", "LastName");
            dataGridView1.Columns.Add("Position", "Position");
            dataGridView1.Columns.Add("DateOfHire", "DateOfHire");
        }

        private void ReadSingleRow(DataGridView dgw, IDataReader record)
        {
            DateTime dateTime = record.GetDateTime(4);
            string dateOnlyString = dateTime.ToString("dd.MM.yyyy");
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), dateOnlyString);
        }


        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string query = $"select * from Employees";

            SqlCommand command = new SqlCommand(query, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateColums();
            RefreshDataGrid(dataGridView1);
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            string FirstName = textBox1.Text;
            string LastName = textBox2.Text;
            string Position = textBox3.Text;
            DateTime newDateOfHire = DateTime.Parse(textBox4.Text);
            string formattedDate = newDateOfHire.ToString("yyyy-MM-dd");
            string query = $"insert into Employees (FirstName, LastName, Position, DateOfHire) values ('{FirstName}','{LastName}','{Position}','{formattedDate}')";
            SqlCommand command = new SqlCommand(query, dataBase.getConnection());

            dataBase.openConnection();

            int affectedRows = command.ExecuteNonQuery();

            dataBase.closeConnection();

            if (affectedRows > 0)
            {
                RefreshDataGrid(dataGridView1);
            }
        }


        private void Changebutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int rowID = int.Parse(dataGridView1[0, selectedIndex].Value.ToString());

                // Получите новые данные, которые вы хотите обновить
                string newFirstName = textBox1.Text;
                string newLastName = textBox2.Text;
                string newPosition = textBox3.Text;
                string newDateOfHire = textBox4.Text;

                string query = $"UPDATE Employees SET FirstName = '{newFirstName}', LastName = '{newLastName}', Position = '{newPosition}', DateOfHire = '{newDateOfHire}' WHERE EmployeeID = {rowID}";
                SqlCommand command = new SqlCommand(query, dataBase.getConnection());

                dataBase.openConnection();

                int affectedRows = command.ExecuteNonQuery();

                dataBase.closeConnection();

                if (affectedRows > 0)
                {
                    dataGridView1.Rows[selectedIndex].Cells["FirstName"].Value = newFirstName;
                    dataGridView1.Rows[selectedIndex].Cells["LastName"].Value = newLastName;
                    dataGridView1.Rows[selectedIndex].Cells["Position"].Value = newPosition;
                    dataGridView1.Rows[selectedIndex].Cells["DateOfHire"].Value = newDateOfHire;
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для обновления");
            }
        }


        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                int rowID = int.Parse(dataGridView1[0, selectedIndex].Value.ToString());

                string query = $"DELETE FROM Employees WHERE EmployeeID = {rowID}";
                SqlCommand command = new SqlCommand(query, dataBase.getConnection());

                dataBase.openConnection();

                int affectedRows = command.ExecuteNonQuery();

                dataBase.closeConnection();

                if (affectedRows > 0)
                {
                    dataGridView1.Rows.RemoveAt(selectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления");
            }
        }

    }
}