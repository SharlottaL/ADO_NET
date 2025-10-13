using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Teacher:Human
    {
        public string WorkSince { get; set; }
        public string Rate { get; set; }
        public Teacher() { }
        public Teacher(int teacher_id):base(teacher_id, "Teachers", "teacher_id")
        {
          WorkSince = HumanData.Rows[0][8].ToString();
          Rate = HumanData.Rows[0][9].ToString();
        }
       
        public Teacher
            (string last_name, string first_name, string middle_name,
            string birth_date, string email, string phone, 
            Image photo,
            string work_since, string rate)
            : base(last_name, first_name, middle_name, birth_date, email, phone, photo)
        {
            WorkSince = work_since;
            Rate = rate;
        }
        //public byte[] SerializePhoto()
        //{
        //    MemoryStream ms = new MemoryStream();
        //    Photo.Save(ms, Photo.RawFormat);
        //    return ms.ToArray();
        //}
        public override string ToString()
        {
            return $"{base.ToString()},'{WorkSince}','{Rate}'";
        }
        public override string ToStringUpdate()
        {
            return $"{base.ToStringUpdate()},work_since='{WorkSince}', rate='{Rate}'";
        }
    }
}
