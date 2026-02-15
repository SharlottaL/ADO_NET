using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
            InitForm();
        }
        public StudentsForm(int stud_id):this()
        {
            //string[] fullName = row[1].ToString().Split(' ');
            //textBoxLastName.Text = fullName[0];
            //textBoxFirstName.Text = fullName[1];
            //textBoxMiddleName.Text = fullName[2];

            //dateTimePickerBirthDate.Text = row[2].ToString();
            //textBoxEmail.Text = row[3].ToString();
            //textBoxPhone.Text = row[6].ToString();
            //comboBoxGroups.SelectedValue = row[7];
            //int stud_id = Convert.ToInt32(row[0]);
            DataTable student = connector.Select("*", "Students", $"stud_id={stud_id}");
            textBoxLastName.Text = student.Rows[0][1].ToString();
            textBoxFirstName.Text = student.Rows[0][2].ToString();
            textBoxMiddleName.Text = student.Rows[0][3].ToString();

            dateTimePickerBirthDate.Value = Convert.ToDateTime(student.Rows[0][4]);
            textBoxEmail.Text = student.Rows[0][5].ToString();
            textBoxPhone.Text = student.Rows[0][6].ToString();
            comboBoxGroups.SelectedValue = student.Rows[0][8];
            labelID.Visible = true;
            labelID.Text = $"ID:{student.Rows[0][0].ToString()}";
            /////////////////////////////////////////////////////////
            ///
            //object photo_obj = student.Rows[0][7];
            //Console.WriteLine(photo_obj .ToString());
            //BinaryFormatter bf = new BinaryFormatter();
            //MemoryStream ms = new MemoryStream(photo_obj as byte[]);
            //////bf.Serialize(ms, student.Rows[0][7]);
            //pictureBoxPhoto.Image = Image.FromStream(ms, true, true);
            try
            {
                pictureBoxPhoto.Image = connector.DownloadPhoto(stud_id, "Students", "photo");
            }
            catch(Exception ex)
            {
               // MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
        void InitForm()
        {
            textBoxLastName.Text = "Леонтьева";
            textBoxFirstName.Text = "Шарлотта";
            textBoxMiddleName.Text = "Владимировна";
            dateTimePickerBirthDate.Value = new DateTime(2007, 07, 08);
            textBoxEmail.Text ="botanichkagigantika@gmail.com";
            textBoxPhone.Text ="+7(123)456-77-88"; 
            comboBoxGroups.SelectedIndex = 10;
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
                Convert.ToInt32(comboBoxGroups.SelectedValue),
                pictureBoxPhoto.Image
                );
        }

        private void buttonOboz_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = 
                "JPG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All image files|*.png;*.jpg|All files (*.*)|*.*";
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                pictureBoxPhoto.Image = Image.FromFile(dialog.FileName);
            }
            
        }
    }
}
