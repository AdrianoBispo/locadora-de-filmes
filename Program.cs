using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora_Platzi {   

    struct Filme {
        public string nome;
        public int anoLancamento;
        public string genero;
        public float avaliacao;
        public int quantidade;
        public bool lancamento;
    }

    class Program { 
        public static Filme unicoFilme;

        static void Main(string[] args) {
            unicoFilme = new Filme();
            unicoFilme.nome = "Matrix";
            unicoFilme.anoLancamento = 1999;
            unicoFilme.genero = "Ação";
            unicoFilme.avaliacao = 9.5f;
            unicoFilme.quantidade = 5;
            unicoFilme.lancamento = false;

            Console.WriteLine ("Seja Bem-Vindo à locadora Platzi!");
            Console.WriteLine ("Por enquanto, este é o nosso único filme:");
            
            Console.WriteLine("Nome: " + unicoFilme.nome);
            Console.WriteLine("Ano de Lançamento: " + unicoFilme.anoLancamento);
            Console.WriteLine("Gênero: " + unicoFilme.genero);
            Console.WriteLine("Avaliação: " + unicoFilme.avaliacao);
            Console.WriteLine("Quantidade: " + unicoFilme.quantidade);
            Console.WriteLine("Lançamento: " + unicoFilme.lancamento);
            
            Console.WriteLine("\n");

            if (unicoFilme.lancamento) {
                Console.WriteLine("O filme é um lançamento.");
            }

            else {
                Console.WriteLine("O filme não é um lançamento.");
            }

            if (unicoFilme.avaliacao < 7 && unicoFilme.avaliacao >= 4) {
                Console.WriteLine("O filme não é tão bom.");
            }

            if (unicoFilme.avaliacao < 4) {
                Console.WriteLine("O filme é ruim!");
            }

            else if (unicoFilme.avaliacao >= 7 && unicoFilme.avaliacao < 9) {
                Console.WriteLine("O filme é bom!");
            }

            else {
                Console.WriteLine("O filme é fantástico");
            }

            Console.ReadLine();
            
        }
    }
}