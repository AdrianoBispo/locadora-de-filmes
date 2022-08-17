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

        public static List<Usuario> usuarios = new List<Usuario>();
        public static List<Cliente> clientes = new List<Cliente>();
        public static List<Administrador> administradores = new List<Administrador>();

        public static Usuario usuarioLogado;
    
        static void Main(string[] args)
    
        {

            InicializarFilmes();
            InicializarUsuarios();

            Console.WriteLine("Login: ");
            string login = Console.ReadLine();

            Console.WriteLine("Senha: ");
            string senha = Console.ReadLine();

            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].Login == login && usuarios[i].Senha == senha)
                {
                    usuarioLogado = usuarios[i];
                } 
            }

            usuarioLogado.ExibirTela();
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

            for (int i = 0; i < clientes.Count; i++)
            {
                usuarios.Add(clientes[i]);
            }

            for (int i = 0; i < administradores.Count; i++)
            {
                usuarios.Add(administradores[i]);
            }
        }   
    }
}