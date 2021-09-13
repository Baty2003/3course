 using System;

namespace study
{
    class Program
    {

        class Arithmetic
        {
            public Arithmetic(int num1, int num2)
            {
                int summa = num1 + num2;
                Console.WriteLine("Сумма двух чисел: " + summa);
            }
            public Arithmetic(int num1, int num2, int num3)
            {
                int summa = num1 + num2 + num3;
                Console.WriteLine("Сумма трёх чисел: " + summa);
            }
            public Arithmetic(int num1, int num2, int num3, int num4)
            {
                int summa = num1 + num2 + num3 + num4;
                Console.WriteLine("Сумма четырёх чисел: " + summa);
            }


        }
        class Student
        {
            public Student()
            {
                Console.WriteLine("Введите своё имя: ");
                name = Console.ReadLine();
                Console.WriteLine("Введите свою Фамилию: ");
                surname = Console.ReadLine();
                Console.WriteLine("Введите своё Отчество: ");
                patronymic = Console.ReadLine();
                Console.WriteLine("Введите свою группу: ");
                group = Console.ReadLine();
                if (group != "ПО-328")
                {
                    Console.WriteLine("Группа не совпадает");
                }
                else
                {
                    Console.WriteLine("Чётко, группа найдена");
                }
            }

            string name;
            string surname;
            string patronymic;
            string group;


        }

        static void Main(string[] args)
        {
            Arithmetic one = new Arithmetic(5,10,6,86);
            Student tom = new Student();


        }
    }
}
