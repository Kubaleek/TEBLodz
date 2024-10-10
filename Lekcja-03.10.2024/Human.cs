using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja_03._10._2024
{
    public class Human
    {
        protected int _age;
        protected string _name;
        protected char? _gender;


        public Human()
        {
            _age = 0;
            _name = string.Empty;
            _gender = null;
        }

        public Human(int age, string name, char? gender)
        {
            _age = age;
            _name = name;
            _gender = gender;
        }

        public int Age { get { return _age; } set { _age = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public char? Gender { get { return _gender; } set { _gender = value; } }

        public virtual void Details()
        {
            Console.WriteLine(_age + " " + _name + " " + _gender);
        }
    }

    public class Student : Human
    {
        private int _nr;
        private string _klasa;
        private string _kierunek;

        public Student() : base()
        {
            _nr = 0;
            _klasa = string.Empty;
            _kierunek = string.Empty;
        }

        public Student(int age, string name, char? gender, int nr, string klasa, string kierunek) : base(age, name, gender)
        {
            {
                _nr = nr;
                _klasa = klasa;
                _kierunek = kierunek;

            }
        }

        public int Nr { get { return _nr; } set { _nr = value; } }
        public string Klasa { get { return _klasa; } set { _klasa = value; } }
        public string Kierunek { get { return _kierunek; } set { _kierunek = value; } }

        public override void Details()
        {
            Console.WriteLine(_age + " " + _name + " " + _gender + " " + _nr + " " + _klasa + " " + _kierunek);
        }
    }
}
