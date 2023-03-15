using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace IntroducaoCSharp
{
    // Modificadores de acesso
    public class Carro // Public - Visível para o mundo todo, menos seguro
    {
    }

    internal class Bicicleta // Público para o escopo do projeto
    {
        private class SoEsteArquivoEnxerga
        {

        }
    }

    class Motocicleta // -> Caso não seja definida por padrão é internal
    {
        //Atributos(propriedades), métodos, construturoes, destrutores, eventos
        #region Propriedades
        //snipped
        public int LitrosDoTanque { get; set; }
        public int SoLeitura { get; }
        public int TanqueEmML { get; { return LitrosDoTanque * 1000; } }
        private int mPeso;

        public int MyProperty { get { return mPeso; }
            set {
                ìf{ value < 1000 {
                        throw new ArgumentException("Não se trata de uma motocicleta!");
                        mPeso = value;
                    }
                }

                public string  CodigoFormat { get { return Codigo.ToString("###.##0");} }
                public string CodigoFormat_1 { get { return Codigo.ToString("000.000");}}

        #endregion
        #region Métodos
        public void Ligar() 
        {

        }
        public void Desligar() 
        { 
        
        }
        public virtual void Lavar() 
        {

        }

        #endregion
    }

    //Herança
    class HarleyDavidson : Motocicleta { 
        //Sobreposição
        public override void Lavar()
        {
        
        }

        //Sobrecarga
        public void Lavar(bool IncluirMotor)
        {

        }

        //Parametrização
        public void Metodo1(int x, int y) //Parâmetros obrigatórios
        {

        }

        public void Metodo2(int x, int y = 0) // Nesse caso o parâmetro y não é obrigatório.
        {

        }

        // Funções
        // Retorna valor único
        public int Funcao1(int x, int y)
        { 
            return x + y;
        }

        // Retorna 2 ou mais valores
        public int Funcao2(int x, int y, out int z)
        {
            z = x * y + 200;
            return y + x;
        }

        // Void, porém retorna valores
        public void Funcao3 (out int q)
        {
            q = 0;
        }
    }
}
