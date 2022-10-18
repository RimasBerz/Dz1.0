using System;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp16
{
    public class Person 
    {
        string name;
        string surname;
        string fathername;
        string adresshome;
        DateTime birthday;
        string phonenumber;

        public string Name {
            get => name;
            set
            {
                if (value == "Гитлер" || value == "Hitler")
                {
                    throw new PersonExceptionName("Ты не гитлер", "You not Hitler");
                }
                else
                {
                    Console.WriteLine("Окей!");
                }
                name = value;
            }
        }

        public string Surname { 
                get => surname;
                set
            {
                    if (value == "Гитлер" || value == "Hitler")
                    {
                        throw new PersonExceptionName("Ты не гитлер", "You not Hitler");
                    }
                    else
                    {
                        Console.WriteLine("Окей!");
                    }
                    surname = value;
                }
            }
        public string Fathername
        {
            get => fathername;
            set
            {
                if (value == "Гитлер" || value == "Hitler")
                {
                    throw new PersonExceptionName("Ты не гитлер", "You not Hitler");
                }
                else
                {
                    Console.WriteLine("Окей!");
                }
                fathername = value;
            }
        }
        public string Adresshome
        {
            get => adresshome;
            set
            {
                if (value == "Гитлер" || value == "Hitler")
                {
                    throw new PersonExceptionName("Ты не гитлер", "You not Hitler");
                }
                else
                {
                    Console.WriteLine("Окей!");
                }
                adresshome = value;
            }
        }
        public string Phonenumber
        {
            get => phonenumber;
            set
            {
                if (value == "Гитлер" || value == "Hitler")
                {
                    throw new PersonExceptionName("Ты не гитлер", "You not Hitler");
                }
                else
                {
                    Console.WriteLine("Окей!");
                }
                phonenumber = value;
            }
        }
        public DateTime Birthday { get; set; }

        public void SetName(string name)
        {
           Name = name;
        }

        public void SetSurname(string surname)
        {
            Surname = surname;
        }
        public void SetFathername(string fathername)
        {
            Fathername = fathername;
        }
        public void SetAddress(string adresshome)
        {
            Adresshome = adresshome;
        }
        public void SetPhoneNumber(string phonenumber)
        {
            Phonenumber = phonenumber;
        }
        public void SetBirthday(DateTime birthday)
        {
            Birthday = birthday;
        }
        public string GetName()
        {
            return name;
        }

        public string GetSurname()
        {
            return surname;
        }

        public string GetFathername()
        {
            return fathername;
        }

        public string GetAddress()
        {
            return adresshome;
        }

        public string GetPhonenumber()
        {
            return phonenumber;
        }

        public DateTime GetBirthday()
        {
            return birthday;
        }
        public Person() : this("Taras", "Bylba", "??????", "--------", DateTime.Today) // Today для примера
        {
            Console.WriteLine("Person Constructor Without Parameters!");
        }

        public Person(string name, string lastname, string fathername, string phonenumber, DateTime birthday)
        {
            Console.WriteLine("Person Constructor With Parameters!");
            Name = name;
            Surname = lastname;
            Fathername = fathername;
            Phonenumber = phonenumber;
            Birthday = birthday;
        }

        // переопределение ТуС
        public override string ToString()
        {
            return Name + " " + Surname + " " + Fathername + ",Phonenumber " + ", age: " + Birthday;
        }
    }
}