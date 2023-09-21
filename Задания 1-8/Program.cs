using System;
using System.Threading;


namespace Задания_1_8
{
    internal class Program

        // Упражнение 8 - Структура: Фамилия,имя,идентефикатор, дата рожд., состояние,выпитый объем
        // 4 категории алкоголизма 
    {
        enum Alcohol
        {
            Alcoholic,
            Drinker,
            Party_Drinker,
            Not_Drink
        }
        struct Student
        {
            public string Surname;
            public string Name;
            public int id;
            public string date;
            public Alcohol alcohol;
            public double liter;
            public void Print()
            {
                Console.WriteLine($"Студент - {Surname} {Name} выпил {liter} литра алкогольного напитка");
            }

        }   
        
    
        
        static void Main(string[] args)
        {
            // Упражнение 1 - Типы данных и их макс. и мин. значения
            Console.WriteLine("Упражнение 1 - Типы данных и их макс. и мин. значения");
            Console.WriteLine("\nТип данных                      Максимальное                     Минимальное");
            Console.WriteLine("bool                            True                             False");
            Console.WriteLine("byte                            255                              0");
            Console.WriteLine("sbyte                           127                              -128");
            Console.WriteLine("short                           32767                            -32768");
            Console.WriteLine("ushort                          65535                            0");
            Console.WriteLine("int                             2147483647                       -2147483647");
            Console.WriteLine("uint                            4294967295                       0");
            Console.WriteLine("long                            9223372036854775807              -9223372036854775808");
            Console.WriteLine("ulong                           18446744073709551615             0");
            Console.WriteLine("decimal                         7,992816e28                      -7,992816e28");
            Console.WriteLine("float                           3,402823e38                      -3,402823e38");
            Console.WriteLine("double                          1,797693e308                     -1,797693e308");
            Console.WriteLine("char                            Любой символ Unicode             Любой символ Unicode");
            Thread.Sleep(5000);

            // Упражнение 2 - Программа, в которой данные пользователя в виде имени,города,возраста и пин кода
            Console.WriteLine("\nУпражнение 2 - Программа, в которой данные пользователя в виде имени,города,возраста и пин кода\n");
            Console.WriteLine("Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Из какого вы города?");
            string city = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            string age = Console.ReadLine();
            Console.WriteLine("Введите свой PIN-код");
            string code = Console.ReadLine();
            Console.WriteLine($"Имя: {name}\nГород: {city}\nВозраст: {age}\nPIN-код: {code}");
            Thread.Sleep(5000);

            // Упражнение 6 - Разговор Гарри Поттера и Тома Реддла
            Console.WriteLine("\nУпражнение 6 - Разговор Гарри Поттера и Тома Реддла\n");
            Console.WriteLine("*Пользователь здоровается*");
            Console.WriteLine("Как тебя зовут?");
            string name1 = Console.ReadLine();
            Console.WriteLine($"Привет,{name1}");
            Console.ReadLine();
            Console.WriteLine("Да.");
            Console.ReadLine();
            Console.WriteLine("Нет.");
            Thread.Sleep(5000);
            Console.WriteLine("Но могу показать..");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вот, это место здесь");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(5000);

            // Упражнение 8 - 5 студентов, их имена,фамилии, идентефикатор,дата рождения, категория алкоголизма
            Console.WriteLine("\nУпражнение 8 - 5 студентов, их имена,фамилии, идентефикатор,дата рождения, категория алкоголизма\n");
            // 1студент
            Student Student1 = new Student();
            Student1.Surname = "Громов";
            Student1.Name = "Сергей";
            Student1.id = 1;
            Student1.date = "07.07.1999";
            Student1.alcohol = 0;
            Student1.liter = 2;
            Student1.Print();
            // 2 студент
            Student Student2 = new Student();
            Student2.Surname = "Овечкин";
            Student2.Name = "Александр";
            Student2.id = 2;
            Student2.date = "03.03.1999";
            Student2.alcohol = 0;
            Student2.liter = 3;
            Student2.Print();
            // 3 студент
            Student Student3 = new Student();
            Student3.Surname = "Харламов";
            Student3.Name = "Гарик";
            Student3.id = 3;
            Student3.date = "04.04.1999";
            Student3.alcohol = 0;
            Student3.liter = 3;
            Student3.Print();
            // 4 студент
            Student Student4 = new Student();
            Student4.Surname = "Техник";
            Student4.Name = "Паша";
            Student4.id = 4;
            Student4.date = "05.05.1999";
            Student4.alcohol = 0;
            Student4.liter = 4;
            Student4.Print();
            // 5 студент
            Student Student5 = new Student();
            Student5.Surname = "Гейтс";
            Student5.Name = "Билл";
            Student5.id = 5;
            Student5.date = "06.06.1999";
            Student5.alcohol = 0;
            Student5.liter = 2;
            Student5.Print();
            Console.WriteLine("\n");
            Thread.Sleep(1500);
            double all_liters = Student1.liter + Student2.liter + Student3.liter + Student4.liter + Student5.liter;
            Console.WriteLine("Общий объем выпитого алкоголя " + all_liters + "литров");
            Console.WriteLine("\n");
            Thread.Sleep(1000);
            Console.WriteLine($"{Student1.Name} {Student1.Surname} выпил {(Student1.liter / all_liters * 100)}% от общего объема алкоголя\n" +
                $"{Student2.Name} {Student2.Surname} выпил {(Student2.liter / all_liters * 100)}% от общего объема алкоголя\n" +
                $"{Student3.Name} {Student3.Surname} выпил {(Student3.liter / all_liters * 100)}% от общего объема алкоголя\n" +
                $"{Student4.Name} {Student4.Surname} выпил {(Student4.liter / all_liters * 100)}% от общего объема алкоголя\n" +
                $"{Student5.Name} {Student5.Surname} выпил {(Student5.liter / all_liters * 100)}% от общего объема алкоголя\n");
        }
    }
}
