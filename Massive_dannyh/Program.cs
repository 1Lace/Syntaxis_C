using System;

namespace project{

    class Program {

        static void Main() {

            short[] numbers = new short[10];
            Random random = new Random();
            short sum = 0;

            for(byte i = 0; i < numbers.Length; i++){               
                numbers[i] = Convert.ToInt16(random.Next(-5, 15));
                Console.WriteLine("El: " + numbers[i]);

                sum += numbers[i];


            }
        
        Console.WriteLine("Summa: " + sum);
        }
    }
}