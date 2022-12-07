using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Father
    {
        public string FirstName { get; set; }

        public string SurName { get; set; }
        
        public string Patronymic { get; set; }


        public Father(string firstname,string surname, string patronymic)
        {
            FirstName = firstname;
            SurName = surname;
            Patronymic = patronymic;
        }

        public string PrintName()
        {
            return $"{FirstName}";
        }
    }
}
