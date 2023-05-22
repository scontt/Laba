using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        string host = "localhost";
        string database = "zoodb";
        string user = "root";
        string password = "";
        string connect;
        string sql = "select * from animals";
        int index = 0;
        MySqlCommandBuilder builder;

        public Form1()
        {
            InitializeComponent();

            dataSet.Clear();

            connect = "Database=" + database + ";Datasource=" + host + ";User=" + user + ";Password=" + password + ";CharSet=utf8;Allow Zero Datetime = true";
            using (connection = new MySqlConnection(connect))
            {
                dataAdapter = new MySqlDataAdapter(sql, connection);
                dataAdapter.Fill(dataSet.Tables[0]);
            }
            dataGridView1.DataSource = bindingSource;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Columns[0].ReadOnly = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите сохранить изменения?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (connection = new MySqlConnection(connect))
                {
                    connection.Open();
                    dataAdapter = new MySqlDataAdapter(sql, connection);
                    builder = new MySqlCommandBuilder(dataAdapter);
                    bindingSource.EndEdit();
                    builder.GetInsertCommand();
                    dataAdapter.Update(dataSet.Tables[0]);
                    dataSet.Clear();
                    dataAdapter.Fill(dataSet.Tables[0]);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (connection = new MySqlConnection(connect))
            {
                dataAdapter = new MySqlDataAdapter(sql, connection);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(dataAdapter);
                dataAdapter.Update(dataSet.Tables["Table1"]);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"animalName like '%{searchTextBox.Text.Trim()}%'";
                DataRowCollection allRows = dataSet.Tables[0].Rows;
                DataRow[] searchedRows = dataSet.Tables[0].Select(query);
                if(searchedRows.Length == 0)
                {
                    dataGridView1.CurrentCell = default;
                    MessageBox.Show("Результатов не найдено", "Поиск");
                    return;
                }
                int rowIndex = allRows.IndexOf(searchedRows[index]);
                dataGridView1.CurrentCell = dataGridView1[0, rowIndex];
                index++;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Поиск закончен", "Поиск");
                return;
            }
        }

        private void cancelSearchButton_Click(object sender, EventArgs e)
        {
            index = 0;
            dataGridView1.CurrentCell = default;
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            bindingSource.Filter = "animalType like '" + filterTextBox.Text.Trim() + "'";
            dataGridView1.DataSource = bindingSource;
        }

        private void cancelFilterButton_Click(object sender, EventArgs e)
        {
            bindingSource.Filter = default;
            dataGridView1.DataSource = bindingSource;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            string query = "insert into animals(animalName, animalType, maxWeight, color, redDate, avgLife, flyingAbilities) " +
                $"values(@animalName, @animalType, @maxWeight, @color, @redDate, @avgLife, @flyingAbilities)";

            using (connection = new MySqlConnection(connect))
            {
                connection.Open();
                mySqlCommand1 = new MySqlCommand(query, connection);

                mySqlCommand1.Parameters.Add(new MySqlParameter("@animalName", animalNameTextBox.Text));
                mySqlCommand1.Parameters.Add(new MySqlParameter("@animalType", animalTypeTextBox.Text));
                mySqlCommand1.Parameters.Add(new MySqlParameter("@maxWeight", Convert.ToInt32(maxWeightTextBox.Text)));
                mySqlCommand1.Parameters.Add(new MySqlParameter("@color", colorTextBox.Text));
                mySqlCommand1.Parameters.Add(new MySqlParameter("@redDate", redDateTextBox.Text));
                mySqlCommand1.Parameters.Add(new MySqlParameter("@avgLife", Convert.ToInt32(avgLifeTextBox.Text)));
                mySqlCommand1.Parameters.Add(new MySqlParameter("@flyingAbilities", flyingAbilitiesTextBox.Text));

                mySqlCommand1.ExecuteNonQuery();
            }
            dataAdapter.Fill(dataSet);
            dataSet.Clear();
            dataAdapter.Fill(dataSet.Tables[0]);
            bindingSource.ResetBindings(false);
        }

        private void deleteCurrentRowButton_Click(object sender, EventArgs e)
        {
            int k = dataGridView1.CurrentCell.RowIndex;
            string query = "delete from animals where ID = @ID";

            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("В таблице нет строк!");
                return;
            }
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить текущую запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (connection = new MySqlConnection(connect))
                {
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.Add(new MySqlParameter("@ID", Convert.ToInt32(dataGridView1.Rows[k].Cells[0].Value)));

                    connection.Open();
                    command.ExecuteNonQuery();

                    dataAdapter.Fill(dataSet);
                    dataSet.Clear();
                    dataAdapter.Fill(dataSet.Tables[0]);
                }
            }
        }

        private void updateRowButton_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = dataSet;
            bindingSource.DataMember = "Table1";
            dataGridView1.DataSource = bindingSource;

            string query = $"update animals set animalName = @animalName, " +
                $"animalType = @animalType, " +
                $"maxWeight = @maxWeight, " +
                $"color = @color, " +
                $"redDate = @redDate, " +
                $"avgLife = @avgLife, " +
                $"flyingAbilities = @flyingAbilities " +
                $"where ID = @ID";

            using (connection = new MySqlConnection(connect))
            {
                connection.Open();
                mySqlCommand1 = new MySqlCommand(query, connection);

                mySqlCommand1.Parameters.Add(new MySqlParameter("@animalName", animalNameTextBox.Text));
                mySqlCommand1.Parameters.Add(new MySqlParameter("@animalType", animalTypeTextBox.Text));
                mySqlCommand1.Parameters.Add(new MySqlParameter("@maxWeight", Convert.ToInt32(maxWeightTextBox.Text)));
                mySqlCommand1.Parameters.Add(new MySqlParameter("@color", colorTextBox.Text));
                mySqlCommand1.Parameters.Add(new MySqlParameter("@redDate", redDateTextBox.Text));
                mySqlCommand1.Parameters.Add(new MySqlParameter("@avgLife", Convert.ToInt32(avgLifeTextBox.Text)));
                mySqlCommand1.Parameters.Add(new MySqlParameter("@flyingAbilities", flyingAbilitiesTextBox.Text));
                mySqlCommand1.Parameters.Add(new MySqlParameter("@ID", Convert.ToInt32(idTextBox.Text)));

                mySqlCommand1.ExecuteNonQuery();
                dataAdapter.Fill(dataSet);
                dataSet.Clear();
                dataAdapter.Fill(dataSet.Tables[0]);
            }
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            string query = $"delete from animals where ID = {Convert.ToInt32(idTextBox.Text)} ";

            using (connection = new MySqlConnection(connect))
            {
                connection.Open();
                mySqlCommand1 = new MySqlCommand(query, connection);
                mySqlCommand1.ExecuteNonQuery();
                dataAdapter.Fill(dataSet);
                dataSet.Clear();
                dataAdapter.Fill(dataSet.Tables[0]);
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            int k = 0;
            try
            {
                k = dataGridView1.CurrentCell.RowIndex;

                idTextBox.Text = dataGridView1.Rows[k].Cells[0].Value.ToString();
                animalNameTextBox.Text = dataGridView1.Rows[k].Cells[1].Value.ToString();
                animalTypeTextBox.Text = dataGridView1.Rows[k].Cells[2].Value.ToString();
                maxWeightTextBox.Text = dataGridView1.Rows[k].Cells[3].Value.ToString();
                colorTextBox.Text = dataGridView1.Rows[k].Cells[4].Value.ToString();
                redDateTextBox.Text = dataGridView1.Rows[k].Cells[5].Value.ToString();
                avgLifeTextBox.Text = dataGridView1.Rows[k].Cells[6].Value.ToString();
                flyingAbilitiesTextBox.Text = dataGridView1.Rows[k].Cells[7].Value.ToString();
            }
            catch
            {
                return;
            }
        }

        private void changeCurrentRowButton_Click(object sender, EventArgs e)
        {
            string query = $"update animals set animalName = @animalName, " +
                $"animalType = @animalType, " +
                $"maxWeight = @maxWeight, " +
                $"color = @color, " +
                $"redDate = @redDate, " +
                $"avgLife = @avgLife, " +
                $"flyingAbilities = @flyingAbilities " +
                $"where ID = @ID";
            try
            {
                connection = new MySqlConnection(connect);
                mySqlCommand1 = new MySqlCommand(query, connection);

                mySqlCommand1.Parameters.Add(new MySqlParameter("@animalName", animalNameTextBox.Text));
                mySqlCommand1.Parameters.Add(new MySqlParameter("@animalType", animalTypeTextBox.Text));
                mySqlCommand1.Parameters.Add(new MySqlParameter("@maxWeight", Convert.ToInt32(maxWeightTextBox.Text)));
                mySqlCommand1.Parameters.Add(new MySqlParameter("@color", colorTextBox.Text));
                mySqlCommand1.Parameters.Add(new MySqlParameter("@redDate", redDateTextBox.Text));
                mySqlCommand1.Parameters.Add(new MySqlParameter("@avgLife", Convert.ToInt32(avgLifeTextBox.Text)));
                mySqlCommand1.Parameters.Add(new MySqlParameter("@flyingAbilities", flyingAbilitiesTextBox.Text));
                mySqlCommand1.Parameters.Add(new MySqlParameter("@ID", Convert.ToInt32(idTextBox.Text)));

                connection.Open();
                mySqlCommand1.ExecuteNonQuery();
                connection.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорретные данные", "Ошибка");
                return;
            }
            dataSet.Clear();
            dataAdapter.Fill(dataSet.Tables[0]);
            //bindingSource1.ResetBindings(false);
        }

        private void idTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) return;
            if (char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.searchButton_Click(sender, e);
            }
        }

        private void filterTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.filterButton_Click(sender, e);
            }
        }

        private void openEmpButton_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 empForm = new Form2();
            empForm.ShowDialog();
            Show();
        }

        private void redDateFilter_Click(object sender, EventArgs e)
        {
            dataSet.Tables[1].Clear();
            string query = "select * from animals where redDate > '2004.12.31' and avgLife < 11";

            using(connection = new MySqlConnection(connect))
            {
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataSet.Tables[1].Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]);
                }

                bindingSource.DataSource = dataSet.Tables[1];
            }
        }

        private void empCountFilter_Click(object sender, EventArgs e)
        {
            dataSet.Tables["FilterEmp"].Clear();
            string query = "select animals.ID, animals.animalName, employees.ID as 'empID', employees.name, employees.applyYear from animals " +
                "inner join employees on animals.ID = employees.ID_animal " +
                "where @year - employees.applyYear > 4";
            DataTable dataTable = new DataTable();
            using (connection = new MySqlConnection(connect))
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add(new MySqlParameter("@year", Convert.ToInt32(DateTime.Now.Year)));

                connection.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataSet.Tables["FilterEmp"].Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4]);
                }

                bindingSource.DataSource = dataSet.Tables["FilterEmp"];
                dataGridView1.ReadOnly = true;
            }
        }

        private void cancelQueryFilterButton_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            bindingSource.DataSource = dataSet;
            bindingSource.DataMember = "Table1";
        }
    }
}
