namespace JogoDaAdivinhacao.ConsoleApp
{
    class JogoAdivinhacao
    {
        public static bool FacilEscolhida(string dificuldade)
        {
            bool FacilEscolhida = dificuldade == "1";

            return FacilEscolhida;

        }
        public static bool MedioEscolhida(string dificuldade)
        {
            bool FacilEscolhida = dificuldade == "2";

            return FacilEscolhida;

        }
        public static bool DificilEscolhida(string dificuldade)
        {
            bool FacilEscolhida = dificuldade == "3";

            return FacilEscolhida;

        }

        public static int GeradorNumero()
        {
            Random geradorNumeros = new Random();
            int numeroSecreto = geradorNumeros.Next(1, 21);

            return numeroSecreto;
        }


    }
}
