namespace Calculator.Helper
{
    public static class Display
    {
        private static short Menu()
        {
            Console.WriteLine("Por favor, escolha a operação que deseja realizar.");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("0 - Sair");

            return short.Parse(Console.ReadLine());
        }


        public static void Show()
        {
            var qualOperacao = Helper.Display.Menu();
            switch (qualOperacao)
            {
                case 1: Operacoes.Soma(); break;
                case 2: Operacoes.Subtracao(); break;
                case 3: Operacoes.Divisao(); break;
                case 4: Operacoes.Multiplicacao(); break;
                case 0: System.Environment.Exit(0); break;
                default: Show(); break;
            }
        }
    }
}
