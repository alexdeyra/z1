using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace z1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя кота: "); // Запрос имени кота у пользователя
            string catName = Console.ReadLine();  // Чтение имени кота из ввода пользователя
            double initialWeight;  // Объявление переменной для хранения веса кота
            Console.Write("Введите вес кота (положительное число): "); //Запрос веса кота у пользователя
            while (!double.TryParse(Console.ReadLine(), out initialWeight)|| initialWeight <=0 ) //Цикл для проверки корректности ввода веса
            {
                Console.WriteLine("Ошибка: Пожалуйста, введите положительное число."); // Сообщение об ошибке, если ввод некорректен
                Console.Write("Введите вес кота (положительное число):"); 
            }

            Cat myCat = new Cat(catName, initialWeight); // Создание объекта Cat с именем и весом
            Console.ReadKey(); // Ожидание нажатия клавиши перед завершением программы
        }
    }

}
