using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora_Platzi
{
    class Cliente : Usuario
    {   
        public Filme filmeAlugado;
        public Cliente(string nome, string login, string senha) : base(nome, login, senha)
        {
        }
        public override void ExibirTela()
        {

            while (true)
            {    
                Console.Clear();

                Console.WriteLine("Cliente" + Nome + ", seja bem-vindo à locadora de filmes Platzi.");          
                if (filmeAlugado != null)
                    Console.WriteLine("O seu filme alugado é: " + filmeAlugado.nome);
                
                Console.WriteLine ("Seja Bem-Vindo à locadora Platzi!");
                Console.WriteLine("\n");
                Console.WriteLine ("Escolha uma opção:");
                Console.WriteLine ("1 - Listar todos os filmes");
                Console.WriteLine("2 - Listar os filmes por gênero");
                Console.WriteLine("3 - Alugar Filme");
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
                        return;

                    case 1:
                        Locadora_Platzi.FuncionalidadesCliente.ListarFilmes();
                        break;

                    case 2:
                        Locadora_Platzi.FuncionalidadesCliente.ListarPorGenero();
                        break;

                    case 3:
                        FuncionalidadesCliente.AlugarFilmes();
                        break;
              
                }
            }
        }
    }
}