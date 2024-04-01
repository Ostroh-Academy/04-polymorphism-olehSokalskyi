// See https://aka.ms/new-console-template for more information

using Lab2_25;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("You like chose 2x2 system or 3x3\n1. chose 2x2\n2. chose 3x3");
        Console.WriteLine("Enter number: ");
        Factory factory;
        
        int chose_value = int.Parse(Console.ReadLine());
        while(chose_value != 1 && chose_value != 2)
        {
            Console.WriteLine("1 or 2 only!");
            Console.WriteLine("Enter number: ");
            chose_value = int.Parse(Console.ReadLine());
        }
        switch (chose_value)
        {
            case 1:
            {
        
                double[] x2x2 = new double[] { 1, 2 };
                factory = new FactoryA();
                Console.WriteLine("Система рівнянь 2х2:");
                factory.FactoryMethod().PrintEquationSystem();
                Console.WriteLine($"Вектор x = ({x2x2[0]}, {x2x2[1]}) {(factory.FactoryMethod().CheckVectorSatisfies(x2x2) ? "задовольняє" : "не задовольняє")} систему рівнянь 2х2.");
                break;
            }
            case 2:
            {
             
                double[] x3x3 = new double[] { 1, 2, 3 };
                
                factory = new FactoryB();
                Console.WriteLine("СЛАР 3х3:");
                factory.FactoryMethod().PrintEquationSystem();
                Console.WriteLine($"Вектор x = ({x3x3[0]}, {x3x3[1]}, {x3x3[2]}) {(factory.FactoryMethod().CheckVectorSatisfies(x3x3) ? "задовольняє" : "не задовольняє")} СЛАР 3х3.");
                break;
            }
       
        }
    }
}