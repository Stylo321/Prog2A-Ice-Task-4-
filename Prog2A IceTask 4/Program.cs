using System;

class Program
{
    // Delegate
    delegate int DoubleNumber(int x);

    static void Main(string[] args)
    {
        // a) Anonymous Method
        DoubleNumber doublerAnonymous = delegate (int x)
        {
            return x * 2;
        };

        Console.WriteLine("Anonymous Method Result: " + doublerAnonymous(5));

        // b) Lambda Expression
        DoubleNumber doublerLambda = x => x * 2;

        Console.WriteLine("Lambda Expression Result: " + doublerLambda(5));
    }
}