using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Bcpg.OpenPgp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static Mysqlx.Expect.Open.Types;

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
        string date = string.Empty;
        int index = 0;
        StringBuilder sb = new StringBuilder();
        MySqlCommandBuilder builder;
        DataSet dataSet = new DataSet();

        public Form1()
        {
            InitializeComponent();

            dataSet.Clear();

            connect = "Database=" + database + ";Datasource=" + host + ";User=" + user + ";Password=" + password + ";CharSet=utf8;Allow Zero Datetime = true";
            using (connection = new MySqlConnection(connect))
            {
                dataAdapter = new MySqlDataAdapter(sql, connection);
                dataAdapter.Fill(dataSet);
            }
            dataGridView1.DataSource = dataSet.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Columns[0].ReadOnly = true;

            bindingSource.DataSource = dataSet.Tables[0];
            dataGridView1.DataSource = bindingSource;
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
                dataAdapter.Update(dataSet.Tables[0]);
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
            bindingSource.Filter = $"animalType like '{filterTextBox.Text.Trim()}'";
            dataGridView1.DataSource = bindingSource;
        }

        private void cancelFilterButton_Click(object sender, EventArgs e)
        {
            bindingSource.Filter = default;
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            string query = "insert into animals(animalName, animalType, maxWeight, color, redDate, avgLife, flyingAbilities) " +
                $"values(@animalName, @animalType, @maxWeight, @color, @redDate, @avgLife, @flyingAbilities)";

            sb.Clear();
            if (redDateTextBox.Text.Length == 10)
            {
                string yyyy = redDateTextBox.Text.Substring(6, 4);
                string dd = redDateTextBox.Text.Substring(3, 2);
                string mm = redDateTextBox.Text.Substring(0, 2);

                sb.Append(yyyy + ".");
                sb.Append(mm + ".");
                sb.Append(dd);
            }

            using (connection = new MySqlConnection(connect))
            {
                connection.Open();
                command = new MySqlCommand(query, connection);

                command.Parameters.Add(new MySqlParameter("@animalName", animalNameTextBox.Text));
                command.Parameters.Add(new MySqlParameter("@animalType", animalTypeTextBox.Text));
                command.Parameters.Add(new MySqlParameter("@maxWeight", Convert.ToInt32(maxWeightTextBox.Text)));
                command.Parameters.Add(new MySqlParameter("@color", colorTextBox.Text));
                command.Parameters.Add(new MySqlParameter("@redDate", sb.ToString()));
                command.Parameters.Add(new MySqlParameter("@avgLife", Convert.ToInt32(avgLifeTextBox.Text)));
                command.Parameters.Add(new MySqlParameter("@flyingAbilities", flyingAbilitiesTextBox.Text));

                command.ExecuteNonQuery();
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
            string empQuery = "select ID_animal from employees where ID_animal = @ID_animal";
            string empDeleteQuery = "delete from employees where ID_animal = @ID_animal";

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
                    command = new MySqlCommand(query, connection);
                    command.Parameters.Add(new MySqlParameter("@ID", Convert.ToInt32(dataGridView1.Rows[k].Cells[0].Value)));

                    MySqlCommand empCommand = new MySqlCommand(empQuery, connection);
                    empCommand.Parameters.Add(new MySqlParameter("@ID_animal", Convert.ToInt32(dataGridView1.Rows[k].Cells[0].Value)));

                    connection.Open();

                    MySqlDataReader reader = empCommand.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Close();
                        MySqlCommand empDeleteCommand = new MySqlCommand(empDeleteQuery, connection);
                        empDeleteCommand.Parameters.Add(new MySqlParameter("@ID_animal", Convert.ToInt32(dataGridView1.Rows[k].Cells[0].Value)));
                        empDeleteCommand.ExecuteNonQuery();
                    }
                    reader.Close();

                    command.ExecuteNonQuery();
                    dataAdapter.Fill(dataSet);
                    dataSet.Clear();
                    dataAdapter.Fill(dataSet.Tables[0]);
                }
            }
        }

        private void updateRowButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataSet.Tables[0];
            string query = $"update animals set " +
                $"animalName = @animalName, " +
                $"animalType = @animalType, " +
                $"maxWeight = @maxWeight, " +
                $"color = @color, " +
                $"redDate = @redDate, " +
                $"avgLife = @avgLife, " +
                $"flyingAbilities = @flyingAbilities " +
                $"where ID = @ID";

            sb.Clear();
            if (redDateTextBox.Text.Length == 10)
            {
                string yyyy = redDateTextBox.Text.Substring(6, 4);
                string dd = redDateTextBox.Text.Substring(3, 2);
                string mm = redDateTextBox.Text.Substring(0, 2);

                sb.Append(yyyy + ".");
                sb.Append(mm + ".");
                sb.Append(dd);
            }

            using (connection = new MySqlConnection(connect))
            {
                connection.Open();
                command = new MySqlCommand(query, connection);

                command.Parameters.Add(new MySqlParameter("@animalName", animalNameTextBox.Text));
                command.Parameters.Add(new MySqlParameter("@animalType", animalTypeTextBox.Text));
                command.Parameters.Add(new MySqlParameter("@maxWeight", Convert.ToInt32(maxWeightTextBox.Text)));
                command.Parameters.Add(new MySqlParameter("@color", colorTextBox.Text));
                command.Parameters.Add(new MySqlParameter("@redDate", redDateTextBox.Text));
                command.Parameters.Add(new MySqlParameter("@avgLife", Convert.ToInt32(avgLifeTextBox.Text)));
                command.Parameters.Add(new MySqlParameter("@flyingAbilities", flyingAbilitiesTextBox.Text));
                command.Parameters.Add(new MySqlParameter("@ID", Convert.ToInt32(idTextBox.Text)));



                command.ExecuteNonQuery();
                dataAdapter.Fill(dataSet);
                dataSet.Clear();
                dataAdapter.Fill(dataSet.Tables[0]);
            }
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            string query = "delete from animals where ID = @ID";
            string empQuery = "select ID_animal from employees where ID_animal = @ID_animal";
            string empDeleteQuery = "delete from employees where ID_animal = @ID_animal";

            using (connection = new MySqlConnection(connect))
            {
                command = new MySqlCommand(query, connection);
                command.Parameters.Add(new MySqlParameter("@ID", Convert.ToInt32(idTextBox.Text)));

                MySqlCommand empCommand = new MySqlCommand(empQuery, connection);
                empCommand.Parameters.Add(new MySqlParameter("@ID_animal", Convert.ToInt32(idTextBox.Text)));

                connection.Open();
                MySqlDataReader reader = empCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();
                    MySqlCommand empDeleteCommand = new MySqlCommand(empDeleteQuery, connection);
                    empDeleteCommand.Parameters.Add(new MySqlParameter("@ID_animal", Convert.ToInt32(idTextBox.Text)));
                    empDeleteCommand.ExecuteNonQuery();
                }
                reader.Close();

                command.ExecuteNonQuery();
                dataAdapter.Fill(dataSet);
                dataSet.Clear();
                dataAdapter.Fill(dataSet.Tables[0]);
            }
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell != null && dataGridView1.Columns.Count == 8)
            {
                int k = dataGridView1.CurrentCell.RowIndex;

                idTextBox.Text = dataGridView1.Rows[k].Cells[0].Value.ToString();
                animalNameTextBox.Text = dataGridView1.Rows[k].Cells[1].Value.ToString();
                animalTypeTextBox.Text = dataGridView1.Rows[k].Cells[2].Value.ToString();
                maxWeightTextBox.Text = dataGridView1.Rows[k].Cells[3].Value.ToString();
                colorTextBox.Text = dataGridView1.Rows[k].Cells[4].Value.ToString();
                redDateTextBox.Text = dataGridView1.Rows[k].Cells[5].Value.ToString();
                avgLifeTextBox.Text = dataGridView1.Rows[k].Cells[6].Value.ToString();
                flyingAbilitiesTextBox.Text = dataGridView1.Rows[k].Cells[7].Value.ToString();
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

            sb.Clear();
            if (redDateTextBox.Text.Length == 10)
            {
                string yyyy = redDateTextBox.Text.Substring(6, 4);
                string dd = redDateTextBox.Text.Substring(3, 2);
                string mm = redDateTextBox.Text.Substring(0, 2);

                sb.Append(yyyy + ".");
                sb.Append(mm + ".");
                sb.Append(dd);
            }

            try
            {
                connection = new MySqlConnection(connect);
                command = new MySqlCommand(query, connection);

                command.Parameters.Add(new MySqlParameter("@animalName", animalNameTextBox.Text));
                command.Parameters.Add(new MySqlParameter("@animalType", animalTypeTextBox.Text));
                command.Parameters.Add(new MySqlParameter("@maxWeight", Convert.ToInt32(maxWeightTextBox.Text)));
                command.Parameters.Add(new MySqlParameter("@color", colorTextBox.Text));
                command.Parameters.Add(new MySqlParameter("@redDate", sb.ToString()));
                command.Parameters.Add(new MySqlParameter("@avgLife", Convert.ToInt32(avgLifeTextBox.Text)));
                command.Parameters.Add(new MySqlParameter("@flyingAbilities", flyingAbilitiesTextBox.Text));
                command.Parameters.Add(new MySqlParameter("@ID", Convert.ToInt32(idTextBox.Text)));

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены некорретные данные", "Ошибка");
                return;
            }
            dataSet.Clear();
            dataAdapter.Fill(dataSet.Tables[0]);
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
                searchButton_Click(sender, e);
            }
        }

        private void filterTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                filterButton_Click(sender, e);
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
            if (dataSet.Tables.Contains("redDateFilter"))
            {
                dataGridView1.DataSource = dataSet.Tables[1];
            }
            else
            {
                dataSet.Tables.Add("redDateFilter");
                string query = "select * from animals where redDate > '2004.12.31' and avgLife < 20";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                dataAdapter = new MySqlDataAdapter(cmd);

                dataAdapter.Fill(dataSet.Tables["redDateFilter"]);

                dataGridView1.DataSource = dataSet.Tables["redDateFilter"];
            }
        }

        private void empCountFilter_Click(object sender, EventArgs e)
        {
            string query = "select animals.ID, animals.animalName, employees.ID as 'empID', employees.name, employees.applyYear from animals " +
                "inner join employees on animals.ID = employees.ID_animal " +
                "where @year - employees.applyYear > 4";

            if (dataSet.Tables.Contains("empCountFilter"))
            {
                dataGridView1.DataSource = dataSet.Tables["empCountFilter"];
            }
            else
            {
                dataSet.Tables.Add("empCountFilter");
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add(new MySqlParameter("@year", Convert.ToInt32(DateTime.Now.Year)));

                dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.Fill(dataSet.Tables["empCountFilter"]);
                dataGridView1.DataSource = dataSet.Tables["empCountFilter"];
                dataGridView1.ReadOnly = true;
            }
        }

        private void cancelQueryFilterButton_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void empSalaryFilter_Click(object sender, EventArgs e)
        {
            string query = "select animals.animalType, min(animals.avgLife) as 'minimal average lifetime', count(employees.ID) as 'employees count', employees.salary from animals " +
                "inner join employees on animals.ID = employees.ID_animal " +
                "group by animals.animalType having salary > 24999";

            if (dataSet.Tables.Contains("empSalaryFilter"))
            {
                dataGridView1.DataSource = dataSet.Tables["empSalaryFilter"];
            }
            else
            {
                dataSet.Tables.Add("empSalaryFilter");
                MySqlCommand cmd = new MySqlCommand(query, connection);

                dataAdapter = new MySqlDataAdapter(cmd);
                dataAdapter.Fill(dataSet.Tables["empSalaryFilter"]);
                dataGridView1.DataSource = dataSet.Tables["empSalaryFilter"];
                dataGridView1.ReadOnly = true;
            }

        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            string query;

            sb.Clear();
            if (selectRedDateTextBox.Text.Length == 10)
            {
                string yyyy = redDateTextBox.Text.Substring(6, 4);
                string dd = redDateTextBox.Text.Substring(3, 2);
                string mm = redDateTextBox.Text.Substring(0, 2);

                sb.Append(yyyy + ".");
                sb.Append(mm + ".");
                sb.Append(dd);
            }

            if (sb.Length != 0)
            {
                query = "select * from animals where animalType = @animalType and redDate <= @redDate and avgLife <= @avgLife";
                command = new MySqlCommand(query, connection);
                command.Parameters.Add(new MySqlParameter("@animalType", selectAnimalTypeTextBox.Text));
                command.Parameters.Add(new MySqlParameter("@redDate", sb.ToString()));
                command.Parameters.Add(new MySqlParameter("@avgLife", Convert.ToInt32(selectAvgLifeTextBox.Text)));
            }
            else
            {
                query = "select * from animals where animalType = @animalType and avgLife <= @avgLife";
                command = new MySqlCommand(query, connection);
                command.Parameters.Add(new MySqlParameter("@animalType", selectAnimalTypeTextBox.Text));
                command.Parameters.Add(new MySqlParameter("@avgLife", Convert.ToInt32(selectAvgLifeTextBox.Text)));
            }

            dataAdapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
            dataGridView1.ReadOnly = true;
        }

        private void cancelSelectButton_Click(object sender, EventArgs e)
        {
            cancelFilterButton_Click(sender, e);
        }

        private void xmlExportButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("../../animalsTable.xml"))
            {
                dataSet.WriteXml(sw);
                MessageBox.Show("XML файл успешно сохранен", "Выполнено");
            }
        }

        private void xmlImportButton_Click(object sender, EventArgs e)
        {
            if (File.Exists("../../animalsTable.xml"))
            {
                DataSet ds = new DataSet();

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                ds.ReadXml("../../animalsTable.xml");
                dataGridView1.DataSource = ds.Tables[0];
                MessageBox.Show("XML файл успешно импортирован", "Выполнено");
            }
        }

        private void csvExportButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sr = new StreamWriter("../../animalsTable.csv", false, Encoding.UTF8))
            {
                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    sr.WriteLine(row[0].ToString() + "," + row[1].ToString() + "," + row[2].ToString() + "," + row[3].ToString() + "," + row[4].ToString() +
                         "," + row[5].ToString() + "," + row[6].ToString() + "," + row[7].ToString(), Encoding.GetEncoding(1251));
                }
                MessageBox.Show("CSV файл успешно сохранен", "Выполнено");
            }
        }

        private void csvImportButton_Click(object sender, EventArgs e)
        {
            string delimiter = ",";
            string tableName = "BooksTable";
            string fileName = "../../animalsTable.csv";

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("animalName");
            dataTable.Columns.Add("animalType");
            dataTable.Columns.Add("maxWeight");
            dataTable.Columns.Add("color");
            dataTable.Columns.Add("redDate");
            dataTable.Columns.Add("avgLife");
            dataTable.Columns.Add("flyingAbilities");

            StreamReader sr = new StreamReader(fileName);

            string allData = sr.ReadToEnd();
            string[] rows = allData.Split("\r".ToCharArray());

            foreach (string r in rows)
            {
                string[] items = r.Split(delimiter.ToCharArray());
                dataTable.Rows.Add(items);
            }
            dataGridView1.DataSource = dataTable.DefaultView;
        }
    }
}
