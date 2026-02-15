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
    public partial class TeacherForm : Form
    {
        internal Teacher Teacher { get; set; }
        Connector connector;
        public TeacherForm()
        {
            InitializeComponent();
            connector = new Connector();
            InitForm();
        }
        public TeacherForm(int teacher_id) : this()
        {
            DataTable teacher = connector.Select("*", "Teachers", $"teacher_id={teacher_id}");
            textBoxLastName.Text = teacher.Rows[0][1].ToString();
            textBoxFirstName.Text = teacher.Rows[0][2].ToString();
            textBoxMiddleName.Text = teacher.Rows[0][3].ToString();

            dateTimePickerBirthDate.Value = Convert.ToDateTime(teacher.Rows[0][4]);
            textBoxEmail.Text = teacher.Rows[0][5].ToString();
            textBoxPhone.Text = teacher.Rows[0][6].ToString();
            dateTimePickerWorkSince.Value = Convert.ToDateTime(teacher.Rows[0][8]);
            textBoxRate.Text = teacher.Rows[0][9].ToString();
            labelID.Visible = true;
            labelID.Text = $"ID:{teacher.Rows[0][0].ToString()}";
            /////////////////////////////////////////////////////////
            try
            {
                pictureBoxPhoto.Image = connector.DownloadPhoto(teacher_id, "Teachers", "photo");
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        void InitForm()
        {
            textBoxLastName.Text = "Ковтун";
            textBoxFirstName.Text = "Олег";
            textBoxMiddleName.Text = "Анатольевич";
            dateTimePickerBirthDate.Value = new DateTime(1985, 01, 16);
            textBoxEmail.Text = "kovtun@gmail.com";
            textBoxPhone.Text = "+7(666)666-66-66";
            dateTimePickerWorkSince.Value = new DateTime(2009, 04, 04);
            textBoxRate.Text = "32.0000";
        }
        void Compress()
        {
            Teacher.LastName = textBoxLastName.Text;
            Teacher.FirstName = textBoxFirstName.Text;
            Teacher.MiddleName = textBoxMiddleName.Text;
            Teacher.Email = textBoxEmail.Text;
            Teacher.Phone = textBoxPhone.Text;
            Teacher.Rate = textBoxRate.Text;
        }

      
        private void buttonOboz_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter =
                "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All image files|*.png;*.jpg|All files (*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPhoto.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Teacher = new Teacher
               (
               textBoxLastName.Text,
               textBoxFirstName.Text,
               textBoxMiddleName.Text,
               dateTimePickerBirthDate.Text,
               textBoxEmail.Text,
               textBoxPhone.Text,
               pictureBoxPhoto.Image,
               dateTimePickerWorkSince.Text,
               textBoxRate.Text
               );
        }
    }
}

