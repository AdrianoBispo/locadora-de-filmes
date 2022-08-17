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
    }
}