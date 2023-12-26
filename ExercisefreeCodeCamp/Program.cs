using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisefreeCodeCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable
            /*string characterName = "Tom";

            int characterAge;
            characterAge = 17;

            Console.WriteLine("There once was a man named" + characterName);
            Console.WriteLine("He was" + characterAge + "years old");

            characterName = "Mike";
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being" + characterAge);

            Console.ReadLine();*/

            //Data Type String type
            /*string phrase = "Girrafe Academy";
            char grade = 'A';
            int age = 30;
            double ipk = 3.5;
            bool isMale = true;


            Console.WriteLine(phrase.Contains ("Academy"));//jika kita menggunakan [] maka yang di hitung merupakan index dari kalimat di atas atau pada kelas phrase
            

            //User input 
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.ReadLine();*/

            //Calculator
            Console.Write("Enter a number :");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number :");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Choose math operation (+ , - , * , /) ");
            string operartion = Console.ReadLine();
            double hasil = 0;

            switch (operartion)
            {
                case "+":
                    hasil = num1 + num2;
                    break;
                case "-":
                    hasil = num1 - num2;
                    break;
                case "*":
                    hasil = num1 * num2;
                    break;
                case "/":
                    if(num1 != 0 || num2 != 0)
                    {
                        hasil = num1 / num2;
                    }
                    else
                    {
                        Console.Write("ERROR : NUMBER CAN'T DEVINE WITH ZERO");
                    }
                    break;
                default:
                    break;
            }
                Console.WriteLine(value: "Result :" + hasil);

            Console.ReadLine();

        }
    }
    
}
