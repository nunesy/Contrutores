using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {

            Log log = Log.GetInstance();

            log.PropriedadeLog = "Teste instância";

            Log log2 = Log.GetInstance();
            System.Console.WriteLine(log2.PropriedadeLog);


            //Pessoa p1 = new Pessoa();
            //p1.Apresentar();
        }
    }
}