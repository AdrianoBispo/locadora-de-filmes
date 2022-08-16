using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_Platzi
{
    public class FuncionalidadesCliente
    {
        public static void ListarFilmes ()
        {

            Console.Clear();
            Console.WriteLine("Listar todos os filmes");
            Console.WriteLine("\n");

            for (int i = 0; i < Program.filmes.Count; i++)
            {

                Console.WriteLine("--------------------");
                Console.WriteLine("Nome: " + Program.filmes[i].nome);
                Console.WriteLine("Ano de lançamento: " + Program.filmes[i].anoLancamento);
                Console.WriteLine("Gênero: " + Program.filmes[i].genero);
                Console.WriteLine("Avaliação: " + Program.filmes[i].avaliacao);
                Console.WriteLine("Quantidade: " + Program.filmes[i].quantidade);
                Console.WriteLine("É lançamento: " + Program.filmes[i].lancamento);
                Console.WriteLine("----------------------");

            }

            Console.ReadLine();
        }   

        public static void AlugarFilmes()
        {

            Console.Clear();
            Console.WriteLine("Digite o nome do filme: ");
            string nomeDoFilme = Console.ReadLine();

            for (int  i = 0; i < Program.filmes.Count; i++)
            {
                if (Program.filmes[i].nome == nomeDoFilme)
                {
                    if (Program.clientes[0].filmeAlugado != null)
                    {
                        Program.clientes[0].filmeAlugado.quantidade++;
                    }

                    Program.clientes[0].filmeAlugado = Program.filmes[i];
                    Program.filmes[i].quantidade--;

                    Console.WriteLine("Filme alugado com sucesso!");
                    Console.ReadLine();
                    return;
                }
            }

            Console.WriteLine("A locadora não possui o filme buscado.");
        }

        public static void ListarPorGenero()
        {
            Console.Clear();
            Console.WriteLine("Digite o gênero do filme: ");
            string generoDoFilme = Console.ReadLine();

            for (int i = 0; i < Program.filmes.Count; i++)
            {
                if (Program.filmes[i].genero.ToString() == generoDoFilme)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("Nome: " + Program.filmes[i].nome);
                    Console.WriteLine("Ano de lançamento: " + Program.filmes[i].anoLancamento);
                    Console.WriteLine("Gênero: " + Program.filmes[i].genero);
                    Console.WriteLine("Avaliação: " + Program.filmes[i].avaliacao);
                    Console.WriteLine("Quantidade: " + Program.filmes[i].quantidade);
                    Console.WriteLine("É lançamento: " + Program.filmes[i].lancamento);
                    Console.WriteLine("----------------------");

                }

            }

            Console.WriteLine("Pressione Enter para prosseguir");
            Console.ReadLine();
        }
    }
}