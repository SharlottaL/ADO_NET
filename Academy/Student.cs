using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Academy
{
    internal class Student:Human
    {
        public int Group { get; set; }
        public Student() { }
        public Student(int stud_id) : base(stud_id, "Students","stud_id")
        {
            Group = Convert.ToInt32(HumanData.Rows[0][8].ToString());
        }
        public Student(string last_name, string first_name, string middle_name,
            string birth_date, string email, string phone, 
            int group, 
            Image photo) : base(last_name, first_name, middle_name, birth_date, email, phone, photo)
        {

            //LastName = last_name;
            //FirstName = first_name;
            //MiddleName = middle_name;
            //BirthDate = birth_date;
            //Email = email;
            //Phone = phone;
            Group = group;
           // Photo = photo;
        }
        //public byte[] SerializePhoto()
        //{
        //    MemoryStream ms = new MemoryStream();
        //    Photo.Save(ms, Photo.RawFormat);
        //    return ms.ToArray();
        //}
        public override string ToString()
        {
            return $"{base.ToString()},{Group}";
        }
        public override string ToStringUpdate()
        {
            return $"{base.ToStringUpdate()}, [group]={Group}";
        }
    }
}
