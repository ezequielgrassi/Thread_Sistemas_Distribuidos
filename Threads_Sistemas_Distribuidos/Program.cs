using Threads_Sistemas_Distribuidos;

int opcao = 0;

Console.WriteLine("1 - Threads com concorrencia");
Console.WriteLine("2 - Threads sem concorrencia");
Console.WriteLine("3 - Sair");

int.TryParse(Console.ReadLine(), out opcao);

Console.WriteLine("");
Console.WriteLine("Informe a quantidade de Threads a serem criadas:");

int.TryParse(Console.ReadLine(), out int numeroThreads);

Console.WriteLine("");
Console.WriteLine("Informe o limite de execuções:");

int.TryParse(Console.ReadLine(), out int numeroExecucoes);

Console.WriteLine("");

if (opcao == 1)
    IniciaThreads(numeroThreads, numeroExecucoes, false);
else if (opcao == 2)
    IniciaThreads(numeroThreads, numeroExecucoes, true);

Console.ReadKey();


void IniciaThreads(int numeroThreads, int numeroExecucoes, bool semConcorrencia)
{
    Console.WriteLine("Iniciando threads");
    for (int i = 1; i <= numeroThreads; i++)
    {
        var servicoAleatorio = new Random().Next(1, 3);
        Thread threadAleatorio;
        switch (servicoAleatorio)
        {
            case 1:
                threadAleatorio = new Thread(() => { Numeros.ExibeNumerosPares(numeroExecucoes); });
                threadAleatorio.Start();
                if (semConcorrencia)
                    threadAleatorio.Join();
                break;

            case 2:
                threadAleatorio = new Thread(() => { Numeros.ExibeNumerosImpares(numeroExecucoes); });
                threadAleatorio.Start();
                if (semConcorrencia)
                    threadAleatorio.Join();
                break;

            case 3:
                threadAleatorio = new Thread(() => { Textos.EscreveTexto(numeroExecucoes); });
                threadAleatorio.Start();
                if (semConcorrencia)
                    threadAleatorio.Join();
                break;

            default:
                threadAleatorio = new Thread(() => { Console.WriteLine("Default"); });
                threadAleatorio.Start();
                if (semConcorrencia)
                    threadAleatorio.Join();
                break;
        }
    }
}

