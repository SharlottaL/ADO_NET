using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class LoginForm : Form
    {
        public string server => textBoxServer.Text;
        public string login => textBoxLogin.Text;
        public string password => textBoxPassword.Text;
        public string dataBase => comboBoxDataBase.Text;
        Connector connector = new Connector();
        string connectionString;
        SqlConnection connection;
        public LoginForm()
        {
            InitializeComponent();
           
        }
        private void textBoxServer_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxServer.Text))
            {
                LoadDataBase();
            }
        }
        void LoadDataBase()
        {
            string serverName = textBoxServer.Text;
            try
            {
                string connectionString = $"Data Source={serverName};Integrated Security=True;TrustServerCertificate=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    comboBoxDataBase.Items.Clear();
                    DataTable databasesTable = connector.Select($"name", "sys.databases", "database_id > 4");
                    comboBoxDataBase.Items.Add("Все");
                    foreach (DataRow row in databasesTable.Rows)
                    {
                        comboBoxDataBase.Items.Add(row["name"]);
                    }
                    comboBoxDataBase.SelectedIndex = 0;
                }
            }
            catch
            {
                comboBoxDataBase.Items.Clear();
                comboBoxDataBase.Items.Add("Сервер недоступен");
                comboBoxDataBase.SelectedIndex = 0;
            }
        }
        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxPassword.ForeColor == SystemColors.GrayText)
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = SystemColors.WindowText;
            }
            else
                textBoxPassword.ForeColor = SystemColors.WindowText;
        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(textBoxLogin.ForeColor == SystemColors.GrayText)
            {
                textBoxLogin.Text = "";
                textBoxLogin.ForeColor = SystemColors.WindowText;
            }
            else
                textBoxLogin.ForeColor = SystemColors.WindowText;
        }

        private void textBoxServer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxServer.ForeColor == SystemColors.GrayText)
            {
                textBoxServer.Text = "";
                textBoxServer.ForeColor = SystemColors.WindowText;
            }
            else
                textBoxServer.ForeColor = SystemColors.WindowText;
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
    }

