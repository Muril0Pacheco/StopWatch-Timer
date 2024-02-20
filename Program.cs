using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuUm();
        }

        static void MenuUm() 
        {
            Console.Clear();
            Console.WriteLine("1 - Temporizador");
            Console.WriteLine("2 - Cronômetro\n");
            Console.Write("Digite a opção desejada: ");
            string opcao = Console.ReadLine();
            if (opcao == "1")
                MenuDois(opcao);

            if (opcao == "2")
                MenuDois(opcao);

            else
                MenuUm();
        }

        static void MenuDois(string opcao)
        {      
            Console.Clear();
            Console.WriteLine("S  = Segundos -> 10s = 10 segundos");
            Console.WriteLine("M  = Minutos -> 1m = 1 minuto");
            Console.WriteLine("00 = Voltar ao menu anterior");
            Console.Write("Quanto tempo deseja contar?: ");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
               MenuUm();

            if (opcao == "1")
                PreStarTemp(time * multiplier);

            if (opcao == "2")
            {
                PreStartCron(time * multiplier);
            }

        }

        static void PreStarTemp(int time)
        {
            Console.Clear();
            Console.WriteLine("Iniciando StopWatch...");
            Thread.Sleep(1000);

            StarTemporizador(time);
        }

        static void PreStartCron(int time)
        {
            Console.Clear();
            Console.WriteLine("Iniciando StopWatch...");
            Thread.Sleep(1000);

            StartCronometro(time);
        }

        static void StarTemporizador(int time)
        {
            int currenTime = time;

            Console.Clear();

            for (int i = currenTime; i > 0; i--)
            {
                Console.Clear();
                Console.WriteLine($"-> {i}");
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
            MenuUm();

        }

        static void StartCronometro(int time)
        {
            int currenTime = 0;
            Console.Clear();

            while (currenTime < time)
            {
                Console.Clear();
                currenTime++;
                Console.WriteLine($"-> {currenTime}");
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
            MenuUm();
        }


    }
}
