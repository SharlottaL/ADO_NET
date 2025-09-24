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

        Query[] queries = new Query[]
        {
            new Query("stud_id, FORMATMESSAGE(N'%s %s %s', last_name, first_name, middle_name) AS N'Студент', group_name AS N'Группа', direction_name AS N'Направление'",
                "Students, Groups, Directions",
                "[group] = group_id AND direction = direction_id"
                ), 
            new Query
            (
              "group_id, group_name, direction_name",
              "Groups, Directions",
              "direction=direction_id"
            ),
            new Query ("*", "Directions" ),
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

        //    for (int i = 0; i < tabControl.TabCount;i++)
        //    {
        //        //       string tableName = tabControl.TabPages[i].Name.Remove(0, "tabPage".Length);
        //        //       Console.Write(tableName+"\t");
        //        //       Console.WriteLine($"dataGridView{tableName}");
        //        //       //Console.WriteLine(this.Controls.Find($"dataGridView{tableName}", true)[0].Name);
        //        //       (this.Controls.Find($"dataGridView{tableName}", true)[0] as DataGridView).DataSource = Select("*", tableName);
        //        ////       (this.GetType().GetField($"dataGridView{tableName}").GetValue(this) as DataGridView).DataSource = Select("*", tableName);
        //        LoadTab(i);
        //}

            //LoadDirections();
            //LoadGroups();
            //dataGridViewDirections.DataSource = Select("*", "Directions");
            //dataGridViewGroups.DataSource = Select
            //    (
            //    "group_id, group_name, direction", "Groups, Directions", "direction = direction_id"
            //    );
           /// dataGridViewStudents.DataSource = Select("*", "Students");
        

            //LoadDisciplines();
            //LoadStudents();
            d_groupsDirection  = LoadDataToComboBox("*", "Directions");
            comboBoxGroupsDirections.Items.AddRange(d_groupsDirection.Keys.ToArray());
            comboBoxGroupsDirections.SelectedIndex = 0;
            tabControl.SelectedIndex = 1;
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
        }
        void FillStatusBar(int i)
        {

        }
        DataTable Select(string fields, string tables, string condition = "")
        {
            DataTable table = new DataTable();
            string cmd = $"SELECT {fields} FROM {tables}";
            if (!string.IsNullOrWhiteSpace(condition)) 
                cmd += $" WHERE {condition}";
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
        //void LoadDirections()
        //{
        //    string cmd = "SELECT * FROM Directions";
        //    SqlCommand command = new SqlCommand(cmd, connection);
        //    connection.Open();
        //    SqlDataReader reader = command.ExecuteReader();
        //    DataTable table = new DataTable();
        //    for (int i = 0; i < reader.FieldCount; i++)
        //        table.Columns.Add(reader.GetName(i));

        //    while (reader.Read())
        //    {
        //        DataRow row = table.NewRow();
        //        for (int i = 0; i < reader.FieldCount; i++)
        //            row[i] = reader[i];

        //        table.Rows.Add(row);
        //    }
        //    reader.Close();
        //    connection.Close();
        //    dataGridViewDirections.DataSource = table;
        //}
        //void LoadGroups()
        //{
        //    string cmd =
        //        @"SELECT
        //        group_id AS N'ID', group_name AS N'Группа', COUNT(stud_id) AS N'Количество студентов: ',  direction_name AS N'Направление'
        //        FROM Students
        //        RIGHT   JOIN Groups ON([group] = group_id)
        //                JOIN Directions ON (direction = direction_id)
        //        GROUP BY group_id, group_name, direction, direction_name;";
        //    SqlCommand command = new SqlCommand(cmd, connection);
        //    connection.Open();
        //    SqlDataReader reader = command.ExecuteReader();
        //    DataTable table = new DataTable();
        //    for (int i = 0; i < reader.FieldCount; i++)
        //        table.Columns.Add(reader.GetName(i));

        //    while (reader.Read())
        //    {
        //        DataRow row = table.NewRow();
        //        for (int i = 0; i < reader.FieldCount; i++)
        //            row[i] = reader[i];

        //        table.Rows.Add(row);
        //    }
        //    reader.Close();
        //    connection.Close();
        //    dataGridViewDirections.DataSource = table;
        //}
        //void LoadDisciplines()
        //{
        //    string cmd =
        //        @"SELECT
        //        direction_id AS N'ID, direction_name AN N'Направление', COUNT(group_id) AS N'Количество групп'
        //        FROM Groups
        //        RIGHT JOIN Directions ON (direction=direction_id)
        //        GROUP BY direction_id, direction_name;";
        //    SqlCommand command = new SqlCommand(cmd, connection);
        //    connection.Open();
        //    SqlDataReader reader = command.ExecuteReader();
        //    DataTable table = new DataTable();
        //    for (int i = 0; i < reader.FieldCount; i++)
        //        table.Columns.Add(reader.GetName(i));

        //    while (reader.Read())
        //    {
        //        DataRow row = table.NewRow();
        //        for (int i = 0; i < reader.FieldCount; i++)
        //            row[i] = reader[i];

        //        table.Rows.Add(row);
        //    }
        //    reader.Close();
        //    connection.Close();
        //    dataGridViewDirections.DataSource = table;
        //}
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
                "group_id, group_name, direction",
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
    }
    }

