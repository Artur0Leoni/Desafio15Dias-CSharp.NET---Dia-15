using System;
using System.Threading;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("===== TIMER POMODORO =====\n");

            Console.Write("Digite o tempo de foco (em minutos): ");
            if (!int.TryParse(Console.ReadLine(), out int minutos) || minutos <= 0)
            {
                Console.WriteLine("Tempo inválido! Pressione ENTER para tentar novamente.");
                Console.ReadLine();
                continue;
            }

            int totalSegundos = minutos * 60;

            for (int segundosRestantes = totalSegundos; segundosRestantes >= 0; segundosRestantes--)
            {
                Console.Clear();
                TimeSpan tempo = TimeSpan.FromSeconds(segundosRestantes);

                Console.WriteLine("===== TIMER POMODORO =====\n");
                Console.WriteLine($"Tempo restante: {tempo:mm\\:ss}");
                Console.WriteLine("\nFoque no que importa! 💻🔥");

                Thread.Sleep(1000);
            }

            Console.Beep();
            Console.WriteLine("\n Tempo finalizado!");
            Console.Write("Deseja iniciar outro Pomodoro? (s/n): ");

            string resposta = Console.ReadLine().ToLower();
            continuar = resposta == "s" || resposta == "sim";
        }

        Console.WriteLine("\nBom trabalho! Até a próxima");
    }
}