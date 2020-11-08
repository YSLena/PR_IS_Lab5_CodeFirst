using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_CodeFirst
{
    /*
     * TODO 0. Цель работы - изучение технологии Entity Framework Core Code First
     * https://docs.microsoft.com/ru-ru/ef/core/modeling/entity-types?tabs=data-annotations
     */

    /*
     * TODO 1. Создание классов
     * Классы для работы с данными - это обычные классы, описывающие предметную область
     * Некоторые дополнительные настройки можно выполнить при помощи атрибутов,
     * Но если устраивает поведение по умолчанию - можно просто описать классы, как обычно,
     * не заморачиваясь тем, что они представляют БД
     */

    public class Address
    {
        /* По умолчанию первичный ключ должен иметь имя Id или <ClassName>Id (т.е. AddressId).
         * Если придерживаться этого соглашения, не нужно дополнительно указывать, 
         * что это первыичный ключ
         */
        public int Id { get; set; }
        public string Street { get; set; }
        public int? House { get; set; }

        /*
         * Для моделирования связи один-ко многим используем свойство-коллекцию
         */
        public List<Person> Persons1 { get; set; }
    }
}
