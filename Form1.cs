using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Columns[0].ReadOnly = true;

            connect = "Database=" + database + ";Datasource=" + host + ";User=" + user + ";Password=" + password + ";CharSet=utf8";
            using (connection = new MySqlConnection(connect))
            {
                mySqlDataAdapter1 = new MySqlDataAdapter(sql, connection);
                mySqlDataAdapter1.Fill(dataSet.Tables[0]);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите сохранить изменения?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (connection = new MySqlConnection(connect))
                {
                    connection.Open();
                    mySqlDataAdapter1 = new MySqlDataAdapter(sql, connection);
                    builder = new MySqlCommandBuilder(mySqlDataAdapter1);
                    bindingSource.EndEdit(); // Завершаем редактирование текущей записи
                    builder.GetInsertCommand();
                    mySqlDataAdapter1.Update(dataSet.Tables[0]); // Сохраняем изменения в базу данных
                    dataSet.Clear();
                    mySqlDataAdapter1.Fill(dataSet.Tables[0]);
                    //bindingSource1.ResetBindings(false);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (connection = new MySqlConnection(connect))
            {
                mySqlDataAdapter1 = new MySqlDataAdapter(sql, connection);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(mySqlDataAdapter1);
                mySqlDataAdapter1.Update(dataSet.Tables["Table1"]);
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
            /*bindingSource1.DataSource = dataSet1;
            bindingSource1.DataMember = "Table1";
            bindingNavigator1.BindingSource = bindingSource1;
            bindingNavigator1.Update();
            dataGridView1.DataSource = bindingSource1;
            dataSet1.Tables.Add("tab");
            dataSet1.Tables["tab"].Columns.Add("ID");
            dataSet1.Tables["tab"].Columns.Add("animalName");
            dataSet1.Tables["tab"].Columns.Add("animalType");
            dataSet1.Tables["tab"].Columns.Add("maxWeight");
            dataSet1.Tables["tab"].Columns.Add("color");
            dataSet1.Tables["tab"].Columns.Add("redDate");
            dataSet1.Tables["tab"].Columns.Add("avgLife");
            dataSet1.Tables["tab"].Columns.Add("flyingAbilities");
            if (filterTextBox.Text == "")
            {
                MessageBox.Show("Введите название", "Нет данных", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            string query = "select * from animals where " +
                $"(animalType = '{filterTextBox.Text.Trim()}')";

            bindingSource1.DataSource = dataSet1.Tables["tab"];
            bindingNavigator1.BindingSource = bindingSource1;
            using (mySqlConnection1 = new MySqlConnection(connect))
            {
                mySqlConnection1.Open();
                MySqlCommand command = new MySqlCommand(query, mySqlConnection1);
                mySqlDataAdapter1 = new MySqlDataAdapter(command);
                mySqlDataAdapter1.Fill(dataSet1, "tab");
            }
            bindingNavigator1.Update();
            dataGridView1.DataSource = bindingSource1;
            dataSet1.Tables.Remove("tab");*/

            bindingSource.Filter = "animalType like '" + filterTextBox.Text.Trim() + "'";
            dataGridView1.DataSource = bindingSource;
        }

        private void cancelFilterButton_Click(object sender, EventArgs e)
        {
            /*bindingSource1.DataSource = dataSet1.Tables["Table1"];
            bindingNavigator1.BindingSource = bindingSource1;
            bindingNavigator1.Update();
            dataGridView1.DataSource = bindingSource1*/

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
            mySqlDataAdapter1.Fill(dataSet);
            dataSet.Clear();
            mySqlDataAdapter1.Fill(dataSet.Tables[0]);
            bindingSource.ResetBindings(false);
        }

        private void deleteCurrentRowButton_Click(object sender, EventArgs e)
        {
            int k = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("В таблице нет строк!");
                return;
            }
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить текущую запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(k);
                mySqlDataAdapter1.Update(dataSet.Tables["Table1"]);
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
                mySqlDataAdapter1.Fill(dataSet);
                dataSet.Clear();
                mySqlDataAdapter1.Fill(dataSet.Tables[0]);
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
                mySqlDataAdapter1.Fill(dataSet);
                dataSet.Clear();
                mySqlDataAdapter1.Fill(dataSet.Tables[0]);
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
            catch (IndexOutOfRangeException)
            {
                return;
            }
            catch (NullReferenceException)
            {

            }

            if (dataGridView1.Rows[k].Cells[1].Value.ToString() != "") bindingNavigatorDeleteItem.Enabled = false;
            else bindingNavigatorDeleteItem.Enabled = true;
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
            mySqlDataAdapter1.Fill(dataSet.Tables[0]);
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
    }
}
