using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Human
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Image Photo { get; set; }
        //protected DataTable human { get; set; }
        protected DataTable HumanData { get; private set; }
        public Human() { }
        public Human(int human_id, string table, string fields)
        {
            Connector connector = new Connector();
            HumanData = connector.Select("*", $"{table}", $"{fields}={human_id}");
            ID = human_id;
            LastName = HumanData.Rows[0][1].ToString();
            FirstName = HumanData.Rows[0][2].ToString();
            MiddleName = HumanData.Rows[0][3].ToString();

            BirthDate = HumanData.Rows[0][4].ToString();
            Email = HumanData.Rows[0][5].ToString();
            Phone = HumanData.Rows[0][6].ToString();
            try
            {
                Photo = connector.DownloadPhoto(human_id, $"{table}", "photo");
            }
            catch (Exception)
            {
            }
        }
        public Human(string last_name, string first_name, string middle_name, string birth_date, string email, string phone, Image photo)
        {
            LastName = last_name;
            FirstName = first_name;
            MiddleName = middle_name;
            BirthDate = birth_date;
            Email = email;
            Phone = phone;
            Photo = photo;
        }
        public byte[] SerializePhoto()
        {
            MemoryStream ms = new MemoryStream();
            Photo.Save(ms, Photo.RawFormat);
            return ms.ToArray();
        }
        public override string ToString()
        {
            return $"N'{LastName}',N'{FirstName}',N'{MiddleName}',N'{BirthDate}',N'{Email}',N'{Phone}'";
        }
        public virtual string ToStringUpdate()
        {
            return $@"
                    last_name=N'{LastName}', 
                    first_name=N'{FirstName}',
                    middle_name=N'{MiddleName}',
                    birth_date='{BirthDate}',
                    email=N'{Email}',
                    phone=N'{Phone}'
                    ";
        }
    }
}
