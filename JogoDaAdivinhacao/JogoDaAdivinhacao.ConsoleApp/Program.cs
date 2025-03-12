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
                Console.WriteLine("2 - Médio (: (5 tentativas)");
                Console.WriteLine("3 - Dificil (:< (3 tentativas)");
                Console.WriteLine("=======================================");

                int totalDeTentativas = 0;

                Console.WriteLine("Digite a dificuldade desejada: ");
                string dificuldade = Console.ReadLine();

                if (dificuldade == "1")
                {
                    Console.WriteLine("\nDificuldade Fraca selecionada");
                    totalDeTentativas = 10;
                }
                else if (dificuldade == "2")
                {
                    Console.WriteLine("\nDificuldade Média selecionada");
                    totalDeTentativas = 5;
                }
                else if (dificuldade == "3")
                {
                    Console.WriteLine("\nDificuldade Difícil selecionada");
                    totalDeTentativas = 3;
                }
                else
                {
                    Console.WriteLine("\nMeu consagrado você arrumo errado vai lá e faz denovo");
                    Console.WriteLine("Aperte ENTER para continuar");
                    Console.ReadLine();
                    continue;
                }

                //geração do numero secreto
                Random geradorNumeros = new Random();
                int numeroSecreto = geradorNumeros.Next(1, 21);

                //loop tentativa
                for (int tentativas = 1; tentativas <= totalDeTentativas; tentativas++)
                {
                    Console.Clear();
                    Console.WriteLine("==========================");
                    Console.WriteLine($"Tentativas {tentativas} de {totalDeTentativas}");
                    Console.WriteLine("==========================");

                    Console.WriteLine("\nDigite um número entre 1 e 20 e veja se ganha ");
                    int numeroDigitado = Convert.ToInt32(Console.ReadLine());


                    if (numeroDigitado == numeroSecreto)
                    {
                        Console.WriteLine("\n==========================");
                        Console.WriteLine("Parabéns, você acertou e vai ganhar nada (:");
                        Console.WriteLine("==========================");

                        break;
                    }

                    if (tentativas == totalDeTentativas)
                    {
                        Console.WriteLine("\n==========================");
                        Console.WriteLine($"Mas que peninha, parece que alguem vai sair na divida, o número era {numeroSecreto}");
                        Console.WriteLine("Mas você chegou perto de ganhar o GRANDE PRÊMIO quer tentar denovo???");
                        Console.WriteLine("==========================");

                        break;
                    }

                    else if (numeroDigitado > numeroSecreto)
                    {
                        Console.WriteLine("\n==========================");
                        Console.WriteLine("Ta indo muito alto em!!!");
                        Console.WriteLine("==========================");
                    }

                    else if (numeroDigitado < numeroSecreto)
                    {
                        Console.WriteLine("\n==========================");
                        Console.WriteLine("Ta indo muito baixo em!!!");
                        Console.WriteLine("==========================");
                    }

                    Console.WriteLine("Aperte ENTER para continuar");
                    Console.ReadLine();

                }

                Console.WriteLine("Deseja continuar? (S/N)");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
                
            }   
        }
    }
}
