using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora_Platzi {
    class Cliente {
        public string nome;
        public Filme filmeAlugado;

        public Cliente(string nome, Filme filmeAlugado) {
            this.nome = nome;
            this.filmeAlugado = filmeAlugado;
        }

    }
}