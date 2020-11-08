using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_CodeFirst
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDay { get; set; }

        /*
         * Вторая сторона связи один-ко многим (т.е. многие-к одному)
         * Здесь используем свойство-ссылку
         */
        public Address Adress { get; set; }
    }
}
