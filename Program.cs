// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program 
    {
        static void Main(string[] args)
        {
            Task1 t1 = new Task1(6);

            System.Console.WriteLine("Factorial");
            System.Console.WriteLine(t1.factorialFunction());

            System.Console.WriteLine("Fibonacci");
            List<int> l=t1.fibonacciFunction();
            l.ForEach(i=>Console.WriteLine("{0}",i));
        }
    }
}