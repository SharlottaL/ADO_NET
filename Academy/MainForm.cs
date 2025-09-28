using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Drawing.Printing;
namespace Academy
{

        public partial class MainForm : Form
        {
            string connectionString = "Data Source=BOTAN\\SQLEXPRESS;Initial Catalog=PD_321;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection;
        Dictionary<string, int> d_groupsDirection;
        Dictionary<string, int> d_studentsGroups;
        Dictionary<string, int> d_studentsDirection;


        Query[] queries = new Query[]
        {
            new Query("stud_id, FORMATMESSAGE(N'%s %s %s', last_name, first_name, middle_name) AS N'Студент', group_name AS N'Группа', direction_name AS N'Направление'",
                "Students, Groups, Directions",
                "[group] = group_id AND direction = direction_id"
                ),
            new Query
            (
              "group_id, group_name, learning_days, direction_name AS N'Направление'",
              "Groups, Directions",
              "direction=direction_id"
            ),
            new Query(
            "direction_id, direction_name, (SELECT COUNT(*) FROM Groups WHERE direction = direction_id) AS N'Количество групп'",
            "Directions",
            "",
            ""
         ),
            new Query ("*", "Disciplines" ),
            new Query ("*", "Teachers" )

        };

        readonly string[] statusBarMassages = new string[]
        {
        "Количество студентов ", 
        "Количество групп ", 
        "Количество направлений ", 
        "Количество дисциплин ",
        "Количество преподавателей " 
        };
    
        public MainForm()
            {
            InitializeComponent();
            AllocConsole();
            Console.WriteLine(tabControl.TabCount);
            connection = new SqlConnection(connectionString);

            d_groupsDirection = LoadDataToComboBox("*", "Directions");
            comboBoxGroupsDirections.Items.AddRange(d_groupsDirection.Keys.ToArray());
            comboBoxGroupsDirections.SelectedIndex = 0;
            tabControl.SelectedIndex = 1;

            d_studentsGroups = LoadDataToComboBox("*", "Groups");
            comboBoxStudentsGroups.Items.AddRange(d_studentsGroups.Keys.ToArray());
            comboBoxStudentsGroups.SelectedIndex = 0;

            d_studentsDirection = LoadDataToComboBox("*", "Directions");
            comboBoxStudentsDirections.Items.AddRange(d_studentsDirection.Keys.ToArray());
            comboBoxStudentsDirections.SelectedIndex = 0;

            for (int i =0; i < tabControl.TabCount; i++)
            {
                (this.Controls.Find($"dataGridView{tabControl.TabPages[i].Name.Remove(0, "tabPage".Length)}", true)[0] as DataGridView)
                    .RowsAdded 
                    += new DataGridViewRowsAddedEventHandler(this.dataGridViewChanged);
            }
        }
        void LoadTab(int i)
        {
            string tableName = tabControl.TabPages[i].Name.Remove(0, "tabPage".Length);
            DataGridView dataGridView = this.Controls.Find($"dataGridView{tableName}", true)[0] as DataGridView;
            dataGridView.DataSource = Select(queries[i].Fields, queries[i].Tables, queries[i].Condition);
            //  toolStripStatusLabel1.Text = $"{statusBarMassages[i]}: {dataGridView.RowCount - 1}";
            if (i == 1) ConvertLearningDays();
        }
        
            void FillStatusBar(int i)
        {

        }
        DataTable Select(string fields, string tables, string condition = "", string group_by = "")
        {
            DataTable table = new DataTable();
            string cmd = $"SELECT {fields} FROM {tables}";
            if (!string.IsNullOrWhiteSpace(condition)) 
                cmd += $" WHERE {condition}";
            if (!string.IsNullOrWhiteSpace(group_by)) 
        cmd += $" GROUP BY {group_by}";

            cmd += ";";

            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            for (int i = 0; i < reader.FieldCount; i++)
                table.Columns.Add(reader.GetName(i));

            while(reader.Read())
            {
                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
                table.Rows.Add(row);
            }
            reader.Close();
            connection.Close();
            return table;
        }

