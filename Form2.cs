using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_1
{
    public partial class Form2 : Form
    {
        string host = "localhost";
        string database = "zoodb";
        string user = "root";
        string password = "";
        string connect;
        string sql = "select* from employees";
        MySqlCommandBuilder builder;
        MySqlCommand cmd;

        public Form2()
        {
            InitializeComponent();

            string query = "select ID from animals";

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Columns[0].ReadOnly = true;

            connect = "Database=" + database + ";Datasource=" + host + ";User=" + user + ";Password=" + password + ";CharSet=utf8";
            using (connection = new MySqlConnection(connect))
            {
                connection.Open();
                dataAdapter = new MySqlDataAdapter(sql, connection);
                dataAdapter.Fill(dataSet.Tables[0]);
                cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        idAnimalComboBox.Items.Add(reader.GetString(0));
                    }
                }
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

        private void openAniButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updateRowButton_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = dataSet;
            bindingSource.DataMember = "Table1";
            dataGridView1.DataSource = bindingSource;

            string query = $"update employees set ID_animal = @ID_animal, " +
                $"name = @name, " +
                $"birthYear = @birthYear, " +
                $"position = @position, " +
                $"applyYear = @applyYear, " +
                $"salary = @salary " +
                $"where ID = @ID";

            using (connection = new MySqlConnection(connect))
            {
                connection.Open();
                cmd = new MySqlCommand(query, connection);

                cmd.Parameters.Add(new MySqlParameter("@ID_animal", Convert.ToInt32(idAnimalComboBox.Text)));
                cmd.Parameters.Add(new MySqlParameter("@name", nameTextBox.Text));
                cmd.Parameters.Add(new MySqlParameter("@birthYear", Convert.ToInt32(birthYearTextBox.Text)));
                cmd.Parameters.Add(new MySqlParameter("@position", positionTextBox.Text));
                cmd.Parameters.Add(new MySqlParameter("@applyYear", applyYearTextBox.Text));
                cmd.Parameters.Add(new MySqlParameter("@salary", Convert.ToInt32(salaryTextBox.Text)));
                cmd.Parameters.Add(new MySqlParameter("@ID", Convert.ToInt32(idTextBox.Text)));

                cmd.ExecuteNonQuery();
                dataAdapter.Fill(dataSet);
                dataSet.Clear();
                dataAdapter.Fill(dataSet.Tables[0]);
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            string query = "insert into employees(ID_animal, name, birthYear, position, applyYear, salary) " +
               $"values(@ID_animal, @name, @birthYear, @position, @applyYear, @salary)";

            using (connection = new MySqlConnection(connect))
            {
                connection.Open();
                cmd = new MySqlCommand(query, connection);

                cmd.Parameters.Add(new MySqlParameter("@ID_animal", Convert.ToInt32(idAnimalComboBox.Text)));
                cmd.Parameters.Add(new MySqlParameter("@name", nameTextBox.Text));
                cmd.Parameters.Add(new MySqlParameter("@birthYear", Convert.ToInt32(birthYearTextBox.Text)));
                cmd.Parameters.Add(new MySqlParameter("@position", positionTextBox.Text));
                cmd.Parameters.Add(new MySqlParameter("@applyYear", applyYearTextBox.Text));
                cmd.Parameters.Add(new MySqlParameter("@salary", Convert.ToInt32(salaryTextBox.Text)));

                cmd.ExecuteNonQuery();
            }
            dataAdapter.Fill(dataSet);
            dataSet.Clear();
            dataAdapter.Fill(dataSet.Tables[0]);
            bindingSource.ResetBindings(false);
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            string query = $"delete from employees where ID = {Convert.ToInt32(idTextBox.Text)}";

            using (connection = new MySqlConnection(connect))
            {
                connection.Open();
                cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                dataAdapter.Fill(dataSet);
                dataSet.Clear();
                dataAdapter.Fill(dataSet.Tables[0]);
            }
        }

        private void deleteCurrentRowButton_Click(object sender, EventArgs e)
        {
            int k = dataGridView1.CurrentCell.RowIndex;
            string query = $"delete from employees where ID = @ID";

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
                    cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.Add(new MySqlParameter("@ID", Convert.ToInt32(dataGridView1.Rows[k].Cells[0].Value)));

                    connection.Open();
                    cmd.ExecuteNonQuery();

                    dataAdapter.Fill(dataSet);
                    dataSet.Clear();
                    dataAdapter.Fill(dataSet.Tables[0]);
                }
            }
        }

        private void changeCurrentRowButton_Click(object sender, EventArgs e)
        {
            bindingSource.DataSource = dataSet;
            bindingSource.DataMember = "Table1";
            dataGridView1.DataSource = bindingSource;

            int k = dataGridView1.CurrentCell.RowIndex;

            string query = $"update employees set ID_animal = @ID_animal, " +
                $"name = @name, " +
                $"birthYear = @birthYear, " +
                $"position = @position, " +
                $"applyYear = @applyYear, " +
                $"salary = @salary " +
                $"where ID = @ID";

            using (connection = new MySqlConnection(connect))
            {
                connection.Open();
                cmd = new MySqlCommand(query, connection);

                cmd.Parameters.Add(new MySqlParameter("@ID_animal", Convert.ToInt32(idAnimalComboBox.Text)));
                cmd.Parameters.Add(new MySqlParameter("@name", nameTextBox.Text));
                cmd.Parameters.Add(new MySqlParameter("@birthYear", Convert.ToInt32(birthYearTextBox.Text)));
                cmd.Parameters.Add(new MySqlParameter("@position", positionTextBox.Text));
                cmd.Parameters.Add(new MySqlParameter("@applyYear", applyYearTextBox.Text));
                cmd.Parameters.Add(new MySqlParameter("@salary", Convert.ToInt32(salaryTextBox.Text)));
                cmd.Parameters.Add(new MySqlParameter("@ID", Convert.ToInt32(dataGridView1.Rows[k].Cells[0].Value)));

                cmd.ExecuteNonQuery();
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
                idAnimalComboBox.Text = dataGridView1.Rows[k].Cells[1].Value.ToString();
                nameTextBox.Text = dataGridView1.Rows[k].Cells[2].Value.ToString();
                birthYearTextBox.Text = dataGridView1.Rows[k].Cells[3].Value.ToString();
                positionTextBox.Text = dataGridView1.Rows[k].Cells[4].Value.ToString();
                applyYearTextBox.Text = dataGridView1.Rows[k].Cells[5].Value.ToString();
                salaryTextBox.Text = dataGridView1.Rows[k].Cells[6].Value.ToString();
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
