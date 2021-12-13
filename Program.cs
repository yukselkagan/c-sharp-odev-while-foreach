using System;

namespace c_sharp_odev_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");

            int number1 = int.Parse( Console.ReadLine() );
            int counter = 1;
            int total = 0;

            while(counter <= number1 ){
                total += counter;
                counter += 1;
            }

            Console.WriteLine(total/number1);

            char v_char1 = 'a';
            while(v_char1 <= 'z' ){
                Console.Write(v_char1);
                v_char1++;
            }

            Console.WriteLine("\n");


            string[] friends = {"Aragorn", "Legolas", "Gimli"};
            foreach(var item in friends){
                Console.WriteLine(item);
            }






        }
    }
}
