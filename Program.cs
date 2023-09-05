using System.Threading.Channels;

namespace Lesson2ifElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Условные Выражения
            /*
            Console.WriteLine("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (b!=0)
                Console.WriteLine(a/b);
            else
                Console.WriteLine("Division by zero");

            //Операторы сравнения: == != < > <= >=

            //Ксли значение переменной а равно значению переменной б...

            if (a==b)//...правда, тогда....
                Console.WriteLine("Numbers are equals");
            else
                Console.WriteLine("Numbers are not equals");

            //if (условное выражение)
            // инстрекуия, которая булет выаолняться если условное выражение верно
            // else
            // инстрекуия, которая булет выаолняться если условное выражение не верно

            bool answer = a == b;
            Console.WriteLine(answer);

            // Определение большего числа из двух имеющихся
            Console.WriteLine("Enter a: ");
           
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b: ");

            b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("Biggest: "); 
                Console.WriteLine(a); 
            }
            else 
            if (a < b)
                Console.WriteLine("Biggest: " + b);
            else
                Console.WriteLine( "Numbers are equales");
            */
            //Если в условных выражениях нужно выполнить больше одной инструкции, 
            //тогда их необходимо объединиить в фигурные скобки.

            //В программировании часто допускаются ошибки, которые можно разедить на две группы
            // - синтаксические ошибки, которые не позволяют скопилировать и запустить программу.
            //Такие ошибки определяются на этапе компиляции. 
            //- ошибки во время выполнения (то есть в runtime), то есть 
            //ошибки, которые возникают в процессе работы программы.
            //Примерами таких ошибко могут быть:
            //- деление не 0.
            // - не удачная конвертация строки в число 
            // -отсутствие соединения с базой данных

            /* int x = 9; int y = 19;

            if (y < 10)
                    Console.WriteLine("*****");
            else
                    Console.WriteLine("#####");

            Console.WriteLine("$$$$$"); 

            if (x !< 10 || y < 10)
            {
                    Console.WriteLine("*****");
            }
            else
            {
                Console.WriteLine("#####");
                Console.WriteLine("$$$$$");
            }

            // || - Логичкское ИЛИ
            // && - Логичкское И
            // ! - Логичкское отрицание

            // Нельзя эти операторы путать с побитовыми И (&) или  (|)

            x = 54;
            y = 6;

            //Проверим что X и Y - чётные числа

            if (x % 2 == 0 && y % 2 == 0)
                Console.WriteLine("4etnie");
            else
                Console.WriteLine("Ne 4etnie");

            //Провкрить что Х больше 50 но  меньещ 100

            if (x > 50 && x < 100)
                Console.WriteLine("tit");
            else
                Console.WriteLine("tint");

            int c;
            int thisisAVariable;
            int q76354;
            int number;

            Console.WriteLine("Введите целое число: ");

            int Age = Convert.ToInt32(Console.ReadLine());

            number = Age;

            Console.WriteLine(number);

            Console.WriteLine("This is C# program");

            Console.WriteLine("This is \nC# program");

            Console.WriteLine("This\nis\nC#\nprogram");

            Console.WriteLine("This\tis\tC#\tprogram");

            int xx;
            int yy;
            int zz;
            int result;



            Console.WriteLine("Введите первое число: ");
            xx = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            yy = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число: ");
            zz = Convert.ToInt32(Console.ReadLine());



            result = xx * yy * zz;



            Console.WriteLine("Result is: " + result);   



            Console.WriteLine("*********\n*       *\n*       *\n*       *\n*       *\n*       *\n*       *\n*       *\n*********");


            Console.WriteLine("   ***   ");
            Console.WriteLine(" *     * ");
            Console.WriteLine("*       *");
            Console.WriteLine("*       *");
            Console.WriteLine("*       *");
            Console.WriteLine("*       *");
            Console.WriteLine("*       *");
            Console.WriteLine(" *     * ");
            Console.WriteLine("   ***   ");

            Console.WriteLine("    *    ");
            Console.WriteLine("   ***   ");
            Console.WriteLine("  *****  ");
            Console.WriteLine("    *    ");
            Console.WriteLine("    *    ");
            Console.WriteLine("    *    ");
            Console.WriteLine("    *    ");
            Console.WriteLine("    *    ");
            Console.WriteLine("    *    ");

            Console.WriteLine("    *    ");
            Console.WriteLine("   * *   ");
            Console.WriteLine("  *   *  ");
            Console.WriteLine(" *     * ");
            Console.WriteLine("*       *");
            Console.WriteLine(" *     * ");
            Console.WriteLine("  *   *  ");
            Console.WriteLine("   * *   ");
            Console.WriteLine("    *    ");

            Console.WriteLine("* * * * * * * *\n * * * * * * * *\n* * * * * * * *\n * * * * * * * *\n* * * * * * * *\n * * * * * * * *\n* * * * * * * *\n * * * * * * * *\n");

           
            
            //Написать программу, вычисляющую среднее арифметическое трёх чисел.
            Console.WriteLine("Эта программа ща выведет среднее арифметическое из трёх, вводимых Вами, чисел!");

            Console.WriteLine("Введите первое число плз: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число плз: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третее число плз: ");
            int thirdNumber = Convert.ToInt32(Console.ReadLine());

            int average = (firstNumber + secondNumber + thirdNumber)/3;

            Console.WriteLine("Средним арифметическим числом из трёх чисел, которые Вы ввели, является - " + average);  



            //Написать программу, которая переводит гривны в доллары и евро.
            Console.WriteLine("Эта программа переведёт гривны в доллары и евро.");

            Console.WriteLine("Введите курс UAH ---> USD");
          //decimal uahUsd = Convert.ToInt32(Console.ReadLine());
            decimal uahUsd = 0.027m;

            Console.WriteLine("Введите курс UAH ---> EUR");
          //decimal uahEur = Convert.ToInt32(Console.ReadLine());
            decimal uahEur = 0.025m;

            Console.WriteLine("Введите количество UAH: ");
            decimal uah = Convert.ToInt32(Console.ReadLine());

            decimal resultUahUsd = uah * uahUsd;
            decimal itegerResultUahUsd = Math.Floor(resultUahUsd); //Math.Floor Метод - Возвращает наибольшее целое число, которое меньше или равно указанному числу.
            decimal centResultUahUsd = (resultUahUsd - itegerResultUahUsd) * 100;
            decimal roundedCentResultUahUsd = Math.Round(centResultUahUsd, 0); // Math.Round Метод - Округляет значение до ближайшего целого или указанного количества десятичных знаков.

            decimal resultUahEur = uah * uahEur;
            decimal itegerResultUahEur = Math.Floor(resultUahEur); //Math.Floor Метод - Возвращает наибольшее целое число, которое меньше или равно указанному числу.
            decimal centResultUahEur = (resultUahEur - itegerResultUahEur) * 100;
            decimal roundedCentResultUahEur = Math.Round(centResultUahEur, 0); // Math.Round Метод - Округляет значение до ближайшего целого или указанного количества десятичных знаков.

            Console.WriteLine("При обмене " + uah + "грн на доллары по курсу " + uahUsd + " вы получите " + itegerResultUahUsd + " долларов и " + roundedCentResultUahUsd + " центов.");

            Console.WriteLine("При обмене " + uah + "грн на доллары по курсу " + uahEur + " вы получите " + itegerResultUahEur + " евро и " + roundedCentResultUahEur + " центов");  


            
            //Выведете текст на экран:
            Console.WriteLine("To \"be\" or not to \"be\"\n\t\\Shakespeare\\"); 



            //Напишите программу, которое возводит в квадрат введённое пользователем число
            Console.WriteLine("Эта программа, котороя возводит в квадрат введённое Вами число");
            Console.WriteLine("Итак, введите Ваше число: ");

            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Вы ввели число " + num + ". Квадратом данного числа является число - " + (num * num)); 



            //Напишите программу, в которой пользователь вводит пять чисел. В результате, программ должна вывести сумму и произведение этих чисел.
            Console.WriteLine("Это программа, в которой пользователь вводит пять чисел. В результате, программ выведет сумму и произведение этих чисел.");
            
            Console.WriteLine("Итак, введите первое число: ");
            int firstNumberA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Теперь введите второе число: ");
            int secondtNumberA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Теперь введите третее число: ");
            int thirdNumberA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Теперь введите четвёртое число: ");
            int fourthtNumberA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ну и наконец введите пятое число: ");
            int fifthNumberA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Вы ввели пять чисел.\nИх сумма равна - " + (firstNumberA + secondtNumberA + thirdNumberA + fourthtNumberA + fifthNumberA) + "\nА их произведение равно - " + (firstNumberA * secondtNumberA * thirdNumberA * fourthtNumberA * fifthNumberA)); */



            //





        }
    }
}