using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora_Platzi
{   
    public class Program
    {
        public static void Main(string[] args)
        {
            string nome = "Matrix";
            int anoLancamento = 1998;
            string genero = "Ação";
            float avaliacao = 9.5f;
            int quantidade = 5;
            bool lancamento = false;
            
            Console.WriteLine ("Seja Bem-Vindo à locadora Platzi!");
            Console.WriteLine ("Por enquanto, este é o nosso único filme:");
            
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Ano de Lançamento: " + anoLancamento);
            Console.WriteLine("Gênero: " + genero);
            Console.WriteLine("Avaliação: " + avaliacao);
            Console.WriteLine("Quantidade: " + quantidade);
            Console.WriteLine("Lançamento: " + lancamento);
            
            Console.ReadLine();
            
        }
    }
}