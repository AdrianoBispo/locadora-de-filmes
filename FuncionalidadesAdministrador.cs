using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora_Platzi
{
    public class FuncionalidadesAdministrador
    {
        public static void AdicionarFilmes()
        {
            Console.Clear();
            Console.WriteLine("Nome do filme: ");
            string nome = Console.ReadLine();

            Console.WriteLine("\nAno de lançamento: ");
            int anoDeLancamento = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nGênero do filme: ");
            Genero genero;
            Enum.TryParse(Console.ReadLine(), out genero);

            Console.WriteLine("\nAvaliação");
            float avaliacao = float.Parse(Console.ReadLine());

            Console.WriteLine("\nQuantidade");
            int quantidade = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nLançamento: ");
            bool lancamento;
            string lancamentoString = Console.ReadLine();
            if (lancamentoString == "True")
            {
                lancamento = true;
            }
            else
            {
                lancamento = false;
            }

            Filme novoFilme = new Filme(nome, anoDeLancamento, genero, avaliacao, quantidade, lancamento);
            Program.filmes.Add(novoFilme);
        }
    }
}