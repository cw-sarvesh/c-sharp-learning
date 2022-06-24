using System;
using System.Collections.Generic;
using Divide = test_namespace;


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

            Console.WriteLine(addResult);
            Console.WriteLine(subtractResult);



            // Class resent in different namespace or directory.

            int productResult = Multiply.Multiply.Product(5, 5);

            Console.WriteLine(productResult);


            // Using method from outside project
            float divideResult = Divide.Program.Divide(14, 7);

            System.Console.WriteLine(divideResult);

        }


    }
}