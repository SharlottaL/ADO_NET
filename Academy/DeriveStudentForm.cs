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
    public partial class DeriveStudentForm : BaseHumanForm
    {
        public DeriveStudentForm()
        {
            InitializeComponent();
            DataTable groups = connector.Select("*", "Groups");
            comboBoxGroups.DataSource = groups;
            comboBoxGroups.DisplayMember = groups.Columns[1].ToString();
            comboBoxGroups.ValueMember = groups.Columns[0].ColumnName;
        }
        public DeriveStudentForm(int id):this()
        {
            Human = new Student(id);
            Extract();
        }
        protected override void Extract()
        {
            base.Extract();
            comboBoxGroups.SelectedIndex = (Human as Student).Group;
            labelID.Text = (Human as Student).ID.ToString();
        }
        protected override void buttonOK_Click(object sender, EventArgs e)
        {
            Human = new Student
                (
                textBoxLastName.Text,
                textBoxFirstName.Text,
                textBoxMiddleName.Text,
                dateTimePickerBirthDate.Text,
                textBoxEmail.Text,
                textBoxPhone.Text,
                Convert.ToInt32(comboBoxGroups.SelectedValue),
                pictureBoxPhoto.Image
                );
        }

    }
}
