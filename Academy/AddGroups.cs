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
        Dictionary<string, int> d_groups;
        public AddGroups()
        {
            InitializeComponent();
            connection = new SqlConnection(connectionString);
            checkedListBoxGroups.Items.Add("Пн");
            checkedListBoxGroups.Items.Add("Вт");
            checkedListBoxGroups.Items.Add("Ср");
            checkedListBoxGroups.Items.Add("Чт");
            checkedListBoxGroups.Items.Add("Пт");
            checkedListBoxGroups.Items.Add("Сб");
            checkedListBoxGroups.Items.Add("Вс");

            d_groups = LoadDataToComboBox("*", "Directions");
            comboBoxAddGroups.Items.AddRange(d_groups.Keys.ToArray());
            comboBoxAddGroups.SelectedIndex = 0;

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

        private void comboBoxAddGroups_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

