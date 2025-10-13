using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    public partial class AddStudents : System.Windows.Forms.Form
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
        private byte[] ImageToByteArray(Image image)
        {
            if (image == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
              
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
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
            byte[] photoBytes = null;
            if (pictureBox1.Image != null)
            {
                photoBytes = ImageToByteArray(pictureBox1.Image);
            }
            bool add = Add("Students", "last_name, first_name, middle_name, [group], birth_date, photo", $"'{textBoxName.Text}', '{textBoxLastName.Text}', '{textBoxMiddleName.Text}', '{group}', '{birthDate}', '{photoBytes}'");

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

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if (openFileDialogStudents.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Загружаем выбранное изображение в PictureBox
                    string selectedFile = openFileDialogStudents.FileName;
                    pictureBox1.Image = Image.FromFile(selectedFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки изображения: {ex.Message}");
                }
            }
        }

       
    }
}