        void ConvertLearningDays()
        {
            for(int i = 0; i < dataGridViewGroups.RowCount;i++)
            {
                dataGridViewGroups.Rows[i].Cells["learning_days"].Value
                    = new Week(Convert.ToByte(dataGridViewGroups.Rows[i].Cells["learning_days"].Value));
            }
        }
        Dictionary<string, int> LoadDataToComboBox(string fields, string tables)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("Все", 0);
            string cmd = $"SELECT {fields} FROM {tables}";
            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                //comboBoxGroupsDirections.Items.Add(reader[1]);
                dictionary.Add(reader[1].ToString(), Convert.ToInt32(reader[0]));
                    }
            reader.Close();
            connection.Close();
            return dictionary;
        }
      
        private void comboBoxGroupsDirections_SelectedIndexChanged(object sender, EventArgs e)
        {
            string condition = "direction = direction_id";
            if (comboBoxGroupsDirections.SelectedItem.ToString() != "Все")
                condition += $" AND direction = {d_groupsDirection[comboBoxGroupsDirections.SelectedItem.ToString()]}";
            dataGridViewGroups.DataSource = Select
                (
                "group_id AS N'ID', group_name AS N'Название группы', direction_name AS N'Направление'",
                "Groups, Directions",
                 condition
              );
            //" +
            //    "CASE WHEN learning_days & 1 = 1 THEN 'ПН' ELSE '' END + ' ' + " +
            //    "CASE WHEN learning_days & 2 = 2 THEN 'Вт' ELSE '' END + ' ' + " +
            //    "CASE WHEN learning_days & 4 = 4 THEN 'Ср' ELSE '' END + ' ' + " +
            //    "CASE WHEN learning_days & 8 = 8 THEN 'Чт' ELSE '' END + ' ' + " +
            //    "CASE WHEN learning_days & 16 = 16 THEN 'Пт' ELSE '' END + ' ' + " +
            //    "CASE WHEN learning_days & 32 = 32 THEN 'Сб' ELSE '' END + ' ' + " +
            //    "CASE WHEN learning_days & 64 = 64 THEN 'Вс' ELSE '' END AS N'Учебные дни', " + "
        }
        [DllImport("kernel32.dll")]
        static extern void AllocConsole();

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTab((sender as TabControl).SelectedIndex);
        }
        private void dataGridViewChanged(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"{statusBarMassages[tabControl.SelectedIndex]}: {(sender as DataGridView).RowCount - 1}";
        }
        private void comboBoxStudentsGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            string condition = "[group] = group_id";
            if (comboBoxStudentsGroups.SelectedItem.ToString() != "Все")
                condition += $" AND [group] = {d_studentsGroups[comboBoxStudentsGroups.SelectedItem.ToString()]}";
            dataGridViewStudents.DataSource = Select
                (
                "stud_id, first_name, last_name, group_name",
                "Students, Groups",
                 condition
              );
        }
        private void comboBoxStudentsDirections_SelectedIndexChanged(object sender, EventArgs e)
        {
            string condition = "[group] = group_id AND direction = direction_id";
            if (comboBoxStudentsGroups.SelectedItem.ToString() != "Все")
                condition += $" AND [group] = {d_studentsGroups[comboBoxStudentsGroups.SelectedItem.ToString()]}";
            if (comboBoxStudentsDirections.SelectedItem.ToString() != "Все")
                condition += $" AND direction = {d_studentsDirection[comboBoxStudentsDirections.SelectedItem.ToString()]}";
            dataGridViewStudents.DataSource = Select
                (
                "stud_id, first_name, last_name, group_name, direction_name",
                "Students, Groups, Directions",
                 condition
              );
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void buttonAddGroups_Click(object sender, EventArgs e)
        {
            AddGroups addGroups = new AddGroups();
            addGroups.Show();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            AddStudents addStudents = new AddStudents();
            addStudents.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTeachers addTeachers = new AddTeachers();
            addTeachers.Show();
        }
    }
 }

