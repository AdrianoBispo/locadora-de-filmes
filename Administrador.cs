using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora_Platzi
{
    public class Administrador : Usuario
    {
        public Administrador(string nome, string login, string senha) : base(nome, login, senha)
        {
        }
    }
}