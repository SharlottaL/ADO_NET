using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{

        public partial class MainForm : Form
        {
            string connectionString = "Data Source=BOTAN\\SQLEXPRESS;Initial Catalog=PD_321;Integrated Security=True;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection;
        System.Data.DataSet DirectionsRelatedData = null;
        Dictionary<string, int> d_groupDirection;
        Dictionary<string, int> d_studentsGroup;


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

            DirectionsRelatedData = new System.Data.DataSet(nameof(DirectionsRelatedData));
            const string dsTableDirections = "Directions";
            const string dstDirections_col_direction_id = "direction_id";
            const string dstDirections_col_direction_name = "direction_name";
            DirectionsRelatedData.Tables.Add(dsTableDirections);
            //Добавить поля в таблицу
            DirectionsRelatedData.Tables[dsTableDirections].Columns.Add(dstDirections_col_direction_id);
            DirectionsRelatedData.Tables[dsTableDirections].Columns.Add(dstDirections_col_direction_name);
            // Выбираем первичный ключ
            DirectionsRelatedData.Tables[dsTableDirections].PrimaryKey =
                new DataColumn[] { DirectionsRelatedData.Tables[dsTableDirections].Columns[dstDirections_col_direction_id] };

            const string dsTableDisciplines = "Disciplines";
            const string dstDisciplines_col_discipline_id = "discipline_id";
            const string dstDisciplines_col_discipline_name = "discipline_name";
            const string dstDisciplines_col_number_of_lessons = "number_of_lessons";
            DirectionsRelatedData.Tables.Add(dsTableDisciplines);
            //Добавить поля в таблицу
            DirectionsRelatedData.Tables[dsTableDisciplines].Columns.Add(dstDisciplines_col_discipline_id);
            DirectionsRelatedData.Tables[dsTableDisciplines].Columns.Add(dstDisciplines_col_discipline_name);
            DirectionsRelatedData.Tables[dsTableDisciplines].Columns.Add(dstDisciplines_col_number_of_lessons);
            // Выбираем первичный ключ
            DirectionsRelatedData.Tables[dsTableDisciplines].PrimaryKey =
                new DataColumn[] { DirectionsRelatedData.Tables[dsTableDisciplines].Columns[dstDisciplines_col_discipline_id] };
            string directions_cmd = "SELECT * FROM Directions";
            string disciplines_cmd = "SELECT * FROM Disciplines";

            SqlDataAdapter directionsAdapter = new SqlDataAdapter(directions_cmd, connection);
            SqlDataAdapter groupsAdapter = new SqlDataAdapter(disciplines_cmd, connection);

            directionsAdapter.Fill(DirectionsRelatedData.Tables[dsTableDirections]);
            groupsAdapter.Fill(DirectionsRelatedData.Tables[dsTableDisciplines]);

            foreach (DataRow row in DirectionsRelatedData.Tables[dsTableDirections].Rows)
            {
                comboBoxDirections.Items.Add(row["direction_name"]);
            }

            d_groupDirection = LoadDataToDictionary("*", "Directions");
            d_studentsGroup = LoadDataToDictionary("*", "Groups");
            comboBoxGroupsDirections.Items.AddRange(d_groupDirection.Keys.ToArray());
            comboBoxStudentsDirections.Items.AddRange(d_groupDirection.Keys.ToArray());
            comboBoxStudentsGroups.Items.AddRange(d_studentsGroup.Keys.ToArray());
            comboBoxStudentsDirections.SelectedIndex = comboBoxGroupsDirections.SelectedIndex = 0;
            comboBoxStudentsGroups.SelectedIndex = 0;

            tabControl.SelectedIndex = 0;

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
        Dictionary<string, int> LoadDataToDictionary(string fields, string tables, string condition = "")
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("Все", 0);
            string cmd = $"SELECT {fields} FROM {tables}";
            if (!string.IsNullOrWhiteSpace(condition))
                cmd += $" WHERE {condition}";

            SqlCommand command = new SqlCommand(cmd, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //comboBoxGroupsDirection.Items.Add(reader[1]);
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
                condition += $" AND direction = {d_groupDirection[comboBoxGroupsDirections.SelectedItem.ToString()]}";
            dataGridViewGroups.DataSource = Select
                (
                "group_id AS N'ID', group_name AS N'Название группы', direction_name AS N'Направление'",
                "Groups, Directions",
                 condition
              );
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
        private void comboBoxStudentsDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string condition = comboBoxStudentsDirections.SelectedItem.ToString() == "Все" ? "" :
                $" direction={d_groupDirection[(sender as ComboBox).SelectedItem.ToString()]}";
            comboBoxStudentsGroups.Items.Clear();
            comboBoxStudentsGroups.Items.AddRange(LoadDataToDictionary("*", "Groups", condition).Keys.ToArray());
            dataGridViewStudents.DataSource = Select
                (
                    queries[0].Fields,
                    queries[0].Tables,
                    queries[0].Condition + (string.IsNullOrEmpty(condition) ? "" : $" AND {condition}")
                );
        }

        private void comboBoxStudentsGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            string condition_group =
                comboBoxStudentsGroups.SelectedItem.ToString() == "Все" ? "" :
                $"[group]={d_studentsGroup[comboBoxStudentsGroups.SelectedItem.ToString()]}";
            string condition_direction = comboBoxStudentsDirections.SelectedItem.ToString() == "Все" ? "" :
                $" direction={d_groupDirection[comboBoxStudentsDirections.SelectedItem.ToString()]}";
            dataGridViewStudents.DataSource = Select
                (
                    queries[0].Fields,
                    queries[0].Tables,
                    queries[0].Condition
                    + (string.IsNullOrWhiteSpace(condition_group) ? "" : $" AND {condition_group}")
                    + (string.IsNullOrWhiteSpace(condition_direction) ? "" : $" AND {condition_direction}")
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

