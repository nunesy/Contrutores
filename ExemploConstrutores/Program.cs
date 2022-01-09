using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {


            Matematica m = new Matematica(10 , 20);
            m.Somar();

            //formas de passar os métodos para o DELEGATE a 1ª sem o "new" e a 2ª com
            //Operacao op = Calculadora.Somar;
            // Operacao op = new Operacao(Calculadora.Somar);
            // op += Calculadora.Subtrair;
            // op += Calculadora.Multiplicar;
            // op += Calculadora.Dividir;

            // //formas de invocar o DELEGATE

            // op.Invoke(10, 5);
            // //op(10, 10);



            //const double pi = 3.14;
            //System.Console.WriteLine(pi);

            //Data data = new Data();
            //data.SetMes(20);

            //data.Mes = 12;
            //System.Console.WriteLine(data.Mes);

            //data.ApresentarMes();

            // Log log = Log.GetInstance();

            // log.PropriedadeLog = "Teste instância";

            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);


            // Aluno p1 = new Aluno("Yuri", "Nunes", "Teste");
            // p1.Apresentar();
        }
    }
}