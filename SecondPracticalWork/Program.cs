using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondPracticalWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice, number, x;
            Random rand = new Random();
            while (true)
            {
                Tasks(); // вызов функции, в котором перечислены задания
                Console.Write("Введите номер задания: ");
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    //***********************************************************************************
                    case 1:
                        double y;

                        Console.Write("Дано уравнение y = 7x^2 - 3x + 4:\nВведите значение x = ");
                        x = int.Parse(Console.ReadLine());
                        y = 7 * Math.Pow(x, 2) - 3 * x + 4;
                        Console.Write("y = " + y);
                        break;
                    //************************************************************************************
                    case 2:
                        const double PI = 3.14;
                        int r;
                        double c, s; // длина окружности, 2 * PI * R, площадь окружности PI * R^2

                        Console.Write("Введите радиус окружности\nR = ");
                        r = int.Parse(Console.ReadLine());
                        c = 2 * PI * r;
                        s = PI * Math.Pow(r, 2);
                        Console.Write("Длина окружности C = " + c); Console.Write("\nПлощадь окружности S = " + s);
                        break;
                    //************************************************************************************
                    case 3:
                        Console.Write("Введите расстояние в сантиметрах: ");
                        int distance = int.Parse(Console.ReadLine());
                        Console.Write("Это эквивалентно - " + distance / 100 + " м");
                        break;
                    //************************************************************************************
                    case 4:
                        int pastDays = 234, daysInWeek = 7;
                        Console.Write("Прошло " + pastDays + " дня\nПрошло полных недель - " + (pastDays / daysInWeek));
                        break;
                    //************************************************************************************
                    case 5:
                        int firstNumb, secondNumb, count = 0;
                        int twoDigitNumber = rand.Next(10, 100);
                        if ((firstNumb = twoDigitNumber / 10) == 1) count++;
                        if ((secondNumb = twoDigitNumber % 10) == int.Parse("1")) count++;

                        Console.WriteLine("Дано двузначное число: " + twoDigitNumber);
                        Console.Write("Число десятков в нем - " + twoDigitNumber / 10 +
                            "\nЧисло единиц в нем - " + count +
                            "\nСумма его цифр - " + (firstNumb + secondNumb) +
                            "\nПроизведение его цифр - " + (firstNumb * secondNumb));
                        break;
                    //************************************************************************************
                    case 6:
                        number = rand.Next(1000, 10000);
                        int multiplication = 1, sum = 0;
                        Console.WriteLine("Дано четырехзначное число - " + number);
                        for (; number != 0;)
                        {
                            sum += number % 10;
                            multiplication *= number % 10;
                            number /= 10;
                        }
                        Console.WriteLine("\nСумма чисел: " + sum + "\nПроизведение чисел: " + multiplication);
                        break;
                    //************************************************************************************
                    case 7:
                        int _a = 4, _b = 5, _c = 6;
                        x = 100 * _a + 10 * _c + _b;
                        Console.WriteLine("Число x = " + x);
                        break;
                    //************************************************************************************
                    case 8:
                        LogicalExpression(true, true);
                        LogicalExpression(true, false);
                        LogicalExpression(false, true);
                        LogicalExpression(false, false);
                        break;
                    //************************************************************************************
                    default:
                        break;
                }
                Console.Write("\n\nДля продолжения нажмите ENTER");
                Console.ReadLine();
                Console.Clear();
            }
        }

        static void LogicalExpression(bool X, bool Y)
        {
            Console.WriteLine("Если X = " + X + ", Y = " + Y);
            Console.WriteLine("a) не X и не Y - " + (!X && !Y));
            Console.WriteLine("b) X или(не X и Y) - " + (X || (!X && Y)));
            Console.WriteLine("c) (не X и Y) или Y - " + ((!X && Y) || Y) + "\n");
        }
        static void Tasks()
        {
            Console.WriteLine("1. Вычисление значения функции y=7x^2-3x+4  при любом значении x;" +
    "\n2. Дан радиус окружности.Найти длину окружности и площадь круга." +
    "\n3. Дано расстояние в сантиметрах.Найти число полных метров в нем." +
    "\n4. С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период ?" +
    "\n5. Дано двузначное число. Найти:" +
            "\n\t - число десятков в нем;" +
            "\n\t - число единиц в нем;" +
            "\n\t - сумму его цифр;" +
            "\n\t - произведение его цифр" +
    "\n6. Дано четырехзначное число. Найти:" +
            "\n\t - сумму его цифр;" +
            "\n\t - произведение его цифр." +
    "\n7. В трехзначном числе x зачеркнули его вторую цифру. Когда к образованному при этом двузначному числу " +
    "\n   справа приписали вторую цифру числа x, то получилось число 456. Найти число x." +
    "\n8. Вычислить значение логического выражения при всех возможных значениях логических величин X и Y:" +
            "\n\t - не X и не Y;" +
            "\n\t - X или(не X и Y);" +
            "\n\t - (не X и Y) или Y."
            );
        }
    }
}