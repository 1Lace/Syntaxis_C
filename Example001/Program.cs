using System;

namespace project {

        class Program{

            static void Main() {
                short user_input = Convert.ToInt16(Console.ReadLine());

                switch(user_input) {

                    case 5: 
                        System.Console.WriteLine("Number in 5"); 
                        break;
                    
                    case 15: 
                        System.Console.WriteLine("Number in 15"); 
                        break;

                     case 20: 
                        System.Console.WriteLine("Number in 20"); 
                        break;

                     case 250: 
                        System.Console.WriteLine("Number in 250"); 
                        break;

                    default:
                        Console.WriteLine("Number is unrecognized!");
                        break;

                }    

                






            }

            


        }


}