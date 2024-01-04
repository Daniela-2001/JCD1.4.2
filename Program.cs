namespace JCD1._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Digite um número para a raiz quadrada: ");
            double num = Convert.ToDouble(Console.ReadLine());
            double raizQuadrada = Math.Sqrt(num);
            Console.WriteLine("A raiz quadrada do número digitado é " + raizQuadrada);



            //public double SquareRoot ()
        }
    }
}