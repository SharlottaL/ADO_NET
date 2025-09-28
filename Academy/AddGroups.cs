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
    public partial class AddGroups : Form
    {
        string connectionString = "Data Source=BOTAN\\SQLEXPRESS;Initial Catalog=PD_321;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection;
        Dictionary<string, int> d_directions;
        public AddGroups()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            checkedListBoxLearningDays.Items.AddRange
                ( new string[]
                { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" }
                );
            checkedListBoxTime.Items.AddRange
                (new string[]
                { "10:00", "13:30", "14:00", "14:30", "18:30"}
                );

            d_directions = LoadDataToComboBox("*", "Directions");
            comboBoxAddDirections.Items.AddRange(d_directions.Keys.ToArray());
            comboBoxAddDirections.SelectedIndex = 0;

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
        
        public bool Add(string table, string fields, object values)

        {
            string cmd = $"INSERT INTO {table} ({fields}) VALUES ({values})";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }
        public object Scalar(string cmd)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
        object obj = command.ExecuteScalar();
        connection.Close();
            return obj;
        }
        
        private int GetNextGroupId(string table)
        {
            string sql = $"SELECT MAX(group_id) + 1 FROM {table}";
            object result = Scalar(sql);
            return Convert.ToInt32(result);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string days = "";
            int nextId = GetNextGroupId("Groups");
            foreach (var item in checkedListBoxLearningDays.CheckedItems)
            {
                days += item.ToString() + ",";
            }
            days = days.TrimEnd(',');

            if (string.IsNullOrEmpty(days))
            {
                MessageBox.Show("Выберите дни обучения!");
                return;
            }
            string time = "";
            foreach (var item in checkedListBoxTime.CheckedItems)
            {
                time += item.ToString() + ",";
            }
            time = time.TrimEnd(','); 

            if (string.IsNullOrEmpty(time))
            {
                MessageBox.Show("Выберите дни обучения!");
                return;
            }

            string selectedDirectionName = comboBoxAddDirections.Text;
            int direction = d_directions[selectedDirectionName];
            if (direction == 0)
            {
                MessageBox.Show("Выберите направление!");
                return;
            }
            byte daysMask = Week.FromToStringLearningDays(checkedListBoxLearningDays);
            bool add = Add("Groups", "group_id, group_name, direction, learning_days, start_time", $"'{nextId}','{textBoxGroupName.Text}', '{direction}', '{daysMask}', '{checkedListBoxTime.Text}'");

            if (add)
            {
                MessageBox.Show("Запись была успешно добавлена в базу данных!");
                return;
            }
            else
                MessageBox.Show("Упс!Произошла ошибка при добавлении группы в базу данных!");

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxGroupName_TextChanged(object sender, EventArgs e)
        {
            if(textBoxGroupName.Text == "")
                MessageBox.Show("Введите название группы!");
        }

        private void checkedListBoxGroups_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int changeCount = checkedListBoxLearningDays.CheckedItems.Count;
            if (e.NewValue == CheckState.Checked)
                changeCount++;
            else
                changeCount--;
            if (changeCount >= 5 && e.NewValue == CheckState.Checked)
            {
                e.NewValue = CheckState.Unchecked;
                MessageBox.Show("Да я погляжу, вы садюга однако! Нельзя вибирать больше 4 дней в неделю для занятий!!!");
            }
        }

        private void checkedListBoxTime_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int changeCount = checkedListBoxTime.CheckedItems.Count;
            if (e.NewValue == CheckState.Checked)
                changeCount++;
            else
                changeCount--;
            if (changeCount >= 2 && e.NewValue == CheckState.Checked)
            {
                e.NewValue = CheckState.Unchecked;
                MessageBox.Show("Можно выбрать только одно время для группы!");
            }
        }
    }
}

