namespace JogoDeAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Jogo de Adivinhação");
                Console.WriteLine("=======================================");
                Console.WriteLine("\nSeja muito bem vindo ao novo jogo do Largartinho");

                //menu
                Console.WriteLine("\nEscolha a dificuldade:");
                Console.WriteLine("=======================================");
                Console.WriteLine("1 - Fraco ):< (10 tentativas)");
                Console.WriteLine("2 - Médio (: (10 tentativas)");
                Console.WriteLine("3 - Dificil (:< (10 tentativas)");
                Console.WriteLine("=======================================");

                int totalDeTentativas = 0;

                Console.WriteLine("Digite a dificuldade desejada: ");
                string dificuldade = Console.ReadLine();

                if (dificuldade == "1")
                {
                    Console.WriteLine("Dificuldade Fraca selecionada");
                }
                else if (dificuldade == "2")
                {
                    Console.WriteLine("Dificuldade Média selecionada");
                }
                else if (dificuldade == "3")
                {
                    Console.WriteLine("Dificuldade Difícil selecionada");
                }
                else
                {
                    Console.WriteLine("Meu bem você arrumo errado vai lá e faz denovo (hehe esse dai é dos burro)");
                    Console.ReadLine();
                    continue;
                }

                Random geradorNumeros = new Random();
                int numeroSecreto = geradorNumeros.Next(1, 20);
                for (int tentativas = 1; tentativas <= totalDeTentativas; tentativas++)
                {
                    Console.WriteLine("==========================");
                    Console.WriteLine($"Tentativas {tentativas} de {totalDeTentativas}");
                    Console.WriteLine("==========================");

                    if (tentativas == totalDeTentativas)
                    {
                        Console.WriteLine("==========================");
                        Console.WriteLine($"Mas que peninha, parece que alguem vai perder o sistema operacional, o número era {numeroSecreto}");
                        Console.WriteLine("Mas sou de coração bom, quer outra chance ???");
                        Console.WriteLine("==========================");

                        break;
                    }

                    Console.WriteLine("\n\nDigite um número: ");
                    int numeroDigitado = Convert.ToInt32(Console.ReadLine());


                    if (numeroDigitado == numeroSecreto)
                    {
                        Console.WriteLine("==========================");
                        Console.WriteLine("Parabéns, você acertou e vai ganhar nada (:");
                        Console.WriteLine("==========================");

                        break;
                    }

                    else if (numeroDigitado > numeroSecreto)
                    {
                        Console.WriteLine("==========================");
                        Console.WriteLine("Ta indo muito alto em!!!");
                        Console.WriteLine("==========================");
                    }

                    else if (numeroDigitado < numeroSecreto)
                    {
                        Console.WriteLine("==========================");
                        Console.WriteLine("Ta indo muito baixo em!!!");
                        Console.WriteLine("==========================");
                    }


                }

                Console.WriteLine("Deseja continuar? (S/N)");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                {
                    break;
                }
            }
        }
    }
}
