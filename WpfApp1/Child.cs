using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Child : Father, ICloneable, IComparable, IPerson
    {
        public Child(string firstname,string surname, string patronymic) : base(firstname, surname, patronymic)
        {
            FirstName = firstname;
            SurName = surname;
            Patronymic = patronymic;
        }

        public int CompareTo(object ch)
        {
            Child child = (Child)ch;
            if (SurName == child.SurName) return 1;
            if (SurName != child.SurName) return -1;
            return 0;
        }

        public Child ShallowClone()
        {
            return (Child)MemberwiseClone();
        }

        public object Clone()
        {
            return new Child(FirstName,SurName, Patronymic);
        }

        public string Print()
        {
            return PrintName() + $" {Patronymic}";
        }
    }
}
