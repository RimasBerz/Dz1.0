using System;
using System.Collections.Generic;

namespace ConsoleApp16
{

    public class Student : Person, ICloneable, IComparable<Student>
    {
        List<int> hometasks = new List<int>();
        List<int> practices = new List<int>();
        List<int> exams = new List<int>();

        public void AddHometask(int rate)
        {

            if (rate > 12 || rate <= 0) throw new IndexOutOfRangeException();

            hometasks.Add(rate);
        }

        public void AddPractices(int rate)
        {
            if (rate > 12 || rate <= 0) throw new IndexOutOfRangeException();

            practices.Add(rate);
        }
        public void AddExams(int rate)
        {
            if (rate > 12 || rate <= 0) throw new IndexOutOfRangeException();

            exams.Add(rate);
        }

        public void PrintHometasks()
        {
            foreach (var i in hometasks)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
        }

        public double AverageHt()
        {
            double avg = 0;
            for (int i = 0; i < hometasks.Count; i++)
            {
                avg += hometasks[i];
            }
            avg /= hometasks.Count;
            return avg;
        }
        public void PrintPractices()
        {
            foreach (var i in practices)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
        }
        public double AveragePractices()
        {
            double avg2 = 0;
            for (int i = 0; i < practices.Count; i++)
            {
                avg2 += practices[i];
            }
            avg2 /= practices.Count;
            return avg2;

        }
        public void PrintExams()
        {
            foreach (var i in exams)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
        }
        public double AverageExams()
        {
            double avg3 = 0;
            for (int i = 0; i < exams.Count; i++)
            {
                avg3 += exams[i];
            }
            avg3 /= exams.Count;
            return avg3;

        }
        public override bool Equals(object Otsenka)
        {
            Student OtsenkaSt = Otsenka as Student;
            if (OtsenkaSt == null)
            {
                Console.WriteLine("OOPS! ETO NE PERSON!!!");
                return false;
            }
            return OtsenkaSt.hometasks == this.hometasks;
            //return OtsenkaSt.practices == this.practices;
            //return OtsenkaSt.exams == this.exams;
        }

        public static bool operator ==(Student left, Student right)
        {
            return left.AverageHt() == right.AverageHt();
            //return left.AveragePractices() == right.AveragePractices();
            //return left.AverageExams() == right.AverageExams();
        }
        public static bool operator !=(Student left, Student right)
        {
            return !(left == right);
        }
        public static bool operator >(Student left, Student right)
        {
            return left.AverageHt() > right.AverageHt();
            //return left.AveragePractices() > right.AveragePractices();
            //return left.AverageExams() > right.AverageExams();
        }
        public static bool operator <(Student left, Student right)
        {
            return left.AverageHt() < right.AverageHt();
            //return left.AveragePractices() < right.AveragePractices();
            //return left.AverageExams() < right.AverageExams();
        }
        public override int GetHashCode()
        {
            return -1062103556 + hometasks.GetHashCode();
            //return -1062104578 + practices.GetHashCode();
            //return -1062105063 + exams.GetHashCode();
        }

        public void Print2()
        {
            System.Console.WriteLine("ФИО : {0}\n{1}\n{2}", Name, Surname, Fathername);
            System.Console.WriteLine("Улица : {0}", Adresshome);
            System.Console.WriteLine("Телефон : {0}", Phonenumber);
            System.Console.WriteLine("День рождения : {1}", Birthday, new DateTime(1970, 1, 1));
            System.Console.WriteLine("среднее арифметическое дз:{0}", AverageHt());
            PrintHometasks();
            PrintPractices();
            PrintExams();
            AverageHt();
            AveragePractices();
            AverageExams();
        }
        

        public Student(string name, string surname, string fathername) { }
        public Student() : this("Name", "Surname", "FN") { }
        public Student(string name, string surname, string fathername, string adresshome, string phonenumber)
        {
            SetName(name);
            SetSurname(surname);
            SetFathername(fathername);
            SetAddress(adresshome);
            SetPhoneNumber(phonenumber);
            SetBirthday(new DateTime(1970, 1, 1));
            PrintHometasks();
            PrintPractices();
            PrintExams();
            AverageHt();
            AveragePractices();
            AverageExams();
        }
        public override string ToString()
        {
            return base.ToString() + ", среднее арифметическое дз: " + AverageHt() + "среднее арифметическое пр: " + AverageHt();
        }

        public object Clone()
        {
            throw new NotImplementedException();
            Student copy = new Student();
            copy.Name = this.Name;
            copy.Surname = this.Surname;
            copy.Fathername = this.Fathername;
            copy.Adresshome = this.Adresshome;
            copy.Birthday = this.Birthday;
            copy.Phonenumber = this.Phonenumber;
            return copy;
            //new Student(Name, Surname, Fathername, Adresshome, Phonenumber);
        }

        public int CompareTo(Student other)
        {
            if (this.AverageHt() < other.AverageHt()) return -1;
            if (this.AverageHt() > other.AverageHt()) return 1;
            if (this.AverageExams() < other.AverageExams()) return -1;
            if (this.AverageExams() > other.AverageExams()) return 1;
            if (this.AveragePractices() < other.AveragePractices()) return -1;
            if (this.AveragePractices() > other.AveragePractices()) return 1;
            

            return 0;
        }
    }
}

