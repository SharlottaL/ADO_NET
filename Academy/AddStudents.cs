using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    public partial class AddStudents : Form
    {
        string connectionString = "Data Source=BOTAN\\SQLEXPRESS;Initial Catalog=PD_321;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection;
        Dictionary<string, int> d_groups;
        public AddStudents()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            d_groups = LoadDataToComboBox("*", "Groups");
            comboBoxGroups.Items.AddRange(d_groups.Keys.ToArray());
            comboBoxGroups.SelectedIndex = 0;
        }
        private Dictionary<string, int> LoadDataToComboBox(string fields, string tables)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("", 0);
            string cmd = $"SELECT {fields} FROM {tables}";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //comboBoxGroupsDirections.Items.Add(reader[1]);
                dictionary.Add(reader[1].ToString(), Convert.ToInt32(reader[0]));
            }
            reader.Close();
            connection.Close();
            return dictionary;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
                MessageBox.Show("Вы не ввели имя!");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == "")
                MessageBox.Show("Вы не ввели фамилию!");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMiddleName.Text == "")
                MessageBox.Show("Вы не ввели отчество!");
        }
        public bool Add(string table, string fields, object values)

        {
            string cmd = $"INSERT INTO {table} ({fields}) VALUES ({values})";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string selectedGroupName = comboBoxGroups.Text;
            int group = d_groups[selectedGroupName];
            string birthDate = dateTimePickerBirthDate.Value.ToString("yyyy-MM-dd");
            if (group == 0)
            {
                MessageBox.Show("Выберите группу!");
                return;
            }
            bool add = Add("Students", "last_name, first_name, middle_name, [group], birth_date", $"'{textBoxName.Text}', '{textBoxLastName.Text}', '{textBoxMiddleName.Text}', '{group}', '{birthDate}'");

            if (add)
            {
                MessageBox.Show("Запись была успешно добавлена в базу данных!");
                return;
            }
            else
                MessageBox.Show("Упс!Произошла ошибка при добавлении группы в базу данных!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
