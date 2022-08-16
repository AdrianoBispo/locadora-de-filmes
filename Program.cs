using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_Platzi
{

    enum Genero { Acao, Terror, Comedia, Romance };   

    class Filme 
    {
        public string nome;
        public int anoLancamento;
        public Genero genero;
        public float avaliacao;
        public int quantidade;
        public bool lancamento;

        public Filme(string nome, int anoLancamento, Genero genero, 
                    float avaliacao, int quantidade, bool lancamento)
        {

            this.nome = nome;
            this.anoLancamento = anoLancamento;
            this.genero = genero;
            this.avaliacao = avaliacao;
            this.quantidade = quantidade;
            this.lancamento = lancamento;

        }
    }
    class Program
    { 
        public static List<Filme> filmes = new List<Filme>();

        public static List<Cliente> clientes = new List<Cliente>();
        public static List<Administrador> administradores = new List<Administrador>();
    
        static void Main(string[] args)
    
        {

            InicializarFilmes();
            InicializarUsuarios();

            while (true)
            {    
                Console.Clear();

                Console.WriteLine(clientes[0].Nome + ", seja bem-vindo à locadora de filmes Platzi.");
                if (clientes[0].filmeAlugado != null)
                Console.WriteLine("\n");
                    Console.WriteLine("O seu filme alugado é: " + clientes[0].filmeAlugado.nome);            

                Console.WriteLine ("Seja Bem-Vindo à locadora Platzi!");
                Console.WriteLine("\n");
                Console.WriteLine ("Escolha uma opção:");
                Console.WriteLine ("1 - Listar todos os filmes");
                Console.WriteLine ("0 - Sair");
                Console.WriteLine ("\n");


                int escolha = 0;
                Int32.TryParse(Console.ReadLine(), out escolha);

                switch (escolha)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Obrigado por nos visitar!");
                        Console.ReadLine();
                        Environment.Exit (0);
                        break;

                    case 1:
                        Locadora_Platzi.FuncionalidadesCliente.ListarFilmes();
                        break;

                    case 2:
                        Locadora_Platzi.FuncionalidadesCliente.ListarPorGenero();
                        break;

                    case 3:
                        Locadora_Platzi.FuncionalidadesCliente.AlugarFilmes();
                        break;
                }
            }
        }

        private static void InicializarFilmes ()
        {
            filmes.Add(new Filme("Matrix", 1999, Genero.Acao, 9.5f, 5, false));
            filmes.Add(new Filme("Matrix Reloaded", 2003, Genero.Acao, 8f, 10, false));
            filmes.Add(new Filme("Matrix Revolutiuons", 2003, Genero.Acao, 6f, 20, false));
            filmes.Add(new Filme("Ghost", 1990, Genero.Romance, 10f, 2, false));
        }
        private static void InicializarUsuarios ()
        {
            clientes.Add(new Cliente("Ruhan", "ruhan", "123"));
            clientes.Add(new Cliente("Paulo", "paulo", "456"));

            administradores.Add(new Administrador("Elda", "elda", "789"));
        }   
    }
}