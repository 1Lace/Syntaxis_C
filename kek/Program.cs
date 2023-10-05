using System;

namespace project {

    class Program {

        static void Main() {
           // System.Console.WriteLine(Math.Abs(-20)); - число по модулю
           //Console.WriteLine(Math.Ceiling(4.11f)); // - округление к большему
           //Console.WriteLine(Math.Floor(4.11f)); // - округление к меньшему
            //Console.WriteLine(Math.Round(4.11f)); // - округление по ситуации

            //Console.WriteLine(Math.Min(5, 0)); // мин число
            //Console.WriteLine(Math.Max(5, 0)); // макс число
            //Console.WriteLine(Math.Pow(5, 2)); // возведение в степень

            System.Console.WriteLine("Введите радиус круга: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            System.Console.WriteLine("Плоащадь круга с радиусом {0} равна {1}", radius, area);











            //Console.Write("Введите число с точкой:" );
            //user_input = Convert.ToDouble(Console.ReadLine());
            //float user_input = float.Parse(Console.ReadLine());
            //float result;
            //result = user_input + 10f;
            //result = result + 5f;
            //result += 5f;
            //result *= 2f;
            //result++; //Добавили 1, -- - отняли единицу
            /*result = user_input - 10f;
            result = user_input * 10f;
            result = user_input / 10f;
            result = user_input % 10f;
                                        */
            //int a = 5, b = 6;
            //int res = a + b;        
            //Console.WriteLine("Переменная: " + result);
        }


    }


}

    
