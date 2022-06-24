using System;
using System.Collections.Generic;


namespace c_sharp_project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello New Project");

            // Class when present in same namespace or directory.

            // If function is declared as instance then create new object out of it to use its methods.
            Sum add = new Sum();

            int addResult = add.Add(4, 5);


            // If function is declared as static then we can directly use it.

            int subtractResult = Sum.Subtract(4, 2);

            System.Console.WriteLine(addResult);
            System.Console.WriteLine(subtractResult);



            // Class when present in different namespace or directory.

            int productResult = Multiply.Multiply.Product(5, 5);

            System.Console.WriteLine(productResult);

        }


    }
}