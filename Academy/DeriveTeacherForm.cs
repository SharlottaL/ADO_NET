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
    public partial class DeriveTeacherForm : BaseHumanForm
    {
        public DeriveTeacherForm()
        {
            InitializeComponent();
        }

        public DeriveTeacherForm(int id) : this()
        {
            Human = new Teacher(id);
            Extract();
        }
        protected override void Extract()
        {
            base.Extract();
            labelID.Text = (Human as Teacher).ID.ToString();
        }
        protected override void buttonOK_Click(object sender, EventArgs e)
        {
            Human = new Teacher
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
