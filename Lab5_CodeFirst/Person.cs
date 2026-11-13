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
        * Друга сторона зв'язку один до багатьох (тобто багато до одного) 
        * Тут використовуємо властивість-посилання 
        */
        public Address Adress { get; set; }
    }
}
