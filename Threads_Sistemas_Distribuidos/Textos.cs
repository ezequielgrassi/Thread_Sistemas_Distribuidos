namespace Threads_Sistemas_Distribuidos
{
    public static class Textos
    {
        public static void EscreveTexto(int numeroExecucoes)
        {
            Console.WriteLine("Iniciando Thread escrevendo linhas");
            for (int i = 1; i <= numeroExecucoes; i++)
            {
                Console.WriteLine($"Escrevendo linha {i}");
            }
            Console.WriteLine("Finalizando Thread escrevendo linhas");
        }
    }
}
