namespace Calculator.Helper
{
    public static class Operacoes
    {
        public static void Soma()
        {
            Console.WriteLine("Primeiro valor: ");
            var v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor :");
            var v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da soma é {v1 + v2}.");

            Console.ReadKey();
            Display.Show();

        }

        public static void Subtracao()
        {

            Console.WriteLine("Primeiro valor: ");
            var v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor :");
            var v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da subtracao é {v1 - v2}.");

            Console.ReadKey();
            Display.Show();

        }

        public static void Divisao()
        {

            Console.WriteLine("Primeiro valor: ");
            var v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor :");
            var v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da divisao é {v1 / v2}.");

            Console.ReadKey();
            Display.Show();

        }

        public static void Multiplicacao()
        {

            Console.WriteLine("Primeiro valor: ");
            var v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor :");
            var v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da multiplicação é {v1 * v2}.");

            Console.ReadKey();
            Display.Show();

        }
    }
}
