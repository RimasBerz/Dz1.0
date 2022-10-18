using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp16
{
  
    public class Group
    {
        string namegroup;
        int numbercourse;
        List<Student> students = new List<Student>();
        public void SetNameGroup(string namegroup)
        {
            
            if (namegroup == "Дебилы" || namegroup == "Idiots")
            {
                throw new PersonExceptionName("Имей уважение!", "Dont name group like this!");
            }
            else
            {
                Console.WriteLine("Окей!");
            }
            this.namegroup = namegroup;
        }
        public void SetNumberCourse(int numbercourse)
        {
            if (numbercourse <= 0 || numbercourse >= 1000)
            {
                throw new PersonExceptionName("Не тот диапазон!", "You runned out diapazon!");
            }
            else
            {
                Console.WriteLine("Окей!");
            }
            this.numbercourse = numbercourse;
        }
        public int GetColStudent()
        {
            return students.Count;
        }
        public string GetNameGroup()
        {
            return NameGroup;
        }
        public int GetNumberCourse()
        {
            return NumberCourse;
        }
        public string GetStudent { get; set; }
        public string NameGroup { get; set; }
        public int NumberCourse { get; set; }
        public void AddStudent(Student s) 
        {
            students.Add(s);
        }
        public override bool Equals(object studentik)
        {
            Group Studentikg = studentik as Group;
            if (Studentikg == null)
            {
                Console.WriteLine("OOPS! ETO NE PERSON!!!");
                return false;
            }
            return Studentikg.students == this.students;
        }
        public static bool operator ==(Group left, Group right)
        {
            return left.students.Count == right.students.Count;
        }
        public static bool operator !=(Group left, Group right)
        {
            return !(left.students.Count == right.students.Count);
        }
     
        public int Length 
        {
            get
            {
               Int32 length = students.Count;
                return length;
            }
            set {  }
        }
        public Student this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    Console.WriteLine("OOPS! Bad index!");
                    return students.ElementAt(index);
                }
                else
                {
                    throw new Exception();
                }
            }

            set
            {
                if (index < 0 || index >= Length)
                {
                    Console.WriteLine("OOPS! Bad index!");
                    return;
                }
                else
                {
                    students[index] = value;
                }
            }
        }

        public Student this[string name, string surname, string fathername,string adresshome,string phonenumber]
        {
            get
            {
                foreach (var person in students)
                {
                    if (person.Name == name) return person;
                    else if (person.Surname == surname) return person;
                    else if (person.Fathername == fathername) return person;
                    else if (person.Adresshome == adresshome) return person;
                    else if (person.Phonenumber == phonenumber) return person;
                }
                throw new Exception("Unknown name or something else");
            }
        }
        public Student this[DateTime birthday]
        {
            get
            {
                foreach (var person in students)
                {
                    if (person.Birthday == birthday) return person;
                }
                throw new Exception("Unknown birthday");
            }
        }
        
        public void Print3() 
        {
            foreach (var s in students)
            {
                s.Print2();
            }
            Console.WriteLine("NameGroup:{0} ", NameGroup);
            Console.Write("NumberGroup:{0} ", NumberCourse);
        }

        public Group(string NameGroup, int NumberCourse)
        {
            SetNameGroup(NameGroup);
            SetNumberCourse(NumberCourse);
        }
        public Group(string NameGroup, int NumberCourse, int Length)
        {
            SetNameGroup(NameGroup);
            SetNumberCourse(NumberCourse);
            Console.WriteLine("Кол-во студентов{0}",Length);
        }
        public Group()
        {
            SetNameGroup("Имя группы");
            SetNumberCourse(0);
        }
    }
}
