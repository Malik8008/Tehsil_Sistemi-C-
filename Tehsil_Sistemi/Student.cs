using System;
using System.Collections.Generic;
using System.Text;

namespace Tehsil_Sistemi
{
    internal class Student
    {

        public int id { get; set; }
        public static int ID = 0;
        public string Fullname { get; set; }

        private byte _point;
        public byte Point
        {
            get
            {
                return _point;
            }
            set
            {
                if (value>0 && value<100)
                {
                    _point = value;
                }
            }
        }

        public Student(string fullname,byte point)
        {
            ID = ++id;
            Fullname = fullname;
            Point = point;
        }
    }
}
