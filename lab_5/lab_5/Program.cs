//Проаналізувати завдання, виділити інформаційні об’єкти та дії. Визначити правильну ієрархію об’єктів
//Створити базовий суперклас (абстрактний клас або інтерфейс) і визначити загальні методи для даного класу. Створити підкласи, в які додати специфічні властивості та методи. Частину методів перевизначити. 
//Розробити програму з використанням абстрактних класів та інтерфейсів. Чітко розуміти, де доцільно використати суперклас, а де звичайний. 
//При розробці використовувати наслідування та поліморфізм
//У всіх класах повинні бути реалізовані доцільні для класу методи, навіть якщо це не вказано у завданні
//Використовувати об’єкти підкласів для моделювання реальних ситуацій та об’єктів

//Створити суперклас Спорядження і підкласи Лижі, Сноуборд, Бігові лижі, Гірські лижі, Рюкзак, Шолом. Подумати, які з вищенаведених підкласів також можуть бути суперкласами. 
//Визначити максимальну швидкість кожного спорядження. За допомогою конструктора встановити його вартість.

using System;

namespace lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Оберіть спорядження");
            Console.WriteLine("1. Лижі");
            Console.WriteLine("2. Сноуборд");
            Console.WriteLine("3. Бігові лижі");
            Console.WriteLine("4. Гірські лижі");
            Console.WriteLine("5. Рюкзак");
            Console.WriteLine("6. Шолом");
           

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Skis skis = new Skis(2000); 
                    Console.WriteLine($"Ціна {skis.Price}");
                    Console.WriteLine("Відстань(км)");
                    double distanceS = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Час(год)");
                    double timeS = Convert.ToDouble(Console.ReadLine());
                    double speedS = skis.CalculateSpeed(distanceS, timeS);
                    Console.WriteLine($"Швидкість {speedS} км/год");
                    break;
                case 2:
                    Snowboard snowboard = new Snowboard(1890); 
                    Console.WriteLine($"Ціна {snowboard.Price}");
                    Console.WriteLine("Відстань(км)");
                    double distanceSb = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Час(год)");
                    double timeSb = Convert.ToDouble(Console.ReadLine());
                    double speedSb = snowboard.CalculateSpeed(distanceSb, timeSb);
                    Console.WriteLine($"Швидкість {speedSb} км/год");
                    break;
                case 3:
                    CrossCountrySkis crossCountrySkis = new CrossCountrySkis(2500); 
                    Console.WriteLine($"Ціна {crossCountrySkis.Price}");
                    Console.WriteLine("Відстань(км)");
                    double distanceCC = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Час(год)");
                    double timeCC = Convert.ToDouble(Console.ReadLine());
                    double speedCC = crossCountrySkis.CalculateSpeed(distanceCC, timeCC);
                    Console.WriteLine($"Швидкість {speedCC} км/год");
                    break;
                case 4:
                    AlpineSkis alpineSkis = new AlpineSkis(2450); 
                    Console.WriteLine($"Ціна {alpineSkis.Price}");
                    Console.WriteLine("Відстань(км):");
                    double distanceAS = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Час(год)");
                    double timeAS = Convert.ToDouble(Console.ReadLine());
                    double speedAS = alpineSkis.CalculateSpeed(distanceAS, timeAS);
                    Console.WriteLine($"Швидкість {speedAS} км/год");
                    break;
                case 5:
                    Backpack backpack = new Backpack(500); 
                    Console.WriteLine($"Ціна {backpack.Price}");
                    Console.WriteLine($"Швидкість {backpack.GetMaxSpeed()}");
                    break;
                case 6:
                    Helmet helmet = new Helmet(600); 
                    Console.WriteLine($"Ціна {helmet.Price}");
                    Console.WriteLine($"Швидкість {helmet.GetMaxSpeed()}");
                    break;
                default:
                    Console.WriteLine("Помилка");
                    break;
            }
        }
    }
}