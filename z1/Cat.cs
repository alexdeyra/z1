using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using z1;

namespace z1
{
    class Cat
    {
        private string name; // скрытое поле для имени кота
        private double weight; // скрытое поле для веса кота

        public Cat(string catName, double initialWeight)
        {
            Name = catName; // Устанавливаем имя кота через свойство Name
            Weight = initialWeight; // Устанавливаем вес кота через свойство Weight
        }
        public string Name // свойство, реализуем инкапсуляцию!
        {
            // получение значения - просто возврат name
            get
            {
                return name; // Возвращаем текущее значение имени
            }
            // установка значения - используем проверку
            set
            {
                bool OnlyLetters = true;
                // ключ. слово value - это то, что хотят свойству присвоить
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters)
                {
                    name = value;
                    Console.WriteLine($"{name}: МЯЯЯЯУ!!!!");
                }
                else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
            }
        }
        public double Weight // Свойство для доступа к весу кота
        {
            get 
            { 
                return weight; 
            } // Геттер для получения значения веса
            set
            {
                if (value > 0) // Проверка, что вес больше нуля
                {
                    weight = value; // Устанавливаем вес кота
                    Console.WriteLine($"{name} весит: {weight} кг"); // Выводим сообщение с весом
                }
                else // Если вес меньше или равен нулю
                {
                    Console.WriteLine($"{value} кг: Вес не может быть нулевым или отрицательным"); // Сообщение об ошибке
                }
            }
        }
    }
}

