using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        //Delegate
        public delegate void DelegateCalculadora();

        //Evento
        public static event DelegateCalculadora EventoCalculadora;
        public static void Somar(int x, int y)
        {
            if (EventoCalculadora != null)
            {
                System.Console.WriteLine($"Adição: {x + y}");
                EventoCalculadora();
            }
            else
            {
                System.Console.WriteLine("Nenhum Inscrito");
            }
            
        }

        // public static void Subtrair(int x, int y)
        // {
        //     System.Console.WriteLine($"Subtração: {x - y}");
        // }

        // public static void Multiplicar(int x, int y)
        // {
        //     System.Console.WriteLine($"Multiplicação: {x * y}");
        // }

        // public static void Dividir(int x, int y)
        // {
        //     System.Console.WriteLine($"Divisão: {x / y}");
        // }
    }
}