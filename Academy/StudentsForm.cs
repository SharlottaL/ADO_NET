using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    public partial class StudentsForm : System.Windows.Forms.Form
    {
        internal Student Student { get; set; }
        Connector connector;
        public StudentsForm()
        {
            InitializeComponent();
           
             connector = new Connector();
            DataTable groups = connector.Select("*", "Groups");
            comboBoxGroups.DataSource = groups;
            comboBoxGroups.DisplayMember = groups.Columns[1].ToString();
            comboBoxGroups.ValueMember = groups.Columns[0].ColumnName;
        }
        void Compress()
        {
            Student.LastName = textBoxLastName.Text;
            Student.FirstName = textBoxFirstName.Text;
            Student.MiddleName = textBoxMiddleName.Text;
            Student.Email = textBoxEmail.Text;
            Student.Phone = textBoxPhone.Text;
            Student.Group = Convert.ToInt32(comboBoxGroups.SelectedValue);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Student = new Student
                (
                textBoxLastName.Text,
                textBoxFirstName.Text,
                textBoxMiddleName.Text,
                dateTimePickerBirthDate.Text,
                textBoxEmail.Text,
                textBoxPhone.Text,
                Convert.ToInt32(comboBoxGroups.SelectedValue)
                );
        }
    }
}
