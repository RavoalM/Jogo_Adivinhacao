using JogoDaAdivinhacao.ConsoleApp;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace JogoDeAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static int totalDeTentativas = 0;
        static void Main(string[] args)
        {
            while (true)
            {
                string dificuldade = ExibirMenu();

                if (JogoAdivinhacao.FacilEscolhida(dificuldade))
                {
                    FacilExibir();
                }
                else if (JogoAdivinhacao.MedioEscolhida(dificuldade))
                {
                    MedioExibir();
                }
                else if (JogoAdivinhacao.DificilEscolhida(dificuldade))
                {
                    DificilExibir();
                }
                else
                {
                    FalhaExibir();
                    continue;
                }

                //geração do numero secreto
                int numeroSecreto = JogoAdivinhacao.GeradorNumero();

                //loop tentativa
                for (int tentativas = 1; tentativas <= totalDeTentativas; tentativas++)
                {
                    int numeroDigitado = Gameplay(tentativas);

                    if (numeroDigitado == numeroSecreto)
                    {
                        VitoriaExibir();
                        break;
                    }

                    if (tentativas == totalDeTentativas)
                    {
                        DerrotaExibir(numeroSecreto);
                        break;
                    }

                    else if (numeroDigitado > numeroSecreto)
                    {
                        NaltoExibir();
                    }

                    else if (numeroDigitado < numeroSecreto)
                    {
                        NbaixoExibir();
                    }

                    Console.WriteLine("Aperte ENTER para continuar");
                    Console.ReadLine();

                }

                string opcaoContinuar = mensagemFinal();

                if (opcaoContinuar != "S")
                    break;

            }


        }
        public static string ExibirMenu()
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
            Console.WriteLine("Digite a dificuldade desejada: ");
            string dificuldade = Console.ReadLine();

            return dificuldade;
        }
        public static void FacilExibir()
        {
            Console.WriteLine("\nDificuldade Fraca selecionada");
            totalDeTentativas = 10;
        }
        public static void MedioExibir()
        {
            Console.WriteLine("\nDificuldade Média selecionada");
            totalDeTentativas = 5;
        }
        public static void DificilExibir()
        {
            Console.WriteLine("\nDificuldade Difícil selecionada");
            totalDeTentativas = 3;
        }
        public static void FalhaExibir()
        {
            Console.WriteLine("\nMeu consagrado você arrumo errado vai lá e faz denovo");
            Console.WriteLine("Aperte ENTER para continuar");
            Console.ReadLine();
        }
        public static int Gameplay(int tentativas)
        {
            Console.Clear();
            Console.WriteLine("==========================");
            Console.WriteLine($"Tentativas {tentativas} de {totalDeTentativas}");
            Console.WriteLine("==========================");

            Console.WriteLine("\nDigite um número entre 1 e 20 e veja se ganha ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            return numeroDigitado;

        }
        public static void VitoriaExibir()
        {
            Console.WriteLine("\n==========================");
            Console.WriteLine("Parabéns, você acertou e vai ganhar nada (:");
            Console.WriteLine("==========================");

        }
        public static void DerrotaExibir(int numeroSecreto)
        {
            Console.WriteLine("\n==========================");
            Console.WriteLine($"Mas que peninha, parece que alguem vai sair na divida, o número era {numeroSecreto}");
            Console.WriteLine("Mas você chegou perto de ganhar o GRANDE PRÊMIO quer tentar denovo???");
            Console.WriteLine("==========================");

        }
        public static void NaltoExibir()
        {
            Console.WriteLine("\n==========================");
            Console.WriteLine("Ta indo muito alto em!!!");
            Console.WriteLine("==========================");

        }
        public static void NbaixoExibir()
        {
            Console.WriteLine("\n==========================");
            Console.WriteLine("Ta indo muito baixo em!!!");
            Console.WriteLine("==========================");

        }
        public static string mensagemFinal()
        {
            Console.WriteLine("Deseja continuar? (S/N)");
            string opcaoContinuar = Console.ReadLine().ToUpper();

            return opcaoContinuar;
        }
    }

}
