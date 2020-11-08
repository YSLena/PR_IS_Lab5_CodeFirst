using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

/* TODO 0.1: Подготовка к работе
 * Должны быть установлены NuGet пакеты:
 * - Microsoft.EntityFrameworkCore.SqlServer,
 * - Microsoft.EntityFrameworkCore.Tools.
 * Это можно сделать через менеджер пакетов (Project \ Manage NuGet Packages ...).
 * 
 * Или через консоль диспетчер пакетов (Tools \ NuGet Package Manager \ Package Manager Console), 
 * выполнив команды:
 * Install-Package Microsoft.EntityFrameworkCore.SqlServer
 * Install-Package Microsoft.EntityFrameworkCore.Tools
 */
 
namespace Lab5_CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (PersonContext db = new PersonContext())
            {
                /*
                 * TODO 3. Выполнение манипуляций с данными
                 * Для работы с данными используются обычные методы коллекций: Add, Remove и т.д.
                 * Выполненные изменения сохраняются в БД при выполнении метода db.SaveChanges();
                 */

                /*
                 * TODO 3.1. Добавление данных
                 * Генерируем объекты и помещаем их в коллекции
                 * Здесь для этого написаны специальные генераторы.
                 * Но можно обойтись и без этого, описав данные в коде
                 */


                Address addr;
                Person pers;

                Console.WriteLine("Прежде всего, всех убъём (при первом обращении к БД может потребовать времени)");

                db.Address.RemoveRange(db.Address);
                db.Person.RemoveRange(db.Person);
                db.SaveChanges();

                Console.WriteLine("Подключитесь к БД и убедитесь, что таблицы пустые");
                Console.WriteLine("Чтобы продолжить, нажмите Enter");
                Console.ReadLine();


                Console.WriteLine("Генерирование белиберды. Это может потребовть времени");

                // наполнение коллекций

                addr = new Address() { Street = "Абрикосовая", House = 94 };
                db.Address.Add(addr);
                db.Person.Add(new Person() { Name = "Яблоков М.К.", BirthDay = new DateTime(1995, 8, 8), Adress = addr });
                db.Person.Add(new Person() { Name = "Яблокова Р.К.", BirthDay = new DateTime(2003, 9, 27), Adress = addr });
                addr = new Address() { Street = "Абрикосовая", House = 20 };
                db.Address.Add(addr);
                db.Person.Add(new Person() { Name = "Сидоров С.В.", BirthDay = new DateTime(1964, 9, 2), Adress = addr });
                db.Person.Add(new Person() { Name = "Цветочкина С.Т.", BirthDay = new DateTime(2010, 11, 27), Adress = addr });
                addr = new Address() { Street = "Кактусовая", House = 199 };
                db.Address.Add(addr);
                db.Person.Add(new Person() { Name = "Лисицина Р.В.", BirthDay = new DateTime(1988, 5, 6), Adress = addr });
                db.Person.Add(new Person() { Name = "Медведева Л.З.", BirthDay = new DateTime(1924, 2, 17), Adress = addr });
                addr = new Address() { Street = "Виноградная", House = 11 };
                db.Address.Add(addr);
                db.Person.Add(new Person() { Name = "Лютикова И.Т.", BirthDay = new DateTime(1955, 12, 24), Adress = addr });
                addr = new Address() { Street = "Грушовая", House = 20 };
                db.Address.Add(addr);
                db.Person.Add(new Person() { Name = "Цветочкин И.Г.", BirthDay = new DateTime(2010, 3, 23), Adress = addr });
                db.Person.Add(new Person() { Name = "Ромашкин Л.П.", BirthDay = new DateTime(2018, 12, 24), Adress = addr });
                addr = new Address() { Street = "Кактусовая", House = 53 };
                db.Address.Add(addr);
                addr = new Address() { Street = "Сосновая", House = 89 };
                db.Address.Add(addr);
                db.Person.Add(new Person() { Name = "Яблоков И.С.", BirthDay = new DateTime(2002, 2, 6), Adress = addr });
                addr = new Address() { Street = "Вишнёвая", House = 62 };
                db.Address.Add(addr);
                addr = new Address() { Street = "Еловая", House = 207 };
                db.Address.Add(addr);
                db.Person.Add(new Person() { Name = "Иванова С.В.", BirthDay = new DateTime(2015, 8, 4), Adress = addr });
                addr = new Address() { Street = "Виноградная", House = 17 };
                db.Address.Add(addr);
                db.Person.Add(new Person() { Name = "Цветочкин Р.А.", BirthDay = new DateTime(1944, 11, 17), Adress = addr });
                addr = new Address() { Street = "Абрикосовая", House = 211 };
                db.Address.Add(addr);
                addr = new Address() { Street = "Еловая", House = 34 };
                db.Address.Add(addr);
                db.Person.Add(new Person() { Name = "Петрова Л.Е.", BirthDay = new DateTime(1996, 3, 2), Adress = addr });
                addr = new Address() { Street = "Абрикосовая", House = 291 };
                db.Address.Add(addr);
                db.Person.Add(new Person() { Name = "Сидорова Я.К.", BirthDay = new DateTime(2001, 4, 4), Adress = addr });
                db.Person.Add(new Person() { Name = "Медведева Р.В.", BirthDay = new DateTime(1936, 2, 23), Adress = addr });
                db.Person.Add(new Person() { Name = "Лисицин С.К.", BirthDay = new DateTime(1923, 5, 18), Adress = addr });
                db.Person.Add(new Person() { Name = "Петрова В.П.", BirthDay = new DateTime(1963, 3, 28), Adress = addr });
                addr = new Address() { Street = "Вишнёвая", House = 71 };
                db.Address.Add(addr);
                db.Person.Add(new Person() { Name = "Иванова И.В.", BirthDay = new DateTime(1938, 3, 17), Adress = addr });
                db.Person.Add(new Person() { Name = "Яблокова Л.С.", BirthDay = new DateTime(2014, 7, 27), Adress = addr });
                addr = new Address() { Street = "Сосновая", House = 81 };
                db.Address.Add(addr);
                addr = new Address() { Street = "Абрикосовая", House = 41 };
                db.Address.Add(addr);
                db.Person.Add(new Person() { Name = "Иванов Я.А.", BirthDay = new DateTime(1921, 9, 14), Adress = addr });
                db.Person.Add(new Person() { Name = "Иванова Л.Т.", BirthDay = new DateTime(1959, 3, 7), Adress = addr });
                db.Person.Add(new Person() { Name = "Иванов Р.В.", BirthDay = new DateTime(1943, 11, 29), Adress = addr });
                addr = new Address() { Street = "Вишнёвая", House = 288 };
                db.Address.Add(addr);
                db.Person.Add(new Person() { Name = "Волков М.З.", BirthDay = new DateTime(1972, 9, 29), Adress = addr });
                db.Person.Add(new Person() { Name = "Лисицин Л.А.", BirthDay = new DateTime(1940, 3, 9), Adress = addr });
                db.Person.Add(new Person() { Name = "Яблокова В.С.", BirthDay = new DateTime(1947, 4, 29), Adress = addr });
                db.Person.Add(new Person() { Name = "Лютиков В.З.", BirthDay = new DateTime(2014, 4, 2), Adress = addr });
                addr = new Address() { Street = "Тенистая", House = 149 };
                db.Address.Add(addr);
                db.Person.Add(new Person() { Name = "Петров Л.Г.", BirthDay = new DateTime(1959, 2, 17), Adress = addr });
                db.Person.Add(new Person() { Name = "Петрова М.К.", BirthDay = new DateTime(2019, 10, 4), Adress = addr });
                db.Person.Add(new Person() { Name = "Петров Р.А.", BirthDay = new DateTime(1933, 11, 14), Adress = addr });
                db.Person.Add(new Person() { Name = "Петров С.А.", BirthDay = new DateTime(1952, 10, 4), Adress = addr });
                db.Person.Add(new Person() { Name = "Яблоков М.К.", BirthDay = new DateTime(1988, 12, 12), Adress = addr });
                db.Person.Add(new Person() { Name = "Цветочкин Ц.П.", BirthDay = new DateTime(1926, 3, 6), Adress = addr });
                addr = new Address() { Street = "Еловая", House = 91 };
                db.Address.Add(addr);
                db.Person.Add(new Person() { Name = "Волкова Р.В.", BirthDay = new DateTime(1993, 4, 7), Adress = addr });
                db.Person.Add(new Person() { Name = "Петров М.А.", BirthDay = new DateTime(2018, 2, 13), Adress = addr });
                db.Person.Add(new Person() { Name = "Волкова С.В.", BirthDay = new DateTime(1994, 7, 30), Adress = addr });
                db.Person.Add(new Person() { Name = "Иванова Р.С.", BirthDay = new DateTime(1986, 4, 5), Adress = addr });
                addr = new Address() { Street = "Грушовая", House = 280 };
                db.Address.Add(addr);
                db.Person.Add(new Person() { Name = "Цветочкин В.Е.", BirthDay = new DateTime(1929, 3, 26), Adress = addr });
                db.Person.Add(new Person() { Name = "Лютикова Ц.Т.", BirthDay = new DateTime(1988, 10, 28), Adress = addr });




                // сохранение данных в бд
                db.SaveChanges();
                Console.WriteLine("\nБелиберда сохранена в БД. Адресов " + db.Address.Count() +
                    ", жителей " + db.Person.Count());
                Console.WriteLine("Прежде, чем продолжить, откройте БД и убедитесь в наличии данных");
                Console.WriteLine("Чтобы продолжить, нажмите Enter");
                Console.ReadLine();

                /* 
                 * TODO 3.2. Извлечение связанных данных
                 * Связанные данные должны быть явно загружены методом Include()
                 */

                Console.WriteLine("Извлечение связанных данных");
                Console.WriteLine("Список жильцов ул. Виноградная");
                foreach (Person p in db.Person.Include(per => per.Adress).Where(pp => pp.Adress.Street.Contains("Виноградная")).ToList())
                    Console.WriteLine("  " + p.Name + ", ул. " + p.Adress.Street + ", д. " + p.Adress.House);
                Console.WriteLine();
                Console.WriteLine("Чтобы продолжить, нажмите Enter");
                Console.ReadLine();


                /*
                * TODO 3.3. Редактирование данных
                */

                int apple = db.Person.Where(pp => pp.Name.Contains("Яблоков")).Count();
                Console.WriteLine("\nСмена фамилии Яблоков -> Тыблоков (" + apple + " строк)");
                foreach (Person p in db.Person.Where(pp => pp.Name.Contains("Яблоков")).ToList())
                    p.Name = p.Name.Replace("Яблоков", "Тыблоков");
                db.SaveChanges();
                Console.WriteLine("Откройте БД, перевыполните запрос данных, и проверьте изменение данных");
                Console.WriteLine("Чтобы продолжить, нажмите Enter");
                Console.ReadLine();

                /*
                 * TODO 3.4. Удаление данных
                 */

                int buttercup = db.Person.Where(pp => pp.Name.Contains("Лютиков")).Count();
                Console.WriteLine("\nУдаление Лютиковых (" + buttercup + " строк)");
                foreach (Person p in db.Person.Where(pp => pp.Name.Contains("Лютиков")).ToList())
                    db.Person.Remove(p);
                Console.WriteLine("Откройте БД, перевыполните запрос данных, и убедитесь, что строки удалены");
                Console.WriteLine("Чтобы продолжить, нажмите Enter");
                db.SaveChanges();

            }
            Console.ReadLine();
        }
    }
}
