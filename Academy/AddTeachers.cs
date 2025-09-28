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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Academy
{
    public partial class AddTeachers : Form
    {
        string connectionString = "Data Source=BOTAN\\SQLEXPRESS;Initial Catalog=PD_321;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection connection;
        public AddTeachers()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
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
        public object Scalar(string cmd)
        {
            connection.Open();
            SqlCommand command = new SqlCommand(cmd, connection);
            object obj = command.ExecuteScalar();
            connection.Close();
            return obj;
        }
        private int GetNextTeachersId(string table)
        {
            string sql = $"SELECT MAX(teacher_id) + 1 FROM {table}";
            object result = Scalar(sql);
            return Convert.ToInt32(result);

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
            int nextId = GetNextTeachersId("Teachers");
            string birth_date = dateTimePickerBirthDate.Value.ToString("yyyy-MM-dd");
            string work_since = dateTimePickerWorkSince.Value.ToString("yyyy-MM-dd");

            bool add = Add("Teachers", "teacher_id, last_name, first_name, middle_name, birth_date, work_since", $"'{nextId}','{textBoxName.Text}', '{textBoxLastName.Text}', '{textBoxMiddleName.Text}', '{birth_date}', '{work_since}'");

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
