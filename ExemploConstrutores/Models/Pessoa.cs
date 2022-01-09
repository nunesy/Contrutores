using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private readonly string nome = "Yuri";
        private readonly string sobrenome;
        //Exemplo de construtor sem parâmetros
        public Pessoa()
        {
            nome = string.Empty;
            sobrenome = string.Empty;
        }
        //Exemplo de construtor com parâmentros
        public Pessoa(string nome, string sobrenome)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor classe pessoa");
            
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá meu nome é: {nome} {sobrenome}");
        }
    }
}