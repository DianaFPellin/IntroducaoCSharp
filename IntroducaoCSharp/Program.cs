using static IntroducaoCSharp.ClassEnumeration;

namespace IntroducaoCSharp
{
    internal class Program
    {
        #region Declaração de variáveis de tipos de dados
        //Números inteiros
        byte NumeroByte; // 0..255
        sbyte NumSByte; // -127..128

        short NumShort; // com sinal -32.767..32.768
        ushort NumUShort;
        Int16 NumInt16; 
        UInt16 NumUInt16; //00.65535

        int NumInt;
        Int32 NumInt32;
        uint NumUInt;
        UInt32 NumUInt32;

        long NumLong;
        ulong NumULong;
        Int64 NumInt64;
        UInt64 NumUInt64;

        //números reais

        float NumFloat;
        Single NumSingle;

        double NumDouble;
        Double numDouble2;

        decimal NumDecimal; //valores financeiros
        Decimal NumDecimal2;

        char Caracter;
        Char Caracter2;
        string Literal;

        bool logico;
        Boolean logicoBoolean;

        //declaração de vetores uni, bi, tridimensionais
        int[] pontos = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        float[] sinais = new float[3] { 21.54f, 29, 323f, 34.457f };

        static int[,] matriz = new int[2, 2] { { 1, 2 }, { 3, 4 } };
        int[,,] cubo = new int[2, 2, 2];

        //tipos estruturados
        struct Estrutura
        {
            public int Codigo;
            public string Nome;
        }

        public record Registro(int Codigo, string Nome);
        public record registro_2
        {
            public int Codigo;
            public string Nome;

            public registro_2()
            {

            }
        }

        //constantes
        const int BUFFER = 100;


        #endregion
        static void Main(string[] args)
        {
        // Modos de compilação
#if DEBUG
            Console.WriteLine("Modo debug");
#elif DEBUGDEMO
            Console.WriteLine("Modo DEMO!");
#else
            Console.WriteLine("Modo Release!");
#endif
            Console.WriteLine(matriz[0, 1].ToString());

            var x = 0;
            var y = 1.99;
            var s = "My name is jonas";
            var c = "K";

            var tipo = TipoDeCliente.Caloteiro;

            var limiteCredito = tipo == TipoDeCliente.Caloteiro? 0 : 10000

            // Data e hora

            DateOnly dt_1 = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            var dt_2 = DateTime.Now;

            TimeOnly time_o = new TimeOnly(23,59,59);

            // Instanciando objeto

            var m = new HarleyDavidson();

            int n;
            var r = m.Funcao2(10, 100, out n);
        }
    }
}

namespace IntroducaoCSharp.uteis
{
    class Executiva
    {

    }
}