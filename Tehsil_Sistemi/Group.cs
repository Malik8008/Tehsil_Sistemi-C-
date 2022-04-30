using System;
using System.Collections.Generic;
using System.Text;

namespace Tehsil_Sistemi
{
    internal class Group
    {
        public string GroupNo;
        public byte limit;
        public byte StudentLimit
        {
            get
            {
                return limit;
            }

            set
            {
                if (value >= 5 && value <= 18)
                {
                    limit = value;
                }
            }
        }

        private Student[] _students = new Student[0];

        public Group(string groupno, byte studenlimit)
        {
            GroupNo = groupno;
            StudentLimit = studenlimit;
        }        

        public static bool CheckGroupNo(string groupno)
        {
            bool HasUpper = false;
            bool HasDigit = false;
            if (groupno.Length == 5)
            {
                foreach (var item in groupno)
                {
                    if (char.IsUpper(item))
                    {
                        HasUpper = true;
                    }
                    else if (char.IsDigit(item))
                    {
                        HasDigit = true;
                    }
                }
            }
            bool result=HasUpper&& HasDigit;
            return result;

        }

        public void AddStudent(Student student)
        {
            if (_students.Length==StudentLimit)
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;
            }
        }

        public void GetStudent(int? id)
        {
            foreach (var item in _students)
            {
                if (item.id==id)
                {
                    Console.WriteLine(item);
                }
            }            
        }

        public Student[] GetAllStudent()
        {
            return _students;
        }
    }
}
