namespace Threads_Sistemas_Distribuidos
{
    public static class Numeros
    {
        public static void ExibeNumerosPares(int numeroExecucoes)
        {
            Console.WriteLine("Iniciando Thread números pares");
            for (int i = 1; i <= numeroExecucoes; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"Numero Par = {i}");
            }
            Console.WriteLine("Finalizando Thread números pares");
        }

        public static void ExibeNumerosImpares(int numeroExecucoes)
        {
            Console.WriteLine("Iniciando Thread números impares");
            for (int i = 1; i <= numeroExecucoes; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine($"Numero Impar = {i}");
            }
            Console.WriteLine("Finalizando Thread números impares");
        }
    }
}
