﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Academy
{
    internal class Teacher
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Image Photo { get; set; }
        public string WorkSince { get; set; }
        public string Rate { get; set; }
        public Teacher() { }
        public Teacher(string last_name, string first_name, string middle_name, string birth_date, string email, string phone, Image photo, string work_since, string rate)
        {
            LastName = last_name;
            FirstName = first_name;
            MiddleName = middle_name;
            BirthDate = birth_date;
            Email = email;
            Phone = phone;
            Photo = photo;
            WorkSince = work_since;
            Rate = rate;
        }
        public byte[] SerializePhoto()
        {
            MemoryStream ms = new MemoryStream();
            Photo.Save(ms, Photo.RawFormat);
            return ms.ToArray();
        }
        public override string ToString()
        {
            return $"N'{LastName}',N'{FirstName}',N'{MiddleName}','{BirthDate}',N'{Email}',N'{Phone}','{WorkSince}','{Rate}'";
        }
        public string ToStringUpdate()
        {
            return $@"
                    last_name=N'{LastName}', 
                    first_name=N'{FirstName}',
                    middle_name=N'{MiddleName}',
                    birth_date='{BirthDate}',
                    email=N'{Email}',
                    phone=N'{Phone}',
                    work_since='{WorkSince}',
                    rate='{Rate}'
                    ";
        }
    }
}
